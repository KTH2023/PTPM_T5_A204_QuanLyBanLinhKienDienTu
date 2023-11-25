using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class NoronNextMonthDAO
    {
        private QL_LinhKienDBDataContext db = new QL_LinhKienDBDataContext();
        //trọng số
        private double wa1, wb1, wa2, wb2, w13, w23;
        //A: tháng 1, B: tháng 2,Z: kết quả
        private double A, B, Z;
        //tính hiệu lỗi
        private double ng1, ng2, ng3;
        //hệ số hiệu chỉnh bias bằng 1 và hệ số nguy = 1
        private double n = 1;
        private List<ItemNoronNextMonth> lstRevenue;
        private static NoronNextMonthDAO instances;
        public static NoronNextMonthDAO Instances
        {
            get
            {
                if (instances == null)
                    instances = new NoronNextMonthDAO();
                return instances;
            }
        }
        public double GetRandomNumber(double minimum, double maximum)
        {
            Random random = new Random();
            return random.NextDouble() * (maximum - minimum) + minimum;
        }
        public dynamic loadDataGC()
        {
            lstRevenue = new List<ItemNoronNextMonth>();
            DateTime months12Ago = DateTime.Now.AddMonths(-11);
            for (DateTime date = months12Ago; date.CompareTo(DateTime.Now) <= 0; date = date.AddMonths(1))
            {
                var total = db.HOADONs.Where(x => x.NGAYLAP.Month == date.Month && x.NGAYLAP.Year == date.Year && x.ispay == true).Sum(x => x.tongtien) ?? 0;
                lstRevenue.Add(new ItemNoronNextMonth()
                {
                    Month = date.Month + "/" + date.Year,
                    Revenue = total,
                    ConvertRevenue = Support.ConvertVND(total.ToString())
                });
            }

            randomWeight();
            for (int j = 0; j < 1000; j++)

                for (int i = 0; i < 8; i++)
                {
                    ReadInput(i);
                    train();
                }
            return Support.ToDataTable<ItemNoronNextMonth>(lstRevenue);
        }
        //tìm doanh thu lớn nhất
        private double findMax()
        {
            return Math.Round(lstRevenue.Max(x => x.Revenue) ?? 0, 6);
        }
        //tìm doanh thu nhỏ nhất
        private double findMin()
        {
            return Math.Round(lstRevenue.Min(x => x.Revenue) ?? 0, 6);

        }
        //chuẩn hoá dữ liệu về [0,1] của lstStaticalDay
        private double dataNormalization(double x)
        {
            double min = findMin();
            double max = findMax();
            double result = (x - min) / (max - min);
            return Math.Round(result, 6);
        }
        //đọc dữ liệu đầu vào và kết quả mong muốn
        private void ReadInput(int month)
        {
            A = lstRevenue[month].Revenue ?? 0;
            //chuẩn hoá dữ liệu A
            A = Math.Round(dataNormalization(A), 6);

            B = lstRevenue[month + 1].Revenue ?? 0;
            //chuẩn hoá dữ liệu B
            B = Math.Round(dataNormalization(B), 6);
            if (month + 2 > 11)
                return;
            Z = lstRevenue[month + 2].Revenue ?? 0;
            //chuẩn hoá dữ liệu Z
            Z = Math.Round(dataNormalization(Z), 6);
        }

        private static double Sigmoid(double t)
        {
            return Math.Round(1.0 / (1 + Math.Pow(Math.E, -t)), 6);
        }

        private static double derivative_Sigmoid(double t)
        {
            return Math.Round(Math.Pow(Math.E, t) / Math.Pow(1.0 + Math.Pow(Math.E, t), 2), 6);
        }
        //tìm t cho nơron
        private double findT(double wa, double wb)
        {
            double t = (A * wa) + (B * wb) + n;
            return Math.Round(t, 6);
        }
        //tìm t cho nơron
        private double findT(double a, double b, double wa, double wb)
        {
            double t = (a * wa) + (b * wb) + n;
            return Math.Round(t, 6);
        }
        //tính trọng số cho 1 nơron
        private double CalcWeight(double a, double w, double ng, double t)
        {
            return Math.Round((double)(w + n * ng * derivative_Sigmoid(t) * a), 6);
        }

        //random trọng số
        private void randomWeight()
        {
            Random r = new Random();
            wa1 = GetRandomNumber(0, 1);
            wb1 = GetRandomNumber(0, 1);
            //
            wa2 = GetRandomNumber(0, 1);
            wb2 = GetRandomNumber(0, 1);
            //            
            w13 = GetRandomNumber(0, 1);
            w23 = GetRandomNumber(0, 1);
        }

        //train dữ liệu 
        private void train()
        {
            //Tính nơron 1
            double t1 = findT(wa1, wb1);
            double y1 = Sigmoid(t1);

            //tính nơron 2
            double t2 = findT(wa2, wb2);
            double y2 = Sigmoid(t2);

            //tính nơron 3
            double t3 = findT(y1, y2, w13, w23);
            double y3 = Sigmoid(t3);
            //tính tính hiệu lỗi ( nguy) của nơron 3
            ng3 = Math.Round(Z - y3, 6);

            //tính tính hiệu lỗi ( nguy) của nơron 1
            ng1 = Math.Round(ng3 * w13, 6);

            //tính tính hiệu lỗi ( nguy) của nơron 2
            ng2 = Math.Round(ng3 * w23, 6);

            //tính lại trọng số            
            wa1 = CalcWeight(A, wa1, ng1, t1);
            wb1 = CalcWeight(B, wb1, ng1, t1);
            //
            wa2 = CalcWeight(A, wa2, ng2, t2);
            wb2 = CalcWeight(B, wb2, ng2, t2);
            //
            w13 = CalcWeight(y1, w13, ng3, t3);
            w23 = CalcWeight(y2, w23, ng3, t3);
        }


        //dự đoán doanh thu tháng kế tiếp
        private double predict()
        {
            //Tính nơron 1
            double t1 = findT(wa1, wb1);
            double y1 = Sigmoid(t1);

            //Tính nơron 2
            double t2 = findT(wa2, wb2);
            double y2 = Sigmoid(t2);

            //Tính nơron 3
            double t3 = findT(y1, y2, w13, w23);
            double y3 = Sigmoid(t3);
            return Math.Round(y3, 6);
        }

        //trả kết quả cuối cùng
        public double ReturnResult()
        {
            ReadInput(10);
            double min = findMin();
            double max = findMax();
            double result = predict() * (max - min) + min;
            return Math.Round(result, 6);
        }
    }
}
