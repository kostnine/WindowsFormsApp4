﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class MyCars : Form
    {
        public MyCars()
        {
            InitializeComponent();
        }

        private void MyCars_Load(object sender, EventArgs e)
        {
            // Assuming Authorization.User contains the currently logged-in user
            string currentUser = Authorization.User;

            // Use the DataAccess class to get data
            dataGridView1.DataSource = Mano.GetAutoByUser(currentUser);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }
    }
}
