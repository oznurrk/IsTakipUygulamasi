namespace IsTakipUygulamasi
{
    partial class Form1
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.ısTakipTanimBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bIMSERDataSet = new IsTakipUygulamasi.BIMSERDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gv_IsTakipTanim_rowid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gv_TicketNumarasi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gv_Musteri = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbpMusteri = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.musteriTanimBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gv_Konu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gv_Aciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtsAciklama = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.gv_UstAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gv_Sorumlu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbpSorumlu = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.sorumluTanimBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gv_PlanlamaTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dtPlanlamaTarihi = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.gv_TamamlamaTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dtTamamlamaTarihi = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.gv_Durum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbsDurum = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.gv_MailGonder = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnMailGonder = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.txtSearch = new DevExpress.XtraEditors.TextEdit();
            this.musteriTanimTableAdapter = new IsTakipUygulamasi.BIMSERDataSetTableAdapters.MusteriTanimTableAdapter();
            this.sorumluTanimTableAdapter = new IsTakipUygulamasi.BIMSERDataSetTableAdapters.SorumluTanimTableAdapter();
            this.isTakipTanimTableAdapter = new IsTakipUygulamasi.BIMSERDataSetTableAdapters.IsTakipTanimTableAdapter();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ısTakipTanimBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bIMSERDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbpMusteri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriTanimBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsAciklama)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbpSorumlu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sorumluTanimBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPlanlamaTarihi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPlanlamaTarihi.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTamamlamaTarihi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTamamlamaTarihi.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbsDurum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMailGonder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.ısTakipTanimBindingSource;
            this.gridControl1.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControl1.EmbeddedNavigator.TextStringFormat = "Sayfa {0} / {1}";
            this.gridControl1.Location = new System.Drawing.Point(0, 28);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmbpMusteri,
            this.cmbpSorumlu,
            this.dtPlanlamaTarihi,
            this.dtTamamlamaTarihi,
            this.cmbsDurum,
            this.btnMailGonder,
            this.txtsAciklama});
            this.gridControl1.Size = new System.Drawing.Size(632, 351);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // ısTakipTanimBindingSource
            // 
            this.ısTakipTanimBindingSource.DataMember = "IsTakipTanim";
            this.ısTakipTanimBindingSource.DataSource = this.bIMSERDataSet;
            // 
            // bIMSERDataSet
            // 
            this.bIMSERDataSet.DataSetName = "BIMSERDataSet";
            this.bIMSERDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gv_IsTakipTanim_rowid,
            this.gv_TicketNumarasi,
            this.gv_Musteri,
            this.gv_Konu,
            this.gv_Aciklama,
            this.gv_UstAciklama,
            this.gv_Sorumlu,
            this.gv_PlanlamaTarihi,
            this.gv_TamamlamaTarihi,
            this.gv_Durum,
            this.gv_MailGonder});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.NewItemRowText = "Listeye eleman eklemek için tıklayınız.";
            this.gridView1.OptionsFind.FindNullPrompt = "Arama";
            this.gridView1.OptionsNavigation.AutoFocusNewRow = true;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gridView1_InitNewRow);
            this.gridView1.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView1_RowUpdated);
            this.gridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridView1_KeyDown);
            // 
            // gv_IsTakipTanim_rowid
            // 
            this.gv_IsTakipTanim_rowid.Caption = "ID";
            this.gv_IsTakipTanim_rowid.FieldName = "IsTakipTanim_rowid";
            this.gv_IsTakipTanim_rowid.Name = "gv_IsTakipTanim_rowid";
            // 
            // gv_TicketNumarasi
            // 
            this.gv_TicketNumarasi.Caption = "Ticket Numarası";
            this.gv_TicketNumarasi.FieldName = "sTicketNumarasi";
            this.gv_TicketNumarasi.Name = "gv_TicketNumarasi";
            this.gv_TicketNumarasi.Visible = true;
            this.gv_TicketNumarasi.VisibleIndex = 0;
            this.gv_TicketNumarasi.Width = 60;
            // 
            // gv_Musteri
            // 
            this.gv_Musteri.Caption = "Müşteri";
            this.gv_Musteri.ColumnEdit = this.cmbpMusteri;
            this.gv_Musteri.FieldName = "pMusteri";
            this.gv_Musteri.Name = "gv_Musteri";
            this.gv_Musteri.Visible = true;
            this.gv_Musteri.VisibleIndex = 1;
            this.gv_Musteri.Width = 60;
            // 
            // cmbpMusteri
            // 
            this.cmbpMusteri.AutoHeight = false;
            this.cmbpMusteri.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbpMusteri.DataSource = this.musteriTanimBindingSource;
            this.cmbpMusteri.DisplayMember = "sAdiSoyadi";
            this.cmbpMusteri.Name = "cmbpMusteri";
            this.cmbpMusteri.NullText = "";
            this.cmbpMusteri.PopupView = this.repositoryItemSearchLookUpEdit1View;
            this.cmbpMusteri.ValueMember = "MusteriTanim_rowid";
            // 
            // musteriTanimBindingSource
            // 
            this.musteriTanimBindingSource.DataMember = "MusteriTanim";
            this.musteriTanimBindingSource.DataSource = this.bIMSERDataSet;
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1});
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.EnableAppearanceEvenRow = true;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Adı Soyadı";
            this.gridColumn1.FieldName = "sAdiSoyadi";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gv_Konu
            // 
            this.gv_Konu.Caption = "Konu";
            this.gv_Konu.FieldName = "sKonu";
            this.gv_Konu.Name = "gv_Konu";
            this.gv_Konu.Visible = true;
            this.gv_Konu.VisibleIndex = 2;
            this.gv_Konu.Width = 60;
            // 
            // gv_Aciklama
            // 
            this.gv_Aciklama.Caption = "Açıklama";
            this.gv_Aciklama.ColumnEdit = this.txtsAciklama;
            this.gv_Aciklama.FieldName = "sAciklama";
            this.gv_Aciklama.Name = "gv_Aciklama";
            this.gv_Aciklama.OptionsColumn.FixedWidth = true;
            this.gv_Aciklama.Visible = true;
            this.gv_Aciklama.VisibleIndex = 3;
            this.gv_Aciklama.Width = 202;
            // 
            // txtsAciklama
            // 
            this.txtsAciklama.Name = "txtsAciklama";
            // 
            // gv_UstAciklama
            // 
            this.gv_UstAciklama.Caption = "Üst Açıklama";
            this.gv_UstAciklama.FieldName = "sUstAciklama";
            this.gv_UstAciklama.Name = "gv_UstAciklama";
            this.gv_UstAciklama.Visible = true;
            this.gv_UstAciklama.VisibleIndex = 4;
            this.gv_UstAciklama.Width = 35;
            // 
            // gv_Sorumlu
            // 
            this.gv_Sorumlu.Caption = "Sorumlu";
            this.gv_Sorumlu.ColumnEdit = this.cmbpSorumlu;
            this.gv_Sorumlu.FieldName = "pSorumlu";
            this.gv_Sorumlu.Name = "gv_Sorumlu";
            this.gv_Sorumlu.Visible = true;
            this.gv_Sorumlu.VisibleIndex = 5;
            this.gv_Sorumlu.Width = 35;
            // 
            // cmbpSorumlu
            // 
            this.cmbpSorumlu.AutoHeight = false;
            this.cmbpSorumlu.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbpSorumlu.DataSource = this.sorumluTanimBindingSource;
            this.cmbpSorumlu.DisplayMember = "sAdiSoyadi";
            this.cmbpSorumlu.Name = "cmbpSorumlu";
            this.cmbpSorumlu.NullText = "";
            this.cmbpSorumlu.PopupView = this.gridView2;
            this.cmbpSorumlu.ValueMember = "SorumluTanim_rowid";
            // 
            // sorumluTanimBindingSource
            // 
            this.sorumluTanimBindingSource.DataMember = "SorumluTanim";
            this.sorumluTanimBindingSource.DataSource = this.bIMSERDataSet;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Adı Soyadı";
            this.gridColumn2.FieldName = "sAdiSoyadi";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // gv_PlanlamaTarihi
            // 
            this.gv_PlanlamaTarihi.Caption = "Planlama Tarihi";
            this.gv_PlanlamaTarihi.ColumnEdit = this.dtPlanlamaTarihi;
            this.gv_PlanlamaTarihi.FieldName = "dtPlanlamaTarihi";
            this.gv_PlanlamaTarihi.Name = "gv_PlanlamaTarihi";
            this.gv_PlanlamaTarihi.Visible = true;
            this.gv_PlanlamaTarihi.VisibleIndex = 6;
            this.gv_PlanlamaTarihi.Width = 35;
            // 
            // dtPlanlamaTarihi
            // 
            this.dtPlanlamaTarihi.AutoHeight = false;
            this.dtPlanlamaTarihi.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtPlanlamaTarihi.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtPlanlamaTarihi.Name = "dtPlanlamaTarihi";
            // 
            // gv_TamamlamaTarihi
            // 
            this.gv_TamamlamaTarihi.Caption = "Tamamlama Tarihi";
            this.gv_TamamlamaTarihi.ColumnEdit = this.dtTamamlamaTarihi;
            this.gv_TamamlamaTarihi.FieldName = "dtTamamlamaTarihi";
            this.gv_TamamlamaTarihi.Name = "gv_TamamlamaTarihi";
            this.gv_TamamlamaTarihi.Visible = true;
            this.gv_TamamlamaTarihi.VisibleIndex = 7;
            this.gv_TamamlamaTarihi.Width = 35;
            // 
            // dtTamamlamaTarihi
            // 
            this.dtTamamlamaTarihi.AutoHeight = false;
            this.dtTamamlamaTarihi.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtTamamlamaTarihi.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtTamamlamaTarihi.Name = "dtTamamlamaTarihi";
            // 
            // gv_Durum
            // 
            this.gv_Durum.Caption = "Durum";
            this.gv_Durum.ColumnEdit = this.cmbsDurum;
            this.gv_Durum.FieldName = "sDurum";
            this.gv_Durum.Name = "gv_Durum";
            this.gv_Durum.Visible = true;
            this.gv_Durum.VisibleIndex = 8;
            this.gv_Durum.Width = 35;
            // 
            // cmbsDurum
            // 
            this.cmbsDurum.AutoHeight = false;
            this.cmbsDurum.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbsDurum.DropDownRows = 2;
            this.cmbsDurum.Items.AddRange(new object[] {
            "Aktif",
            "Pasif"});
            this.cmbsDurum.Name = "cmbsDurum";
            this.cmbsDurum.NullText = "Aktif";
            this.cmbsDurum.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // gv_MailGonder
            // 
            this.gv_MailGonder.Caption = "Mail Gönder";
            this.gv_MailGonder.ColumnEdit = this.btnMailGonder;
            this.gv_MailGonder.FieldName = "bMailGonder";
            this.gv_MailGonder.Name = "gv_MailGonder";
            this.gv_MailGonder.Visible = true;
            this.gv_MailGonder.VisibleIndex = 9;
            this.gv_MailGonder.Width = 50;
            // 
            // btnMailGonder
            // 
            this.btnMailGonder.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btnMailGonder.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Mail Gönder", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", "Mail", null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnMailGonder.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMailGonder.ContextImageOptions.Image")));
            this.btnMailGonder.Name = "btnMailGonder";
            this.btnMailGonder.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnMailGonder.Click += new System.EventHandler(this.btnMailGonder_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Appearance.Options.UseTextOptions = true;
            this.simpleButton1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton1.Location = new System.Drawing.Point(399, 2);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(20, 20);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(420, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Properties.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("txtSearch.Properties.ContextImageOptions.Image")));
            this.txtSearch.Properties.NullText = "Arama";
            this.txtSearch.Size = new System.Drawing.Size(211, 20);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // musteriTanimTableAdapter
            // 
            this.musteriTanimTableAdapter.ClearBeforeFill = true;
            // 
            // sorumluTanimTableAdapter
            // 
            this.sorumluTanimTableAdapter.ClearBeforeFill = true;
            // 
            // isTakipTanimTableAdapter
            // 
            this.isTakipTanimTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 391);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.gridControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İş Takip Listesi:";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ısTakipTanimBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bIMSERDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbpMusteri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriTanimBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsAciklama)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbpSorumlu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sorumluTanimBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPlanlamaTarihi.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPlanlamaTarihi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTamamlamaTarihi.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTamamlamaTarihi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbsDurum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMailGonder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit txtSearch;
        private DevExpress.XtraGrid.Columns.GridColumn gv_TicketNumarasi;
        private DevExpress.XtraGrid.Columns.GridColumn gv_Musteri;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmbpMusteri;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gv_Konu;
        private DevExpress.XtraGrid.Columns.GridColumn gv_Aciklama;
        private DevExpress.XtraGrid.Columns.GridColumn gv_UstAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn gv_Sorumlu;
        private DevExpress.XtraGrid.Columns.GridColumn gv_PlanlamaTarihi;
        private BIMSERDataSet bIMSERDataSet;
        private System.Windows.Forms.BindingSource musteriTanimBindingSource;
        private BIMSERDataSetTableAdapters.MusteriTanimTableAdapter musteriTanimTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmbpSorumlu;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.BindingSource sorumluTanimBindingSource;
        private BIMSERDataSetTableAdapters.SorumluTanimTableAdapter sorumluTanimTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit dtPlanlamaTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn gv_TamamlamaTarihi;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit dtTamamlamaTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn gv_Durum;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox cmbsDurum;
        private DevExpress.XtraGrid.Columns.GridColumn gv_MailGonder;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnMailGonder;
        private System.Windows.Forms.BindingSource ısTakipTanimBindingSource;
        private BIMSERDataSetTableAdapters.IsTakipTanimTableAdapter isTakipTanimTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn gv_IsTakipTanim_rowid;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit txtsAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
    }
}

