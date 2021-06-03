using Google.Cloud.Vision.V1;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Drawing;
namespace JamesApp
{

    public class Jmvision
    {
        private string _keyfilepath;
        private Dictionary<string, int> _uniqBasicColors = new Dictionary<string, int>();
        private Dictionary<string, int> _CSharpColors = new Dictionary<string, int>();
        private Dictionary<string, int> _gVisionColors = new Dictionary<string, int>();
        private Dictionary<string, int> _complexColors = new Dictionary<string, int>();
        public string GetUniq_Colors()
        {
            string s = "";
            foreach (var i in _uniqBasicColors)
            {
                s += i.Key + ":" + i.Value + ",";
            }
            return s;
        }
        public string GetCSharp_Colors()
        {
            string s = "";
            foreach (var i in _CSharpColors)
            {
                s += i.Key + ":" + i.Value + ",";
            }
            return s;
        }
        public string GetGoog_Vision_Colors()
        {
            string s = "";
            foreach (var i in _gVisionColors)
            {
                s += i.Key + ":" + i.Value + ",";
            }
            return s;
        }
        public string GetcomplexColors()
        {
            string s = "";
            foreach (var i in _complexColors)
            {
                s += i.Key + ":" + i.Value + ",";
            }
            return s;
        }
        public string GetUniq_Color()
        {

            return _uniqBasicColors.FirstOrDefault().Key;
        }
        public string KeyFilePath
        {
            get
            {
                return _keyfilepath;
            }

            set
            {

                _keyfilepath = value;
                System.Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", _keyfilepath);
            }
        }
        public string GetSafSearch(string imageUrl, bool isLocalimage = false)
        {
            Google.Cloud.Vision.V1.Image image;
            var client = ImageAnnotatorClient.Create();
            if (isLocalimage)
                image = Google.Cloud.Vision.V1.Image.FromFile(imageUrl);
            else
                image = Google.Cloud.Vision.V1.Image.FromUri(imageUrl);
            var labels = client.DetectSafeSearch(image);

           
            return labels.Adult.ToString();
        }
        public string GetLabels(string imageUrl, bool isLocalimage = false)
        {
            string lb = "";
           
            Google.Cloud.Vision.V1.Image image;
            var client = ImageAnnotatorClient.Create();
            if (isLocalimage)
                image = Google.Cloud.Vision.V1.Image.FromFile(imageUrl);
            else
                image = Google.Cloud.Vision.V1.Image.FromUri(imageUrl);
            var labels = client.DetectLabels(image);
           // var NudeLb = client.DetectSafeSearch(image);
            foreach (var label in labels)
            {
                lb += label.Description + ":" + Convert.ToInt16((label.Score * 100)).ToString() + ",";
            }

           
            return lb;
        }
        public string GetLabelsPercentage(string imageUrl, bool isLocalimage = false)
        {
            string lbper = "";
            var client = ImageAnnotatorClient.Create();
            Google.Cloud.Vision.V1.Image image;
            if (isLocalimage)
                image = Google.Cloud.Vision.V1.Image.FromFile(imageUrl);
            else
                image = Google.Cloud.Vision.V1.Image.FromUri(imageUrl);
            var labels = client.DetectLabels(image);

            foreach (var label in labels)
            {
                lbper = lbper + Convert.ToInt16((label.Score * 100)).ToString() + " ";
            }

            return lbper;
        }
        public string GetImageLandMark(string imageUrl, bool isLocalimage = false)
        {
            string landmark = "";

            var client = ImageAnnotatorClient.Create();
            Google.Cloud.Vision.V1.Image image;
            if (isLocalimage)
                image = Google.Cloud.Vision.V1.Image.FromFile(imageUrl);
            else
                image = Google.Cloud.Vision.V1.Image.FromUri(imageUrl);
            var response = client.DetectLandmarks(image);
            foreach (var annotation in response)
            {
                if (annotation.Description != null)
                {
                    landmark += annotation.Description + " ";
                }
            }
            return landmark;
        }
        public string GetImageLColors(string imageUrl, bool isLocalimage = false)
        {
            _uniqBasicColors.Clear();
            _CSharpColors.Clear();
            _gVisionColors.Clear();
            _complexColors.Clear();
            string s = "";
            MyColor MyColor = new MyColor();
            var client = ImageAnnotatorClient.Create();
            Google.Cloud.Vision.V1.Image image;
            if (isLocalimage)
                image = Google.Cloud.Vision.V1.Image.FromFile(imageUrl);
            else
                image = Google.Cloud.Vision.V1.Image.FromUri(imageUrl);
            ImageProperties properties = client.DetectImageProperties(image);

            foreach (var color in properties.DominantColors.Colors)
            {
                string cur_color, B_pre_color;

                Color c = Color.FromArgb(Convert.ToInt32(color.Color.Red), Convert.ToInt32(color.Color.Green), Convert.ToInt32(color.Color.Blue));
                _gVisionColors.Add(c.Name + "|" + color.Color.Red.ToString() + "," + color.Color.Green.ToString() + "," + color.Color.Blue.ToString(), Convert.ToInt16(100 * color.Score));
                B_pre_color = MyColor.GetBasic_PreBasic_ColorName(c);
                string[] y = B_pre_color.Split('|');
                cur_color = y[0];
                
                if (_complexColors.ContainsKey(y[1]))

                    _complexColors[y[1]] += Convert.ToInt16(100 * color.Score);
              else
                    _complexColors.Add(y[1], Convert.ToInt16(100 * color.Score));


                if (_CSharpColors.ContainsKey(y[2]))

                    _CSharpColors[y[2]] += Convert.ToInt16(100 * color.Score);
                else
                    _CSharpColors.Add(y[2], Convert.ToInt16(100 * color.Score));

                if (_uniqBasicColors.ContainsKey(cur_color))
                {


                    if (cur_color.ToUpper() == "GRAY" || cur_color.ToUpper() == "GREY")
                        _uniqBasicColors[cur_color] = Convert.ToInt16((Convert.ToInt16(_uniqBasicColors[cur_color]) + Convert.ToInt16(0.3 * 100 * color.Score)));
                    else if (cur_color.ToUpper() == "BROWN")
                        _uniqBasicColors[cur_color] = Convert.ToInt16((Convert.ToInt16(_uniqBasicColors[cur_color]) + Convert.ToInt16(0.8 * 100 * color.Score)));
                    else
                        _uniqBasicColors[cur_color] = Convert.ToInt16((Convert.ToInt16(_uniqBasicColors[cur_color]) + Convert.ToInt16(100 * color.Score)));
                }
                else
                {

                    if (cur_color.ToUpper() == "GRAY" || cur_color.ToUpper() == "GREY")
                        _uniqBasicColors.Add(cur_color, Convert.ToInt16(0.3 * 100 * color.Score));
                    else if (cur_color.ToUpper() == "BROWN")
                        _uniqBasicColors.Add(cur_color, Convert.ToInt16(0.8 * 100 * color.Score));
                    else
                        _uniqBasicColors.Add(cur_color, Convert.ToInt16(100 * color.Score));
                }
                s += cur_color + ":" + (Convert.ToInt16(100 * color.Score)).ToString() + ",";

            }

            _uniqBasicColors = _uniqBasicColors.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            _CSharpColors = _CSharpColors.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            _gVisionColors = _gVisionColors.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            _complexColors = _complexColors.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            return s;

        }
        public string[,] GetImageLColors_old(string imageUrl, bool isLocalimage = false)
        {
            string[,] image_colors;
            var client = ImageAnnotatorClient.Create();
            Google.Cloud.Vision.V1.Image image;
            if (isLocalimage)
                image = Google.Cloud.Vision.V1.Image.FromFile(imageUrl);
            else
                image = Google.Cloud.Vision.V1.Image.FromUri(imageUrl);
            ImageProperties properties = client.DetectImageProperties(image);
            int x = 0;
            image_colors = new string[properties.DominantColors.Colors.Count, 3];
            foreach (var color in properties.DominantColors.Colors)
            {

                string _red, _green, _blue;
                _red = color.Color.Red.ToString();
                _green = color.Color.Green.ToString();
                _blue = color.Color.Blue.ToString();

                image_colors[x, 0] = (Convert.ToInt16(100 * color.Score)).ToString();
                image_colors[x, 1] = _red + "," + _green + "," + _blue;

                x++;
            }

            return image_colors;
        }
        public string GetImageText(string imageUrl, bool isLocalimage = false)
        {
            string imageText = "";
            var client = ImageAnnotatorClient.Create();
            Google.Cloud.Vision.V1.Image image;
            if (isLocalimage)
                image = Google.Cloud.Vision.V1.Image.FromFile(imageUrl);
            else
                image = Google.Cloud.Vision.V1.Image.FromUri(imageUrl);
            var response = client.DetectText(image);
            foreach (var annotation in response)
            {
                if (annotation.Description != null)
                {
                    imageText += annotation.Description + " ";
                }
            }

            return imageText;
        }
    }
}
