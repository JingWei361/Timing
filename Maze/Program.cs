using System;
namespace Maze
{
    class CountdownTimer
    {
        static void Main(string[] args)
        {
            // 設定固定倒數秒數
            int seconds = 60;
            int keyPressCount = 0;
            DateTime endTime = DateTime.Now.AddSeconds(seconds);
            // 設定 Console，不顯示按鍵輸入
            Console.CursorVisible = false;
            Console.TreatControlCAsInput = true;
            // 初始化畫面（只清一次）
            Console.Clear();
            Console.WriteLine("倒數：");
            Console.WriteLine("總共走了：");

            while (DateTime.Now < endTime)
            {
                TimeSpan remaining = endTime - DateTime.Now;

                // 更新時間與計數顯示（覆蓋同一行）
                Console.SetCursorPosition(4, 0);
                Console.Write($"{(int)remaining.TotalSeconds} 秒    "); // 加空白消除殘影

                Console.SetCursorPosition(13, 1);
                Console.Write($"{keyPressCount} 步   ");

                // 檢查是否有按鍵
                while (Console.KeyAvailable)
                {
                    ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                    char key = char.ToUpper(keyInfo.KeyChar);
                    if (key == 'W' || key == 'A' || key == 'S' || key == 'D')
                    {
                        keyPressCount++;
                    }
                }

                Thread.Sleep(50); // 降低 CPU 使用率
            }


            // 顯示結束畫面
            Console.Clear();
            Console.CursorVisible = true;
            Console.WriteLine("時間到！");
            Console.WriteLine($"總共走了：{keyPressCount} 步");

            Console.ReadKey();

        }
    }
}
