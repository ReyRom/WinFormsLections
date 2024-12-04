namespace WinFormsGame_34_45
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            GameTimer.Start();
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            CoolHero.MoveWithSpeed();
            FieldPanel.Controls.OfType<Projectile>().ToList().ForEach(x => x.MoveWithSpeed());
            ValidateHeroOnField();
        }

        private void ValidateHeroOnField()
        {
            var loc = CoolHero.Location;
            if (CoolHero.Location.X > FieldPanel.Width)
            {
                loc.X = -CoolHero.Width;
            }
            if (CoolHero.Location.X < -CoolHero.Width)
            {
                loc.X = FieldPanel.Width;
            }
            if (CoolHero.Location.Y > FieldPanel.Height)
            {
                loc.Y = -CoolHero.Height;
            }
            if (CoolHero.Location.Y < -CoolHero.Height)
            {
                loc.Y = FieldPanel.Height;
            }
            CoolHero.Location = loc;
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            var speed = CoolHero.Speed;
            if (e.KeyCode == Keys.Up)
            {
                speed.Y = -Hero.MOVESPEED;
            }
            if (e.KeyCode == Keys.Down)
            {
                speed.Y = Hero.MOVESPEED;
            }
            if (e.KeyCode == Keys.Left)
            {
                speed.X = -Hero.MOVESPEED;
            }
            if (e.KeyCode == Keys.Right)
            {
                speed.X = Hero.MOVESPEED;
            }
            CoolHero.Speed = speed;

            if (e.KeyCode == Keys.Space)
            {
                var proj = new Projectile();
                proj.Location = CoolHero.Center;
                FieldPanel.Controls.Add(proj);
            }
        }

        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            var speed = CoolHero.Speed;
            if (e.KeyCode == Keys.Up)
            {
                speed.Y = 0;
            }
            if (e.KeyCode == Keys.Down)
            {
                speed.Y = 0;
            }
            if (e.KeyCode == Keys.Left)
            {
                speed.X = 0;
            }
            if (e.KeyCode == Keys.Right)
            {
                speed.X = 0;
            }
            CoolHero.Speed = speed;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            GameTimer.Stop();
        }
    }

    public class Hero : GameObject
    {
        public const float MOVESPEED = 5;
        public Hero()
        {
            Size = new Size(30, 50);
            BackColor = Color.Blue;
            Speed = Vector.Zero;
        }
    }

    public class Projectile : GameObject
    {
        public Projectile()
        {
            Size = new Size(10,3);
            BackColor = Color.Red;
            Speed = new Vector(15, 0);
        }
    }

    public class GameObject : Panel
    {
        public Vector Speed { get; set; }

        public Point Center => new Point(Location.X + Width / 2, Location.Y + Height / 2);

        public void MoveWithSpeed()
        {
            Location = Location + Speed;
        }
    }

    public struct Vector
    {
        public Vector(float x, float y)
        {
            X = x;
            Y = y;
        }

        public static Vector Zero = new Vector(0, 0);

        public float X { get; set; }
        public float Y { get; set; }

        public float Length => (float)Math.Sqrt(X * X + Y * Y);

        public Vector Normalize()
        {
            return new Vector(X / Length, Y / Length);
        }

        public static Vector operator +(Vector v1, Vector v2)
        {
            return new Vector(v1.X + v2.X, v1.Y + v2.Y);
        }

        public static Vector operator *(Vector v1, float n)
        {
            return new Vector(v1.X * n, v1.Y * n);
        }

        public static Point operator +(Point p, Vector v)
        {
            return new Point(p.X + (int)v.X, p.Y + (int)v.Y);
        }
    }
}
