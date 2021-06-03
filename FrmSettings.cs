using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JamesApp
{
    public partial class FrmSettings : Form
    {
        public FrmSettings()
        {
            InitializeComponent();
        }

        private void FrmSettings_Load(object sender, EventArgs e)
        {
            DataTable tb = new DataTable();
            tb = Db.GetTable("Select * from Tb_Setting");
            CameraPath.Text = tb.Rows[0]["CameraPath"].ToString();
            SofaPath.Text = tb.Rows[0]["SofaPath"].ToString();
            FTP_Path.Text = tb.Rows[0]["FTP_Path"].ToString();
            HighResolution_Path.Text = tb.Rows[0]["HighResolution_Path"].ToString();
            ResizePath.Text = tb.Rows[0]["ResizePath"].ToString();
        }

        private void BtnCamPath_Click(object sender, EventArgs e)
        {
            Get_Path(CameraPath);
        }
        private void Get_Path(TextBox t)
        {
            FolderBrowserDialog fdg = new FolderBrowserDialog();
            if (fdg.ShowDialog() == DialogResult.OK)
                t.Text = fdg.SelectedPath;
        }

        private void CameraPath_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (Utfile.IsValidPath(CameraPath.Text)==false)
            {
                MessageBox.Show("Invalid Camera Path", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                CameraPath.Focus();
                return;
            }
            if (Utfile.IsValidPath(SofaPath.Text) == false)
            {
                MessageBox.Show("Invalid Sofa Path", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SofaPath.Focus();
                return;
            }
            if (Utfile.IsValidPath(FTP_Path.Text) == false)
            {
                MessageBox.Show("Invalid FTP Path", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FTP_Path.Focus();
                return;
            }
            if (Utfile.IsValidPath(HighResolution_Path.Text) == false)
            {
                MessageBox.Show("Invalid High Resolution Path", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                HighResolution_Path.Focus();
                return;
            }
            if (Utfile.IsValidPath(ResizePath.Text) == false)
            {
                MessageBox.Show("Invalid Resize Path", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResizePath.Focus();
                return;
            }
            string sl= "Update Tb_Setting set " ;
            sl += "CameraPath = '" + CameraPath.Text + "',";
            sl += "SofaPath = '" + SofaPath.Text + "',";
            sl += "FTP_Path = '" + FTP_Path.Text + "',";
            sl += "HighResolution_Path = '" + HighResolution_Path.Text + "',";
            sl += "ResizePath = '" + ResizePath.Text + "'";
            Db.Execute(sl);
        }

        private void BtnSofaPath_Click(object sender, EventArgs e)
        {
            Get_Path(SofaPath);
        }

        private void BtnFtp_Path_Click(object sender, EventArgs e)
        {
            Get_Path(FTP_Path);
        }

        private void BtnHigh_Resolution_Path_Click(object sender, EventArgs e)
        {
            Get_Path(HighResolution_Path);
        }

        private void BtnResize_Path_Click(object sender, EventArgs e)
        {
            Get_Path(ResizePath);
        }
    }
}
