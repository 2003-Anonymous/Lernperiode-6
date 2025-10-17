using Lernperiode_6.enemy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lernperiode_6.player
{
    public class Berserker : Typ
    {
        private Enemy enemy;
        protected readonly int _healthMax = 80;
        protected readonly int _damageMax = 20;
        protected readonly int _attackSpeedMax = 20;
        protected readonly int _defenseMax = 40;

        public override int HealthMax => _healthMax;
        public override int DamageMax => _damageMax;
        public override int AttackSpeedMax => _attackSpeedMax;
        public override int DefenseMax => _defenseMax;
        public Berserker(int[] s)
        : base(s)
        {
            _image = new PictureBox();
            _image.Image = Image.FromFile(@"C:\Users\joshu\source\repos\Lernperiode-6\Lernperiode-6\Images\Berserker.JPEG");
            _image.SizeMode = PictureBoxSizeMode.StretchImage;
            _image.Size = new Size(80, 80);
            _image.Location = new Point(0, 10);
            this.Controls.Add(_image);

            this.Size = new Size(100, 140);
            this.Location = new Point(250, 100);

            Stats = new StatsControl(statsArray);
            
        }
        public Berserker()
        {
            _image = new PictureBox();
            _image.Image = Image.FromFile(@"C:\Users\joshu\source\repos\Lernperiode-6\Lernperiode-6\Images\Berserker.JPEG");
            _image.SizeMode = PictureBoxSizeMode.StretchImage;
            _image.Size = new Size(80, 80);
            _image.Location = new Point(0, 10);
            this.Controls.Add(_image);

            this.Size = new Size(100, 140);
            this.Location = new Point(250, 100);

            EnterStats = new StatsEnter(HealthMax, DamageMax, AttackSpeedMax, DefenseMax);
        }
    }
}
