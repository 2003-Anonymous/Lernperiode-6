using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Lernperiode_6.player
{
    internal class Archer : Typ   
    {
        public Archer(int health, int damage, int attackSpeed, int defense)
        : base(health, damage, attackSpeed, defense)
        {
            _image = new PictureBox();
            _image.Image = Image.FromFile(@"C:\Users\joshu\source\repos\Lernperiode-6\Lernperiode-6\Images\Archer.JPEG");
            _image.SizeMode = PictureBoxSizeMode.StretchImage;
            _image.Size = new Size(80, 80);
            _image.Location = new Point(0, 10);
            this.Controls.Add(_image);

            this.Size = new Size(100, 140);
            this.Location = new Point(100, 100);

            Stats = new StatsControl(health, damage, attackSpeed, defense);
        }
    }
}
