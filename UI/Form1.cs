using System.Windows.Forms;
using DAL;
namespace UI
{
    public partial class InventoryManagementSystem : Form
    {
        public InventoryManagementSystem()
        {
            InitializeComponent();

        }
        private void InventoryManagementSystem_Load(object sender, EventArgs e)
        {

            viewdata();
        }

        private void viewdata()
        {
            try
            {
                //dummy data
                int totalProducts = GetTotalProductCount();  // Method to get total products count from the database
                decimal totalInventoryValue = GetTotalInventoryValue();  // Method to calculate total inventory value
               
                // Update UI labels with the retrieved data
                txtTotalInventoryvalue.Text = $" {totalInventoryValue:C}";
                txt_TotalProducts.Text = $"{totalProducts:C}";

            }
            catch (Exception ex)
            {
                Console.WriteLine($"error Occurred : {ex.ToString} ");
            }
        }

     

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var Report = new Reports();
            Report.Show();
        }

        private void lblSearch_Click(object sender, EventArgs e)
        {
            var search = new Search();
            search.Show();
        }

        private void btnCategoryManagement_Click(object sender, EventArgs e)
        {
            var Cateogry = new CatogryManagement();
            Cateogry.Show();
        }

        private void btn_InventoryStatus_Click(object sender, EventArgs e)
        {
            var statues = new InventoryStatues();
            statues.Show();
        }

        private void btn_TransactionRecording_Click(object sender, EventArgs e)
        {
            var transaction = new TransactionRecording();
            transaction.Show();
        }

        private void btn_ProductManagement_Click(object sender, EventArgs e)
        {
            var productForm = new ProductManagement();
            bool c = can();
           
            MessageBox.Show(c.ToString());
            
            productForm.Show();
        }

        private void InventoryManagementSystem_Click(object sender, EventArgs e)
        {

        }

      
    
        int GetTotalProductCount()
        {
           
                var Context = new InventoryManagementSystemContext();
                // LINQ query to count the total number of products
                int totalProducts = Context.Products.Count();
                return totalProducts;
           
        }
      
           decimal GetTotalInventoryValue()
           {
            using (var context = new InventoryManagementSystemContext())
            {
                
                decimal totalInventoryValue = context.Products
                    .Join(context.Inventory,
                          product => product.ProductId,
                          inventory => inventory.ProductId,
                          (product, inventory) => new { product.price, inventory.Quantity })
                    .Sum(x => x.price * x.Quantity);


                Console.WriteLine(totalInventoryValue);
                return totalInventoryValue;
            }
        }
        bool can()
        {
            using (var context = new InventoryManagementSystemContext())
            {
                bool canConnect = context.Database.CanConnect();
                Console.WriteLine(canConnect ? "Connected to the database." : "Failed to connect to the database.");
                return canConnect;
            }

        }

    }
}
