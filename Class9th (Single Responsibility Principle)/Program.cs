using System.Collections;
using System.Security.AccessControl;
using System.Xml.Linq;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 단일 책임 원칙
            // 클래스는 하나의 기능으로 수정될 수 있도록 설계해야 하는 원칙입니다.

            User user = new User("iheu@naver.com", "password123*");

            User user2 = new User("2iheu@naver.com", "2password123*");

            Persistence persistence = new Persistence();

            Authenticate authenticate = new Authenticate(persistence);

            persistence.Save(user);

            // 로그인 시도

            bool result = authenticate.Execute(user);

            // 로그인 성공

            if (result)
            {
                Console.WriteLine("Login Success");
            }
            else
            {
                Console.WriteLine("Login failure");
            }

            #endregion
        }
    }

}

