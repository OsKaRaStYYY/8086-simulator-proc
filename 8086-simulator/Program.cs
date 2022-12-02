using test_procesora;

namespace Simulator8086

{


    public class Program

    {

        public static void Main()
        {
            int AX = 0;
            int BX = 0;
            int CX = 0;
            int DX = 0;
            ValueRejestr wartosc = new ValueRejestr();
            wartosc.AX = AX;
            wartosc.BX = BX;
            wartosc.CX = CX;
            wartosc.DX = DX;


        //Menu
        Wroc:
            try
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("8086 MICROPROCCESOR SIMULATOR");

                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("1.SET");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("2.MOV");
                Console.ResetColor();
                Console.WriteLine("3");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("4.View current registers values");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("5.Clear registers values");



                while (true)
                {


                    //Instrukcja SET
                    int menu = int.Parse(Console.ReadLine());
                    if (menu == 1)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("1.SET 16 BIT");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("2.SET 8 BIT");
                        Console.ResetColor();
                        int b = int.Parse(Console.ReadLine());
                        if (b == 1)
                        {



                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("Choose a register:");
                            Console.WriteLine("1.AX");
                            Console.WriteLine("2.BX");
                            Console.WriteLine("3.CX");
                            Console.WriteLine("4.DX");
                            try
                            {
                                int rejestr = int.Parse(Console.ReadLine());
                                if (rejestr == 1)
                                {
                                    wartosc.WartoscRejestrowAX();
                                    goto Wroc;
                                }
                                else if (rejestr == 2)
                                {
                                    wartosc.WartoscRejestrowBX();
                                    goto Wroc;

                                }
                                else if (rejestr == 3)
                                {
                                    wartosc.WartoscRejestrowCX();
                                    goto Wroc;
                                }
                                else if (rejestr == 4)
                                {
                                    wartosc.WartoscRejestrowDX();
                                    goto Wroc;
                                }
                                else
                                {
                                    Console.WriteLine("Incorrect register..Back to menu");
                                    Thread.Sleep(2500);
                                    Console.Clear();
                                    goto Wroc;
                                }
                            }
                            catch (Exception T)
                            {
                                Console.ResetColor();
                                Console.WriteLine(T.Message);
                                Console.WriteLine("Back to menu");
                                Thread.Sleep(2000);
                                Console.Clear();
                                goto Wroc;
                            }

                            Console.ResetColor();
                        }

                        else if (b == 2)
                        {
                        SET8:
                            try
                            {

                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.WriteLine("Choose a register:");
                                Console.WriteLine("1.AH");
                                Console.WriteLine("2.BH");
                                Console.WriteLine("3.CH");
                                Console.WriteLine("4.DH");
                                Console.WriteLine("5.AL");
                                Console.WriteLine("6.BL");
                                Console.WriteLine("7.CL");
                                Console.WriteLine("8.DL");

                                int rejestr = int.Parse(Console.ReadLine());
                                if (rejestr == 1)
                                {
                                    Console.Write("Enter a value in decimal: ");
                                    int value1 = int.Parse(Console.ReadLine());
                                    if (value1 <= 9 && value1 >= 0)
                                    {
                                        wartosc.HIGH1 = value1;
                                        wartosc.HEX1 = "0" + value1 + "00";
                                        wartosc.AX = int.Parse(wartosc.HEX1, System.Globalization.NumberStyles.HexNumber);
                                        Console.WriteLine("Done! Click any button to return to menu");

                                        Console.ReadLine();
                                        Console.Clear();

                                        goto Wroc;

                                    }
                                    else if (value1 <= 99)
                                    {
                                        wartosc.HIGH1 = value1;
                                        wartosc.HEX1 = value1 + "00";
                                        wartosc.AX = int.Parse(wartosc.HEX1, System.Globalization.NumberStyles.HexNumber);
                                        Console.WriteLine("Done! Click any button to return to menu");

                                        Console.ReadLine();
                                        Console.Clear();

                                        goto Wroc;
                                    }
                                    else if (value1 > 99)
                                    {
                                        Console.WriteLine("Value is too high.");
                                        Console.WriteLine("Click any button to return to SET");
                                        Console.ReadLine();
                                        Console.Clear();
                                        goto SET8;
                                    }
                                    else if (value1 < 0)
                                    {

                                        Console.WriteLine("Value is too low.");
                                        Console.WriteLine("Click any button to return to SET");
                                        Console.ReadLine();
                                        Console.Clear();
                                        goto SET8;

                                    }
                                }
                                else if (rejestr == 2)
                                {

                                    Console.Write("Enter a value in decimal: ");
                                    int value2 = int.Parse(Console.ReadLine());
                                    if (value2 <= 9 && value2 >= 0)
                                    {
                                        wartosc.HIGH2 = value2;
                                        wartosc.HEX2 = "0" + value2 + "00";
                                        wartosc.BX = int.Parse(wartosc.HEX2, System.Globalization.NumberStyles.HexNumber);
                                        Console.WriteLine("Done! Click any button to return to menu");

                                        Console.ReadLine();
                                        Console.Clear();

                                        goto Wroc;

                                    }
                                    else if (value2 <= 99)
                                    {
                                        wartosc.HIGH2 = value2;
                                        wartosc.HEX2 = value2 + "00";
                                        wartosc.BX = int.Parse(wartosc.HEX2, System.Globalization.NumberStyles.HexNumber);
                                        Console.WriteLine("Done! Click any button to return to menu.");

                                        Console.ReadLine();
                                        Console.Clear();

                                        goto Wroc;
                                    }
                                    else if (value2 > 99)
                                    {
                                        Console.WriteLine("Value is too high..");
                                        Console.WriteLine("Click any button to return to SET.");
                                        Console.ReadLine();
                                        Console.Clear();
                                        goto SET8;
                                    }
                                    else if (value2 < 0)
                                    {

                                        Console.WriteLine("Value is too low.");
                                        Console.WriteLine("Click any button to return to SET.");
                                        Console.ReadLine();
                                        Console.Clear();
                                        goto SET8;

                                    }
                                }
                                else if (rejestr == 3)
                                {

                                    Console.Write("Enter a value in decimal: ");
                                    int value3 = int.Parse(Console.ReadLine());
                                    if (value3 <= 9 && value3 >= 0)
                                    {
                                        wartosc.HIGH3 = value3;
                                        wartosc.HEX3 = "0" + value3 + "00";
                                        wartosc.CX = int.Parse(wartosc.HEX3, System.Globalization.NumberStyles.HexNumber);
                                        Console.WriteLine("Done! Click any button to return to menu.");

                                        Console.ReadLine();
                                        Console.Clear();

                                        goto Wroc;

                                    }
                                    else if (value3 <= 99)
                                    {
                                        wartosc.HIGH3 = value3;
                                        wartosc.HEX3 = value3 + "00";
                                        wartosc.CX = int.Parse(wartosc.HEX3, System.Globalization.NumberStyles.HexNumber);
                                        Console.WriteLine("Done! Click any button to return to menu.");

                                        Console.ReadLine();
                                        Console.Clear();

                                        goto Wroc;
                                    }
                                    else if (value3 > 99)
                                    {
                                        Console.WriteLine("Value is too high.");
                                        Console.WriteLine("Click any button to return to SET.");
                                        Console.ReadLine();
                                        Console.Clear();
                                        goto SET8;
                                    }
                                    else if (value3 < 0)
                                    {

                                        Console.WriteLine("Value is too low.");
                                        Console.WriteLine("Click any button to return to SET.");
                                        Console.ReadLine();
                                        Console.Clear();
                                        goto SET8;

                                    }
                                }
                                else if (rejestr == 4)
                                {

                                    Console.Write("Enter a value in decimal: ");
                                    int value4 = int.Parse(Console.ReadLine());
                                    if (value4 <= 9 && value4 >= 0)
                                    {
                                        wartosc.HIGH4 = value4;
                                        wartosc.HEX4 = "0" + value4 + "00";
                                        wartosc.DX = int.Parse(wartosc.HEX4, System.Globalization.NumberStyles.HexNumber);
                                        Console.WriteLine("Click any button to return to menu.");

                                        Console.ReadLine();
                                        Console.Clear();

                                        goto Wroc;

                                    }
                                    else if (value4 <= 99)
                                    {
                                        wartosc.HIGH4 = value4;
                                        wartosc.HEX4 = value4 + "00";
                                        wartosc.DX = int.Parse(wartosc.HEX4, System.Globalization.NumberStyles.HexNumber);
                                        Console.WriteLine("Done! Click any button to return to menu.");

                                        Console.ReadLine();
                                        Console.Clear();

                                        goto Wroc;
                                    }
                                    else if (value4 > 99)
                                    {
                                        Console.WriteLine("Value is too high.");
                                        Console.WriteLine("Click any button to return to menu.");
                                        Console.ReadLine();
                                        Console.Clear();
                                        goto SET8;
                                    }
                                    else if (value4 < 0)
                                    {

                                        Console.WriteLine("Value is too low.");
                                        Console.WriteLine("Click any button to return to menu.");
                                        Console.ReadLine();
                                        Console.Clear();
                                        goto SET8;

                                    }
                                }
                                else if (rejestr == 5)
                                {

                                    Console.Write("Enter a value in decimal: ");
                                    int value5 = int.Parse(Console.ReadLine());
                                    if (value5 <= 9 && value5 >= 0)
                                    {
                                        wartosc.LOW1 = value5;
                                        wartosc.HEX1 = "00" + value5;
                                        wartosc.AX = int.Parse(wartosc.HEX1, System.Globalization.NumberStyles.HexNumber);
                                        Console.WriteLine("Click any button to return to menu.");

                                        Console.ReadLine();
                                        Console.Clear();

                                        goto Wroc;

                                    }
                                    else if (value5 <= 99)
                                    {
                                        wartosc.LOW1 = value5;
                                        wartosc.HEX1 = "00" + value5;
                                        wartosc.AX = int.Parse(wartosc.HEX1, System.Globalization.NumberStyles.HexNumber);
                                        Console.WriteLine("Done! Click any button to return to menu.");

                                        Console.ReadLine();
                                        Console.Clear();

                                        goto Wroc;
                                    }
                                    else if (value5 > 99)
                                    {
                                        Console.WriteLine("Value is too high.");
                                        Console.WriteLine("Click any button to return to menu.");
                                        Console.ReadLine();
                                        Console.Clear();
                                        goto SET8;
                                    }
                                    else if (value5 < 0)
                                    {

                                        Console.WriteLine("Value is too low.");
                                        Console.WriteLine("Click any button to return to menu.");
                                        Console.ReadLine();
                                        Console.Clear();
                                        goto SET8;

                                    }
                                }
                                else if (rejestr == 6)
                                {
                                    Console.Write("Enter a value in decimal: ");
                                    int value6 = int.Parse(Console.ReadLine());
                                    if (value6 <= 9 && value6 >= 0)
                                    {
                                        wartosc.LOW2 = value6;
                                        wartosc.HEX2 = "000" + value6;
                                        wartosc.BX = int.Parse(wartosc.HEX2, System.Globalization.NumberStyles.HexNumber);
                                        Console.WriteLine("Done! Click any button to return to menu.");

                                        Console.ReadLine();
                                        Console.Clear();

                                        goto Wroc;

                                    }
                                    else if (value6 <= 99)
                                    {
                                        wartosc.LOW2 = value6;
                                        wartosc.HEX2 = "00" + value6;
                                        wartosc.BX = int.Parse(wartosc.HEX2, System.Globalization.NumberStyles.HexNumber);
                                        Console.WriteLine("Done! Click any button to return to menu.");

                                        Console.ReadLine();
                                        Console.Clear();

                                        goto Wroc;
                                    }
                                    else if (value6 > 99)
                                    {
                                        Console.WriteLine("Value is too high.");
                                        Console.WriteLine("Click any button to return to menu.");
                                        Console.ReadLine();
                                        Console.Clear();
                                        goto SET8;
                                    }
                                    else if (value6 < 0)
                                    {

                                        Console.WriteLine("Value is too low.");
                                        Console.WriteLine("Click any button to return to menu.");
                                        Console.ReadLine();
                                        Console.Clear();
                                        goto SET8;

                                    }
                                }
                                else if (rejestr == 7)
                                {
                                    Console.Write("Enter a value in decimal: ");
                                    int value7 = int.Parse(Console.ReadLine());
                                    if (value7 <= 9 && value7 >= 0)
                                    {
                                        wartosc.LOW3 = value7;
                                        wartosc.HEX3 = "000" + value7;
                                        wartosc.CX = int.Parse(wartosc.HEX3, System.Globalization.NumberStyles.HexNumber);
                                        Console.WriteLine("Done! Return to menu. Click any button.");

                                        Console.ReadLine();
                                        Console.Clear();

                                        goto Wroc;

                                    }
                                    else if (value7 <= 99)
                                    {
                                        wartosc.LOW3 = value7;
                                        wartosc.HEX3 = "00" + value7;
                                        wartosc.CX = int.Parse(wartosc.HEX3, System.Globalization.NumberStyles.HexNumber);
                                        Console.WriteLine("Done! Return to menu. Click any button.");

                                        Console.ReadLine();
                                        Console.Clear();

                                        goto Wroc;
                                    }
                                    else if (value7 > 99)
                                    {
                                        Console.WriteLine("Value is to high.");
                                        Console.WriteLine("Click any button to return to menu.");
                                        Console.ReadLine();
                                        Console.Clear();
                                        goto SET8;
                                    }
                                    else if (value7 < 0)
                                    {

                                        Console.WriteLine("Value is too low.");
                                        Console.WriteLine("Click any button to return to menu.");
                                        Console.ReadLine();
                                        Console.Clear();
                                        goto SET8;

                                    }
                                }
                                else if (rejestr == 8)
                                {
                                    Console.Write("Enter a value in decimal: ");
                                    int value8 = int.Parse(Console.ReadLine());
                                    if (value8 <= 9 && value8 >= 0)
                                    {
                                        wartosc.LOW4 = value8;
                                        wartosc.HEX4 = "000" + value8;
                                        wartosc.DX = int.Parse(wartosc.HEX4, System.Globalization.NumberStyles.HexNumber);
                                        Console.WriteLine("Done! Return to menu. Click any button.");

                                        Console.ReadLine();
                                        Console.Clear();

                                        goto Wroc;

                                    }
                                    else if (value8 <= 99)
                                    {
                                        wartosc.LOW4 = value8;
                                        wartosc.HEX4 = "00" + value8;
                                        wartosc.DX = int.Parse(wartosc.HEX4, System.Globalization.NumberStyles.HexNumber);
                                        Console.WriteLine("Done! Return to menu. Click any button.");

                                        Console.ReadLine();
                                        Console.Clear();

                                        goto Wroc;
                                    }
                                    else if (value8 > 99)
                                    {
                                        Console.WriteLine("Value is to high.");
                                        Console.WriteLine("Done! Click any button to return to menu.");
                                        Console.ReadLine();
                                        Console.Clear();
                                        goto SET8;
                                    }
                                    else if (value8 < 0)
                                    {

                                        Console.WriteLine("Value is too low.");
                                        Console.WriteLine("To return to the menu, click any button. ");
                                        Console.ReadLine();
                                        Console.Clear();
                                        goto SET8;

                                    }
                                }
                                else
                                {
                                    Console.WriteLine("You choose incorrect register, please try again..");
                                    Console.WriteLine("Click any button to return to SET.");
                                    Console.ReadLine();
                                    Console.Clear();

                                    goto SET8;
                                }

                            }
                            catch (Exception K)
                            {
                                Console.ResetColor();
                                Console.WriteLine(K.Message);
                                Console.WriteLine("Back to SET8");
                                Thread.Sleep(2000);
                                goto SET8;
                            }

                            Console.ResetColor();
                        }
                        else
                        {
                            Console.WriteLine("Incorrect register.. Back to menu");
                            Thread.Sleep(2500);
                            Console.Clear();
                            goto Wroc;

                        }


                        //Instrukcja MOV
                    }
                    else if (menu == 2)
                    {

                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("1.16 BIT");
                        Console.WriteLine("2.8 BIT");


                        try
                        {
                            int MOV16_8 = int.Parse(Console.ReadLine());


                            if (MOV16_8 == 1)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Choose first register: ");
                                Console.WriteLine("1.AX");
                                Console.WriteLine("2.BX");
                                Console.WriteLine("3.CX");
                                Console.WriteLine("4.DX");

                                try
                                {
                                    int poczatkowy = int.Parse(Console.ReadLine());
                                    if (poczatkowy == 1)
                                    {

                                        Console.WriteLine("In which register you want to transfer the value:");
                                        Console.WriteLine("1.BX");
                                        Console.WriteLine("2.CX");
                                        Console.WriteLine("3.DX");
                                        int DoCzego1 = int.Parse(Console.ReadLine());


                                        if (DoCzego1 == 1)
                                        {
                                            wartosc.BX = wartosc.AX;
                                            wartosc.HEX2 = wartosc.HEX1;
                                            wartosc.HIGH2 = wartosc.HIGH1;
                                            wartosc.LOW2 = wartosc.LOW1;


                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;

                                        }
                                        else if (DoCzego1 == 2)
                                        {
                                            wartosc.CX = wartosc.AX;
                                            wartosc.HEX3 = wartosc.HEX1;
                                            wartosc.HIGH3 = wartosc.HIGH1;
                                            wartosc.LOW3 = wartosc.LOW1;

                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;
                                        }
                                        else if (DoCzego1 == 3)
                                        {
                                            wartosc.DX = wartosc.AX;
                                            wartosc.HEX4 = wartosc.HEX1;
                                            wartosc.HIGH4 = wartosc.HIGH1;
                                            wartosc.LOW4 = wartosc.LOW1;
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;
                                        }
                                    }
                                    else if (poczatkowy == 2)
                                    {
                                        Console.WriteLine("In which register you want to transfer the value:");
                                        Console.WriteLine("1.AX");
                                        Console.WriteLine("2.CX");
                                        Console.WriteLine("3.DX");
                                        int DoCzego2 = int.Parse(Console.ReadLine());


                                        if (DoCzego2 == 1)
                                        {
                                            wartosc.AX = wartosc.BX;
                                            wartosc.HEX1 = wartosc.HEX2;
                                            wartosc.HIGH1 = wartosc.HIGH2;
                                            wartosc.LOW1 = wartosc.LOW2;

                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;

                                        }
                                        else if (DoCzego2 == 2)
                                        {
                                            wartosc.CX = wartosc.BX;
                                            wartosc.HEX3 = wartosc.HEX2;
                                            wartosc.HIGH3 = wartosc.HIGH2;
                                            wartosc.LOW3 = wartosc.LOW2;

                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;
                                        }
                                        else if (DoCzego2 == 3)
                                        {
                                            wartosc.DX = wartosc.BX;
                                            wartosc.HEX4 = wartosc.HEX2;
                                            wartosc.HIGH4 = wartosc.HIGH2;
                                            wartosc.LOW4 = wartosc.LOW2;

                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;
                                        }
                                    }
                                    else if (poczatkowy == 3)
                                    {
                                        Console.WriteLine("In which register you want to transfer the value:");
                                        Console.WriteLine("1.AX");
                                        Console.WriteLine("2.BX");
                                        Console.WriteLine("3.DX");
                                        int DoCzego3 = int.Parse(Console.ReadLine());


                                        if (DoCzego3 == 1)
                                        {
                                            wartosc.AX = wartosc.CX;
                                            wartosc.HEX1 = wartosc.HEX3;
                                            wartosc.HIGH1 = wartosc.HIGH3;
                                            wartosc.LOW1 = wartosc.LOW3;

                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;

                                        }
                                        else if (DoCzego3 == 2)
                                        {
                                            wartosc.BX = wartosc.CX;
                                            wartosc.HEX2 = wartosc.HEX3;
                                            wartosc.HIGH2 = wartosc.HIGH3;
                                            wartosc.LOW2 = wartosc.LOW3;


                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;

                                        }
                                        else if (DoCzego3 == 3)
                                        {
                                            wartosc.DX = wartosc.CX;
                                            wartosc.HEX4 = wartosc.HEX3;
                                            wartosc.HIGH4 = wartosc.HIGH3;
                                            wartosc.LOW4 = wartosc.LOW3;

                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;
                                        }
                                    }
                                    else if (poczatkowy == 4)
                                    {
                                        Console.WriteLine("In which register you want to transfer the value:");
                                        Console.WriteLine("1.AX");
                                        Console.WriteLine("2.BX");
                                        Console.WriteLine("3.CX");
                                        int DoCzego4 = int.Parse(Console.ReadLine());


                                        if (DoCzego4 == 1)
                                        {
                                            wartosc.AX = wartosc.DX;
                                            wartosc.HEX1 = wartosc.HEX4;
                                            wartosc.HIGH1 = wartosc.HIGH4;
                                            wartosc.LOW1 = wartosc.LOW4;

                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;

                                        }
                                        else if (DoCzego4 == 2)
                                        {
                                            wartosc.BX = wartosc.DX;
                                            wartosc.HEX2 = wartosc.HEX4;
                                            wartosc.HIGH2 = wartosc.HIGH4;
                                            wartosc.LOW2 = wartosc.LOW4;


                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;
                                        }
                                        else if (DoCzego4 == 3)
                                        {
                                            wartosc.CX = wartosc.DX;
                                            wartosc.HEX3 = wartosc.HEX4;
                                            wartosc.HIGH3 = wartosc.HIGH4;
                                            wartosc.LOW3 = wartosc.LOW4;


                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;
                                        }
                                    }

                                    Console.ResetColor();

                                }
                                catch (Exception P)
                                {
                                    Console.WriteLine(P.Message);
                                    goto Wroc;

                                }

                            }



                            else if (MOV16_8 == 2)
                            {

                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Choose first register");
                                Console.WriteLine("1.AH");
                                Console.WriteLine("2.BH");
                                Console.WriteLine("3.CH");
                                Console.WriteLine("4.DH");
                                Console.WriteLine("5.AL");
                                Console.WriteLine("6.BL");
                                Console.WriteLine("7.CL");
                                Console.WriteLine("8.DL");
                                int q = int.Parse(Console.ReadLine());
                                if (q == 1)
                                {
                                    Console.WriteLine("In which register you want to transfer the value:");
                                    Console.WriteLine("1.BH");
                                    Console.WriteLine("2.CH");
                                    Console.WriteLine("3.DH");
                                    Console.WriteLine("4.AL");
                                    Console.WriteLine("5.BL");
                                    Console.WriteLine("6.CL");
                                    Console.WriteLine("7.DL");
                                    int mov = int.Parse(Console.ReadLine());
                                    if (mov == 1) //AH->BH
                                    {
                                        if (wartosc.HIGH1 <= 9 && wartosc.HIGH1 >= 0)
                                        {
                                            wartosc.HIGH2 = wartosc.HIGH1;
                                            wartosc.HEX2 = "0" + wartosc.HIGH2 + "00";
                                            wartosc.BX = int.Parse(wartosc.HEX2, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;

                                        }
                                        else if (wartosc.HIGH1 <= 99)
                                        {
                                            wartosc.HIGH2 = wartosc.HIGH1;
                                            wartosc.HEX2 = wartosc.HIGH2 + "00";
                                            wartosc.BX = int.Parse(wartosc.HEX2, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;
                                        }


                                    }
                                    if (mov == 2) //AH->CH
                                    {
                                        if (wartosc.HIGH1 <= 9 && wartosc.HIGH1 >= 0)
                                        {
                                            wartosc.HIGH3 = wartosc.HIGH1;
                                            wartosc.HEX3 = "0" + wartosc.HIGH3 + "00";
                                            wartosc.CX = int.Parse(wartosc.HEX3, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;

                                        }
                                        else if (wartosc.HIGH1 <= 99)
                                        {
                                            wartosc.HIGH3 = wartosc.HIGH1;
                                            wartosc.HEX3 = wartosc.HIGH3 + "00";
                                            wartosc.CX = int.Parse(wartosc.HEX3, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;
                                        }
                                    }
                                    if (mov == 3) //AH->DH
                                    {
                                        if (wartosc.HIGH1 <= 9 && wartosc.HIGH1 >= 0)
                                        {
                                            wartosc.HIGH4 = wartosc.HIGH1;
                                            wartosc.HEX4 = "0" + wartosc.HIGH4 + "00";
                                            wartosc.DX = int.Parse(wartosc.HEX4, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();

                                            goto Wroc;

                                        }
                                        else if (wartosc.HIGH1 <= 99)
                                        {
                                            wartosc.HIGH4 = wartosc.HIGH1;
                                            wartosc.HEX4 = wartosc.HIGH4 + "00";
                                            wartosc.DX = int.Parse(wartosc.HEX4, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;
                                        }
                                    }
                                    if (mov == 4) //AH->AL
                                    {
                                        if (wartosc.HIGH1 <= 9 && wartosc.HIGH1 >= 0)
                                        {
                                            wartosc.LOW1 = wartosc.HIGH1;
                                            wartosc.HEX1 = $"0{wartosc.HIGH1.ToString()}0{wartosc.LOW1.ToString()}";
                                            wartosc.AX = int.Parse(wartosc.HEX1, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;

                                        }
                                        else if (wartosc.HIGH1 <= 99)
                                        {
                                            wartosc.LOW1 = wartosc.HIGH1;
                                            wartosc.HEX1 = $"{wartosc.HIGH1.ToString()}{wartosc.LOW1.ToString()}"; ;
                                            wartosc.AX = int.Parse(wartosc.HEX1, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;
                                        }
                                    }
                                    if (mov == 5) //AH->BL
                                    {
                                        if (wartosc.HIGH1 <= 9 && wartosc.HIGH1 >= 0)
                                        {
                                            wartosc.LOW2 = wartosc.HIGH1;
                                            wartosc.HEX2 = "000" + wartosc.LOW2;
                                            wartosc.BX = int.Parse(wartosc.HEX2, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;

                                        }
                                        else if (wartosc.HIGH1 <= 99)
                                        {
                                            wartosc.LOW2 = wartosc.HIGH1;
                                            wartosc.HEX2 = "00" + wartosc.LOW2;
                                            wartosc.BX = int.Parse(wartosc.HEX2, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;
                                        }
                                    }
                                    if (mov == 6)  //AH->CL
                                    {
                                        if (wartosc.HIGH1 <= 9 && wartosc.HIGH1 >= 0)
                                        {
                                            wartosc.LOW3 = wartosc.HIGH1;
                                            wartosc.HEX3 = "000" + wartosc.LOW3;
                                            wartosc.CX = int.Parse(wartosc.HEX3, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;

                                        }
                                        else if (wartosc.HIGH1 <= 99)
                                        {
                                            wartosc.LOW3 = wartosc.HIGH1;
                                            wartosc.HEX3 = "00" + wartosc.LOW3;
                                            wartosc.CX = int.Parse(wartosc.HEX3, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;
                                        }
                                    }
                                    if (mov == 7) //AH->DL
                                    {
                                        if (wartosc.HIGH1 <= 9 && wartosc.HIGH1 >= 0)
                                        {
                                            wartosc.LOW4 = wartosc.HIGH1;
                                            wartosc.HEX4 = "000" + wartosc.LOW4;
                                            wartosc.DX = int.Parse(wartosc.HEX4, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;

                                        }
                                        else if (wartosc.HIGH1 <= 99)
                                        {
                                            wartosc.LOW4 = wartosc.HIGH1;
                                            wartosc.HEX4 = "00" + wartosc.LOW4;
                                            wartosc.DX = int.Parse(wartosc.HEX4, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;
                                        }
                                    }


                                }
                                if (q == 2)
                                {


                                    Console.WriteLine("In which register you want to transfer the value:");
                                    Console.WriteLine("1.AH");
                                    Console.WriteLine("2.CH");
                                    Console.WriteLine("3.DH");
                                    Console.WriteLine("4.AL");
                                    Console.WriteLine("5.BL");
                                    Console.WriteLine("6.CL");
                                    Console.WriteLine("7.DL");
                                    int mov2 = int.Parse(Console.ReadLine());
                                    if (mov2 == 1) //BH->AH
                                    {
                                        if (wartosc.HIGH2 <= 9 && wartosc.HIGH2 >= 0)
                                        {
                                            wartosc.HIGH1 = wartosc.HIGH2;
                                            wartosc.HEX1 = "0" + wartosc.HIGH1 + "00";
                                            wartosc.AX = int.Parse(wartosc.HEX1, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;

                                        }
                                        else if (wartosc.HIGH2 <= 99)
                                        {
                                            wartosc.HIGH1 = wartosc.HIGH2;
                                            wartosc.HEX1 = wartosc.HIGH1 + "00";
                                            wartosc.AX = int.Parse(wartosc.HEX1, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;
                                        }


                                    }
                                    if (mov2 == 2) //BH->CH
                                    {
                                        if (wartosc.HIGH2 <= 9 && wartosc.HIGH2 >= 0)
                                        {
                                            wartosc.HIGH3 = wartosc.HIGH2;
                                            wartosc.HEX3 = "0" + wartosc.HIGH3 + "00";
                                            wartosc.CX = int.Parse(wartosc.HEX3, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;

                                        }
                                        else if (wartosc.HIGH2 <= 99)
                                        {
                                            wartosc.HIGH3 = wartosc.HIGH2;
                                            wartosc.HEX3 = wartosc.HIGH3 + "00";
                                            wartosc.CX = int.Parse(wartosc.HEX3, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;
                                        }
                                    }
                                    if (mov2 == 3) //BH->DH
                                    {
                                        if (wartosc.HIGH2 <= 9 && wartosc.HIGH2 >= 0)
                                        {
                                            wartosc.HIGH4 = wartosc.HIGH2;
                                            wartosc.HEX4 = "0" + wartosc.HIGH4 + "00";
                                            wartosc.DX = int.Parse(wartosc.HEX4, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;

                                        }
                                        else if (wartosc.HIGH2 <= 99)
                                        {
                                            wartosc.HIGH4 = wartosc.HIGH2;
                                            wartosc.HEX4 = wartosc.HIGH4 + "00";
                                            wartosc.DX = int.Parse(wartosc.HEX4, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;
                                        }
                                    }
                                    if (mov2 == 4) //BH->AL
                                    {
                                        if (wartosc.HIGH2 <= 9 && wartosc.HIGH2 >= 0)
                                        {
                                            wartosc.LOW1 = wartosc.HIGH2;
                                            wartosc.HEX1 = "000" + wartosc.LOW1;
                                            wartosc.AX = int.Parse(wartosc.HEX1, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;

                                        }
                                        else if (wartosc.HIGH2 <= 99)
                                        {
                                            wartosc.LOW1 = wartosc.HIGH2;
                                            wartosc.HEX1 = "00" + wartosc.LOW1;
                                            wartosc.AX = int.Parse(wartosc.HEX1, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;
                                        }
                                    }
                                    if (mov2 == 5) //BH->BL
                                    {
                                        if (wartosc.HIGH2 <= 9 && wartosc.HIGH2 >= 0)
                                        {
                                            wartosc.LOW2 = wartosc.HIGH2;
                                            wartosc.HEX2 = $"0{wartosc.HIGH2.ToString()}0{wartosc.LOW2.ToString()}";
                                            wartosc.BX = int.Parse(wartosc.HEX2, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;

                                        }
                                        else if (wartosc.HIGH2 <= 99)
                                        {
                                            wartosc.LOW2 = wartosc.HIGH2;
                                            wartosc.HEX2 = $"{wartosc.HIGH2.ToString()}{wartosc.LOW2.ToString()}";
                                            wartosc.BX = int.Parse(wartosc.HEX2, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;
                                        }
                                    }
                                    if (mov2 == 6)  //BH->CL
                                    {
                                        if (wartosc.HIGH2 <= 9 && wartosc.HIGH2 >= 0)
                                        {
                                            wartosc.LOW3 = wartosc.HIGH2;
                                            wartosc.HEX3 = "000" + wartosc.LOW3;
                                            wartosc.CX = int.Parse(wartosc.HEX3, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;

                                        }
                                        else if (wartosc.HIGH2 <= 99)
                                        {
                                            wartosc.LOW3 = wartosc.HIGH2;
                                            wartosc.HEX3 = "00" + wartosc.LOW3;
                                            wartosc.CX = int.Parse(wartosc.HEX3, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;
                                        }
                                    }
                                    if (mov2 == 7) //BH->DL
                                    {
                                        if (wartosc.HIGH2 <= 9 && wartosc.HIGH2 >= 0)
                                        {
                                            wartosc.LOW4 = wartosc.HIGH2;
                                            wartosc.HEX4 = "000" + wartosc.LOW4;
                                            wartosc.DX = int.Parse(wartosc.HEX4, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;

                                        }
                                        else if (wartosc.HIGH2 <= 99)
                                        {
                                            wartosc.LOW4 = wartosc.HIGH2;
                                            wartosc.HEX4 = "00" + wartosc.LOW4;
                                            wartosc.DX = int.Parse(wartosc.HEX4, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;
                                        }
                                    }
                                }
                                if (q == 3)
                                {

                                    Console.WriteLine("In which register you want to transfer the value:");
                                    Console.WriteLine("1.AH");
                                    Console.WriteLine("2.BH");
                                    Console.WriteLine("3.DH");
                                    Console.WriteLine("4.AL");
                                    Console.WriteLine("5.BL");
                                    Console.WriteLine("6.CL");
                                    Console.WriteLine("7.DL");
                                    int mov3 = int.Parse(Console.ReadLine());
                                    if (mov3 == 1) //CH->AH
                                    {
                                        if (wartosc.HIGH3 <= 9 && wartosc.HIGH3 >= 0)
                                        {
                                            wartosc.HIGH1 = wartosc.HIGH3;
                                            wartosc.HEX1 = "0" + wartosc.HIGH1 + "00";
                                            wartosc.AX = int.Parse(wartosc.HEX1, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;

                                        }
                                        else if (wartosc.HIGH3 <= 99)
                                        {
                                            wartosc.HIGH1 = wartosc.HIGH3;
                                            wartosc.HEX1 = wartosc.HIGH1 + "00";
                                            wartosc.AX = int.Parse(wartosc.HEX1, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;
                                        }


                                    }
                                    if (mov3 == 2) //CH->BH
                                    {
                                        if (wartosc.HIGH3 <= 9 && wartosc.HIGH3 >= 0)
                                        {
                                            wartosc.HIGH2 = wartosc.HIGH3;
                                            wartosc.HEX2 = "0" + wartosc.HIGH2 + "00";
                                            wartosc.BX = int.Parse(wartosc.HEX2, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;

                                        }
                                        else if (wartosc.HIGH3 <= 99)
                                        {
                                            wartosc.HIGH2 = wartosc.HIGH3;
                                            wartosc.HEX2 = wartosc.HIGH2 + "00";
                                            wartosc.BX = int.Parse(wartosc.HEX2, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;
                                        }
                                    }
                                    if (mov3 == 3) //CH->DH
                                    {
                                        if (wartosc.HIGH3 <= 9 && wartosc.HIGH3 >= 0)
                                        {
                                            wartosc.HIGH4 = wartosc.HIGH3;
                                            wartosc.HEX4 = "0" + wartosc.HIGH4 + "00";
                                            wartosc.DX = int.Parse(wartosc.HEX4, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;

                                        }
                                        else if (wartosc.HIGH3 <= 99)
                                        {
                                            wartosc.HIGH4 = wartosc.HIGH3;
                                            wartosc.HEX4 = wartosc.HIGH4 + "00";
                                            wartosc.DX = int.Parse(wartosc.HEX4, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;
                                        }
                                    }
                                    if (mov3 == 4) //CH->AL
                                    {
                                        if (wartosc.HIGH3 <= 9 && wartosc.HIGH3 >= 0)
                                        {
                                            wartosc.LOW1 = wartosc.HIGH3;
                                            wartosc.HEX1 = "000" + wartosc.LOW1;
                                            wartosc.AX = int.Parse(wartosc.HEX1, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;

                                        }
                                        else if (wartosc.HIGH3 <= 99)
                                        {
                                            wartosc.LOW1 = wartosc.HIGH3;
                                            wartosc.HEX1 = "00" + wartosc.LOW1;
                                            wartosc.AX = int.Parse(wartosc.HEX1, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;
                                        }
                                    }
                                    if (mov3 == 5) //CH->BL
                                    {
                                        if (wartosc.HIGH3 <= 9 && wartosc.HIGH3 >= 0)
                                        {
                                            wartosc.LOW2 = wartosc.HIGH3;
                                            wartosc.HEX2 = "000" + wartosc.LOW2;
                                            wartosc.BX = int.Parse(wartosc.HEX2, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;

                                        }
                                        else if (wartosc.HIGH3 <= 99)
                                        {
                                            wartosc.LOW2 = wartosc.HIGH3;
                                            wartosc.HEX2 = "00" + wartosc.LOW2;
                                            wartosc.BX = int.Parse(wartosc.HEX2, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;
                                        }
                                    }
                                    if (mov3 == 6)  //CH->CL
                                    {
                                        if (wartosc.HIGH3 <= 9 && wartosc.HIGH3 >= 0)
                                        {
                                            wartosc.LOW3 = wartosc.HIGH3;
                                            wartosc.HEX3 = $"0{wartosc.HIGH3.ToString()}0{wartosc.LOW3.ToString()}";
                                            wartosc.CX = int.Parse(wartosc.HEX3, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;

                                        }
                                        else if (wartosc.HIGH3 <= 99)
                                        {
                                            wartosc.LOW3 = wartosc.HIGH3;
                                            wartosc.HEX3 = $"{wartosc.HIGH3.ToString()}{wartosc.LOW3.ToString()}";
                                            wartosc.CX = int.Parse(wartosc.HEX3, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;
                                        }
                                    }
                                    if (mov3 == 7) //CH->DL
                                    {
                                        if (wartosc.HIGH3 <= 9 && wartosc.HIGH3 >= 0)
                                        {
                                            wartosc.LOW4 = wartosc.HIGH3;
                                            wartosc.HEX4 = "000" + wartosc.LOW4;
                                            wartosc.DX = int.Parse(wartosc.HEX4, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;

                                        }
                                        else if (wartosc.HIGH3 <= 99)
                                        {
                                            wartosc.LOW4 = wartosc.HIGH3;
                                            wartosc.HEX4 = "00" + wartosc.LOW4;
                                            wartosc.DX = int.Parse(wartosc.HEX4, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;
                                        }
                                    }

                                }
                                if (q == 4)
                                {

                                    Console.WriteLine("In which register you want to transfer the value:");
                                    Console.WriteLine("1.AH");
                                    Console.WriteLine("2.BH");
                                    Console.WriteLine("3.CH");
                                    Console.WriteLine("4.AL");
                                    Console.WriteLine("5.BL");
                                    Console.WriteLine("6.CL");
                                    Console.WriteLine("7.DL");
                                    int mov4 = int.Parse(Console.ReadLine());
                                    if (mov4 == 1) //DH->AH
                                    {
                                        if (wartosc.HIGH4 <= 9 && wartosc.HIGH4 >= 0)
                                        {
                                            wartosc.HIGH1 = wartosc.HIGH4;
                                            wartosc.HEX1 = "0" + wartosc.HIGH1 + "00";
                                            wartosc.AX = int.Parse(wartosc.HEX1, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;

                                        }
                                        else if (wartosc.HIGH4 <= 99)
                                        {
                                            wartosc.HIGH1 = wartosc.HIGH4;
                                            wartosc.HEX1 = wartosc.HIGH1 + "00";
                                            wartosc.AX = int.Parse(wartosc.HEX1, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;
                                        }


                                    }
                                    if (mov4 == 2) //DH->BH
                                    {
                                        if (wartosc.HIGH4 <= 9 && wartosc.HIGH4 >= 0)
                                        {
                                            wartosc.HIGH2 = wartosc.HIGH4;
                                            wartosc.HEX2 = "0" + wartosc.HIGH2 + "00";
                                            wartosc.BX = int.Parse(wartosc.HEX2, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;

                                        }
                                        else if (wartosc.HIGH4 <= 99)
                                        {
                                            wartosc.HIGH2 = wartosc.HIGH4;
                                            wartosc.HEX2 = wartosc.HIGH2 + "00";
                                            wartosc.BX = int.Parse(wartosc.HEX2, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;
                                        }
                                    }
                                    if (mov4 == 3) //DH->CH
                                    {
                                        if (wartosc.HIGH4 <= 9 && wartosc.HIGH4 >= 0)
                                        {
                                            wartosc.HIGH3 = wartosc.HIGH4;
                                            wartosc.HEX3 = "0" + wartosc.HIGH3 + "00";
                                            wartosc.CX = int.Parse(wartosc.HEX3, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;

                                        }
                                        else if (wartosc.HIGH4 <= 99)
                                        {
                                            wartosc.HIGH3 = wartosc.HIGH4;
                                            wartosc.HEX3 = wartosc.HIGH3 + "00";
                                            wartosc.CX = int.Parse(wartosc.HEX3, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;
                                        }
                                    }
                                    if (mov4 == 4) //DH->AL
                                    {
                                        if (wartosc.HIGH4 <= 9 && wartosc.HIGH4 >= 0)
                                        {
                                            wartosc.LOW1 = wartosc.HIGH4;
                                            wartosc.HEX1 = "000" + wartosc.LOW1;
                                            wartosc.AX = int.Parse(wartosc.HEX1, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;

                                        }
                                        else if (wartosc.HIGH4 <= 99)
                                        {
                                            wartosc.LOW1 = wartosc.HIGH4;
                                            wartosc.HEX1 = "00" + wartosc.LOW1;
                                            wartosc.AX = int.Parse(wartosc.HEX1, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;
                                        }
                                    }
                                    if (mov4 == 5) //DH->BL
                                    {
                                        if (wartosc.HIGH4 <= 9 && wartosc.HIGH4 >= 0)
                                        {
                                            wartosc.LOW2 = wartosc.HIGH4;
                                            wartosc.HEX2 = "000" + wartosc.LOW2;
                                            wartosc.BX = int.Parse(wartosc.HEX2, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;

                                        }
                                        else if (wartosc.HIGH4 <= 99)
                                        {
                                            wartosc.LOW2 = wartosc.HIGH4;
                                            wartosc.HEX2 = "00" + wartosc.LOW2;
                                            wartosc.BX = int.Parse(wartosc.HEX2, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;
                                        }
                                    }
                                    if (mov4 == 6)  //DH->CL
                                    {
                                        if (wartosc.HIGH4 <= 9 && wartosc.HIGH4 >= 0)
                                        {
                                            wartosc.LOW3 = wartosc.HIGH4;
                                            wartosc.HEX3 = $"000" + wartosc.LOW3;
                                            wartosc.CX = int.Parse(wartosc.HEX3, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;

                                        }
                                        else if (wartosc.HIGH4 <= 99)
                                        {
                                            wartosc.LOW3 = wartosc.HIGH4;
                                            wartosc.HEX3 = $"00" + wartosc.LOW3;
                                            wartosc.CX = int.Parse(wartosc.HEX3, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;
                                        }
                                    }
                                    if (mov4 == 7) //DH->DL
                                    {
                                        if (wartosc.HIGH4 <= 9 && wartosc.HIGH4 >= 0)
                                        {
                                            wartosc.LOW4 = wartosc.HIGH4;
                                            wartosc.HEX4 = $"0{wartosc.HIGH4.ToString()}0{wartosc.LOW4.ToString()}";
                                            wartosc.DX = int.Parse(wartosc.HEX4, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;

                                        }
                                        else if (wartosc.HIGH4 <= 99)
                                        {
                                            wartosc.LOW4 = wartosc.HIGH4;
                                            wartosc.HEX4 = $"{wartosc.HIGH4.ToString()}{wartosc.LOW4.ToString()}";
                                            wartosc.DX = int.Parse(wartosc.HEX4, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;
                                        }
                                    }
                                }
                                if (q == 5)
                                {

                                    Console.WriteLine("In which register you want to transfer the value:");
                                    Console.WriteLine("1.AH");
                                    Console.WriteLine("2.BH");
                                    Console.WriteLine("3.CH");
                                    Console.WriteLine("4.DH");
                                    Console.WriteLine("5.BL");
                                    Console.WriteLine("6.CL");
                                    Console.WriteLine("7.DL");
                                    int mov5 = int.Parse(Console.ReadLine());
                                    if (mov5 == 1) //AL->AH
                                    {
                                        if (wartosc.LOW1 <= 9 && wartosc.LOW1 >= 0)
                                        {
                                            wartosc.HIGH1 = wartosc.LOW1;
                                            wartosc.HEX1 = $"0{wartosc.HIGH1.ToString()}0{wartosc.LOW1.ToString()}";
                                            wartosc.AX = int.Parse(wartosc.HEX1, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;

                                        }
                                        else if (wartosc.LOW1 <= 99)
                                        {
                                            wartosc.HIGH1 = wartosc.LOW1;
                                            wartosc.HEX1 = $"{wartosc.HIGH1.ToString()}{wartosc.LOW1.ToString()}";
                                            wartosc.AX = int.Parse(wartosc.HEX1, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;
                                        }


                                    }
                                    if (mov5 == 2) //AL->BH
                                    {
                                        if (wartosc.LOW1 <= 9 && wartosc.LOW1 >= 0)
                                        {
                                            wartosc.HIGH2 = wartosc.LOW1;
                                            wartosc.HEX2 = "0" + wartosc.HIGH2 + "00";
                                            wartosc.BX = int.Parse(wartosc.HEX2, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;

                                        }
                                        else if (wartosc.LOW1 <= 99)
                                        {
                                            wartosc.HIGH2 = wartosc.LOW1;
                                            wartosc.HEX2 = wartosc.HIGH2 + "00";
                                            wartosc.BX = int.Parse(wartosc.HEX2, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;
                                        }
                                    }
                                    if (mov5 == 3) //AL->CH
                                    {
                                        if (wartosc.LOW1 <= 9 && wartosc.LOW1 >= 0)
                                        {
                                            wartosc.HIGH3 = wartosc.LOW1;
                                            wartosc.HEX3 = "0" + wartosc.HIGH3 + "00";
                                            wartosc.CX = int.Parse(wartosc.HEX3, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;

                                        }
                                        else if (wartosc.LOW1 <= 99)
                                        {
                                            wartosc.HIGH3 = wartosc.LOW1;
                                            wartosc.HEX3 = wartosc.HIGH3 + "00";
                                            wartosc.CX = int.Parse(wartosc.HEX3, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;
                                        }
                                    }
                                    if (mov5 == 4) //AL->DH
                                    {
                                        if (wartosc.LOW1 <= 9 && wartosc.LOW1 >= 0)
                                        {
                                            wartosc.HIGH4 = wartosc.LOW1;
                                            wartosc.HEX4 = "0" + wartosc.HIGH4 + "00";
                                            wartosc.DX = int.Parse(wartosc.HEX4, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;

                                        }
                                        else if (wartosc.LOW1 <= 99)
                                        {
                                            wartosc.HIGH4 = wartosc.LOW1;
                                            wartosc.HEX4 = wartosc.HIGH4 + "00";
                                            wartosc.DX = int.Parse(wartosc.HEX4, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;
                                        }
                                    }
                                    if (mov5 == 5) //AL->BL
                                    {
                                        if (wartosc.LOW1 <= 9 && wartosc.LOW1 >= 0)
                                        {
                                            wartosc.LOW2 = wartosc.LOW1;
                                            wartosc.HEX2 = "000" + wartosc.LOW2;
                                            wartosc.BX = int.Parse(wartosc.HEX2, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;

                                        }
                                        else if (wartosc.LOW1 <= 99)
                                        {
                                            wartosc.LOW2 = wartosc.LOW1;
                                            wartosc.HEX2 = "00" + wartosc.LOW2;
                                            wartosc.BX = int.Parse(wartosc.HEX2, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;
                                        }
                                    }
                                    if (mov5 == 6)  //AL->CL
                                    {
                                        if (wartosc.LOW1 <= 9 && wartosc.LOW1 >= 0)
                                        {
                                            wartosc.LOW3 = wartosc.LOW1;
                                            wartosc.HEX3 = $"000" + wartosc.LOW3;
                                            wartosc.CX = int.Parse(wartosc.HEX3, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;

                                        }
                                        else if (wartosc.LOW1 <= 99)
                                        {
                                            wartosc.LOW3 = wartosc.LOW1;
                                            wartosc.HEX3 = $"00" + wartosc.LOW3;
                                            wartosc.CX = int.Parse(wartosc.HEX3, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;
                                        }
                                    }
                                    if (mov5 == 7) //AL->DL
                                    {
                                        if (wartosc.LOW1 <= 9 && wartosc.LOW1 >= 0)
                                        {
                                            wartosc.LOW4 = wartosc.LOW1;
                                            wartosc.HEX4 = "000" + wartosc.LOW4;
                                            wartosc.DX = int.Parse(wartosc.HEX4, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;

                                        }
                                        else if (wartosc.LOW1 <= 99)
                                        {
                                            wartosc.LOW4 = wartosc.LOW1;
                                            wartosc.HEX4 = "00" + wartosc.LOW4;
                                            wartosc.DX = int.Parse(wartosc.HEX4, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;
                                        }
                                    }

                                }
                                if (q == 6)
                                {

                                    Console.WriteLine("In which register you want to transfer the value:");
                                    Console.WriteLine("1.AH");
                                    Console.WriteLine("2.BH");
                                    Console.WriteLine("3.CH");
                                    Console.WriteLine("4.DH");
                                    Console.WriteLine("5.AL");
                                    Console.WriteLine("6.CL");
                                    Console.WriteLine("7.DL");
                                    int mov6 = int.Parse(Console.ReadLine());
                                    if (mov6 == 1) //BL->AH
                                    {
                                        if (wartosc.LOW2 <= 9 && wartosc.LOW2 >= 0)
                                        {
                                            wartosc.HIGH1 = wartosc.LOW2;
                                            wartosc.HEX1 = "0" + wartosc.HIGH1 + "00";
                                            wartosc.AX = int.Parse(wartosc.HEX1, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;

                                        }
                                        else if (wartosc.LOW2 <= 99)
                                        {
                                            wartosc.HIGH1 = wartosc.LOW2;
                                            wartosc.HEX1 = wartosc.HIGH1 + "00";
                                            wartosc.AX = int.Parse(wartosc.HEX1, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;
                                        }


                                    }
                                    if (mov6 == 2) //BL->BH
                                    {
                                        if (wartosc.LOW2 <= 9 && wartosc.LOW2 >= 0)
                                        {
                                            wartosc.HIGH2 = wartosc.LOW2;
                                            wartosc.HEX2 = $"0{wartosc.HIGH2.ToString()}0{wartosc.LOW2.ToString()}";
                                            wartosc.BX = int.Parse(wartosc.HEX2, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;

                                        }
                                        else if (wartosc.LOW2 <= 99)
                                        {
                                            wartosc.HIGH2 = wartosc.LOW2;
                                            wartosc.HEX2 = $"{wartosc.HIGH2.ToString()}{wartosc.LOW2.ToString()}";
                                            wartosc.BX = int.Parse(wartosc.HEX2, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;
                                        }
                                    }
                                    if (mov6 == 3) //BL->CH
                                    {
                                        if (wartosc.LOW2 <= 9 && wartosc.LOW2 >= 0)
                                        {
                                            wartosc.HIGH3 = wartosc.LOW2;
                                            wartosc.HEX3 = "0" + wartosc.HIGH3 + "00";
                                            wartosc.CX = int.Parse(wartosc.HEX3, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;

                                        }
                                        else if (wartosc.LOW2 <= 99)
                                        {
                                            wartosc.HIGH3 = wartosc.LOW2;
                                            wartosc.HEX3 = wartosc.HIGH3 + "00";
                                            wartosc.CX = int.Parse(wartosc.HEX3, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;
                                        }
                                    }
                                    if (mov6 == 4) //BL->DH
                                    {
                                        if (wartosc.LOW2 <= 9 && wartosc.LOW2 >= 0)
                                        {
                                            wartosc.HIGH4 = wartosc.LOW2;
                                            wartosc.HEX4 = "0" + wartosc.HIGH4 + "00";
                                            wartosc.DX = int.Parse(wartosc.HEX4, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;

                                        }
                                        else if (wartosc.LOW2 <= 99)
                                        {
                                            wartosc.HIGH4 = wartosc.LOW2;
                                            wartosc.HEX4 = wartosc.HIGH4 + "00";
                                            wartosc.DX = int.Parse(wartosc.HEX4, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;
                                        }
                                    }
                                    if (mov6 == 5) //BL->AL
                                    {
                                        if (wartosc.LOW2 <= 9 && wartosc.LOW2 >= 0)
                                        {
                                            wartosc.LOW1 = wartosc.LOW2;
                                            wartosc.HEX1 = "000" + wartosc.LOW1;
                                            wartosc.AX = int.Parse(wartosc.HEX1, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;

                                        }
                                        else if (wartosc.LOW2 <= 99)
                                        {
                                            wartosc.LOW1 = wartosc.LOW2;
                                            wartosc.HEX1 = "00" + wartosc.LOW1;
                                            wartosc.AX = int.Parse(wartosc.HEX1, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;
                                        }
                                    }
                                    if (mov6 == 6)  //BL->CL
                                    {
                                        if (wartosc.LOW2 <= 9 && wartosc.LOW2 >= 0)
                                        {
                                            wartosc.LOW3 = wartosc.LOW2;
                                            wartosc.HEX3 = $"000" + wartosc.LOW3;
                                            wartosc.CX = int.Parse(wartosc.HEX3, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;

                                        }
                                        else if (wartosc.LOW2 <= 99)
                                        {
                                            wartosc.LOW3 = wartosc.LOW2;
                                            wartosc.HEX3 = $"00" + wartosc.LOW3;
                                            wartosc.CX = int.Parse(wartosc.HEX3, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();

                                            goto Wroc;
                                        }
                                    }
                                    if (mov6 == 7) //BL->DL
                                    {
                                        if (wartosc.LOW2 <= 9 && wartosc.LOW2 >= 0)
                                        {
                                            wartosc.LOW4 = wartosc.LOW2;
                                            wartosc.HEX4 = "000" + wartosc.LOW4;
                                            wartosc.DX = int.Parse(wartosc.HEX4, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;

                                        }
                                        else if (wartosc.LOW2 <= 99)
                                        {
                                            wartosc.LOW4 = wartosc.LOW2;
                                            wartosc.HEX4 = "00" + wartosc.LOW4;
                                            wartosc.DX = int.Parse(wartosc.HEX4, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;
                                        }
                                    }
                                }
                                if (q == 7)
                                {

                                    Console.WriteLine("In which register you want to transfer the value:");
                                    Console.WriteLine("1.AH");
                                    Console.WriteLine("2.BH");
                                    Console.WriteLine("3.CH");
                                    Console.WriteLine("4.DH");
                                    Console.WriteLine("5.AL");
                                    Console.WriteLine("6.BL");
                                    Console.WriteLine("7.DL");
                                    int mov7 = int.Parse(Console.ReadLine());
                                    if (mov7 == 1) //CL->AH
                                    {
                                        if (wartosc.LOW3 <= 9 && wartosc.LOW3 >= 0)
                                        {
                                            wartosc.HIGH1 = wartosc.LOW3;
                                            wartosc.HEX1 = "0" + wartosc.HIGH1 + "00";
                                            wartosc.AX = int.Parse(wartosc.HEX1, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;

                                        }
                                        else if (wartosc.LOW3 <= 99)
                                        {
                                            wartosc.HIGH1 = wartosc.LOW3;
                                            wartosc.HEX1 = wartosc.HIGH1 + "00";
                                            wartosc.AX = int.Parse(wartosc.HEX1, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;
                                        }


                                    }
                                    if (mov7 == 2) //CL->BH
                                    {
                                        if (wartosc.LOW3 <= 9 && wartosc.LOW3 >= 0)
                                        {
                                            wartosc.HIGH2 = wartosc.LOW3;
                                            wartosc.HEX2 = "0" + wartosc.HIGH2 + "00";
                                            wartosc.BX = int.Parse(wartosc.HEX2, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;

                                        }
                                        else if (wartosc.LOW3 <= 99)
                                        {
                                            wartosc.HIGH2 = wartosc.LOW3;
                                            wartosc.HEX2 = wartosc.HIGH2 + "00";
                                            wartosc.BX = int.Parse(wartosc.HEX2, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;
                                        }
                                    }
                                    if (mov7 == 3) //CL->CH
                                    {
                                        if (wartosc.LOW3 <= 9 && wartosc.LOW3 >= 0)
                                        {
                                            wartosc.HIGH3 = wartosc.LOW3;
                                            wartosc.HEX3 = $"0{wartosc.HIGH3.ToString()}0{wartosc.LOW3.ToString()}";
                                            wartosc.CX = int.Parse(wartosc.HEX3, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;

                                        }
                                        else if (wartosc.LOW3 <= 99)
                                        {
                                            wartosc.HIGH3 = wartosc.LOW3;
                                            wartosc.HEX3 = $"{wartosc.HIGH3.ToString()}{wartosc.LOW3.ToString()}";
                                            wartosc.CX = int.Parse(wartosc.HEX3, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;
                                        }
                                    }
                                    if (mov7 == 4) //CL->DH
                                    {
                                        if (wartosc.LOW3 <= 9 && wartosc.LOW3 >= 0)
                                        {
                                            wartosc.HIGH4 = wartosc.LOW3;
                                            wartosc.HEX4 = "0" + wartosc.HIGH4 + "00";
                                            wartosc.DX = int.Parse(wartosc.HEX4, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;

                                        }
                                        else if (wartosc.LOW3 <= 99)
                                        {
                                            wartosc.HIGH4 = wartosc.LOW3;
                                            wartosc.HEX4 = wartosc.HIGH4 + "00";
                                            wartosc.DX = int.Parse(wartosc.HEX4, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;
                                        }
                                    }
                                    if (mov7 == 5) //CL->AL
                                    {
                                        if (wartosc.LOW3 <= 9 && wartosc.LOW3 >= 0)
                                        {
                                            wartosc.LOW1 = wartosc.LOW3;
                                            wartosc.HEX1 = "000" + wartosc.LOW1;
                                            wartosc.AX = int.Parse(wartosc.HEX1, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;

                                        }
                                        else if (wartosc.LOW3 <= 99)
                                        {
                                            wartosc.LOW1 = wartosc.LOW3;
                                            wartosc.HEX1 = "00" + wartosc.LOW1;
                                            wartosc.AX = int.Parse(wartosc.HEX1, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;
                                        }
                                    }
                                    if (mov7 == 6)  //CL->BL
                                    {
                                        if (wartosc.LOW3 <= 9 && wartosc.LOW3 >= 0)
                                        {
                                            wartosc.LOW2 = wartosc.LOW3;
                                            wartosc.HEX2 = $"000" + wartosc.LOW2;
                                            wartosc.BX = int.Parse(wartosc.HEX2, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;

                                        }
                                        else if (wartosc.LOW3 <= 99)
                                        {
                                            wartosc.LOW2 = wartosc.LOW3;
                                            wartosc.HEX2 = $"00" + wartosc.LOW2;
                                            wartosc.BX = int.Parse(wartosc.HEX2, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;
                                        }
                                    }
                                    if (mov7 == 7) //CL->DL
                                    {
                                        if (wartosc.LOW3 <= 9 && wartosc.LOW3 >= 0)
                                        {
                                            wartosc.LOW4 = wartosc.LOW3;
                                            wartosc.HEX4 = "000" + wartosc.LOW4;
                                            wartosc.DX = int.Parse(wartosc.HEX4, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;

                                        }
                                        else if (wartosc.LOW3 <= 99)
                                        {
                                            wartosc.LOW4 = wartosc.LOW3;
                                            wartosc.HEX4 = "00" + wartosc.LOW4;
                                            wartosc.DX = int.Parse(wartosc.HEX4, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto Wroc;
                                        }
                                    }
                                }
                                if (q == 8)
                                {

                                    Console.WriteLine("In which register you want to transfer the value:");
                                    Console.WriteLine("1.AH");
                                    Console.WriteLine("2.BH");
                                    Console.WriteLine("3.CH");
                                    Console.WriteLine("4.DH");
                                    Console.WriteLine("5.AL");
                                    Console.WriteLine("6.BL");
                                    Console.WriteLine("7.CL");
                                    int mov8 = int.Parse(Console.ReadLine());
                                    if (mov8 == 1) //DL->AH
                                    {
                                        if (wartosc.LOW4 <= 9 && wartosc.LOW4 >= 0)
                                        {
                                            wartosc.HIGH1 = wartosc.LOW4;
                                            wartosc.HEX1 = "0" + wartosc.HIGH1 + "00";
                                            wartosc.AX = int.Parse(wartosc.HEX1, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();

                                            goto Wroc;

                                        }
                                        else if (wartosc.LOW4 <= 99)
                                        {
                                            wartosc.HIGH1 = wartosc.LOW4;
                                            wartosc.HEX1 = wartosc.HIGH1 + "00";
                                            wartosc.AX = int.Parse(wartosc.HEX1, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();

                                            goto Wroc;
                                        }


                                    }
                                    if (mov8 == 2) //DL->BH
                                    {
                                        if (wartosc.LOW4 <= 9 && wartosc.LOW4 >= 0)
                                        {
                                            wartosc.HIGH2 = wartosc.LOW4;
                                            wartosc.HEX2 = "0" + wartosc.HIGH2 + "00";
                                            wartosc.BX = int.Parse(wartosc.HEX2, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();

                                            goto Wroc;

                                        }
                                        else if (wartosc.LOW4 <= 99)
                                        {
                                            wartosc.HIGH2 = wartosc.LOW4;
                                            wartosc.HEX2 = wartosc.HIGH2 + "00";
                                            wartosc.BX = int.Parse(wartosc.HEX2, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();

                                            goto Wroc;
                                        }
                                    }
                                    if (mov8 == 3) //DL->CH
                                    {
                                        if (wartosc.LOW4 <= 9 && wartosc.LOW4 >= 0)
                                        {
                                            wartosc.HIGH3 = wartosc.LOW4;
                                            wartosc.HEX3 = "0" + wartosc.HIGH3 + "00";
                                            wartosc.CX = int.Parse(wartosc.HEX3, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();

                                            goto Wroc;

                                        }
                                        else if (wartosc.LOW4 <= 99)
                                        {
                                            wartosc.HIGH3 = wartosc.LOW4;
                                            wartosc.HEX3 = wartosc.HIGH3 + "00";
                                            wartosc.CX = int.Parse(wartosc.HEX3, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();

                                            goto Wroc;
                                        }
                                    }
                                    if (mov8 == 4) //DL->DH
                                    {
                                        if (wartosc.LOW4 <= 9 && wartosc.LOW4 >= 0)
                                        {
                                            wartosc.HIGH4 = wartosc.LOW4;
                                            wartosc.HEX4 = $"0{wartosc.HIGH4.ToString()}0{wartosc.LOW4.ToString()}";
                                            wartosc.DX = int.Parse(wartosc.HEX4, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();

                                            goto Wroc;

                                        }
                                        else if (wartosc.LOW4 <= 99)
                                        {
                                            wartosc.HIGH4 = wartosc.LOW4;
                                            wartosc.HEX4 = $"{wartosc.HIGH4.ToString()}{wartosc.LOW4.ToString()}";
                                            wartosc.DX = int.Parse(wartosc.HEX4, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();

                                            goto Wroc;
                                        }
                                    }
                                    if (mov8 == 5) //DL->AL
                                    {
                                        if (wartosc.LOW4 <= 9 && wartosc.LOW4 >= 0)
                                        {
                                            wartosc.LOW1 = wartosc.LOW4;
                                            wartosc.HEX1 = "000" + wartosc.LOW1;
                                            wartosc.AX = int.Parse(wartosc.HEX1, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();

                                            goto Wroc;

                                        }
                                        else if (wartosc.LOW4 <= 99)
                                        {
                                            wartosc.LOW1 = wartosc.LOW4;
                                            wartosc.HEX1 = "00" + wartosc.LOW1;
                                            wartosc.AX = int.Parse(wartosc.HEX1, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();

                                            goto Wroc;
                                        }
                                    }
                                    if (mov8 == 6)  //DL->BL
                                    {
                                        if (wartosc.LOW4 <= 9 && wartosc.LOW4 >= 0)
                                        {
                                            wartosc.LOW2 = wartosc.LOW4;
                                            wartosc.HEX2 = $"000" + wartosc.LOW2;
                                            wartosc.BX = int.Parse(wartosc.HEX2, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();

                                            goto Wroc;

                                        }
                                        else if (wartosc.LOW4 <= 99)
                                        {
                                            wartosc.LOW2 = wartosc.LOW4;
                                            wartosc.HEX2 = $"00" + wartosc.LOW2;
                                            wartosc.BX = int.Parse(wartosc.HEX2, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();

                                            goto Wroc;
                                        }
                                    }
                                    if (mov8 == 7) //DL->CL
                                    {
                                        if (wartosc.LOW4 <= 9 && wartosc.LOW4 >= 0)
                                        {
                                            wartosc.LOW3 = wartosc.LOW4;
                                            wartosc.HEX3 = "000" + wartosc.LOW3;
                                            wartosc.CX = int.Parse(wartosc.HEX3, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();

                                            goto Wroc;

                                        }
                                        else if (wartosc.LOW4 <= 99)
                                        {
                                            wartosc.LOW3 = wartosc.LOW4;
                                            wartosc.HEX3 = "00" + wartosc.LOW3;
                                            wartosc.CX = int.Parse(wartosc.HEX3, System.Globalization.NumberStyles.HexNumber);
                                            Console.WriteLine("Done! Click any button to return to menu.");
                                            Console.ReadLine();
                                            Console.Clear();

                                            goto Wroc;
                                        }
                                    }
                                }

                            }
                            else
                            {
                                Console.ResetColor();
                                Console.WriteLine("Wrong.");
                                Console.WriteLine("Back to menu");
                                Thread.Sleep(2000);

                                Console.Clear();
                                goto Wroc;
                            }


                        }
                        catch (Exception X)
                        {
                            Console.ResetColor();
                            Console.WriteLine(X.Message);
                            Console.WriteLine("Wrong. Back to menu..");
                            Thread.Sleep(2000);

                            Console.Clear();
                            goto Wroc;
                        }

                        //Pokazanie aktualnych wartości rejestrów
                    }
                    else if (menu == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Choose first register");

                        Console.WriteLine("1.AH");
                        Console.WriteLine("2.BH");
                        Console.WriteLine("3.CH");
                        Console.WriteLine("4.DH");
                        Console.WriteLine("5.AL");
                        Console.WriteLine("6.BL");
                        Console.WriteLine("7.CL");
                        Console.WriteLine("8.DL");
                        int add = int.Parse(Console.ReadLine());
                        if (add == 1) //AH +
                        {
                            Console.WriteLine("Which register you want to add:");

                            Console.WriteLine("1.BH");
                            Console.WriteLine("2.CH");
                            Console.WriteLine("3.DH");
                            Console.WriteLine("4.AL");
                            Console.WriteLine("5.BL");
                            Console.WriteLine("6.CL");
                            Console.WriteLine("7.DL");

                        }
                        else if (add == 2) //BH +
                        {
                            Console.WriteLine("Which register you want to add :");
                        }
                        else if (add == 3) //CH +
                        {
                            Console.WriteLine("Which register you want to add:");
                        }
                        else if (add == 4) //DH +
                        {
                            Console.WriteLine("Which register you want to add:");
                        }
                        else if (add == 5) // AL +
                        {
                            Console.WriteLine("Which register you want to add:");
                        }
                        else if (add == 6) // BL +
                        {
                            Console.WriteLine("Which register you want to add:");
                        }
                        else if (add == 7) // CL +
                        {
                            Console.WriteLine("Which register you want to add:");
                        }
                        else if (add == 8) // DL +
                        {
                            Console.WriteLine("Which register you wanna add:");
                        }


                    }
                    else if (menu == 4)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Value AX DEC: {wartosc.AX} HEX: {wartosc.HEX1} HIGH: {wartosc.HIGH1} LOW: {wartosc.LOW1}");
                        Console.WriteLine($"Value BX DEC: {wartosc.BX} HEX: {wartosc.HEX2} HIGH: {wartosc.HIGH2} LOW: {wartosc.LOW2}");
                        Console.WriteLine($"Value CX DEC: {wartosc.CX} HEX: {wartosc.HEX3} HIGH: {wartosc.HIGH3} LOW: {wartosc.LOW3}");
                        Console.WriteLine($"Value DX DEC: {wartosc.DX} HEX: {wartosc.HEX4} HIGH: {wartosc.HIGH4} LOW: {wartosc.LOW4}");


                        Console.WriteLine("Click any button to return to menu.");
                        Console.ResetColor();

                        Console.ReadLine();
                        Console.Clear();
                        goto Wroc;

                    }
                    //Wyczyszczenie wartości rejestrów
                    else if (menu == 5)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("Values have been deleted!");
                        wartosc.AX = 0;
                        wartosc.BX = 0;
                        wartosc.CX = 0;
                        wartosc.DX = 0;
                        wartosc.value1 = 0;
                        wartosc.value2 = 0;
                        wartosc.value3 = 0;
                        wartosc.value4 = 0;
                        wartosc.HEX1 = "0";
                        wartosc.HEX2 = "0";
                        wartosc.HEX3 = "0";
                        wartosc.HEX4 = "0";
                        wartosc.HIGH1 = 0;
                        wartosc.HIGH2 = 0;
                        wartosc.HIGH3 = 0;
                        wartosc.HIGH4 = 0;
                        wartosc.LOW1 = 0;
                        wartosc.LOW2 = 0;
                        wartosc.LOW3 = 0;
                        wartosc.LOW4 = 0;
                        Console.WriteLine($"Value AX DEC: {wartosc.AX} HEX: {wartosc.HEX1} HIGH: {wartosc.HIGH1} LOW: {wartosc.LOW1}");
                        Console.WriteLine($"Value BX DEC: {wartosc.BX} HEX: {wartosc.HEX2} HIGH: {wartosc.HIGH2} LOW: {wartosc.LOW2}");
                        Console.WriteLine($"Value CX DEC: {wartosc.CX} HEX: {wartosc.HEX3} HIGH: {wartosc.HIGH3} LOW: {wartosc.LOW3}");
                        Console.WriteLine($"Value DX DEC: {wartosc.DX} HEX: {wartosc.HEX4} HIGH: {wartosc.HIGH4} LOW: {wartosc.LOW4}");
                        Console.WriteLine("Click any button to return to menu");
                        Console.ResetColor();
                        Console.ReadLine();
                        Console.Clear();
                        goto Wroc;
                    }

                    else
                    {
                        Console.WriteLine("Failure.");
                        Console.WriteLine("Click any button to return.");
                        Console.ReadLine();
                        goto Wroc;

                    }
                }
            }
            catch (Exception F)
            {

                Console.WriteLine(F.Message);
                Console.WriteLine("Click any button to return.");
                Console.ReadLine();
                Console.Clear();
                goto Wroc;
            }
        }
    }
}