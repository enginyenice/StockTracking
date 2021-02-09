
namespace FormUI.Modules
{
    partial class ReportingModule
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
            this.ReportGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ReportGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ReportGridView
            // 
            this.ReportGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReportGridView.Location = new System.Drawing.Point(12, 12);
            this.ReportGridView.Name = "ReportGridView";
            this.ReportGridView.RowTemplate.Height = 25;
            this.ReportGridView.Size = new System.Drawing.Size(769, 232);
            this.ReportGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(643, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Günlük Bakiye: 0 TL";
            // 
            // ReportingModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 280);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReportGridView);
            this.Name = "ReportingModule";
            this.Text = "ReportingModule";
            this.Load += new System.EventHandler(this.ReportingModule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReportGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ReportGridView;
        private System.Windows.Forms.Label label1;
    }
}