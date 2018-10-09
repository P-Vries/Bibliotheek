namespace Bibliotheek
{
    partial class Form1
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
            this.rdbRoman = new System.Windows.Forms.RadioButton();
            this.rdbStudieboeken = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBereken = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rdbRoman
            // 
            this.rdbRoman.AutoSize = true;
            this.rdbRoman.Checked = true;
            this.rdbRoman.Location = new System.Drawing.Point(12, 14);
            this.rdbRoman.Name = "rdbRoman";
            this.rdbRoman.Size = new System.Drawing.Size(59, 17);
            this.rdbRoman.TabIndex = 0;
            this.rdbRoman.TabStop = true;
            this.rdbRoman.Text = "Roman";
            this.rdbRoman.UseVisualStyleBackColor = true;
            // 
            // rdbStudieboeken
            // 
            this.rdbStudieboeken.AutoSize = true;
            this.rdbStudieboeken.Location = new System.Drawing.Point(12, 44);
            this.rdbStudieboeken.Name = "rdbStudieboeken";
            this.rdbStudieboeken.Size = new System.Drawing.Size(91, 17);
            this.rdbStudieboeken.TabIndex = 1;
            this.rdbStudieboeken.Text = "Studieboeken";
            this.rdbStudieboeken.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(158, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Uitleen datum:";
            // 
            // btnBereken
            // 
            this.btnBereken.Location = new System.Drawing.Point(134, 38);
            this.btnBereken.Name = "btnBereken";
            this.btnBereken.Size = new System.Drawing.Size(225, 28);
            this.btnBereken.TabIndex = 4;
            this.btnBereken.Text = "Bereken";
            this.btnBereken.UseVisualStyleBackColor = true;
            this.btnBereken.Click += new System.EventHandler(this.btnBereken_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 77);
            this.Controls.Add(this.btnBereken);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.rdbStudieboeken);
            this.Controls.Add(this.rdbRoman);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbRoman;
        private System.Windows.Forms.RadioButton rdbStudieboeken;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBereken;
    }
}

