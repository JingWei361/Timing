using System;
namespace Maze
{
    class CountdownTimer
    {
        static void Main(string[] args)
        {
            // 設定固定倒數秒數
            int seconds = 60; 

            for (int i = seconds; i > 0; i--)
            {
                // 清除上一輪輸出
                Console.Clear();
                // 顯示剩餘時間
                Console.WriteLine($"倒數：{i} 秒");
                // 暫停 1 秒
                Thread.Sleep(1000);
            }

            // 清除畫面
            Console.Clear();
            Console.WriteLine("時間到！");
            // 播放嗶聲（Beep）：頻率 1550Hz，持續 2500 毫秒
            Console.Beep(1550, 2500); 

            // 等待使用者關閉程式
            Console.ReadKey();

        }
    }
}
