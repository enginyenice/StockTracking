
namespace FormUI.Modules
{
    partial class ProductTransferModule
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
            this.TransferBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.StoreTransferList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.StoreList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ProductList = new System.Windows.Forms.ComboBox();
            this.PieeceNumber = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.PieeceNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // TransferBtn
            // 
            this.TransferBtn.Location = new System.Drawing.Point(362, 28);
            this.TransferBtn.Name = "TransferBtn";
            this.TransferBtn.Size = new System.Drawing.Size(156, 72);
            this.TransferBtn.TabIndex = 30;
            this.TransferBtn.Text = "Transfer Et";
            this.TransferBtn.UseVisualStyleBackColor = true;
            this.TransferBtn.Click += new System.EventHandler(this.TransferBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(183, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 15);
            this.label5.TabIndex = 27;
            this.label5.Text = "Adet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 15);
            this.label4.TabIndex = 23;
            this.label4.Text = "Transfer Edilecek Depo";
            // 
            // StoreTransferList
            // 
            this.StoreTransferList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StoreTransferList.FormattingEnabled = true;
            this.StoreTransferList.Location = new System.Drawing.Point(8, 77);
            this.StoreTransferList.Name = "StoreTransferList";
            this.StoreTransferList.Size = new System.Drawing.Size(170, 23);
            this.StoreTransferList.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "Depo";
            // 
            // StoreList
            // 
            this.StoreList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StoreList.FormattingEnabled = true;
            this.StoreList.Location = new System.Drawing.Point(186, 28);
            this.StoreList.Name = "StoreList";
            this.StoreList.Size = new System.Drawing.Size(170, 23);
            this.StoreList.TabIndex = 20;
            this.StoreList.SelectedIndexChanged += new System.EventHandler(this.StoreList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "Ürün";
            // 
            // ProductList
            // 
            this.ProductList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProductList.FormattingEnabled = true;
            this.ProductList.Location = new System.Drawing.Point(8, 28);
            this.ProductList.Name = "ProductList";
            this.ProductList.Size = new System.Drawing.Size(170, 23);
            this.ProductList.TabIndex = 18;
            this.ProductList.SelectedIndexChanged += new System.EventHandler(this.ProductList_SelectedIndexChanged);
            // 
            // PieeceNumber
            // 
            this.PieeceNumber.Location = new System.Drawing.Point(187, 77);
            this.PieeceNumber.Name = "PieeceNumber";
            this.PieeceNumber.Size = new System.Drawing.Size(169, 23);
            this.PieeceNumber.TabIndex = 32;
            // 
            // ProductTransferModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 127);
            this.Controls.Add(this.PieeceNumber);
            this.Controls.Add(this.TransferBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.StoreTransferList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StoreList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProductList);
            this.Name = "ProductTransferModule";
            this.Text = "ProductTransferModule";
            this.Load += new System.EventHandler(this.ProductTransferModule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PieeceNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TransferBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox StoreTransferList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox StoreList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ProductList;
        private System.Windows.Forms.NumericUpDown PieeceNumber;
    }
}