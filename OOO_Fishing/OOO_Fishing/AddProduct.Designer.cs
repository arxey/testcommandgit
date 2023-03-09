namespace OOO_Fishing
{
    partial class AddProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProduct));
            this.LabelName = new System.Windows.Forms.Label();
            this.LabelCategory = new System.Windows.Forms.Label();
            this.LabelQuantityInStock = new System.Windows.Forms.Label();
            this.LabelMeasure = new System.Windows.Forms.Label();
            this.LabelProvider = new System.Windows.Forms.Label();
            this.LabelCost = new System.Windows.Forms.Label();
            this.LabelDescription = new System.Windows.Forms.Label();
            this.CostText = new System.Windows.Forms.TextBox();
            this.QuantityInStockText = new System.Windows.Forms.TextBox();
            this.MeasureText = new System.Windows.Forms.TextBox();
            this.ProviderText = new System.Windows.Forms.TextBox();
            this.NameText = new System.Windows.Forms.TextBox();
            this.DescriptionRich = new System.Windows.Forms.RichTextBox();
            this.CategoryCombo = new System.Windows.Forms.ComboBox();
            this.ButtonAddProduct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelName.Location = new System.Drawing.Point(47, 9);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(148, 26);
            this.LabelName.TabIndex = 0;
            this.LabelName.Text = "Наименование";
            // 
            // LabelCategory
            // 
            this.LabelCategory.AutoSize = true;
            this.LabelCategory.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelCategory.Location = new System.Drawing.Point(47, 49);
            this.LabelCategory.Name = "LabelCategory";
            this.LabelCategory.Size = new System.Drawing.Size(105, 26);
            this.LabelCategory.TabIndex = 1;
            this.LabelCategory.Text = "Категория";
            // 
            // LabelQuantityInStock
            // 
            this.LabelQuantityInStock.AutoSize = true;
            this.LabelQuantityInStock.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelQuantityInStock.Location = new System.Drawing.Point(47, 92);
            this.LabelQuantityInStock.Name = "LabelQuantityInStock";
            this.LabelQuantityInStock.Size = new System.Drawing.Size(214, 26);
            this.LabelQuantityInStock.TabIndex = 2;
            this.LabelQuantityInStock.Text = "Количество на складе";
            // 
            // LabelMeasure
            // 
            this.LabelMeasure.AutoSize = true;
            this.LabelMeasure.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelMeasure.Location = new System.Drawing.Point(47, 132);
            this.LabelMeasure.Name = "LabelMeasure";
            this.LabelMeasure.Size = new System.Drawing.Size(195, 26);
            this.LabelMeasure.TabIndex = 3;
            this.LabelMeasure.Text = "Единица измерения";
            // 
            // LabelProvider
            // 
            this.LabelProvider.AutoSize = true;
            this.LabelProvider.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelProvider.Location = new System.Drawing.Point(47, 170);
            this.LabelProvider.Name = "LabelProvider";
            this.LabelProvider.Size = new System.Drawing.Size(115, 26);
            this.LabelProvider.TabIndex = 4;
            this.LabelProvider.Text = "Поставщик";
            // 
            // LabelCost
            // 
            this.LabelCost.AutoSize = true;
            this.LabelCost.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelCost.Location = new System.Drawing.Point(45, 212);
            this.LabelCost.Name = "LabelCost";
            this.LabelCost.Size = new System.Drawing.Size(216, 26);
            this.LabelCost.TabIndex = 5;
            this.LabelCost.Text = "Стоимость за единицу";
            // 
            // LabelDescription
            // 
            this.LabelDescription.AutoSize = true;
            this.LabelDescription.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelDescription.Location = new System.Drawing.Point(45, 249);
            this.LabelDescription.Name = "LabelDescription";
            this.LabelDescription.Size = new System.Drawing.Size(104, 26);
            this.LabelDescription.TabIndex = 7;
            this.LabelDescription.Text = "Описание";
            // 
            // CostText
            // 
            this.CostText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.CostText.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CostText.Location = new System.Drawing.Point(269, 209);
            this.CostText.Name = "CostText";
            this.CostText.Size = new System.Drawing.Size(100, 34);
            this.CostText.TabIndex = 8;
            this.CostText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CostText_KeyPress);
            // 
            // QuantityInStockText
            // 
            this.QuantityInStockText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.QuantityInStockText.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuantityInStockText.Location = new System.Drawing.Point(269, 89);
            this.QuantityInStockText.Name = "QuantityInStockText";
            this.QuantityInStockText.Size = new System.Drawing.Size(100, 34);
            this.QuantityInStockText.TabIndex = 9;
            // 
            // MeasureText
            // 
            this.MeasureText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.MeasureText.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MeasureText.Location = new System.Drawing.Point(269, 129);
            this.MeasureText.Name = "MeasureText";
            this.MeasureText.Size = new System.Drawing.Size(100, 34);
            this.MeasureText.TabIndex = 11;
            // 
            // ProviderText
            // 
            this.ProviderText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.ProviderText.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProviderText.Location = new System.Drawing.Point(269, 169);
            this.ProviderText.Name = "ProviderText";
            this.ProviderText.Size = new System.Drawing.Size(100, 34);
            this.ProviderText.TabIndex = 12;
            // 
            // NameText
            // 
            this.NameText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.NameText.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameText.Location = new System.Drawing.Point(269, 9);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(100, 34);
            this.NameText.TabIndex = 14;
            // 
            // DescriptionRich
            // 
            this.DescriptionRich.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.DescriptionRich.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DescriptionRich.Location = new System.Drawing.Point(269, 249);
            this.DescriptionRich.Name = "DescriptionRich";
            this.DescriptionRich.Size = new System.Drawing.Size(100, 96);
            this.DescriptionRich.TabIndex = 15;
            this.DescriptionRich.Text = "";
            // 
            // CategoryCombo
            // 
            this.CategoryCombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.CategoryCombo.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CategoryCombo.FormattingEnabled = true;
            this.CategoryCombo.Items.AddRange(new object[] {
            "SevereLand",
            "Kuusamo",
            "Gamma",
            "Westin",
            "Aquatech",
            "Stinger",
            "LumiCom",
            "Usami",
            "Ultron",
            "Balsax",
            "Momoi"});
            this.CategoryCombo.Location = new System.Drawing.Point(269, 49);
            this.CategoryCombo.Name = "CategoryCombo";
            this.CategoryCombo.Size = new System.Drawing.Size(121, 34);
            this.CategoryCombo.TabIndex = 16;
            // 
            // ButtonAddProduct
            // 
            this.ButtonAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.ButtonAddProduct.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonAddProduct.Location = new System.Drawing.Point(153, 382);
            this.ButtonAddProduct.Name = "ButtonAddProduct";
            this.ButtonAddProduct.Size = new System.Drawing.Size(108, 32);
            this.ButtonAddProduct.TabIndex = 17;
            this.ButtonAddProduct.Text = "Добавить";
            this.ButtonAddProduct.UseVisualStyleBackColor = false;
            this.ButtonAddProduct.Click += new System.EventHandler(this.ButtonAddProduct_Click);
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(409, 450);
            this.Controls.Add(this.ButtonAddProduct);
            this.Controls.Add(this.CategoryCombo);
            this.Controls.Add(this.DescriptionRich);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.ProviderText);
            this.Controls.Add(this.MeasureText);
            this.Controls.Add(this.QuantityInStockText);
            this.Controls.Add(this.CostText);
            this.Controls.Add(this.LabelDescription);
            this.Controls.Add(this.LabelCost);
            this.Controls.Add(this.LabelProvider);
            this.Controls.Add(this.LabelMeasure);
            this.Controls.Add(this.LabelQuantityInStock);
            this.Controls.Add(this.LabelCategory);
            this.Controls.Add(this.LabelName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddProduct";
            this.Text = "Добавить новый продукт";
            this.Load += new System.EventHandler(this.AddProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label LabelCategory;
        private System.Windows.Forms.Label LabelQuantityInStock;
        private System.Windows.Forms.Label LabelMeasure;
        private System.Windows.Forms.Label LabelProvider;
        private System.Windows.Forms.Label LabelCost;
        private System.Windows.Forms.Label LabelDescription;
        private System.Windows.Forms.TextBox CostText;
        private System.Windows.Forms.TextBox QuantityInStockText;
        private System.Windows.Forms.TextBox MeasureText;
        private System.Windows.Forms.TextBox ProviderText;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.RichTextBox DescriptionRich;
        private System.Windows.Forms.ComboBox CategoryCombo;
        private System.Windows.Forms.Button ButtonAddProduct;
    }
}