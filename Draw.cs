using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Security;

namespace Bookshop
{
    public static class Colorspace
    {
        public static class Colors_Default
        {
            public static class FormCS
            {
                public static Color ForeColor = SystemColors.Control;
                public static Color BackColor = SystemColors.ControlDark;
                public static Color[] ColorSpace = { ForeColor, BackColor };
            }
            public static class ButtonCS
            {
                public static Color ForeColor = SystemColors.Control;
                public static Color BackColor = SystemColors.ControlDark;
                public static Color[] ColorSpace = { ForeColor, BackColor };
            }
            public static class DataTimePickerCS
            {
                public static Color ForeColor = SystemColors.Control;
                public static Color MonthBackground = SystemColors.ControlDark;
                public static Color TitleForeColor = SystemColors.ActiveCaptionText;    //Заглавия календаря
                public static Color TitleBackColor = SystemColors.ActiveCaption;
                public static Color TrailingForeColor = SystemColors.GrayText;          //Начальные и конечные даты
                public static Color[] ColorSpace = { ForeColor, MonthBackground, TitleForeColor, TitleForeColor, TrailingForeColor};
            }
            public static Color[][] DefaultColorspace = { FormCS.ColorSpace, ButtonCS.ColorSpace, DataTimePickerCS.ColorSpace };
        }
        public static class Colors_Dark
        {
            public static class FormCS
            {
                public static Color ForeColor = SystemColors.ControlDark;
                public static Color BackColor = SystemColors.Control;
                public static Color[] ColorSpace = { ForeColor, BackColor };
            }
            public static class ButtonCS
            {
                public static Color ForeColor = SystemColors.ControlDark;
                public static Color BackColor = SystemColors.Control;
                public static Color[] ColorSpace = { ForeColor, BackColor };
            }
            public static class DataTimePickerCS
            {
                public static Color ForeColor = SystemColors.ControlDark;
                public static Color MonthBackground = SystemColors.Control;
                public static Color TitleForeColor = Color.DodgerBlue;    //Заглавия календаря
                public static Color TitleBackColor = Color.White;
                public static Color TrailingForeColor = Color.Blue;       //Начальные и конечные даты
                public static Color[] ColorSpace = { ForeColor, MonthBackground, TitleForeColor, TitleForeColor, TrailingForeColor };
            }
            public static Color[][] DarkColorspace = { FormCS.ColorSpace, ButtonCS.ColorSpace, DataTimePickerCS.ColorSpace };
        }
        public static class Colors_OrangeBlack
        {
            public static class FormCS
            {
                public static Color ForeColor = Color.Black;
                public static Color BackColor = Color.DarkOrange;
                public static Color[] ColorSpace = { ForeColor, BackColor };
            }
            public static class ButtonCS
            {
                public static Color ForeColor = Color.Black;
                public static Color BackColor = Color.DarkOrange;
                public static Color[] ColorSpace = { ForeColor, BackColor };
            }
            public static class DataTimePickerCS
            {
                public static Color ForeColor = Color.DarkOrange;
                public static Color MonthBackground = Color.Black;
                public static Color TitleForeColor = Color.SandyBrown;    //Заглавия календаря
                public static Color TitleBackColor = Color.Black;
                public static Color TrailingForeColor = Color.OrangeRed;       //Начальные и конечные даты
                public static Color[] ColorSpace = { ForeColor, MonthBackground, TitleForeColor, TitleForeColor, TrailingForeColor };
            }
            public static Color[][] OrangeBlackColorspace = { FormCS.ColorSpace, ButtonCS.ColorSpace, DataTimePickerCS.ColorSpace };
        }
        public static Color[][][] ColorspaceArray = { Colors_Default.DefaultColorspace, Colors_Dark.DarkColorspace, Colors_OrangeBlack.OrangeBlackColorspace };
    }
}
