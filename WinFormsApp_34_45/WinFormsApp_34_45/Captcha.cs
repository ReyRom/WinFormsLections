using System.Drawing.Drawing2D;

namespace WinFormsApp_34_45
{
    public partial class Captcha : UserControl
    {
        private string _text;
        public int Length { get; set; } = 5;

        public Color LinesColor { get; set; } = Color.Red;
        public Color TextColor { get; set; } = Color.Green;
        public Color PointsColor { get; set; } = Color.Lime;

        public Captcha()
        {
            InitializeComponent();
            Font = new Font("Consolas", 30);
            BackColor = Color.LimeGreen;
        }

        public bool IsValidCaptcha(string text)
        {
            return text == _text;
        }

        public void Renew()
        {
            CaptchaPictureBox.Image?.Dispose();
            CaptchaPictureBox.Image = CreateImage(this.Width, this.Height);
        }

        private Bitmap CreateImage(int width, int height)
        {
            Bitmap result = new Bitmap(width, height);
            Random rnd = new Random();

            using Graphics g = Graphics.FromImage(result);

            g.Clear(BackColor);

            const int lines = 10;
            using Pen linesPen = new Pen(LinesColor);

            #region Line
            for (int i = 0; i < lines; i++)
            {
                g.DrawLine(linesPen,
                    new Point(0, 0),
                    new Point(width - 1, height - rnd.Next(height)));
            }
            for (int i = 0; i < lines; i++)
            {
                g.DrawLine(linesPen,
                    new Point(0, 0),
                    new Point(width - rnd.Next(width), height - 1));
            }
            for (int i = 0; i < lines; i++)
            {
                g.DrawLine(linesPen,
                    new Point(width - 1, 0),
                    new Point(0, height - rnd.Next(height)));
            }
            for (int i = 0; i < lines; i++)
            {
                g.DrawLine(linesPen,
                    new Point(width - 1, 0),
                    new Point(width - rnd.Next(width), height - 1));
            }
            #endregion

            _text = string.Empty;

            const string ALF = "1234567890QWERTYUIOPASDFGHJKLZXCVBNM";

            for (int i = 0; i < Length; i++)
            {
                _text += ALF[rnd.Next(ALF.Length)];
            }

            using Brush brush = new SolidBrush(TextColor);

            float textWidth;
            float textHeight;

            using (Bitmap temp = new Bitmap(400, 400))
            {
                var size = Graphics.FromImage(temp).MeasureString(_text.Substring(0,1), Font);
                textWidth = size.Width;
                textHeight = size.Height;
            }

            int space = width / Length;
            for (int i = 0; i< _text.Length; i++)
            {
                int xPos = rnd.Next(i * space, (i+1)*space - (int)textWidth);
                int yPos = rnd.Next(0, height - (int)textHeight);

                float angle = rnd.Next(-45, 45);
                using Matrix m = new Matrix();

                m.RotateAt(angle,new PointF(xPos + textWidth/2, yPos + textHeight/2));

                g.Transform = m;
                g.DrawString(_text.Substring(i, 1), Font, brush, new PointF(xPos, yPos));
                g.ResetTransform();
            }


            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j< height; j++)
                {
                    if (rnd.Next() % 20 == 0)
                    {
                        result.SetPixel(i, j, PointsColor);
                    }
                }
            }
            
            return result;
        }
    }
}
