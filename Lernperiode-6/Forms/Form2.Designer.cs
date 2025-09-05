namespace Lernperiode_6
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            create_btn = new Button();
            fight_btn = new Button();
            SuspendLayout();
            // 
            // create_btn
            // 
            create_btn.Location = new Point(12, 409);
            create_btn.Name = "create_btn";
            create_btn.Size = new Size(115, 29);
            create_btn.TabIndex = 0;
            create_btn.Text = "CREATE";
            create_btn.UseVisualStyleBackColor = true;
            create_btn.Click += create_btn_Click;
            // 
            // fight_btn
            // 
            fight_btn.Location = new Point(646, 407);
            fight_btn.Name = "fight_btn";
            fight_btn.Size = new Size(142, 31);
            fight_btn.TabIndex = 1;
            fight_btn.Text = "Fight";
            fight_btn.UseVisualStyleBackColor = true;
            fight_btn.Click += fight_btn_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(fight_btn);
            Controls.Add(create_btn);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion

        private Button create_btn;
        private Button fight_btn;
    }
}