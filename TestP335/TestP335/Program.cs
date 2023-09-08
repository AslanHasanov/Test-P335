using System.Linq.Expressions;
using System;
using System.Net.Sockets;
using System.Threading.Channels;
using System.Reflection;


namespace TestP335
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // value type
            int sayi = 42;

            //reference type
            object boxedSayi = sayi; // Boxing 




            Console.WriteLine(sayi);
            Console.WriteLine(boxedSayi.GetType());




            //value type
            int unboxedSayi = (int)boxedSayi;      //Unboxing 



            Console.WriteLine($"boxedSayi: {boxedSayi}, unboxedSayi: {unboxedSayi}");


























            //SampleClass sample = new SampleClass();

            //// Reflection kullanarak tür bilgisini alalım
            //Type type = sample.GetType();

            //// Alanları ve değerlerini alma
            //Console.WriteLine("Alanlar:");

            //FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            //foreach (var field in fields)
            //{
            //    Console.WriteLine($"{field.Name}: {field.GetValue(sample)}");
            //}

            //// Metotları çağırma
            //Console.WriteLine("\nMetotlar:");
            //MethodInfo[] methods = type.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            //foreach (var method in methods)
            //{
            //    Console.WriteLine(method.Name);
            //}

        }
        //public class SampleClass
        //{
        //    public int PublicField = 42;
        //    private string privateField = "Merhaba, Dünya!";

        //    public void PublicMethod()
        //    {
        //        Console.WriteLine("PublicMethod çağrıldı.");
        //    }

        //    private void PrivateMethod()
        //    {
        //        Console.WriteLine("PrivateMethod çağrıldı.");
        //    }
        //}
    }

}
