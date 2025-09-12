using Lernperiode_6.player;
using Lernperiode_6.enemy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;


namespace Lernperiode_6
{
    public partial class Form2 : Form
    {
        private Enemy enemy;
        private Archer archer;
        private Form2 parent;
        public Form2()
        {
            InitializeComponent();
            this.parent = this;
            enemy = new Enemy(100, 40, 1, 15);
            Controls.Add(enemy);

            FlowLayoutPanel statsEnemy = new FlowLayoutPanel();
            statsEnemy.FlowDirection = FlowDirection.TopDown;
            statsEnemy.Location = new Point(enemy.Left + 90, 100);
            statsEnemy.Size = new Size(220, 400);
            this.Controls.Add(statsEnemy);

            statsEnemy.Controls.Add(enemy.StatsEnemy);
        }

        public void create_btn_Click(object sender, EventArgs e)
        {
            Form typeSelect = new TypeSelect(this);
            typeSelect.Show();

            
        }

        private void fight_btn_Click(object sender, EventArgs e)
        {
            Fight(archer, enemy);
        }

        private void Fight(Archer archer, Enemy enemy)
        {
            archer.Attack(enemy);
            enemy.Attack(archer);
        }
    }
}
