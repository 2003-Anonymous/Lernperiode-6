using Lernperiode_6.enemy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using Lernperiode_6.player;

namespace Lernperiode_6.player
{
    public class Archer : Typ   
    {
        private Enemy enemy;
        protected int _healthMax = 60;
        protected int _damageMax = 40;
        protected int _attackSpeedMax = 30;
        protected int _defenseMax = 20;

        public override int HealthMax => _healthMax;
        public override int DamageMax => _damageMax;
        public override int AttackSpeedMax => _attackSpeedMax;
        public override int DefenseMax => _defenseMax;

        public Archer(int[] s)
        : base(s)
        {
            _image = new PictureBox();
            _image.Image = Image.FromFile(@"C:\Users\joshu\source\repos\Lernperiode-6\Lernperiode-6\Images\Archer.JPEG");
            _image.SizeMode = PictureBoxSizeMode.StretchImage;
            _image.Size = new Size(80, 80);
            _image.Location = new Point(0, 10);
            this.Controls.Add(_image);

            this.Size = new Size(100, 140);
            this.Location = new Point(250, 100);

            this.BackColor = Color.Transparent;



            Stats = new StatsControl(statsArray);
        }

        public Archer()
        {
            _image = new PictureBox();
            _image.Image = Image.FromFile(@"C:\Users\joshu\source\repos\Lernperiode-6\Lernperiode-6\Images\Archer.JPEG");
            _image.SizeMode = PictureBoxSizeMode.StretchImage;
            _image.Size = new Size(80, 80);
            _image.Location = new Point(0, 10);
            this.Controls.Add(_image);

            this.Size = new Size(100, 140);
            this.Location = new Point(250, 100);

            this.BackColor = Color.Transparent;

            EnterStats = new StatsEnter(HealthMax, DamageMax, AttackSpeedMax, DefenseMax);
        }


    }
}
