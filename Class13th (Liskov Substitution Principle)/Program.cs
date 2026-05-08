using System.Collections;
using System.Security.AccessControl;
using System.Xml.Linq;

namespace Program
{
    internal class Program
    {
        static void FlyMove(IFlyable flyable)
        {
            flyable.Fly();
        }

        static void Main(string[] args)
        {
            #region 리스코프 치환 원칙
            // 하위 클래스는 항상 상위 클래스로 치환 가능해야 하며, 그로 인해
            // 프로그램의 동작이 변경되지 않도록 설계 해야 하는 원칙입니다.

            Slime slime = new Slime();
            Dragon dragon = new Dragon();

            FlyMove(dragon);

            #endregion
        }
    }

}

