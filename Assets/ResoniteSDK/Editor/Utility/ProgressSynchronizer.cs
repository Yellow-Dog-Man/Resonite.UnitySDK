using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

public class ProgressSynchronizer : IDisposable
{
    AutoResetEvent resetEvent;

    public string Info { get; private set; }
    public float Progress { get; private set; }
    public bool Done { get; private set; }

    public ProgressSynchronizer()
    {
        resetEvent = new AutoResetEvent(false);
    }

    public void UpdateProgress(string info, float progress)
    {
        Info = info;
        Progress = progress;

        resetEvent.Set();
    }

    public void Complete()
    {
        Done = true;

        resetEvent.Set();
    }

    public void WaitForProgress() => resetEvent.WaitOne();

    public void Dispose()
    {
        resetEvent.Dispose();
    }
}

