using System;
using System.Reflection;

namespace ЛР_4
{
    class Program
    {
        static Country myCountry = new Country();
        static void Main(string[] args)
        {

            #region fields
            const BindingFlags BindingAttr = BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public;
            var type = myCountry.GetType();
            FieldInfo[] fieldsInfo = type.GetFields(BindingAttr);
            MethodInfo[] methodsInfo = type.GetMethods(BindingAttr);
            PropertyInfo[] propertiesInfo = type.GetProperties(BindingAttr);
            #endregion

            #region get info
            foreach (var fieldInfo in fieldsInfo)
                GetInfoAboutField(fieldInfo);

            foreach (var methodInfo in methodsInfo)
                GetInfoAboutMethod(methodInfo);

            foreach (var propertyInfo in propertiesInfo)
                GetInfoAboutPropety(propertyInfo);
            #endregion

            #region set values
            FieldInfo field = type.GetField("nameCountry", BindingAttr);
            field.SetValue(myCountry, "notDefault");
            field = type.GetField("population", BindingAttr);
            field.SetValue(myCountry, 100);
            PropertyInfo property = type.GetProperty("NumberCities", BindingAttr);
            property.SetValue(myCountry, 200);
            #endregion

            #region method invoke
            MethodInfo method = type.GetMethod("AddToPopulation", BindingAttr);
            method.Invoke(myCountry, new object[] { 100 });
            #endregion

            #region constructors invoke
            ConstructorInfo constructor = type.GetConstructor(Type.EmptyTypes);
            constructor.Invoke(null);
            constructor = type.GetConstructor(BindingAttr, null, new Type[] { typeof(string), typeof(int), typeof(int), typeof(double) }, null);
            constructor.Invoke(new object[] { "Америка", 328200000, 30000, 9834000 });
            #endregion

            Console.ReadKey();
        }
        static void GetInfoAboutField(FieldInfo fieldInfo)
        {
            Console.WriteLine($"Имя поля: {fieldInfo.Name}");
            Console.WriteLine($"Тип поля: {fieldInfo.FieldType}");
            Console.WriteLine($"Значение поля: {fieldInfo.GetValue(myCountry)}");
            Console.WriteLine($" Открытый член? {fieldInfo.IsPublic}");
            Console.WriteLine($" Приватный член? {fieldInfo.IsPrivate}");
            Console.WriteLine($" Статический член? {fieldInfo.IsStatic}\n");
        }
        static void GetInfoAboutMethod(MethodInfo methodInfo)
        {
            Console.WriteLine($"Имя метода: {methodInfo.Name}");
            Console.WriteLine($"Возвращаемый тип: {methodInfo.ReturnType.Name}");
            Console.WriteLine($"Параметры метода:");
            foreach (var parameter in methodInfo.GetParameters())
                Console.WriteLine($"  Тип: {parameter.ParameterType}, Имя: {parameter.Name}");
            Console.WriteLine($" Это конструктор? {methodInfo.IsConstructor}");
            Console.WriteLine($" Это абстрактный метод? {methodInfo.IsAbstract}");
            Console.WriteLine($" Открытый метод? {methodInfo.IsPublic}");
            Console.WriteLine($" Приватный метод? {methodInfo.IsPrivate}");
            Console.WriteLine($" Статический метод? {methodInfo.IsStatic}\n");
        }
        static void GetInfoAboutPropety(PropertyInfo propertyInfo)
        {
            Console.WriteLine($"Имя свойства: {propertyInfo.Name}");
            Console.WriteLine($"Тип свойства: {propertyInfo.PropertyType}");
            if (propertyInfo.CanRead)
                Console.WriteLine($"Значение свойства: {propertyInfo.GetValue(myCountry)}");
            Console.WriteLine($" Запись разрешена? {propertyInfo.CanWrite}");
            Console.WriteLine($" Чтение разрешено? {propertyInfo.CanRead}\n");
        }
    }
}
