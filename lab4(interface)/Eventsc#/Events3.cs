// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
class process{
  public event EventHandler<bool> Startprocess;
  public void processprog(){
      try{
      Console.WriteLine ("program started");
      OnStartprocess(true);
      }catch(Exception ex){
          OnStartprocess(false);
      }
  }
  protected virtual void OnStartprocess(bool IsSucc){
      Startprocess?.Invoke(this,IsSucc);
  }
}
public class Events3
{
    public static void Main(string[] args)
    {
        process a=new process();
        a.Startprocess+=a_startprocess;
        a.processprog();
    }
     public static void a_startprocess(object sender,bool IsSucc){
            Console.WriteLine ("program"+(IsSucc?"completed successfully":"False"));
        }
}