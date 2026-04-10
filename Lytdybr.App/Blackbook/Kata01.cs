namespace Lytdybr.App.Blackbook;

/// <summary>
/// Задача:
/// 100 потоков увеличивают общий счётчик до 1_000_000
/// Реализовать через:
/// lock
/// Interlocked
/// ConcurrentDictionary (как костыль 😄)
/// Цель:
/// Почувствовать разницу в производительности
/// Понять lock contention
/// </summary>
public class Kata01(int threadsNumber, int limit)
{
    private int _counter;
    private readonly Lock _lock = new();
    public int Do()
    {
        var threads = new Thread[threadsNumber];
        for (var i = 0; i < threadsNumber; i++)
        {
            threads[i] = new Thread(Increment2);
            threads[i].Start();
        }

        foreach (var thread in threads)
        {
            thread.Join();
        }
        
        return _counter;
    }

    private void Increment1()
    {
        lock (_lock)
        {
            while (_counter < limit)
            {
                _counter++;
            }
        }
    }

    private void Increment2()
    {
        while (true)
        {
            var current = _counter;
            if (current >= limit)
            {
                break;
            }

            Interlocked.CompareExchange(ref _counter, current + 1, current);
        }
    }
}