using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ioos
{
    internal class Texamp
    {
        static void main(string[] args)
        {
            string fn = "file.txt";
            if(File.Exists(fn))
            {
                Console.WriteLine("{0} file already exists", fn);
                Console.WriteLine("rename file");
                return;
            }
            
            using (FileStream fs = new FileStream(fn, FileMode.CreateNew))
            {
                using (BinaryWriter bw = new BinaryWriter(fs))
                {
                    for(int i = 0; i < 20; i++)
                    {
                        bw.Write(i);
                    }
                    bw.Close();
                }
                
            }
            using (FileStream fs = new FileStream(fn, FileMode.Open,FileAccess.Read))
            {
                using (BinaryReader br = new BinaryReader(fs))
                {
                    for (int i = 0; i < 20; i++)
                    {
                        Console.WriteLine(br.ReadInt32());
                    }
                    br.Close();
                }

            }
            Console.ReadKey();
        }
    }
}
