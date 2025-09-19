using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

        public StatsControl(int[] statsArray)
        {
            this.Size = new Size(300, 100);

            Label lblHealth = new Label { Text = "Health", Location = new Point(5, 5) };
            Health = new ProgressBar { Location = new Point(110, 15), Size = new Size(50, 10), Maximum = 100, Value = statsArray[0] };

            Label lblDamage = new Label { Text = "Damage", Location = new Point(5, 30) };
            Damage = new ProgressBar { Location = new Point(110, 40), Size = new Size(50, 10), Maximum= 100, Value = statsArray[1] };

            Label lblAttackSpeed = new Label { Text = "Attackspeed", Location= new Point(5, 55) };
            AttackSpeed = new ProgressBar {Location = new Point(110, 65), Size = new Size(50, 10),Maximum = 100, Value = statsArray[2] };

            Label lblDefense = new Label { Text = "Defense", Location =  new Point(5, 80) };
            Defense = new ProgressBar { Location = new Point(110, 90), Size = new Size(50, 10), Maximum = 100, Value = statsArray[3] };

            this.Controls.AddRange(new Control[] { lblHealth, Health, lblDamage, Damage, lblAttackSpeed, AttackSpeed, lblDefense, Defense });
        }
    }

    public class StatsEnter : UserControl
    {
        private TextBox Health;
        private TextBox Damage;
        private TextBox AttackSpeed;
        private TextBox Defense;
        public int[] s;

        public  StatsEnter()
        {
            s = new int[4];

            this.Size = new Size(350, 150);

            Label lblHealth = new Label { Text = "Health", Location = new Point(5, 15) };
            Health = new TextBox { Location = new Point(120, 15), Size = new Size(100, 10), PlaceholderText = "0 - 100" };

            Label lblDamage = new Label { Text = "Damage", Location = new Point(5, 40) };
            Damage = new TextBox { Location = new Point(120, 40), Size = new Size(100, 10), PlaceholderText = "0 - 100" };

            Label lblAttackSpeed = new Label { Text = "AttackSpeed", Location = new Point(5, 65) };
            AttackSpeed = new TextBox { Location = new Point(120, 65), Size = new Size(100, 10), PlaceholderText = "0 - 100" };

            Label lblDefense = new Label { Text = "Defense", Location = new Point(5, 90) };
            Defense = new TextBox { Location = new Point(120, 90), Size = new Size(100, 10), PlaceholderText = "0 - 100"};

            this.Controls.AddRange(new Control[] {lblHealth, Health, lblDamage, Damage, lblAttackSpeed, AttackSpeed, lblDefense, Defense });


            s = TextToStats(s);
            
        }

        public int[] TextToStats(int[] s)
        {
            s[0] = Convert.ToInt32(Health.Text);
            s[1] = Convert.ToInt32(Damage.Text);
            s[2] = Convert.ToInt32(AttackSpeed.Text);
            s[4] = Convert.ToInt32(Defense.Text);

            return s;
        }
    }
}
