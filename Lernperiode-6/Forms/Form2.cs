using Lernperiode_6.player;
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
        public Form2()
        {
            InitializeComponent();
        }

        private void create_btn_Click(object sender, EventArgs e)
        {
            Archer archer = new Archer(100, 80, 50, 20);
            Controls.Add(archer);

            
            FlowLayoutPanel statsPanel = new FlowLayoutPanel();
            statsPanel.FlowDirection = FlowDirection.TopDown;
            statsPanel.Size = new Size(220, 400);
            statsPanel.Location = new Point(archer.Left +90, 100);
            this.Controls.Add(statsPanel);

            statsPanel.Controls.Add(archer.Stats);
        }
    }
}
