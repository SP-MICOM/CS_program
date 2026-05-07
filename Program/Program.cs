using System.Collections;
using System.Security.AccessControl;
using System.Xml.Linq;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 의존 역전 원칙
            // 추상화는 세부 사항에 의존해서는 안되며, 세부 사항이
            // 추상화에 의존할 수 있도록 설계해야 하는 원칙입니다.

            Character character = new Character();

            Weapon knife = new Knife();
            Weapon grenade = new Grenade();

            character.Acquire(knife);
            character.Acquire(grenade);




            #endregion
        }
    }

}

