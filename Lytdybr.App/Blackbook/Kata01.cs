namespace Lytdybr.App.Blackbook;

/// <summary>
/// Задача:
/// 100 потоков увеличивают общий счётчик до 1_000_000
/// Реализовать через:
/// lock
/// Interlocked
/// Цель:
/// Почувствовать разницу в производительности
/// Понять lock contention
/// </summary>
public class Kata01(int threadsNumber, int limit)
{
    public enum IncrementStrategy
    {
        Lock,
        Interlocked
    }

    private int _counter;
    private readonly Lock _lock = new();
    public int Do() => Do(IncrementStrategy.Interlocked);

    public int Do(IncrementStrategy strategy)
    {
        var increment = strategy switch
        {
            IncrementStrategy.Lock => Increment1,
            IncrementStrategy.Interlocked => Increment2,
            _ => throw new ArgumentOutOfRangeException(nameof(strategy), strategy, null)
        };

        var threads = new Thread[threadsNumber];
        for (var i = 0; i < threadsNumber; i++)
        {
            threads[i] = new Thread(increment);
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
        while (true)
        {
            lock (_lock)
            {
                if (_counter >= limit)
                {
                    break;
                }

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