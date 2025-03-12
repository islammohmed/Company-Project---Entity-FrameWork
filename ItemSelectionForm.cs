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

namespace Company_Project
{

    public partial class ItemSelectionForm : Form
    {
        public Item SelectedItem { get; private set; }
        public ItemSelectionForm()
        {
            InitializeComponent();
            LoadItems();
        }
        private void LoadItems()
        {
            using (var context = new AppDbContext())
            {
                var items = context.Items.ToList();
                dgvSupplyOrderItems.DataSource = items;
            }
        }


        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (dgvSupplyOrderItems.SelectedRows.Count > 0)
            {
                SelectedItem = (Item)dgvSupplyOrderItems.SelectedRows[0].DataBoundItem;
                DialogResult = DialogResult.OK; 
                Close();
            }
            else
            {
                MessageBox.Show("Please select an item.");
            }
        }
    }
}
