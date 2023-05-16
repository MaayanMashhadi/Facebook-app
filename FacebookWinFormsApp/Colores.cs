using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp.DevTools.Network;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public static class Colores
    {

        private static readonly Color sr_MenuePanale;
        private static readonly Color sr_IconPanel;
        private static readonly Color sr_TitlePanel;
        private static List<string> s_ColorList;
        private static Color s_PrimeryColor;
        private static Color s_SeconderyColor;

        static Colores()
        {
            s_ColorList = new List<string>()
                                                      {
                                                          "#730db0",
                                                          "#2e3aec",
                                                          "#be4197",
                                                          "#0cab5a",
                                                          "#e1981e",
                                                          "#a85a57",
                                                          "#57A5A8",
                                                          "#d42b55",
                                                          "#6d8a92",
                                                          "#66649b",
                                                          "#cbf00f",
                                                          "#c6117c",
                                                          "#1bcae4",
                                                          "#41BE68",
                                                          "#E4351B",
                                                          "#90D9C7",
                                                          "#C61122",
                                                          "#ff8b00",
                                                          "#FFC3DB"
                                                      };

            sr_MenuePanale = Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            sr_IconPanel = Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(70)))));
            sr_TitlePanel = Color.MediumPurple;
        }

        public static Color MenuePanale
        {
            get
            {
                return sr_MenuePanale;
            }
        }

        public static Color IconPanel
        {
            get
            {
                return sr_IconPanel;
            }
        }

        public static Color TitlePanel
        {
            get
            {
                return sr_TitlePanel;
            }
        }

        public static Color PrimeryColor
        {
            get
            {
                return s_PrimeryColor;
            }

            set
            {
                s_PrimeryColor = value;
            }
        }

        public static Color SeconderyColor
        {
            get
            {
                return s_SeconderyColor;
            }

            set
            {
                s_SeconderyColor = value;
            }
        }

        public static List<string> ColorList
        {
            get
            {
                return s_ColorList;
            }
        }

        public static Color ColorBrightnessChangeIconPanel(Color i_Color)
        {
            double red = i_Color.R;
            double green = i_Color.G;
            double blue = i_Color.B;
            double correctionColor = 1 - 0.3;

            red *= correctionColor;
            green *= correctionColor;
            blue *= correctionColor;

            return Color.FromArgb(i_Color.A, (byte)red, (byte)green, (byte)blue);

        }

        public static void SetColorsToControls(Control.ControlCollection i_Controls)
        {
            Button buttonToChange;

            foreach(Control control in i_Controls)
            {
                if(control.GetType().Equals(typeof(Button)))
                {
                    buttonToChange = control as Button;
                    buttonToChange.BackColor = PrimeryColor;
                    buttonToChange.FlatAppearance.BorderColor = SeconderyColor;
                    buttonToChange.ForeColor = SeconderyColor;
                }
            }
        }
    }
}

