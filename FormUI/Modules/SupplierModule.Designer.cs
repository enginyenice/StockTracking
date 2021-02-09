
namespace FormUI.Modules
{
    partial class SupplierModule
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
            this.CreateBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CreatePhoneNumberTxt = new System.Windows.Forms.TextBox();
            this.CreateCompanyNameTxt = new System.Windows.Forms.TextBox();
            this.CreateEMailTxt = new System.Windows.Forms.TextBox();
            this.SupplierGridView = new System.Windows.Forms.DataGridView();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.EditPhoneNumberTxt = new System.Windows.Forms.TextBox();
            this.EditCompanyNameTxt = new System.Windows.Forms.TextBox();
            this.EditEMailTxt = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.SupplierGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateBtn
            // 
            this.CreateBtn.Location = new System.Drawing.Point(6, 158);
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
            this.label3.Location = new System.Drawing.Point(6, 111);
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
            this.label6.Size = new System.Drawing.Size(58, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Firma Adı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "E-Posta";
            // 
            // CreatePhoneNumberTxt
            // 
            this.CreatePhoneNumberTxt.Location = new System.Drawing.Point(6, 129);
            this.CreatePhoneNumberTxt.Name = "CreatePhoneNumberTxt";
            this.CreatePhoneNumberTxt.Size = new System.Drawing.Size(207, 23);
            this.CreatePhoneNumberTxt.TabIndex = 10;
            // 
            // CreateCompanyNameTxt
            // 
            this.CreateCompanyNameTxt.Location = new System.Drawing.Point(6, 37);
            this.CreateCompanyNameTxt.Name = "CreateCompanyNameTxt";
            this.CreateCompanyNameTxt.Size = new System.Drawing.Size(207, 23);
            this.CreateCompanyNameTxt.TabIndex = 8;
            // 
            // CreateEMailTxt
            // 
            this.CreateEMailTxt.Location = new System.Drawing.Point(6, 86);
            this.CreateEMailTxt.Name = "CreateEMailTxt";
            this.CreateEMailTxt.Size = new System.Drawing.Size(207, 23);
            this.CreateEMailTxt.TabIndex = 8;
            // 
            // SupplierGridView
            // 
            this.SupplierGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SupplierGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SupplierGridView.Location = new System.Drawing.Point(236, 12);
            this.SupplierGridView.Name = "SupplierGridView";
            this.SupplierGridView.RowTemplate.Height = 25;
            this.SupplierGridView.Size = new System.Drawing.Size(813, 408);
            this.SupplierGridView.TabIndex = 18;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(130, 162);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(82, 32);
            this.DeleteBtn.TabIndex = 11;
            this.DeleteBtn.Text = "Sil";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(6, 162);
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
            this.label8.Location = new System.Drawing.Point(6, 115);
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
            this.label10.Location = new System.Drawing.Point(6, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 15);
            this.label10.TabIndex = 7;
            this.label10.Text = "E-Posta";
            // 
            // EditPhoneNumberTxt
            // 
            this.EditPhoneNumberTxt.Location = new System.Drawing.Point(6, 133);
            this.EditPhoneNumberTxt.Name = "EditPhoneNumberTxt";
            this.EditPhoneNumberTxt.Size = new System.Drawing.Size(206, 23);
            this.EditPhoneNumberTxt.TabIndex = 10;
            // 
            // EditCompanyNameTxt
            // 
            this.EditCompanyNameTxt.Location = new System.Drawing.Point(6, 42);
            this.EditCompanyNameTxt.Name = "EditCompanyNameTxt";
            this.EditCompanyNameTxt.Size = new System.Drawing.Size(206, 23);
            this.EditCompanyNameTxt.TabIndex = 8;
            // 
            // EditEMailTxt
            // 
            this.EditEMailTxt.Location = new System.Drawing.Point(6, 89);
            this.EditEMailTxt.Name = "EditEMailTxt";
            this.EditEMailTxt.Size = new System.Drawing.Size(206, 23);
            this.EditEMailTxt.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DeleteBtn);
            this.groupBox2.Controls.Add(this.UpdateBtn);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.EditPhoneNumberTxt);
            this.groupBox2.Controls.Add(this.EditCompanyNameTxt);
            this.groupBox2.Controls.Add(this.EditEMailTxt);
            this.groupBox2.Location = new System.Drawing.Point(2, 211);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(228, 209);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tedarikçi Düzenle / Sil";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CreateBtn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.CreatePhoneNumberTxt);
            this.groupBox1.Controls.Add(this.CreateCompanyNameTxt);
            this.groupBox1.Controls.Add(this.CreateEMailTxt);
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 203);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tedarikçi Ekle";
            // 
            // SupplierModul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 425);
            this.Controls.Add(this.SupplierGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SupplierModul";
            this.Text = "SupplierModul";
            this.Load += new System.EventHandler(this.SupplierModul_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SupplierGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        protected System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CreatePhoneNumberTxt;
        private System.Windows.Forms.TextBox CreateCompanyNameTxt;
        private System.Windows.Forms.TextBox CreateEMailTxt;
        private System.Windows.Forms.DataGridView SupplierGridView;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox EditPhoneNumberTxt;
        private System.Windows.Forms.TextBox EditCompanyNameTxt;
        private System.Windows.Forms.TextBox EditEMailTxt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}