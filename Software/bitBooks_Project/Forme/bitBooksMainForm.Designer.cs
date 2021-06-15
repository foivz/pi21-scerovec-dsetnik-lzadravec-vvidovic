
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
            this.btnPregledClanova = new System.Windows.Forms.Button();
            this.groups = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvUseri = new System.Windows.Forms.DataGridView();
            this.txtPw = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.btnRecenzije = new System.Windows.Forms.Button();
            this.btnProvjera = new System.Windows.Forms.Button();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.prijava_button = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.obavijesti_button = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.btnLiveChat = new System.Windows.Forms.Button();
            this.groups.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUseri)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPregledClanova
            // 
            this.btnPregledClanova.Location = new System.Drawing.Point(164, 38);
            this.btnPregledClanova.Name = "btnPregledClanova";
            this.btnPregledClanova.Size = new System.Drawing.Size(76, 57);
            this.btnPregledClanova.TabIndex = 0;
            this.btnPregledClanova.Text = "Pregled članova";
            this.btnPregledClanova.UseVisualStyleBackColor = true;
            this.btnPregledClanova.Click += new System.EventHandler(this.btnPregledClanova_Click);
            // 
            // groups
            // 
            this.groups.Controls.Add(this.label2);
            this.groups.Controls.Add(this.label1);
            this.groups.Controls.Add(this.dgvUseri);
            this.groups.Controls.Add(this.txtPw);
            this.groups.Controls.Add(this.txtUser);
            this.groups.Controls.Add(this.btnPregledClanova);
            this.groups.Location = new System.Drawing.Point(561, 21);
            this.groups.Name = "groups";
            this.groups.Size = new System.Drawing.Size(345, 274);
            this.groups.TabIndex = 1;
            this.groups.TabStop = false;
            this.groups.Text = "kingDorienTesting";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "username";
            // 
            // dgvUseri
            // 
            this.dgvUseri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUseri.Location = new System.Drawing.Point(26, 118);
            this.dgvUseri.Name = "dgvUseri";
            this.dgvUseri.Size = new System.Drawing.Size(304, 150);
            this.dgvUseri.TabIndex = 3;
            // 
            // txtPw
            // 
            this.txtPw.Location = new System.Drawing.Point(58, 73);
            this.txtPw.Name = "txtPw";
            this.txtPw.Size = new System.Drawing.Size(100, 20);
            this.txtPw.TabIndex = 2;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(58, 38);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 20);
            this.txtUser.TabIndex = 1;
            // 
            // btnRecenzije
            // 
            this.btnRecenzije.Location = new System.Drawing.Point(205, 42);
            this.btnRecenzije.Name = "btnRecenzije";
            this.btnRecenzije.Size = new System.Drawing.Size(105, 23);
            this.btnRecenzije.TabIndex = 6;
            this.btnRecenzije.Text = "Moje recenzije";
            this.btnRecenzije.UseVisualStyleBackColor = true;
            this.btnRecenzije.Click += new System.EventHandler(this.btnRecenzije_Click);
            // 
            // btnProvjera
            // 
            this.btnProvjera.Location = new System.Drawing.Point(655, 312);
            this.btnProvjera.Name = "btnProvjera";
            this.btnProvjera.Size = new System.Drawing.Size(110, 135);
            this.btnProvjera.TabIndex = 2;
            this.btnProvjera.Text = "Ovaj button provjeri tip usera i vraca Korisnik korisnik i do odjave je active ko" +
    "risnik onaj koji se prijavil";
            this.btnProvjera.UseVisualStyleBackColor = true;
            this.btnProvjera.Click += new System.EventHandler(this.btnProvjera_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(655, 486);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(100, 20);
            this.txtStatus.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(655, 467);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "User status:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(29, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(407, 56);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Main Menu";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(312, 20);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Recenzije";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(199, 20);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Pregled knjiga";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(118, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Novosti";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Početna stranica";
            this.button1.UseVisualStyleBackColor = true;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.prijava_button);
            this.groupBox2.Location = new System.Drawing.Point(29, 139);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(407, 63);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Prijava/registracija";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(235, 19);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 1;
            this.button6.Text = "Registracija";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.registracija_button_Click);
            // 
            // prijava_button
            // 
            this.prijava_button.Location = new System.Drawing.Point(79, 19);
            this.prijava_button.Name = "prijava_button";
            this.prijava_button.Size = new System.Drawing.Size(75, 23);
            this.prijava_button.TabIndex = 0;
            this.prijava_button.Text = "Prijava";
            this.prijava_button.UseVisualStyleBackColor = true;
            this.prijava_button.Click += new System.EventHandler(this.prijava_button_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.obavijesti_button);
            this.groupBox3.Controls.Add(this.btnRecenzije);
            this.groupBox3.Controls.Add(this.button8);
            this.groupBox3.Controls.Add(this.button7);
            this.groupBox3.Location = new System.Drawing.Point(29, 224);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(407, 91);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Korisničke aktivnosti";
            // 
            // obavijesti_button
            // 
            this.obavijesti_button.Location = new System.Drawing.Point(315, 42);
            this.obavijesti_button.Name = "obavijesti_button";
            this.obavijesti_button.Size = new System.Drawing.Size(85, 23);
            this.obavijesti_button.TabIndex = 7;
            this.obavijesti_button.Text = "Moje obavijesti";
            this.obavijesti_button.UseVisualStyleBackColor = true;
            this.obavijesti_button.Click += new System.EventHandler(this.obavijesti_button_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(6, 42);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(96, 23);
            this.button8.TabIndex = 1;
            this.button8.Text = "Moje rezervacije";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(108, 42);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(91, 23);
            this.button7.TabIndex = 0;
            this.button7.Text = "Moje posudbe";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // btnLiveChat
            // 
            this.btnLiveChat.Location = new System.Drawing.Point(39, 466);
            this.btnLiveChat.Name = "btnLiveChat";
            this.btnLiveChat.Size = new System.Drawing.Size(102, 40);
            this.btnLiveChat.TabIndex = 9;
            this.btnLiveChat.Text = "Live chat sa knjižničarom";
            this.btnLiveChat.UseVisualStyleBackColor = true;
            this.btnLiveChat.Click += new System.EventHandler(this.btnLiveChat_Click);
            // 
            // bitBooksMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 531);
            this.Controls.Add(this.btnLiveChat);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.btnProvjera);
            this.Controls.Add(this.groups);
            this.Name = "bitBooksMainForm";
            this.Load += new System.EventHandler(this.bitBooksMainForm_Load);
            this.groups.ResumeLayout(false);
            this.groups.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUseri)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPregledClanova;
        private System.Windows.Forms.GroupBox groups;
        private System.Windows.Forms.TextBox txtPw;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.DataGridView dgvUseri;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRecenzije;
        private System.Windows.Forms.Button btnProvjera;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button prijava_button;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button obavijesti_button;
        private System.Windows.Forms.Button btnLiveChat;
    }
}

