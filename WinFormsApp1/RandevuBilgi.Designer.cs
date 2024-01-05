namespace Berberim
{
    partial class RandevuBilgi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RandevuBilgi));
            panel1 = new Panel();
            label8 = new Label();
            pictureBoxBack = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBack).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(30, 116);
            panel1.Name = "panel1";
            panel1.Size = new Size(346, 288);
            panel1.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Bookman Old Style", 40.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.ForeColor = Color.DarkBlue;
            label8.Location = new Point(30, 18);
            label8.Name = "label8";
            label8.Size = new Size(346, 78);
            label8.TabIndex = 10;
            label8.Text = "berberim";
            // 
            // pictureBoxBack
            // 
            pictureBoxBack.Cursor = Cursors.Hand;
            pictureBoxBack.Image = (Image)resources.GetObject("pictureBoxBack.Image");
            pictureBoxBack.Location = new Point(0, 410);
            pictureBoxBack.Name = "pictureBoxBack";
            pictureBoxBack.Size = new Size(64, 63);
            pictureBoxBack.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxBack.TabIndex = 11;
            pictureBoxBack.TabStop = false;
            pictureBoxBack.Click += pictureBoxBack_Click;
            // 
            // RandevuBilgi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(416, 471);
            Controls.Add(pictureBoxBack);
            Controls.Add(label8);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RandevuBilgi";
            Text = "RandevuBilgi";
            ((System.ComponentModel.ISupportInitialize)pictureBoxBack).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label8;
        private PictureBox pictureBoxBack;
    }
}