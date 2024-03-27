using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ioos
{
    internal class bianry
    {
        static void main(string[] args)
        {
            int ii = 6;
            Double db = 2.3;
            string s = "hello hii";
            float f = 6.77f;
            BinaryWriter bw;
            BinaryReader br;
            bw = new BinaryWriter(new FileStream("BinaryFile", FileMode.Create));
            bw.Write(ii);
            bw.Write(db);
            bw.Write(s);
            bw.Write(f);
            bw.Close();
            br = new BinaryReader(new FileStream("BinaryFile.", FileMode.Open));
            Console.WriteLine("the int value={0}", br.ReadInt32());
            Console.WriteLine("the double value={0}", br.ReadDouble());
            Console.WriteLine("the string value={0}", br.Read());
            Console.WriteLine("the float value={0}", br.ReadDecimal());
            br.Close();
            Console.ReadKey();
        }
    }
}
