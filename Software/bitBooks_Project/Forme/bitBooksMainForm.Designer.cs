
namespace bitBooks_Project
{
    partial class bitBooksMainForm
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
            this.btnRecenzije = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnPosudbe = new System.Windows.Forms.Button();
            this.obavijesti_button = new System.Windows.Forms.Button();
            this.btnRezervacije = new System.Windows.Forms.Button();
            this.btnLiveChat = new System.Windows.Forms.Button();
            this.grpAdmin = new System.Windows.Forms.GroupBox();
            this.btnPregledKnjiga = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPrihvatiLivechat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.grpAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRecenzije
            // 
            this.btnRecenzije.Location = new System.Drawing.Point(222, 29);
            this.btnRecenzije.Name = "btnRecenzije";
            this.btnRecenzije.Size = new System.Drawing.Size(82, 23);
            this.btnRecenzije.TabIndex = 6;
            this.btnRecenzije.Text = "Recenzije";
            this.btnRecenzije.UseVisualStyleBackColor = true;
            this.btnRecenzije.Click += new System.EventHandler(this.btnRecenzije_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(36, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(407, 56);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Main Menu";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(198, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(161, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Rezervacija i Posuđivanje";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(96, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Novosti";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "bitBooks";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnPosudbe);
            this.groupBox3.Controls.Add(this.obavijesti_button);
            this.groupBox3.Controls.Add(this.btnRecenzije);
            this.groupBox3.Controls.Add(this.btnRezervacije);
            this.groupBox3.Location = new System.Drawing.Point(36, 214);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(407, 78);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Korisničke aktivnosti";
            // 
            // btnPosudbe
            // 
            this.btnPosudbe.Location = new System.Drawing.Point(115, 29);
            this.btnPosudbe.Name = "btnPosudbe";
            this.btnPosudbe.Size = new System.Drawing.Size(101, 23);
            this.btnPosudbe.TabIndex = 8;
            this.btnPosudbe.Text = "Moje posudbe";
            this.btnPosudbe.UseVisualStyleBackColor = true;
            this.btnPosudbe.Click += new System.EventHandler(this.btnPosudbe_Click);
            // 
            // obavijesti_button
            // 
            this.obavijesti_button.Location = new System.Drawing.Point(310, 29);
            this.obavijesti_button.Name = "obavijesti_button";
            this.obavijesti_button.Size = new System.Drawing.Size(85, 23);
            this.obavijesti_button.TabIndex = 7;
            this.obavijesti_button.Text = "Moje obavijesti";
            this.obavijesti_button.UseVisualStyleBackColor = true;
            this.obavijesti_button.Click += new System.EventHandler(this.obavijesti_button_Click);
            // 
            // btnRezervacije
            // 
            this.btnRezervacije.Location = new System.Drawing.Point(6, 29);
            this.btnRezervacije.Name = "btnRezervacije";
            this.btnRezervacije.Size = new System.Drawing.Size(103, 23);
            this.btnRezervacije.TabIndex = 0;
            this.btnRezervacije.Text = "Moje rezervacije";
            this.btnRezervacije.UseVisualStyleBackColor = true;
            this.btnRezervacije.Click += new System.EventHandler(this.btnRezervacije_Click);
            // 
            // btnLiveChat
            // 
            this.btnLiveChat.Location = new System.Drawing.Point(36, 408);
            this.btnLiveChat.Name = "btnLiveChat";
            this.btnLiveChat.Size = new System.Drawing.Size(102, 40);
            this.btnLiveChat.TabIndex = 9;
            this.btnLiveChat.Text = "Live chat sa knjižničarom";
            this.btnLiveChat.UseVisualStyleBackColor = true;
            this.btnLiveChat.Click += new System.EventHandler(this.btnLiveChat_Click);
            // 
            // grpAdmin
            // 
            this.grpAdmin.Controls.Add(this.btnPregledKnjiga);
            this.grpAdmin.Controls.Add(this.button1);
            this.grpAdmin.Location = new System.Drawing.Point(36, 312);
            this.grpAdmin.Name = "grpAdmin";
            this.grpAdmin.Size = new System.Drawing.Size(407, 78);
            this.grpAdmin.TabIndex = 10;
            this.grpAdmin.TabStop = false;
            this.grpAdmin.Text = "Admin aktivnosti";
            // 
            // btnPregledKnjiga
            // 
            this.btnPregledKnjiga.Location = new System.Drawing.Point(222, 29);
            this.btnPregledKnjiga.Name = "btnPregledKnjiga";
            this.btnPregledKnjiga.Size = new System.Drawing.Size(111, 23);
            this.btnPregledKnjiga.TabIndex = 2;
            this.btnPregledKnjiga.Text = "Pregled svih knjiga";
            this.btnPregledKnjiga.UseVisualStyleBackColor = true;
            this.btnPregledKnjiga.Click += new System.EventHandler(this.btnPregledKnjiga_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(96, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Pregled korisnika";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::bitBooks_Project.Properties.Resources.knjiga;
            this.pictureBox1.Location = new System.Drawing.Point(154, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btnPrihvatiLivechat
            // 
            this.btnPrihvatiLivechat.Location = new System.Drawing.Point(314, 417);
            this.btnPrihvatiLivechat.Name = "btnPrihvatiLivechat";
            this.btnPrihvatiLivechat.Size = new System.Drawing.Size(107, 23);
            this.btnPrihvatiLivechat.TabIndex = 12;
            this.btnPrihvatiLivechat.Text = "Prihvati Livechat";
            this.btnPrihvatiLivechat.UseVisualStyleBackColor = true;
            this.btnPrihvatiLivechat.Click += new System.EventHandler(this.btnPrihvatiLivechat_Click);
            // 
            // bitBooksMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(455, 470);
            this.Controls.Add(this.btnPrihvatiLivechat);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grpAdmin);
            this.Controls.Add(this.btnLiveChat);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Name = "bitBooksMainForm";
            this.Load += new System.EventHandler(this.bitBooksMainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.grpAdmin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRecenzije;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnRezervacije;
        private System.Windows.Forms.Button obavijesti_button;
        private System.Windows.Forms.Button btnLiveChat;
        private System.Windows.Forms.GroupBox grpAdmin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPosudbe;
        private System.Windows.Forms.Button btnPregledKnjiga;
        private System.Windows.Forms.Button btnPrihvatiLivechat;
    }
}

