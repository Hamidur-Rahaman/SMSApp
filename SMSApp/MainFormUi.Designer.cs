namespace SMSApp
{
    partial class MainFormUi
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
            this.CategoryButton = new System.Windows.Forms.Button();
            this.CompanyButton = new System.Windows.Forms.Button();
            this.ItemButton = new System.Windows.Forms.Button();
            this.StockINButton = new System.Windows.Forms.Button();
            this.StockOutButton = new System.Windows.Forms.Button();
            this.StockInSearchButton = new System.Windows.Forms.Button();
            this.DateWiseSearchButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CategoryButton
            // 
            this.CategoryButton.Location = new System.Drawing.Point(15, 78);
            this.CategoryButton.Name = "CategoryButton";
            this.CategoryButton.Size = new System.Drawing.Size(75, 23);
            this.CategoryButton.TabIndex = 0;
            this.CategoryButton.Text = "Category";
            this.CategoryButton.UseVisualStyleBackColor = true;
            this.CategoryButton.Click += new System.EventHandler(this.CategoryButton_Click);
            // 
            // CompanyButton
            // 
            this.CompanyButton.Location = new System.Drawing.Point(96, 78);
            this.CompanyButton.Name = "CompanyButton";
            this.CompanyButton.Size = new System.Drawing.Size(75, 23);
            this.CompanyButton.TabIndex = 0;
            this.CompanyButton.Text = "Company";
            this.CompanyButton.UseVisualStyleBackColor = true;
            this.CompanyButton.Click += new System.EventHandler(this.CompanyButton_Click);
            // 
            // ItemButton
            // 
            this.ItemButton.Location = new System.Drawing.Point(177, 78);
            this.ItemButton.Name = "ItemButton";
            this.ItemButton.Size = new System.Drawing.Size(75, 23);
            this.ItemButton.TabIndex = 0;
            this.ItemButton.Text = "Item";
            this.ItemButton.UseVisualStyleBackColor = true;
            this.ItemButton.Click += new System.EventHandler(this.ItemButton_Click);
            // 
            // StockINButton
            // 
            this.StockINButton.Location = new System.Drawing.Point(258, 78);
            this.StockINButton.Name = "StockINButton";
            this.StockINButton.Size = new System.Drawing.Size(75, 23);
            this.StockINButton.TabIndex = 0;
            this.StockINButton.Text = "Stock In";
            this.StockINButton.UseVisualStyleBackColor = true;
            this.StockINButton.Click += new System.EventHandler(this.StockINButton_Click);
            // 
            // StockOutButton
            // 
            this.StockOutButton.Location = new System.Drawing.Point(339, 78);
            this.StockOutButton.Name = "StockOutButton";
            this.StockOutButton.Size = new System.Drawing.Size(75, 23);
            this.StockOutButton.TabIndex = 0;
            this.StockOutButton.Text = "Stock Out";
            this.StockOutButton.UseVisualStyleBackColor = true;
            this.StockOutButton.Click += new System.EventHandler(this.StockOutButton_Click);
            // 
            // StockInSearchButton
            // 
            this.StockInSearchButton.Location = new System.Drawing.Point(420, 78);
            this.StockInSearchButton.Name = "StockInSearchButton";
            this.StockInSearchButton.Size = new System.Drawing.Size(87, 23);
            this.StockInSearchButton.TabIndex = 48;
            this.StockInSearchButton.Text = "Search Items";
            this.StockInSearchButton.UseVisualStyleBackColor = true;
            this.StockInSearchButton.Click += new System.EventHandler(this.StockInSearchButton_Click);
            // 
            // DateWiseSearchButton
            // 
            this.DateWiseSearchButton.Location = new System.Drawing.Point(513, 78);
            this.DateWiseSearchButton.Name = "DateWiseSearchButton";
            this.DateWiseSearchButton.Size = new System.Drawing.Size(87, 23);
            this.DateWiseSearchButton.TabIndex = 49;
            this.DateWiseSearchButton.Text = "Search Sales";
            this.DateWiseSearchButton.UseVisualStyleBackColor = true;
            this.DateWiseSearchButton.Click += new System.EventHandler(this.DateWiseSearchButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(149, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 31);
            this.label1.TabIndex = 50;
            this.label1.Text = "Stock Management System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(21, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 7);
            this.label2.TabIndex = 51;
            this.label2.Text = "Develop by StarCoders";
            // 
            // MainFormUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 175);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StockInSearchButton);
            this.Controls.Add(this.DateWiseSearchButton);
            this.Controls.Add(this.StockOutButton);
            this.Controls.Add(this.StockINButton);
            this.Controls.Add(this.ItemButton);
            this.Controls.Add(this.CompanyButton);
            this.Controls.Add(this.CategoryButton);
            this.Name = "MainFormUi";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CategoryButton;
        private System.Windows.Forms.Button CompanyButton;
        private System.Windows.Forms.Button ItemButton;
        private System.Windows.Forms.Button StockINButton;
        private System.Windows.Forms.Button StockOutButton;
        private System.Windows.Forms.Button StockInSearchButton;
        private System.Windows.Forms.Button DateWiseSearchButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

