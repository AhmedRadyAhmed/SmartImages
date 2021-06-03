using Google.Api;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace JamesApp
{
    public static class Db
    {
        private static OleDbConnection cn = new OleDbConnection();
        private static OleDbCommand cmd = new OleDbCommand();

        public static void OpenDb(string connstring)
        {
            cn.ConnectionString = connstring;
            cn.Open();
            cmd.Connection = cn;
        }

        public static void Execute(string sl)
        {
            cmd.CommandText = sl;
            cmd.ExecuteNonQuery();
        }
        public static string GetValue(string sl)
        {
            string rs = "";
            cmd.CommandText = sl;
            rs = cmd.ExecuteScalar().ToString();
            return rs;
        }
        public static string SqlTxt(string s)
        {
            return s.Replace("'", "''").Trim();
        }
        public static DataTable GetTable(string sl)
        {
            DataTable tb = new DataTable();
            cmd.CommandText = sl;
            OleDbDataReader rd = cmd.ExecuteReader();
            tb.Load(rd);
            rd.Close();
            return tb;
        }
        public static void Fill_List(string sl,ListBox lst)
        {
            DataTable tb = new DataTable();
            tb = GetTable(sl);
            lst.DataSource = tb;
            lst.DisplayMember = tb.Columns[1].ColumnName;
            lst.ValueMember = tb.Columns[0].ColumnName;
        }
        public static void Fill_Combo(string sl, ComboBox lst)
        {
            DataTable tb = new DataTable();
            tb = GetTable(sl);
            lst.DataSource = tb;
            lst.DisplayMember = tb.Columns[1].ColumnName;
            lst.ValueMember = tb.Columns[0].ColumnName;
        }

    }
}
