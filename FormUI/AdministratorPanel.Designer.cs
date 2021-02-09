
namespace FormUI
{
    partial class AdministratorPanel
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
            this.UserModuleBtn = new System.Windows.Forms.Button();
            this.CustomerModuleBtn = new System.Windows.Forms.Button();
            this.SupplierModuleBtn = new System.Windows.Forms.Button();
            this.StoreModuleBtn = new System.Windows.Forms.Button();
            this.ReportModuleBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserModuleBtn
            // 
            this.UserModuleBtn.Location = new System.Drawing.Point(12, 11);
            this.UserModuleBtn.Name = "UserModuleBtn";
            this.UserModuleBtn.Size = new System.Drawing.Size(133, 52);
            this.UserModuleBtn.TabIndex = 0;
            this.UserModuleBtn.Text = "Kullanıcı Modülü";
            this.UserModuleBtn.UseVisualStyleBackColor = true;
            this.UserModuleBtn.Click += new System.EventHandler(this.UserModuleBtn_Click);
            // 
            // CustomerModuleBtn
            // 
            this.CustomerModuleBtn.Location = new System.Drawing.Point(151, 11);
            this.CustomerModuleBtn.Name = "CustomerModuleBtn";
            this.CustomerModuleBtn.Size = new System.Drawing.Size(133, 52);
            this.CustomerModuleBtn.TabIndex = 1;
            this.CustomerModuleBtn.Text = "Müşteri Modülü";
            this.CustomerModuleBtn.UseVisualStyleBackColor = true;
            this.CustomerModuleBtn.Click += new System.EventHandler(this.CustomerModuleBtn_Click);
            // 
            // SupplierModuleBtn
            // 
            this.SupplierModuleBtn.Location = new System.Drawing.Point(290, 11);
            this.SupplierModuleBtn.Name = "SupplierModuleBtn";
            this.SupplierModuleBtn.Size = new System.Drawing.Size(133, 52);
            this.SupplierModuleBtn.TabIndex = 2;
            this.SupplierModuleBtn.Text = "Tedarikçi Modülü";
            this.SupplierModuleBtn.UseVisualStyleBackColor = true;
            this.SupplierModuleBtn.Click += new System.EventHandler(this.SupplierModuleBtn_Click);
            // 
            // StoreModuleBtn
            // 
            this.StoreModuleBtn.Location = new System.Drawing.Point(12, 68);
            this.StoreModuleBtn.Name = "StoreModuleBtn";
            this.StoreModuleBtn.Size = new System.Drawing.Size(272, 52);
            this.StoreModuleBtn.TabIndex = 3;
            this.StoreModuleBtn.Text = "Depo Modülü";
            this.StoreModuleBtn.UseVisualStyleBackColor = true;
            this.StoreModuleBtn.Click += new System.EventHandler(this.StoreModuleBtn_Click);
            // 
            // ReportModuleBtn
            // 
            this.ReportModuleBtn.Location = new System.Drawing.Point(290, 69);
            this.ReportModuleBtn.Name = "ReportModuleBtn";
            this.ReportModuleBtn.Size = new System.Drawing.Size(133, 51);
            this.ReportModuleBtn.TabIndex = 4;
            this.ReportModuleBtn.Text = "Rapor Modülü";
            this.ReportModuleBtn.UseVisualStyleBackColor = true;
            this.ReportModuleBtn.Click += new System.EventHandler(this.ReportModuleBtn_Click);
            // 
            // AdministratorPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 132);
            this.Controls.Add(this.ReportModuleBtn);
            this.Controls.Add(this.StoreModuleBtn);
            this.Controls.Add(this.SupplierModuleBtn);
            this.Controls.Add(this.CustomerModuleBtn);
            this.Controls.Add(this.UserModuleBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "AdministratorPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrator Panel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdministratorPanel_FormClosing);
            this.Load += new System.EventHandler(this.AdministratorPanel_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UserModuleBtn;
        private System.Windows.Forms.Button CustomerModuleBtn;
        private System.Windows.Forms.Button SupplierModuleBtn;
        private System.Windows.Forms.Button StoreModuleBtn;
        private System.Windows.Forms.Button ReportModuleBtn;
    }
}