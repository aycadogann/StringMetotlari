using System;

namespace HazirMetotlar_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken="Dersimiz CSharp. Hoş geldiniz.";
            string degisken2="Dersimiz CSharp.";

            //Length
            Console.WriteLine(degisken.Length);

            //ToUpper
            Console.WriteLine(degisken.ToUpper());

            //ToLower
            Console.WriteLine(degisken.ToLower());

            //Concat
            Console.WriteLine(string.Concat(degisken,"Merhaba"));

            //CompareTo
            //çıktı -1,0,1 seçeneklerinden biri
            Console.WriteLine(degisken.CompareTo(degisken2));

            //Compare
            //true büyük küçük harf duyarsız olması
            //false büyük küçük harf duyarlı olması
            //çıktı -1,0,1 seçeneklerinden biri
            Console.WriteLine(string.Compare(degisken,degisken2,true));
            Console.WriteLine(string.Compare(degisken,degisken2,false));

            //Contains
            Console.WriteLine(degisken.Contains(degisken2));

            //EndsWith-StartsWith
            Console.WriteLine(degisken.EndsWith("Hoş geldiniz"));
            Console.WriteLine(degisken.StartsWith("Merhaba"));

            //IndexOf
            Console.WriteLine(degisken.IndexOf("CS"));

            //LastIndexOf
            Console.WriteLine(degisken.LastIndexOf("i"));

            //Insert
            Console.WriteLine(degisken.Insert(0,"Merhaba"));

            //PadLeft,PadRight
            //degisken2'nin soluna boşluk ekler.
            //bunu yaparken degisken2 ve boşluk toplamı 30 karakter olacak şekilde yapar.
            Console.WriteLine(degisken+degisken2.PadLeft(30));
            Console.WriteLine(degisken+degisken2.PadLeft(30,'*'));
            Console.WriteLine(degisken.PadRight(50)+degisken2);
            Console.WriteLine(degisken.PadRight(50,'-')+degisken2);

            //Remove
            Console.WriteLine(degisken.Remove(10));
            Console.WriteLine(degisken.Remove(5,3));
            Console.WriteLine(degisken.Remove(0,1));

            //Replace
            Console.WriteLine(degisken.Replace("CSharp","C#"));
            Console.WriteLine(degisken.Replace(" ","*"));

            //Split
            Console.WriteLine(degisken.Split(' ')[1]);

            //Substring
            Console.WriteLine(degisken.Substring(4));
            Console.WriteLine(degisken.Substring(4,6));

        }
    }
}
