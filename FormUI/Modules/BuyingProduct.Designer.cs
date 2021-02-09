
namespace FormUI.Modules
{
    partial class BuyingProduct
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
            this.ProductList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SupplierList = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.StoreList = new System.Windows.Forms.ComboBox();
            this.UnitPriceTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PieceeTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TotalPriceTxt = new System.Windows.Forms.TextBox();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProductList
            // 
            this.ProductList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProductList.FormattingEnabled = true;
            this.ProductList.Location = new System.Drawing.Point(12, 34);
            this.ProductList.Name = "ProductList";
            this.ProductList.Size = new System.Drawing.Size(170, 23);
            this.ProductList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ürün";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tedarikçi";
            // 
            // SupplierList
            // 
            this.SupplierList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SupplierList.FormattingEnabled = true;
            this.SupplierList.Location = new System.Drawing.Point(190, 34);
            this.SupplierList.Name = "SupplierList";
            this.SupplierList.Size = new System.Drawing.Size(170, 23);
            this.SupplierList.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(366, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Depo";
            // 
            // StoreList
            // 
            this.StoreList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StoreList.FormattingEnabled = true;
            this.StoreList.Location = new System.Drawing.Point(366, 34);
            this.StoreList.Name = "StoreList";
            this.StoreList.Size = new System.Drawing.Size(170, 23);
            this.StoreList.TabIndex = 9;
            // 
            // UnitPriceTxt
            // 
            this.UnitPriceTxt.Location = new System.Drawing.Point(12, 83);
            this.UnitPriceTxt.Name = "UnitPriceTxt";
            this.UnitPriceTxt.Size = new System.Drawing.Size(170, 23);
            this.UnitPriceTxt.TabIndex = 11;
            this.UnitPriceTxt.Text = "1";
            this.UnitPriceTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UnitPriceTxt_KeyPress);
            this.UnitPriceTxt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.UnitPriceTxt_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Birim Fiyatı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(190, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Adet";
            // 
            // PieceeTxt
            // 
            this.PieceeTxt.Location = new System.Drawing.Point(190, 83);
            this.PieceeTxt.Name = "PieceeTxt";
            this.PieceeTxt.Size = new System.Drawing.Size(170, 23);
            this.PieceeTxt.TabIndex = 13;
            this.PieceeTxt.Text = "1";
            this.PieceeTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PieceeTxt_KeyPress);
            this.PieceeTxt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PieceeTxt_KeyUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(366, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Toplam Fiyat";
            // 
            // TotalPriceTxt
            // 
            this.TotalPriceTxt.Enabled = false;
            this.TotalPriceTxt.Location = new System.Drawing.Point(366, 83);
            this.TotalPriceTxt.Name = "TotalPriceTxt";
            this.TotalPriceTxt.Size = new System.Drawing.Size(170, 23);
            this.TotalPriceTxt.TabIndex = 16;
            // 
            // CreateBtn
            // 
            this.CreateBtn.Location = new System.Drawing.Point(556, 34);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(156, 72);
            this.CreateBtn.TabIndex = 17;
            this.CreateBtn.Text = "Ürün Al";
            this.CreateBtn.UseVisualStyleBackColor = true;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // BuyingProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 136);
            this.Controls.Add(this.CreateBtn);
            this.Controls.Add(this.TotalPriceTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PieceeTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UnitPriceTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.StoreList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SupplierList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProductList);
            this.Name = "BuyingProduct";
            this.Text = "BuyingProduct";
            this.Load += new System.EventHandler(this.BuyingProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ProductList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox SupplierList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox StoreList;
        private System.Windows.Forms.TextBox UnitPriceTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PieceeTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TotalPriceTxt;
        private System.Windows.Forms.Button CreateBtn;
    }
}