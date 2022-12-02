using System;
using test_procesora;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace test_procesora
{
    //Klasa instrukcji SET
    public class ValueRejestr
    {
        public int AX;
        public int BX;
        public int CX;
        public int DX;
        public int value1;
        public int value2;
        public int value3;
        public int value4;
        public string HEX1;
        public string HEX2;
        public string HEX3;
        public string HEX4;
        public int HIGH1;
        public int HIGH2;
        public int HIGH3;
        public int HIGH4;
        public int LOW1;
        public int LOW2;
        public int LOW3;
        public int LOW4;

        public void WartoscRejestrowAX()
        {

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Enter a value in decimal: ");

            int ValueAX = int.Parse(Console.ReadLine());



            if (ValueAX <= 9 && ValueAX >= 0)
            {



                HEX1 = "000" + ValueAX.ToString();

                string hexValue1 = ValueAX.ToString();
                LOW1 = ValueAX;
                value1 = int.Parse(hexValue1, System.Globalization.NumberStyles.HexNumber);
                AX = value1;

                Console.WriteLine("Done! Return to menu. Click any button");
                Console.ReadLine();


            }
            else if (ValueAX <= 99 && ValueAX >= 10)
            {


                HEX1 = "00" + ValueAX.ToString();
                string hexValue2 = ValueAX.ToString();
                LOW1 = ValueAX;
                value1 = int.Parse(hexValue2, System.Globalization.NumberStyles.HexNumber);
                AX = value1;

                Console.WriteLine("Done! Return to menu. Click any button");
                Console.ReadLine();




            }
            else if (ValueAX <= 999 && ValueAX >= 100)
            {
                HEX1 = "0" + ValueAX.ToString();

                string hexValue3 = ValueAX.ToString();



                HIGH1 = int.Parse(hexValue3.Substring(0, 1));
                LOW1 = int.Parse(hexValue3.Substring(1, 2));

                value1 = int.Parse(hexValue3, System.Globalization.NumberStyles.HexNumber);
                AX = value1;

                Console.WriteLine("Done! Return to menu. Click any button");
                Console.ReadLine();



            }
            else if (ValueAX >= 1000 && ValueAX <= 9999)
            {
                HEX1 = ValueAX.ToString();
                string hexValue4 = ValueAX.ToString();

                HIGH1 = int.Parse(hexValue4.Substring(0, 2));
                LOW1 = int.Parse(hexValue4.Substring(2, 2));
                value1 = int.Parse(hexValue4, System.Globalization.NumberStyles.HexNumber);
                AX = value1;

                Console.WriteLine("Done! Return to menu. Click any button");
                Console.ReadLine();




            }

            else if (ValueAX > 9999)
            {
                Console.WriteLine("Value is too high. Click any button to return to menu");
                Console.ReadLine();

            }
            else
            {
                Console.WriteLine("Value is too low. Click any button to return to menu");

            }
            Console.ResetColor();
            Console.Clear();
        }
        public void WartoscRejestrowBX()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Enter a value in decimal: ");
            int ValueBX = int.Parse(Console.ReadLine());


            if (ValueBX <= 9 && ValueBX >= 0)
            {



                HEX2 = "000" + ValueBX.ToString();

                string hexValue5 = ValueBX.ToString();
                LOW2 = ValueBX;
                value2 = int.Parse(hexValue5, System.Globalization.NumberStyles.HexNumber);
                BX = value2;

                Console.WriteLine("Done! Return to menu. Click any button");
                Console.ReadLine();

            }
            else if (ValueBX <= 99 && ValueBX >= 10)
            {


                HEX2 = "00" + ValueBX.ToString();
                string hexValue6 = ValueBX.ToString();
                LOW2 = ValueBX;
                value2 = int.Parse(hexValue6, System.Globalization.NumberStyles.HexNumber);
                BX = value2;

                Console.WriteLine("Done! Return to menu. Click any button");
                Console.ReadLine();


            }
            else if (ValueBX <= 999 && ValueBX >= 100)
            {
                HEX2 = "0" + ValueBX.ToString();

                string hexValue7 = ValueBX.ToString();



                HIGH2 = int.Parse(hexValue7.Substring(0, 1));
                LOW2 = int.Parse(hexValue7.Substring(1, 2));

                value2 = int.Parse(hexValue7, System.Globalization.NumberStyles.HexNumber);
                BX = value2;

                Console.WriteLine("Done! Return to menu. Click any button");
                Console.ReadLine();

            }
            else if (ValueBX >= 1000 && ValueBX <= 9999)
            {
                HEX2 = ValueBX.ToString();
                string hexValue8 = ValueBX.ToString();

                HIGH2 = int.Parse(hexValue8.Substring(0, 2));
                LOW2 = int.Parse(hexValue8.Substring(2, 2));
                value2 = int.Parse(hexValue8, System.Globalization.NumberStyles.HexNumber);
                BX = value2;

                Console.WriteLine("Done! Return to menu. Click any button");
                Console.ReadLine();


            }

            else if (ValueBX > 9999)
            {
                Console.WriteLine("Value is too high. Click any button to return to menu");
                Console.ReadLine();

            }
            else
            {
                Console.WriteLine("Value is too low. Click any button to return to menu");

            }
            Console.ResetColor();
            Console.Clear();
        }
        public void WartoscRejestrowCX()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Enter a value in decimal: ");
            int ValueCX = int.Parse(Console.ReadLine());


            if (ValueCX <= 9 && ValueCX >= 0)
            {



                HEX3 = "000" + ValueCX.ToString();

                string hexValue9 = ValueCX.ToString();
                LOW3 = ValueCX;
                value3 = int.Parse(hexValue9, System.Globalization.NumberStyles.HexNumber);
                CX = value3;

                Console.WriteLine("GDone! Return to menu. Click any button");
                Console.ReadLine();

            }
            else if (ValueCX <= 99 && ValueCX >= 10)
            {


                HEX3 = "00" + ValueCX.ToString();
                string hexValue10 = ValueCX.ToString();
                LOW3 = ValueCX;
                value3 = int.Parse(hexValue10, System.Globalization.NumberStyles.HexNumber);
                CX = value3;

                Console.WriteLine("Done! Return to menu. Click any button");
                Console.ReadLine();


            }
            else if (ValueCX <= 999 && ValueCX >= 100)
            {
                HEX3 = "0" + ValueCX.ToString();

                string hexValue11 = ValueCX.ToString();



                HIGH3 = int.Parse(hexValue11.Substring(0, 1));
                LOW3 = int.Parse(hexValue11.Substring(1, 2));

                value3 = int.Parse(hexValue11, System.Globalization.NumberStyles.HexNumber);
                CX = value3;

                Console.WriteLine("Done! Return to menu. Click any button");
                Console.ReadLine();

            }
            else if (ValueCX >= 1000 && ValueCX <= 9999)
            {
                HEX3 = ValueCX.ToString();
                string hexValue12 = ValueCX.ToString();

                HIGH3 = int.Parse(hexValue12.Substring(0, 2));
                LOW3 = int.Parse(hexValue12.Substring(2, 2));
                value3 = int.Parse(hexValue12, System.Globalization.NumberStyles.HexNumber);
                CX = value3;

                Console.WriteLine("Done! Return to menu. Click any button");
                Console.ReadLine();


            }

            else if (ValueCX > 9999)
            {
                Console.WriteLine("Value is too high. Click any button to return to menu");
                Console.ReadLine();

            }
            else
            {
                Console.WriteLine("Value is too low. Click any button to return to menu");

            }
            Console.ResetColor();
            Console.Clear();
        }
        public void WartoscRejestrowDX()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Enter a value in decimal: ");
            int ValueDX = int.Parse(Console.ReadLine());


            if (ValueDX <= 9 && ValueDX >= 0)
            {



                HEX4 = "000" + ValueDX.ToString();

                string hexValue13 = ValueDX.ToString();
                LOW4 = ValueDX;
                value4 = int.Parse(hexValue13, System.Globalization.NumberStyles.HexNumber);
                DX = value4;

                Console.WriteLine("Done! Return to menu. Click any button");
                Console.ReadLine();

            }
            else if (ValueDX <= 99 && ValueDX >= 10)
            {


                HEX4 = "00" + ValueDX.ToString();
                string hexValue14 = ValueDX.ToString();
                LOW4 = ValueDX;
                value4 = int.Parse(hexValue14, System.Globalization.NumberStyles.HexNumber);
                DX = value4;

                Console.WriteLine("Done! Return to menu. Click any button");
                Console.ReadLine();


            }
            else if (ValueDX <= 999 && ValueDX >= 100)
            {
                HEX4 = "0" + ValueDX.ToString();

                string hexValue15 = ValueDX.ToString();



                HIGH4 = int.Parse(hexValue15.Substring(0, 1));
                LOW4 = int.Parse(hexValue15.Substring(1, 2));

                value4 = int.Parse(hexValue15, System.Globalization.NumberStyles.HexNumber);
                DX = value4;

                Console.WriteLine("Done! Return to menu. Click any button");
                Console.ReadLine();

            }
            else if (ValueDX >= 1000 && ValueDX <= 9999)
            {
                HEX4 = ValueDX.ToString();
                string hexValue16 = ValueDX.ToString();

                HIGH4 = int.Parse(hexValue16.Substring(0, 2));
                LOW4 = int.Parse(hexValue16.Substring(2, 2));
                value4 = int.Parse(hexValue16, System.Globalization.NumberStyles.HexNumber);
                DX = value4;


                Console.WriteLine("Done! Return to menu. Click any button");
                Console.ReadLine();


            }

            else if (ValueDX > 9999)
            {
                Console.WriteLine("Value is too high. Click any button to return to menu");
                Console.ReadLine();

            }
            else
            {
                Console.WriteLine("Value is too low. Click any button to return to menu");

            }
            Console.ResetColor();
            Console.Clear();
        }

    }
}