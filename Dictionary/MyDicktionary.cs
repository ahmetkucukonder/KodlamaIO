using System;

namespace Dictionary
{
    class MyDicktionary<TKey, TValue>
    {
        TKey[] _itemKey; //Set item key
        TValue[] _itemValue; //Set item value
        TKey[] _tempKey; //Set temp for key
        TValue[] _tempValue; //Set temp for value

        public MyDicktionary() //Create advanced constructor for my dicktionary
        {
            _itemKey = new TKey[0]; //Create key for array
            _itemValue = new TValue[0]; //Create value for array
        }

        public void Add(TKey key, TValue value) //Add any data to my dicktionary
        {
            _tempKey = _itemKey; //Protect key data in temp
            _tempValue = _itemValue; //Protect value data in temp
            _itemKey = new TKey[_tempKey.Length + 1]; //Increase key index bound
            _itemValue = new TValue[_tempKey.Length + 1]; //Increase value index bound

            for (int i = 0; i < _tempKey.Length; i++) //Some loop
            {
                _itemKey[i] = _tempKey[i]; //Yo temp give back my key data
                _itemValue[i] = _tempValue[i]; //Yo temp give back my value data
            }
            _itemKey[_itemKey.Length - 1] = key; //Add my key to array
            _itemValue[_itemValue.Length - 1] = value; //Add my value to array
            Console.WriteLine(key + " => " + value); //Tell me anything
        }

        public void List() //List all items
        {
            Console.WriteLine("All items (" + _itemKey.Length + "):"); //Inf message
            for (int i = 0; i < _itemKey.Length; i++) //Loop for all items
            {
                Console.WriteLine(_itemKey[i] + " => " + _itemValue[i]); //Write item
            }
        }

        public int Count
        {
            get { return _itemKey.Length; }
        }
    }
}
