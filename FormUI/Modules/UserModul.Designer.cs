
namespace FormUI.Modules
{
    partial class UserModul
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
            this.CreateFirstNameTxt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CreatePasswordTxt = new System.Windows.Forms.TextBox();
            this.CreatePhoneNumberTxt = new System.Windows.Forms.TextBox();
            this.CreateUserNameTxt = new System.Windows.Forms.TextBox();
            this.CreateEMailTxt = new System.Windows.Forms.TextBox();
            this.CreateLastNameTxt = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.EditPasswordTxt = new System.Windows.Forms.TextBox();
            this.EditPhoneNumberTxt = new System.Windows.Forms.TextBox();
            this.EditUserNameTxt = new System.Windows.Forms.TextBox();
            this.EditEMailTxt = new System.Windows.Forms.TextBox();
            this.EditLastNameTxt = new System.Windows.Forms.TextBox();
            this.EditFirstNameTxt = new System.Windows.Forms.TextBox();
            this.UserGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateFirstNameTxt
            // 
            this.CreateFirstNameTxt.Location = new System.Drawing.Point(6, 36);
            this.CreateFirstNameTxt.Name = "CreateFirstNameTxt";
            this.CreateFirstNameTxt.Size = new System.Drawing.Size(207, 23);
            this.CreateFirstNameTxt.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CreateBtn);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CreatePasswordTxt);
            this.groupBox1.Controls.Add(this.CreatePhoneNumberTxt);
            this.groupBox1.Controls.Add(this.CreateUserNameTxt);
            this.groupBox1.Controls.Add(this.CreateEMailTxt);
            this.groupBox1.Controls.Add(this.CreateLastNameTxt);
            this.groupBox1.Controls.Add(this.CreateFirstNameTxt);
            this.groupBox1.Location = new System.Drawing.Point(4, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 320);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanıcı Ekle";
            // 
            // CreateBtn
            // 
            this.CreateBtn.Location = new System.Drawing.Point(6, 287);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(207, 33);
            this.CreateBtn.TabIndex = 7;
            this.CreateBtn.Text = "Kayıt Et";
            this.CreateBtn.UseVisualStyleBackColor = true;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Şifre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Telefon";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Kullanıcı Adı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "E-Posta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad";
            // 
            // CreatePasswordTxt
            // 
            this.CreatePasswordTxt.Location = new System.Drawing.Point(6, 258);
            this.CreatePasswordTxt.Name = "CreatePasswordTxt";
            this.CreatePasswordTxt.Size = new System.Drawing.Size(207, 23);
            this.CreatePasswordTxt.TabIndex = 10;
            // 
            // CreatePhoneNumberTxt
            // 
            this.CreatePhoneNumberTxt.Location = new System.Drawing.Point(6, 166);
            this.CreatePhoneNumberTxt.Name = "CreatePhoneNumberTxt";
            this.CreatePhoneNumberTxt.Size = new System.Drawing.Size(207, 23);
            this.CreatePhoneNumberTxt.TabIndex = 10;
            // 
            // CreateUserNameTxt
            // 
            this.CreateUserNameTxt.Location = new System.Drawing.Point(6, 215);
            this.CreateUserNameTxt.Name = "CreateUserNameTxt";
            this.CreateUserNameTxt.Size = new System.Drawing.Size(207, 23);
            this.CreateUserNameTxt.TabIndex = 8;
            // 
            // CreateEMailTxt
            // 
            this.CreateEMailTxt.Location = new System.Drawing.Point(6, 123);
            this.CreateEMailTxt.Name = "CreateEMailTxt";
            this.CreateEMailTxt.Size = new System.Drawing.Size(207, 23);
            this.CreateEMailTxt.TabIndex = 8;
            // 
            // CreateLastNameTxt
            // 
            this.CreateLastNameTxt.Location = new System.Drawing.Point(6, 80);
            this.CreateLastNameTxt.Name = "CreateLastNameTxt";
            this.CreateLastNameTxt.Size = new System.Drawing.Size(207, 23);
            this.CreateLastNameTxt.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DeleteBtn);
            this.groupBox2.Controls.Add(this.UpdateBtn);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.EditPasswordTxt);
            this.groupBox2.Controls.Add(this.EditPhoneNumberTxt);
            this.groupBox2.Controls.Add(this.EditUserNameTxt);
            this.groupBox2.Controls.Add(this.EditEMailTxt);
            this.groupBox2.Controls.Add(this.EditLastNameTxt);
            this.groupBox2.Controls.Add(this.EditFirstNameTxt);
            this.groupBox2.Location = new System.Drawing.Point(4, 338);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(228, 347);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kullanıcı Düzenle / Sil";
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(130, 297);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(82, 23);
            this.DeleteBtn.TabIndex = 11;
            this.DeleteBtn.Text = "Sil";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(5, 297);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(84, 23);
            this.UpdateBtn.TabIndex = 7;
            this.UpdateBtn.Text = "Güncelle";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "Şifre";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "Telefon";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 197);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 15);
            this.label9.TabIndex = 7;
            this.label9.Text = "Kullanıcı Adı";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 15);
            this.label10.TabIndex = 7;
            this.label10.Text = "E-Posta";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 15);
            this.label11.TabIndex = 5;
            this.label11.Text = "Soyad";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(22, 15);
            this.label12.TabIndex = 0;
            this.label12.Text = "Ad";
            // 
            // EditPasswordTxt
            // 
            this.EditPasswordTxt.Location = new System.Drawing.Point(6, 259);
            this.EditPasswordTxt.Name = "EditPasswordTxt";
            this.EditPasswordTxt.Size = new System.Drawing.Size(206, 23);
            this.EditPasswordTxt.TabIndex = 10;
            // 
            // EditPhoneNumberTxt
            // 
            this.EditPhoneNumberTxt.Location = new System.Drawing.Point(6, 166);
            this.EditPhoneNumberTxt.Name = "EditPhoneNumberTxt";
            this.EditPhoneNumberTxt.Size = new System.Drawing.Size(206, 23);
            this.EditPhoneNumberTxt.TabIndex = 10;
            // 
            // EditUserNameTxt
            // 
            this.EditUserNameTxt.Location = new System.Drawing.Point(5, 215);
            this.EditUserNameTxt.Name = "EditUserNameTxt";
            this.EditUserNameTxt.Size = new System.Drawing.Size(206, 23);
            this.EditUserNameTxt.TabIndex = 8;
            // 
            // EditEMailTxt
            // 
            this.EditEMailTxt.Location = new System.Drawing.Point(6, 122);
            this.EditEMailTxt.Name = "EditEMailTxt";
            this.EditEMailTxt.Size = new System.Drawing.Size(206, 23);
            this.EditEMailTxt.TabIndex = 8;
            // 
            // EditLastNameTxt
            // 
            this.EditLastNameTxt.Location = new System.Drawing.Point(6, 78);
            this.EditLastNameTxt.Name = "EditLastNameTxt";
            this.EditLastNameTxt.Size = new System.Drawing.Size(206, 23);
            this.EditLastNameTxt.TabIndex = 6;
            // 
            // EditFirstNameTxt
            // 
            this.EditFirstNameTxt.Location = new System.Drawing.Point(6, 34);
            this.EditFirstNameTxt.Name = "EditFirstNameTxt";
            this.EditFirstNameTxt.Size = new System.Drawing.Size(206, 23);
            this.EditFirstNameTxt.TabIndex = 4;
            // 
            // UserGridView
            // 
            this.UserGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserGridView.Location = new System.Drawing.Point(238, 12);
            this.UserGridView.Name = "UserGridView";
            this.UserGridView.RowTemplate.Height = 25;
            this.UserGridView.Size = new System.Drawing.Size(773, 673);
            this.UserGridView.TabIndex = 12;
            this.UserGridView.SelectionChanged += new System.EventHandler(this.UserGridView_SelectionChanged);
            // 
            // UserModul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 708);
            this.Controls.Add(this.UserGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UserModul";
            this.Text = "UserModul";
            this.Load += new System.EventHandler(this.UserModul_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox CreateFirstNameTxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CreatePasswordTxt;
        private System.Windows.Forms.TextBox CreatePhoneNumberTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CreateUserNameTxt;
        private System.Windows.Forms.TextBox CreateEMailTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CreateLastNameTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox EditPasswordTxt;
        private System.Windows.Forms.TextBox EditPhoneNumberTxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox EditUserNameTxt;
        private System.Windows.Forms.TextBox EditEMailTxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox EditLastNameTxt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox EditFirstNameTxt;
        private System.Windows.Forms.DataGridView UserGridView;
    }
}