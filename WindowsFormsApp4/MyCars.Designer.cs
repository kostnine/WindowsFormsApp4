namespace WindowsFormsApp4
{
    partial class MyCars
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id_account = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marke = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kebulas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Degalu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Variklis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jusu automobiliai";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_account,
            this.Login,
            this.Password,
            this.Marke,
            this.Modelis,
            this.Kebulas,
            this.Degalu,
            this.Variklis,
            this.VIN});
            this.dataGridView1.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.Location = new System.Drawing.Point(12, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(843, 238);
            this.dataGridView1.TabIndex = 1;
            // 
            // id_account
            // 
            this.id_account.DataPropertyName = "id_account";
            this.id_account.HeaderText = "Column1";
            this.id_account.Name = "id_account";
            this.id_account.Visible = false;
            // 
            // Login
            // 
            this.Login.DataPropertyName = "Login";
            this.Login.HeaderText = "Vardas";
            this.Login.Name = "Login";
            // 
            // Password
            // 
            this.Password.DataPropertyName = "Password";
            this.Password.HeaderText = "Pavarde";
            this.Password.Name = "Password";
            // 
            // Marke
            // 
            this.Marke.DataPropertyName = "Marke";
            this.Marke.HeaderText = "Marke";
            this.Marke.Name = "Marke";
            // 
            // Modelis
            // 
            this.Modelis.DataPropertyName = "Modelis";
            this.Modelis.HeaderText = "Modelis";
            this.Modelis.Name = "Modelis";
            // 
            // Kebulas
            // 
            this.Kebulas.DataPropertyName = "Kebulas";
            this.Kebulas.HeaderText = "Kebulas";
            this.Kebulas.Name = "Kebulas";
            // 
            // Degalu
            // 
            this.Degalu.DataPropertyName = "Degalu";
            this.Degalu.HeaderText = "Degalai";
            this.Degalu.Name = "Degalu";
            // 
            // Variklis
            // 
            this.Variklis.DataPropertyName = "Variklis";
            this.Variklis.HeaderText = "Variklio Galia";
            this.Variklis.Name = "Variklis";
            // 
            // VIN
            // 
            this.VIN.DataPropertyName = "VIN";
            this.VIN.HeaderText = "VIN";
            this.VIN.Name = "VIN";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(763, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Grizti";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MyCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "MyCars";
            this.Text = "MyCars";
            this.Load += new System.EventHandler(this.MyCars_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_account;
        private System.Windows.Forms.DataGridViewTextBoxColumn Login;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marke;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kebulas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Degalu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Variklis;
        private System.Windows.Forms.DataGridViewTextBoxColumn VIN;
        private System.Windows.Forms.Button button1;
    }
}