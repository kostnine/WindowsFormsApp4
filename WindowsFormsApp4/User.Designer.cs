namespace WindowsFormsApp4
{
    partial class User
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
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id_auto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marke = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kebulas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Komplektacija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Degalai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Variklio_Galia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kaina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button5 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1219, 68);
            this.panel1.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(1153, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(40, 40);
            this.button3.TabIndex = 3;
            this.button3.Text = "x";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Mano masinos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Najausios BMW masinos";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Filtrai:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 37);
            this.label5.TabIndex = 5;
            this.label5.Text = "Degalu rusys:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 37);
            this.label6.TabIndex = 6;
            this.label6.Text = "Kebulas:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(34, 243);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(34, 339);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 8;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(34, 393);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(121, 53);
            this.button4.TabIndex = 4;
            this.button4.Text = "Surasti svajoniu automobili";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_auto,
            this.Marke,
            this.Kebulas,
            this.Modelis,
            this.Komplektacija,
            this.Degalai,
            this.Variklio_Galia,
            this.Kaina});
            this.dataGridView1.Location = new System.Drawing.Point(389, 154);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(744, 342);
            this.dataGridView1.TabIndex = 9;
            // 
            // id_auto
            // 
            this.id_auto.DataPropertyName = "id_auto";
            this.id_auto.HeaderText = "Column1";
            this.id_auto.Name = "id_auto";
            this.id_auto.Visible = false;
            // 
            // Marke
            // 
            this.Marke.DataPropertyName = "Marke";
            this.Marke.HeaderText = "Marke";
            this.Marke.Name = "Marke";
            // 
            // Kebulas
            // 
            this.Kebulas.DataPropertyName = "Kebulas";
            this.Kebulas.HeaderText = "Kebulas";
            this.Kebulas.Name = "Kebulas";
            // 
            // Modelis
            // 
            this.Modelis.DataPropertyName = "Modelis";
            this.Modelis.HeaderText = "Modelis";
            this.Modelis.Name = "Modelis";
            // 
            // Komplektacija
            // 
            this.Komplektacija.DataPropertyName = "Komplektacija";
            this.Komplektacija.HeaderText = "Komplektacija";
            this.Komplektacija.Name = "Komplektacija";
            // 
            // Degalai
            // 
            this.Degalai.DataPropertyName = "Degalai";
            this.Degalai.HeaderText = "Degalai";
            this.Degalai.Name = "Degalai";
            // 
            // Variklio_Galia
            // 
            this.Variklio_Galia.DataPropertyName = "Variklio_Galia";
            this.Variklio_Galia.HeaderText = "Variklio Galia";
            this.Variklio_Galia.Name = "Variklio_Galia";
            // 
            // Kaina
            // 
            this.Kaina.DataPropertyName = "Kaina";
            this.Kaina.HeaderText = "Kaina";
            this.Kaina.Name = "Kaina";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(389, 508);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(121, 53);
            this.button5.TabIndex = 10;
            this.button5.Text = "Apmoketi!";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(382, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(388, 37);
            this.label3.TabIndex = 11;
            this.label3.Text = "Issirinkite norima automobili";
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 693);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "User";
            this.Text = "User";
            this.Load += new System.EventHandler(this.User_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_auto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marke;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kebulas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Komplektacija;
        private System.Windows.Forms.DataGridViewTextBoxColumn Degalai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Variklio_Galia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kaina;
    }
}