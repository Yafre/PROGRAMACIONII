namespace YAGNIPrinciple
{
    public class ProductService
    {
        public void AddProduct(string name, decimal price)
        {
            Console.WriteLine($"Producto '{name}' agregado con precio {price}.");
        }

        public void DeleteProduct(int productId)
        {
            Console.WriteLine($"Producto con ID {productId} eliminado.");
        }
    }
}
