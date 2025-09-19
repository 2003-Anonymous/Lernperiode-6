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
                new Point(75, 50),
                new Point(75, 100),
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
                //Für TypeSelect
                Archer archerCopy = new Archer();
                this.Controls.Add(archerCopy);

                FlowLayoutPanel statsPanelAC = new FlowLayoutPanel();
                statsPanelAC.FlowDirection = FlowDirection.TopDown;
                statsPanelAC.Size = new Size(220, 400);
                statsPanelAC.Location = new Point(archerCopy.Left + 90, archerCopy.Top);
                this.Controls.Add(statsPanelAC);

                statsPanelAC.Controls.Add(archerCopy.EnterStats);

                
            }
            else if(typeName == "Berserker")
            {
                //Für TypeSelect
                Berserker berserkerCopy = new Berserker(100, 80, 50, 20);
                Controls.Add(berserkerCopy);

                FlowLayoutPanel statsPanelBC = new FlowLayoutPanel();
                statsPanelBC.FlowDirection = FlowDirection.TopDown;
                statsPanelBC.Size = new Size(220, 400);
                statsPanelBC.Location = new Point(berserkerCopy.Left + 90, berserkerCopy.Top);
                this.Controls.Add(statsPanelBC);

                statsPanelBC.Controls.Add(berserkerCopy.EnterStats);
                Controls.Add(berserkerCopy);

                //Für Form2
                Berserker berserker = new Berserker(100, 80, 50, 20);
                Controls.Add(berserker);
                berserker.Location = new Point(150, 100);

                FlowLayoutPanel statsPanelB = new FlowLayoutPanel();
                statsPanelB.FlowDirection = FlowDirection.TopDown;
                statsPanelB.Size = new Size(220, 400);
                statsPanelB.Location = new Point(berserker.Left + 90, berserker.Top);
                this.parent.Controls.Add(statsPanelB);

                
                statsPanelB.Controls.Add(berserker.Stats);
                parent.Controls.Add(berserker);

                parent.playerUnit = berserker;
            }
        }
        private void commit_btn_Click(object sender, EventArgs e)
        {
            //Für Form2
            Archer archer = new Archer();
            Controls.Add(archer);
            archer.Location = new Point(150, 100);

            FlowLayoutPanel statsPanelA = new FlowLayoutPanel();
            statsPanelA.FlowDirection = FlowDirection.TopDown;
            statsPanelA.Size = new Size(220, 400);
            statsPanelA.Location = new Point(archer.Left + 90, archer.Top);
            this.parent.Controls.Add(statsPanelA);

            

            statsPanelA.Controls.Add(archer.Stats);
            parent.Controls.Add(archer);

            parent.playerUnit = archer;

            this.Close();
        }
    }
}
