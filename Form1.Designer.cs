namespace JamesApp
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
            this.BtnOk = new System.Windows.Forms.Button();
            this.txtpath = new System.Windows.Forms.TextBox();
            this.txtresult = new System.Windows.Forms.TextBox();
            this.BtnAnyalyze = new System.Windows.Forms.Button();
            this.myprog = new System.Windows.Forms.ProgressBar();
            this.BtnOpen = new System.Windows.Forms.Button();
            this.txt_path = new System.Windows.Forms.TextBox();
            this.lblfilename = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tb_Generate = new System.Windows.Forms.TabPage();
            this.tb_image_analysis = new System.Windows.Forms.TabPage();
            this.tab_categories = new System.Windows.Forms.TabPage();
            this.tab_AnalyzeKeywords = new System.Windows.Forms.TabPage();
            this.progkeywords = new System.Windows.Forms.ProgressBar();
            this.BtnAnyalyzeKeywords = new System.Windows.Forms.Button();
            this.tb_Keyword_Category = new System.Windows.Forms.TabPage();
            this.ChkSave = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnFilter = new System.Windows.Forms.Button();
            this.cmb_filter = new System.Windows.Forms.ComboBox();
            this.txtkeywordsearch = new System.Windows.Forms.TextBox();
            this.BtnGo = new System.Windows.Forms.Button();
            this.BtnNext = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtrecid = new System.Windows.Forms.TextBox();
            this.txtkeyword = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.opt1 = new System.Windows.Forms.RadioButton();
            this.opt0 = new System.Windows.Forms.RadioButton();
            this.opt2 = new System.Windows.Forms.RadioButton();
            this.txtNoRepeates = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnPrev = new System.Windows.Forms.Button();
            this.LstCategories = new System.Windows.Forms.ListBox();
            this.tb_use_GV = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tb_image_analysis.SuspendLayout();
            this.tab_AnalyzeKeywords.SuspendLayout();
            this.tb_Keyword_Category.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tb_use_GV.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnOk
            // 
            this.BtnOk.Location = new System.Drawing.Point(528, 25);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(60, 20);
            this.BtnOk.TabIndex = 1;
            this.BtnOk.Text = "Ok";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // txtpath
            // 
            this.txtpath.Location = new System.Drawing.Point(25, 25);
            this.txtpath.Name = "txtpath";
            this.txtpath.Size = new System.Drawing.Size(500, 20);
            this.txtpath.TabIndex = 0;
            // 
            // txtresult
            // 
            this.txtresult.Location = new System.Drawing.Point(25, 51);
            this.txtresult.Multiline = true;
            this.txtresult.Name = "txtresult";
            this.txtresult.Size = new System.Drawing.Size(563, 277);
            this.txtresult.TabIndex = 2;
            this.txtresult.Visible = false;
            // 
            // BtnAnyalyze
            // 
            this.BtnAnyalyze.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAnyalyze.Location = new System.Drawing.Point(25, 61);
            this.BtnAnyalyze.Name = "BtnAnyalyze";
            this.BtnAnyalyze.Size = new System.Drawing.Size(100, 23);
            this.BtnAnyalyze.TabIndex = 3;
            this.BtnAnyalyze.Text = "Start";
            this.BtnAnyalyze.UseVisualStyleBackColor = true;
            this.BtnAnyalyze.Click += new System.EventHandler(this.BtnAnyalyze_Click);
            // 
            // myprog
            // 
            this.myprog.Location = new System.Drawing.Point(133, 61);
            this.myprog.Name = "myprog";
            this.myprog.Size = new System.Drawing.Size(465, 23);
            this.myprog.TabIndex = 4;
            this.myprog.UseWaitCursor = true;
            this.myprog.Visible = false;
            // 
            // BtnOpen
            // 
            this.BtnOpen.Location = new System.Drawing.Point(533, 25);
            this.BtnOpen.Name = "BtnOpen";
            this.BtnOpen.Size = new System.Drawing.Size(65, 21);
            this.BtnOpen.TabIndex = 2;
            this.BtnOpen.Text = "Open";
            this.BtnOpen.UseVisualStyleBackColor = true;
            this.BtnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // txt_path
            // 
            this.txt_path.Location = new System.Drawing.Point(25, 25);
            this.txt_path.Name = "txt_path";
            this.txt_path.Size = new System.Drawing.Size(500, 20);
            this.txt_path.TabIndex = 1;
            this.txt_path.Text = "F:\\Rady\\Pic";
            // 
            // lblfilename
            // 
            this.lblfilename.AutoSize = true;
            this.lblfilename.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfilename.Location = new System.Drawing.Point(130, 96);
            this.lblfilename.Name = "lblfilename";
            this.lblfilename.Size = new System.Drawing.Size(15, 16);
            this.lblfilename.TabIndex = 0;
            this.lblfilename.Text = "0";
            this.lblfilename.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tb_Generate);
            this.tabControl1.Controls.Add(this.tb_image_analysis);
            this.tabControl1.Controls.Add(this.tab_categories);
            this.tabControl1.Controls.Add(this.tab_AnalyzeKeywords);
            this.tabControl1.Controls.Add(this.tb_Keyword_Category);
            this.tabControl1.Controls.Add(this.tb_use_GV);
            this.tabControl1.Location = new System.Drawing.Point(28, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(658, 371);
            this.tabControl1.TabIndex = 1;
            // 
            // tb_Generate
            // 
            this.tb_Generate.Location = new System.Drawing.Point(4, 22);
            this.tb_Generate.Name = "tb_Generate";
            this.tb_Generate.Size = new System.Drawing.Size(650, 345);
            this.tb_Generate.TabIndex = 3;
            this.tb_Generate.Text = "Generate CSV";
            this.tb_Generate.UseVisualStyleBackColor = true;
            // 
            // tb_image_analysis
            // 
            this.tb_image_analysis.Controls.Add(this.myprog);
            this.tb_image_analysis.Controls.Add(this.txt_path);
            this.tb_image_analysis.Controls.Add(this.BtnAnyalyze);
            this.tb_image_analysis.Controls.Add(this.BtnOpen);
            this.tb_image_analysis.Controls.Add(this.lblfilename);
            this.tb_image_analysis.Location = new System.Drawing.Point(4, 22);
            this.tb_image_analysis.Name = "tb_image_analysis";
            this.tb_image_analysis.Padding = new System.Windows.Forms.Padding(3);
            this.tb_image_analysis.Size = new System.Drawing.Size(650, 345);
            this.tb_image_analysis.TabIndex = 0;
            this.tb_image_analysis.Text = "Image Analysis";
            this.tb_image_analysis.UseVisualStyleBackColor = true;
            // 
            // tab_categories
            // 
            this.tab_categories.Location = new System.Drawing.Point(4, 22);
            this.tab_categories.Name = "tab_categories";
            this.tab_categories.Size = new System.Drawing.Size(650, 345);
            this.tab_categories.TabIndex = 5;
            this.tab_categories.Text = "Categories";
            this.tab_categories.UseVisualStyleBackColor = true;
            // 
            // tab_AnalyzeKeywords
            // 
            this.tab_AnalyzeKeywords.Controls.Add(this.progkeywords);
            this.tab_AnalyzeKeywords.Controls.Add(this.BtnAnyalyzeKeywords);
            this.tab_AnalyzeKeywords.Location = new System.Drawing.Point(4, 22);
            this.tab_AnalyzeKeywords.Name = "tab_AnalyzeKeywords";
            this.tab_AnalyzeKeywords.Padding = new System.Windows.Forms.Padding(3);
            this.tab_AnalyzeKeywords.Size = new System.Drawing.Size(650, 345);
            this.tab_AnalyzeKeywords.TabIndex = 4;
            this.tab_AnalyzeKeywords.Text = "Analyze Keywords";
            this.tab_AnalyzeKeywords.UseVisualStyleBackColor = true;
            // 
            // progkeywords
            // 
            this.progkeywords.Location = new System.Drawing.Point(106, 25);
            this.progkeywords.Name = "progkeywords";
            this.progkeywords.Size = new System.Drawing.Size(508, 23);
            this.progkeywords.TabIndex = 11;
            this.progkeywords.Visible = false;
            // 
            // BtnAnyalyzeKeywords
            // 
            this.BtnAnyalyzeKeywords.Location = new System.Drawing.Point(25, 25);
            this.BtnAnyalyzeKeywords.Name = "BtnAnyalyzeKeywords";
            this.BtnAnyalyzeKeywords.Size = new System.Drawing.Size(75, 23);
            this.BtnAnyalyzeKeywords.TabIndex = 10;
            this.BtnAnyalyzeKeywords.Text = "Anyalyze Keywords";
            this.BtnAnyalyzeKeywords.UseVisualStyleBackColor = true;
            this.BtnAnyalyzeKeywords.Click += new System.EventHandler(this.BtnAnyalyzeKeywords_Click_1);
            // 
            // tb_Keyword_Category
            // 
            this.tb_Keyword_Category.Controls.Add(this.ChkSave);
            this.tb_Keyword_Category.Controls.Add(this.groupBox1);
            this.tb_Keyword_Category.Controls.Add(this.BtnNext);
            this.tb_Keyword_Category.Controls.Add(this.panel2);
            this.tb_Keyword_Category.Controls.Add(this.BtnPrev);
            this.tb_Keyword_Category.Controls.Add(this.LstCategories);
            this.tb_Keyword_Category.Location = new System.Drawing.Point(4, 22);
            this.tb_Keyword_Category.Name = "tb_Keyword_Category";
            this.tb_Keyword_Category.Padding = new System.Windows.Forms.Padding(3);
            this.tb_Keyword_Category.Size = new System.Drawing.Size(650, 345);
            this.tb_Keyword_Category.TabIndex = 1;
            this.tb_Keyword_Category.Text = "Keyword&Categories";
            this.tb_Keyword_Category.UseVisualStyleBackColor = true;
            // 
            // ChkSave
            // 
            this.ChkSave.AutoSize = true;
            this.ChkSave.Location = new System.Drawing.Point(270, 309);
            this.ChkSave.Name = "ChkSave";
            this.ChkSave.Size = new System.Drawing.Size(130, 17);
            this.ChkSave.TabIndex = 4;
            this.ChkSave.Text = "Save Wtih Navigation";
            this.ChkSave.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnFilter);
            this.groupBox1.Controls.Add(this.cmb_filter);
            this.groupBox1.Controls.Add(this.txtkeywordsearch);
            this.groupBox1.Controls.Add(this.BtnGo);
            this.groupBox1.Location = new System.Drawing.Point(25, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 49);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search By keyWord";
            // 
            // BtnFilter
            // 
            this.BtnFilter.Location = new System.Drawing.Point(97, 17);
            this.BtnFilter.Name = "BtnFilter";
            this.BtnFilter.Size = new System.Drawing.Size(41, 23);
            this.BtnFilter.TabIndex = 3;
            this.BtnFilter.Text = "Filter";
            this.BtnFilter.UseVisualStyleBackColor = true;
            this.BtnFilter.Click += new System.EventHandler(this.BtnFilter_Click);
            // 
            // cmb_filter
            // 
            this.cmb_filter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_filter.FormattingEnabled = true;
            this.cmb_filter.Items.AddRange(new object[] {
            "All",
            "New",
            "Old"});
            this.cmb_filter.Location = new System.Drawing.Point(6, 17);
            this.cmb_filter.Name = "cmb_filter";
            this.cmb_filter.Size = new System.Drawing.Size(85, 21);
            this.cmb_filter.TabIndex = 2;
            // 
            // txtkeywordsearch
            // 
            this.txtkeywordsearch.Location = new System.Drawing.Point(164, 19);
            this.txtkeywordsearch.Name = "txtkeywordsearch";
            this.txtkeywordsearch.Size = new System.Drawing.Size(142, 20);
            this.txtkeywordsearch.TabIndex = 0;
            // 
            // BtnGo
            // 
            this.BtnGo.Location = new System.Drawing.Point(312, 17);
            this.BtnGo.Name = "BtnGo";
            this.BtnGo.Size = new System.Drawing.Size(57, 23);
            this.BtnGo.TabIndex = 1;
            this.BtnGo.Text = "Go";
            this.BtnGo.UseVisualStyleBackColor = true;
            this.BtnGo.Click += new System.EventHandler(this.BtnGo_Click);
            // 
            // BtnNext
            // 
            this.BtnNext.Location = new System.Drawing.Point(106, 305);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(75, 23);
            this.BtnNext.TabIndex = 3;
            this.BtnNext.Text = "Next";
            this.BtnNext.UseVisualStyleBackColor = true;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtrecid);
            this.panel2.Controls.Add(this.txtkeyword);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.txtNoRepeates);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(25, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(375, 213);
            this.panel2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Location = new System.Drawing.Point(20, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Record Id";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(20, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Keword :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtrecid
            // 
            this.txtrecid.Location = new System.Drawing.Point(96, 22);
            this.txtrecid.Name = "txtrecid";
            this.txtrecid.ReadOnly = true;
            this.txtrecid.Size = new System.Drawing.Size(219, 20);
            this.txtrecid.TabIndex = 1;
            // 
            // txtkeyword
            // 
            this.txtkeyword.Location = new System.Drawing.Point(96, 48);
            this.txtkeyword.Name = "txtkeyword";
            this.txtkeyword.ReadOnly = true;
            this.txtkeyword.Size = new System.Drawing.Size(219, 20);
            this.txtkeyword.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.opt1);
            this.panel1.Controls.Add(this.opt0);
            this.panel1.Controls.Add(this.opt2);
            this.panel1.Location = new System.Drawing.Point(96, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 94);
            this.panel1.TabIndex = 13;
            // 
            // opt1
            // 
            this.opt1.AutoSize = true;
            this.opt1.Location = new System.Drawing.Point(10, 35);
            this.opt1.Name = "opt1";
            this.opt1.Size = new System.Drawing.Size(31, 17);
            this.opt1.TabIndex = 1;
            this.opt1.Text = "1";
            this.opt1.UseVisualStyleBackColor = true;
            // 
            // opt0
            // 
            this.opt0.AutoSize = true;
            this.opt0.Checked = true;
            this.opt0.Location = new System.Drawing.Point(10, 3);
            this.opt0.Name = "opt0";
            this.opt0.Size = new System.Drawing.Size(31, 17);
            this.opt0.TabIndex = 0;
            this.opt0.TabStop = true;
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
            // txtNoRepeates
            // 
            this.txtNoRepeates.Location = new System.Drawing.Point(96, 73);
            this.txtNoRepeates.Name = "txtNoRepeates";
            this.txtNoRepeates.ReadOnly = true;
            this.txtNoRepeates.Size = new System.Drawing.Size(219, 20);
            this.txtNoRepeates.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Location = new System.Drawing.Point(1, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Keywod Priority";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Location = new System.Drawing.Point(20, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "No. Repeats :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BtnPrev
            // 
            this.BtnPrev.Location = new System.Drawing.Point(25, 305);
            this.BtnPrev.Name = "BtnPrev";
            this.BtnPrev.Size = new System.Drawing.Size(75, 23);
            this.BtnPrev.TabIndex = 2;
            this.BtnPrev.Text = " Previous";
            this.BtnPrev.UseVisualStyleBackColor = true;
            this.BtnPrev.Click += new System.EventHandler(this.BtnPrev_Click);
            // 
            // LstCategories
            // 
            this.LstCategories.FormattingEnabled = true;
            this.LstCategories.Location = new System.Drawing.Point(416, 25);
            this.LstCategories.Name = "LstCategories";
            this.LstCategories.Size = new System.Drawing.Size(214, 303);
            this.LstCategories.TabIndex = 5;
            // 
            // tb_use_GV
            // 
            this.tb_use_GV.Controls.Add(this.txtpath);
            this.tb_use_GV.Controls.Add(this.BtnOk);
            this.tb_use_GV.Controls.Add(this.txtresult);
            this.tb_use_GV.Location = new System.Drawing.Point(4, 22);
            this.tb_use_GV.Name = "tb_use_GV";
            this.tb_use_GV.Padding = new System.Windows.Forms.Padding(3);
            this.tb_use_GV.Size = new System.Drawing.Size(650, 345);
            this.tb_use_GV.TabIndex = 2;
            this.tb_use_GV.Text = "Google Vision";
            this.tb_use_GV.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1470, 750);
            this.Controls.Add(this.tabControl1);
            this.Location = new System.Drawing.Point(25, 25);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tb_image_analysis.ResumeLayout(false);
            this.tb_image_analysis.PerformLayout();
            this.tab_AnalyzeKeywords.ResumeLayout(false);
            this.tb_Keyword_Category.ResumeLayout(false);
            this.tb_Keyword_Category.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tb_use_GV.ResumeLayout(false);
            this.tb_use_GV.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.TextBox txtpath;
        private System.Windows.Forms.TextBox txtresult;
        private System.Windows.Forms.Button BtnAnyalyze;
        private System.Windows.Forms.ProgressBar myprog;
        private System.Windows.Forms.Button BtnOpen;
        private System.Windows.Forms.TextBox txt_path;
        private System.Windows.Forms.Label lblfilename;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tb_Generate;
        private System.Windows.Forms.TabPage tb_image_analysis;
        private System.Windows.Forms.TabPage tb_Keyword_Category;
        private System.Windows.Forms.TabPage tb_use_GV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton opt1;
        private System.Windows.Forms.RadioButton opt0;
        private System.Windows.Forms.RadioButton opt2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtkeyword;
        private System.Windows.Forms.TextBox txtNoRepeates;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tab_AnalyzeKeywords;
        private System.Windows.Forms.ProgressBar progkeywords;
        private System.Windows.Forms.Button BtnAnyalyzeKeywords;
        private System.Windows.Forms.TabPage tab_categories;
        private System.Windows.Forms.ListBox LstCategories;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtkeywordsearch;
        private System.Windows.Forms.Button BtnGo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnPrev;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.CheckBox ChkSave;
        private System.Windows.Forms.ComboBox cmb_filter;
        private System.Windows.Forms.Button BtnFilter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtrecid;
    }
}

