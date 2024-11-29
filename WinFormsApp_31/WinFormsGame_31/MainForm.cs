namespace WinFormsGame_31
{
    public partial class MainForm : Form
    {
        private const float MOVESPEED = 5;
        

        private List<IMovable> _movementList = new List<IMovable>();
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            Vector speed = _hero.Speed;

            if (e.KeyCode == Keys.Left)
            {
                speed.X = -MOVESPEED;
            }
            if (e.KeyCode == Keys.Right)
            {
                speed.X = MOVESPEED;
            }
            if (e.KeyCode == Keys.Up)
            {
                speed.Y = -MOVESPEED;
            }
            if (e.KeyCode == Keys.Down)
            {
                speed.Y = MOVESPEED;
            }
            if (e.KeyCode == Keys.Space)
            {
                //var proj = new Projectile() { Rectangle = new Rectangle(HeroPictureBox.Location.X, HeroPictureBox.Location.Y, 5, 2) };
                //_movementList.Add(proj);
            }

            _hero.Speed = speed;
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
            var speed = _hero.Speed;
            switch (e.KeyCode)
            {
                case Keys.Up:
                case Keys.Down:
                    speed.Y = 0;
                    break;
                case Keys.Left:
                case Keys.Right:
                    speed.X = 0;
                    break;
            }
            _hero.Speed = speed;
        }

        private void DrawHero()
        {
            var pos = _hero.Location;

            var newPos = pos + _hero.Speed;

            if (newPos.X < 0)
            {
                newPos.X = 0;
            }
            if (newPos.X > FieldPanel.Width - _hero.Width)
            {
                newPos.X = FieldPanel.Width - _hero.Width;
            }

            if (newPos.Y < 0)
            {
                newPos.Y = 0;
            }
            if (newPos.Y > FieldPanel.Height - _hero.Height)
            {
                newPos.Y = FieldPanel.Height - _hero.Height;
            }


            _hero.Location = newPos;
        }
    }

    public interface IMovable
    {
        void Move();
        Vector Speed { get; set; }
    }

    public class GameObject : Panel
    {
        public int LeftBound => Location.X;
        public int TopBound => Location.Y;
        public int RightBound => Location.X + Width;
        public int BottomBound => Location.Y + Height;
        public Point Center => new Point(LeftBound + Width / 2, TopBound + Height / 2);
    }

    public struct Vector
    {
        public float X { readonly get; set; }
        public float Y { readonly get; set; }

        public static Vector Zero = new Vector(0, 0);

        public Vector(float x, float y)
        {
            X = x;
            Y = y;
        }

        public float Length => (float)Math.Sqrt(X * X + Y * Y);

        public Vector Normalize()
        {
            return new Vector(X / Length, Y / Length);
        }

        public static Vector operator +(Vector v1, Vector v2)
        {
            return new Vector(v1.X + v2.X, v1.Y + v2.Y);
        }

        public static Point operator +(Point p, Vector v)
        {
            return new Point(p.X + (int)v.X, p.Y + (int)v.Y);
        }
        public static Vector operator *(Vector v, float n)
        {
            return new Vector(v.X * n, v.Y * n);
        }
    }

    public class Hero : GameObject, IMovable
    {
        public Vector Speed { get; set; }

        void IMovable.Move()
        {
            throw new NotImplementedException();
        }
    }

    public class Projectile : GameObject
    {

    }
}
