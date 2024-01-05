namespace Berberim
{
    partial class GecmisRandevu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GecmisRandevu));
            panelGecmis = new Panel();
            panelBaslik = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label8 = new Label();
            pictureBox2 = new PictureBox();
            panelBaslik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panelGecmis
            // 
            panelGecmis.Location = new Point(60, 246);
            panelGecmis.Name = "panelGecmis";
            panelGecmis.Size = new Size(615, 454);
            panelGecmis.TabIndex = 0;
            // 
            // panelBaslik
            // 
            panelBaslik.Controls.Add(label1);
            panelBaslik.Controls.Add(pictureBox1);
            panelBaslik.Location = new Point(60, 140);
            panelBaslik.Name = "panelBaslik";
            panelBaslik.Size = new Size(580, 100);
            panelBaslik.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(98, 36);
            label1.Name = "label1";
            label1.Size = new Size(388, 41);
            label1.TabIndex = 1;
            label1.Text = "Geçmiş Randevularım";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(13, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(79, 74);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Bookman Old Style", 40.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.ForeColor = Color.DarkBlue;
            label8.Location = new Point(49, 35);
            label8.Name = "label8";
            label8.Size = new Size(346, 78);
            label8.TabIndex = 9;
            label8.Text = "berberim";
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(770, 23);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(78, 90);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // GecmisRandevu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(873, 758);
            Controls.Add(pictureBox2);
            Controls.Add(label8);
            Controls.Add(panelBaslik);
            Controls.Add(panelGecmis);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GecmisRandevu";
            Text = "GecmisRandevu";
            Load += GecmisRandevu_Load;
            panelBaslik.ResumeLayout(false);
            panelBaslik.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelGecmis;
        private Panel panelBaslik;
        private PictureBox pictureBox1;
        private Label label8;
        private Label label1;
        private PictureBox pictureBox2;
    }
}