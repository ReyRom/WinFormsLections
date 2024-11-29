namespace WinFormsGame_31
{
    public partial class MainForm : Form
    {
        private const float MOVESPEED = 5;
        private int _score;
        private Enemy _enemy = new Enemy()
        {
            Location = new Point(400, Random.Shared.Next(200, 300))
        };

        private List<IMovable> _movementList = new List<IMovable>();
        public MainForm()
        {
            InitializeComponent();
            FieldPanel.Controls.Add(_enemy);
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
                var proj = new Projectile() { Location = _hero.Center };
                _movementList.Add(proj);
                FieldPanel.Controls.Add(proj);
            }

            _hero.Speed = speed;
        }
        private void IncreaseScore()
        {
            _score++;
            ScoreMenuItem.Text = $"Score: {_score}";
        }

        private void GameCycleTimer_Tick(object sender, EventArgs e)
        {
            DrawHero();
            foreach(var item in _movementList)
            {
                item.MoveObject();
            }

            _enemy.Speed = new Vector(0, Random.Shared.Next(-10,10));
            _enemy.MoveObject();

            foreach(Projectile item in _movementList)
            {
                if (item.IsCollide(_enemy))
                {
                    _enemy.Dispose();
                    _enemy = new Enemy() { Location = new Point(400,Random.Shared.Next(200, 300)) };
                    IncreaseScore();
                    FieldPanel.Controls.Add(_enemy);
                }
            }

            var removeList = _movementList.Where(x => x.Location.X > Width).ToList();
            
            foreach (var item in removeList)
            {
                _movementList.Remove(item);
                FieldPanel.Controls.Remove(item as Control);
            }
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
        void MoveObject();
        Vector Speed { get; set; }
        Point Location { get; set; }
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

        public void MoveObject()
        {
            throw new NotImplementedException();
        }
    }

    public class Enemy : GameObject, IMovable
    {
        public Enemy()
        {
            Size = new Size(25,25);
            BackColor = Color.Red;
        }

        public Vector Speed { get; set; }

        public void MoveObject()
        {
            Location = Location + Speed;
        }
    }

    public class Projectile : GameObject, IMovable
    {
        public Projectile()
        {
            Size = new Size(5,5);
            BackColor = Color.Red;
        }

        public bool IsCollide(GameObject go)
        {
            return Bounds.IntersectsWith(go.Bounds);
        }

        public Vector Speed { get; set; } = new Vector (25, 0);

        public void MoveObject()
        {
            Location = Location + Speed;
        }
    }
}
