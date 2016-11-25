namespace DPL3._0
{
    partial class Adresboek
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnZoek = new System.Windows.Forms.Button();
            this.btnNieuw = new System.Windows.Forms.Button();
            this.btnWijzig = new System.Windows.Forms.Button();
            this.btnVerwijder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(167, 237);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btnZoek
            // 
            this.btnZoek.Location = new System.Drawing.Point(200, 31);
            this.btnZoek.Name = "btnZoek";
            this.btnZoek.Size = new System.Drawing.Size(151, 34);
            this.btnZoek.TabIndex = 1;
            this.btnZoek.Text = "Zoeken";
            this.btnZoek.UseVisualStyleBackColor = true;
            this.btnZoek.Click += new System.EventHandler(this.btnZoek_Click);
            // 
            // btnNieuw
            // 
            this.btnNieuw.Location = new System.Drawing.Point(200, 88);
            this.btnNieuw.Name = "btnNieuw";
            this.btnNieuw.Size = new System.Drawing.Size(151, 34);
            this.btnNieuw.TabIndex = 2;
            this.btnNieuw.Text = "Nieuw";
            this.btnNieuw.UseVisualStyleBackColor = true;
            // 
            // btnWijzig
            // 
            this.btnWijzig.Location = new System.Drawing.Point(200, 143);
            this.btnWijzig.Name = "btnWijzig";
            this.btnWijzig.Size = new System.Drawing.Size(151, 40);
            this.btnWijzig.TabIndex = 3;
            this.btnWijzig.Text = "Wijzig";
            this.btnWijzig.UseVisualStyleBackColor = true;
            // 
            // btnVerwijder
            // 
            this.btnVerwijder.Location = new System.Drawing.Point(200, 204);
            this.btnVerwijder.Name = "btnVerwijder";
            this.btnVerwijder.Size = new System.Drawing.Size(151, 35);
            this.btnVerwijder.TabIndex = 4;
            this.btnVerwijder.Text = "Verwijder";
            this.btnVerwijder.UseVisualStyleBackColor = true;
            // 
            // Adresboek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 261);
            this.Controls.Add(this.btnVerwijder);
            this.Controls.Add(this.btnWijzig);
            this.Controls.Add(this.btnNieuw);
            this.Controls.Add(this.btnZoek);
            this.Controls.Add(this.listView1);
            this.Name = "Adresboek";
            this.Text = "Adresboek";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnZoek;
        private System.Windows.Forms.Button btnNieuw;
        private System.Windows.Forms.Button btnWijzig;
        private System.Windows.Forms.Button btnVerwijder;
    }
}