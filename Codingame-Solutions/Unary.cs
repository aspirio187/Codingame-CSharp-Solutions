using System;
using System.Collections.Generic;
using System.Text;

namespace Codingame_Solutions
{
    public static class Unary
    {
        public static void UnarySolution()
        {
            string MESSAGE = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            foreach (char c in MESSAGE)
            {
                string binary = Convert.ToString((int)c, 2).PadLeft(7, '0');

                while(binary.Length > 0)
                {
                    bool is1 = Convert.ToBoolean(int.Parse(binary[0].ToString()));
                    sb.Append(is1 ? "0 " : "00 ");
                    int sub = is1 ? binary.IndexOf('0') : binary.IndexOf('1');
                    string tmp = sub >= 0 ? binary.Substring(0, sub) : binary;
                    int nb = tmp.Length;
                    binary = binary.Substring(tmp.Length, binary.Length - tmp.Length);

                    sb.Append('0', nb);
                    sb.Append(' ');
                }     

                //for (int i = 0; i < binary.Length; i++)
                //{
                //    int sub;
                //    if (binary[i] == '1')
                //    {
                //        sb.Append("0 ");
                //        sub = binary.IndexOf('0');
                //    }
                //    else
                //    {
                //        sb.Append("00 ");
                //        sub = binary.IndexOf('1');
                //    }

                //    string tmp = sub >= 0 ? binary.Substring(i, sub) : binary.Substring(i, binary.Length);
                //    int nb = tmp.Length;
                //    binary = binary.Substring(tmp.Length, binary.Length - tmp.Length);

                //    sb.Append('0', nb);
                //    sb.Append(' ');
                //    i--;
                //}
            }

            // Write an answer using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");

            Console.WriteLine(sb.ToString().Trim());
        }
    }
}
