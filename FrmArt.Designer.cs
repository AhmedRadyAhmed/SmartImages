
namespace JamesApp
{
    partial class FrmArt
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
            this.tb_Generate = new System.Windows.Forms.TabPage();
            this.gridArt = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnGenerateCSV = new System.Windows.Forms.Button();
            this.tabArt = new System.Windows.Forms.TabPage();
            this.PnlNewKeywords = new System.Windows.Forms.Panel();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.BtnDone = new System.Windows.Forms.Button();
            this.lstnewkeywords = new System.Windows.Forms.ListBox();
            this.LstCategories = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.opt1 = new System.Windows.Forms.RadioButton();
            this.opt0 = new System.Windows.Forms.RadioButton();
            this.opt2 = new System.Windows.Forms.RadioButton();
            this.BtnOpenHtml = new System.Windows.Forms.Button();
            this.BtnCopyToNew = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnSaveClear = new System.Windows.Forms.Button();
            this.BtnNewArtItem = new System.Windows.Forms.Button();
            this.cmbSubject = new System.Windows.Forms.ComboBox();
            this.lstArt_Style = new System.Windows.Forms.ComboBox();
            this.lstFYear = new System.Windows.Forms.ComboBox();
            this.cmbSigned = new System.Windows.Forms.ComboBox();
            this.cmbTypeMedia = new System.Windows.Forms.ComboBox();
            this.cmbCondition_Report = new System.Windows.Forms.ComboBox();
            this.txtNotesLb = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.LblPrice = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.txtKeywords = new System.Windows.Forms.TextBox();
            this.txtUsedPub = new System.Windows.Forms.TextBox();
            this._txturls = new System.Windows.Forms.TextBox();
            this._txtsize = new System.Windows.Forms.TextBox();
            this.SKU = new System.Windows.Forms.TextBox();
            this.txtCustom_TypeMedia = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtPublishTitle = new System.Windows.Forms.TextBox();
            this.txtArtistName = new System.Windows.Forms.TextBox();
            this.CameraPath = new System.Windows.Forms.TextBox();
            this.BtnFolderArt = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tb_Generate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridArt)).BeginInit();
            this.panel3.SuspendLayout();
            this.tabArt.SuspendLayout();
            this.PnlNewKeywords.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_Generate
            // 
            this.tb_Generate.Controls.Add(this.gridArt);
            this.tb_Generate.Controls.Add(this.panel3);
            this.tb_Generate.Location = new System.Drawing.Point(4, 22);
            this.tb_Generate.Name = "tb_Generate";
            this.tb_Generate.Size = new System.Drawing.Size(1158, 513);
            this.tb_Generate.TabIndex = 3;
            this.tb_Generate.Text = "Data";
            this.tb_Generate.UseVisualStyleBackColor = true;
            // 
            // gridArt
            // 
            this.gridArt.AllowUserToAddRows = false;
            this.gridArt.AllowUserToDeleteRows = false;
            this.gridArt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridArt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridArt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridArt.Location = new System.Drawing.Point(0, 41);
            this.gridArt.Name = "gridArt";
            this.gridArt.ReadOnly = true;
            this.gridArt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridArt.Size = new System.Drawing.Size(1158, 472);
            this.gridArt.TabIndex = 2;
            this.gridArt.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridArt_CellDoubleClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.BtnGenerateCSV);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1158, 41);
            this.panel3.TabIndex = 1;
            // 
            // BtnGenerateCSV
            // 
            this.BtnGenerateCSV.Location = new System.Drawing.Point(26, 8);
            this.BtnGenerateCSV.Name = "BtnGenerateCSV";
            this.BtnGenerateCSV.Size = new System.Drawing.Size(115, 23);
            this.BtnGenerateCSV.TabIndex = 5;
            this.BtnGenerateCSV.Text = "Generate CSV";
            this.BtnGenerateCSV.UseVisualStyleBackColor = true;
            this.BtnGenerateCSV.Click += new System.EventHandler(this.BtnGenerateCSV_Click);
            // 
            // tabArt
            // 
            this.tabArt.Controls.Add(this.PnlNewKeywords);
            this.tabArt.Controls.Add(this.BtnOpenHtml);
            this.tabArt.Controls.Add(this.BtnCopyToNew);
            this.tabArt.Controls.Add(this.BtnClear);
            this.tabArt.Controls.Add(this.BtnSearch);
            this.tabArt.Controls.Add(this.BtnSaveClear);
            this.tabArt.Controls.Add(this.BtnNewArtItem);
            this.tabArt.Controls.Add(this.cmbSubject);
            this.tabArt.Controls.Add(this.lstArt_Style);
            this.tabArt.Controls.Add(this.lstFYear);
            this.tabArt.Controls.Add(this.cmbSigned);
            this.tabArt.Controls.Add(this.cmbTypeMedia);
            this.tabArt.Controls.Add(this.cmbCondition_Report);
            this.tabArt.Controls.Add(this.txtNotesLb);
            this.tabArt.Controls.Add(this.label7);
            this.tabArt.Controls.Add(this.label8);
            this.tabArt.Controls.Add(this.label13);
            this.tabArt.Controls.Add(this.label12);
            this.tabArt.Controls.Add(this.label15);
            this.tabArt.Controls.Add(this.label14);
            this.tabArt.Controls.Add(this.label11);
            this.tabArt.Controls.Add(this.label10);
            this.tabArt.Controls.Add(this.LblPrice);
            this.tabArt.Controls.Add(this.label6);
            this.tabArt.Controls.Add(this.label9);
            this.tabArt.Controls.Add(this.label4);
            this.tabArt.Controls.Add(this.txtNotes);
            this.tabArt.Controls.Add(this.txtKeywords);
            this.tabArt.Controls.Add(this.txtUsedPub);
            this.tabArt.Controls.Add(this._txturls);
            this.tabArt.Controls.Add(this._txtsize);
            this.tabArt.Controls.Add(this.SKU);
            this.tabArt.Controls.Add(this.txtCustom_TypeMedia);
            this.tabArt.Controls.Add(this.txtPrice);
            this.tabArt.Controls.Add(this.txtPublishTitle);
            this.tabArt.Controls.Add(this.txtArtistName);
            this.tabArt.Controls.Add(this.CameraPath);
            this.tabArt.Controls.Add(this.BtnFolderArt);
            this.tabArt.Location = new System.Drawing.Point(4, 22);
            this.tabArt.Name = "tabArt";
            this.tabArt.Padding = new System.Windows.Forms.Padding(3);
            this.tabArt.Size = new System.Drawing.Size(1158, 513);
            this.tabArt.TabIndex = 6;
            this.tabArt.Text = "ART";
            this.tabArt.UseVisualStyleBackColor = true;
            // 
            // PnlNewKeywords
            // 
            this.PnlNewKeywords.BackColor = System.Drawing.SystemColors.Control;
            this.PnlNewKeywords.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlNewKeywords.Controls.Add(this.Btn_Save);
            this.PnlNewKeywords.Controls.Add(this.BtnDone);
            this.PnlNewKeywords.Controls.Add(this.lstnewkeywords);
            this.PnlNewKeywords.Controls.Add(this.LstCategories);
            this.PnlNewKeywords.Controls.Add(this.panel1);
            this.PnlNewKeywords.Location = new System.Drawing.Point(584, 4);
            this.PnlNewKeywords.Name = "PnlNewKeywords";
            this.PnlNewKeywords.Size = new System.Drawing.Size(574, 433);
            this.PnlNewKeywords.TabIndex = 30;
            this.PnlNewKeywords.Visible = false;
            // 
            // Btn_Save
            // 
            this.Btn_Save.Location = new System.Drawing.Point(220, 162);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(129, 23);
            this.Btn_Save.TabIndex = 29;
            this.Btn_Save.Tag = "0";
            this.Btn_Save.Text = "Save";
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // BtnDone
            // 
            this.BtnDone.Location = new System.Drawing.Point(240, 341);
            this.BtnDone.Name = "BtnDone";
            this.BtnDone.Size = new System.Drawing.Size(91, 23);
            this.BtnDone.TabIndex = 29;
            this.BtnDone.Tag = "0";
            this.BtnDone.Text = "Done";
            this.BtnDone.UseVisualStyleBackColor = true;
            this.BtnDone.Click += new System.EventHandler(this.BtnDone_Click);
            // 
            // lstnewkeywords
            // 
            this.lstnewkeywords.FormattingEnabled = true;
            this.lstnewkeywords.Location = new System.Drawing.Point(85, 61);
            this.lstnewkeywords.Name = "lstnewkeywords";
            this.lstnewkeywords.Size = new System.Drawing.Size(129, 303);
            this.lstnewkeywords.TabIndex = 0;
            // 
            // LstCategories
            // 
            this.LstCategories.FormattingEnabled = true;
            this.LstCategories.Location = new System.Drawing.Point(382, 61);
            this.LstCategories.Name = "LstCategories";
            this.LstCategories.Size = new System.Drawing.Size(129, 303);
            this.LstCategories.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.opt1);
            this.panel1.Controls.Add(this.opt0);
            this.panel1.Controls.Add(this.opt2);
            this.panel1.Location = new System.Drawing.Point(220, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(129, 94);
            this.panel1.TabIndex = 27;
            // 
            // opt1
            // 
            this.opt1.AutoSize = true;
            this.opt1.Checked = true;
            this.opt1.Location = new System.Drawing.Point(10, 35);
            this.opt1.Name = "opt1";
            this.opt1.Size = new System.Drawing.Size(31, 17);
            this.opt1.TabIndex = 1;
            this.opt1.TabStop = true;
            this.opt1.Text = "1";
            this.opt1.UseVisualStyleBackColor = true;
            // 
            // opt0
            // 
            this.opt0.AutoSize = true;
            this.opt0.Location = new System.Drawing.Point(10, 3);
            this.opt0.Name = "opt0";
            this.opt0.Size = new System.Drawing.Size(31, 17);
            this.opt0.TabIndex = 0;
            this.opt0.Text = "0";
            this.opt0.UseVisualStyleBackColor = true;
            // 
            // opt2
            // 
            this.opt2.AutoSize = true;
            this.opt2.Location = new System.Drawing.Point(10, 68);
            this.opt2.Name = "opt2";
            this.opt2.Size = new System.Drawing.Size(31, 17);
            this.opt2.TabIndex = 2;
            this.opt2.Text = "2";
            this.opt2.UseVisualStyleBackColor = true;
            // 
            // BtnOpenHtml
            // 
            this.BtnOpenHtml.Location = new System.Drawing.Point(400, 385);
            this.BtnOpenHtml.Name = "BtnOpenHtml";
            this.BtnOpenHtml.Size = new System.Drawing.Size(91, 23);
            this.BtnOpenHtml.TabIndex = 31;
            this.BtnOpenHtml.Text = "HTML";
            this.BtnOpenHtml.UseVisualStyleBackColor = true;
            this.BtnOpenHtml.Click += new System.EventHandler(this.BtnOpenHtml_Click);
            // 
            // BtnCopyToNew
            // 
            this.BtnCopyToNew.Location = new System.Drawing.Point(121, 414);
            this.BtnCopyToNew.Name = "BtnCopyToNew";
            this.BtnCopyToNew.Size = new System.Drawing.Size(91, 23);
            this.BtnCopyToNew.TabIndex = 33;
            this.BtnCopyToNew.Text = "Copy To New";
            this.BtnCopyToNew.UseVisualStyleBackColor = true;
            this.BtnCopyToNew.Click += new System.EventHandler(this.BtnCopyToNew_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(309, 385);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(91, 23);
            this.BtnClear.TabIndex = 30;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(491, 385);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(91, 23);
            this.BtnSearch.TabIndex = 32;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // BtnSaveClear
            // 
            this.BtnSaveClear.Location = new System.Drawing.Point(212, 385);
            this.BtnSaveClear.Name = "BtnSaveClear";
            this.BtnSaveClear.Size = new System.Drawing.Size(91, 23);
            this.BtnSaveClear.TabIndex = 29;
            this.BtnSaveClear.Tag = "1";
            this.BtnSaveClear.Text = "Save and Clear";
            this.BtnSaveClear.UseVisualStyleBackColor = true;
            this.BtnSaveClear.Click += new System.EventHandler(this.BtnNewArtItem_Click);
            // 
            // BtnNewArtItem
            // 
            this.BtnNewArtItem.Location = new System.Drawing.Point(121, 385);
            this.BtnNewArtItem.Name = "BtnNewArtItem";
            this.BtnNewArtItem.Size = new System.Drawing.Size(91, 23);
            this.BtnNewArtItem.TabIndex = 28;
            this.BtnNewArtItem.Tag = "0";
            this.BtnNewArtItem.Text = "Save";
            this.BtnNewArtItem.UseVisualStyleBackColor = true;
            this.BtnNewArtItem.Click += new System.EventHandler(this.BtnNewArtItem_Click);
            // 
            // cmbSubject
            // 
            this.cmbSubject.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbSubject.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSubject.BackColor = System.Drawing.Color.White;
            this.cmbSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubject.FormattingEnabled = true;
            this.cmbSubject.Location = new System.Drawing.Point(121, 237);
            this.cmbSubject.Name = "cmbSubject";
            this.cmbSubject.Size = new System.Drawing.Size(410, 21);
            this.cmbSubject.TabIndex = 21;
            // 
            // lstArt_Style
            // 
            this.lstArt_Style.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstArt_Style.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstArt_Style.BackColor = System.Drawing.Color.White;
            this.lstArt_Style.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstArt_Style.FormattingEnabled = true;
            this.lstArt_Style.Location = new System.Drawing.Point(121, 162);
            this.lstArt_Style.Name = "lstArt_Style";
            this.lstArt_Style.Size = new System.Drawing.Size(410, 21);
            this.lstArt_Style.TabIndex = 15;
            // 
            // lstFYear
            // 
            this.lstFYear.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstFYear.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstFYear.BackColor = System.Drawing.Color.White;
            this.lstFYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstFYear.FormattingEnabled = true;
            this.lstFYear.Location = new System.Drawing.Point(121, 187);
            this.lstFYear.Name = "lstFYear";
            this.lstFYear.Size = new System.Drawing.Size(410, 21);
            this.lstFYear.TabIndex = 17;
            // 
            // cmbSigned
            // 
            this.cmbSigned.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbSigned.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSigned.BackColor = System.Drawing.Color.White;
            this.cmbSigned.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSigned.FormattingEnabled = true;
            this.cmbSigned.Location = new System.Drawing.Point(121, 212);
            this.cmbSigned.Name = "cmbSigned";
            this.cmbSigned.Size = new System.Drawing.Size(410, 21);
            this.cmbSigned.TabIndex = 19;
            // 
            // cmbTypeMedia
            // 
            this.cmbTypeMedia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbTypeMedia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTypeMedia.BackColor = System.Drawing.Color.White;
            this.cmbTypeMedia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTypeMedia.FormattingEnabled = true;
            this.cmbTypeMedia.Location = new System.Drawing.Point(121, 137);
            this.cmbTypeMedia.Name = "cmbTypeMedia";
            this.cmbTypeMedia.Size = new System.Drawing.Size(410, 21);
            this.cmbTypeMedia.TabIndex = 13;
            this.cmbTypeMedia.SelectedIndexChanged += new System.EventHandler(this.cmbTypeMedia_SelectedIndexChanged);
            // 
            // cmbCondition_Report
            // 
            this.cmbCondition_Report.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCondition_Report.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCondition_Report.BackColor = System.Drawing.Color.White;
            this.cmbCondition_Report.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCondition_Report.FormattingEnabled = true;
            this.cmbCondition_Report.Location = new System.Drawing.Point(121, 112);
            this.cmbCondition_Report.Name = "cmbCondition_Report";
            this.cmbCondition_Report.Size = new System.Drawing.Size(410, 21);
            this.cmbCondition_Report.TabIndex = 10;
            // 
            // txtNotesLb
            // 
            this.txtNotesLb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtNotesLb.Location = new System.Drawing.Point(30, 316);
            this.txtNotesLb.Name = "txtNotesLb";
            this.txtNotesLb.Size = new System.Drawing.Size(85, 20);
            this.txtNotesLb.TabIndex = 26;
            this.txtNotesLb.Text = "Notes";
            this.txtNotesLb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Location = new System.Drawing.Point(6, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Keywords";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Location = new System.Drawing.Point(6, 284);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "Used in publication";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label13.Location = new System.Drawing.Point(30, 216);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 20);
            this.label13.TabIndex = 18;
            this.label13.Text = "Signed";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label12.Location = new System.Drawing.Point(30, 241);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 20);
            this.label12.TabIndex = 20;
            this.label12.Text = "Subject";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label15.Location = new System.Drawing.Point(30, 191);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(85, 20);
            this.label15.TabIndex = 16;
            this.label15.Text = "Year";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label14.Location = new System.Drawing.Point(30, 166);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 20);
            this.label14.TabIndex = 14;
            this.label14.Text = "Style";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Location = new System.Drawing.Point(30, 141);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 20);
            this.label11.TabIndex = 11;
            this.label11.Text = "Type/Media";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Location = new System.Drawing.Point(9, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "Condition Report";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblPrice
            // 
            this.LblPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblPrice.Location = new System.Drawing.Point(30, 91);
            this.LblPrice.Name = "LblPrice";
            this.LblPrice.Size = new System.Drawing.Size(85, 20);
            this.LblPrice.TabIndex = 7;
            this.LblPrice.Text = "Price";
            this.LblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Location = new System.Drawing.Point(30, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Artwork Title";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Location = new System.Drawing.Point(30, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Image Path";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Location = new System.Drawing.Point(30, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Artist Name";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(121, 310);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(410, 61);
            this.txtNotes.TabIndex = 27;
            // 
            // txtKeywords
            // 
            this.txtKeywords.Location = new System.Drawing.Point(121, 262);
            this.txtKeywords.Name = "txtKeywords";
            this.txtKeywords.Size = new System.Drawing.Size(410, 20);
            this.txtKeywords.TabIndex = 23;
            // 
            // txtUsedPub
            // 
            this.txtUsedPub.Location = new System.Drawing.Point(121, 286);
            this.txtUsedPub.Name = "txtUsedPub";
            this.txtUsedPub.Size = new System.Drawing.Size(410, 20);
            this.txtUsedPub.TabIndex = 25;
            // 
            // _txturls
            // 
            this._txturls.Location = new System.Drawing.Point(699, 67);
            this._txturls.Name = "_txturls";
            this._txturls.Size = new System.Drawing.Size(105, 20);
            this._txturls.TabIndex = 1;
            this._txturls.Visible = false;
            // 
            // _txtsize
            // 
            this._txtsize.Location = new System.Drawing.Point(699, 41);
            this._txtsize.Name = "_txtsize";
            this._txtsize.Size = new System.Drawing.Size(105, 20);
            this._txtsize.TabIndex = 37;
            this._txtsize.Visible = false;
            // 
            // SKU
            // 
            this.SKU.Location = new System.Drawing.Point(699, 15);
            this.SKU.Name = "SKU";
            this.SKU.Size = new System.Drawing.Size(105, 20);
            this.SKU.TabIndex = 35;
            this.SKU.Visible = false;
            // 
            // txtCustom_TypeMedia
            // 
            this.txtCustom_TypeMedia.BackColor = System.Drawing.Color.White;
            this.txtCustom_TypeMedia.Location = new System.Drawing.Point(326, 138);
            this.txtCustom_TypeMedia.Name = "txtCustom_TypeMedia";
            this.txtCustom_TypeMedia.Size = new System.Drawing.Size(205, 20);
            this.txtCustom_TypeMedia.TabIndex = 8;
            this.txtCustom_TypeMedia.Visible = false;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(121, 88);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(410, 20);
            this.txtPrice.TabIndex = 8;
            // 
            // txtPublishTitle
            // 
            this.txtPublishTitle.Location = new System.Drawing.Point(121, 64);
            this.txtPublishTitle.Name = "txtPublishTitle";
            this.txtPublishTitle.Size = new System.Drawing.Size(410, 20);
            this.txtPublishTitle.TabIndex = 6;
            // 
            // txtArtistName
            // 
            this.txtArtistName.Location = new System.Drawing.Point(121, 40);
            this.txtArtistName.Name = "txtArtistName";
            this.txtArtistName.Size = new System.Drawing.Size(410, 20);
            this.txtArtistName.TabIndex = 4;
            // 
            // CameraPath
            // 
            this.CameraPath.Location = new System.Drawing.Point(121, 16);
            this.CameraPath.Name = "CameraPath";
            this.CameraPath.Size = new System.Drawing.Size(338, 20);
            this.CameraPath.TabIndex = 1;
            this.CameraPath.Text = "F:\\Art Process\\1_Camera_Output";
            // 
            // BtnFolderArt
            // 
            this.BtnFolderArt.Location = new System.Drawing.Point(465, 16);
            this.BtnFolderArt.Name = "BtnFolderArt";
            this.BtnFolderArt.Size = new System.Drawing.Size(65, 21);
            this.BtnFolderArt.TabIndex = 2;
            this.BtnFolderArt.Text = "Choose..";
            this.BtnFolderArt.UseVisualStyleBackColor = true;
            this.BtnFolderArt.Click += new System.EventHandler(this.BtnFolderArt_Click_1);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabArt);
            this.tabControl1.Controls.Add(this.tb_Generate);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1166, 539);
            this.tabControl1.TabIndex = 0;
            // 
            // FrmArt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 539);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmArt";
            this.Text = "ART";
            this.Load += new System.EventHandler(this.FrmArt_Load);
            this.tb_Generate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridArt)).EndInit();
            this.panel3.ResumeLayout(false);
            this.tabArt.ResumeLayout(false);
            this.tabArt.PerformLayout();
            this.PnlNewKeywords.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tb_Generate;
        private System.Windows.Forms.DataGridView gridArt;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BtnGenerateCSV;
        private System.Windows.Forms.TabPage tabArt;
        private System.Windows.Forms.Button BtnCopyToNew;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnNewArtItem;
        private System.Windows.Forms.ComboBox cmbSubject;
        private System.Windows.Forms.ComboBox lstArt_Style;
        private System.Windows.Forms.ComboBox lstFYear;
        private System.Windows.Forms.ComboBox cmbSigned;
        private System.Windows.Forms.ComboBox cmbTypeMedia;
        private System.Windows.Forms.ComboBox cmbCondition_Report;
        private System.Windows.Forms.Label txtNotesLb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label LblPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.TextBox txtKeywords;
        private System.Windows.Forms.TextBox txtUsedPub;
        private System.Windows.Forms.TextBox _txturls;
        private System.Windows.Forms.TextBox _txtsize;
        private System.Windows.Forms.TextBox SKU;
        private System.Windows.Forms.TextBox txtCustom_TypeMedia;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtPublishTitle;
        private System.Windows.Forms.TextBox txtArtistName;
        private System.Windows.Forms.TextBox CameraPath;
        private System.Windows.Forms.Button BtnFolderArt;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ListBox lstnewkeywords;
        private System.Windows.Forms.ListBox LstCategories;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton opt1;
        private System.Windows.Forms.RadioButton opt0;
        private System.Windows.Forms.RadioButton opt2;
        private System.Windows.Forms.Button BtnOpenHtml;
        private System.Windows.Forms.Panel PnlNewKeywords;
        private System.Windows.Forms.Button BtnSaveClear;
        private System.Windows.Forms.Button BtnDone;
        private System.Windows.Forms.Button Btn_Save;
    }
}