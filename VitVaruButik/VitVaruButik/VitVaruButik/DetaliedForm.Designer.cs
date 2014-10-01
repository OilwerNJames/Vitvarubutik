namespace VitVaruButik
{
    partial class DetaliedForm
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
            this.labelProduktNamn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.produktBeskrivning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelProduktNamn
            // 
            this.labelProduktNamn.AutoSize = true;
            this.labelProduktNamn.Location = new System.Drawing.Point(82, 42);
            this.labelProduktNamn.Name = "labelProduktNamn";
            this.labelProduktNamn.Size = new System.Drawing.Size(35, 13);
            this.labelProduktNamn.TabIndex = 0;
            this.labelProduktNamn.Text = "Namn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Namn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Beskrivning:";
            // 
            // produktBeskrivning
            // 
            this.produktBeskrivning.AutoSize = true;
            this.produktBeskrivning.Location = new System.Drawing.Point(41, 121);
            this.produktBeskrivning.Name = "produktBeskrivning";
            this.produktBeskrivning.Size = new System.Drawing.Size(62, 13);
            this.produktBeskrivning.TabIndex = 3;
            this.produktBeskrivning.Text = "Beskrivning";
            // 
            // DetaliedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 381);
            this.Controls.Add(this.produktBeskrivning);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelProduktNamn);
            this.Name = "DetaliedForm";
            this.Text = "DetaliedForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelProduktNamn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label produktBeskrivning;
    }
}