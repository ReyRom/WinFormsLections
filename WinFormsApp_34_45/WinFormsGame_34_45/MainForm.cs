using Microsoft.VisualBasic.Devices;

namespace WinFormsGame_34_45
{
    public partial class MainForm : Form
    {
        private int _counter = 0;
        private int _score = 0;

        public int Score
        {
            get => _score;
            set
            {
                _score = value;
                ScoreStatusLabel.Text = $"—чет {_score}";
            }
        }

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
            if (_counter % 25 == 0)
            {
                SpawnEnemy();
            }

            CoolHero.MoveWithSpeed();
            FieldPanel.Controls.OfType<Projectile>().ToList().ForEach(p =>
            {
                p.MoveWithSpeed();
            });

            FieldPanel.Controls.OfType<Enemy>().ToList().ForEach(e =>
            {
                Vector vector = new Vector(CoolHero.Location.X - e.Location.X, CoolHero.Location.Y - e.Location.Y).Normalize() * 3;
                e.Speed = vector;

                FieldPanel.Controls.OfType<Projectile>().ToList().ForEach(p =>
                {
                    if(p.IsCollide(e))
                    {
                        FieldPanel.Controls.Remove(p);
                        FieldPanel.Controls.Remove(e);
                        e.Dispose();
                        p.Dispose();
                        Score++;
                    }
                });

                e.MoveWithSpeed();
            });

            ValidateHeroOnField();




            if (_counter < int.MaxValue)
            {
                _counter++;
            }
            else
            {
                _counter = 0;
            }
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
            if (e.KeyCode == Keys.W)
            {
                speed.Y = -Hero.MOVESPEED;
            }
            if (e.KeyCode == Keys.S)
            {
                speed.Y = Hero.MOVESPEED;
            }
            if (e.KeyCode == Keys.A)
            {
                speed.X = -Hero.MOVESPEED;
            }
            if (e.KeyCode == Keys.D)
            {
                speed.X = Hero.MOVESPEED;
            }
            CoolHero.Speed = speed;

            if (e.KeyCode == Keys.Space)
            {
                
            }
        }

        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            var speed = CoolHero.Speed;
            if (e.KeyCode == Keys.W)
            {
                speed.Y = 0;
            }
            if (e.KeyCode == Keys.S)
            {
                speed.Y = 0;
            }
            if (e.KeyCode == Keys.A)
            {
                speed.X = 0;
            }
            if (e.KeyCode == Keys.D)
            {
                speed.X = 0;
            }
            CoolHero.Speed = speed;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            GameTimer.Stop();
        }

        public void SpawnEnemy()
        {
            var enemy = new Enemy();
            var x = Random.Shared.Next(-enemy.Width, FieldPanel.Width + enemy.Width);
            var y = Random.Shared.Next(-enemy.Height, FieldPanel.Height + enemy.Height);
            if (x > 0 && x < FieldPanel.Width)
            {
                y = y > FieldPanel.Height / 2 ? FieldPanel.Height : -enemy.Height;
            }

            enemy.Location = new Point(x, y);

            FieldPanel.Controls.Add(enemy);
        }

        private void FieldPanel_MouseClick(object sender, MouseEventArgs e)
        {
            var proj = new Projectile();
            proj.Location = CoolHero.Center;

            Vector vector = new Vector(e.X - CoolHero.Center.X, e.Y - CoolHero.Center.Y).Normalize() * 20;
            proj.Speed = vector;

            FieldPanel.Controls.Add(proj);
        }
    }



    public class Hero : GameObject
    {
        public const float MOVESPEED = 5;
        public Hero()
        {
            Size = new Size(30, 30);
            BackColor = Color.Blue;
            Speed = Vector.Zero;
        }
    }

    public class Enemy : GameObject
    {
        public Enemy()
        {
            Size = new Size(25, 25);
            BackColor = Color.Red;
            Speed = Vector.Zero;
        }
    }

    public class Projectile : GameObject
    {
        public Projectile()
        {
            Size = new Size(3, 3);
            BackColor = Color.Red;
            Speed = Vector.Zero;
        }
    }

    public class GameObject : Panel
    {
        public Vector Speed { get; set; }

        public Point Center => new Point(Location.X + Width / 2, Location.Y + Height / 2);

        public bool IsCollide(GameObject o)
        {
            return Bounds.IntersectsWith(o.Bounds);
        }

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
