namespace userInputTest
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.CreateNewCharacter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStrength = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.OpenPDF = new System.Windows.Forms.Button();
            this.CreatePDF = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(112, 118);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(703, 522);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 25);
            this.button1.TabIndex = 2;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Charisma";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(703, 492);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 24);
            this.button2.TabIndex = 4;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CreateNewCharacter
            // 
            this.CreateNewCharacter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateNewCharacter.Location = new System.Drawing.Point(703, 448);
            this.CreateNewCharacter.Name = "CreateNewCharacter";
            this.CreateNewCharacter.Size = new System.Drawing.Size(93, 38);
            this.CreateNewCharacter.TabIndex = 5;
            this.CreateNewCharacter.Text = "Create new character";
            this.CreateNewCharacter.UseVisualStyleBackColor = true;
            this.CreateNewCharacter.Click += new System.EventHandler(this.CreateNewCharacter_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Strength";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtStrength
            // 
            this.txtStrength.Location = new System.Drawing.Point(112, 153);
            this.txtStrength.Name = "txtStrength";
            this.txtStrength.Size = new System.Drawing.Size(100, 20);
            this.txtStrength.TabIndex = 6;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(15, 179);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(781, 263);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // OpenPDF
            // 
            this.OpenPDF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenPDF.Location = new System.Drawing.Point(560, 509);
            this.OpenPDF.Name = "OpenPDF";
            this.OpenPDF.Size = new System.Drawing.Size(137, 38);
            this.OpenPDF.TabIndex = 9;
            this.OpenPDF.Text = "Open PDF";
            this.OpenPDF.UseVisualStyleBackColor = true;
            this.OpenPDF.Click += new System.EventHandler(this.button3_Click);
            // 
            // CreatePDF
            // 
            this.CreatePDF.Location = new System.Drawing.Point(15, 509);
            this.CreatePDF.Name = "CreatePDF";
            this.CreatePDF.Size = new System.Drawing.Size(159, 38);
            this.CreatePDF.TabIndex = 10;
            this.CreatePDF.Text = "Create PDF";
            this.CreatePDF.UseVisualStyleBackColor = true;
            this.CreatePDF.Click += new System.EventHandler(this.CreatePDF_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 559);
            this.Controls.Add(this.CreatePDF);
            this.Controls.Add(this.OpenPDF);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtStrength);
            this.Controls.Add(this.CreateNewCharacter);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Character Builder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button CreateNewCharacter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStrength;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button OpenPDF;
        private System.Windows.Forms.Button CreatePDF;
    }
}

