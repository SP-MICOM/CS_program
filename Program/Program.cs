namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Frame frame = new Frame();
            Clock clock = new Clock();
            Switch @switch = new Switch();

            ISelectable[] selectable = new ISelectable[3];

            int count = 0;

            while (count < selectable.Length)
            {
                Console.Write("What : ");
                int select = int.Parse(Console.ReadLine());

                switch (select)
                {
                    case 0:
                        frame.Select();
                        count++;
                        break;

                    case 1:
                        clock.Select();
                        count++;
                    break;

                    case 2:
                        @switch.Select();
                        count++;
                        break;

                    default:
                        Console.WriteLine("wrong");
                        break;
                }

                Console.WriteLine();
            }
        }
    }

}

