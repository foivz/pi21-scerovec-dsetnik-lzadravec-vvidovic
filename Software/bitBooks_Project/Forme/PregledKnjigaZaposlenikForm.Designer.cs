namespace bitBooks_Project.Forme
{
    partial class PregledKnjigaZaposlenikForm
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
            this.dgvKnjige = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKnjige)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKnjige
            // 
            this.dgvKnjige.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKnjige.Location = new System.Drawing.Point(34, 23);
            this.dgvKnjige.Name = "dgvKnjige";
            this.dgvKnjige.Size = new System.Drawing.Size(428, 334);
            this.dgvKnjige.TabIndex = 0;
            // 
            // PregledKnjigaZaposlenikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(500, 390);
            this.Controls.Add(this.dgvKnjige);
            this.Name = "PregledKnjigaZaposlenikForm";
            this.Text = "PregledKnjigaZaposlenikForm";
            this.Load += new System.EventHandler(this.PregledKnjigaZaposlenikForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKnjige)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKnjige;
    }
}