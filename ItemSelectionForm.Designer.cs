﻿namespace Company_Project
{
    partial class ItemSelectionForm
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
            dgvSupplyOrderItems = new DataGridView();
            label10 = new Label();
            btnSelect = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSupplyOrderItems).BeginInit();
            SuspendLayout();
            // 
            // dgvSupplyOrderItems
            // 
            dgvSupplyOrderItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSupplyOrderItems.Location = new Point(12, 32);
            dgvSupplyOrderItems.Name = "dgvSupplyOrderItems";
            dgvSupplyOrderItems.RowHeadersWidth = 51;
            dgvSupplyOrderItems.Size = new Size(776, 299);
            dgvSupplyOrderItems.TabIndex = 22;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(342, 9);
            label10.Name = "label10";
            label10.Size = new Size(94, 20);
            label10.TabIndex = 21;
            label10.Text = "Supply Items";
            // 
            // btnSelect
            // 
            btnSelect.Location = new Point(12, 337);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(94, 29);
            btnSelect.TabIndex = 26;
            btnSelect.Text = "Select";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // ItemSelectionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSelect);
            Controls.Add(dgvSupplyOrderItems);
            Controls.Add(label10);
            Name = "ItemSelectionForm";
            Text = "ItemSelectionForm";
            ((System.ComponentModel.ISupportInitialize)dgvSupplyOrderItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvSupplyOrderItems;
        private Label label10;
        private Button btnSelect;
    }
}