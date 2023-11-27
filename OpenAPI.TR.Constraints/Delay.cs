using System.Diagnostics;

namespace ShareInvest;

public sealed class Delay : IDisposable
{
    public static Delay Instance
    {
        get => Request ??= new Delay();
    }
    public int Milliseconds
    {
        private get; set;
    }
    public int Count
    {
        get => task.Count;
    }
    public void Run()
    {
        if (System.Threading.ThreadState.Unstarted.Equals(worker.ThreadState))
        {
            worker.Start();
        }
    }
    public void Dispose()
    {
        task.Clear();

        cts.Cancel();
    }
    public void RequestTheMission(Task task)
    {
        this.task.Enqueue(task);
    }
    Delay()
    {
        worker = new Thread(delegate ()
        {
            while (cts?.Token.IsCancellationRequested is false && task != null)
            {
                while (this.task.TryDequeue(out Task? task))
                {
                    try
                    {
                        task.RunSynchronously();

                        Thread.Sleep(Milliseconds + ShareInvest.Request.CheckAndResetLimits());
                    }
                    catch (Exception ex)
                    {
#if DEBUG
                        Debug.WriteLine(ex.Message);
#else
                        Console.WriteLine(ex.Message);
#endif
                    }
                    Debug.WriteLine(this.task.Count);
                }
                Thread.Sleep(task.Count > 0 ? 0x1 : 0xA);
            }
        });
        task = new Queue<Task>();
        cts = new CancellationTokenSource();
    }
    static Delay? Request
    {
        get; set;
    }
    readonly Thread worker;
    readonly Queue<Task> task;
    readonly CancellationTokenSource cts;
}