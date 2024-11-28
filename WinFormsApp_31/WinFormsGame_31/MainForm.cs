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
                //var proj = new Projectile() { Rectangle = new Rectangle(HeroPictureBox.Location.X, HeroPictureBox.Location.Y, 5, 2) };
                //_movementList.Add(proj);
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
        Vector Speed { get; set; }
        Point Position { get; set; }
    }

    public class GameObject : Panel
    {

    }

    public struct Vector
    {
        public float X; 
        public float Y;

        public Vector(float x, float y)
        {
            X = x;
            Y = y;
        }

        public static Vector operator +(Vector v1, Vector v2)
        {
            return new Vector(v1.X+v2.X, v1.Y+v2.Y);
        }
        public static Vector operator *(Vector v, float n)
        {
            return new Vector(v.X*n, v.Y*n);
        }
    }

    public class Hero
    {

    }

    public class Projectile 
    {
        
    }
}
