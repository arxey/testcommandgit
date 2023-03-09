namespace OOO_Fishing
{
    partial class Goods
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Goods));
            this.PanelTop = new System.Windows.Forms.Panel();
            this.FishingPicture = new System.Windows.Forms.PictureBox();
            this.LabelFishing = new System.Windows.Forms.Label();
            this.PanelBottom = new System.Windows.Forms.Panel();
            this.PanelAvailable = new System.Windows.Forms.Panel();
            this.LabelAvailable = new System.Windows.Forms.Label();
            this.PanelInfo = new System.Windows.Forms.Panel();
            this.LabelPrice = new System.Windows.Forms.Label();
            this.LabelManufacturer = new System.Windows.Forms.Label();
            this.LabelDescription = new System.Windows.Forms.Label();
            this.LabelName = new System.Windows.Forms.Label();
            this.PicturePlug = new System.Windows.Forms.PictureBox();
            this.PanelExtra = new System.Windows.Forms.Panel();
            this.LabelAll = new System.Windows.Forms.Label();
            this.LabelFrom = new System.Windows.Forms.Label();
            this.LabelCount = new System.Windows.Forms.Label();
            this.AddProductButton = new System.Windows.Forms.Button();
            this.ComboBoxFilter = new System.Windows.Forms.ComboBox();
            this.SearchText = new System.Windows.Forms.TextBox();
            this.LabelSearch = new System.Windows.Forms.Label();
            this.GoodsView = new System.Windows.Forms.DataGridView();
            this.ContextMenuOrder = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FishingPicture)).BeginInit();
            this.PanelBottom.SuspendLayout();
            this.PanelAvailable.SuspendLayout();
            this.PanelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicturePlug)).BeginInit();
            this.PanelExtra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GoodsView)).BeginInit();
            this.ContextMenuOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelTop
            // 
            this.PanelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.PanelTop.Controls.Add(this.FishingPicture);
            this.PanelTop.Controls.Add(this.LabelFishing);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.Location = new System.Drawing.Point(0, 0);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(800, 43);
            this.PanelTop.TabIndex = 0;
            // 
            // FishingPicture
            // 
            this.FishingPicture.Image = ((System.Drawing.Image)(resources.GetObject("FishingPicture.Image")));
            this.FishingPicture.Location = new System.Drawing.Point(3, 3);
            this.FishingPicture.Name = "FishingPicture";
            this.FishingPicture.Size = new System.Drawing.Size(40, 40);
            this.FishingPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FishingPicture.TabIndex = 3;
            this.FishingPicture.TabStop = false;
            // 
            // LabelFishing
            // 
            this.LabelFishing.AutoSize = true;
            this.LabelFishing.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelFishing.Location = new System.Drawing.Point(323, 9);
            this.LabelFishing.Name = "LabelFishing";
            this.LabelFishing.Size = new System.Drawing.Size(155, 26);
            this.LabelFishing.TabIndex = 2;
            this.LabelFishing.Text = "ООО \"Рыбалка\"";
            // 
            // PanelBottom
            // 
            this.PanelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.PanelBottom.Controls.Add(this.PanelAvailable);
            this.PanelBottom.Controls.Add(this.PanelInfo);
            this.PanelBottom.Controls.Add(this.PicturePlug);
            this.PanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelBottom.Location = new System.Drawing.Point(0, 322);
            this.PanelBottom.Name = "PanelBottom";
            this.PanelBottom.Size = new System.Drawing.Size(800, 128);
            this.PanelBottom.TabIndex = 1;
            // 
            // PanelAvailable
            // 
            this.PanelAvailable.Controls.Add(this.LabelAvailable);
            this.PanelAvailable.Location = new System.Drawing.Point(651, 3);
            this.PanelAvailable.Name = "PanelAvailable";
            this.PanelAvailable.Size = new System.Drawing.Size(146, 121);
            this.PanelAvailable.TabIndex = 2;
            // 
            // LabelAvailable
            // 
            this.LabelAvailable.AutoSize = true;
            this.LabelAvailable.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelAvailable.Location = new System.Drawing.Point(11, 29);
            this.LabelAvailable.Name = "LabelAvailable";
            this.LabelAvailable.Size = new System.Drawing.Size(126, 52);
            this.LabelAvailable.TabIndex = 0;
            this.LabelAvailable.Text = "Наличие на \r\nскладе";
            this.LabelAvailable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelInfo
            // 
            this.PanelInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelInfo.Controls.Add(this.LabelPrice);
            this.PanelInfo.Controls.Add(this.LabelManufacturer);
            this.PanelInfo.Controls.Add(this.LabelDescription);
            this.PanelInfo.Controls.Add(this.LabelName);
            this.PanelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PanelInfo.Location = new System.Drawing.Point(133, 3);
            this.PanelInfo.Name = "PanelInfo";
            this.PanelInfo.Size = new System.Drawing.Size(512, 122);
            this.PanelInfo.TabIndex = 1;
            // 
            // LabelPrice
            // 
            this.LabelPrice.AutoSize = true;
            this.LabelPrice.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelPrice.Location = new System.Drawing.Point(3, 79);
            this.LabelPrice.Name = "LabelPrice";
            this.LabelPrice.Size = new System.Drawing.Size(64, 26);
            this.LabelPrice.TabIndex = 3;
            this.LabelPrice.Text = "Цена:";
            // 
            // LabelManufacturer
            // 
            this.LabelManufacturer.AutoSize = true;
            this.LabelManufacturer.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelManufacturer.Location = new System.Drawing.Point(3, 53);
            this.LabelManufacturer.Name = "LabelManufacturer";
            this.LabelManufacturer.Size = new System.Drawing.Size(160, 26);
            this.LabelManufacturer.TabIndex = 2;
            this.LabelManufacturer.Text = "Производитель:";
            // 
            // LabelDescription
            // 
            this.LabelDescription.AutoSize = true;
            this.LabelDescription.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelDescription.Location = new System.Drawing.Point(3, 27);
            this.LabelDescription.Name = "LabelDescription";
            this.LabelDescription.Size = new System.Drawing.Size(170, 26);
            this.LabelDescription.TabIndex = 1;
            this.LabelDescription.Text = "Описание товара";
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelName.Location = new System.Drawing.Point(3, 0);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(222, 27);
            this.LabelName.TabIndex = 0;
            this.LabelName.Text = "Наименование товара";
            // 
            // PicturePlug
            // 
            this.PicturePlug.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PicturePlug.Image = ((System.Drawing.Image)(resources.GetObject("PicturePlug.Image")));
            this.PicturePlug.Location = new System.Drawing.Point(3, 3);
            this.PicturePlug.Name = "PicturePlug";
            this.PicturePlug.Size = new System.Drawing.Size(124, 121);
            this.PicturePlug.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicturePlug.TabIndex = 0;
            this.PicturePlug.TabStop = false;
            // 
            // PanelExtra
            // 
            this.PanelExtra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.PanelExtra.Controls.Add(this.LabelAll);
            this.PanelExtra.Controls.Add(this.LabelFrom);
            this.PanelExtra.Controls.Add(this.LabelCount);
            this.PanelExtra.Controls.Add(this.AddProductButton);
            this.PanelExtra.Controls.Add(this.ComboBoxFilter);
            this.PanelExtra.Controls.Add(this.SearchText);
            this.PanelExtra.Controls.Add(this.LabelSearch);
            this.PanelExtra.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelExtra.Location = new System.Drawing.Point(0, 43);
            this.PanelExtra.Name = "PanelExtra";
            this.PanelExtra.Size = new System.Drawing.Size(800, 46);
            this.PanelExtra.TabIndex = 2;
            // 
            // LabelAll
            // 
            this.LabelAll.AutoSize = true;
            this.LabelAll.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelAll.Location = new System.Drawing.Point(709, 14);
            this.LabelAll.Name = "LabelAll";
            this.LabelAll.Size = new System.Drawing.Size(65, 26);
            this.LabelAll.TabIndex = 6;
            this.LabelAll.Text = "label2";
            // 
            // LabelFrom
            // 
            this.LabelFrom.AutoSize = true;
            this.LabelFrom.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelFrom.Location = new System.Drawing.Point(671, 14);
            this.LabelFrom.Name = "LabelFrom";
            this.LabelFrom.Size = new System.Drawing.Size(32, 26);
            this.LabelFrom.TabIndex = 5;
            this.LabelFrom.Text = "из";
            // 
            // LabelCount
            // 
            this.LabelCount.AutoSize = true;
            this.LabelCount.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelCount.Location = new System.Drawing.Point(623, 14);
            this.LabelCount.Name = "LabelCount";
            this.LabelCount.Size = new System.Drawing.Size(42, 26);
            this.LabelCount.TabIndex = 4;
            this.LabelCount.Text = "***";
            // 
            // AddProductButton
            // 
            this.AddProductButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.AddProductButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddProductButton.Location = new System.Drawing.Point(510, 5);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(107, 35);
            this.AddProductButton.TabIndex = 3;
            this.AddProductButton.Text = "Добавить";
            this.AddProductButton.UseVisualStyleBackColor = false;
            this.AddProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // ComboBoxFilter
            // 
            this.ComboBoxFilter.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComboBoxFilter.FormattingEnabled = true;
            this.ComboBoxFilter.Items.AddRange(new object[] {
            "Все производители",
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
            this.ComboBoxFilter.Location = new System.Drawing.Point(328, 6);
            this.ComboBoxFilter.Name = "ComboBoxFilter";
            this.ComboBoxFilter.Size = new System.Drawing.Size(121, 34);
            this.ComboBoxFilter.TabIndex = 2;
            this.ComboBoxFilter.SelectedIndexChanged += new System.EventHandler(this.ComboBoxFilter_SelectedIndexChanged);
            // 
            // SearchText
            // 
            this.SearchText.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchText.Location = new System.Drawing.Point(89, 6);
            this.SearchText.Multiline = true;
            this.SearchText.Name = "SearchText";
            this.SearchText.Size = new System.Drawing.Size(118, 34);
            this.SearchText.TabIndex = 1;
            this.SearchText.TextChanged += new System.EventHandler(this.SearchText_TextChanged);
            // 
            // LabelSearch
            // 
            this.LabelSearch.AutoSize = true;
            this.LabelSearch.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelSearch.Location = new System.Drawing.Point(12, 9);
            this.LabelSearch.Name = "LabelSearch";
            this.LabelSearch.Size = new System.Drawing.Size(71, 26);
            this.LabelSearch.TabIndex = 0;
            this.LabelSearch.Text = "Поиск";
            // 
            // GoodsView
            // 
            this.GoodsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GoodsView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GoodsView.Location = new System.Drawing.Point(0, 89);
            this.GoodsView.Name = "GoodsView";
            this.GoodsView.Size = new System.Drawing.Size(800, 233);
            this.GoodsView.TabIndex = 3;
            this.GoodsView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GoodsView_CellClick);
            this.GoodsView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GoodsView_MouseDown);
            // 
            // ContextMenuOrder
            // 
            this.ContextMenuOrder.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ContextMenuOrder.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemEdit});
            this.ContextMenuOrder.Name = "ContextMenuOrder";
            this.ContextMenuOrder.Size = new System.Drawing.Size(125, 26);
            // 
            // ToolStripMenuItemEdit
            // 
            this.ToolStripMenuItemEdit.Name = "ToolStripMenuItemEdit";
            this.ToolStripMenuItemEdit.Size = new System.Drawing.Size(124, 22);
            this.ToolStripMenuItemEdit.Text = "Изменить";
            this.ToolStripMenuItemEdit.Click += new System.EventHandler(this.ToolStripMenuItemEdit_Click);
            // 
            // Goods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GoodsView);
            this.Controls.Add(this.PanelExtra);
            this.Controls.Add(this.PanelBottom);
            this.Controls.Add(this.PanelTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Goods";
            this.Text = "Товары";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Goods_FormClosing);
            this.Load += new System.EventHandler(this.Goods_Load);
            this.PanelTop.ResumeLayout(false);
            this.PanelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FishingPicture)).EndInit();
            this.PanelBottom.ResumeLayout(false);
            this.PanelAvailable.ResumeLayout(false);
            this.PanelAvailable.PerformLayout();
            this.PanelInfo.ResumeLayout(false);
            this.PanelInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicturePlug)).EndInit();
            this.PanelExtra.ResumeLayout(false);
            this.PanelExtra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GoodsView)).EndInit();
            this.ContextMenuOrder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelTop;
        private System.Windows.Forms.Panel PanelBottom;
        private System.Windows.Forms.Panel PanelExtra;
        private System.Windows.Forms.Label LabelFishing;
        private System.Windows.Forms.PictureBox FishingPicture;
        private System.Windows.Forms.PictureBox PicturePlug;
        private System.Windows.Forms.TextBox SearchText;
        private System.Windows.Forms.Label LabelSearch;
        private System.Windows.Forms.ComboBox ComboBoxFilter;
        private System.Windows.Forms.Panel PanelInfo;
        private System.Windows.Forms.Label LabelPrice;
        private System.Windows.Forms.Label LabelManufacturer;
        private System.Windows.Forms.Label LabelDescription;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label LabelAll;
        private System.Windows.Forms.Label LabelFrom;
        private System.Windows.Forms.Label LabelCount;
        private System.Windows.Forms.Button AddProductButton;
        private System.Windows.Forms.DataGridView GoodsView;
        private System.Windows.Forms.Panel PanelAvailable;
        private System.Windows.Forms.Label LabelAvailable;
        private System.Windows.Forms.ContextMenuStrip ContextMenuOrder;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemEdit;
    }
}