using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lernperiode_6.player
{
    public class StatsControl : UserControl
    {
        private ProgressBar _health;
        private ProgressBar _damage;
        private ProgressBar _attackSpeed;
        private ProgressBar _defense;


        public StatsControl(int health, int damage, int attackSpeed, int defense)
        {
            this.Size = new Size(300, 100);

            Label lblHealth = new Label { Text = "Health", Location = new Point(5, 5) };
            _health = new ProgressBar { Location = new Point(110, 15), Size = new Size(50, 10), Maximum = 100, Value = health };

            Label lblDamage = new Label { Text = "Damage", Location = new Point(5, 30) };
            _damage = new ProgressBar { Location = new Point(110, 40), Size = new Size(50, 10), Maximum= 100, Value = damage };

            Label lblAttackSpeed = new Label { Text = "Attackspeed", Location= new Point(5, 55) };
            _attackSpeed = new ProgressBar {Location = new Point(110, 65), Size = new Size(50, 10),Maximum = 100, Value = attackSpeed };

            Label lblDefense = new Label { Text = "Defense", Location =  new Point(5, 80) };
            _defense = new ProgressBar { Location = new Point(110, 90), Size = new Size(50, 10), Maximum = 100, Value = defense };

            this.Controls.AddRange(new Control[] { lblHealth, _health, lblDamage, _damage, lblAttackSpeed, _attackSpeed, lblDefense, _defense });
        }
    }
}
