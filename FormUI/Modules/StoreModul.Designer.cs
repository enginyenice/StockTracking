
namespace FormUI.Modules
{
    partial class StoreModul
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
            this.StoreGridView = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.EditPhoneNumberTxt = new System.Windows.Forms.TextBox();
            this.EditStoreNameTxt = new System.Windows.Forms.TextBox();
            this.EditAddressTxt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CreatePhoneNumberTxt = new System.Windows.Forms.TextBox();
            this.CreateStoreNameTxt = new System.Windows.Forms.TextBox();
            this.CreateAddressTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.StoreGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StoreGridView
            // 
            this.StoreGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StoreGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StoreGridView.Location = new System.Drawing.Point(246, 22);
            this.StoreGridView.Name = "StoreGridView";
            this.StoreGridView.RowTemplate.Height = 25;
            this.StoreGridView.Size = new System.Drawing.Size(747, 543);
            this.StoreGridView.TabIndex = 21;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DeleteBtn);
            this.groupBox2.Controls.Add(this.UpdateBtn);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.EditPhoneNumberTxt);
            this.groupBox2.Controls.Add(this.EditStoreNameTxt);
            this.groupBox2.Controls.Add(this.EditAddressTxt);
            this.groupBox2.Location = new System.Drawing.Point(12, 286);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(228, 279);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Depo Düzenle / Sil";
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(132, 231);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(82, 32);
            this.DeleteBtn.TabIndex = 11;
            this.DeleteBtn.Text = "Sil";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(6, 231);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(84, 32);
            this.UpdateBtn.TabIndex = 7;
            this.UpdateBtn.Text = "Güncelle";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "Telefon";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 15);
            this.label9.TabIndex = 7;
            this.label9.Text = "Firma Adı";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 15);
            this.label10.TabIndex = 7;
            this.label10.Text = "Adres";
            // 
            // EditPhoneNumberTxt
            // 
            this.EditPhoneNumberTxt.Location = new System.Drawing.Point(6, 91);
            this.EditPhoneNumberTxt.Name = "EditPhoneNumberTxt";
            this.EditPhoneNumberTxt.Size = new System.Drawing.Size(206, 23);
            this.EditPhoneNumberTxt.TabIndex = 10;
            // 
            // EditStoreNameTxt
            // 
            this.EditStoreNameTxt.Location = new System.Drawing.Point(6, 42);
            this.EditStoreNameTxt.Name = "EditStoreNameTxt";
            this.EditStoreNameTxt.Size = new System.Drawing.Size(206, 23);
            this.EditStoreNameTxt.TabIndex = 8;
            // 
            // EditAddressTxt
            // 
            this.EditAddressTxt.Location = new System.Drawing.Point(7, 136);
            this.EditAddressTxt.Multiline = true;
            this.EditAddressTxt.Name = "EditAddressTxt";
            this.EditAddressTxt.Size = new System.Drawing.Size(207, 89);
            this.EditAddressTxt.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CreateBtn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.CreatePhoneNumberTxt);
            this.groupBox1.Controls.Add(this.CreateStoreNameTxt);
            this.groupBox1.Controls.Add(this.CreateAddressTxt);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 268);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Depo Ekle";
            // 
            // CreateBtn
            // 
            this.CreateBtn.Location = new System.Drawing.Point(6, 227);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(207, 33);
            this.CreateBtn.TabIndex = 7;
            this.CreateBtn.Text = "Kayıt Et";
            this.CreateBtn.UseVisualStyleBackColor = true;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Telefon";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Depo Adı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Adres";
            // 
            // CreatePhoneNumberTxt
            // 
            this.CreatePhoneNumberTxt.Location = new System.Drawing.Point(6, 85);
            this.CreatePhoneNumberTxt.Name = "CreatePhoneNumberTxt";
            this.CreatePhoneNumberTxt.Size = new System.Drawing.Size(207, 23);
            this.CreatePhoneNumberTxt.TabIndex = 10;
            // 
            // CreateStoreNameTxt
            // 
            this.CreateStoreNameTxt.Location = new System.Drawing.Point(6, 37);
            this.CreateStoreNameTxt.Name = "CreateStoreNameTxt";
            this.CreateStoreNameTxt.Size = new System.Drawing.Size(207, 23);
            this.CreateStoreNameTxt.TabIndex = 8;
            // 
            // CreateAddressTxt
            // 
            this.CreateAddressTxt.Location = new System.Drawing.Point(6, 132);
            this.CreateAddressTxt.Multiline = true;
            this.CreateAddressTxt.Name = "CreateAddressTxt";
            this.CreateAddressTxt.Size = new System.Drawing.Size(207, 89);
            this.CreateAddressTxt.TabIndex = 8;
            // 
            // StoreModul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 577);
            this.Controls.Add(this.StoreGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "StoreModul";
            this.Text = "StoreModul";
            this.Load += new System.EventHandler(this.StoreModul_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StoreGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView StoreGridView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox EditPhoneNumberTxt;
        private System.Windows.Forms.TextBox EditStoreNameTxt;
        private System.Windows.Forms.TextBox EditAddressTxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        protected System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CreatePhoneNumberTxt;
        private System.Windows.Forms.TextBox CreateStoreNameTxt;
        private System.Windows.Forms.TextBox CreateAddressTxt;
    }
}