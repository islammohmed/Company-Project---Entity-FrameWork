namespace Company_Project
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
            Customer = new TabControl();
            WarehouseManagement = new TabPage();
            textBox4 = new TextBox();
            label1 = new Label();
            Save = new Button();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            Address = new Label();
            Manger = new Label();
            Name = new Label();
            Delete = new Button();
            Update = new Button();
            Add = new Button();
            dataGridViewWarehouses = new DataGridView();
            SupplyOrder = new TabPage();
            label14 = new Label();
            dvgSupplyItems = new DataGridView();
            btnChooseItem = new Button();
            SaveSupplyOrder = new Button();
            dateTimeOrder = new DateTimePicker();
            comboBoxWarehouse = new ComboBox();
            comboBoxSupplier = new ComboBox();
            DeleteSupplyOrder = new Button();
            UpdateSupplyOrder = new Button();
            label5 = new Label();
            textBoxReleaseOrderId = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            AddSupplyOrder = new Button();
            dataGridViewSupplyItems = new DataGridView();
            ReleaseOrder = new TabPage();
            button5 = new Button();
            label10 = new Label();
            dgvReleaseOrderItems = new DataGridView();
            SaveReleaseOrder = new Button();
            comboBoxWarehouseforRelase = new ComboBox();
            comboBoxCustomer = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            label6 = new Label();
            textBox15 = new TextBox();
            textBox16 = new TextBox();
            label7 = new Label();
            WarehouseId = new Label();
            ClientId = new Label();
            button3 = new Button();
            dgvReleaseOrders = new DataGridView();
            TransferOrder = new TabPage();
            tabPage5 = new TabPage();
            tabPage1 = new TabPage();
            button4 = new Button();
            textBoxCustomerId = new TextBox();
            label8 = new Label();
            textBoxMobile = new TextBox();
            Mobile = new Label();
            DeleteClient = new Button();
            UpdateClient = new Button();
            textBoxPhone = new TextBox();
            textBoxFax = new TextBox();
            textBoxWebsite = new TextBox();
            textBoxEmail = new TextBox();
            Phone = new Label();
            Fax = new Label();
            ClientEmail = new Label();
            Site = new Label();
            AddClient = new Button();
            textBoxName = new TextBox();
            ClientName = new Label();
            dataGridViewCustomers = new DataGridView();
            dataGridViewSuppliers = new TabPage();
            SaveSupplierChanges = new Button();
            textBoxSupplierId = new TextBox();
            label9 = new Label();
            textBoxSupplierPhone = new TextBox();
            label50 = new Label();
            DeleteSupplier = new Button();
            UpdateSupplier = new Button();
            SupplierWebsite = new TextBox();
            textBoxSupplierFax = new TextBox();
            textBoxSupplierMobile = new TextBox();
            textBoxSupplierEmail = new TextBox();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label25 = new Label();
            AddSupplier = new Button();
            textBoxSupplierName = new TextBox();
            label20 = new Label();
            dataGridViewSupplier = new DataGridView();
            Customer.SuspendLayout();
            WarehouseManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewWarehouses).BeginInit();
            SupplyOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgSupplyItems).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSupplyItems).BeginInit();
            ReleaseOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReleaseOrderItems).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvReleaseOrders).BeginInit();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomers).BeginInit();
            dataGridViewSuppliers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSupplier).BeginInit();
            SuspendLayout();
            // 
            // Customer
            // 
            Customer.Controls.Add(WarehouseManagement);
            Customer.Controls.Add(SupplyOrder);
            Customer.Controls.Add(ReleaseOrder);
            Customer.Controls.Add(TransferOrder);
            Customer.Controls.Add(tabPage5);
            Customer.Controls.Add(tabPage1);
            Customer.Controls.Add(dataGridViewSuppliers);
            Customer.Cursor = Cursors.Hand;
            Customer.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Customer.Location = new Point(12, 7);
            Customer.Name = "Customer";
            Customer.SelectedIndex = 0;
            Customer.Size = new Size(1002, 703);
            Customer.TabIndex = 0;
            Customer.Tag = "";
            // 
            // WarehouseManagement
            // 
            WarehouseManagement.BackColor = Color.Transparent;
            WarehouseManagement.Controls.Add(textBox4);
            WarehouseManagement.Controls.Add(label1);
            WarehouseManagement.Controls.Add(Save);
            WarehouseManagement.Controls.Add(textBox3);
            WarehouseManagement.Controls.Add(textBox2);
            WarehouseManagement.Controls.Add(textBox1);
            WarehouseManagement.Controls.Add(Address);
            WarehouseManagement.Controls.Add(Manger);
            WarehouseManagement.Controls.Add(Name);
            WarehouseManagement.Controls.Add(Delete);
            WarehouseManagement.Controls.Add(Update);
            WarehouseManagement.Controls.Add(Add);
            WarehouseManagement.Controls.Add(dataGridViewWarehouses);
            WarehouseManagement.ForeColor = SystemColors.ActiveCaptionText;
            WarehouseManagement.Location = new Point(4, 29);
            WarehouseManagement.Name = "WarehouseManagement";
            WarehouseManagement.Padding = new Padding(3);
            WarehouseManagement.Size = new Size(994, 670);
            WarehouseManagement.TabIndex = 0;
            WarehouseManagement.Text = "Warehouse Management";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(381, 523);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(381, 500);
            label1.Name = "label1";
            label1.Size = new Size(171, 20);
            label1.TabIndex = 21;
            label1.Text = "Id for Update or Delete";
            // 
            // Save
            // 
            Save.Location = new Point(785, 438);
            Save.Name = "Save";
            Save.Size = new Size(142, 29);
            Save.TabIndex = 20;
            Save.Text = "Save";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(17, 523);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 19;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(381, 470);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 18;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(17, 470);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 17;
            // 
            // Address
            // 
            Address.AutoSize = true;
            Address.Location = new Point(381, 447);
            Address.Name = "Address";
            Address.Size = new Size(66, 20);
            Address.TabIndex = 16;
            Address.Text = "Address";
            // 
            // Manger
            // 
            Manger.AutoSize = true;
            Manger.Location = new Point(17, 500);
            Manger.Name = "Manger";
            Manger.Size = new Size(71, 20);
            Manger.TabIndex = 15;
            Manger.Text = "Manager";
            // 
            // Name
            // 
            Name.AutoSize = true;
            Name.ForeColor = SystemColors.ActiveCaptionText;
            Name.Location = new Point(17, 447);
            Name.Name = "Name";
            Name.Size = new Size(51, 20);
            Name.TabIndex = 14;
            Name.Text = "Name";
            // 
            // Delete
            // 
            Delete.Location = new Point(763, 616);
            Delete.Name = "Delete";
            Delete.Size = new Size(94, 29);
            Delete.TabIndex = 13;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click;
            // 
            // Update
            // 
            Update.Location = new Point(381, 616);
            Update.Name = "Update";
            Update.Size = new Size(94, 29);
            Update.TabIndex = 12;
            Update.Text = "Update";
            Update.UseVisualStyleBackColor = true;
            Update.Click += Update_Click;
            // 
            // Add
            // 
            Add.Location = new Point(39, 616);
            Add.Name = "Add";
            Add.Size = new Size(94, 29);
            Add.TabIndex = 11;
            Add.Text = "Add";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // dataGridViewWarehouses
            // 
            dataGridViewWarehouses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewWarehouses.Location = new Point(17, 6);
            dataGridViewWarehouses.Name = "dataGridViewWarehouses";
            dataGridViewWarehouses.RowHeadersWidth = 51;
            dataGridViewWarehouses.Size = new Size(910, 426);
            dataGridViewWarehouses.TabIndex = 0;
            dataGridViewWarehouses.CellDoubleClick += dataGridViewWarehouses_CellDoubleClick;
            // 
            // SupplyOrder
            // 
            SupplyOrder.BackColor = Color.Transparent;
            SupplyOrder.Controls.Add(label14);
            SupplyOrder.Controls.Add(dvgSupplyItems);
            SupplyOrder.Controls.Add(btnChooseItem);
            SupplyOrder.Controls.Add(SaveSupplyOrder);
            SupplyOrder.Controls.Add(dateTimeOrder);
            SupplyOrder.Controls.Add(comboBoxWarehouse);
            SupplyOrder.Controls.Add(comboBoxSupplier);
            SupplyOrder.Controls.Add(DeleteSupplyOrder);
            SupplyOrder.Controls.Add(UpdateSupplyOrder);
            SupplyOrder.Controls.Add(label5);
            SupplyOrder.Controls.Add(textBoxReleaseOrderId);
            SupplyOrder.Controls.Add(label4);
            SupplyOrder.Controls.Add(label3);
            SupplyOrder.Controls.Add(label2);
            SupplyOrder.Controls.Add(AddSupplyOrder);
            SupplyOrder.Controls.Add(dataGridViewSupplyItems);
            SupplyOrder.Location = new Point(4, 29);
            SupplyOrder.Name = "SupplyOrder";
            SupplyOrder.Padding = new Padding(3);
            SupplyOrder.Size = new Size(994, 670);
            SupplyOrder.TabIndex = 1;
            SupplyOrder.Text = "Supply Order";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(394, 429);
            label14.Name = "label14";
            label14.Size = new Size(100, 20);
            label14.TabIndex = 18;
            label14.Text = "Supply Items";
            // 
            // dvgSupplyItems
            // 
            dvgSupplyItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgSupplyItems.Location = new Point(38, 452);
            dvgSupplyItems.Name = "dvgSupplyItems";
            dvgSupplyItems.RowHeadersWidth = 51;
            dvgSupplyItems.Size = new Size(865, 158);
            dvgSupplyItems.TabIndex = 17;
            // 
            // btnChooseItem
            // 
            btnChooseItem.Location = new Point(258, 616);
            btnChooseItem.Name = "btnChooseItem";
            btnChooseItem.Size = new Size(379, 29);
            btnChooseItem.TabIndex = 16;
            btnChooseItem.Text = "Choose Item";
            btnChooseItem.UseVisualStyleBackColor = true;
            btnChooseItem.Click += btnChooseItem_Click;
            // 
            // SaveSupplyOrder
            // 
            SaveSupplyOrder.Location = new Point(66, 375);
            SaveSupplyOrder.Name = "SaveSupplyOrder";
            SaveSupplyOrder.Size = new Size(379, 29);
            SaveSupplyOrder.TabIndex = 15;
            SaveSupplyOrder.Text = "Save";
            SaveSupplyOrder.UseVisualStyleBackColor = true;
            // 
            // dateTimeOrder
            // 
            dateTimeOrder.Location = new Point(50, 196);
            dateTimeOrder.Name = "dateTimeOrder";
            dateTimeOrder.Size = new Size(277, 27);
            dateTimeOrder.TabIndex = 14;
            // 
            // comboBoxWarehouse
            // 
            comboBoxWarehouse.FormattingEnabled = true;
            comboBoxWarehouse.Location = new Point(53, 63);
            comboBoxWarehouse.Name = "comboBoxWarehouse";
            comboBoxWarehouse.Size = new Size(151, 28);
            comboBoxWarehouse.TabIndex = 13;
            // 
            // comboBoxSupplier
            // 
            comboBoxSupplier.FormattingEnabled = true;
            comboBoxSupplier.Location = new Point(53, 135);
            comboBoxSupplier.Name = "comboBoxSupplier";
            comboBoxSupplier.Size = new Size(151, 28);
            comboBoxSupplier.TabIndex = 12;
            // 
            // DeleteSupplyOrder
            // 
            DeleteSupplyOrder.Location = new Point(351, 327);
            DeleteSupplyOrder.Name = "DeleteSupplyOrder";
            DeleteSupplyOrder.Size = new Size(94, 29);
            DeleteSupplyOrder.TabIndex = 11;
            DeleteSupplyOrder.Text = "Delete";
            DeleteSupplyOrder.UseVisualStyleBackColor = true;
            // 
            // UpdateSupplyOrder
            // 
            UpdateSupplyOrder.Location = new Point(206, 327);
            UpdateSupplyOrder.Name = "UpdateSupplyOrder";
            UpdateSupplyOrder.Size = new Size(94, 29);
            UpdateSupplyOrder.TabIndex = 10;
            UpdateSupplyOrder.Text = "Update";
            UpdateSupplyOrder.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 248);
            label5.Name = "label5";
            label5.Size = new Size(171, 20);
            label5.TabIndex = 9;
            label5.Text = "Id for Update or Delete";
            // 
            // textBoxReleaseOrderId
            // 
            textBoxReleaseOrderId.Location = new Point(53, 271);
            textBoxReleaseOrderId.Name = "textBoxReleaseOrderId";
            textBoxReleaseOrderId.Size = new Size(125, 27);
            textBoxReleaseOrderId.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 173);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 6;
            label4.Text = "Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 112);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 4;
            label3.Text = "Suppler ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 40);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 2;
            label2.Text = "Wahrehouse";
            // 
            // AddSupplyOrder
            // 
            AddSupplyOrder.Location = new Point(66, 327);
            AddSupplyOrder.Name = "AddSupplyOrder";
            AddSupplyOrder.Size = new Size(94, 29);
            AddSupplyOrder.TabIndex = 1;
            AddSupplyOrder.Text = "Add";
            AddSupplyOrder.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSupplyItems
            // 
            dataGridViewSupplyItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSupplyItems.Location = new Point(451, 17);
            dataGridViewSupplyItems.Name = "dataGridViewSupplyItems";
            dataGridViewSupplyItems.RowHeadersWidth = 51;
            dataGridViewSupplyItems.Size = new Size(476, 396);
            dataGridViewSupplyItems.TabIndex = 0;
            // 
            // ReleaseOrder
            // 
            ReleaseOrder.BackColor = Color.Transparent;
            ReleaseOrder.Controls.Add(button5);
            ReleaseOrder.Controls.Add(label10);
            ReleaseOrder.Controls.Add(dgvReleaseOrderItems);
            ReleaseOrder.Controls.Add(SaveReleaseOrder);
            ReleaseOrder.Controls.Add(comboBoxWarehouseforRelase);
            ReleaseOrder.Controls.Add(comboBoxCustomer);
            ReleaseOrder.Controls.Add(button1);
            ReleaseOrder.Controls.Add(button2);
            ReleaseOrder.Controls.Add(label6);
            ReleaseOrder.Controls.Add(textBox15);
            ReleaseOrder.Controls.Add(textBox16);
            ReleaseOrder.Controls.Add(label7);
            ReleaseOrder.Controls.Add(WarehouseId);
            ReleaseOrder.Controls.Add(ClientId);
            ReleaseOrder.Controls.Add(button3);
            ReleaseOrder.Controls.Add(dgvReleaseOrders);
            ReleaseOrder.ForeColor = SystemColors.ControlText;
            ReleaseOrder.Location = new Point(4, 29);
            ReleaseOrder.Name = "ReleaseOrder";
            ReleaseOrder.Padding = new Padding(3);
            ReleaseOrder.Size = new Size(994, 670);
            ReleaseOrder.TabIndex = 2;
            ReleaseOrder.Text = "ReleaseOrder";
            // 
            // button5
            // 
            button5.Location = new Point(276, 628);
            button5.Name = "button5";
            button5.Size = new Size(379, 29);
            button5.TabIndex = 28;
            button5.Text = "Choose Item";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(406, 416);
            label10.Name = "label10";
            label10.Size = new Size(106, 20);
            label10.TabIndex = 27;
            label10.Text = "Release Items";
            // 
            // dgvReleaseOrderItems
            // 
            dgvReleaseOrderItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReleaseOrderItems.Location = new Point(32, 439);
            dgvReleaseOrderItems.Name = "dgvReleaseOrderItems";
            dgvReleaseOrderItems.RowHeadersWidth = 51;
            dgvReleaseOrderItems.Size = new Size(895, 183);
            dgvReleaseOrderItems.TabIndex = 26;
            // 
            // SaveReleaseOrder
            // 
            SaveReleaseOrder.Location = new Point(70, 373);
            SaveReleaseOrder.Name = "SaveReleaseOrder";
            SaveReleaseOrder.Size = new Size(379, 29);
            SaveReleaseOrder.TabIndex = 25;
            SaveReleaseOrder.Text = "Save";
            SaveReleaseOrder.UseVisualStyleBackColor = true;
            SaveReleaseOrder.Click += SaveReleaseOrder_Click;
            // 
            // comboBoxWarehouseforRelase
            // 
            comboBoxWarehouseforRelase.FormattingEnabled = true;
            comboBoxWarehouseforRelase.Location = new Point(57, 136);
            comboBoxWarehouseforRelase.Name = "comboBoxWarehouseforRelase";
            comboBoxWarehouseforRelase.Size = new Size(151, 28);
            comboBoxWarehouseforRelase.TabIndex = 24;
            // 
            // comboBoxCustomer
            // 
            comboBoxCustomer.FormattingEnabled = true;
            comboBoxCustomer.Location = new Point(57, 66);
            comboBoxCustomer.Name = "comboBoxCustomer";
            comboBoxCustomer.Size = new Size(151, 28);
            comboBoxCustomer.TabIndex = 23;
            // 
            // button1
            // 
            button1.Location = new Point(355, 330);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 22;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(210, 330);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 21;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(42, 251);
            label6.Name = "label6";
            label6.Size = new Size(171, 20);
            label6.TabIndex = 20;
            label6.Text = "Id for Update or Delete";
            // 
            // textBox15
            // 
            textBox15.Location = new Point(57, 274);
            textBox15.Name = "textBox15";
            textBox15.Size = new Size(125, 27);
            textBox15.TabIndex = 19;
            // 
            // textBox16
            // 
            textBox16.Location = new Point(57, 199);
            textBox16.Name = "textBox16";
            textBox16.Size = new Size(125, 27);
            textBox16.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(42, 176);
            label7.Name = "label7";
            label7.Size = new Size(109, 20);
            label7.TabIndex = 17;
            label7.Text = "Total Quantity";
            // 
            // WarehouseId
            // 
            WarehouseId.AutoSize = true;
            WarehouseId.Location = new Point(42, 113);
            WarehouseId.Name = "WarehouseId";
            WarehouseId.Size = new Size(105, 20);
            WarehouseId.TabIndex = 15;
            WarehouseId.Text = "Warehouse Id";
            WarehouseId.Visible = false;
            // 
            // ClientId
            // 
            ClientId.AutoSize = true;
            ClientId.Location = new Point(42, 43);
            ClientId.Name = "ClientId";
            ClientId.Size = new Size(67, 20);
            ClientId.TabIndex = 13;
            ClientId.Text = "Client Id";
            // 
            // button3
            // 
            button3.Location = new Point(70, 330);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 12;
            button3.Text = "Add";
            button3.UseVisualStyleBackColor = true;
            // 
            // dgvReleaseOrders
            // 
            dgvReleaseOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReleaseOrders.Location = new Point(455, 6);
            dgvReleaseOrders.Name = "dgvReleaseOrders";
            dgvReleaseOrders.RowHeadersWidth = 51;
            dgvReleaseOrders.Size = new Size(472, 396);
            dgvReleaseOrders.TabIndex = 1;
            // 
            // TransferOrder
            // 
            TransferOrder.BackColor = Color.Transparent;
            TransferOrder.Location = new Point(4, 29);
            TransferOrder.Name = "TransferOrder";
            TransferOrder.Padding = new Padding(3);
            TransferOrder.Size = new Size(994, 670);
            TransferOrder.TabIndex = 3;
            TransferOrder.Text = "Transfer Order";
            // 
            // tabPage5
            // 
            tabPage5.BackColor = Color.Transparent;
            tabPage5.Location = new Point(4, 29);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(994, 670);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Reports";
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button4);
            tabPage1.Controls.Add(textBoxCustomerId);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(textBoxMobile);
            tabPage1.Controls.Add(Mobile);
            tabPage1.Controls.Add(DeleteClient);
            tabPage1.Controls.Add(UpdateClient);
            tabPage1.Controls.Add(textBoxPhone);
            tabPage1.Controls.Add(textBoxFax);
            tabPage1.Controls.Add(textBoxWebsite);
            tabPage1.Controls.Add(textBoxEmail);
            tabPage1.Controls.Add(Phone);
            tabPage1.Controls.Add(Fax);
            tabPage1.Controls.Add(ClientEmail);
            tabPage1.Controls.Add(Site);
            tabPage1.Controls.Add(AddClient);
            tabPage1.Controls.Add(textBoxName);
            tabPage1.Controls.Add(ClientName);
            tabPage1.Controls.Add(dataGridViewCustomers);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(994, 670);
            tabPage1.TabIndex = 5;
            tabPage1.Text = "Customer";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(28, 465);
            button4.Name = "button4";
            button4.Size = new Size(367, 29);
            button4.TabIndex = 18;
            button4.Text = "Save";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBoxCustomerId
            // 
            textBoxCustomerId.Location = new Point(101, 383);
            textBoxCustomerId.Name = "textBoxCustomerId";
            textBoxCustomerId.Size = new Size(125, 27);
            textBoxCustomerId.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(40, 360);
            label8.Name = "label8";
            label8.Size = new Size(182, 20);
            label8.TabIndex = 16;
            label8.Text = "Id for Delete and Update";
            // 
            // textBoxMobile
            // 
            textBoxMobile.Location = new Point(101, 304);
            textBoxMobile.Name = "textBoxMobile";
            textBoxMobile.Size = new Size(125, 27);
            textBoxMobile.TabIndex = 15;
            // 
            // Mobile
            // 
            Mobile.AutoSize = true;
            Mobile.Location = new Point(40, 307);
            Mobile.Name = "Mobile";
            Mobile.Size = new Size(57, 20);
            Mobile.TabIndex = 14;
            Mobile.Text = "Mobile";
            // 
            // DeleteClient
            // 
            DeleteClient.Location = new Point(301, 420);
            DeleteClient.Name = "DeleteClient";
            DeleteClient.Size = new Size(94, 29);
            DeleteClient.TabIndex = 13;
            DeleteClient.Text = "Delete";
            DeleteClient.UseVisualStyleBackColor = true;
            DeleteClient.Click += DeleteClient_Click;
            // 
            // UpdateClient
            // 
            UpdateClient.Location = new Point(164, 420);
            UpdateClient.Name = "UpdateClient";
            UpdateClient.Size = new Size(94, 29);
            UpdateClient.TabIndex = 12;
            UpdateClient.Text = "Update";
            UpdateClient.UseVisualStyleBackColor = true;
            UpdateClient.Click += UpdateClient_Click;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(101, 255);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(125, 27);
            textBoxPhone.TabIndex = 11;
            // 
            // textBoxFax
            // 
            textBoxFax.Location = new Point(101, 202);
            textBoxFax.Name = "textBoxFax";
            textBoxFax.Size = new Size(125, 27);
            textBoxFax.TabIndex = 10;
            // 
            // textBoxWebsite
            // 
            textBoxWebsite.Location = new Point(101, 142);
            textBoxWebsite.Name = "textBoxWebsite";
            textBoxWebsite.Size = new Size(125, 27);
            textBoxWebsite.TabIndex = 9;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(101, 84);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(125, 27);
            textBoxEmail.TabIndex = 8;
            // 
            // Phone
            // 
            Phone.AutoSize = true;
            Phone.Location = new Point(42, 255);
            Phone.Name = "Phone";
            Phone.Size = new Size(53, 20);
            Phone.TabIndex = 7;
            Phone.Text = "Phone";
            // 
            // Fax
            // 
            Fax.AutoSize = true;
            Fax.Location = new Point(44, 202);
            Fax.Name = "Fax";
            Fax.Size = new Size(33, 20);
            Fax.TabIndex = 6;
            Fax.Text = "Fax";
            // 
            // ClientEmail
            // 
            ClientEmail.AutoSize = true;
            ClientEmail.Location = new Point(44, 87);
            ClientEmail.Name = "ClientEmail";
            ClientEmail.Size = new Size(47, 20);
            ClientEmail.TabIndex = 5;
            ClientEmail.Text = "Email";
            // 
            // Site
            // 
            Site.AutoSize = true;
            Site.Location = new Point(46, 145);
            Site.Name = "Site";
            Site.Size = new Size(35, 20);
            Site.TabIndex = 4;
            Site.Text = "Site";
            // 
            // AddClient
            // 
            AddClient.Location = new Point(28, 420);
            AddClient.Name = "AddClient";
            AddClient.Size = new Size(94, 29);
            AddClient.TabIndex = 3;
            AddClient.Text = "Add";
            AddClient.UseVisualStyleBackColor = true;
            AddClient.Click += AddClient_Click;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(101, 40);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(125, 27);
            textBoxName.TabIndex = 2;
            // 
            // ClientName
            // 
            ClientName.AutoSize = true;
            ClientName.Location = new Point(44, 40);
            ClientName.Name = "ClientName";
            ClientName.Size = new Size(51, 20);
            ClientName.TabIndex = 1;
            ClientName.Text = "Name";
            // 
            // dataGridViewCustomers
            // 
            dataGridViewCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCustomers.Location = new Point(258, 21);
            dataGridViewCustomers.Name = "dataGridViewCustomers";
            dataGridViewCustomers.RowHeadersWidth = 51;
            dataGridViewCustomers.Size = new Size(669, 366);
            dataGridViewCustomers.TabIndex = 0;
            // 
            // dataGridViewSuppliers
            // 
            dataGridViewSuppliers.Controls.Add(SaveSupplierChanges);
            dataGridViewSuppliers.Controls.Add(textBoxSupplierId);
            dataGridViewSuppliers.Controls.Add(label9);
            dataGridViewSuppliers.Controls.Add(textBoxSupplierPhone);
            dataGridViewSuppliers.Controls.Add(label50);
            dataGridViewSuppliers.Controls.Add(DeleteSupplier);
            dataGridViewSuppliers.Controls.Add(UpdateSupplier);
            dataGridViewSuppliers.Controls.Add(SupplierWebsite);
            dataGridViewSuppliers.Controls.Add(textBoxSupplierFax);
            dataGridViewSuppliers.Controls.Add(textBoxSupplierMobile);
            dataGridViewSuppliers.Controls.Add(textBoxSupplierEmail);
            dataGridViewSuppliers.Controls.Add(label11);
            dataGridViewSuppliers.Controls.Add(label12);
            dataGridViewSuppliers.Controls.Add(label13);
            dataGridViewSuppliers.Controls.Add(label25);
            dataGridViewSuppliers.Controls.Add(AddSupplier);
            dataGridViewSuppliers.Controls.Add(textBoxSupplierName);
            dataGridViewSuppliers.Controls.Add(label20);
            dataGridViewSuppliers.Controls.Add(dataGridViewSupplier);
            dataGridViewSuppliers.Location = new Point(4, 29);
            dataGridViewSuppliers.Name = "dataGridViewSuppliers";
            dataGridViewSuppliers.Padding = new Padding(3);
            dataGridViewSuppliers.Size = new Size(994, 670);
            dataGridViewSuppliers.TabIndex = 6;
            dataGridViewSuppliers.Text = "Supplier";
            dataGridViewSuppliers.UseVisualStyleBackColor = true;
            dataGridViewSuppliers.Click += dataGridViewSuppliers_Click;
            // 
            // SaveSupplierChanges
            // 
            SaveSupplierChanges.Location = new Point(45, 461);
            SaveSupplierChanges.Name = "SaveSupplierChanges";
            SaveSupplierChanges.Size = new Size(367, 29);
            SaveSupplierChanges.TabIndex = 37;
            SaveSupplierChanges.Text = "Save";
            SaveSupplierChanges.UseVisualStyleBackColor = true;
            SaveSupplierChanges.Click += SaveSupplierChanges_Click_1;
            // 
            // textBoxSupplierId
            // 
            textBoxSupplierId.Location = new Point(118, 379);
            textBoxSupplierId.Name = "textBoxSupplierId";
            textBoxSupplierId.Size = new Size(125, 27);
            textBoxSupplierId.TabIndex = 36;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(57, 356);
            label9.Name = "label9";
            label9.Size = new Size(182, 20);
            label9.TabIndex = 35;
            label9.Text = "Id for Delete and Update";
            // 
            // textBoxSupplierPhone
            // 
            textBoxSupplierPhone.Location = new Point(118, 300);
            textBoxSupplierPhone.Name = "textBoxSupplierPhone";
            textBoxSupplierPhone.Size = new Size(125, 27);
            textBoxSupplierPhone.TabIndex = 34;
            // 
            // label50
            // 
            label50.AutoSize = true;
            label50.Location = new Point(57, 303);
            label50.Name = "label50";
            label50.Size = new Size(53, 20);
            label50.TabIndex = 33;
            label50.Text = "Phone";
            // 
            // DeleteSupplier
            // 
            DeleteSupplier.Location = new Point(318, 416);
            DeleteSupplier.Name = "DeleteSupplier";
            DeleteSupplier.Size = new Size(94, 29);
            DeleteSupplier.TabIndex = 32;
            DeleteSupplier.Text = "Delete";
            DeleteSupplier.UseVisualStyleBackColor = true;
            // 
            // UpdateSupplier
            // 
            UpdateSupplier.Location = new Point(181, 416);
            UpdateSupplier.Name = "UpdateSupplier";
            UpdateSupplier.Size = new Size(94, 29);
            UpdateSupplier.TabIndex = 31;
            UpdateSupplier.Text = "Update";
            UpdateSupplier.UseVisualStyleBackColor = true;
            UpdateSupplier.Click += UpdateSupplier_Click;
            // 
            // SupplierWebsite
            // 
            SupplierWebsite.Location = new Point(118, 251);
            SupplierWebsite.Name = "SupplierWebsite";
            SupplierWebsite.Size = new Size(125, 27);
            SupplierWebsite.TabIndex = 30;
            // 
            // textBoxSupplierFax
            // 
            textBoxSupplierFax.Location = new Point(118, 198);
            textBoxSupplierFax.Name = "textBoxSupplierFax";
            textBoxSupplierFax.Size = new Size(125, 27);
            textBoxSupplierFax.TabIndex = 29;
            // 
            // textBoxSupplierMobile
            // 
            textBoxSupplierMobile.Location = new Point(118, 138);
            textBoxSupplierMobile.Name = "textBoxSupplierMobile";
            textBoxSupplierMobile.Size = new Size(125, 27);
            textBoxSupplierMobile.TabIndex = 28;
            // 
            // textBoxSupplierEmail
            // 
            textBoxSupplierEmail.Location = new Point(118, 80);
            textBoxSupplierEmail.Name = "textBoxSupplierEmail";
            textBoxSupplierEmail.Size = new Size(125, 27);
            textBoxSupplierEmail.TabIndex = 27;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(50, 254);
            label11.Name = "label11";
            label11.Size = new Size(67, 20);
            label11.TabIndex = 26;
            label11.Text = "WebSite";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(75, 201);
            label12.Name = "label12";
            label12.Size = new Size(33, 20);
            label12.TabIndex = 25;
            label12.Text = "Fax";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(61, 83);
            label13.Name = "label13";
            label13.Size = new Size(47, 20);
            label13.TabIndex = 24;
            label13.Text = "Email";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(63, 141);
            label25.Name = "label25";
            label25.Size = new Size(57, 20);
            label25.TabIndex = 23;
            label25.Text = "Mobile";
            // 
            // AddSupplier
            // 
            AddSupplier.Location = new Point(45, 416);
            AddSupplier.Name = "AddSupplier";
            AddSupplier.Size = new Size(94, 29);
            AddSupplier.TabIndex = 22;
            AddSupplier.Text = "Add";
            AddSupplier.UseVisualStyleBackColor = true;
            AddSupplier.Click += AddSupplier_Click;
            // 
            // textBoxSupplierName
            // 
            textBoxSupplierName.Location = new Point(118, 36);
            textBoxSupplierName.Name = "textBoxSupplierName";
            textBoxSupplierName.Size = new Size(125, 27);
            textBoxSupplierName.TabIndex = 21;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(61, 36);
            label20.Name = "label20";
            label20.Size = new Size(51, 20);
            label20.TabIndex = 20;
            label20.Text = "Name";
            // 
            // dataGridViewSupplier
            // 
            dataGridViewSupplier.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSupplier.Location = new Point(272, 17);
            dataGridViewSupplier.Name = "dataGridViewSupplier";
            dataGridViewSupplier.RowHeadersWidth = 51;
            dataGridViewSupplier.Size = new Size(655, 366);
            dataGridViewSupplier.TabIndex = 19;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(955, 693);
            Controls.Add(Customer);
            Text = "Form1";
            Customer.ResumeLayout(false);
            WarehouseManagement.ResumeLayout(false);
            WarehouseManagement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewWarehouses).EndInit();
            SupplyOrder.ResumeLayout(false);
            SupplyOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dvgSupplyItems).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSupplyItems).EndInit();
            ReleaseOrder.ResumeLayout(false);
            ReleaseOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReleaseOrderItems).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvReleaseOrders).EndInit();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomers).EndInit();
            dataGridViewSuppliers.ResumeLayout(false);
            dataGridViewSuppliers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSupplier).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl Customer;
        private TabPage WarehouseManagement;
        private TabPage SupplyOrder;
        private TabPage ReleaseOrder;
        private TabPage TransferOrder;
        private TabPage tabPage5;
        private DataGridView dataGridViewWarehouses;
        private Button Delete;
        private Button Update;
        private Button Add;
        private Label Address;
        private Label Manger;
        private Label Name;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button Save;
        private TextBox textBox4;
        private Label label1;
        private TabPage tabPage1;
        private Button AddClient;
        private TextBox textBoxName;
        private Label ClientName;
        private DataGridView dataGridViewCustomers;
        private Button DeleteClient;
        private Button UpdateClient;
        private TextBox textBoxPhone;
        private TextBox textBoxFax;
        private TextBox textBoxWebsite;
        private TextBox textBoxEmail;
        private Label Phone;
        private Label Fax;
        private Label ClientEmail;
        private Label Site;
        private TextBox textBoxMobile;
        private Label Mobile;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button AddSupplyOrder;
        private DataGridView dataGridViewSupplyItems;
        private Label label5;
        private TextBox textBoxReleaseOrderId;
        private Button DeleteSupplyOrder;
        private Button UpdateSupplyOrder;
        private DataGridView dgvReleaseOrders;
        private Button button1;
        private Button button2;
        private Label label6;
        private TextBox textBox15;
        private TextBox textBox16;
        private Label label7;
        private Label WarehouseId;
        private Label ClientId;
        private Button button3;
        private TextBox textBoxCustomerId;
        private Label label8;
        private Button button4;
        private TabPage dataGridViewSuppliers;
        private Button SaveSupplierChanges;
        private TextBox textBoxSupplierId;
        private Label label9;
        private TextBox textBoxSupplierPhone;
        private Label label50;
        private Button DeleteSupplier;
        private Button UpdateSupplier;
        private TextBox SupplierWebsite;
        private TextBox textBoxSupplierFax;
        private TextBox textBoxSupplierMobile;
        private TextBox textBoxSupplierEmail;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label25;
        private Button AddSupplier;
        private TextBox textBoxSupplierName;
        private Label label20;
        private DataGridView dataGridViewSupplier;
        private ComboBox comboBoxSupplier;
        private ComboBox comboBoxWarehouse;
        private Button SaveSupplyOrder;
        private DateTimePicker dateTimeOrder;
        private ComboBox comboBoxWarehouseforRelase;
        private ComboBox comboBoxCustomer;
        private Button SaveReleaseOrder;
        private Button btnChooseItem;
        private Label label10;
        private DataGridView dgvReleaseOrderItems;
        private Button button5;
        private DataGridView dvgSupplyItems;
        private Label label14;
    }
}
