using System.ComponentModel;
using Company_Project.Context;
using Company_Project.Entities;
using Microsoft.EntityFrameworkCore;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
// there some tasks not finished yet i work on it and i will update the repo 
namespace Company_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadWarehouses();
            LoadCustomers();
            LoadSuppliers();
            LoadSupplyOrders();
            LoadSuppliersForOrder();
            LoadWarehousesForOrders();
        }

        //warehouse
        private BindingSource itemBindingSource = new BindingSource();
        private void LoadItems(int warehouseId)
        {
            using (var context = new AppDbContext())
            {
                var items = context.Items.Where(i => i.Id == warehouseId).ToList();
                itemBindingSource.DataSource = items; // Bind data to BindingSource
                Items.DataSource = itemBindingSource;
            }
        }
        private void dataGridViewWarehouses_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewWarehouses.SelectedRows.Count > 0)
            {
                int warehouseId = Convert.ToInt32(dataGridViewWarehouses.SelectedRows[0].Cells["Id"].Value);

                LoadItems(warehouseId);
            }
        }
        //Crud
        private BindingSource warehouseBindingSource = new BindingSource();
        private void LoadWarehouses()
        {
            using (var context = new AppDbContext())
            {
                var warehouses = context.Warehouses.ToList();
                dataGridViewWarehouses.DataSource = warehouses;
                warehouseBindingSource.DataSource = warehouses;
                dataGridViewWarehouses.DataSource = warehouseBindingSource;
                dataGridViewWarehouses.AllowUserToAddRows = true;
                dataGridViewWarehouses.AllowUserToDeleteRows = true;
                Items.AllowUserToAddRows = true;
                Items.AllowUserToDeleteRows = true;
            }
        }
        private void Add_Click(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                var warehouse = new Warehouse
                {
                    Name = textBox1.Text,
                    Address = textBox2.Text,
                    Manager = textBox3.Text
                };
                context.Warehouses.Add(warehouse);
                context.SaveChanges();
            }
            LoadWarehouses();
        }
        private void Update_Click(object sender, EventArgs e)
        {
            int warehouseId = -1;

            if (!string.IsNullOrWhiteSpace(textBox4.Text))
            {
                if (!int.TryParse(textBox4.Text, out warehouseId))
                {
                    MessageBox.Show("Invalid ID entered.");
                    return;
                }
            }
            else if (dataGridViewWarehouses.SelectedRows.Count > 0)
            {
                warehouseId = Convert.ToInt32(dataGridViewWarehouses.SelectedRows[0].Cells["Id"].Value);
            }
            else
            {
                MessageBox.Show("Please enter an ID or select a row.");
                return;
            }

            using (var context = new AppDbContext())
            {
                var warehouse = context.Warehouses.Find(warehouseId);
                if (warehouse != null)
                {
                    // Only update fields that are NOT empty
                    if (!string.IsNullOrWhiteSpace(textBox1.Text))
                        warehouse.Name = textBox1.Text;

                    if (!string.IsNullOrWhiteSpace(textBox2.Text))
                        warehouse.Address = textBox2.Text;

                    if (!string.IsNullOrWhiteSpace(textBox3.Text))
                        warehouse.Manager = textBox3.Text;

                    context.SaveChanges();
                    LoadWarehouses();
                }
                else
                {
                    MessageBox.Show("Warehouse not found.");
                }
            }
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            int warehouseId = -1;

            // Check if user provided an ID in the textbox
            if (!string.IsNullOrWhiteSpace(textBox4.Text))
            {
                if (!int.TryParse(textBox4.Text, out warehouseId))
                {
                    MessageBox.Show("Invalid ID entered.");
                    return;
                }
            }
            // If no ID is provided, use the selected row
            else if (dataGridViewWarehouses.SelectedRows.Count > 0)
            {
                warehouseId = Convert.ToInt32(dataGridViewWarehouses.SelectedRows[0].Cells["Id"].Value);
            }
            else
            {
                MessageBox.Show("Please enter an ID or select a row.");
                return;
            }

            using (var context = new AppDbContext())
            {
                var warehouse = context.Warehouses.Find(warehouseId);
                if (warehouse != null)
                {
                    context.Warehouses.Remove(warehouse);
                    context.SaveChanges();
                    LoadWarehouses();
                }
                else
                {
                    MessageBox.Show("Warehouse not found.");
                }
            }
        }
        private void Save_Click(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                context.SaveChanges();
                MessageBox.Show("Changes saved successfully.");
            }
        }

        //customer
        private BindingSource customerBindingSource = new BindingSource();
        private void LoadCustomers()
        {

            using (var context = new AppDbContext())
            {
                var customers = context.Clients.ToList();
                customerBindingSource.DataSource = customers;
                dataGridViewCustomers.DataSource = customerBindingSource;
                dataGridViewCustomers.AllowUserToAddRows = true;
                dataGridViewCustomers.AllowUserToDeleteRows = true;
                dataGridViewCustomers.ReadOnly = false;
            }
        }
        private void AddClient_Click(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                var customer = new Client
                {
                    Name = textBoxName.Text,
                    Phone = textBoxEmail.Text,
                    Fax = textBoxWebsite.Text,
                    Mobile = textBoxFax.Text,
                    Email = textBoxPhone.Text,
                    Site = textBoxMobile.Text
                };
                context.Clients.Add(customer);
                context.SaveChanges();
            }
            LoadCustomers();
        }
        private void UpdateClient_Click(object sender, EventArgs e)
        {
            int customerId;
            if (!int.TryParse(textBoxCustomerId.Text, out customerId))
            {
                MessageBox.Show("Invalid ID entered.");
                return;
            }

            using (var context = new AppDbContext())
            {
                var customer = context.Clients.Find(customerId);
                if (customer != null)
                {
                    if (!string.IsNullOrWhiteSpace(textBoxName.Text))
                        customer.Name = textBoxName.Text;
                    if (!string.IsNullOrWhiteSpace(textBoxPhone.Text))
                        customer.Phone = textBoxPhone.Text;
                    if (!string.IsNullOrWhiteSpace(textBoxFax.Text))
                        customer.Fax = textBoxFax.Text;
                    if (!string.IsNullOrWhiteSpace(textBoxMobile.Text))
                        customer.Mobile = textBoxMobile.Text;
                    if (!string.IsNullOrWhiteSpace(textBoxEmail.Text))
                        customer.Email = textBoxEmail.Text;
                    if (!string.IsNullOrWhiteSpace(textBoxWebsite.Text))
                        customer.Site = textBoxWebsite.Text;

                    context.SaveChanges();
                    LoadCustomers();
                }
                else
                {
                    MessageBox.Show("Customer not found.");
                }
            }
        }
        private void DeleteClient_Click(object sender, EventArgs e)
        {
            int customerId;
            if (!int.TryParse(textBoxCustomerId.Text, out customerId))
            {
                MessageBox.Show("Invalid ID entered.");
                return;
            }

            using (var context = new AppDbContext())
            {
                var customer = context.Clients.Find(customerId);
                if (customer != null)
                {
                    context.Clients.Remove(customer);
                    context.SaveChanges();
                    LoadCustomers();
                }
                else
                {
                    MessageBox.Show("Customer not found.");
                }
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                var customers = (List<Client>)customerBindingSource.DataSource;
                var existingCustomers = context.Clients.AsNoTracking().ToList();

                // Handle deletions (Find missing items)
                foreach (var dbCustomer in existingCustomers)
                {
                    if (!customers.Any(c => c.Id == dbCustomer.Id))
                    {
                        var toDelete = context.Clients.Find(dbCustomer.Id);
                        if (toDelete != null)
                            context.Clients.Remove(toDelete);
                    }
                }

                // Handle additions & updates
                foreach (var customer in customers)
                {
                    if (customer.Id == 0)
                    {
                        context.Clients.Add(customer);
                    }
                    else
                    {
                        var existing = context.Clients.Find(customer.Id);
                        if (existing != null)
                        {
                            context.Entry(existing).CurrentValues.SetValues(customer);
                        }
                    }
                }

                context.SaveChanges();
                MessageBox.Show("Changes saved successfully.");
                LoadCustomers(); // Refresh DataGridView
            }
        }
        private void dataGridViewCustomers_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            var customer = (Client)dataGridViewCustomers.Rows[e.RowIndex].DataBoundItem;
            if (customer != null)
            {
                customerBindingSource.EndEdit(); // Confirm changes in the BindingSource
            }
        }

        private void dataGridViewSuppliers_Click(object sender, EventArgs e)
        {

        }


        //supplier
        private BindingSource supplierBindingSource = new BindingSource();
        private void LoadSuppliers()
        {
            using (var context = new AppDbContext())
            {
                var suppliers = context.Suppliers.AsNoTracking().ToList();
                supplierBindingSource.DataSource = suppliers;
                dataGridViewSupplier.DataSource = supplierBindingSource;
                dataGridViewSupplier.AllowUserToAddRows = true;
                dataGridViewSupplier.AllowUserToDeleteRows = true;
            }
        }
        private void AddSupplier_Click(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {


                var supplier = new Supplier
                {
                    Name = textBoxSupplierName.Text.Trim(),
                    Phone = textBoxSupplierPhone.Text.Trim(),
                    Fax = textBoxSupplierFax.Text.Trim(),
                    Mobile = label25.Text.Trim(),
                    Email = textBoxSupplierEmail.Text.Trim(),
                    Site = textBoxWebsite.Text.Trim()
                };

                context.Suppliers.Add(supplier);
                context.SaveChanges();
            }
            LoadSuppliers();
        }
        private void UpdateSupplier_Click(object sender, EventArgs e)
        {
            int supplierId;
            if (!int.TryParse(textBoxSupplierId.Text, out supplierId))
            {
                MessageBox.Show("Invalid ID entered.");
                return;
            }

            using (var context = new AppDbContext())
            {
                var supplier = context.Suppliers.Find(supplierId);
                if (supplier != null)
                {
                    if (!string.IsNullOrWhiteSpace(label20.Text))
                        supplier.Name = textBoxSupplierName.Text.Trim();
                    if (!string.IsNullOrWhiteSpace(label50.Text))
                        supplier.Phone = textBoxSupplierPhone.Text.Trim();
                    if (!string.IsNullOrWhiteSpace(textBoxSupplierFax.Text))
                        supplier.Fax = textBoxSupplierFax.Text.Trim();
                    if (!string.IsNullOrWhiteSpace(label25.Text))
                        supplier.Mobile = textBoxSupplierMobile.Text.Trim();
                    if (!string.IsNullOrWhiteSpace(textBoxSupplierEmail.Text))
                        supplier.Email = textBoxSupplierEmail.Text.Trim();
                    if (!string.IsNullOrWhiteSpace(textBoxWebsite.Text))
                        supplier.Site = textBoxWebsite.Text.Trim();

                    context.SaveChanges();
                    LoadSuppliers();
                }
                else
                {
                    MessageBox.Show("Supplier not found.");
                }
            }
        }
        private void DeleteSupplier_Click(object sender, EventArgs e)
        {
            int supplierId;
            if (!int.TryParse(textBoxSupplierId.Text, out supplierId))
            {
                MessageBox.Show("Invalid ID entered.");
                return;
            }

            var confirmResult = MessageBox.Show("Are you sure you want to delete this supplier?",
                                                "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.No) return;

            using (var context = new AppDbContext())
            {
                var supplier = context.Suppliers.Find(supplierId);
                if (supplier != null)
                {
                    context.Suppliers.Remove(supplier);
                    context.SaveChanges();
                    LoadSuppliers();
                }
                else
                {
                    MessageBox.Show("Supplier not found.");
                }
            }
        }
        private void SaveSupplierChanges_Click_1(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                var updatedSuppliers = (List<Supplier>)supplierBindingSource.DataSource;
                var existingSuppliers = context.Suppliers.ToList();

                // Handle deletions
                foreach (var dbSupplier in existingSuppliers)
                {
                    if (!updatedSuppliers.Any(s => s.Id == dbSupplier.Id))
                    {
                        context.Suppliers.Remove(context.Suppliers.Find(dbSupplier.Id));
                    }
                }

                // Handle additions & updates
                foreach (var supplier in updatedSuppliers)
                {
                    if (supplier.Id == 0)
                    {
                        context.Suppliers.Add(supplier);
                    }
                    else
                    {
                        var existing = context.Suppliers.Find(supplier.Id);
                        if (existing != null)
                        {
                            context.Entry(existing).CurrentValues.SetValues(supplier);
                        }
                    }
                }

                context.SaveChanges();
                MessageBox.Show("Changes saved successfully.");
                LoadSuppliers();
            }
        }     
        private void btnChooseItem_Click(object sender, EventArgs e)
        {
            ItemSelectionForm itemForm = new ItemSelectionForm();
            //if (itemForm.ShowDialog() == DialogResult.OK)
            //{
            //    // Retrieve selected item from the new form
            //    var selectedItem = itemForm.Select;
            //    if (selectedItem != null)
            //    {
            //        MessageBox.Show($"Selected Item: {selectedItem.Name}");
            //    }
            //}
            itemForm.Show();
        }


        private BindingSource supplyOrderBindingSource = new BindingSource();
        private BindingSource supplyOrderItemsBindingSource = new BindingSource();
        private BindingList<SupplyOrderItem> supplyOrderItems = new BindingList<SupplyOrderItem>();

        private void LoadWarehousesForOrders()
        {
            using (var context = new AppDbContext())
            {
                var warehouses = context.Warehouses.AsNoTracking().ToList();
                if (warehouses.Any())
                {
                    comboBoxWarehouse.DataSource = warehouses;
                    comboBoxWarehouse.DisplayMember = "Name";
                    comboBoxWarehouse.ValueMember = "Id";
                }
                else
                {
                    MessageBox.Show("No warehouses found. Please add warehouses first.");
                }
            }
        }

        private void LoadSuppliersForOrder()
        {
            using (var context = new AppDbContext())
            {
                var suppliers = context.Suppliers.AsNoTracking().ToList();
                if (suppliers.Any())
                {
                    comboBoxSupplier.DataSource = suppliers;
                    comboBoxSupplier.DisplayMember = "Name";
                    comboBoxSupplier.ValueMember = "Id";
                }
                else
                {
                    MessageBox.Show("No suppliers found. Please add suppliers first.");
                }
            }
        }

        private void LoadSupplyOrders()
        {
            using (var context = new AppDbContext())
            {
                var supplyOrders = context.SupplyOrders
                    .Include(o => o.Supplier)
                    .Include(o => o.Warehouse)
                    .Include(o => o.SupplyOrderItems)
                    .ThenInclude(i => i.Item)
                    .AsNoTracking()
                    .ToList();

                supplyOrderBindingSource.DataSource = supplyOrders;
                dataGridViewSupplyItems.DataSource = supplyOrderBindingSource;
            }
        }

        private void AddSupplyOrder_Click(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                var supplyOrder = new SupplyOrder
                {
                    OrderDate = dateTimeOrder.Value,
                    SupplierId = (int)comboBoxSupplier.SelectedValue,
                    WarehouseId = (int)comboBoxWarehouse.SelectedValue,
                    SupplyOrderItems = new List<SupplyOrderItem>()
                };

                context.SupplyOrders.Add(supplyOrder);
                context.SaveChanges();
            }
            LoadSupplyOrders();
        }

        private void UpdateSupplyOrder_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxReleaseOrderId.Text, out int orderId))
            {
                MessageBox.Show("Invalid Order ID.");
                return;
            }

            using (var context = new AppDbContext())
            {
                var supplyOrder = context.SupplyOrders.Find(orderId);
                if (supplyOrder != null)
                {
                    supplyOrder.OrderDate = dateTimeOrder.Value;
                    supplyOrder.SupplierId = (int)comboBoxSupplier.SelectedValue;
                    supplyOrder.WarehouseId = (int)comboBoxWarehouse.SelectedValue;
                    context.SaveChanges();
                    LoadSupplyOrders();
                }
                else
                {
                    MessageBox.Show("Supply Order not found.");
                }
            }
        }

        private void DeleteSupplyOrder_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxReleaseOrderId.Text, out int orderId))
            {
                MessageBox.Show("Invalid Order ID.");
                return;
            }

            var confirmResult = MessageBox.Show("Are you sure you want to delete this Supply Order?",
                                                "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.No) return;

            using (var context = new AppDbContext())
            {
                var supplyOrder = context.SupplyOrders
                    .Include(o => o.SupplyOrderItems)
                    .ThenInclude(i => i.Item)
                    .FirstOrDefault(o => o.Id == orderId);

                if (supplyOrder == null)
                {
                    MessageBox.Show("Supply Order not found.");
                    return;
                }

                // Remove associated items first
                if (supplyOrder.SupplyOrderItems.Any())
                {
                    context.SupplyOrderItems.RemoveRange(supplyOrder.SupplyOrderItems);
                }

                // Remove the supply order itself
                context.SupplyOrders.Remove(supplyOrder);
                context.SaveChanges();

                MessageBox.Show("Supply Order deleted successfully.");
                LoadSupplyOrders();
            }
        }

        private void SaveSupplyOrder_Click(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                foreach (var order in (List<SupplyOrder>)supplyOrderBindingSource.DataSource)
                {
                    context.Entry(order).State = order.Id == 0 ? EntityState.Added : EntityState.Modified;
                }
                context.SaveChanges();
                MessageBox.Show("Changes saved successfully.");
            }
        }

 
    }
}


