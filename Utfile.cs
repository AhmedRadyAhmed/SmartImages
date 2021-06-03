using System;
using System.Data;
using System.Text;
using System.IO;

namespace JamesApp
{
    public static class  Utfile
    {
        public static bool IsValidPath(string Path)
        {
            return Directory.Exists(Path);
        }
        public static bool RenameFile(string curFile, string newName)
        {
            bool flag = false;
            FileInfo fi = new FileInfo(curFile);
            if (fi.Exists)
            {
                fi.MoveTo(newName);
                flag = true;
            }
            return flag;
        }
        public static string ChangeNames(string[] files, string path)
        {
            string NewNm = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString().PadLeft(2, '0') + DateTime.Now.Day.ToString().PadLeft(2, '0') + DateTime.Now.Hour.ToString().PadLeft(2, '0') + DateTime.Now.Minute.ToString().PadLeft(2, '0') + DateTime.Now.Second.ToString().PadLeft(2, '0');
            int _i = 0;
            string _fnM = "";
            string _fnF = "";
            string picNames = "";
            string _r = "";
            string _MName = "";
            string _fname = "";
            foreach (var item in files)
            {
                if (Path.GetFileName(item).ToLower() == "m.jpg")
                {
                    RenameFile(item, path + @"\" + NewNm + "_M.jpg");
                    _fnM = NewNm + "_M.jpg";
                    _MName = NewNm + "_M-1400.jpg" + "|";
                }

                else if (Path.GetFileName(item).ToLower() == "f.jpg")
                {
                    RenameFile(item, path + @"\" + NewNm + "_F.jpg");
                    _fnF = NewNm + "_F.jpg";
                    _fname = NewNm + "_F-1400.jpg" + "|";
                }

                else
                {
                    _i += 1;
                    RenameFile(item, path + @"\" + NewNm + @"_" + _i.ToString() + ".jpg");
                    picNames += NewNm + @"_" + _i.ToString() + "-1400.jpg" + "|";
                }
            }
            if (_fnF == "")
                _r = _fnM;
            else
                _r = _fnF;
            if (_fname != "")
                picNames = _MName + "|" + _fname + "|" + picNames;
            else
                picNames = _MName + "|" + picNames;
            picNames = picNames.Replace("||", "|");
            return _r + ":" + picNames;
        }
        public static void MoveFiles(string fromDir, string toDir, Boolean isCopy = false)
        {
            if (Directory.Exists(fromDir))
            {
                foreach (var file in new DirectoryInfo(fromDir).GetFiles())
                {
                    if (isCopy)
                        file.CopyTo($@"{toDir}\{file.Name}");
                    else
                        file.MoveTo($@"{toDir}\{file.Name}");
                }
            }
        }
        public static void MoveFile(string fromfile, string tofile, Boolean isCopy = false)
        {
            FileInfo fi = new FileInfo(fromfile);
            if (fi.Exists)
            {
                if (isCopy)
                    fi.CopyTo(tofile);
                else
                    fi.MoveTo(tofile);
            }
        }
        public static void RemoveFiles(string _dir)
        {
            if (Directory.Exists(_dir))
            {
                foreach (var file in new DirectoryInfo(_dir).GetFiles())
                {
                    file.Delete();
                }
            }

        }
        public static void RemoveFile(string _filename)
        {
            FileInfo fi = new FileInfo(_filename);
            if (fi.Exists)
                fi.Delete();

        }
        public static string GetHtmlArt(string title, string artist, string size, string typemedia, string year, string conditionReport, string notes, string picurls, string weburl, DataTable tb)
        {
            StringBuilder s = new StringBuilder();
            string[] picnames = picurls.Split('|');
            s.Append(tb.Rows[0][1].ToString());
            s.Append("\"");
            s.Append(weburl);

            s.Append(picnames[0]);

            s.Append("\"></label ><img src =\"");
            s.Append(weburl);

            s.Append(picnames[0]);
            s.Append("\">");
            for (int i = 1; i < picnames.Length; i++)
            {
                if (picnames[i] != "")
                {
                    s.Append("<input id=\"pic_");
                    s.Append(i.ToString());
                    s.Append("\" name = \"switch\" type = \"radio\" ><label for= \"pic_");
                    s.Append(i.ToString());
                    s.Append("\" > <img src =\"");
                    s.Append(weburl);

                    s.Append(picnames[i]);
                    s.Append("\"> </label > <img src = \"");
                    s.Append(weburl);

                    s.Append(picnames[i]);
                    s.Append("\" > ");
                }

            }
            s.Append(tb.Rows[0][2].ToString());
            s.Append(" " + title);
            s.Append("</li> <li > Artist: ");
            s.Append(artist);
            s.Append("</li><li>Size: ");
            s.Append(size);
            s.Append("</li><li>Type/Media: ");
            s.Append(typemedia);
            s.Append("</li><li>Year: ");
            s.Append(year);
            s.Append("</li><li>Originality: Original ");
            s.Append("</li><li>Condition Report: ");
            s.Append(conditionReport);
            s.Append(tb.Rows[0][3].ToString());
            s.Append(" " + artist);
            s.Append(tb.Rows[0][4].ToString());
            s.Append(" " + artist + " ");
            s.Append(tb.Rows[0][5].ToString());
            s.Append(artist);
            s.Append(tb.Rows[0][6].ToString());
            s.Append(artist);
            s.Append(" - ");
            s.Append(artist);
            s.Append(tb.Rows[0][7].ToString());
            s.Append( " ");
           
            s.Append("<a href = 'https://www.ebay.co.uk/sch/m.html?_odkw=&_ssn=twineview&_nkw=");
            s.Append(typemedia.Replace(' ', '+'));
            s.Append("' target = '_blank' style='color: black'><B>");
            s.Append(typemedia);
            s.Append("</B></a>");

            s.Append(" artwork by ");

            s.Append("<a href = 'https://www.ebay.co.uk/sch/m.html?_odkw=&_ssn=twineview&_nkw=");
            s.Append(artist.Replace(' ', '+'));
            s.Append("' target = '_blank' style='color: black'><B>");
            s.Append(artist);
            s.Append("</B></a>");

            s.Append(" entitled  ");

            s.Append("<a href = 'https://www.ebay.co.uk/sch/m.html?_odkw=&_ssn=twineview&_nkw=");
            s.Append(title.Replace(' ', '+'));
            s.Append("' target = '_blank' style='color: black'><B>");
            s.Append(title);
            s.Append("</B></a>");

            s.Append(".");
            if (notes != "")
            {
                s.Append(notes);
                s.Append(".");
            }
            s.Append(tb.Rows[0][8].ToString());
            return s.ToString();
        }

    }
}
