namespace Lernperiode_6
{
    partial class TypeSelect
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
            commit_btn = new Button();
            SuspendLayout();
            // 
            // commit_btn
            // 
            commit_btn.Location = new Point(348, 375);
            commit_btn.Name = "commit_btn";
            commit_btn.Size = new Size(112, 34);
            commit_btn.TabIndex = 0;
            commit_btn.Text = "Commit";
            commit_btn.UseVisualStyleBackColor = true;
            commit_btn.Click += this.commit_btn_Click;
            // 
            // TypeSelect
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(commit_btn);
            Name = "TypeSelect";
            Text = "TypeSelect";
            ResumeLayout(false);
        }

        #endregion

        private Button commit_btn;
    }
}