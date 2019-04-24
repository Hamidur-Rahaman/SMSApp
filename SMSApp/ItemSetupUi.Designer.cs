namespace SMSApp
{
    partial class ItemSetupUi
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
            this.components = new System.ComponentModel.Container();
            this.SaveButton = new System.Windows.Forms.Button();
            this.reorderLevelTextBox = new System.Windows.Forms.TextBox();
            this.itemTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.catagoryComboBox = new System.Windows.Forms.ComboBox();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.StockOutButton = new System.Windows.Forms.Button();
            this.StockINButton = new System.Windows.Forms.Button();
            this.CompanyButton = new System.Windows.Forms.Button();
            this.CategoryButton = new System.Windows.Forms.Button();
            this.StockInSearchButton = new System.Windows.Forms.Button();
            this.DateWiseSearchButton = new System.Windows.Forms.Button();
            this.companyComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(440, 209);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 26;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // reorderLevelTextBox
            // 
            this.reorderLevelTextBox.Location = new System.Drawing.Point(286, 169);
            this.reorderLevelTextBox.Name = "reorderLevelTextBox";
            this.reorderLevelTextBox.Size = new System.Drawing.Size(229, 20);
            this.reorderLevelTextBox.TabIndex = 25;
            this.reorderLevelTextBox.Text = "0";
            // 
            // itemTextBox
            // 
            this.itemTextBox.Location = new System.Drawing.Point(286, 131);
            this.itemTextBox.Name = "itemTextBox";
            this.itemTextBox.Size = new System.Drawing.Size(229, 20);
            this.itemTextBox.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(188, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Reorder level";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "item name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Catagory";
            // 
            // catagoryComboBox
            // 
            this.catagoryComboBox.DataSource = this.categoryBindingSource;
            this.catagoryComboBox.DisplayMember = "Name";
            this.catagoryComboBox.FormattingEnabled = true;
            this.catagoryComboBox.Location = new System.Drawing.Point(286, 90);
            this.catagoryComboBox.Name = "catagoryComboBox";
            this.catagoryComboBox.Size = new System.Drawing.Size(229, 21);
            this.catagoryComboBox.TabIndex = 27;
            this.catagoryComboBox.ValueMember = "ID";
            // 
            // StockOutButton
            // 
            this.StockOutButton.Location = new System.Drawing.Point(254, 14);
            this.StockOutButton.Name = "StockOutButton";
            this.StockOutButton.Size = new System.Drawing.Size(75, 23);
            this.StockOutButton.TabIndex = 30;
            this.StockOutButton.Text = "Stock Out";
            this.StockOutButton.UseVisualStyleBackColor = true;
            this.StockOutButton.Click += new System.EventHandler(this.StockOutButton_Click);
            // 
            // StockINButton
            // 
            this.StockINButton.Location = new System.Drawing.Point(173, 14);
            this.StockINButton.Name = "StockINButton";
            this.StockINButton.Size = new System.Drawing.Size(75, 23);
            this.StockINButton.TabIndex = 32;
            this.StockINButton.Text = "Stock In";
            this.StockINButton.UseVisualStyleBackColor = true;
            this.StockINButton.Click += new System.EventHandler(this.StockINButton_Click);
            // 
            // CompanyButton
            // 
            this.CompanyButton.Location = new System.Drawing.Point(92, 14);
            this.CompanyButton.Name = "CompanyButton";
            this.CompanyButton.Size = new System.Drawing.Size(75, 23);
            this.CompanyButton.TabIndex = 34;
            this.CompanyButton.Text = "Company";
            this.CompanyButton.UseVisualStyleBackColor = true;
            this.CompanyButton.Click += new System.EventHandler(this.CompanyButton_Click);
            // 
            // CategoryButton
            // 
            this.CategoryButton.Location = new System.Drawing.Point(11, 14);
            this.CategoryButton.Name = "CategoryButton";
            this.CategoryButton.Size = new System.Drawing.Size(75, 23);
            this.CategoryButton.TabIndex = 35;
            this.CategoryButton.Text = "Category";
            this.CategoryButton.UseVisualStyleBackColor = true;
            this.CategoryButton.Click += new System.EventHandler(this.CategoryButton_Click);
            // 
            // StockInSearchButton
            // 
            this.StockInSearchButton.Location = new System.Drawing.Point(335, 14);
            this.StockInSearchButton.Name = "StockInSearchButton";
            this.StockInSearchButton.Size = new System.Drawing.Size(87, 23);
            this.StockInSearchButton.TabIndex = 50;
            this.StockInSearchButton.Text = "Search Items";
            this.StockInSearchButton.UseVisualStyleBackColor = true;
            this.StockInSearchButton.Click += new System.EventHandler(this.StockInSearchButton_Click);
            // 
            // DateWiseSearchButton
            // 
            this.DateWiseSearchButton.Location = new System.Drawing.Point(428, 14);
            this.DateWiseSearchButton.Name = "DateWiseSearchButton";
            this.DateWiseSearchButton.Size = new System.Drawing.Size(87, 23);
            this.DateWiseSearchButton.TabIndex = 51;
            this.DateWiseSearchButton.Text = "Search Sales";
            this.DateWiseSearchButton.UseVisualStyleBackColor = true;
            this.DateWiseSearchButton.Click += new System.EventHandler(this.DateWiseSearchButton_Click);
            // 
            // companyComboBox
            // 
            this.companyComboBox.DataSource = this.companyBindingSource;
            this.companyComboBox.DisplayMember = "Name";
            this.companyComboBox.FormattingEnabled = true;
            this.companyComboBox.Location = new System.Drawing.Point(286, 52);
            this.companyComboBox.Name = "companyComboBox";
            this.companyComboBox.Size = new System.Drawing.Size(229, 21);
            this.companyComboBox.TabIndex = 28;
            this.companyComboBox.ValueMember = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Company";
            // 
            // ItemSetupUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 246);
            this.Controls.Add(this.StockInSearchButton);
            this.Controls.Add(this.DateWiseSearchButton);
            this.Controls.Add(this.StockOutButton);
            this.Controls.Add(this.StockINButton);
            this.Controls.Add(this.CompanyButton);
            this.Controls.Add(this.CategoryButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.reorderLevelTextBox);
            this.Controls.Add(this.itemTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.companyComboBox);
            this.Controls.Add(this.catagoryComboBox);
            this.Name = "ItemSetupUi";
            this.Text = "ItemSetupUi";
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox reorderLevelTextBox;
        private System.Windows.Forms.TextBox itemTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private System.Windows.Forms.ComboBox catagoryComboBox;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private System.Windows.Forms.Button StockOutButton;
        private System.Windows.Forms.Button StockINButton;
        private System.Windows.Forms.Button CompanyButton;
        private System.Windows.Forms.Button CategoryButton;
        private System.Windows.Forms.Button StockInSearchButton;
        private System.Windows.Forms.Button DateWiseSearchButton;
        private System.Windows.Forms.ComboBox companyComboBox;
        private System.Windows.Forms.Label label2;
    }
}