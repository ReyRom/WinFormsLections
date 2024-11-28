namespace WinFormsGame_31
{
    public partial class MainForm : Form
    {
        private const double MOVESPEED = 5;
        private double _speedX = 0;
        private double _speedY = 0;

        private List<IMovement> _movementList = new List<IMovement>();
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Left)
            {
                _speedX = -MOVESPEED;
            }
            if (e.KeyCode == Keys.Right)
            {
                _speedX = MOVESPEED;
            }
            if (e.KeyCode == Keys.Up)
            {
                _speedY = -MOVESPEED;
            }
            if (e.KeyCode == Keys.Down)
            {
                _speedY = MOVESPEED;
            }
            if (e.KeyCode == Keys.Space)
            {
                var proj = new Projectile() { Rectangle = new Rectangle(HeroPictureBox.Location.X, HeroPictureBox.Location.Y, 5, 2) };
                FieldPanel.Controls.Add(proj.Rectangle);
                _movementList.Add(proj);
            }
        }

        private void GameCycleTimer_Tick(object sender, EventArgs e)
        {

            DrawHero();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            GameCycleTimer.Start();
        }

        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                case Keys.Down:
                    _speedY = 0;
                    break;
                case Keys.Left:
                case Keys.Right:
                    _speedX = 0;
                    break;
            }
        }

        private void DrawHero()
        {
            var pos = HeroPictureBox.Location;

            var newPosX = pos.X + (int)_speedX;
            var newPosY = pos.Y + (int)_speedY;

            if (newPosX < 0)
            {
                newPosX = 0;
            }
            if (newPosX > FieldPanel.Width - HeroPictureBox.Width)
            {
                newPosX = FieldPanel.Width - HeroPictureBox.Width;
            }

            if (newPosY < 0)
            {
                newPosY = 0;
            }
            if (newPosY > FieldPanel.Height - HeroPictureBox.Height)
            {
                newPosY = FieldPanel.Height - HeroPictureBox.Height;
            }


            HeroPictureBox.Location = new Point(newPosX, newPosY);
        }
    }

    public interface IMovement
    {
        void Move();
        double SpeedX { get; set; }
        double SpeedY { get; set; }
        Point Position { get; set; }
    }
    public class Hero
    {

    }
    public class Projectile : IMovement
    {
        public Rectangle Rectangle { get; set; }
        public double SpeedX { get; set; } = 25;
        public double SpeedY { get; set; } = 0;
        public Point Position { get; set; }

        public void Move()
        {
            Position = new Point(Position.X + (int)SpeedX, Position.Y);
        }
    }
}
