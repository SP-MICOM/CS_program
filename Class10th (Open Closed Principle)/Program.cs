using System.Collections;
using System.Security.AccessControl;
using System.Xml.Linq;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 개방 폐쇄 원칙
            // 소프트웨어 개체에서는 확장에 대해 열려 있어야 하며,
            // 수정에 대해서는 닫혀 있도록 설계되어야 하는 원칙입니다.

            Sensor sensor = new Sensor();

            Product defective = new Defective();
            Product bread = new Bread();
            Product sealant = new Sealant();

            sensor.Detect(defective);
            sensor.Detect(bread);
            sensor.Detect(sealant);

            #endregion
        }
    }

}


