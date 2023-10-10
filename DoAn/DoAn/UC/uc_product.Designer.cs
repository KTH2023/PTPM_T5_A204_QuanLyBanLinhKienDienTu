namespace GUI.UC
{
    partial class uc_product
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_product));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnExcel = new DevExpress.XtraBars.BarButtonItem();
            this.btnWord = new DevExpress.XtraBars.BarButtonItem();
            this.btnPdf = new DevExpress.XtraBars.BarButtonItem();
            this.btnClose = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.repositoryItemImageEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gcProduct = new DevExpress.XtraGrid.GridControl();
            this.gvProduct = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lkLoaiLK = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.imgHinhAnh = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pictureImage = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.repositoryItemPictureEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.gcTypeProduct = new DevExpress.XtraGrid.GridControl();
            this.gvTypeProduct = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkLoaiLK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHinhAnh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit2)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcTypeProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTypeProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnClose,
            this.btnDelete,
            this.btnXoa,
            this.btnExcel,
            this.btnWord,
            this.btnPdf});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 15;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageEdit1,
            this.repositoryItemPictureEdit1,
            this.repositoryItemImageComboBox1});
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnXoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnExcel, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnWord, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPdf, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnClose, true)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xoá";
            this.btnXoa.Id = 5;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnExcel
            // 
            this.btnExcel.Caption = "Xuất excel";
            this.btnExcel.Id = 12;
            this.btnExcel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.ImageOptions.Image")));
            this.btnExcel.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnExcel.ImageOptions.LargeImage")));
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnWord
            // 
            this.btnWord.Caption = "Xuất word";
            this.btnWord.Id = 13;
            this.btnWord.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnWord.ImageOptions.Image")));
            this.btnWord.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnWord.ImageOptions.LargeImage")));
            this.btnWord.Name = "btnWord";
            this.btnWord.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnPdf
            // 
            this.btnPdf.Caption = "Xuất pdf";
            this.btnPdf.Id = 14;
            this.btnPdf.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPdf.ImageOptions.Image")));
            this.btnPdf.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPdf.ImageOptions.LargeImage")));
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnClose
            // 
            this.btnClose.Caption = "Đóng";
            this.btnClose.Id = 3;
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.LargeImage")));
            this.btnClose.Name = "btnClose";
            this.btnClose.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(937, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 598);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(937, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 558);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(937, 40);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 558);
            // 
            // btnDelete
            // 
            this.btnDelete.Caption = "Xoá";
            this.btnDelete.Id = 4;
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.LargeImage")));
            this.btnDelete.Name = "btnDelete";
            // 
            // repositoryItemImageEdit1
            // 
            this.repositoryItemImageEdit1.AutoHeight = false;
            this.repositoryItemImageEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageEdit1.Name = "repositoryItemImageEdit1";
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            // 
            // repositoryItemImageComboBox1
            // 
            this.repositoryItemImageComboBox1.AutoHeight = false;
            this.repositoryItemImageComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 40);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(937, 558);
            this.xtraTabControl1.TabIndex = 4;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.pictureBox1);
            this.xtraTabPage1.Controls.Add(this.gcProduct);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(930, 520);
            this.xtraTabPage1.Text = "Linh kiện";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(916, 225);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 11);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // gcProduct
            // 
            this.gcProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcProduct.Location = new System.Drawing.Point(0, 0);
            this.gcProduct.MainView = this.gvProduct;
            this.gcProduct.MenuManager = this.barManager1;
            this.gcProduct.Name = "gcProduct";
            this.gcProduct.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lkLoaiLK,
            this.pictureImage,
            this.repositoryItemPictureEdit2,
            this.imgHinhAnh});
            this.gcProduct.Size = new System.Drawing.Size(930, 520);
            this.gcProduct.TabIndex = 0;
            this.gcProduct.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvProduct});
            // 
            // gvProduct
            // 
            this.gvProduct.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn9,
            this.gridColumn6});
            this.gvProduct.DetailHeight = 368;
            this.gvProduct.GridControl = this.gcProduct;
            this.gvProduct.Name = "gvProduct";
            this.gvProduct.OptionsDetail.EnableMasterViewMode = false;
            this.gvProduct.OptionsFind.AlwaysVisible = true;
            this.gvProduct.OptionsFind.Condition = DevExpress.Data.Filtering.FilterCondition.Contains;
            this.gvProduct.OptionsFind.FindDelay = 100;
            this.gvProduct.OptionsFind.FindNullPrompt = "Tìm kiếm tại đây...";
            this.gvProduct.OptionsFind.SearchInPreview = true;
            this.gvProduct.OptionsFind.ShowFindButton = false;
            this.gvProduct.OptionsView.ShowGroupPanel = false;

            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên linh kiện";
            this.gridColumn2.FieldName = "TENLINHKIEN";
            this.gridColumn2.MinWidth = 30;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 168;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "LOẠI";
            this.gridColumn3.ColumnEdit = this.lkLoaiLK;
            this.gridColumn3.FieldName = "MALOAI";
            this.gridColumn3.MinWidth = 30;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 168;
            // 
            // lkLoaiLK
            // 
            this.lkLoaiLK.AutoHeight = false;
            this.lkLoaiLK.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkLoaiLK.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MALOAI", "Mã loại"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TENLOAI", "Tên loại")});
            this.lkLoaiLK.Name = "lkLoaiLK";
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Hãng sản xuất";
            this.gridColumn4.FieldName = "HANGSX";
            this.gridColumn4.MinWidth = 30;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            this.gridColumn4.Width = 168;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Dơn giá";
            this.gridColumn5.FieldName = "DONGIA";
            this.gridColumn5.MinWidth = 30;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 3;
            this.gridColumn5.Width = 168;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Hình ảnh";
            this.gridColumn9.ColumnEdit = this.imgHinhAnh;
            this.gridColumn9.FieldName = "HINHANH";
            this.gridColumn9.MinWidth = 30;
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 4;
            this.gridColumn9.Width = 92;
            // 
            // imgHinhAnh
            // 
            this.imgHinhAnh.AutoHeight = false;
            this.imgHinhAnh.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.imgHinhAnh.Name = "imgHinhAnh";
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Số lượng còn";
            this.gridColumn6.FieldName = "SOLUONGCON";
            this.gridColumn6.MinWidth = 30;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            this.gridColumn6.Width = 143;
            // 
            // pictureImage
            // 
            this.pictureImage.InitialImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("pictureImage.InitialImageOptions.Image")));
            this.pictureImage.Name = "pictureImage";
            // 
            // repositoryItemPictureEdit2
            // 
            this.repositoryItemPictureEdit2.InitialImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("repositoryItemPictureEdit2.InitialImageOptions.Image")));
            this.repositoryItemPictureEdit2.Name = "repositoryItemPictureEdit2";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.gcTypeProduct);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(930, 520);
            this.xtraTabPage2.Text = "Loại linh kiện";
            // 
            // gcTypeProduct
            // 
            this.gcTypeProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcTypeProduct.Location = new System.Drawing.Point(0, 0);
            this.gcTypeProduct.MainView = this.gvTypeProduct;
            this.gcTypeProduct.MenuManager = this.barManager1;
            this.gcTypeProduct.Name = "gcTypeProduct";
            this.gcTypeProduct.Size = new System.Drawing.Size(930, 520);
            this.gcTypeProduct.TabIndex = 0;
            this.gcTypeProduct.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTypeProduct});
            // 
            // gvTypeProduct
            // 
            this.gvTypeProduct.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn8});
            this.gvTypeProduct.DetailHeight = 368;
            this.gvTypeProduct.GridControl = this.gcTypeProduct;
            this.gvTypeProduct.Name = "gvTypeProduct";
            this.gvTypeProduct.OptionsDetail.EnableMasterViewMode = false;
            this.gvTypeProduct.OptionsFind.AlwaysVisible = true;
            this.gvTypeProduct.OptionsFind.Condition = DevExpress.Data.Filtering.FilterCondition.Contains;
            this.gvTypeProduct.OptionsFind.FindDelay = 100;
            this.gvTypeProduct.OptionsFind.FindNullPrompt = "Tìm kiếm tại đây...";
            this.gvTypeProduct.OptionsFind.SearchInPreview = true;
            this.gvTypeProduct.OptionsFind.ShowFindButton = false;
            this.gvTypeProduct.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Tên loại";
            this.gridColumn8.FieldName = "TENLOAI";
            this.gridColumn8.MinWidth = 30;
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 0;
            this.gridColumn8.Width = 112;
            // 
            // uc_product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "uc_product";
            this.Size = new System.Drawing.Size(937, 598);
            this.Tag = "Linh kiện";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkLoaiLK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHinhAnh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit2)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcTypeProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTypeProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnClose;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraGrid.GridControl gcProduct;
        private DevExpress.XtraGrid.Views.Grid.GridView gvProduct;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lkLoaiLK;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.GridControl gcTypeProduct;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTypeProduct;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit pictureImage;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageEdit repositoryItemImageEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox1;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageEdit imgHinhAnh;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraBars.BarButtonItem btnExcel;
        private DevExpress.XtraBars.BarButtonItem btnWord;
        private DevExpress.XtraBars.BarButtonItem btnPdf;
    }
}
