using System;
public delegate void Notify();
class process{
  public event Notify Startprocess;
  public void processprog(){
      Console.WriteLine ("program started");
      OnStartprocess();
  }
  protected virtual void OnStartprocess(){
      Startprocess?.Invoke();
  }
}
public class Event
{
    public static void Main(string[] args)
    {
        process a=new process();
        a.Startprocess+=a_startprocess;
        a.processprog();
    }
     public static void a_startprocess(){
            Console.WriteLine ("program executed");
        }
}