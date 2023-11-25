using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class NoronNextDayDAO
    {
        private QL_LinhKienDBDataContext db = new QL_LinhKienDBDataContext();
        //trọng số
        private double wa1, wb1, wc1, wd1, wa2, wb2, wc2, wd2, wa3, wb3, wc3, wd3
                       , wa4, wb4, wc4, wd4, w15, w25, w35, w45;
        //A: ngày 1, B: ngày 2, C: ngày 3, D: ngày 4, Z: kết quả
        private double A, B, C, D, Z;
        //tính hiệu lỗi
        private double ng1, ng2, ng3, ng4, ng5;
        //hệ số hiệu chỉnh bias bằng 1 và hệ số nguy = 1
        private const double n = 1;
        private List<ItemNoronNextDay> lstRevenue;
        private static NoronNextDayDAO instances;
        public static NoronNextDayDAO Instances
        {
            get
            {
                if (instances == null)
                    instances = new NoronNextDayDAO();
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
            lstRevenue = new List<ItemNoronNextDay>();
            DateTime days30Ago = DateTime.Now.AddDays(-29);
            for (DateTime date = days30Ago; date.CompareTo(DateTime.Now) <= 0; date = date.AddDays(1))
            {
                var total = db.HOADONs.Where(x => x.NGAYLAP.CompareTo(date) == 0 && x.ispay == true).Sum(x => x.tongtien) ?? 0;
                lstRevenue.Add(new ItemNoronNextDay()
                {
                    Date = date,
                    Revenue = total,
                    ConvertRevenue = Support.ConvertVND(total.ToString())
                });
            }

            randomWeight();
            for (int j = 0; j < 1000; j++)
            {
                for (int i = 0; i < 22; i++)
                {
                    ReadInput(i);
                    train();
                }
            }
            return Support.ToDataTable<ItemNoronNextDay>(lstRevenue);
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
        //chuẩn hoá dữ liệu về [min,max] của lstStaticalDay
        private double dataNormalization(double x)
        {
            double min = findMin();
            double max = findMax();
            double result = (x - min) / (max - min);
            return Math.Round(result, 6);
        }
        //đọc dữ liệu đầu vào và kết quả mong muốn
        private void ReadInput(int day)
        {
            A = lstRevenue[day].Revenue ?? 0;
            //chuẩn hoá dữ liệu A
            A = Math.Round(dataNormalization(A), 6);

            B = lstRevenue[day + 1].Revenue ?? 0;
            //chuẩn hoá dữ liệu B
            B = Math.Round(dataNormalization(B), 6);

            C = lstRevenue[day + 2].Revenue ?? 0;
            //chuẩn hoá dữ liệu C
            C = Math.Round(dataNormalization(C), 6);


            D = lstRevenue[day + 3].Revenue ?? 0;
            //chuẩn hoá dữ liệu D
            D = Math.Round(dataNormalization(D), 6);
            if (day + 4 > 29)
                return;
            Z = lstRevenue[day + 4].Revenue ?? 0;
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
        private double findT(double wa, double wb, double wc, double wd)
        {
            double t = (A * wa) + (B * wb) + (C * wc) + (D * wd) + n;
            return Math.Round(t, 6);
        }
        //tìm t cho nơron
        private double findT(double a, double b, double c, double d, double wa, double wb, double wc, double wd)
        {
            double t = (a * wa) + (b * wb) + (c * wc) + (d * wd) + n;
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
            wc1 = GetRandomNumber(0, 1);
            wd1 = GetRandomNumber(0, 1);
            //
            wa2 = GetRandomNumber(0, 1);
            wb2 = GetRandomNumber(0, 1);
            wc2 = GetRandomNumber(0, 1);
            wd2 = GetRandomNumber(0, 1);
            //
            wa3 = GetRandomNumber(0, 1);
            wb3 = GetRandomNumber(0, 1);
            wc3 = GetRandomNumber(0, 1);
            wd3 = GetRandomNumber(0, 1);
            //
            wa4 = GetRandomNumber(0, 1);
            wb4 = GetRandomNumber(0, 1);
            wc4 = GetRandomNumber(0, 1);
            wd4 = GetRandomNumber(0, 1);
            //
            w15 = GetRandomNumber(0, 1);
            w25 = GetRandomNumber(0, 1);
            w35 = GetRandomNumber(0, 1);
            w45 = GetRandomNumber(0, 1);
        }

        //train dữ liệu 
        private void train()
        {
            //Tính nơron 1
            double t1 = findT(wa1, wb1, wc1, wd1);
            double y1 = Sigmoid(t1);

            //tính nơron 2
            double t2 = findT(wa2, wb2, wc2, wd2);
            double y2 = Sigmoid(t2);

            //tính nơron 3
            double t3 = findT(wa3, wb3, wc3, wd3);
            double y3 = Sigmoid(t3);

            //tính nơron 4
            double t4 = findT(wa4, wb4, wc4, wd4);
            double y4 = Sigmoid(t4);

            //tính nơron 5
            double t5 = findT(y1, y2, y3, y4, w15, w25, w35, w45);
            double y5 = Sigmoid(t5);
            //tính tính hiệu lỗi ( nguy) của nơron 5
            ng5 = Math.Round(Z - y5, 6);

            //tính tính hiệu lỗi ( nguy) của nơron 1
            ng1 = Math.Round(ng5 * w15, 6);

            //tính tính hiệu lỗi ( nguy) của nơron 2
            ng2 = Math.Round(ng5 * w25, 6);

            //tính tính hiệu lỗi ( nguy) của nơron 3
            ng3 = Math.Round(ng5 * w35, 6);

            //tính tính hiệu lỗi ( nguy) của nơron 4
            ng4 = Math.Round(ng5 * w45, 6);
            //tính lại trọng số            
            wa1 = CalcWeight(A, wa1, ng1, t1);
            wb1 = CalcWeight(B, wb1, ng1, t1);
            wc1 = CalcWeight(C, wc1, ng1, t1);
            wd1 = CalcWeight(D, wd1, ng1, t1);
            //
            wa2 = CalcWeight(A, wa2, ng2, t2);
            wb2 = CalcWeight(B, wb2, ng2, t2);
            wc2 = CalcWeight(C, wc2, ng2, t2);
            wd2 = CalcWeight(D, wd2, ng2, t2);
            //
            wa3 = CalcWeight(A, wa3, ng3, t3);
            wb3 = CalcWeight(B, wb3, ng3, t3);
            wc3 = CalcWeight(C, wc3, ng3, t3);
            wd3 = CalcWeight(D, wd3, ng3, t3);
            //
            wa4 = CalcWeight(A, wa4, ng4, t4);
            wb4 = CalcWeight(B, wb4, ng4, t4);
            wc4 = CalcWeight(C, wc4, ng4, t4);
            wd4 = CalcWeight(D, wd4, ng4, t4);
            //
            w15 = CalcWeight(y1, w15, ng5, t5);
            w25 = CalcWeight(y2, w25, ng5, t5);
            w35 = CalcWeight(y3, w35, ng5, t5);
            w45 = CalcWeight(y4, w45, ng5, t5);
        }


        //dự đoán doanh thu ngày kế tiếp
        private double predict()
        {
            //Tính nơron 1
            double t1 = findT(wa1, wb1, wc1, wd1);
            double y1 = Sigmoid(t1);

            //Tính nơron 2
            double t2 = findT(wa2, wb2, wc2, wd2);
            double y2 = Sigmoid(t2);

            //Tính nơron 3
            double t3 = findT(wa3, wb3, wc3, wd3);
            double y3 = Sigmoid(t3);

            //Tính nơron 4
            double t4 = findT(wa4, wb4, wc4, wd4);
            double y4 = Sigmoid(t4);
            //Tính nơron 5
            double t5 = findT(y1, y2, y3, y4, w15, w25, w35, w45);
            double y5 = Sigmoid(t5);
            return Math.Round(y5, 6);
        }

        //trả kết quả cuối cùng
        public double ReturnResult()
        {
            ReadInput(26);
            double min = findMin();
            double max = findMax();
            double result = predict() * (max - min) + min;
            return Math.Round(result, 6);
        }
    }
}

