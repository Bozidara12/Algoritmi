namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ukazatelTel=new Dictionary<string, string>();

            ukazatelTel.Add("Ivan Ivanov", "08890790898");
            ukazatelTel.Add("Angel Stoqnov", "099089765332");
            ukazatelTel.Add("Miro Asenov", "08876253425");
            foreach (var d in ukazatelTel)
            {
                Console.WriteLine($"{d.Key} {d.Value}");
            }
        }
    }
}
