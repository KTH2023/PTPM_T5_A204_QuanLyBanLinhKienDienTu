
namespace DoAn.FRM
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, null, true, true);
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.fluentDesignFormContainer1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.btnHome = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnManagerment = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnProduct = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnNhanVien = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnKhachHang = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnReceipt = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnOrder = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnStaffCustomer = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnBanHang = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnNhapHang = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnCustomerOfStaff = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnStatistical = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnTurnover = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnInventory = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnTopStaffCustomer = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnPredictNextDay = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.lbTieuDe = new DevExpress.XtraBars.BarHeaderItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnDoiMK = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.lbAccount = new DevExpress.XtraBars.BarHeaderItem();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // splashScreenManager1
            // 
            splashScreenManager1.ClosingDelay = 500;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // fluentDesignFormContainer1
            // 
            this.fluentDesignFormContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fluentDesignFormContainer1.Location = new System.Drawing.Point(260, 53);
            this.fluentDesignFormContainer1.Name = "fluentDesignFormContainer1";
            this.fluentDesignFormContainer1.Size = new System.Drawing.Size(427, 392);
            this.fluentDesignFormContainer1.TabIndex = 0;
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btnHome,
            this.btnManagerment,
            this.btnStaffCustomer,
            this.btnStatistical});
            this.accordionControl1.Location = new System.Drawing.Point(0, 53);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(260, 392);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // btnHome
            // 
            this.btnHome.Name = "btnHome";
            this.btnHome.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnHome.Text = "Trang chủ";
            // 
            // btnManagerment
            // 
            this.btnManagerment.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btnProduct,
            this.btnNhanVien,
            this.btnKhachHang,
            this.btnReceipt,
            this.btnOrder});
            this.btnManagerment.Expanded = true;
            this.btnManagerment.Name = "btnManagerment";
            this.btnManagerment.Text = "Quản lý";
            // 
            // btnProduct
            // 
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnProduct.Text = "Linh kiện";
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnNhanVien.Text = "Nhân viên";
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnKhachHang.Text = "Khách hàng";
            // 
            // btnReceipt
            // 
            this.btnReceipt.Name = "btnReceipt";
            this.btnReceipt.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnReceipt.Text = "Phiếu nhập";
            // 
            // btnOrder
            // 
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnOrder.Text = "Hoá đơn";
            // 
            // btnStaffCustomer
            // 
            this.btnStaffCustomer.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btnBanHang,
            this.btnNhapHang,
            this.btnCustomerOfStaff});
            this.btnStaffCustomer.Expanded = true;
            this.btnStaffCustomer.Name = "btnStaffCustomer";
            this.btnStaffCustomer.Text = "Khách hàng";
            // 
            // btnBanHang
            // 
            this.btnBanHang.Name = "btnBanHang";
            this.btnBanHang.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnBanHang.Text = "Bán hàng";
            // 
            // btnNhapHang
            // 
            this.btnNhapHang.Name = "btnNhapHang";
            this.btnNhapHang.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnNhapHang.Text = "Nhập hàng";
            // 
            // btnCustomerOfStaff
            // 
            this.btnCustomerOfStaff.Name = "btnCustomerOfStaff";
            this.btnCustomerOfStaff.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnCustomerOfStaff.Text = "Quản lý khách hàng";
            // 
            // btnStatistical
            // 
            this.btnStatistical.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btnTurnover,
            this.btnInventory,
            this.btnTopStaffCustomer,
            this.btnPredictNextDay});
            this.btnStatistical.Expanded = true;
            this.btnStatistical.Name = "btnStatistical";
            this.btnStatistical.Text = "Thống kê - Dự đoán";
            // 
            // btnTurnover
            // 
            this.btnTurnover.Name = "btnTurnover";
            this.btnTurnover.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnTurnover.Text = "Doanh thu";
            // 
            // btnInventory
            // 
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnInventory.Text = "Tồn kho";
            // 
            // btnTopStaffCustomer
            // 
            this.btnTopStaffCustomer.Name = "btnTopStaffCustomer";
            this.btnTopStaffCustomer.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnTopStaffCustomer.Text = "Top khách hàng, nhân viên";
            // 
            // btnPredictNextDay
            // 
            this.btnPredictNextDay.Name = "btnPredictNextDay";
            this.btnPredictNextDay.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnPredictNextDay.Text = "Dự báo doanh thu";
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.lbTieuDe});
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(687, 29);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            this.fluentDesignFormControl1.TitleItemLinks.Add(this.lbTieuDe);
            // 
            // lbTieuDe
            // 
            this.lbTieuDe.Caption = "lbTieuDe";
            this.lbTieuDe.Id = 1;
            this.lbTieuDe.Name = "lbTieuDe";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnDoiMK,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.lbAccount});
            this.barManager1.MaxItemId = 5;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDoiMK, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem3)});
            this.bar1.Text = "Tools";
            // 
            // btnDoiMK
            // 
            this.btnDoiMK.Caption = "Đổi mật khẩu";
            this.btnDoiMK.Id = 0;
            this.btnDoiMK.Name = "btnDoiMK";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Backup";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Restore";
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Đăng xuất";
            this.barButtonItem3.Id = 3;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.lbAccount)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 29);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(687, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 445);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(687, 26);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 53);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 392);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(687, 53);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 392);
            // 
            // lbAccount
            // 
            this.lbAccount.Caption = "NV";
            this.lbAccount.Id = 4;
            this.lbAccount.Name = "lbAccount";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 471);
            this.ControlContainer = this.fluentDesignFormContainer1;
            this.Controls.Add(this.fluentDesignFormContainer1);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.Name = "frmMain";
            this.NavigationControl = this.accordionControl1;
            this.Text = "Phần mềm quản lý bán linh kiện điện tử";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentDesignFormContainer1;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnHome;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.BarHeaderItem lbTieuDe;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnDoiMK;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnManagerment;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnProduct;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnNhanVien;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnKhachHang;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnReceipt;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnOrder;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnStaffCustomer;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnBanHang;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnNhapHang;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnCustomerOfStaff;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnStatistical;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnTurnover;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnInventory;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnTopStaffCustomer;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnPredictNextDay;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraBars.BarHeaderItem lbAccount;
    }
}