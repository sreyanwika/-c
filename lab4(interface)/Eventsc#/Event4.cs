// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
public class processdata:EventArgs{
    public bool proc{get;set;}
    public DateTime custTime{get;set;}
}
public class HelloWorld
{
    public static void Main(string[] args)
    {
        process a=new process();
        a.Startprocess+=a_Startprocess;
        a.processprog();
    }
     public static void a_Startprocess(object sender,processdata e){
            Console.WriteLine ("program"+(e.proc?"completed successfully":"False"));
            Console.WriteLine ("cust time"+e.custTime.ToLongDateString());
        }
}
public class process{
  public event EventHandler<processdata> Startprocess;
  public void processprog(){
      var data=new processdata();
      try{
      Console.WriteLine ("program started");
      data.proc=true;
      data.custTime=DateTime.Now;
      OnStartprocess(data);
      }catch(Exception ex){
          data.proc=false;
          data.custTime=DateTime.Now;
          OnStartprocess(data);
      }
  }
  protected virtual void OnStartprocess(processdata e){
      Startprocess?.Invoke(this,e);
  }
}