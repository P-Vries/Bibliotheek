namespace Bibliotheek
{
    partial class frmBibliotheekInvoer
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBereken = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txbIn = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(93, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Uitleen datum:";
            // 
            // btnBereken
            // 
            this.btnBereken.Location = new System.Drawing.Point(15, 31);
            this.btnBereken.Name = "btnBereken";
            this.btnBereken.Size = new System.Drawing.Size(278, 28);
            this.btnBereken.TabIndex = 4;
            this.btnBereken.Text = "Bereken";
            this.btnBereken.UseVisualStyleBackColor = true;
            this.btnBereken.Click += new System.EventHandler(this.btnBereken_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Boeknummer: ";
            // 
            // txbIn
            // 
            this.txbIn.Location = new System.Drawing.Point(93, 65);
            this.txbIn.Name = "txbIn";
            this.txbIn.Size = new System.Drawing.Size(200, 20);
            this.txbIn.TabIndex = 6;
            // 
            // frmBibliotheekInvoer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 97);
            this.Controls.Add(this.txbIn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBereken);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "frmBibliotheekInvoer";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBereken;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbIn;
    }
}

