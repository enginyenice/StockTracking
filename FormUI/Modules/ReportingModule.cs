using Business.Abstract;
using Business.Ninject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FormUI.Modules
{
    public partial class ReportingModule : Form
    {
        IStockMovementService stockMovementService;

        public ReportingModule()
        {
            stockMovementService = InstanceFactory.GetInstance<IStockMovementService>();
            InitializeComponent();
        }

        private void ReportingModule_Load(object sender, EventArgs e)
        {

            ReportGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ReportGridView.ReadOnly = true;
            ReportGridView.ColumnCount = 7;
            ReportGridView.Columns[0].Name = "Tarih";
            ReportGridView.Columns[1].Name = "İşlem";
            ReportGridView.Columns[2].Name = "Tedarik / Müşteri ";
            ReportGridView.Columns[3].Name = "Ürün";
            ReportGridView.Columns[4].Name = "Adet";
            ReportGridView.Columns[5].Name = "Birim Fiyat";
            ReportGridView.Columns[6].Name = "Toplam Fiyat";
            GetAllReport();
        }

        private void GetAllReport()
        {
            decimal Total = 0;
            foreach (var report in stockMovementService.GetReportData())
            {
                string[] row = new string[] {
                    report.TransactionDate.ToShortDateString(),
                    report.Type,
                    report.FirstName + " "+report.LastName,
                    report.ProductDetail,
                    report.Piece.ToString(),
                    report.UnitPrice.ToString(),
                    report.TotalPrice.ToString()

                };
                ReportGridView.Rows.Add(row);
                if (report.Type == "Alış")
                    Total -= report.TotalPrice;
                else
                    Total += report.TotalPrice;
                label1.Text = "Günlük Bakiye: " + Total.ToString() + " TL";
            }
        }
    }
}
