using System.Collections;
using System.Security.AccessControl;
using System.Xml.Linq;

namespace Program
{
    internal class Program
    {
        delegate float Opertation(float x, float y);

        static float Add(float x, float y)
        {
            return (x + y);
        }

        static float Substract(float x, float y)
        {
            return x - y;
        }

        static float Multiply(float x, float y)
        {
            return x * y;
        }

        static float Divide(float x, float y)
        {
            return x / y;
        }

        static void Main(string[] args)
        {
            #region 대리자
            // 특정한 함수를 가진 함수를 참조할 수 있는 참조 타입입니다.

            Opertation opertation;

            opertation = Add;

            Console.WriteLine(opertation(5, 5));

            opertation = Substract;

            Console.WriteLine(opertation(5, 5));

            opertation = Multiply;

            Console.WriteLine(opertation(5, 5));

            opertation = Divide;

            Console.WriteLine(opertation(5, 5));
            
            #endregion
        }
    }

}

