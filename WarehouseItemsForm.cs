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
    public partial class WarehouseItemsForm : Form
    {
        private int _warehouseId;
        private BindingSource itemBindingSource = new BindingSource();
        public WarehouseItemsForm(int warehouseId)
        {
            InitializeComponent();
            _warehouseId = warehouseId;
            LoadWarehouseItems();
        }
        private void LoadWarehouseItems()
        {
            using (var context = new AppDbContext())
            {
                var items = context.Items.Where(i => i.Id == _warehouseId).ToList();
                itemBindingSource.DataSource = items;
                dataGridView1.DataSource = itemBindingSource;
                dataGridView1.AllowUserToAddRows = true;
                dataGridView1.AllowUserToDeleteRows = true;
                dataGridView1.ReadOnly = false; 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                foreach (var item in (List<Item>)itemBindingSource.DataSource)
                {
                    context.Entry(item).State = item.Id == 0 ? EntityState.Added : EntityState.Modified;
                }
                context.SaveChanges();
                MessageBox.Show("Changes saved successfully.");
            }
        }
    }
}
