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
                ScoreStatusLabel.Text = $"Счет: {_score}";
            }
        }

        public int HP
        {
            get => CoolHero.HealthPoints;
            set
            {
                CoolHero.HealthPoints = value;
                HealthPointsStatusLabel.Text = $"HP: {HP}";
            }
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void Restart()
        {
            Score = 0;
            HP = 3;
            Enemy.Movespeed = 1;
            HighScoreStatusLabel.Text = $"Рекорд: {Properties.Settings.Default.HighScore}";
            CoolHero.Location = new Point(FieldPanel.Width / 2 - CoolHero.Width / 2, FieldPanel.Height / 2 - CoolHero.Height / 2);
            CoolHero.Speed = Vector.Zero;
            FieldPanel.Controls.OfType<Enemy>().ToList().ForEach(enemy =>
            {
                FieldPanel.Controls.Remove(enemy);
                enemy.Dispose();
            });
            FieldPanel.Controls.OfType<Projectile>().ToList().ForEach(proj =>
            {
                FieldPanel.Controls.Remove(proj);
                proj.Dispose();
            });
            GameTimer.Start();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Restart();
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            if (_counter % 25 == 0)
            {
                SpawnEnemy();
            }

            if (_counter % 10 == 0)
            {
                Enemy.Movespeed += 0.05f;
            }

            

            CoolHero.MoveWithSpeed();
            FieldPanel.Controls.OfType<Projectile>().ToList().ForEach(p =>
            {
                p.MoveWithSpeed();
            });

            FieldPanel.Controls.OfType<Enemy>().ToList().ForEach(e =>
            {
                Vector vector = new Vector(CoolHero.Location.X - e.Location.X, CoolHero.Location.Y - e.Location.Y).Normalize() * Enemy.Movespeed;
                e.Speed = vector;

                FieldPanel.Controls.OfType<Projectile>().ToList().ForEach(p =>
                {
                    if (p.IsCollide(e))
                    {
                        FieldPanel.Controls.Remove(p);
                        FieldPanel.Controls.Remove(e);
                        e.Dispose();
                        p.Dispose();
                        Score++;
                    }
                });

                if (e.IsCollide(CoolHero))
                {
                    HP--;
                    FieldPanel.Controls.Remove(e);
                    e.Dispose();
                }

                e.MoveWithSpeed();
            });

            ValidateHeroOnField();

            if (HP <= 0)
            {
                GameTimer.Stop();

                if(Score > Properties.Settings.Default.HighScore)
                {
                    Properties.Settings.Default.HighScore = Score;
                    Properties.Settings.Default.Save();
                }


                MessageBox.Show("Потрачено!");
            }


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
                var proj = new Projectile();
                proj.Location = CoolHero.Center;
                var point = FieldPanel.PointToClient(MousePosition);
                Vector vector = new Vector(point.X - CoolHero.Center.X, point.Y - CoolHero.Center.Y).Normalize() * 20;
                proj.Speed = vector;

                FieldPanel.Controls.Add(proj);
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

        private void NewGameMenuItem_Click(object sender, EventArgs e)
        {
            Restart();
        }
    }



    public class Hero : GameObject
    {
        public const float MOVESPEED = 5;

        public float Angle { get; set; } = 50;

        public int HealthPoints { get; set; } = 3;

        public Hero()
        {
            Size = new Size(30, 30);
            BackColor = Color.Blue;
            Speed = Vector.Zero;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.RotateTransform(Angle);
            base.OnPaint(e);
        }
    }

    public class Enemy : GameObject
    {
        public static float Movespeed = 1;
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
