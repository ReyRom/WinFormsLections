using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp_31
{
    public partial class Captcha : UserControl
    {
        private string _text;
        public int Length { get; set; } = 5;
        public Captcha()
        {
            InitializeComponent();
        }

        public void Renew()
        {
            CaptchaPictureBox.Image?.Dispose();
            CaptchaPictureBox.Image = CreateImage(Width, Height);
        }

        private Bitmap CreateImage(int width, int height)
        {
            Bitmap result = new Bitmap(width, height);
            Random rnd = new Random();

            using (Graphics g = Graphics.FromImage(result))
            {
                g.Clear(Color.BlueViolet);

                #region Lines
                const int lines = 10;

                using (Pen linesPen = new Pen(Color.Blue))
                {
                    for (int i = 0; i < lines; i++)
                    {
                        g.DrawLine(linesPen,
                                   new PointF(0, 0),
                                   new PointF(rnd.Next(width),height));
                    }
                    for (int i = 0; i < lines; i++)
                    {
                        g.DrawLine(linesPen,
                                   new PointF(0, 0),
                                   new PointF(width, rnd.Next(height)));
                    }
                    for (int i = 0; i < lines; i++)
                    {
                        g.DrawLine(linesPen,
                                   new PointF(width, 0),
                                   new PointF(rnd.Next(width), height));
                    }
                    for (int i = 0; i < lines; i++)
                    {
                        g.DrawLine(linesPen,
                                   new PointF(width, 0),
                                   new PointF(0, rnd.Next(height)));
                    }
                }
                #endregion

                _text = String.Empty;

                const string ALF = "1234567890QWERTYUIOPASDFGHJKLZXCVBNM";

                for (int i = 0; i < Length; i++)
                {
                    _text += ALF[rnd.Next(ALF.Length)];
                }

                using (Brush textBrush = new SolidBrush(Color.Green))
                {

                }
            }
            return result;
        }
    }
}
