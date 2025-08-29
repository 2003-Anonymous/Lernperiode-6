using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lernperiode_6.Enemy
{
    internal class Enemy : UserControl
    {
        private int _health;
        private int _damage;
        private int _attackSpeed;
        private int _defense;

        public CustomProgressBar EnemyHealthBar;

        public Enemy(int health, int damage, int attackSpeed, int defense)
        {
            _health = health;
            _damage = damage;
            _attackSpeed = attackSpeed;
            _defense = defense;

            EnemyHealthBar = new CustomProgressBar();
            EnemyHealthBar.Size = new Size(35, 5);
            EnemyHealthBar.Location = new Point(700, 200);
            EnemyHealthBar.Maximum = health;
            EnemyHealthBar.Value = health;
            EnemyHealthBar.BackColor = Color.Black;
            EnemyHealthBar.ForeColor = Color.Red;

            this.Controls.Add(EnemyHealthBar);
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
                // Fortschrittsbereich zeichnen
                int width = (int)(rect.Width * ((double)Value / Maximum));
                e.Graphics.FillRectangle(brush, 0, 0, width, rect.Height);
            }

            // Rahmen zeichnen
            e.Graphics.DrawRectangle(Pens.Black, 0, 0, rect.Width - 1, rect.Height - 1);
        }
    }
}
