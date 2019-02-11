using System;
using System.Dynamic;
using System.Runtime.CompilerServices;

namespace MethodFactory
{
    public interface ICar
    {
        void SetSpeed();
        DateTime GetManufactureDate();
        string GetModel();
        string GetConsumption();

    }
}