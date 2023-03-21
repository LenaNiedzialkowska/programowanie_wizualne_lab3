namespace projektowanie_wizualne_lab3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Wydawnictwo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tytul = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gatunek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelAdd = new System.Windows.Forms.Label();
            this.labelRemove = new System.Windows.Forms.Label();
            this.labelSave = new System.Windows.Forms.Label();
            this.labelLoad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Wydawnictwo,
            this.Data,
            this.Tytul,
            this.Gatunek,
            this.Autor});
            this.dataGridView1.Location = new System.Drawing.Point(21, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(677, 269);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Wydawnictwo
            // 
            this.Wydawnictwo.HeaderText = "Wydawnictwo";
            this.Wydawnictwo.MinimumWidth = 6;
            this.Wydawnictwo.Name = "Wydawnictwo";
            this.Wydawnictwo.Width = 125;
            // 
            // Data
            // 
            this.Data.HeaderText = "Data wydania";
            this.Data.MinimumWidth = 6;
            this.Data.Name = "Data";
            this.Data.Width = 125;
            // 
            // Tytul
            // 
            this.Tytul.HeaderText = "Tytuł";
            this.Tytul.MinimumWidth = 6;
            this.Tytul.Name = "Tytul";
            this.Tytul.Width = 125;
            // 
            // Gatunek
            // 
            this.Gatunek.HeaderText = "Gatunek";
            this.Gatunek.MinimumWidth = 6;
            this.Gatunek.Name = "Gatunek";
            this.Gatunek.Width = 125;
            // 
            // Autor
            // 
            this.Autor.HeaderText = "Autor";
            this.Autor.MinimumWidth = 6;
            this.Autor.Name = "Autor";
            this.Autor.Width = 125;
            // 
            // labelAdd
            // 
            this.labelAdd.AutoSize = true;
            this.labelAdd.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAdd.Location = new System.Drawing.Point(249, 358);
            this.labelAdd.Name = "labelAdd";
            this.labelAdd.Size = new System.Drawing.Size(90, 46);
            this.labelAdd.TabIndex = 1;
            this.labelAdd.Text = "ADD";
            this.labelAdd.Click += new System.EventHandler(this.labelAdd_Click);
            // 
            // labelRemove
            // 
            this.labelRemove.AutoSize = true;
            this.labelRemove.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRemove.Location = new System.Drawing.Point(416, 358);
            this.labelRemove.Name = "labelRemove";
            this.labelRemove.Size = new System.Drawing.Size(151, 46);
            this.labelRemove.TabIndex = 2;
            this.labelRemove.Text = "REMOVE";
            this.labelRemove.Click += new System.EventHandler(this.labelRemove_Click);
            // 
            // labelSave
            // 
            this.labelSave.AutoSize = true;
            this.labelSave.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSave.Location = new System.Drawing.Point(640, 319);
            this.labelSave.Name = "labelSave";
            this.labelSave.Size = new System.Drawing.Size(96, 46);
            this.labelSave.TabIndex = 3;
            this.labelSave.Text = "SAVE";
            this.labelSave.Click += new System.EventHandler(this.labelSave_Click);
            // 
            // labelLoad
            // 
            this.labelLoad.AutoSize = true;
            this.labelLoad.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLoad.Location = new System.Drawing.Point(640, 392);
            this.labelLoad.Name = "labelLoad";
            this.labelLoad.Size = new System.Drawing.Size(106, 46);
            this.labelLoad.TabIndex = 4;
            this.labelLoad.Text = "LOAD";
            this.labelLoad.Click += new System.EventHandler(this.labelLoad_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelLoad);
            this.Controls.Add(this.labelSave);
            this.Controls.Add(this.labelRemove);
            this.Controls.Add(this.labelAdd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Label labelAdd;
        private Label labelRemove;
        private Label labelSave;
        private Label labelLoad;
        private DataGridViewTextBoxColumn Wydawnictwo;
        private DataGridViewTextBoxColumn Data;
        private DataGridViewTextBoxColumn Tytul;
        private DataGridViewTextBoxColumn Gatunek;
        private DataGridViewTextBoxColumn Autor;
    }
}