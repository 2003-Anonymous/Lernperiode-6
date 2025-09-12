using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lernperiode_6.player
{
    public class StatsControl : UserControl
    {
        private ProgressBar Health;
        private ProgressBar Damage;
        private ProgressBar AttackSpeed;
        private ProgressBar Defense;

        public int HealthSet
        {
            get => Health.Value;
            set => Health.Value = Math.Max(Health.Minimum, Math.Min(Health.Maximum, value));
        }

        public StatsControl(int health, int damage, int attackSpeed, int defense)
        {
            this.Size = new Size(300, 100);

            Label lblHealth = new Label { Text = "Health", Location = new Point(5, 5) };
            Health = new ProgressBar { Location = new Point(110, 15), Size = new Size(50, 10), Maximum = 100, Value = health };

            Label lblDamage = new Label { Text = "Damage", Location = new Point(5, 30) };
            Damage = new ProgressBar { Location = new Point(110, 40), Size = new Size(50, 10), Maximum= 100, Value = damage };

            Label lblAttackSpeed = new Label { Text = "Attackspeed", Location= new Point(5, 55) };
            AttackSpeed = new ProgressBar {Location = new Point(110, 65), Size = new Size(50, 10),Maximum = 100, Value = attackSpeed };

            Label lblDefense = new Label { Text = "Defense", Location =  new Point(5, 80) };
            Defense = new ProgressBar { Location = new Point(110, 90), Size = new Size(50, 10), Maximum = 100, Value = defense };

            this.Controls.AddRange(new Control[] { lblHealth, Health, lblDamage, Damage, lblAttackSpeed, AttackSpeed, lblDefense, Defense });
        }
    }
}
