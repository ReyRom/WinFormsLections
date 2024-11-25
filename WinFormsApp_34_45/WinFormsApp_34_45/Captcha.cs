namespace WinFormsApp_34_45
{
    public partial class Captcha : UserControl
    {
        private string _text;
        public Captcha()
        {
            InitializeComponent();
        }

        public void Renew()
        {
            CaptchaPictureBox.Image = CreateImage(this.Width, this.Height);
        }

        private Bitmap CreateImage(int width, int height)
        {
            Random rnd = new Random();
            Bitmap result = new Bitmap(width, height);

            Graphics g = Graphics.FromImage(result);

            g.Clear(Color.GreenYellow);

            const int lines = 10;
            Pen linesPen = Pens.Red;

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



            return result;
        }
    }
}
