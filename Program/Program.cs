namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 추상 클래스
            // 공통적인 기능을 제공하며, 구체적인 동작은 하위 클래스에서
            // 정의할 수 있도록 만들어 놓은 클래스입니다.

            Barracks barracks = new Barracks();

            int creatcount = 0;

            int select = 0;

            while (creatcount < 5)
            {
                Console.WriteLine(" ");

                select = int.Parse(Console.ReadLine());

                barracks.Create(select);

                creatcount++;
            }

            #endregion
        }
    }

}

