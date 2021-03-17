using System;
using System.Collections.Generic;
using System.Text;

namespace _4GunOdev5_Dictionary
{
    class MyDictionary<Key, Value>
    {
        Key[] urun;
        Value[] tur;

        public MyDictionary()
        {
            urun = new Key[0];
            tur = new Value[0];
        }


        public void Add(Key key, Value value)
        {
            Key[] tempUrun = urun;
            Value[] tempTur = tur;

            urun = new Key[urun.Length + 1];
            tur = new Value[tur.Length + 1];

            for (int i = 0; i < tempUrun.Length; i++)
            {
                urun[i] = tempUrun[i];
            }

            for (int i = 0; i < tempUrun.Length; i++)
            {
                tur[i] = tempTur[i];
            }

            urun[urun.Length - 1] = key;
            tur[tur.Length - 1] = value;

        }

        public int Count
        {
            get { return urun.Length; }
        }

        public void Listele()
        {
            for (int i = 0; i < urun.Length; i++)
            {
                Console.WriteLine("Ürün Adı : " + urun[i] + "Ürünün Türü : " + tur[i]);
            }
        }

    }
}

