﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    class MyDictionary<Key,Value>
    {
        Key[] keys;
        Value[] values;

        public MyDictionary()
        {
            keys = new Key[0];
            values = new Value[0];

        }


        public void Add(Key key,Value value)
        {
            Key[] tempKey = keys;
            Value[] tempValue = values;

            keys = new Key[keys.Length + 1];
            values = new Value[values.Length + 1];

            for (int i = 0; i < tempKey.Length; i++)
            {
                for (int j = 0; j < tempValue.Length; j++)
                {
                    keys[i] = tempKey[i];
                    values[i] = tempValue[i];
                }
               
            }

            keys[keys.Length -1] = key;

            values[values.Length - 1] = value;
        }

        public void Show()
        {
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine("Plaka:"+keys[i]+"\t"+"Şehir:"+values[i]);
            }
        }
    }
}
