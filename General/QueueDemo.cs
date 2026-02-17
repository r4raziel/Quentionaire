using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Questionaire
{
    public class QueueDemo
    {
        // Thread-safe queue shared by all tasks
        private static readonly ConcurrentQueue<string> _workQueue = new();

        public static async Task RunDemoAsync()
        {
            // 1. Start multiple tasks that "Produce" data
            var producers = Enumerable.Range(1, 3).Select(i => Task.Run(() => {
                _workQueue.Enqueue($"Task {i} Data"); // Simple thread-safe add
            }));

            await Task.WhenAll(producers);

            // 2. Start multiple tasks that "Consume" data
            var consumers = Enumerable.Range(1, 2).Select(async i => {
                // TryDequeue returns true if it successfully got an item
                while (_workQueue.TryDequeue(out string? item)) 
                {
                    await Task.Delay(50); // Simulate async work
                    Console.WriteLine($"Consumer {i} processed: {item}");
                } 
            });

            await Task.WhenAll(consumers);
        }
    }
}