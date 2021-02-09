
namespace FormUI.Modules
{
    partial class CustomerModul
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
            this.CustomerGridView = new System.Windows.Forms.DataGridView();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.EditPhoneNumberTxt = new System.Windows.Forms.TextBox();
            this.EditCompanyNameTxt = new System.Windows.Forms.TextBox();
            this.EditEMailTxt = new System.Windows.Forms.TextBox();
            this.EditLastNameTxt = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.EditFirstNameTxt = new System.Windows.Forms.TextBox();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CreatePhoneNumberTxt = new System.Windows.Forms.TextBox();
            this.CreateCompanyNameTxt = new System.Windows.Forms.TextBox();
            this.CreateEMailTxt = new System.Windows.Forms.TextBox();
            this.CreateLastNameTxt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CreateFirstNameTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustomerGridView
            // 
            this.CustomerGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerGridView.Location = new System.Drawing.Point(246, 12);
            this.CustomerGridView.Name = "CustomerGridView";
            this.CustomerGridView.RowTemplate.Height = 25;
            this.CustomerGridView.Size = new System.Drawing.Size(773, 560);
            this.CustomerGridView.TabIndex = 15;
            this.CustomerGridView.SelectionChanged += new System.EventHandler(this.CustomerGridView_SelectionChanged);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(130, 247);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(82, 32);
            this.DeleteBtn.TabIndex = 11;
            this.DeleteBtn.Text = "Sil";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(6, 247);
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
            this.label8.Location = new System.Drawing.Point(6, 200);
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
            this.label10.Location = new System.Drawing.Point(6, 156);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 15);
            this.label10.TabIndex = 7;
            this.label10.Text = "E-Posta";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 112);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 15);
            this.label11.TabIndex = 5;
            this.label11.Text = "Soyad";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 68);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(22, 15);
            this.label12.TabIndex = 0;
            this.label12.Text = "Ad";
            // 
            // EditPhoneNumberTxt
            // 
            this.EditPhoneNumberTxt.Location = new System.Drawing.Point(6, 218);
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
            this.EditEMailTxt.Location = new System.Drawing.Point(6, 174);
            this.EditEMailTxt.Name = "EditEMailTxt";
            this.EditEMailTxt.Size = new System.Drawing.Size(206, 23);
            this.EditEMailTxt.TabIndex = 8;
            // 
            // EditLastNameTxt
            // 
            this.EditLastNameTxt.Location = new System.Drawing.Point(6, 130);
            this.EditLastNameTxt.Name = "EditLastNameTxt";
            this.EditLastNameTxt.Size = new System.Drawing.Size(206, 23);
            this.EditLastNameTxt.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DeleteBtn);
            this.groupBox2.Controls.Add(this.UpdateBtn);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.EditPhoneNumberTxt);
            this.groupBox2.Controls.Add(this.EditCompanyNameTxt);
            this.groupBox2.Controls.Add(this.EditEMailTxt);
            this.groupBox2.Controls.Add(this.EditLastNameTxt);
            this.groupBox2.Controls.Add(this.EditFirstNameTxt);
            this.groupBox2.Location = new System.Drawing.Point(12, 302);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(228, 302);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kullanıcı Düzenle / Sil";
            // 
            // EditFirstNameTxt
            // 
            this.EditFirstNameTxt.Location = new System.Drawing.Point(6, 86);
            this.EditFirstNameTxt.Name = "EditFirstNameTxt";
            this.EditFirstNameTxt.Size = new System.Drawing.Size(206, 23);
            this.EditFirstNameTxt.TabIndex = 4;
            // 
            // CreateBtn
            // 
            this.CreateBtn.Location = new System.Drawing.Point(6, 240);
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
            this.label3.Location = new System.Drawing.Point(6, 193);
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
            this.label4.Location = new System.Drawing.Point(6, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "E-Posta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad";
            // 
            // CreatePhoneNumberTxt
            // 
            this.CreatePhoneNumberTxt.Location = new System.Drawing.Point(6, 211);
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
            this.CreateEMailTxt.Location = new System.Drawing.Point(6, 168);
            this.CreateEMailTxt.Name = "CreateEMailTxt";
            this.CreateEMailTxt.Size = new System.Drawing.Size(207, 23);
            this.CreateEMailTxt.TabIndex = 8;
            // 
            // CreateLastNameTxt
            // 
            this.CreateLastNameTxt.Location = new System.Drawing.Point(6, 125);
            this.CreateLastNameTxt.Name = "CreateLastNameTxt";
            this.CreateLastNameTxt.Size = new System.Drawing.Size(207, 23);
            this.CreateLastNameTxt.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CreateBtn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CreatePhoneNumberTxt);
            this.groupBox1.Controls.Add(this.CreateCompanyNameTxt);
            this.groupBox1.Controls.Add(this.CreateEMailTxt);
            this.groupBox1.Controls.Add(this.CreateLastNameTxt);
            this.groupBox1.Controls.Add(this.CreateFirstNameTxt);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 284);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Ekle";
            // 
            // CreateFirstNameTxt
            // 
            this.CreateFirstNameTxt.Location = new System.Drawing.Point(6, 81);
            this.CreateFirstNameTxt.Name = "CreateFirstNameTxt";
            this.CreateFirstNameTxt.Size = new System.Drawing.Size(207, 23);
            this.CreateFirstNameTxt.TabIndex = 4;
            // 
            // CustomerModul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 584);
            this.Controls.Add(this.CustomerGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CustomerModul";
            this.Text = "CustomerModul";
            this.Load += new System.EventHandler(this.CustomerModul_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView CustomerGridView;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox EditPhoneNumberTxt;
        private System.Windows.Forms.TextBox EditCompanyNameTxt;
        private System.Windows.Forms.TextBox EditEMailTxt;
        private System.Windows.Forms.TextBox EditLastNameTxt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox EditFirstNameTxt;
        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CreatePhoneNumberTxt;
        private System.Windows.Forms.TextBox CreateCompanyNameTxt;
        private System.Windows.Forms.TextBox CreateEMailTxt;
        private System.Windows.Forms.TextBox CreateLastNameTxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox CreateFirstNameTxt;
        protected System.Windows.Forms.Label label4;
    }
}