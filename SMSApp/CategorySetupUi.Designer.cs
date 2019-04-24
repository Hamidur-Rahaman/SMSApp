namespace SMSApp
{
    partial class CategorySetupUi
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
            this.showDataGridView = new System.Windows.Forms.DataGridView();
            this.Sl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaveButton = new System.Windows.Forms.Button();
            this.categorySetupTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StockOutButton = new System.Windows.Forms.Button();
            this.StockINButton = new System.Windows.Forms.Button();
            this.ItemButton = new System.Windows.Forms.Button();
            this.CompanyButton = new System.Windows.Forms.Button();
            this.StockInSearchButton = new System.Windows.Forms.Button();
            this.DateWiseSearchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.showDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // showDataGridView
            // 
            this.showDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sl,
            this.Name,
            this.ID});
            this.showDataGridView.Location = new System.Drawing.Point(242, 140);
            this.showDataGridView.Name = "showDataGridView";
            this.showDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.showDataGridView.Size = new System.Drawing.Size(274, 118);
            this.showDataGridView.TabIndex = 11;
            this.showDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.showDataGridView_CellClick);
            this.showDataGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.showDataGridView_RowPostPaint);
            // 
            // Sl
            // 
            this.Sl.HeaderText = "Sl";
            this.Sl.Name = "Sl";
            this.Sl.Width = 30;
            // 
            // Name
            // 
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            this.Name.Width = 200;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(441, 94);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 28);
            this.SaveButton.TabIndex = 10;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // categorySetupTextBox
            // 
            this.categorySetupTextBox.Location = new System.Drawing.Point(217, 68);
            this.categorySetupTextBox.Name = "categorySetupTextBox";
            this.categorySetupTextBox.Size = new System.Drawing.Size(299, 20);
            this.categorySetupTextBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name";
            // 
            // StockOutButton
            // 
            this.StockOutButton.Location = new System.Drawing.Point(255, 20);
            this.StockOutButton.Name = "StockOutButton";
            this.StockOutButton.Size = new System.Drawing.Size(75, 23);
            this.StockOutButton.TabIndex = 13;
            this.StockOutButton.Text = "Stock Out";
            this.StockOutButton.UseVisualStyleBackColor = true;
            this.StockOutButton.Click += new System.EventHandler(this.StockOutButton_Click);
            // 
            // StockINButton
            // 
            this.StockINButton.Location = new System.Drawing.Point(174, 20);
            this.StockINButton.Name = "StockINButton";
            this.StockINButton.Size = new System.Drawing.Size(75, 23);
            this.StockINButton.TabIndex = 15;
            this.StockINButton.Text = "Stock In";
            this.StockINButton.UseVisualStyleBackColor = true;
            this.StockINButton.Click += new System.EventHandler(this.StockINButton_Click);
            // 
            // ItemButton
            // 
            this.ItemButton.Location = new System.Drawing.Point(93, 20);
            this.ItemButton.Name = "ItemButton";
            this.ItemButton.Size = new System.Drawing.Size(75, 23);
            this.ItemButton.TabIndex = 16;
            this.ItemButton.Text = "Item";
            this.ItemButton.UseVisualStyleBackColor = true;
            this.ItemButton.Click += new System.EventHandler(this.ItemButton_Click);
            // 
            // CompanyButton
            // 
            this.CompanyButton.Location = new System.Drawing.Point(12, 20);
            this.CompanyButton.Name = "CompanyButton";
            this.CompanyButton.Size = new System.Drawing.Size(75, 23);
            this.CompanyButton.TabIndex = 17;
            this.CompanyButton.Text = "Company";
            this.CompanyButton.UseVisualStyleBackColor = true;
            this.CompanyButton.Click += new System.EventHandler(this.CompanyButton_Click);
            // 
            // StockInSearchButton
            // 
            this.StockInSearchButton.Location = new System.Drawing.Point(336, 20);
            this.StockInSearchButton.Name = "StockInSearchButton";
            this.StockInSearchButton.Size = new System.Drawing.Size(87, 23);
            this.StockInSearchButton.TabIndex = 18;
            this.StockInSearchButton.Text = "Search Items";
            this.StockInSearchButton.UseVisualStyleBackColor = true;
            this.StockInSearchButton.Click += new System.EventHandler(this.StockInSearchButton_Click);
            // 
            // DateWiseSearchButton
            // 
            this.DateWiseSearchButton.Location = new System.Drawing.Point(429, 20);
            this.DateWiseSearchButton.Name = "DateWiseSearchButton";
            this.DateWiseSearchButton.Size = new System.Drawing.Size(87, 23);
            this.DateWiseSearchButton.TabIndex = 19;
            this.DateWiseSearchButton.Text = "Search Sales";
            this.DateWiseSearchButton.UseVisualStyleBackColor = true;
            this.DateWiseSearchButton.Click += new System.EventHandler(this.DateWiseSearchButton_Click);
            // 
            // CategorySetupUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 270);
            this.Controls.Add(this.StockInSearchButton);
            this.Controls.Add(this.DateWiseSearchButton);
            this.Controls.Add(this.StockOutButton);
            this.Controls.Add(this.StockINButton);
            this.Controls.Add(this.ItemButton);
            this.Controls.Add(this.CompanyButton);
            this.Controls.Add(this.showDataGridView);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.categorySetupTextBox);
            this.Controls.Add(this.label1);
            this.Text = "Category Setup";
            ((System.ComponentModel.ISupportInitialize)(this.showDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView showDataGridView;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox categorySetupTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button StockOutButton;
        private System.Windows.Forms.Button StockINButton;
        private System.Windows.Forms.Button ItemButton;
        private System.Windows.Forms.Button CompanyButton;
        private System.Windows.Forms.Button StockInSearchButton;
        private System.Windows.Forms.Button DateWiseSearchButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
    }
}