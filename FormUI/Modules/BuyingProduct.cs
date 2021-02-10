using Business.Abstract;
using Business.Ninject;
using Entities.Concrete;
using System;
using System.Windows.Forms;

namespace FormUI.Modules
{
    public partial class BuyingProduct : Form
    {
        private IProductService productService;
        private IStoreService storeService;
        private ISupplierService supplierService;
        private IBuyOrSellService buyOrSellService;
        private CreateMessage createMessage;

        public BuyingProduct()
        {
            productService = InstanceFactory.GetInstance<IProductService>();
            storeService = InstanceFactory.GetInstance<IStoreService>();
            supplierService = InstanceFactory.GetInstance<ISupplierService>();
            buyOrSellService = InstanceFactory.GetInstance<IBuyOrSellService>();
            createMessage = new CreateMessage();
            InitializeComponent();
        }

        private void BuyingProduct_Load(object sender, EventArgs e)
        {
            foreach (var product in productService.GetAll())
                ProductList.Items.Add(product.Id.ToString() + ") " + product.Description);
            foreach (var store in storeService.GetAll())
                StoreList.Items.Add(store.Id + ") " + store.Name);
            foreach (var supplier in supplierService.GetAll())
                SupplierList.Items.Add(supplier.Id + ") " + supplier.CompanyName);
        }

        private void UnitPriceTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void PieceeTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void PieceeTxt_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                TotalPriceTxt.Text = (decimal.Parse(UnitPriceTxt.Text) * 1.0m * Convert.ToInt32(PieceeTxt.Text)).ToString();
            }
            catch (Exception)
            {
                TotalPriceTxt.Text = "";
            }
        }

        private void UnitPriceTxt_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                TotalPriceTxt.Text = (decimal.Parse(UnitPriceTxt.Text) * 1.0m * Convert.ToInt32(PieceeTxt.Text)).ToString();
            }
            catch (Exception)
            {
                TotalPriceTxt.Text = "";
            }
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            string[] productArray = ProductList.SelectedItem.ToString().Split(')');
            string[] supplierArray = SupplierList.SelectedItem.ToString().Split(')');
            string[] storeArray = StoreList.SelectedItem.ToString().Split(')');

            int ProductId = Convert.ToInt32(productArray[0]);
            int SupplierId = Convert.ToInt32(supplierArray[0]);
            int StoreId = Convert.ToInt32(storeArray[0]);

            ProductInStore productInStore = new ProductInStore
            {
                ProductId = ProductId,
                StoreId = StoreId,
                Stock = Convert.ToInt32(PieceeTxt.Text)
            };
            StockMovement stockMovement = new StockMovement
            {
                MemberNumber = SupplierId,
                Type = "Buy",
                Piece = Convert.ToInt32(PieceeTxt.Text),
                ProductId = ProductId,
                TotalPrice = decimal.Parse(TotalPriceTxt.Text),
                UnitPrice = decimal.Parse(UnitPriceTxt.Text),
                TransactionDate = DateTime.Now
            };
            createMessage.CreateMessageBox(buyOrSellService.Buy(productInStore, stockMovement));
        }
    }
}