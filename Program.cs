using System;

namespace Program3
{
    class Program
    {
        class Block
        {
            int num;
            string str;
            byte byt;
            double decim;

            public int myNumber
            {
                get
                {
                    return num;
                }

                set
                {
                    num = value;
                }
            }

            public string myString
            {
                get
                {
                    return str;
                }
                set
                {
                    str = value;
                }
            }

            public byte mybyte
            {
                get
                {
                    return byt;
                }
                set
                {
                    byt = value;
                }
            }

            public double myDecimal
            {
                get
                {
                    return decim;
                }
                set
                {
                    decim = value;
                }
            }

            public static bool operator != (Block block1 , Block block2)
            {
                return !block1.Equals(block2);
            }

            public static bool operator == (Block block1, Block block2)
            {
                return block1.Equals(block2);
            }

            public void ToString()
            {
                System.Console.WriteLine(
                    "Number: {0} \nString: {1} \nbyte: {2} \nDouble: {3}",
                    num,
                    str,
                    byt,
                    decim
                );
            }
        }
        static void Main(string[] args)
        {
            Block myBlock1 = new Block();
            Block myBlock2 = new Block();
            //integer 
            myBlock1.myNumber = 12;
            myBlock2.myNumber = 203;
            //string
            myBlock1.myString = "Junes";
            myBlock2.myString = "Junes";
            //byte
            myBlock1.mybyte = 0XFE;
            myBlock2.mybyte = 0X14;
            //double
            myBlock1.myDecimal = 10.2;
            myBlock2.myDecimal = 10.20;
            bool integerIsEqual , stringIsEqual , byteIsEqual , doubleIsEqual;
            //Compare the value
            integerIsEqual = myBlock1.myNumber == myBlock2.myNumber;
            stringIsEqual = myBlock1.myString == myBlock2.myString;
            byteIsEqual = myBlock1.mybyte == myBlock2.mybyte;
            doubleIsEqual = myBlock1.myDecimal == myBlock2.myDecimal;
            //Check if value is equal
            System.Console.WriteLine("**********True || False***********");
            Console.WriteLine("The value is equal True or False? --> " + integerIsEqual);
            Console.WriteLine("The value is equal True or False? --> " + stringIsEqual);
            Console.WriteLine("The value is equal True or False? --> " + byteIsEqual);
            Console.WriteLine("The value is equal True or False? --> " + doubleIsEqual);
            System.Console.WriteLine("\n");

            //Block 1
            System.Console.WriteLine("*********Block 1***********");
            //Print all value for the the first block
            myBlock1.ToString();
            //Block 2
            System.Console.WriteLine("*********Block 2***********");
            //Print for the second
            myBlock2.ToString();

        }
    }
}
