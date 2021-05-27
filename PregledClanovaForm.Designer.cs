
namespace bitBooks_Project
{
    partial class PregledClanovaForm
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
            this.dgvKorisnici = new System.Windows.Forms.DataGridView();
            this.btnPrikaziSve = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnici)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKorisnici
            // 
            this.dgvKorisnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKorisnici.Location = new System.Drawing.Point(12, 121);
            this.dgvKorisnici.Name = "dgvKorisnici";
            this.dgvKorisnici.Size = new System.Drawing.Size(631, 361);
            this.dgvKorisnici.TabIndex = 0;
            // 
            // btnPrikaziSve
            // 
            this.btnPrikaziSve.Location = new System.Drawing.Point(417, 15);
            this.btnPrikaziSve.Name = "btnPrikaziSve";
            this.btnPrikaziSve.Size = new System.Drawing.Size(75, 78);
            this.btnPrikaziSve.TabIndex = 1;
            this.btnPrikaziSve.Text = "Prikaži sve";
            this.btnPrikaziSve.UseVisualStyleBackColor = true;
            this.btnPrikaziSve.Click += new System.EventHandler(this.btnPrikaziSve_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(317, 15);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 78);
            this.btnFilter.TabIndex = 2;
            this.btnFilter.Text = "Filtriraj";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(139, 15);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(162, 20);
            this.txtIme.TabIndex = 3;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(139, 41);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(162, 20);
            this.txtPrezime.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ime člana:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Prezime člana:";
            // 
            // PregledClanovaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 494);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.btnPrikaziSve);
            this.Controls.Add(this.dgvKorisnici);
            this.Name = "PregledClanovaForm";
            this.Text = "Pregled članova";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKorisnici;
        private System.Windows.Forms.Button btnPrikaziSve;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}