namespace VitVaruButik
{
    partial class Mainform
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
            this.button1 = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNamn = new System.Windows.Forms.TextBox();
            this.cmbCatagories = new System.Windows.Forms.ComboBox();
            this.Catagory = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbVaruGrupp = new System.Windows.Forms.ComboBox();
            this.lblVaru = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(378, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView
            // 
            this.listView.Location = new System.Drawing.Point(12, 137);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(441, 154);
            this.listView.TabIndex = 1;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.List;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Namn";
            // 
            // txtNamn
            // 
            this.txtNamn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamn.Location = new System.Drawing.Point(12, 98);
            this.txtNamn.Name = "txtNamn";
            this.txtNamn.Size = new System.Drawing.Size(100, 20);
            this.txtNamn.TabIndex = 3;
            // 
            // cmbCatagories
            // 
            this.cmbCatagories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCatagories.FormattingEnabled = true;
            this.cmbCatagories.Location = new System.Drawing.Point(245, 97);
            this.cmbCatagories.Name = "cmbCatagories";
            this.cmbCatagories.Size = new System.Drawing.Size(121, 21);
            this.cmbCatagories.TabIndex = 4;
            // 
            // Catagory
            // 
            this.Catagory.AutoSize = true;
            this.Catagory.Location = new System.Drawing.Point(242, 81);
            this.Catagory.Name = "Catagory";
            this.Catagory.Size = new System.Drawing.Size(65, 13);
            this.Catagory.TabIndex = 5;
            this.Catagory.Text = "Energi Klass";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Produkt Namn";
            // 
            // cmbVaruGrupp
            // 
            this.cmbVaruGrupp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVaruGrupp.FormattingEnabled = true;
            this.cmbVaruGrupp.Location = new System.Drawing.Point(118, 97);
            this.cmbVaruGrupp.Name = "cmbVaruGrupp";
            this.cmbVaruGrupp.Size = new System.Drawing.Size(121, 21);
            this.cmbVaruGrupp.TabIndex = 7;
            // 
            // lblVaru
            // 
            this.lblVaru.AutoSize = true;
            this.lblVaru.Location = new System.Drawing.Point(115, 82);
            this.lblVaru.Name = "lblVaru";
            this.lblVaru.Size = new System.Drawing.Size(58, 13);
            this.lblVaru.TabIndex = 8;
            this.lblVaru.Text = "VaruGrupp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(245, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Varugrupp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Energi Klass";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(375, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Pris";
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 303);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblVaru);
            this.Controls.Add(this.cmbVaruGrupp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Catagory);
            this.Controls.Add(this.cmbCatagories);
            this.Controls.Add(this.txtNamn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.button1);
            this.Name = "Mainform";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNamn;
        private System.Windows.Forms.ComboBox cmbCatagories;
        private System.Windows.Forms.Label Catagory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbVaruGrupp;
        private System.Windows.Forms.Label lblVaru;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

