
namespace DocumentedAttribute
{
    internal class Operation
    {
        internal void GetDocs()
        {
            Type type = typeof(Trainee);
            Console.WriteLine($"\t Target Class Name: {type.Name}\n");

            var attributes = type.GetCustomAttributes(true);

            foreach (var attribute in attributes)
            {
                if (attribute is DocumentAttribute)
                {
                    var doc = attribute as DocumentAttribute;
                    Console.WriteLine($"\t Description: {doc.Description} \n\t Input: {doc.Input} \n\t Output: {doc.Output}");
                }
            }


            Console.WriteLine("\n\t Methods of Trainee class:\n\t =========================");
            var methods = type.GetMethods();

            foreach (var method in methods)
            {
                var methodAttributes = method.GetCustomAttributes(true);
                foreach (var attribute in methodAttributes)
                {
                    if (attribute is DocumentAttribute)
                    {
                        var doc = attribute as DocumentAttribute;
                        Console.WriteLine($"\t Method Name: {method.Name} \n\t Description: {doc.Description} \n\t Input: {doc.Input} \n\t Output: {doc.Output}\n");
                    }
                }
            }


            Console.WriteLine("\n\t Properties of Trainee class:\n\t ============================");
            var properties = type.GetProperties();

            foreach (var property in properties)
            {
                var propertyAttributes = property.GetCustomAttributes(true);
                foreach (var attribute in propertyAttributes)
                {
                    if (attribute is DocumentAttribute)
                    {
                        var doc = attribute as DocumentAttribute;
                        Console.WriteLine($"\t Property Name: {property.Name} \n\t Description: {doc.Description} \n\t Input: {doc.Input} \n\t Output: {doc.Output}");
                    }
                }
            }


            Type enumType = typeof(Level.LevelEnum);
            var enumValues = enumType.GetEnumValues();

            Console.WriteLine("\n\t Values of LevelEnum:\n\t =====================");
            foreach (var value in enumValues)
            {
                var valueAttributes = enumType.GetField(value.ToString()).GetCustomAttributes(true);

                foreach (var attribute in valueAttributes)
                {
                    if (attribute is DocumentAttribute)
                    {
                        var doc = attribute as DocumentAttribute;
                        Console.WriteLine($"\n\t Description: {doc.Description} \n\t Value: {value}");
                    }
                }
            }
        }
    }
}
