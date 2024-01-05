namespace Berberim
{
    partial class Giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris));
            textBox1 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            btnSign = new Button();
            title = new Label();
            btnLogin = new Button();
            pswrdbtn5 = new Button();
            pswrdbtn6 = new Button();
            btnSign2 = new Button();
            panel2 = new Panel();
            title2 = new Label();
            linkLabel1 = new LinkLabel();
            btnBack = new Button();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            textBox5 = new TextBox();
            textBox3 = new TextBox();
            checkBox1 = new CheckBox();
            label3 = new Label();
            tcbox = new TextBox();
            sifrebox2 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            pswrdbtn2 = new Button();
            pswrdbtn4 = new Button();
            pswrdbtn = new Button();
            pswrdbtn3 = new Button();
            pictureBoxCikis = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCikis).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Window;
            textBox1.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(377, 170);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(300, 35);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(73, 170);
            label1.Name = "label1";
            label1.Size = new Size(225, 32);
            label1.TabIndex = 2;
            label1.Text = "T.C. Kimlik No";
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Window;
            textBox2.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.Location = new Point(377, 235);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(257, 35);
            textBox2.TabIndex = 3;
            textBox2.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(106, 250);
            label2.Name = "label2";
            label2.Size = new Size(84, 32);
            label2.TabIndex = 4;
            label2.Text = "Şifre";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Bisque;
            panel1.Controls.Add(btnSign);
            panel1.Controls.Add(title);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pswrdbtn5);
            panel1.Controls.Add(pswrdbtn6);
            panel1.Location = new Point(1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(860, 499);
            panel1.TabIndex = 6;
            panel1.Paint += panel1_Paint;
            // 
            // btnSign
            // 
            btnSign.BackColor = Color.WhiteSmoke;
            btnSign.Cursor = Cursors.Hand;
            btnSign.Font = new Font("Verdana", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnSign.Location = new Point(284, 342);
            btnSign.Name = "btnSign";
            btnSign.Size = new Size(169, 51);
            btnSign.TabIndex = 5;
            btnSign.Text = "Kayıt Ol";
            btnSign.UseVisualStyleBackColor = false;
            btnSign.Click += btnSign_Click;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Bookman Old Style", 48F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            title.ForeColor = Color.DarkBlue;
            title.Location = new Point(221, 33);
            title.Name = "title";
            title.Size = new Size(413, 93);
            title.TabIndex = 5;
            title.Text = "berberim";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.WhiteSmoke;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.Font = new Font("Verdana", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnLogin.Location = new Point(542, 342);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(169, 51);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Giriş Yap";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // pswrdbtn5
            // 
            pswrdbtn5.BackgroundImage = (Image)resources.GetObject("pswrdbtn5.BackgroundImage");
            pswrdbtn5.BackgroundImageLayout = ImageLayout.Center;
            pswrdbtn5.Cursor = Cursors.Hand;
            pswrdbtn5.Location = new Point(632, 234);
            pswrdbtn5.Name = "pswrdbtn5";
            pswrdbtn5.Size = new Size(45, 36);
            pswrdbtn5.TabIndex = 18;
            pswrdbtn5.UseVisualStyleBackColor = true;
            pswrdbtn5.Click += pswrdbtn5_Click_1;
            // 
            // pswrdbtn6
            // 
            pswrdbtn6.BackgroundImage = (Image)resources.GetObject("pswrdbtn6.BackgroundImage");
            pswrdbtn6.BackgroundImageLayout = ImageLayout.Center;
            pswrdbtn6.Cursor = Cursors.Hand;
            pswrdbtn6.Location = new Point(632, 234);
            pswrdbtn6.Name = "pswrdbtn6";
            pswrdbtn6.Size = new Size(45, 36);
            pswrdbtn6.TabIndex = 19;
            pswrdbtn6.UseVisualStyleBackColor = true;
            pswrdbtn6.Click += pswrdbtn6_Click_1;
            // 
            // btnSign2
            // 
            btnSign2.BackColor = Color.WhiteSmoke;
            btnSign2.Cursor = Cursors.Hand;
            btnSign2.Font = new Font("Verdana", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnSign2.Location = new Point(475, 502);
            btnSign2.Name = "btnSign2";
            btnSign2.Size = new Size(169, 51);
            btnSign2.TabIndex = 8;
            btnSign2.Text = "Kayıt Ol";
            btnSign2.UseVisualStyleBackColor = false;
            btnSign2.Click += btnSign2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Bisque;
            panel2.Controls.Add(title2);
            panel2.Controls.Add(btnSign2);
            panel2.Controls.Add(linkLabel1);
            panel2.Controls.Add(btnBack);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(textBox5);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(checkBox1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(tcbox);
            panel2.Controls.Add(sifrebox2);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(pswrdbtn2);
            panel2.Controls.Add(pswrdbtn4);
            panel2.Controls.Add(pswrdbtn);
            panel2.Controls.Add(pswrdbtn3);
            panel2.Location = new Point(1, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1000, 600);
            panel2.TabIndex = 7;
            panel2.Paint += panel2_Paint;
            // 
            // title2
            // 
            title2.AutoSize = true;
            title2.Font = new Font("Bookman Old Style", 48F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            title2.ForeColor = Color.DarkBlue;
            title2.Location = new Point(274, 4);
            title2.Name = "title2";
            title2.Size = new Size(413, 93);
            title2.TabIndex = 21;
            title2.Text = "berberim";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Cursor = Cursors.Hand;
            linkLabel1.Location = new Point(313, 429);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(154, 20);
            linkLabel1.TabIndex = 20;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Kullanıcı Sözleşmesini";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.WhiteSmoke;
            btnBack.Cursor = Cursors.Hand;
            btnBack.Font = new Font("Verdana", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnBack.Location = new Point(192, 502);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(169, 51);
            btnBack.TabIndex = 9;
            btnBack.Text = "Geri Dön";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(619, 370);
            label11.Name = "label11";
            label11.Size = new Size(15, 20);
            label11.TabIndex = 15;
            label11.Text = "*";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(619, 309);
            label10.Name = "label10";
            label10.Size = new Size(15, 20);
            label10.TabIndex = 14;
            label10.Text = "*";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(619, 247);
            label9.Name = "label9";
            label9.Size = new Size(15, 20);
            label9.TabIndex = 13;
            label9.Text = "*";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(610, 123);
            label8.Name = "label8";
            label8.Size = new Size(15, 20);
            label8.TabIndex = 10;
            label8.Text = "*";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Georgia", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(35, 123);
            label7.Name = "label7";
            label7.Size = new Size(79, 32);
            label7.TabIndex = 12;
            label7.Text = "İsim";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Georgia", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(35, 186);
            label6.Name = "label6";
            label6.Size = new Size(131, 32);
            label6.TabIndex = 11;
            label6.Text = "Soyisim";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Georgia", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(35, 371);
            label5.Name = "label5";
            label5.Size = new Size(227, 32);
            label5.TabIndex = 10;
            label5.Text = "Şifreyi Onayla";
            // 
            // textBox5
            // 
            textBox5.BackColor = SystemColors.Window;
            textBox5.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            textBox5.Location = new Point(313, 370);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(257, 35);
            textBox5.TabIndex = 9;
            textBox5.UseSystemPasswordChar = true;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.Window;
            textBox3.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            textBox3.Location = new Point(313, 247);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(300, 35);
            textBox3.TabIndex = 7;
            textBox3.TextChanged += textBox3_TextChanged;
            textBox3.KeyPress += textBox3_KeyPress;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(298, 425);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(346, 24);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Kullanıcı sözleşmesini  okudum kabul ediyorum.";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(35, 247);
            label3.Name = "label3";
            label3.Size = new Size(225, 32);
            label3.TabIndex = 2;
            label3.Text = "T.C. Kimlik No";
            // 
            // tcbox
            // 
            tcbox.BackColor = SystemColors.Window;
            tcbox.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            tcbox.Location = new Point(313, 123);
            tcbox.Name = "tcbox";
            tcbox.Size = new Size(300, 35);
            tcbox.TabIndex = 1;
            // 
            // sifrebox2
            // 
            sifrebox2.BackColor = SystemColors.Window;
            sifrebox2.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            sifrebox2.Location = new Point(313, 186);
            sifrebox2.Name = "sifrebox2";
            sifrebox2.Size = new Size(300, 35);
            sifrebox2.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Georgia", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(37, 313);
            label4.Name = "label4";
            label4.Size = new Size(84, 32);
            label4.TabIndex = 4;
            label4.Text = "Şifre";
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.Window;
            textBox4.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            textBox4.Location = new Point(313, 312);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(257, 35);
            textBox4.TabIndex = 8;
            textBox4.UseSystemPasswordChar = true;
            // 
            // pswrdbtn2
            // 
            pswrdbtn2.BackgroundImage = (Image)resources.GetObject("pswrdbtn2.BackgroundImage");
            pswrdbtn2.BackgroundImageLayout = ImageLayout.Center;
            pswrdbtn2.Cursor = Cursors.Hand;
            pswrdbtn2.Location = new Point(568, 311);
            pswrdbtn2.Name = "pswrdbtn2";
            pswrdbtn2.Size = new Size(45, 36);
            pswrdbtn2.TabIndex = 17;
            pswrdbtn2.UseVisualStyleBackColor = true;
            pswrdbtn2.Click += pswrdbtn2_Click;
            // 
            // pswrdbtn4
            // 
            pswrdbtn4.BackgroundImage = (Image)resources.GetObject("pswrdbtn4.BackgroundImage");
            pswrdbtn4.BackgroundImageLayout = ImageLayout.Center;
            pswrdbtn4.Cursor = Cursors.Hand;
            pswrdbtn4.Location = new Point(568, 369);
            pswrdbtn4.Name = "pswrdbtn4";
            pswrdbtn4.Size = new Size(45, 36);
            pswrdbtn4.TabIndex = 19;
            pswrdbtn4.UseVisualStyleBackColor = true;
            pswrdbtn4.Click += pswrdbtn4_Click;
            // 
            // pswrdbtn
            // 
            pswrdbtn.BackgroundImage = (Image)resources.GetObject("pswrdbtn.BackgroundImage");
            pswrdbtn.BackgroundImageLayout = ImageLayout.Center;
            pswrdbtn.Cursor = Cursors.Hand;
            pswrdbtn.Location = new Point(568, 309);
            pswrdbtn.Name = "pswrdbtn";
            pswrdbtn.Size = new Size(45, 36);
            pswrdbtn.TabIndex = 16;
            pswrdbtn.UseVisualStyleBackColor = true;
            pswrdbtn.Click += pswrdbtn_Click;
            // 
            // pswrdbtn3
            // 
            pswrdbtn3.BackgroundImage = (Image)resources.GetObject("pswrdbtn3.BackgroundImage");
            pswrdbtn3.BackgroundImageLayout = ImageLayout.Center;
            pswrdbtn3.Cursor = Cursors.Hand;
            pswrdbtn3.Location = new Point(568, 369);
            pswrdbtn3.Name = "pswrdbtn3";
            pswrdbtn3.Size = new Size(45, 36);
            pswrdbtn3.TabIndex = 18;
            pswrdbtn3.UseVisualStyleBackColor = true;
            pswrdbtn3.Click += pswrdbtn3_Click;
            // 
            // pictureBoxCikis
            // 
            pictureBoxCikis.Cursor = Cursors.Hand;
            pictureBoxCikis.Image = (Image)resources.GetObject("pictureBoxCikis.Image");
            pictureBoxCikis.Location = new Point(1053, 25);
            pictureBoxCikis.Name = "pictureBoxCikis";
            pictureBoxCikis.Size = new Size(107, 74);
            pictureBoxCikis.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxCikis.TabIndex = 8;
            pictureBoxCikis.TabStop = false;
            pictureBoxCikis.Click += pictureBoxCikis_Click;
            // 
            // Giris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SandyBrown;
            ClientSize = new Size(1182, 753);
            Controls.Add(pictureBoxCikis);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Giris";
            Text = "Berberim";
            Load += Giris_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCikis).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button pswrdbtn3;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private Button pswrdbtn4;
        private Panel panel1;
        private Panel panel2;
        private Label label3;
        private TextBox tcbox;
        private TextBox sifrebox2;
        private Label label4;
        private Button btnSign;
        private Button btnLogin;
        private CheckBox checkBox1;
        private Label label6;
        private Label label5;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private Label label7;
        private Button btnSign2;
        private Button btnBack;
        private Label label9;
        private Label label8;
        private Label label11;
        private Label label10;
        private Button pswrdbtn2;
        private Button pswrdbtn;
        private Label title;
        private LinkLabel linkLabel1;
        private Button pswrdbtn5;
        private Button pswrdbtn6;
        private Label title2;
        private PictureBox pictureBoxCikis;
    }
}