// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
class process{
  public event EventHandler Startprocess;
  public void processprog(){
      Console.WriteLine ("program started");
      OnStartprocess(EventArgs.Empty);
  }
  protected virtual void OnStartprocess(EventArgs e){
      Startprocess?.Invoke(this,e);
  }
}
public class eventhandler
{
    public static void Main(string[] args)
    {
        process a=new process();
        a.Startprocess+=a_startprocess;
        a.processprog();
    }
     public static void a_startprocess(object sender,EventArgs e){
            Console.WriteLine ("program executed");
        }
}