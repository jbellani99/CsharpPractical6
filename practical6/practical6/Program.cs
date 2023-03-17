using System;

public delegate void Notify();

public class ProcessBussinessLogic {

    public int flag = 0;    
    public event Notify ProcessCompleted;

    /// <summary>
    /// it's Start the process and call OnprocessCompleted
    /// <return>
    /// void 
    /// </return>
    /// </summary>

    public void StartProcess() {

        Console.WriteLine("Process Started..");
        OnprocessCompeleted();
            
    
    }

    /// <summary>
    /// It's call ProcessCompleted function
    /// <return>
    /// void
    /// </return>
    /// </summary>
    protected virtual void OnprocessCompeleted() {
        
            ProcessCompleted?.Invoke();
           

    }


}


public class call { 

            public static void Main(string[] args) { 
    
                ProcessBussinessLogic bl = new ProcessBussinessLogic(); 
                    bl.flag = 0;
                    bl.ProcessCompleted += ProcessCompleted;
        bl.StartProcess();  

       

    
    }

    /// <summary>
    /// It's acknowledge the event is done
    /// <return>
    /// void
    /// </return>
    /// </summary>
    static void ProcessCompleted()
    {

        Console.WriteLine("Method Invoked..");


    }

} 