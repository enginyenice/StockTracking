using Business.Abstract;
using Business.Ninject;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FormUI.Modules
{
    public partial class ProductTransferModule : Form
    {
        IProductService productService;
        IStoreService storeService;
        ISupplierService supplierService;
        IBuyOrSellService buyOrSellService;
        IProductInStoreService productInStoreService;
        CreateMessage createMessage;

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
                Store storeData = storeService.Get(store.StoreId);
                StoreList.Items.Add(storeData.Id + ") " + storeData.Name);
            }
        }

        private void StoreList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //TODO : Burada kaldım.
            string[] productArray = ProductList.SelectedItem.ToString().Split(')');
            int ProductId = Convert.ToInt32(productArray[0]);

            string[] storeArray = StoreList.SelectedItem.ToString().Split(')');
            int StoreId = Convert.ToInt32(storeArray[0]);

            StoreTransferList.Items.Clear();
            
            foreach (var store in productInStoreService.GetAllStore(ProductId))
            {
                Store storeData = storeService.Get(store.StoreId);
                StoreList.Items.Add(storeData.Id + ") " + storeData.Name);
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
