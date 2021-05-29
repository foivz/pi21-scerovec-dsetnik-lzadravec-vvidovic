
namespace bitBooks_Project
{
    partial class PregledRecenzijaForm
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
            this.dgvRecenzije = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.btnRecenzijeKnjiznice = new System.Windows.Forms.Button();
            this.btnRecenzijeZaposlenika = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUnosRecenzijeZaKnjiznicu = new System.Windows.Forms.Button();
            this.btnUnosRecenzijeZaZaposlenika = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecenzije)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRecenzije
            // 
            this.dgvRecenzije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecenzije.Location = new System.Drawing.Point(12, 68);
            this.dgvRecenzije.Name = "dgvRecenzije";
            this.dgvRecenzije.Size = new System.Drawing.Size(747, 289);
            this.dgvRecenzije.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Recenzije";
            // 
            // btnZatvori
            // 
            this.btnZatvori.Location = new System.Drawing.Point(687, 433);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(75, 23);
            this.btnZatvori.TabIndex = 2;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // btnRecenzijeKnjiznice
            // 
            this.btnRecenzijeKnjiznice.Location = new System.Drawing.Point(86, 23);
            this.btnRecenzijeKnjiznice.Name = "btnRecenzijeKnjiznice";
            this.btnRecenzijeKnjiznice.Size = new System.Drawing.Size(130, 36);
            this.btnRecenzijeKnjiznice.TabIndex = 4;
            this.btnRecenzijeKnjiznice.Text = "Prikaži recenzije knjižnice";
            this.btnRecenzijeKnjiznice.UseVisualStyleBackColor = true;
            this.btnRecenzijeKnjiznice.Click += new System.EventHandler(this.btnRecenzijeKnjiznice_Click);
            // 
            // btnRecenzijeZaposlenika
            // 
            this.btnRecenzijeZaposlenika.Location = new System.Drawing.Point(231, 23);
            this.btnRecenzijeZaposlenika.Name = "btnRecenzijeZaposlenika";
            this.btnRecenzijeZaposlenika.Size = new System.Drawing.Size(130, 36);
            this.btnRecenzijeZaposlenika.TabIndex = 5;
            this.btnRecenzijeZaposlenika.Text = "Prikaži recenzije zaposlenika knjižnice";
            this.btnRecenzijeZaposlenika.UseVisualStyleBackColor = true;
            this.btnRecenzijeZaposlenika.Click += new System.EventHandler(this.btnRecenzijeZaposlenika_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUnosRecenzijeZaZaposlenika);
            this.groupBox1.Controls.Add(this.btnUnosRecenzijeZaKnjiznicu);
            this.groupBox1.Location = new System.Drawing.Point(15, 364);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 92);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Moje recenzije";
            // 
            // btnUnosRecenzijeZaKnjiznicu
            // 
            this.btnUnosRecenzijeZaKnjiznicu.Location = new System.Drawing.Point(18, 19);
            this.btnUnosRecenzijeZaKnjiznicu.Name = "btnUnosRecenzijeZaKnjiznicu";
            this.btnUnosRecenzijeZaKnjiznicu.Size = new System.Drawing.Size(130, 67);
            this.btnUnosRecenzijeZaKnjiznicu.TabIndex = 7;
            this.btnUnosRecenzijeZaKnjiznicu.Text = "Unesi recenziju za knjižnicu";
            this.btnUnosRecenzijeZaKnjiznicu.UseVisualStyleBackColor = true;
            this.btnUnosRecenzijeZaKnjiznicu.Click += new System.EventHandler(this.btnUnosRecenzijeZaKnjiznicu_Click);
            // 
            // btnUnosRecenzijeZaZaposlenika
            // 
            this.btnUnosRecenzijeZaZaposlenika.Location = new System.Drawing.Point(154, 19);
            this.btnUnosRecenzijeZaZaposlenika.Name = "btnUnosRecenzijeZaZaposlenika";
            this.btnUnosRecenzijeZaZaposlenika.Size = new System.Drawing.Size(130, 67);
            this.btnUnosRecenzijeZaZaposlenika.TabIndex = 8;
            this.btnUnosRecenzijeZaZaposlenika.Text = "Unesi recenziju za zaposlenika";
            this.btnUnosRecenzijeZaZaposlenika.UseVisualStyleBackColor = true;
            // 
            // PregledRecenzijaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 468);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRecenzijeZaposlenika);
            this.Controls.Add(this.btnRecenzijeKnjiznice);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvRecenzije);
            this.Name = "PregledRecenzijaForm";
            this.Text = "PregledRecenzijaForm";
            this.Load += new System.EventHandler(this.PregledRecenzijaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecenzije)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRecenzije;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.Button btnRecenzijeKnjiznice;
        private System.Windows.Forms.Button btnRecenzijeZaposlenika;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUnosRecenzijeZaZaposlenika;
        private System.Windows.Forms.Button btnUnosRecenzijeZaKnjiznicu;
    }
}