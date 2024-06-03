using RLogger;

Logger logger = new("logs.txt", 1000);

for (int i = 1; i < 1300; i++)
{
    logger.Log($"Log {i}");
}

Console.WriteLine("Finished");

Console.ReadKey();