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
using System.Security.Cryptography.X509Certificates;

namespace Lernperiode_6
{
    public partial class Form2 : Form
    {
        public Enemy _enemy;
        private Archer _archer;
        private Berserker _berserker;
        private Form2 parent;
        public Typ playerUnit;
        public Form2()
        {
            InitializeComponent();
            this.parent = this;
            int enemyHealth = 100;
            int enemyDamage = 20;
            int enemyAttackSpeed = 15;
            int enemyDefense = 10;

            createEnemy(enemyHealth, enemyDamage, enemyAttackSpeed, enemyDefense);

            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 100; // alle 100ms prüfen
            timer.Tick += (s, e) =>
            {
                //if (_enemy.Health == 0)
                //{
                //    enemyDamage += 2;
                //    enemyAttackSpeed += 1;
                //    enemyDefense += 3;
                //    createEnemy(enemyHealth, enemyDamage, enemyAttackSpeed, enemyDefense);
                //}
            };
            timer.Start();

        }
        public void createEnemy(int eH, int eDa, int eAS, int eDe)
        {
            _enemy = new Enemy(eH, eDa, eAS, eDe);
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
