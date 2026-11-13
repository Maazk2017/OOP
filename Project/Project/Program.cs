
namespace Project
{
    using Project.Components; 

    internal class Program
    {
        static void Main(string[] args)
        {
            ProductManager.LoadProductsFromJson();
            ProductManager.DisplayCategoryProducts();
            //ProductManager.AddProduct();
            //ProductManager.RemoveProductById("d6d52");

        }
    }
}
