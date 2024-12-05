namespace SynchronousAndAsynchronousMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //同步方法
            SynchronousMethod();

            //异步方法
            AsynchronousMethod().Wait();
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
