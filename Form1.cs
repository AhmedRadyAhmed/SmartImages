
using System;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using Microsoft.SqlServer.Server;

namespace JamesApp
{
    public partial class Form1 : Form
    {
        Db Mydb;
        Jmvision Jm;
        DataTable tbcateg;
        int _curentrow = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Mydb = new Db(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\Rady\Db\JMDB.accdb");
            //   Mydb = new Db(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Ahmed\Desktop\JMdb.accdb");
            Jm = new Jmvision();
            Jm.KeyFilePath = @"F:\Rady\Key\mykey.json";
            Mydb.Fill_List("Select CategoryID,Category from Subjects_StoreCategory order by 2 asc", LstCategories);
            Mydb.Fill_Combo("Select Recid,Filtername from tbfilter order by 1 asc", cmb_filter);
            cmb_filter.SelectedValue = 1;
            tbcateg = Mydb.GetTable("Select Keyword,KeywordNo,KeywordPriority,CategoryID,Status,Recid from KeywordsTb order by KeywordNo desc ");
            MovetoRecord(0);
        }
        private void BtnOk_Click(object sender, EventArgs e)
        {
            Jmvision Jm = new Jmvision();
            string mypath = "";
            string mycolors = "";
            Jm.KeyFilePath = @"F:\Rady\Key\mykey.json";
            if (this.txtpath.Text == "")
            {
                MessageBox.Show("Enter the path or url");
                return;
            }
            txtresult.Visible = false;

            mypath = txtpath.Text;

            if (mypath.Contains("http"))
            {
                txtresult.Text = Jm.GetLabels(mypath) + Environment.NewLine + "------------GetLabelsPercentage-----------------" + Environment.NewLine;
                txtresult.Text += Jm.GetLabelsPercentage(mypath) + Environment.NewLine + "-------------GetImageLandMark----------------" + Environment.NewLine;
                txtresult.Text += Jm.GetImageLandMark(mypath) + Environment.NewLine + "---------------GetImageText--------------" + Environment.NewLine;
                //txtresult.Text += Jm.GetImageText(mypath) + Environment.NewLine + "-----------------------------" + Environment.NewLine;
                foreach (var item in Jm.GetImageLColors(mypath))
                {
                    mycolors += item + Environment.NewLine;
                }
                txtresult.Text += mycolors;
            }

            else
            {

                txtresult.Text = Jm.GetLabels(mypath, true) + Environment.NewLine + "------------GetLabelsPercentage-----------------" + Environment.NewLine;
                txtresult.Text += Jm.GetLabelsPercentage(mypath, true) + Environment.NewLine + "-------------GetImageLandMark----------------" + Environment.NewLine;
                txtresult.Text += Jm.GetImageLandMark(mypath, true) + Environment.NewLine + "---------------GetImageText--------------" + Environment.NewLine;
                //txtresult.Text += Jm.GetImageText(mypath, true) + Environment.NewLine + "-----------------------------" + Environment.NewLine;
                foreach (var item in Jm.GetImageLColors(mypath, true))
                {
                    mycolors += item + Environment.NewLine;
                }
                txtresult.Text += mycolors;
            }

            txtresult.Visible = true;

        }


        private void BtnAnyalyze_Click(object sender, EventArgs e)
        {

            txt_path.Text = txt_path.Text.Trim();
            if (txt_path.Text.Trim() == "")
            {
                MessageBox.Show("The location of images.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_path.Focus();
                return;
            }


            if (System.IO.Directory.Exists(txt_path.Text.Trim()) == false)
            {
                MessageBox.Show("Invalid path.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_path.Focus();
                return;

            }


            string[] filePaths = Directory.GetFiles(txt_path.Text, "*.jpg", SearchOption.AllDirectories);
            myprog.Maximum = filePaths.Length;
            myprog.Visible = true;

            lblfilename.Visible = true;
            myprog.Value = 0;
            foreach (var item in filePaths)
            {
                string sl = "";
                lblfilename.Text = Mydb.SqlTxt(item);
                myprog.Value += 1;
                // lblval.Text = (100 * myprog.Value / filePaths.Length).ToString() + " %";
                if (Mydb.GetValue("Select Count(Recid) From PicProps where Picname='" + Mydb.SqlTxt(Path.GetFileName(item)) + "'") == "0")
                {

                    sl = "insert into  PicProps(PicName,picpath,PicKeywords,piccolors,PicColorsSorted,DominantColor) values('";
                    sl += Mydb.SqlTxt(Path.GetFileName(item)) + "','";
                    sl += Mydb.SqlTxt(item) + "','";
                    sl += Mydb.SqlTxt(Jm.GetLabels(item, true)) + "','";
                    sl += Mydb.SqlTxt(Jm.GetImageLColors(item, true)) + "','";
                    sl += Mydb.SqlTxt(Jm.GetUniq_Colors()) + "','";
                    sl += Mydb.SqlTxt(Jm.GetUniq_Color()) + "')";
                    Mydb.Execute(sl);
                }
            }

            myprog.Visible = false;

            lblfilename.Visible = false;
        }

      
 


        private void BtnOpen_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fdg = new FolderBrowserDialog();

            if (fdg.ShowDialog() == DialogResult.OK)
                txt_path.Text = fdg.SelectedPath;
            else
                return;

        }

        private void BtnAnyalyzeKeywords_Click(object sender, EventArgs e)
        {
            Hashtable _tb = new Hashtable();
            DataTable tb = new DataTable();
            tb = Mydb.GetTable("Select PicKeywords from picprops");
            foreach (DataRow r in tb.Rows)
            {
                string[] x = r[0].ToString().Split(',');
                foreach (var item in x)
                {
                    if (item != "")
                    {
                        string[] y = item.Split(':');
                        if (!_tb.ContainsKey(y[0]))
                            _tb.Add(y[0], 1);
                        else
                        {
                            _tb[y[0]] = Convert.ToInt32(_tb[y[0]]) + 1;
                        }
                    }
                }

            }
            progkeywords.Maximum = _tb.Count;
            progkeywords.Visible = true;
            foreach (DictionaryEntry de in _tb)
            {
                string sl = "";
                if (Mydb.GetValue("Select Count(recid) from KeywordsTb where Keyword='" + Mydb.SqlTxt(de.Key.ToString()) + "'") == "0")
                    sl = "insert into KeywordsTb(Keyword,KeywordNo) values('" + Mydb.SqlTxt(de.Key.ToString()) + "'," + de.Value.ToString() + ")";
                else
                    sl = "update KeywordsTb set KeywordNo=" + de.Value.ToString() + " where Keyword='" + Mydb.SqlTxt(de.Key.ToString()) + "'";
                Mydb.Execute(sl);
                progkeywords.Value += 1;
            }

            progkeywords.Visible = false;
        }
        void MovetoRecord(int index)
        {
            int _priority = 0;
            string sl = "";
            if (ChkSave.Checked == true)
            {
                if (opt1.Checked == true)
                    _priority = 1;
                if (opt2.Checked == true)
                    _priority = 2;

                if (_priority == 0 && LstCategories.SelectedValue.ToString() != "0" || _priority != 0 && LstCategories.SelectedValue.ToString() == "0")
                {
                    MessageBox.Show("Category is not allwed with priority 0 & Category 0 with priority greater  than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
              sl= "update KeywordsTb set KeywordPriority=" + _priority.ToString() + ",CategoryID=" + LstCategories.SelectedValue.ToString() + ",Status=true,TranDate=Date() where Keyword='" + txtkeyword.Text + "'";
                Mydb.Execute(sl);
            }
          
            sl = "Select Keyword, KeywordNo, KeywordPriority, CategoryID, Status,Recid from KeywordsTb";
            if (cmb_filter.SelectedValue.ToString() == "1")
                sl += "  order by KeywordNo desc ";
            if (cmb_filter.SelectedValue.ToString() == "2")
                sl += " where status = true order by KeywordNo desc ";
            if (cmb_filter.SelectedValue.ToString() == "3")
                sl += " where status = false order by KeywordNo desc ";
            tbcateg = Mydb.GetTable(sl);

            txtrecid.Text =(1+ _curentrow).ToString() + "/" + tbcateg.Rows.Count.ToString();
            txtkeyword.Text = tbcateg.Rows[index][0].ToString();
            txtNoRepeates.Text = String.Format("{0:#,##0.##}", Convert.ToInt16(tbcateg.Rows[index][1].ToString()));
            LstCategories.SelectedValue = tbcateg.Rows[index][3].ToString();
            switch (tbcateg.Rows[index][2].ToString())
            {
                case "1":
                    opt1.Checked = true;
                    break;
                case "2":
                    opt2.Checked = true;
                    break;
                default:
                    opt0.Checked = true;
                    break;
            }
        }

      
        private void BtnPrev_Click(object sender, EventArgs e)
        {
            if (_curentrow > 0)
                _curentrow -= 1;
            MovetoRecord(_curentrow);
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (_curentrow < tbcateg.Rows.Count - 1)
                _curentrow += 1;
            MovetoRecord(_curentrow);
        }

        private void BtnGo_Click(object sender, EventArgs e)
        {
            int i = 0;
            bool flag = false;
            string s = txtkeywordsearch.Text.Trim().ToLower();
            for (i = 0; i < tbcateg.Rows.Count; i++)
            {
                if (tbcateg.Rows[i][0].ToString().ToLower() == s)
                {
                    flag = true;
                    break;
                }
            }

            if (flag == true)
            {
                _curentrow = i;
                MovetoRecord(_curentrow);
            }
            else
            {
                MessageBox.Show("Keword Dosn't Exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            //string s = txtkeywordsearch.Text.Trim();
            //var _tb = (from n in tbcateg.AsEnumerable()
            //           where n.Field<string>("Keyword").Equals(s)
            //           select n).CopyToDataTable();
            //txtkeyword.Text = _tb.Rows[0][0].ToString();
            //txtNoRepeates.Text = _tb.Rows[0][1].ToString();
            //LstCategories.SelectedValue = _tb.Rows[0][3].ToString();
            //switch (_tb.Rows[0][2].ToString())
            //{
            //    case "1":
            //        opt1.Checked = true;
            //        break;
            //    case "2":
            //        opt2.Checked = true;
            //        break;
            //    default:
            //        opt0.Checked = true;
            //        break;
            //}

        }

        private void BtnAnyalyzeKeywords_Click_1(object sender, EventArgs e)
        {
            Hashtable _tb = new Hashtable();
            DataTable tb = new DataTable();
            tb = Mydb.GetTable("Select PicKeywords from picprops");
            foreach (DataRow r in tb.Rows)
            {
                string[] x = r[0].ToString().Split(',');
                foreach (var item in x)
                {
                    if (item != "")
                    {
                        string[] y = item.Split(':');
                        if (!_tb.ContainsKey(y[0]))
                            _tb.Add(y[0], 1);
                        else
                        {
                            _tb[y[0]] = Convert.ToInt32(_tb[y[0]]) + 1;
                        }
                    }
                }

            }
            progkeywords.Maximum = _tb.Count;
            progkeywords.Visible = true;
            foreach (DictionaryEntry de in _tb)
            {
                string sl = "";
                if (Mydb.GetValue("Select Count(recid) from KeywordsTb where Keyword='" + Mydb.SqlTxt(de.Key.ToString()) + "'") == "0")
                    sl = "insert into KeywordsTb(Keyword,KeywordNo) values('" + Mydb.SqlTxt(de.Key.ToString()) + "'," + de.Value.ToString() + ")";
                else
                    sl = "update KeywordsTb set KeywordNo=" + de.Value.ToString() + " where Keyword='" + Mydb.SqlTxt(de.Key.ToString()) + "'";
                Mydb.Execute(sl);
                progkeywords.Value += 1;
            }

            progkeywords.Visible = false;
            tbcateg = Mydb.GetTable("Select Keyword,KeywordNo,KeywordPriority,CategoryID,Status,Recid from KeywordsTb order by KeywordNo desc ");
        }

        private void BtnFilter_Click(object sender, EventArgs e)
        {

            MovetoRecord(0);
        }
     
    }
}
