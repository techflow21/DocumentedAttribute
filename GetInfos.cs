using System;
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

            GetEnumAttribute(classType);

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

            Console.WriteLine("\n\t Method Attribute Info:\n\t=========================== ");

            MethodInfo[] methods = classType.GetMethods();

            for (int count = 0; count < methods.GetLength(0); count++)
            {
                object[] methodAttributes = methods[count].GetCustomAttributes(true);

                foreach (Attribute methodAttribute in methodAttributes)
                {
                    if (methodAttribute is DocumentAttribute)
                    {
                        DocumentAttribute methodDocument = (DocumentAttribute)methodAttribute;

                        Console.WriteLine($"\n\t Method Name: {methods[count].Name}\n\t Method Description: {methodDocument.Description}\n\t Method Input: {methodDocument.Input}\n\t Method Output: {methodDocument.Output}");
                    }
                }
            }
        }


        public static void GetPropertyAttribute(Type classType)
        {
            Console.WriteLine("\n\t Property Attribute Info:\n\t========================== ");

            PropertyInfo[] properties = classType.GetProperties();

            for (int count = 0; count < properties.GetLength(0); count++)
            {
                object[] propertyAttributes = properties[count].GetCustomAttributes(true);

                foreach (Attribute propertyAttribute in propertyAttributes)
                {
                    if (propertyAttribute is DocumentAttribute)
                    {
                        DocumentAttribute propertyDocument = (DocumentAttribute) propertyAttribute;
                        Console.WriteLine($"\n\t Property Name: {properties[count].Name}\n\t Property Description: {propertyDocument.Description}\n\t Property Input: {propertyDocument.Input}\n\t Property Output: {propertyDocument.Output}");
                    }
                }
            }

        }


        public static void GetEnumAttribute(Type classType)
        {
            Console.WriteLine("\n\t Enum Attribute Info: \n\t==============================");

            FieldInfo[] fields = classType.GetFields();

            for (int count = 0; count < fields.GetLength(0); count++)
            {
                object[] fieldAttributes = fields[count].GetCustomAttributes(true);

                foreach (Attribute fieldAttribute in fieldAttributes)
                {
                    if (fieldAttribute is DocumentAttribute)
                    {
                        DocumentAttribute fieldDocument = (DocumentAttribute)fieldAttribute;
                        Console.WriteLine($"\n\t Field Name: {fields[count].Name}\t Field Description: {fieldDocument.Description}\t Field Input: {fieldDocument.Input}");
                    }
                }
            }
        }

    }
}


