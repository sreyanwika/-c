// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string[] f=new string[]{"sreya","poorvitha","harshini","afreen"};
        using(StreamWriter sw=new StreamWriter("f.txt")){
            foreach(string s in f){
                sw.WriteLine(s);
            }
        }
        //reating the file to teh output
        string line="";
        using(StreamReader rd=new StreamReader("f.txt")){
            while ((line = rd.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
            Console.ReadLine();
        }
        
        }
}