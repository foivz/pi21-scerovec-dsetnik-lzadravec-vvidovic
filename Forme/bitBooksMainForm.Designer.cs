
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
            this.groups.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUseri)).BeginInit();
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
            this.groups.Controls.Add(this.btnRecenzije);
            this.groups.Controls.Add(this.label2);
            this.groups.Controls.Add(this.label1);
            this.groups.Controls.Add(this.dgvUseri);
            this.groups.Controls.Add(this.txtPw);
            this.groups.Controls.Add(this.txtUser);
            this.groups.Controls.Add(this.btnPregledClanova);
            this.groups.Location = new System.Drawing.Point(443, 12);
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
            this.btnRecenzije.Location = new System.Drawing.Point(246, 38);
            this.btnRecenzije.Name = "btnRecenzije";
            this.btnRecenzije.Size = new System.Drawing.Size(76, 57);
            this.btnRecenzije.TabIndex = 6;
            this.btnRecenzije.Text = "Pregled Recenzija";
            this.btnRecenzije.UseVisualStyleBackColor = true;
            this.btnRecenzije.Click += new System.EventHandler(this.btnRecenzije_Click);
            // 
            // btnProvjera
            // 
            this.btnProvjera.Location = new System.Drawing.Point(232, 145);
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
            this.txtStatus.Location = new System.Drawing.Point(232, 319);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(100, 20);
            this.txtStatus.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(232, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "User status:";
            // 
            // bitBooksMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.btnProvjera);
            this.Controls.Add(this.groups);
            this.Name = "bitBooksMainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.bitBooksMainForm_Load);
            this.groups.ResumeLayout(false);
            this.groups.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUseri)).EndInit();
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
    }
}

