namespace MultiThreadBugGame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            frstBug = new Button();
            scndBug = new Button();
            thrdBug = new Button();
            StartBtn = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // frstBug
            // 
            frstBug.Location = new Point(12, 182);
            frstBug.Name = "frstBug";
            frstBug.Size = new Size(94, 29);
            frstBug.TabIndex = 0;
            frstBug.Text = "BUG1";
            frstBug.UseVisualStyleBackColor = true;
            // 
            // scndBug
            // 
            scndBug.Location = new Point(12, 292);
            scndBug.Name = "scndBug";
            scndBug.Size = new Size(94, 29);
            scndBug.TabIndex = 1;
            scndBug.Text = "BUG2";
            scndBug.UseVisualStyleBackColor = true;
            // 
            // thrdBug
            // 
            thrdBug.Location = new Point(12, 409);
            thrdBug.Name = "thrdBug";
            thrdBug.Size = new Size(94, 29);
            thrdBug.TabIndex = 2;
            thrdBug.Text = "BUG3";
            thrdBug.UseVisualStyleBackColor = true;
            // 
            // StartBtn
            // 
            StartBtn.Location = new Point(12, 63);
            StartBtn.Name = "StartBtn";
            StartBtn.Size = new Size(94, 29);
            StartBtn.TabIndex = 3;
            StartBtn.Text = "START";
            StartBtn.UseVisualStyleBackColor = true;
            StartBtn.Click += Button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(StartBtn);
            Controls.Add(thrdBug);
            Controls.Add(scndBug);
            Controls.Add(frstBug);
            Name = "BugRaceForm";
            Text = "BugRace";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button frstBug;
        private Button scndBug;
        private Button thrdBug;
        private Button StartBtn;
        private Label label1;
    }
}