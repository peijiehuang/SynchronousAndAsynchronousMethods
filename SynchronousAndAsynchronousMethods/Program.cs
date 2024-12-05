namespace SynchronousAndAsynchronousMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //同步方法
            // SynchronousMethod();

            //异步方法
            //AsynchronousMethod().Wait();

            ProcessDataAsync().Wait();
            Console.ReadKey();
        }

        /// <summary>
        /// 异步方法
        /// </summary>
        /// <returns></returns>
        public static async Task ProcessDataAsync()
        {
            Console.WriteLine("开始处理数据");
            // 异步任务启动，但没有 await，直接执行后续代码
            var task = LongRunningOperationAsync();
            Console.WriteLine("数据处理中");
            //在没有等待的情况下直接执行
            Console.WriteLine("数据处理结束");
        }

        /// <summary>
        /// 长时间等待
        /// </summary>
        /// <returns></returns>
        public static async Task LongRunningOperationAsync()
        {
            await Task.Delay(5000);
            // 模拟长时间操作
             Console.WriteLine("长时间操作完成");
        }


        /// <summary>
        /// 同步方法
        /// </summary>
        public static void SynchronousMethod()
        {
            Console.WriteLine("处理数据开始");
            // 模拟等待（2秒）
            Thread.Sleep(2000);
            Console.WriteLine("同步操作1 完成");
            // 再等待（2秒）
            Thread.Sleep(2000);
            Console.WriteLine("同步操作2 完成");
            Console.WriteLine("数据处理完成");
        }

        /// <summary>
        /// 异步方法
        /// </summary>
        /// <returns></returns>
        public static async Task AsynchronousMethod()
        {
            Console.WriteLine("处理数据开始");
            // 模拟等待（2秒）
            await Task.Delay(2000);
            Console.WriteLine("异步操作1 完成");
            // 再等待（2秒）
            await Task.Delay(2000);
            Console.WriteLine("异步操作2 完成");
            Console.WriteLine("数据处理完成");
        }

    }
}
