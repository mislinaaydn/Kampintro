using System;
using System.Collections.Generic;
using System.Text;

namespace GenericDictionary
{
    class MyGenericDictionary<TKey, TValue>
    {
        // Dictionary<int, string> yapısı görüldüğü üzere iki farklı tipteki listelerin birleşiminden oluşuyor. Listeleri arka planda array'ler ile tutuyorduk yani burdaki elemanları da array'ler ile tutacağız 2 farklı tip için 2 farklı array'imiz olacak.

        // kullanacağım ana array'ler
        TKey[] keyArray;
        TValue[] valueArray;
        // yedekleme yapacağım geçici array'ler
        TKey[] tempKeyArray;
        TValue[] tempValueArray;

        public MyGenericDictionary()
        {
            keyArray = new TKey[0];
            valueArray = new TValue[0];
        }

        public void Add(TKey key, TValue value)
        {
            // ana array'leri yedekleme işlemi
            tempKeyArray = keyArray;
            tempValueArray = valueArray;

            // ana array'lerin her çağırıldıklarında 1'er eleman arttırılması işlemini yapıyoruz.
            keyArray = new TKey[keyArray.Length + 1];
            valueArray = new TValue[valueArray.Length + 1];

            // array'in uzunluğu arttırıldıktan sonra geçici array'lerdeki elemanları ana array'lerimize aktarıyoruz.
            for (int i = 0; i < tempKeyArray.Length; i++)
            {
                keyArray[i] = tempKeyArray[i];
            }

            for (int i = 0; i < tempValueArray.Length; i++)
            {
                valueArray[i] = tempValueArray[i];
            }

            // array^leri eşitleme işlemi bittikten sonra yeni elemanlarımızı ekliyoruz.
            keyArray[keyArray.Length - 1] = key;
            valueArray[valueArray.Length - 1] = value;
        }

        // iki metot listelerimizi consolda göstermemizi sağlar.
        public TKey[] Items1
        {
            get { return keyArray; }
        }

        public TValue[] Items2
        {
            get { return valueArray; }
        }
    }
}