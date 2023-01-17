using System.Reflection;

namespace DocumentedAttribute
{
    internal class GetInfos
    {
        public static void GetDocs(Type classType)
        {
            GetAssemblyAttribute(classType);

            GetPropertyAttribute(classType);

            GetMethodAttribute(classType);

            GetEnumAttribute();

        }

        public static void GetAssemblyAttribute(Type classType)
        {
            Console.WriteLine($"\n\t Current Assembly: {Assembly.GetExecutingAssembly}\n\t Class Name: {classType.FullName}");


            object[] classAttributes = classType.GetCustomAttributes(true);

            foreach (Attribute classAttribute in classAttributes)
            {
                if (classAttribute is DocumentAttribute)
                {
                    DocumentAttribute classDocument = (DocumentAttribute) classAttribute;

                    Console.WriteLine("\n\t Class Description: {0}", classDocument.Description);
                }
            }
        }


        public static void GetMethodAttribute(Type classType)
        {

            Console.WriteLine("\n\t Method Attribute Info: ");

            MethodInfo[] methods = classType.GetMethods();

            for (int count = 0; count < methods.GetLength(0); count++)
            {
                object[] methodAttributes = methods[count].GetCustomAttributes(true);

                foreach (Attribute methodAttribute in methodAttributes)
                {
                    if (methodAttribute is DocumentAttribute)
                    {
                        DocumentAttribute methodDocument = (DocumentAttribute)methodAttribute;

                        Console.WriteLine($"\n\t Method Name: {methods[count].Name}\t Method Description: {methodDocument.Description}\t Method Input: {methodDocument.Input}");
                    }
                }
            }
        }


        public static void GetPropertyAttribute(Type classType)
        {
            Console.WriteLine("\n\t Property Attribute Info: ");

            PropertyInfo[] properties = classType.GetProperties();

            for (int count = 0; count < properties.GetLength(0); count++)
            {
                object[] propertyAttributes = properties[count].GetCustomAttributes(true);

                foreach (Attribute propertyAttribute in propertyAttributes)
                {
                    if (propertyAttribute is DocumentAttribute)
                    {
                        DocumentAttribute propertyDocument = (DocumentAttribute) propertyAttribute;
                        Console.WriteLine($"\n\t Property Name: {properties[count].Name}\t Property Description: {propertyDocument.Description}\t Property Input: {propertyDocument.Input}");
                    }
                }
            }

        }


        public static void GetEnumAttribute()
        {
            Console.WriteLine("\n\t Enum Attribute Info: ");

            var fields = typeof(Trainee).GetFields();
            foreach (var field in fields)
            {
                var attr = field.GetCustomAttribute<DocumentAttribute>();
                if (attr != null)
                {
                    Console.WriteLine($"\n\t Method Name: {field.Name}\t Method Description: {attr.Description}\t Method Input: {attr.Input}");
                }
            }
        }

    }
}


