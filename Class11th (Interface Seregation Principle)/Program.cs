using System.Collections;
using System.Security.AccessControl;
using System.Xml.Linq;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 인터페이스 분리 원칙
            // 하나의 큰 인터페이스를 여러 개의 작은 인터페이스로 나누어서, 각 클래스가
            // 자신에게 필요한 기능만 의존하도록 설계해야 하는 원칙입니다.

            Seller seller = new Seller();
            Guide guide = new Guide();
            Sentinel sentinel = new Sentinel();

            sentinel.Damage(20);
            sentinel.Talk();

            guide.Talk();

            seller.Talk();
            seller.Sell();

            #endregion
        }
    }

}

