using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Configuration;

namespace JamesApp
{
    class MyColor
    {
     
        private partial struct TStoredColours
        {
            public string Name;
            public short R;
            public short G;
            public short B;
        }

        private List<TStoredColours> Colours = new List<TStoredColours>();
        public MyColor()
        {
            GenerateColourList();
         
            string MyConStr = ConfigurationManager.ConnectionStrings["MyConStr"].ConnectionString;
            
        }
        private void GenerateColourList()
        {
            var ColourType = typeof(System.Drawing.Color);
            var PropertyInfo = ColourType.GetProperties(BindingFlags.Static | BindingFlags.DeclaredOnly | BindingFlags.Public);
            foreach (PropertyInfo c in PropertyInfo)
            {
                if (!(c.Name == "Transparent"))
                {
                    Colours.Add(new TStoredColours() { Name = c.Name, R = System.Drawing.Color.FromName(c.Name).R, G = System.Drawing.Color.FromName(c.Name).G, B = System.Drawing.Color.FromName(c.Name).B });
                }
            }

            var SortOrder = from c in Colours
                            orderby c.Name
                            select c;
            Colours = SortOrder.ToList();
        }
        public string GetBasic_PreBasic_ColorName(System.Drawing.Color Colour)
        {
            var NearestColour = new TStoredColours() { Name = "NULL", R = 255, G = 255, B = 255 };
            int NearestColourVal = int.MaxValue;
            foreach (TStoredColours c in Colours)
            {
                if (Colour == Color.FromArgb(255, c.R, c.G, c.B))
                {
                    // Found exact match
                    //   return c.Name;
                    NearestColour = c;
                }
                // Couldn't find exact match, working out which colour is closest to given colour
                else if (Math.Abs(Colour.R - c.R) + Math.Abs(Colour.G - c.G) + Math.Abs(Colour.B - c.B) < NearestColourVal)
                {
                    NearestColourVal = Math.Abs(Colour.R - c.R) + Math.Abs(Colour.G - c.G) + Math.Abs(Colour.B - c.B);
                    NearestColour = c;
                }
            }
            //return NearestColour.Name;
            return Db.GetValue("Select BasicColor + '|'+ ComplexColor From Colors where Color='" + NearestColour.Name + "'") + "|"+ NearestColour.Name;
        }
        
    }
}
