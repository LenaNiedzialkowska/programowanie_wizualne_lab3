namespace projektowanie_wizualne_lab3
{
    partial class Form2
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.labelWydawnictwo = new System.Windows.Forms.Label();
            this.labelGatunek = new System.Windows.Forms.Label();
            this.labelAutor = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.labelTytul = new System.Windows.Forms.Label();
            this.labelAccept = new System.Windows.Forms.Label();
            this.labelReturn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(268, 103);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(268, 163);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 27);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(268, 216);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(125, 27);
            this.textBox3.TabIndex = 2;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(268, 269);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(125, 27);
            this.textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(268, 328);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(125, 27);
            this.textBox5.TabIndex = 4;
            // 
            // labelWydawnictwo
            // 
            this.labelWydawnictwo.AutoSize = true;
            this.labelWydawnictwo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelWydawnictwo.Location = new System.Drawing.Point(76, 95);
            this.labelWydawnictwo.Name = "labelWydawnictwo";
            this.labelWydawnictwo.Size = new System.Drawing.Size(169, 35);
            this.labelWydawnictwo.TabIndex = 5;
            this.labelWydawnictwo.Text = "Wydawnictwo";
            this.labelWydawnictwo.Click += new System.EventHandler(this.labelNazwa_Click);
            // 
            // labelGatunek
            // 
            this.labelGatunek.AutoSize = true;
            this.labelGatunek.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelGatunek.Location = new System.Drawing.Point(139, 155);
            this.labelGatunek.Name = "labelGatunek";
            this.labelGatunek.Size = new System.Drawing.Size(106, 35);
            this.labelGatunek.TabIndex = 6;
            this.labelGatunek.Text = "Gatunek";
            this.labelGatunek.Click += new System.EventHandler(this.labelGatunek_Click);
            // 
            // labelAutor
            // 
            this.labelAutor.AutoSize = true;
            this.labelAutor.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAutor.Location = new System.Drawing.Point(156, 208);
            this.labelAutor.Name = "labelAutor";
            this.labelAutor.Size = new System.Drawing.Size(77, 35);
            this.labelAutor.TabIndex = 7;
            this.labelAutor.Text = "Autor";
            this.labelAutor.Click += new System.EventHandler(this.labelAutor_Click);
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelData.Location = new System.Drawing.Point(97, 269);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(165, 35);
            this.labelData.TabIndex = 8;
            this.labelData.Text = "Data wydania";
            this.labelData.Click += new System.EventHandler(this.labelData_Click);
            // 
            // labelTytul
            // 
            this.labelTytul.AutoSize = true;
            this.labelTytul.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTytul.Location = new System.Drawing.Point(165, 328);
            this.labelTytul.Name = "labelTytul";
            this.labelTytul.Size = new System.Drawing.Size(68, 35);
            this.labelTytul.TabIndex = 9;
            this.labelTytul.Text = "Tytuł";
            this.labelTytul.Click += new System.EventHandler(this.labelTytul_Click);
            // 
            // labelAccept
            // 
            this.labelAccept.AutoSize = true;
            this.labelAccept.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAccept.Location = new System.Drawing.Point(546, 289);
            this.labelAccept.Name = "labelAccept";
            this.labelAccept.Size = new System.Drawing.Size(100, 35);
            this.labelAccept.TabIndex = 10;
            this.labelAccept.Text = "ACCEPT";
            this.labelAccept.Click += new System.EventHandler(this.labelAccept_Click);
            // 
            // labelReturn
            // 
            this.labelReturn.AutoSize = true;
            this.labelReturn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelReturn.Location = new System.Drawing.Point(539, 343);
            this.labelReturn.Name = "labelReturn";
            this.labelReturn.Size = new System.Drawing.Size(107, 35);
            this.labelReturn.TabIndex = 11;
            this.labelReturn.Text = "RETURN";
            this.labelReturn.Click += new System.EventHandler(this.labelReturn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelReturn);
            this.Controls.Add(this.labelAccept);
            this.Controls.Add(this.labelTytul);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.labelAutor);
            this.Controls.Add(this.labelGatunek);
            this.Controls.Add(this.labelWydawnictwo);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label labelWydawnictwo;
        private Label labelGatunek;
        private Label labelAutor;
        private Label labelData;
        private Label labelTytul;
        private Label labelAccept;
        private Label labelReturn;
    }
}