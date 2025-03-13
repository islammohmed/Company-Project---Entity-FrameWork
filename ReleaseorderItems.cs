using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Company_Project.Context;
using Company_Project.Entities;
using Microsoft.EntityFrameworkCore;

namespace Company_Project
{
    public partial class ReleaseorderItems : Form
    {
        public Item SelectedItem { get; private set; }
        public ReleaseorderItems()
        {
            InitializeComponent();
            LoadItems();
        }

        private void LoadItems()
        {
            using (var context = new AppDbContext())
            {
                var items = context.Items.ToList();
                ReleaseItemsDVg.DataSource = items;
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (ReleaseItemsDVg.SelectedRows.Count > 0)
            {
                SelectedItem = (Item)ReleaseItemsDVg.SelectedRows[0].DataBoundItem;
                DialogResult = DialogResult.OK; // Close form and return OK result
                Close();
            }
            else
            {
                MessageBox.Show("Please select an item.");
            }
        }


    }
}
