namespace WinFormsGame_31
{
    public partial class MainForm : Form
    {
        private const float MOVESPEED = 5;
        private int _score = 0;
        private int _counter = 0;
        private Enemy _enemy;
        private Image _enemyImage;
        private Image _heroImage;
        public MainForm()
        {
            InitializeComponent();
            _enemyImage = Image.FromFile("enemy.png");
            _heroImage = Image.FromFile("hero.png");
        }

        public void Reset()
        {
            _score = 0;
            ScoreMenuItem.Text = $"Счет: {_score}";
            _counter = 0;
            FieldPanel.Controls.Clear();

            _hero = new Hero() { Location = new Point(FieldPanel.Width / 2 - _hero.Width / 2, FieldPanel.Height / 2 - _hero.Height / 2) };
            _hero.Paint += Hero_Paint;
            FieldPanel.Controls.Add(_hero);
            GameCycleTimer.Start();

            HighScoreMenuItem.Text = $"Рекорд: {Properties.Settings.Default.HighScore}";
        }

        private void IncreaseScore()
        {
            _score++;
            ScoreMenuItem.Text = $"Счет: {_score}";
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            Vector speed = _hero.Speed;

            if (e.KeyCode == Keys.A)
            {
                speed.X = -MOVESPEED;
            }
            if (e.KeyCode == Keys.D)
            {
                speed.X = MOVESPEED;
            }
            if (e.KeyCode == Keys.W)
            {
                speed.Y = -MOVESPEED;
            }
            if (e.KeyCode == Keys.S)
            {
                speed.Y = MOVESPEED;
            }
            if (e.KeyCode == Keys.Space)
            {
                var ps = (new Vector(FieldPanel.PointToClient(MousePosition)) - new Vector(_hero.Center)).Normalize() * 10;

                var proj = new Projectile() { Location = _hero.Center, Speed = ps, Owner = Owners.Hero };
                FieldPanel.Controls.Add(proj);
            }

            _hero.Speed = speed;
        }


        private void GameCycleTimer_Tick(object sender, EventArgs e)
        {
            DrawHero();


            _counter++;
            if (_counter % 7 == 0)
            {
                FieldPanel.Controls.OfType<Enemy>().ToList().ForEach(enemy =>
                {
                    var speed = new Vector(0, Random.Shared.Next(-10, 10));

                    enemy.Speed = speed;
                });
            }
            if (_counter % 60 == 0)
            {
                FieldPanel.Controls.OfType<Enemy>().ToList().ForEach(enemy =>
                {
                    var ps = (new Vector(_hero.Center) - new Vector(enemy.Center)).Normalize() * 10;
                    var proj = new Projectile()
                    {
                        Location = enemy.Center,
                        Speed = ps,
                        BackColor = Color.Red,
                        Owner = Owners.Enemy
                    };
                    FieldPanel.Controls.Add(proj);
                });
            }

            if (_counter % 30 == 0)
            {
                Enemy enemy = new Enemy();
                enemy.BackgroundImage = _enemyImage;
                enemy.BackgroundImageLayout = ImageLayout.Zoom;
                var x1 = Random.Shared.Next(0, enemy.Width * 4);
                var x2 = Random.Shared.Next(FieldPanel.Width - enemy.Width * 5, FieldPanel.Width - enemy.Width);

                var y = Random.Shared.Next(0, FieldPanel.Height - enemy.Height);

                enemy.Location = new Point((Random.Shared.Next() % 2 == 0) ? x1 : x2, y);
                FieldPanel.Controls.Add(enemy);
            }

            FieldPanel.Controls.OfType<Enemy>().ToList().ForEach(enemy =>
            {
                enemy.MoveObject();
                if (enemy.TopBound + enemy.Speed.Y < 0)
                {
                    enemy.Location = new Point(enemy.Location.X, 0);
                }

                if (enemy.BottomBound + enemy.Speed.Y > FieldPanel.Height)
                {
                    enemy.Location = new Point(enemy.Location.X, FieldPanel.Height - enemy.Height);
                }
            });



            foreach (var item in FieldPanel.Controls.OfType<Projectile>())
            {
                item.MoveObject();


                FieldPanel.Controls.OfType<Enemy>().ToList().ForEach(enemy =>
                {
                    if (item.Owner == Owners.Hero && item.IsCollide(enemy))
                    {
                        FieldPanel.Controls.Remove(enemy);
                        enemy.Dispose();

                        IncreaseScore();
                        item.Owner = Owners.None;
                    }
                });


                if (item.Owner == Owners.Enemy && item.IsCollide(_hero))
                {
                    _hero.HealthPoint--;
                    item.Owner = Owners.None;
                }

                if (item.Location.X > FieldPanel.Width || item.Location.X < -item.Width)
                {
                    item.Owner = Owners.None;
                }
            }

            var removeList = FieldPanel.Controls.OfType<Projectile>().Where(x => x.Owner == Owners.None).ToList();

            foreach (var item in removeList)
            {
                FieldPanel.Controls.Remove(item);
                item.Dispose();
            }

            HealthPointsMenuItem.Text = $"HP = {_hero.HealthPoint}";

            if (_hero.HealthPoint <= 0)
            {
                GameCycleTimer.Stop();
                MessageBox.Show($"Потрачено! \n Счет: {_score}");
                if (Properties.Settings.Default.HighScore < _score)
                {
                    Properties.Settings.Default.HighScore = _score;
                    Properties.Settings.Default.Save();
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Reset();
        }

        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            var speed = _hero.Speed;
            switch (e.KeyCode)
            {
                case Keys.W:
                case Keys.S:
                    speed.Y = 0;
                    break;
                case Keys.A:
                case Keys.D:
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
            _hero.Invalidate();
        }

        private void NewGameMenuItem_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Hero_Paint(object sender, PaintEventArgs e)
        {
            var point = FieldPanel.PointToClient(MousePosition);

            var rotationAngle = (float)(Math.Atan2(point.Y - _hero.Center.Y, point.X-_hero.Center.X)*(180/Math.PI)+90);

            e.Graphics.TranslateTransform(_hero.Width/2, _hero.Height/2);

            e.Graphics.RotateTransform(rotationAngle);

            e.Graphics.DrawImage(_heroImage, -_hero.Width / 2, -_hero.Height / 2, _hero.Width, _hero.Height);
            e.Graphics.ResetTransform();
        }
    }

    public class GameObject : Panel
    {
        public void MoveObject()
        {
            Location = Location + Speed;
        }

        public Vector Speed { get; set; }
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
        public Vector(Point point)
        {
            X = point.X;
            Y = point.Y;
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
        public static Vector operator -(Vector v1, Vector v2)
        {
            return new Vector(v1.X - v2.X, v1.Y - v2.Y);
        }
    }

    public class Hero : GameObject
    {
        public Hero()
        {
            BackColor = Color.Transparent;
            Size = new Size(50, 50);
            DoubleBuffered = true;
        }

        public int HealthPoint { get; set; } = 3;

        public void MoveObject()
        {
            throw new NotImplementedException();
        }
    }

    public class Enemy : GameObject
    {
        public Enemy()
        {
            Size = new Size(40, 40);
            BackColor = Color.Transparent;
        }

    }

    public class Projectile : GameObject
    {
        public Owners Owner { get; set; }
        public Projectile()
        {
            Size = new Size(5, 5);
            BackColor = Color.Blue;
            Speed = new Vector(25, 0);
        }

        public bool IsCollide(GameObject go)
        {
            return Bounds.IntersectsWith(go.Bounds);
        }
    }
    public enum Owners
    {
        None,
        Enemy,
        Hero
    }
}
