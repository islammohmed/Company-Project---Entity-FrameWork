namespace Company_Project
{
    partial class ReleaseorderItems
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
            ReleaseItemsDVg = new DataGridView();
            btnSelect = new Button();
            ((System.ComponentModel.ISupportInitialize)ReleaseItemsDVg).BeginInit();
            SuspendLayout();
            // 
            // ReleaseItemsDVg
            // 
            ReleaseItemsDVg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ReleaseItemsDVg.Location = new Point(12, 35);
            ReleaseItemsDVg.Name = "ReleaseItemsDVg";
            ReleaseItemsDVg.RowHeadersWidth = 51;
            ReleaseItemsDVg.Size = new Size(755, 309);
            ReleaseItemsDVg.TabIndex = 0;
            // 
            // btnSelect
            // 
            btnSelect.Location = new Point(26, 364);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(94, 29);
            btnSelect.TabIndex = 1;
            btnSelect.Text = "Select";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // ReleaseorderItems
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSelect);
            Controls.Add(ReleaseItemsDVg);
            Name = "ReleaseorderItems";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)ReleaseItemsDVg).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView ReleaseItemsDVg;
        private Button btnSelect;
    }
}