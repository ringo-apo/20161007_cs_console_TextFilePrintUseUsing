using System;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            string a;
            Console.WriteLine("文字を入力してください。");
            a = Console.ReadLine();
            
            // ファイルにテキストを書き出し。
            using (StreamWriter w = new StreamWriter(@"D:\test.txt"))
            {
                w.WriteLine(a);
            }

            Console.WriteLine(@"D:\test.txtに保存しました。");
            Console.WriteLine("");
            Console.WriteLine("保存した内容を表示します。");


            // ファイルからテキストを読み出し。
            using (StreamReader r = new StreamReader(@"D:\test.txt"))
            {
                string line;
                while ((line = r.ReadLine()) != null) // 1行ずつ読み出し。
                {
                    Console.WriteLine(line);
                }
            }

            Console.WriteLine("何か文字を入力すると終了します。");
            Console.ReadKey();
        }
    }
}
