using System;

namespace taskbench
{
    using System.Threading.Tasks;
    using System.Linq;
    using BenchmarkDotNet.Configs;
    using BenchmarkDotNet.Jobs;
    using BenchmarkDotNet.Attributes;
    using BenchmarkDotNet.Attributes.Jobs;
    using BenchmarkDotNet.Running;
    using System.Collections.Concurrent;
    [Config(typeof(MultipleRuntime))]
    public class WhenAllBench
    {
        [Params(10000)]
        public int LoopNum;
        [Params(1, 10, 100)]
        public int TaskNum;
        [Benchmark]
        public async Task TaskYield()
        {
            var queue = new ConcurrentQueue<int>();
            await Task.WhenAll(Enumerable.Range(0, TaskNum).Select(async (idx) =>
            {
                await Task.Yield();
            })).ConfigureAwait(false);
        }
        [Benchmark]
        public async Task TaskCompletedTask()
        {
            var queue = new ConcurrentQueue<int>();
            await Task.WhenAll(Enumerable.Range(0, TaskNum).Select((idx) =>
            {
                return Task.CompletedTask;
            })).ConfigureAwait(false);
        }
        [Benchmark]
        public async Task TaskYieldQueue()
        {
            var queue = new ConcurrentQueue<int>();
            await Task.WhenAll(Enumerable.Range(0, TaskNum).Select(async (idx) =>
            {
                await Task.Yield();
                for (int i = 0; i < LoopNum; i++)
                {
                    queue.Enqueue(i);
                }
            })).ConfigureAwait(false);
        }
        [Benchmark]
        public async Task TaskCompletedTaskQueue()
        {
            var queue = new ConcurrentQueue<int>();
            await Task.WhenAll(Enumerable.Range(0, TaskNum).Select((idx) =>
            {
                for (int i = 0; i < LoopNum; i++)
                {
                    queue.Enqueue(i);
                }
                return Task.CompletedTask;
            })).ConfigureAwait(false);
        }
    }
    class MultipleRuntime : ManualConfig
    {
        public MultipleRuntime()
        {
            Add(Job.Default.With(BenchmarkDotNet.Toolchains.CsProj.CsProjCoreToolchain.NetCoreApp21)
                .WithTargetCount(5)
                .WithWarmupCount(5));
            Add(Job.Default.With(BenchmarkDotNet.Toolchains.CsProj.CsProjCoreToolchain.NetCoreApp20)
                .WithTargetCount(5)
                .WithWarmupCount(5));
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            var reporter = BenchmarkRunner.Run<WhenAllBench>();
        }
    }
}
