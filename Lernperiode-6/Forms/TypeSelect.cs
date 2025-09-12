using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lernperiode_6.player;

namespace Lernperiode_6
{
    public partial class TypeSelect : Form
    {
        public Form2 parent;
        public TypeSelect(Form2 parent)
        {
            InitializeComponent();
            this.parent = parent;

            List<Point> btnPositions = new List<Point>()
            {
                new Point(75, 125),
                new Point(225, 225),
            };

            Size btnSize = new Size(100, 50);
            int counter = 0;

            foreach (Point p in btnPositions)
            {
                Button btn = new Button();
                btn.Text = Typ.types[counter];
                btn.Size = btnSize;
                btn.Location = p;

                btn.Tag = Typ.types[counter];

                btn.Click += TypeButton_Click;
                Controls.Add(btn);
                counter++;
                
            }
        }

        private void TypeButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            string typeName = clickedButton.Tag as string;

            if(typeName == "Archer")
            {
                Archer archer = new Archer(100, 80, 1, 20);
                Controls.Add(archer);

                FlowLayoutPanel statsPanel = new FlowLayoutPanel();
                statsPanel.FlowDirection = FlowDirection.TopDown;
                statsPanel.Size = new Size(220, 400);
                statsPanel.Location = new Point(archer.Left + 90, 100);
                this.Controls.Add(statsPanel);

                statsPanel.Controls.Add(archer.Stats);
                parent.Hide();
            }
        }
        private void commit_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Commit Button wurde geklickt!");
        }
    }
}
