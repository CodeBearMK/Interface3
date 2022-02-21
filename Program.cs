namespace Interface3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入學期成績：");
            int score = int.Parse(Console.ReadLine());
            CStudent student = new CStudent();
            Console.WriteLine("分數：{0}", student.Pass(score));
            Console.WriteLine("評語：{0}", student.Level(score));
            Console.Read();
        }
    }
}