using Business.Abstract;
using Business.Ninject;
using Entities.Concrete;
using System;
using System.Windows.Forms;

namespace FormUI.Modules
{
    public partial class SellingProduct : Form
    {
        private IProductService productService;
        private IStoreService storeService;
        private ICustomerService customerService;
        private IBuyOrSellService buyOrSellService;
        private IProductInStoreService productInStoreService;
        private CreateMessage createMessage;

        public SellingProduct()
        {
            productService = InstanceFactory.GetInstance<IProductService>();
            storeService = InstanceFactory.GetInstance<IStoreService>();
            customerService = InstanceFactory.GetInstance<ICustomerService>();
            buyOrSellService = InstanceFactory.GetInstance<IBuyOrSellService>();
            productInStoreService = InstanceFactory.GetInstance<IProductInStoreService>();
            createMessage = new CreateMessage();

            InitializeComponent();
        }

        private void SellingProduct_Load(object sender, EventArgs e)
        {
            foreach (var customer in customerService.GetAll())
                CustomerList.Items.Add(customer.Id + ")" + customer.FirstName + " " + customer.LastName);
            foreach (var product in productService.GetAll())
                ProductList.Items.Add(product.Id + ")" + product.Description);
        }

        private void ProductList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] productArray = ProductList.SelectedItem.ToString().Split(')');
            int ProductId = Convert.ToInt32(productArray[0]);
            StoreList.Items.Clear();
            foreach (var store in productInStoreService.GetAllStore(ProductId))
            {
                Store getStore = storeService.Get(store.StoreId);
                StoreList.Items.Add(getStore.Id + ") " + getStore.Name);
            }
        }

        private void StoreList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] storeArray = StoreList.SelectedItem.ToString().Split(')');
            int StoreId = Convert.ToInt32(storeArray[0]);
            string[] productArray = ProductList.SelectedItem.ToString().Split(')');
            int ProductId = Convert.ToInt32(productArray[0]);

            UnitPriceTxt.Text = "";
            PieeceNumber.Value = 0;
            PieeceNumber.Minimum = 0;
            PieeceNumber.Maximum = (productInStoreService.GetStoreCount(StoreId, ProductId) == null) ? 0 : productInStoreService.GetStoreCount(StoreId, ProductId).Stock;
            TotalPriceTxt.Text = "";
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            string[] storeArray = StoreList.SelectedItem.ToString().Split(')');
            string[] productArray = ProductList.SelectedItem.ToString().Split(')');
            string[] customerArray = CustomerList.SelectedItem.ToString().Split(')');

            int StoreId = Convert.ToInt32(storeArray[0]);
            int ProductId = Convert.ToInt32(productArray[0]);
            int customerId = Convert.ToInt32(productArray[0]);

            ProductInStore productInStore = new ProductInStore
            {
                ProductId = ProductId,
                StoreId = StoreId,
                Stock = Convert.ToInt32(PieeceNumber.Value)
            };
            StockMovement stockMovement = new StockMovement
            {
                MemberNumber = customerId,
                Type = "Sell",
                Piece = Convert.ToInt32(PieeceNumber.Value),
                ProductId = ProductId,
                TotalPrice = decimal.Parse(TotalPriceTxt.Text),
                UnitPrice = decimal.Parse(UnitPriceTxt.Text),
                TransactionDate = DateTime.Now
            };
            createMessage.CreateMessageBox(buyOrSellService.Sell(productInStore, stockMovement));
        }

        private void PieeceNumber_Click(object sender, EventArgs e)
        {
            try
            {
                TotalPriceTxt.Text = (decimal.Parse(UnitPriceTxt.Text) * 1.0m * Convert.ToInt32(PieeceNumber.Value)).ToString();
            }
            catch (Exception)
            {
                TotalPriceTxt.Text = "";
            }
        }

        private void PieeceNumber_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                TotalPriceTxt.Text = (decimal.Parse(UnitPriceTxt.Text) * 1.0m * Convert.ToInt32(PieeceNumber.Value)).ToString();
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
                TotalPriceTxt.Text = (decimal.Parse(UnitPriceTxt.Text) * 1.0m * Convert.ToInt32(PieeceNumber.Value)).ToString();
            }
            catch (Exception)
            {
                TotalPriceTxt.Text = "";
            }
        }

        /*
         string[] productArray = ProductList.SelectedItem.ToString().Split(')');
                string[] supplierArray = SupplierList.SelectedItem.ToString().Split(')');
                string[] storeArray = StoreList.SelectedItem.ToString().Split(')');

                int ProductId = Convert.ToInt32(productArray[0]);
                int SupplierId = Convert.ToInt32(supplierArray[0]);
                int StoreId = Convert.ToInt32(storeArray[0]);
        */
    }
}