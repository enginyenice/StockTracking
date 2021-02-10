using Business.Abstract;
using Business.Ninject;
using Entities.Concrete;
using System;
using System.Windows.Forms;

namespace FormUI.Modules
{
    public partial class ProductTransferModule : Form
    {
        private IProductService productService;
        private IStoreService storeService;
        private ISupplierService supplierService;
        private IBuyOrSellService buyOrSellService;
        private IProductInStoreService productInStoreService;
        private CreateMessage createMessage;

        public ProductTransferModule()
        {
            productService = InstanceFactory.GetInstance<IProductService>();
            storeService = InstanceFactory.GetInstance<IStoreService>();
            supplierService = InstanceFactory.GetInstance<ISupplierService>();
            buyOrSellService = InstanceFactory.GetInstance<IBuyOrSellService>();
            productInStoreService = InstanceFactory.GetInstance<IProductInStoreService>();
            createMessage = new CreateMessage();
            InitializeComponent();
        }

        private void ProductTransferModule_Load(object sender, EventArgs e)
        {
            foreach (var product in productService.GetAll())
                ProductList.Items.Add(product.Id + ") " + product.Description);
        }

        private void ProductList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] productArray = ProductList.SelectedItem.ToString().Split(')');
            int ProductId = Convert.ToInt32(productArray[0]);
            StoreList.Items.Clear();
            foreach (var store in productInStoreService.GetAllStore(ProductId))
            {
                if (store.Stock > 0)
                {
                    Store storeData = storeService.Get(store.StoreId);
                    StoreList.Items.Add(storeData.Id + ") " + storeData.Name);
                }
            }
        }

        private void StoreList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] productArray = ProductList.SelectedItem.ToString().Split(')');
            int ProductId = Convert.ToInt32(productArray[0]);

            string[] storeArray = StoreList.SelectedItem.ToString().Split(')');
            int StoreId = Convert.ToInt32(storeArray[0]);

            StoreTransferList.Items.Clear();

            foreach (var store in storeService.GetAllOrderStore(StoreId))
            {
                StoreTransferList.Items.Add(store.Id + ") " + store.Name);
            }
            PieeceNumber.Minimum = 0;
            PieeceNumber.Maximum = (productInStoreService.GetStoreCount(StoreId, ProductId) != null) ? productInStoreService.GetStoreCount(StoreId, ProductId).Stock : 0;
            PieeceNumber.Value = 0;
        }

        private void TransferBtn_Click(object sender, EventArgs e)
        {
            if (PieeceNumber.Value > 0)
            {
                try
                {
                    string[] productArray = ProductList.SelectedItem.ToString().Split(')');
                    int ProductId = Convert.ToInt32(productArray[0]);

                    string[] storeArray = StoreList.SelectedItem.ToString().Split(')');
                    int StoreId = Convert.ToInt32(storeArray[0]);

                    string[] storeTransferArray = StoreTransferList.SelectedItem.ToString().Split(')');
                    int TransferStoreId = Convert.ToInt32(storeTransferArray[0]);
                    int Count = Convert.ToInt32(PieeceNumber.Value);

                    createMessage.CreateMessageBox(productInStoreService.Transfer(StoreId, TransferStoreId, ProductId, Count));
                    StoreList.Items.Clear();
                    StoreTransferList.Items.Clear();
                    PieeceNumber.Value = 0;
                }
                catch (Exception)
                {
                    MessageBox.Show("Tüm alanları eksiksiz doldurunuz..");
                }
            }
            else
            {
                MessageBox.Show("Adet 0 dan büyük olmalıdır.");
            }
        }
    }
}