
namespace DocumentedAttribute
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\t This is a Custom Attribute Implementation\n\t =========================================\n");
            
            Operation operation = new Operation();

            operation.GetDocs();
        }
    }
}
