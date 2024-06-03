namespace RLogger;

public sealed class Logger
{
    private readonly string _filePath;
    private readonly int _batchSize;
    private readonly List<string> _logs = new List<string>();

    public Logger(string filePath, int batchSize = 1)
    {
        _filePath = filePath;
        _batchSize = batchSize;
    }

    public void Log(string message)
    {
        _logs.Add(message);
        if (_logs.Count >= _batchSize)
        {
            _=WriteAsync();
        }
    }

    private async Task WriteAsync()
    {
        List<string> logsToWrite;

        lock (_logs)
        {
            logsToWrite = new List<string>(_logs);
            _logs.Clear();
        }

        await Task.Run(() =>
        {
            using (var writer = new StreamWriter(_filePath,false))
            {
                foreach (var log in logsToWrite)
                {
                    writer.WriteLine($"{DateTime.Now}: {log}");
                }
            }
        });
    }
}
