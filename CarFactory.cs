using System.Security.Cryptography.X509Certificates;

namespace MethodFactory
{
    public static class CarFactory
    {
        public enum bugetType
        {
            cheap = 1,
            middle = 2,
            expensive =3
        }
        public static ICar CreateCar(int buget)
        {
            switch (buget)
            {
                case (int) bugetType.cheap:
                    return new Logan();
                case (int)bugetType.middle:
                    return new WW();
                case (int)bugetType.expensive:
                    return new BMW();
                default:
                    return null;
            }
        }
    }
}