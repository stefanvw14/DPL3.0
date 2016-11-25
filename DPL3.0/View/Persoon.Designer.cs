namespace DPL3._0
{
    partial class Persoon
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
            this.lblNaam = new System.Windows.Forms.Label();
            this.lblAdres = new System.Windows.Forms.Label();
            this.lblWpl = new System.Windows.Forms.Label();
            this.txtNaam = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtWpl = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnAnnuleren = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Location = new System.Drawing.Point(12, 47);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(35, 13);
            this.lblNaam.TabIndex = 0;
            this.lblNaam.Text = "Naam";
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Location = new System.Drawing.Point(15, 83);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(34, 13);
            this.lblAdres.TabIndex = 1;
            this.lblAdres.Text = "Adres";
            // 
            // lblWpl
            // 
            this.lblWpl.AutoSize = true;
            this.lblWpl.Location = new System.Drawing.Point(18, 123);
            this.lblWpl.Name = "lblWpl";
            this.lblWpl.Size = new System.Drawing.Size(64, 13);
            this.lblWpl.TabIndex = 2;
            this.lblWpl.Text = "Woonplaats";
            // 
            // txtNaam
            // 
            this.txtNaam.Location = new System.Drawing.Point(145, 39);
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(100, 20);
            this.txtNaam.TabIndex = 3;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(145, 75);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(100, 20);
            this.txtAdres.TabIndex = 4;
            // 
            // txtWpl
            // 
            this.txtWpl.Location = new System.Drawing.Point(145, 115);
            this.txtWpl.Name = "txtWpl";
            this.txtWpl.Size = new System.Drawing.Size(100, 20);
            this.txtWpl.TabIndex = 5;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(97, 182);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnAnnuleren
            // 
            this.btnAnnuleren.Location = new System.Drawing.Point(179, 182);
            this.btnAnnuleren.Name = "btnAnnuleren";
            this.btnAnnuleren.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuleren.TabIndex = 7;
            this.btnAnnuleren.Text = "Annuleren";
            this.btnAnnuleren.UseVisualStyleBackColor = true;
            // 
            // Persoon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnAnnuleren);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtWpl);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtNaam);
            this.Controls.Add(this.lblWpl);
            this.Controls.Add(this.lblAdres);
            this.Controls.Add(this.lblNaam);
            this.Name = "Persoon";
            this.Text = "Persoon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaam;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label lblWpl;
        private System.Windows.Forms.TextBox txtNaam;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtWpl;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnAnnuleren;
    }
}