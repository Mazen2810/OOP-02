using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Encapsulation
{
    internal struct PhoneBook
    {
        #region Fields

        private string[] names;
        private ulong[] numbers;
        private int size;

        #endregion
        //Getter
        public long GetPersonNumber(string name)
        {

            if (name is not null && numbers is not null)
            {
                for (int i = 0; i < size; i++)
                    if (name == names[i])
                        return (long)numbers[i];
            }
            return -1;

        }

        //Setter
        public void SetNumber(string name, ulong value)
        {
            for (int i = 0; i < size; i++)
                if (name == names[i])
                {
                    numbers[i] = value;
                    return;
                }
        }

        #region Property
        public int Size
        {
            get { return size; }

        }

        //***** Indexer : is a Special Property [Named always with "this" keyword && Can Take Parameters]

        public long this[string name] // this =>current object
        {
            get
            {
                if (name is not null && numbers is not null)
                {
                    for (int i = 0; i < size; i++)
                        if (name == names[i])
                            return (long)numbers[i];
                }
                return -1;

            }
            set
            {
                if (name is not null && numbers is not null)
                {
                    for (int i = 0; i < size; i++)
                    {
                        if (name == names[i])
                        {
                            numbers[i] = (ulong)value;
                            return;
                        }
                    }
                }
            }
        }


        public string this[int index]
        {
            get
            {
                return $"Position : {index + 1}, Name = {names[index]}, Number = {numbers[index]}";
            }
        }
        #endregion

        #region Constructor
        public PhoneBook(int size)
        {
            this.size = size;
            names = new string[size];
            numbers = new ulong[size];
        }
        #endregion

        #region Methods
        public void AddPerson(uint position, string name, ulong number)
        {
            if (names is not null && numbers is not null && position < size)
            {
                names[position] = name;
                numbers[position] = number;
            }
        }
        #endregion
    }
}
