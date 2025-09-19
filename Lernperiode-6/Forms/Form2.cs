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
        private Enemy _enemy;
        private Archer _archer;
        private Berserker _berserker;
        private Form2 parent;
        public Typ playerUnit;
        public Form2()
        {
            InitializeComponent();
            this.parent = this;
            _enemy = new Enemy(100, 40, 25, 15);
            Controls.Add(_enemy);

            FlowLayoutPanel statsEnemy = new FlowLayoutPanel();
            statsEnemy.FlowDirection = FlowDirection.TopDown;
            statsEnemy.Location = new Point(_enemy.Left + 90, 100);
            statsEnemy.Size = new Size(220, 400);
            this.Controls.Add(statsEnemy);

            statsEnemy.Controls.Add(_enemy.StatsEnemy);
        }

        public void create_btn_Click(object sender, EventArgs e)
        {
            Form typeSelect = new TypeSelect(this);
            typeSelect.Show();     
        }

        private void fight_btn_Click(object sender, EventArgs e)
        {
            Fight(playerUnit, _enemy);
        }

        private void Fight(Typ player, Enemy enemy)
        {
            player.Attack(enemy);
            enemy.Attack(player);
        }
    }
}
