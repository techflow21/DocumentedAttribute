using System.IO.Enumeration;
using System.Reflection;
using System.Text;

namespace DocumentedAttribute
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\t Custom Atttribute Implementation");

            GetInfos.GetDocs(typeof(Trainee));
        }
        
    }

}

