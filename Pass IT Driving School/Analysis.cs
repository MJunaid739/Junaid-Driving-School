using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pass_IT_Driving_School
{
    public partial class Analysis : Form
    {
        public Analysis()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Analysis_Load(object sender, EventArgs e)
        {
          
         
            listView3.Columns.Add("ID", 80);
            listView3.Columns.Add("First Name", 80);
            listView3.Columns.Add("Last Name", 80);
            listView3.Columns.Add("Email", 80);
        

            ListViewItem newitem3 = new ListViewItem("1");

            newitem3.SubItems.Add("Sajjad");

            newitem3.SubItems.Add("Khan");
            newitem3.SubItems.Add("sajjad@gmail.com");
            listView3.Items.Add(newitem3);
        }
    }
}
