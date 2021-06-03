
using System;
using System.Data;
using System.Drawing;
using System.Configuration;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Drawing.Imaging;
namespace JamesApp
{

    public partial class FrmArt : Form
    {
       
        Jmvision Jm;
        DataTable tb_path;
        DataTable Art_tb;
        string sku = "";
        public FrmArt()
        {
            InitializeComponent();
        }

       
      

        private string GetTitle(string _artist, string _title)
        {
            int totallen, titlelen, artistlen;
            string mytitle = "";
            artistlen = _artist.Length;
            titlelen = _title.Length;
            totallen = artistlen + titlelen;
            if (totallen < 80)
            {
                mytitle = _artist + " " + _title;
            }
            else if (totallen >= 80)
            {
                if ((artistlen <= 80 && titlelen <= 80) || (artistlen <= 80 && titlelen > 80))
                    mytitle = _artist;
                if ((artistlen > 80 && titlelen > 80))
                    mytitle = "";
                if ((artistlen > 80 && titlelen <= 80))
                    mytitle = _title;
            }
            return mytitle;
        }
        private string ReplaceFirstOccurrence(string Source, string Find, string Replace)
        {
            int Place = Source.IndexOf(Find);
            string result = Source.Remove(Place, Find.Length).Insert(Place, Replace);
            return result;
        }

        private string RemoveBr(string s)
        {
            if (s.IndexOf("(") == -1)
                return s;
            else
            {
                int Place1 = s.ToString().IndexOf("(");
                int Place2 = s.ToString().IndexOf(")");
                s = s.ToString().Remove(Place1, Place2 - Place1 + 1);
                return RemoveBr(s);
            }
        }
       
        private void BtnFolderArt_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fdg = new FolderBrowserDialog();

            if (fdg.ShowDialog() == DialogResult.OK)
                CameraPath.Text = fdg.SelectedPath;
            else
                return;
        }

        private void cmbTypeMedia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTypeMedia.SelectedValue == null)
                return;
            if (cmbTypeMedia.SelectedValue.ToString().ToLower() == "other")
            {
                txtCustom_TypeMedia.Visible = true;
                cmbTypeMedia.Width = 205;
            } 
            else
            {
                txtCustom_TypeMedia.Visible = false;
                cmbTypeMedia.Width = 410;
            }
                

        }

        private void BtnNewArtItem_Click(object sender, EventArgs e)
        {
            const double pixelsToInch = (57.00787 * 2.54);
            String camPath = "";
            string sofaPath = tb_path.Rows[0]["SofaPath"].ToString();
            string ftp_Path = tb_path.Rows[0]["FTP_Path"].ToString();
            string highResPath = tb_path.Rows[0]["HighResolution_Path"].ToString();
            string resizedPath = tb_path.Rows[0]["ResizePath"].ToString();
            string _hr_fileName = "";
            string my_path = Environment.CurrentDirectory;
            Boolean isMainimage = false;
            Boolean isFramedImage = false;
            camPath = CameraPath.Text;
            string[] filePaths;
            string sl = "";
            Size _mSize = new Size();
            Size _fSize = new Size();
            if (Db.GetValue("Select Count(*) from Art_Process") == "0" && SKU.Text == "")
            {
                if (camPath == "")
                {
                    MessageBox.Show("Enter the path or Image", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    CameraPath.Focus();
                    return;
                }
                if (Utfile.IsValidPath(camPath) == false)
                {
                    MessageBox.Show("Invalid path", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    CameraPath.Focus();
                    return;
                }

                filePaths = Directory.GetFiles(camPath, "*.jpg", SearchOption.TopDirectoryOnly);
                if (filePaths.Length == 0)
                {
                    MessageBox.Show("There are no images", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    CameraPath.Focus();
                    return;
                }

                foreach (var item in filePaths)
                {
                    if (Path.GetFileName(item).ToLower() == "m.jpg")
                    {
                        isMainimage = true;
                        _mSize = GetImageSize(item);
                    }
                    if (Path.GetFileName(item).ToLower() == "f.jpg")
                    {
                        isFramedImage = true;
                        _fSize = GetImageSize(item);
                    }
                }
                if (isMainimage == false)
                {
                    MessageBox.Show("There are no Main image", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            if (txtArtistName.Text.Trim() == "")
            {
                MessageBox.Show("Enter the Artist Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtArtistName.Focus();
                return;
            }
            if (txtPublishTitle.Text.Trim() == "")
            {
                MessageBox.Show("Enter the Art Work Title", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPublishTitle.Focus();
                return;
            }
            if (txtPrice.Text.Trim() == "")
            {
                MessageBox.Show("Enter the Price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrice.Focus();
                return;
            }

            if (UtNumers.IsNumeric(txtPrice.Text.Trim()) == false)
            {
                MessageBox.Show("Invalid Price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrice.Focus();
                return;
            }
            if (cmbCondition_Report.SelectedValue == null)
            {
                MessageBox.Show("Enter the Condition Report", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbCondition_Report.Focus();
                return;
            }
            if (cmbTypeMedia.SelectedValue == null)
            {
                MessageBox.Show("Enter the Type/Media", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbTypeMedia.Focus();
                return;
            }
            if (lstArt_Style.SelectedValue == null)
            {
                MessageBox.Show("Enter the Style", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lstArt_Style.Focus();
                return;
            }
            if (lstFYear.Text.Trim() == "")
            {
                MessageBox.Show("Enter the Year", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lstFYear.Focus();
                return;
            }

            string _DtCreation = GetDateOfCreation(lstFYear);
            if (_DtCreation == "")
            {
                MessageBox.Show("Enter ot Choose Valid Year");
                lstFYear.Focus();
                return;
            }
            if (_DtCreation == "txt")
            {
                MessageBox.Show("InValid Year Format");
                lstFYear.Focus();
                return;
            }
            if (_DtCreation == "inv")
            {
                MessageBox.Show("InValid Year");
                lstFYear.Focus();
                return;
            }

            if (cmbSigned.SelectedValue == null)
            {
                MessageBox.Show("Enter the Signed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbSigned.Focus();
                return;
            }
            if (cmbSubject.SelectedValue == null)
            {
                MessageBox.Show("Enter Subject", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbSubject.Focus();
                return;
            }
           
           
            DataTable tb = new DataTable();
            string weburl = Db.GetValue("select ARTImagesURL from TbSettings");
            tb = Db.GetTable("Select * from Art_Desc");
            string html_Description = "";
            if (SKU.Text != "")
            {
                html_Description = Utfile.GetHtmlArt(Db.SqlTxt(txtPublishTitle.Text), Db.SqlTxt(txtArtistName.Text), _txtsize.Text, Db.SqlTxt(cmbTypeMedia.SelectedValue.ToString()), Db.SqlTxt(lstFYear.Text), Db.SqlTxt(cmbCondition_Report.SelectedValue.ToString()), Db.SqlTxt(txtUsedPub.Text.Trim()), Db.SqlTxt(txtNotes.Text.Trim()), _txturls.Text, weburl, tb);
                sl = "Update Art_Data set ";
                sl += "Artist='" + Db.SqlTxt(txtArtistName.Text) + "',";
                sl += "PublishTitle='" + Db.SqlTxt(txtPublishTitle.Text) + "',";
                sl += "Price=" + txtPrice.Text + ",";
                sl += "Condition_Report='" + Db.SqlTxt(cmbCondition_Report.SelectedValue.ToString()) + "',";
                sl += "TypeMedia='" + Db.SqlTxt(cmbTypeMedia.SelectedValue.ToString()) + "',";
                sl += "Art_Style='" + Db.SqlTxt(lstArt_Style.SelectedValue.ToString()) + "',";
                sl += "Fyear='" + Db.SqlTxt(lstFYear.Text) + "',";
                sl += "DateOfCreation='" + Db.SqlTxt(_DtCreation) + "',";
                sl += "Signed='" + Db.SqlTxt(cmbSigned.SelectedValue.ToString()) + "',";
                sl += "Subject='" + Db.SqlTxt(cmbSubject.SelectedValue.ToString()) + "',";
                sl += "Keywords='" + Db.SqlTxt(txtKeywords.Text) + "',";
                sl += "UsedinPublication='" + Db.SqlTxt(txtUsedPub.Text) + "',";
                sl += "Notes='" + Db.SqlTxt(txtNotes.Text) + "',";
                sl += "HTmlDescription='" + Db.SqlTxt(html_Description) + "'";
                sl += " where Sku='" + SKU.Text + "'";
                Db.Execute(sl);
                Get_Smart_Data(SKU.Text);
                this.SKU.Text = "";
                if (((Button)sender).Tag.ToString() == "1")
                {
                    BtnClear_Click(sender, e);
                    BtnSearch_Click(sender, e);
                }

                return;
            }
            if (Db.GetValue("Select Count(*) from Art_Process") == "0")
            {
                Utfile.RemoveFile(my_path + @"\F.jpg");
                Utfile.RemoveFile(my_path + @"\M.jpg");
                if (isFramedImage == true)
                {
                    Utfile.MoveFile(camPath + @"\F.jpg", my_path + @"\F.jpg", true);
                    System.Diagnostics.Process.Start("Sofadroplet.exe", my_path + @"\F.jpg");
                }
                else
                {
                    Utfile.MoveFile(camPath + @"\M.jpg", my_path + @"\M.jpg", true);
                    System.Diagnostics.Process.Start("Sofadroplet.exe", my_path + @"\M.jpg");
                }
                System.Threading.Thread.Sleep(15000);
                Utfile.MoveFiles(sofaPath, camPath);
                System.Threading.Thread.Sleep(15000);
                filePaths = Directory.GetFiles(camPath, "*.jpg", SearchOption.TopDirectoryOnly);

                _hr_fileName = Utfile.ChangeNames(filePaths, camPath);  //hr high resolution
                string[] myfilesNames = _hr_fileName.ToString().Split(':');
                _hr_fileName = myfilesNames[0];
                Utfile.MoveFile(camPath + @"\" + _hr_fileName, highResPath + @"\" + _hr_fileName, true);

                Utfile.MoveFiles(camPath, my_path + @"\Camera_Output");
                System.Diagnostics.Process.Start("Resized.exe", my_path + @"\Camera_Output");
                System.Threading.Thread.Sleep(15000);
                Utfile.RemoveFiles(my_path + @"\Camera_Output");
                Utfile.MoveFiles(resizedPath, ftp_Path);


                sku = _hr_fileName.Substring(0, _hr_fileName.IndexOf('_'));
                int _mhi, _mwi, _fhi, _fwi, _mhc, _mwc, _fwc, _fhc;  //m main  ,f frame, w width ,h height,i inch ,c cm

                _mhi = UtNumers.RoundByLimit(_mSize.Height / pixelsToInch);
                _mwi = UtNumers.RoundByLimit(_mSize.Width / pixelsToInch);
                _fhi = UtNumers.RoundByLimit(_fSize.Width / pixelsToInch);
                _fwi = UtNumers.RoundByLimit(_fSize.Width / pixelsToInch);

                _mhc = UtNumers.RoundByLimit(_mhi * 2.54);
                _mwc = UtNumers.RoundByLimit(_mwi * 2.54);
                _fhc = UtNumers.RoundByLimit(_fhi * 2.54);
                _fwc = UtNumers.RoundByLimit(_fwi * 2.54);



                string _artSsize = GetSize(_mwi, _mhi, _fwi, _fhi);
                string _sz = $"{_mhi}\"x{_mwi}\" ({_mhc}x{_mwc}cm)";

                //Generate html description


                html_Description = Utfile.GetHtmlArt(Db.SqlTxt(txtPublishTitle.Text), Db.SqlTxt(txtArtistName.Text), _sz, Db.SqlTxt(cmbTypeMedia.SelectedValue.ToString()), Db.SqlTxt(lstFYear.Text), Db.SqlTxt(cmbCondition_Report.SelectedValue.ToString()), Db.SqlTxt(txtUsedPub.Text.Trim()), Db.SqlTxt(txtNotes.Text), myfilesNames[1], weburl, tb);
                //-------------------------------------------------------------------

                sl = "insert into Art_Data(SKU, Title, M_Height, M_Width, F_Height,F_Width,MHI,MWI,MHC,MWC,FHI,FWI,FHC,FWC, Art_Size,Art_Size_InCm , Artist, PublishTitle, Price, Condition_Report, TypeMedia,Art_Style,Fyear, DateOfCreation,Signed, Subject,  Keywords, UsedinPublication,PicUrl, Notes,HTmlDescription) values('";
                sl += sku + "','";
                sl += "',";
                sl += _mSize.Height + ",";
                sl += _mSize.Width + ",";
                sl += _fSize.Height + ",";
                sl += _fSize.Width + ",";
                sl += _mhi + ",";
                sl += _mwi + ",";
                sl += _mhc + ",";
                sl += _mwc + ",";
                sl += _fhi + ",";
                sl += _fwi + ",";
                sl += _fhc + ",";
                sl += _fwc + ",'";
                sl += _artSsize + "','";
                sl += _sz + "','";
                sl += Db.SqlTxt(txtArtistName.Text) + "','";
                sl += Db.SqlTxt(txtPublishTitle.Text) + "',";
                sl += txtPrice.Text + ",'";
                sl += Db.SqlTxt(cmbCondition_Report.SelectedValue.ToString()) + "','";
                sl += Db.SqlTxt(cmbTypeMedia.SelectedValue.ToString()) + "','";
                sl += Db.SqlTxt(lstArt_Style.SelectedValue.ToString()) + "','";
                sl += Db.SqlTxt(lstFYear.Text) + "','";
                sl += Db.SqlTxt(_DtCreation) + "','";
                sl += Db.SqlTxt(cmbSigned.SelectedValue.ToString()) + "','";
                sl += Db.SqlTxt(cmbSubject.SelectedValue.ToString()) + "','";
                sl += Db.SqlTxt(txtKeywords.Text) + "','";
                sl += Db.SqlTxt(txtUsedPub.Text) + "','";
                sl += myfilesNames[1] + "','";
                sl += Db.SqlTxt(txtNotes.Text) + "','";
                sl += Db.SqlTxt(html_Description) + "')";
                Db.Execute(sl);


                SendFiles(myfilesNames[1], ftp_Path);
                Db.Execute("insert into ART_Process(Sku) values('" + sku + "')");

                RunGoogleVision_AddTo_PicProps(ftp_Path + @"\" + sku + "_M-1400.jpg", sku, Db.SqlTxt(txtKeywords.Text));
            }
            else
            {
                sku = Db.GetValue("Select sku from Art_Process");
            }

            string N_keywords = AddKeyWords(sku);
            if (N_keywords == "")
            {
                Get_Smart_Data(sku);
                Db.Execute("delete From  ART_Process where sku='" + sku + "'");
                sku = "";
                if (((Button)sender).Tag.ToString() == "1")
                {
                    BtnClear_Click(sender, e);
                    BtnSearch_Click(sender, e);
                }

                BtnClear_Click(sender, e);
                BtnSearch_Click(sender, e);
            }
            else
            {
                Refresh_List_With_New_Kewords(N_keywords);
            }
        }

        private void Refresh_List_With_New_Kewords(string s)
        {
            lstnewkeywords.Items.Clear();
            string[] ss = s.Split(',');
            foreach (var item in ss)
            {
                if (item != "")
                    lstnewkeywords.Items.Add(item);

            }
            PnlNewKeywords.Visible = true;
        }
        private Size GetImageSize(string imagepath)
        {
            Size s = new Size();
            var fileStream = new FileStream(imagepath, FileMode.Open, FileAccess.Read, FileShare.Read);
            var image = Image.FromStream(fileStream, false, false);
            var height = image.Height;
            var width = image.Width;
            s.Width = width;
            s.Height = height;
            fileStream.Close();
            fileStream.Dispose();
            image.Dispose();
            return s;
        }

        private bool RunGoogleVision_AddTo_PicProps(string item, string sku, string keywords)
        {
            bool flag = false;
            if (Db.GetValue("Select Count(Recid) From PicProps where Picname='" + Db.SqlTxt(Path.GetFileName(item)) + "'") == "0")
            {
                string sl = "";
                List<String> myNudeList = new List<String>();
                myNudeList.Add("VeryLikely");
                myNudeList.Add("Likely");
                myNudeList.Add("Possible");
                string _lb = Db.SqlTxt(Jm.GetLabels(item, true));
                string _safelb = Db.SqlTxt(Jm.GetSafSearch(item, true));
                if (myNudeList.Contains(_safelb))
                    _lb += "Nude";
                sl = "insert into  PicProps(Sku_PicProps,PicName,picpath,PicKeywords,PicKeywordsDataEntry,safsearch,piccolors,PicColorsSorted,DominantColor,CSharColors,GooGleVisionColors,ComplexColors) values('";
                sl += sku + "','";
                sl += Db.SqlTxt(Path.GetFileName(item)) + "','";
                sl += Db.SqlTxt(item) + "','";
                sl += _lb + "','";
                sl += keywords + "','";
                sl += _safelb + "','";
                sl += Db.SqlTxt(Jm.GetImageLColors(item, true)) + "','";
                sl += Db.SqlTxt(Jm.GetUniq_Colors()) + "','";
                sl += Db.SqlTxt(Jm.GetUniq_Color()) + "','";
                sl += Db.SqlTxt(Jm.GetCSharp_Colors()) + "','";
                sl += Db.SqlTxt(Jm.GetGoog_Vision_Colors()) + "','";
                sl += Db.SqlTxt(Jm.GetcomplexColors()) + "')";
                Db.Execute(sl);
                flag = true;
            }
            return flag;
        }
        private string AddKeyWords(string sku)
        {
            string sl = "";
            Hashtable _tb = new Hashtable();
            DataTable tb = new DataTable();
            tb = Db.GetTable("Select PicKeywords +',' + PicKeywordsDataEntry as PicKeywords ,Sku_PicProps from picprops where IsKeyWordAnalyzed=false and   Sku_PicProps='" + sku + "'");
            if (tb.Rows.Count == 0)
                return "";
            string[] x = tb.Rows[0][0].ToString().Split(',');
            foreach (var item in x)
            {
                if (item != "")
                {
                    string[] y = item.Split(':');
                    if (!_tb.ContainsKey(y[0]))
                        _tb.Add(y[0], 1);
                    else
                        _tb[y[0]] = Convert.ToInt32(_tb[y[0]]) + 1;

                }
            }
            int _new_keyWord_no = 0;
            string _new_keyWords = "";
            foreach (DictionaryEntry de in _tb)
            {
                if (Db.GetValue("Select Count(recid) from KeywordsTb where Keyword='" + Db.SqlTxt(de.Key.ToString()) + "'") == "0")
                {
                    sl = "insert into KeywordsTb(Keyword,KeywordNo) values('" + Db.SqlTxt(de.Key.ToString()) + "'," + de.Value.ToString() + ")";
                    _new_keyWords += Db.SqlTxt(de.Key.ToString()) + ",";
                    _new_keyWord_no += 1;
                }
                else
                    sl = "update KeywordsTb set KeywordNo=KeywordNo+" + de.Value.ToString() + " where Keyword='" + Db.SqlTxt(de.Key.ToString()) + "'";
                Db.Execute(sl);
            }
            sl = "UPDATE PicProps SET PicProps.IsKeyWordAnalyzed = Yes WHERE(((PicProps.Sku_PicProps) ='" + sku + "'))";
            Db.Execute(sl);
            if (_new_keyWords == "")
                return "";
            else
                return _new_keyWords;
        }
        private String GetSize(int mw, int mh, int fw, int fh)
        {
            double max = 0;
            string s = "";
            if (mw > max)
                max = mw;
            if (mh > max)
                max = mh;
            if (fw > max)
                max = fw;
            if (fh > max)
                max = fh;
            if (max <= 6)
                s = "Mini(up to 6in.)";
            else if (max <= 12)
                s = "Small (up to 12in.)";
            else if (max <= 36)
                s = "Medium(up to 36in.)";
            else if (max <= 60)
                s = "Large(up to 60in.)";
            else if (max > 60)
                s = "Giant(over 60in.)";
            return s;
        }
        private string GetDateOfCreation(ComboBox lst)
        {
            string s = "";

            if (lstFYear.SelectedValue != null)
                s = lstFYear.SelectedValue.ToString();
            else if (lstFYear.Text != "")
            {
                s = lstFYear.Text;
                int i;
                bool b = int.TryParse(s, out i);
                if (!b)
                    s = "txt";//text input 
                else if (i < 1500 || i > DateTime.Now.Year)
                    s = "inv"; //out of range year
                else if (i >= 1980)
                    s = "Contemporary";
                else if (i >= 1900 || i <= 1979)
                    s = "Modern";
                else if (i < 1900)
                    s = "Antique";
            }

            return s;
        }

        private void BtnGenerateCSV_Click(object sender, EventArgs e)
        {

            Export_Tb_To_CSV(Art_tb);


        }

        private void Export_Tb_To_CSV(DataTable tb)
        {
            SaveFileDialog dgSave = new SaveFileDialog();
            dgSave.InitialDirectory = @"C:\";
            dgSave.Title = "Save text Files";

            dgSave.CheckPathExists = true;
            dgSave.FileName = "Art_" + DateTime.Now.ToLongDateString()+ " " + DateTime.Now.ToShortTimeString();
            dgSave.Filter = "CSV files (*.csv)|*.csv";
            dgSave.RestoreDirectory = true;
            if (dgSave.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(dgSave.FileName))
                {
                    Dt_To_CSV.WriteDataTable(tb, writer, true);
                }
            }
        }
       

        public void SendFiles(string s, string ftppath)
        {
           
            string my_path = Environment.CurrentDirectory;
            string[] _files = s.Split('|');
            foreach (var item in _files)
            {
                if (item != "")
                {
                    Utfile.MoveFile(ftppath + @"\" + item, my_path + @"\" + item, true);
                    FTPServer.Send(item);
                    Utfile.RemoveFile(my_path + @"\" + item);

                }


            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            Art_tb = new DataTable();
            string sl = "Select * From Q_Art where Recid<>-1";
            if (txtArtistName.Text != "")
            {
                sl += " and Artist like '%" + txtArtistName.Text + "%'";
            }

            if (txtPublishTitle.Text != "")
            {
                sl += " and PublishTitle like '%" + txtPublishTitle.Text + "%'";
            }
            if (txtPrice.Text != "")
            {
                sl += " and Price=" + txtPrice.Text;
            }
            if (cmbCondition_Report.SelectedValue != null)
            {
                sl += " and Condition_Report ='" + cmbCondition_Report.SelectedValue.ToString() + "'";
            }
            if (cmbTypeMedia.SelectedValue != null)
            {
                sl += " and TypeMedia ='" + cmbTypeMedia.SelectedValue.ToString() + "'";
            }
            if (lstArt_Style.SelectedValue != null)
            {
                sl += " and Art_Style ='" + lstArt_Style.SelectedValue.ToString() + "'";
            }
            if (lstFYear.Text != "")
            {
                sl += " and Fyear ='" + lstFYear.Text + "'";
            }
            if (cmbSigned.SelectedValue != null)
            {
                sl += " and Signed ='" + cmbSigned.SelectedValue.ToString() + "'";
            }
            if (cmbSubject.SelectedValue != null)
            {
                sl += " and Subject ='" + cmbSubject.SelectedValue.ToString() + "'";
            }
            if (txtKeywords.Text != "")
            {
                sl += " and Keywords like '%" + txtKeywords.Text + "%'";
            }
            if (txtUsedPub.Text != "")
            {
                sl += " and UsedinPublication like '%" + txtUsedPub.Text + "%'";
            }
            if (txtNotes.Text != "")
            {
                sl += " and Notes like '%" + txtNotes.Text + "%'";
            }

            Art_tb = Db.GetTable(sl);
            gridArt.DataSource = Art_tb;
            gridArt.Refresh();
            tabControl1.SelectedTab = tb_Generate;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtArtistName.Text = "";
            txtPublishTitle.Text = "";
            txtPrice.Text = "";
            cmbCondition_Report.SelectedValue = -1;
            cmbTypeMedia.SelectedValue = -1;
            lstArt_Style.SelectedValue = -1;
            lstFYear.SelectedValue = -1;
            cmbSigned.SelectedValue = -1;
            cmbSubject.SelectedValue = -1;
            txtKeywords.Text = "";
            txtUsedPub.Text = "";
            txtNotes.Text = "";
        }

        private void FrmArt_Load(object sender, EventArgs e)
        {
            Jm = new Jmvision();
            Jm.KeyFilePath = @"F:\Rady\Key\mykey.json";

            tb_path = new DataTable();
            tb_path = Db.GetTable("Select * from Tb_Setting");
            CameraPath.Text = tb_path.Rows[0]["CameraPath"].ToString();
           

            Db.Fill_List("Select CategoryID,Category from Subjects_StoreCategory order by 2 asc", LstCategories);
            Db.Fill_Combo("Select Fname,Fname  from Art_Condition_Report order by recid", cmbCondition_Report);
            Db.Fill_Combo("Select Fname,Fname  from Art_Singed order by recid", cmbSigned);
            Db.Fill_Combo("Select Fname,Fname from Art_Type_Media order by recid", cmbTypeMedia);
            Db.Fill_Combo("Select Ftype,FYear from Art_Year order by recid", lstFYear);
            Db.Fill_Combo("Select Fname,Fname from Art_Style order by recid", lstArt_Style);
            Db.Fill_Combo("Select Category,Category from Subjects_StoreCategory order by 2 asc ", cmbSubject);
            gridArt.DataSource = Db.GetTable("Select * from Q_ART");
            gridArt.Refresh();
        }

        private void BtnFolderArt_Click_1(object sender, EventArgs e)
        {
            FolderBrowserDialog fdg = new FolderBrowserDialog();

            if (fdg.ShowDialog() == DialogResult.OK)
                CameraPath.Text = fdg.SelectedPath;
            else
                return;
        }

        private void gridArt_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            DataGridViewRow row = gridArt.Rows[i];

            SKU.Text = gridArt.Rows[i].Cells["SKU"].Value.ToString();
            _txtsize.Text = gridArt.Rows[i].Cells["Art_Size_InCm"].Value.ToString();  
            _txturls.Text = gridArt.Rows[i].Cells["PicUrl"].Value.ToString();
            txtArtistName.Text = gridArt.Rows[i].Cells["Artist"].Value.ToString();
            txtPublishTitle.Text = gridArt.Rows[i].Cells["PublishTitle"].Value.ToString();
            txtPrice.Text = gridArt.Rows[i].Cells["Price"].Value.ToString();
            cmbCondition_Report.SelectedValue = gridArt.Rows[i].Cells["Condition_Report"].Value.ToString();
            cmbTypeMedia.SelectedValue = gridArt.Rows[i].Cells["TypeMedia"].Value.ToString();
            lstArt_Style.SelectedValue = gridArt.Rows[i].Cells["Art_Style"].Value.ToString();
            lstFYear.Text = gridArt.Rows[i].Cells["Fyear"].Value.ToString();
            cmbSigned.SelectedValue = gridArt.Rows[i].Cells["Signed"].Value.ToString();
            cmbSubject.SelectedValue = gridArt.Rows[i].Cells["Subject"].Value.ToString();
            txtKeywords.Text = gridArt.Rows[i].Cells["Keywords"].Value.ToString();
            txtUsedPub.Text = gridArt.Rows[i].Cells["UsedinPublication"].Value.ToString();
            txtNotes.Text = gridArt.Rows[i].Cells["Notes"].Value.ToString();
            tabControl1.SelectedTab = tabArt;
        }
        private void BtnOpenHtml_Click(object sender, EventArgs e)
        {
            if (this.SKU.Text=="")
            {
                MessageBox.Show("There is Item Selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string s = Db.GetValue("Select HTmlDescription from Art_data where SKu='" + SKU.Text + "'");
            string my_path = Environment.CurrentDirectory;
            string myHtml = my_path + @"\myhtml.html";
            File.WriteAllText(myHtml, s);
            System.Diagnostics.Process.Start(myHtml);
        }

        private void Get_Smart_Data(string _sku)
        {
            DataTable tb_data = new DataTable();
            DataTable tbrules = new DataTable();
            DataTable tbFillingKewords = new DataTable();
            DataTable tbCateg_Keywords = new DataTable();
            DataTable temp_tbkeycateg = new DataTable();
            DataTable temp_tbkeycateg2 = new DataTable();


            tb_data = Db.GetTable("SELECT T.Artist, T.[PublishTitle], T.Artist AS New_Title, S.Category, S.Category as Generated_Category , S.Categoryid, p.PicKeywords +','+ T.Keywords as PicKeywords ,ComplexColors,T.SKU  FROM(Art_data AS T LEFT JOIN Subjects_StoreCategory AS S ON T.Subject = S.Category) INNER JOIN PicProps AS P ON T.SKU = P.Sku_PicProps where T.Sku='" + _sku + "' order by T.Recid");
            tbFillingKewords = Db.GetTable("SELECT FilingWords FROM Tb_setting");
            tbrules = Db.GetTable("SELECT * FROM TitleGenerateRulesTb");
            tbCateg_Keywords = Db.GetTable("SELECT S.CategoryID, S.Category, S.CategoryPriority,K.Keyword,len(K.Keyword) as Keyword_len , K.KeywordNo, K.KeywordPriority,MasterKeyword  FROM Subjects_StoreCategory AS S INNER JOIN KeywordsTb AS K ON S.CategoryID = K.CategoryID WHERE S.CategoryID <> 0  order by K.KeywordPriority desc, len(K.Keyword) asc ");
            temp_tbkeycateg = Db.GetTable("SELECT S.CategoryID, S.Category, S.CategoryPriority,S.Category as Keyword,S.Category as  Keyword_len , S.Category as KeywordNo, S.Category as KeywordPriority , S.Category as New_res FROM Subjects_StoreCategory as S where  S.CategoryID=-1");


            //Remove and Replace based on TitleGenerateRulesTb Table
            for (int i = 0; i < tb_data.Rows.Count; i++)
            {
                foreach (DataRow r1 in tbrules.Rows)
                {
                    string oldtxt = r1["oldtxt"].ToString().Replace('-', ' ');
                    string newtxt = r1["newtxt"].ToString().Replace('-', ' '); ;
                    string instanceNo = r1["instanceNo"].ToString();
                    if (instanceNo == "0")
                    {
                        tb_data.Rows[i][0] = tb_data.Rows[i][0].ToString().Replace(oldtxt, newtxt);
                        tb_data.Rows[i][1] = tb_data.Rows[i][1].ToString().Replace(oldtxt, newtxt);
                    }

                    if (instanceNo == "1" && tb_data.Rows[i][0].ToString().Contains(oldtxt))
                        tb_data.Rows[i][0] = ReplaceFirstOccurrence(tb_data.Rows[i][0].ToString(), oldtxt, newtxt);
                    if (instanceNo == "1" && tb_data.Rows[i][1].ToString().Contains(oldtxt))
                        tb_data.Rows[i][1] = ReplaceFirstOccurrence(tb_data.Rows[i][1].ToString(), oldtxt, newtxt);


                    if (oldtxt == "(")//&& tb_data.Rows[i][0].ToString().Contains(oldtxt))
                    {
                        tb_data.Rows[i][0] = RemoveBr(tb_data.Rows[i][0].ToString());
                        tb_data.Rows[i][1] = RemoveBr(tb_data.Rows[i][1].ToString());
                    }
                }
            }
            for (int i = 0; i < tb_data.Rows.Count; i++)
            {
                string artist = tb_data.Rows[i][0].ToString().Trim().ToUpper();
                string title = "";
                if (tb_data.Rows[i][1].ToString() != "")
                    title = (char)34 + tb_data.Rows[i][1].ToString().Trim() + (char)34;
                tb_data.Rows[i][2] = GetTitle(artist, title);

                string labels = tb_data.Rows[i][6].ToString().Trim().ToLower();

                string[] labels_Arr = labels.ToString().Split(',');
                temp_tbkeycateg.Clear();
                //Fill temp_tbkeycateg by Keywords based on priority 
                foreach (var item in labels_Arr)
                {
                    if (item != "")
                    {
                        string[] y = item.Split(':');

                        foreach (var y_item in y)
                        {
                            if (y_item != "")
                            {
                                for (int j = 0; j < tbCateg_Keywords.Rows.Count; j++)
                                {
                                    string _keyword = tbCateg_Keywords.Rows[j][3].ToString().Trim().ToLower();

                                    if (y_item.Trim() == _keyword)
                                    {
                                        string[] _Arr_Keyword = item.Split(' ');
                                        foreach (var _Arr_Keyword_item in _Arr_Keyword)
                                        {
                                            if (_Arr_Keyword_item.Trim() != "")
                                            {
                                                bool exists = temp_tbkeycateg.Select().ToList().Exists(row => row[2].ToString().ToUpper().Contains(tbCateg_Keywords.Rows[j][7].ToString().Trim().ToUpper()) && row[2].ToString().Length == tbCateg_Keywords.Rows[j][7].ToString().Length);
                                                if (exists == false)
                                                    temp_tbkeycateg.Rows.Add(tbCateg_Keywords.Rows[j][0].ToString(), tbCateg_Keywords.Rows[j][1].ToString(), tbCateg_Keywords.Rows[j][2].ToString(), tbCateg_Keywords.Rows[j][7].ToString(), tbCateg_Keywords.Rows[j][4].ToString(), tbCateg_Keywords.Rows[j][5].ToString(), tbCateg_Keywords.Rows[j][6].ToString());
                                            }
                                        }
                                    }
                                    //{
                                    //    temp_tbkeycateg.Rows.Add(tbCateg_Keywords.Rows[j][0].ToString(), tbCateg_Keywords.Rows[j][1].ToString(), tbCateg_Keywords.Rows[j][2].ToString(), tbCateg_Keywords.Rows[j][3].ToString(), tbCateg_Keywords.Rows[j][4].ToString(), tbCateg_Keywords.Rows[j][5].ToString(), tbCateg_Keywords.Rows[j][6].ToString());
                                    //}
                                }
                            }
                        }
                    }
                }

                for (int j = 0; j < temp_tbkeycateg.Rows.Count; j++)
                {
                    string k1 = temp_tbkeycateg.Rows[j][3].ToString().Trim().ToLower();
                    for (int t = j + 1; t < temp_tbkeycateg.Rows.Count; t++)
                    {
                        string k2 = temp_tbkeycateg.Rows[t][3].ToString().Trim().ToLower();
                        string[] y = k2.Split(' ');
                        foreach (var y_item in y)
                        {
                            if (y_item.Trim().Contains(k1) && y_item.Trim().Length.ToString() == k1.Trim().Length.ToString())
                            {
                                temp_tbkeycateg.Rows[j]["New_res"] = "N";
                                break;
                            }

                        }
                    }
                }
                // missed check
                //keyword is not contained in other 6 keywords & inclue with same len "red tile" tile red tile /tile	tileless
                int z;
                //Compltete Title by keywords if less than 80
                for (z = 0; z < temp_tbkeycateg.Rows.Count; z++)
                {
                    string _keword_Add = temp_tbkeycateg.Rows[z][3].ToString().Trim().ToLower();
                    if (tb_data.Rows[i][2].ToString().Length + _keword_Add.Length < 80 && tb_data.Rows[i][2].ToString().ToLower().Contains(_keword_Add.ToLower()) == false)
                    {
                        //Check if Ading the keyword make duplicate ignore and take the next word
                        bool exists = tb_data.Select().ToList().Exists(row => row[2].ToString().ToUpper().StartsWith(tb_data.Rows[i][2] + " " + _keword_Add.ToUpper()));
                        if (exists == false)
                            tb_data.Rows[i][2] += " " + _keword_Add.Trim();
                    }

                }
                //-----------------------
                //Compltete Title by Complex Colors if less than 80
                string[] myFillingComplexcolors = tb_data.Rows[i]["ComplexColors"].ToString().Split(',');
                int _No_of_Added_colors = 0;
                foreach (var item in myFillingComplexcolors)
                {

                    if (item != "" && _No_of_Added_colors < 2)
                    {
                        string[] y = item.Split(':');
                        string _color = y[0].Trim();
                        if (_color != "")
                        {
                            if (tb_data.Rows[i][2].ToString().Length + _color.Length < 80 && tb_data.Rows[i][2].ToString().ToLower().Contains(_color.ToLower()) == false)
                            {
                                //Check if Ading the keyword make duplicate ignore and take the next word
                                bool exists = tb_data.Select().ToList().Exists(row => row[2].ToString().ToUpper().StartsWith(tb_data.Rows[i][2] + " " + _color.ToUpper()));
                                if (exists == false)
                                {
                                    tb_data.Rows[i][2] += " " + _color.Trim();
                                    _No_of_Added_colors += 1;
                                }
                            }
                        }
                    }
                }
                //----------------
                string[] myFillingWords = tbFillingKewords.Rows[0][0].ToString().Split(',');
                foreach (var item in myFillingWords)
                {
                    if (tb_data.Rows[i][2].ToString().Length + item.Length < 80 && tb_data.Rows[i][2].ToString().ToLower().Contains(item.ToLower()) == false)
                        tb_data.Rows[i][2] += " " + item.Trim();
                }
                temp_tbkeycateg.DefaultView.Sort = "CategoryPriority asc";
                temp_tbkeycateg = temp_tbkeycateg.DefaultView.ToTable();
                if (temp_tbkeycateg.Rows.Count > 0)
                    tb_data.Rows[i][4] = temp_tbkeycateg.Rows[0][1].ToString();
                string sl = "";
                if(Db.GetValue("Select Count(sku_Smart_tb) from smart_tb where sku_Smart_tb='" + Db.SqlTxt(tb_data.Rows[i]["Sku"].ToString()) + "'")=="0")
                 {
                    sl = "insert into smart_tb(sku_Smart_tb,Smart_titl,Categ) values('";
                    sl += Db.SqlTxt(tb_data.Rows[i]["Sku"].ToString()) + "','";
                    sl += Db.SqlTxt(tb_data.Rows[i]["New_Title"].ToString()) + "','";
                    sl += Db.SqlTxt(tb_data.Rows[i]["Generated_Category"].ToString()) + "')";
                }
               else
                {
                    sl = "Update  smart_tb set Smart_titl='";
                    sl += Db.SqlTxt(tb_data.Rows[i]["New_Title"].ToString()) + "',Categ='";
                    sl += Db.SqlTxt(tb_data.Rows[i]["Generated_Category"].ToString()) + "' ";
                    sl += " where   sku_Smart_tb='" + Db.SqlTxt(tb_data.Rows[i]["Sku"].ToString()) + "'";
                }
                Db.Execute(sl);
            }
           
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if(lstnewkeywords.SelectedItem==null)
            {
                MessageBox.Show("Choose The keyword", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (LstCategories.SelectedValue == null)
            {
                MessageBox.Show("Choose The Category", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int _priority = 0;
            if (opt1.Checked == true)
                _priority = 1;
            if (opt2.Checked == true)
                _priority = 2;
            if (_priority == 0 && LstCategories.SelectedValue.ToString() != "0" || _priority != 0 && LstCategories.SelectedValue.ToString() == "0")
            {
                MessageBox.Show("Category is not allwed with priority 0 & Category 0 with priority greater  than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string sl = "update KeywordsTb set KeywordPriority=" + _priority.ToString() + ",CategoryID=" + LstCategories.SelectedValue.ToString() + ",Status=true,TranDate=now() where Keyword='" + Db.SqlTxt(lstnewkeywords.SelectedItem.ToString()) + "'";
            Db.Execute(sl);
        }

        private void BtnDone_Click(object sender, EventArgs e)
        {
            string kw = "";
            foreach (var item in lstnewkeywords.Items)
            {
                if (Db.GetValue("Select Count(*) from KeywordsTb where status=0 and  keyword='" + item + "'")!="0")
                {
                    if (kw=="")
                    kw = item.ToString();
                    else
                        kw += "," + item.ToString();
                }
            }
            if(kw!="" )
            {
                MessageBox.Show("You should Specify the category and priority for all kewords First  (" + kw +   ")", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            BtnNewArtItem_Click(sender, e);
            PnlNewKeywords.Visible = false;

        }

        private void BtnCopyToNew_Click(object sender, EventArgs e)
        {
            BtnCopyToNew.Text=( UtNumers.RoundByLimit(Convert.ToDouble(txtPrice.Text))).ToString();
        }
    }
}
