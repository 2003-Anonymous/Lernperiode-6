using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Lernperiode_6.player
{
    internal class Archer : UserControl
    {
        private ProgressBar _health;
        private int _damage;
        private int _attackspeed;
        private int _defense;
        private PictureBox _image;

        public StatsControl Stats { get; private set; }
        //public int Health
        //{
        //    get
        //    {
        //        return _health;
        //    }
        //    set
        //    {
        //        if (value < 0)
        //        {
        //            _health = 0;
        //        }
        //        else if(value > 100)
        //        {
        //            _health = 100;
        //        }
        //    }
        //}


        public Archer(int health, int damage, int attackSpeed, int defense)
        {
            _damage = damage;
            _attackspeed = attackSpeed;
            _defense = defense;


            

            _image = new PictureBox();
            _image.Image = Image.FromFile(@"C:\Users\joshu\source\repos\Lernperiode-6\Lernperiode-6\Images\Archer.JPEG");
            _image.SizeMode = PictureBoxSizeMode.StretchImage;
            _image.Size = new Size(50, 80);
            _image.Location = new Point(0, 10);
            this.Controls.Add(_image);

            this.Size = new Size(100, 140);

            this.Location = new Point(100, 100);

            Stats = new StatsControl(health, damage, attackSpeed, defense);
        }

    }
}
