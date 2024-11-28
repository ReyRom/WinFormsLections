using System.Drawing.Drawing2D;

namespace WinFormsApp_31
{
    public partial class Captcha : UserControl
    {
        private string _text;
        public int Length { get; set; } = 5;
        public Color LinesColor { get; set; } = Color.Blue;

        public Color DotsColor { get; set; } = Color.Blue;

        public Captcha()
        {
            InitializeComponent();
        }

        public bool IsCorrectText(string text)
        {
            return _text == text;
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
                g.Clear(BackColor);

                #region Lines
                const int lines = 10;

                using (Pen linesPen = new Pen(LinesColor))
                {
                    for (int i = 0; i < lines; i++)
                    {
                        g.DrawLine(linesPen,
                                   new PointF(0, 0),
                                   new PointF(rnd.Next(width), height));
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

                int space = width / Length;

                float textWidth;
                float textHeight;

                using (Bitmap temp = new Bitmap(400, 400))
                {
                    using (Graphics tg = Graphics.FromImage(temp))
                    {
                        var size = tg.MeasureString("W", Font);
                        textWidth = size.Width;
                        textHeight = size.Height;
                    }
                }

                for (int i = 0; i < Length; i++)
                {
                    int xPos = rnd.Next(i * space, (i + 1) * space - (int)textWidth);
                    int yPos = rnd.Next(0, height - (int)textHeight);
                    float angle = rnd.Next(-45, 45);
                    using (Matrix matrix = new Matrix())
                    {
                        matrix.RotateAt(angle, new PointF(xPos + textWidth / 2, yPos + textHeight / 2));
                        g.Transform = matrix;
                    }
                    using (Brush textBrush = new SolidBrush(ForeColor))
                    {
                        g.DrawString(_text.Substring(i, 1), Font, textBrush, xPos, yPos);
                    }
                    g.ResetTransform();
                }
            }

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    if (rnd.Next() % 10 == 0)
                        result.SetPixel(i, j, DotsColor);
                }
            }

            return result;
        }
    }
}
