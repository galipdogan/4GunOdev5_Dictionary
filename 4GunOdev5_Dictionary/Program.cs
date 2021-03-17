using System;
using System.Collections.Generic;

namespace _4GunOdev5_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            IDictionary<string, string> urunler = new Dictionary<string, string>();
            urunler.Add("Kazak","Yünlü,Kaşmir,Pamuklu"); //adding a key/value using the Add() method
            urunler.Add("Pantolon","Gabardin,Kot,Günlük");
            urunler.Add("Gömlek", "Pamuklu,Yünlü,Keten,Yazlık");

            foreach (var kvp in urunler)
                Console.WriteLine("Anahtar: {0}, Değer: {1}", kvp.Key, kvp.Value);


            MyDictionary<string, string> myDictionary = new MyDictionary<string, string>();
            myDictionary.Add("Ayakkabı","Spor Ayakkabı,Günlük Ayakkabı,Kundura");

            myDictionary.Listele();
            
        }
    }
}
