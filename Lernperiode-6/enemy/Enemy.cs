using Lernperiode_6.player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Lernperiode_6.enemy
{
    internal class Enemy : UserControl
    {

        private int _health;
        private int _damage;
        private int _attackSpeed;
        private int _defense;

        private PictureBox _image;
        public CustomProgressBar EnemyHealthBar;
        private System.Windows.Forms.Timer EnemyAttackTimer;
        private Typ typ;

        public StatsControl StatsEnemy { get; private set; }

        public int Health
        {
            get { return _health; }
            set
            {
                if (value < 0)
                    _health = 0;
                else if (value > EnemyHealthBar.Maximum)
                    _health = EnemyHealthBar.Maximum;
                else
                    _health = value;
            }
        }

        public Enemy(int health, int damage, int attackSpeed, int defense)
        {
            _health = health;
            _damage = damage;
            _attackSpeed = attackSpeed;
            _defense = defense;

            this.Location = new Point(500, 100);
            this.Size = new Size(100, 140);

            _image = new PictureBox();
            _image.Image = Image.FromFile(@"C:\Users\joshu\source\repos\Lernperiode-6\Lernperiode-6\Images\Enemy.JPEG");
            _image.SizeMode = PictureBoxSizeMode.StretchImage;
            _image.Size = new Size(80, 80);
            _image.Location = new Point(0, 10);
            this.Controls.Add(_image);

            EnemyHealthBar = new CustomProgressBar();
            EnemyHealthBar.Size = new Size(35, 5);
            EnemyHealthBar.Location = new Point(700, 200);
            EnemyHealthBar.Maximum = health;
            EnemyHealthBar.Value = health;
            EnemyHealthBar.BackColor = Color.Black;
            EnemyHealthBar.ForeColor = Color.Red;

            this.Controls.Add(EnemyHealthBar);

            StatsEnemy = new StatsControl(health, damage, attackSpeed, defense);
        }

        public void TakeDamage(int damage)
        {
            Health = Health - (damage * (_defense/100));
                
            EnemyHealthBar.Value = Health;
        }

        public void Attack(Typ target)
        {
            typ = target;

            EnemyAttackTimer = new System.Windows.Forms.Timer();
            EnemyAttackTimer.Interval = 1000 / _attackSpeed;
            EnemyAttackTimer.Tick += DealDamage;
            EnemyAttackTimer.Start();
        }

        private void DealDamage(object sender, EventArgs e)
        {
            if (typ != null && typ.Health > 0)
            {
                typ.TakeDamage(_damage);
            }
        }
    }




    public class CustomProgressBar : ProgressBar
    {
        public Color BarColor { get; set; } = Color.Red;

        public CustomProgressBar()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rect = ClientRectangle;

            using (SolidBrush brush = new SolidBrush(BarColor))
            {
                
                int width = (int)(rect.Width * ((double)Value / Maximum));
                e.Graphics.FillRectangle(brush, 0, 0, width, rect.Height);
            }

            
            e.Graphics.DrawRectangle(Pens.Black, 0, 0, rect.Width - 1, rect.Height - 1);
        }
    }



    public class StatsControlEnemy : UserControl
    {
        private CustomProgressBar _health;
        private CustomProgressBar _damage;
        private CustomProgressBar _attackSpeed;
        private CustomProgressBar _defense;


        public StatsControlEnemy(int health, int damage, int attackSpeed, int defense)
        {
            this.Size = new Size(300, 100);

            Label lblHealth = new Label { Text = "Health", Location = new Point(5, 5) };
            _health = new CustomProgressBar { Location = new Point(110, 15), Size = new Size(50, 10), Maximum = 100, Value = health };

            Label lblDamage = new Label { Text = "Damage", Location = new Point(5, 30) };
            _damage = new CustomProgressBar { Location = new Point(110, 40), Size = new Size(50, 10), Maximum = 100, Value = damage };

            Label lblAttackSpeed = new Label { Text = "Attackspeed", Location = new Point(5, 55) };
            _attackSpeed = new CustomProgressBar { Location = new Point(110, 65), Size = new Size(50, 10), Maximum = 100, Value = attackSpeed };

            Label lblDefense = new Label { Text = "Defense", Location = new Point(5, 80) };
            _defense = new CustomProgressBar { Location = new Point(110, 90), Size = new Size(50, 10), Maximum = 100, Value = defense };

            this.Controls.AddRange(new Control[] { lblHealth, _health, lblDamage, _damage, lblAttackSpeed, _attackSpeed, lblDefense, _defense });
        }
    }
}
