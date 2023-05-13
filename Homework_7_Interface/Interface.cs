using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_7_Interface
{
    // Создайте интерфейс ICalc. В нём должно быть два метода:
    //■ int Less(int valueToCompare) — возвращает количество значений меньших, чем valueToCompare;
    //■ int Greater(int valueToCompare) — возвращает количество значений больших, чем valueToCompare.
    public interface ICalc
    {
        int Less(int valueToCompare);
        int Greater(int valueToCompare);
    }
    /* Создайте интерфейс IOutput2. В нём должно быть два метода:
     ■ void ShowEven() — отображает четные значения из контейнера с данными;
     ■ void ShowOdd() — отображает нечетные значения из контейнера с данными.*/
    internal interface IOutput2
    {
        void ShowEven();
        void ShowOdd();
    }
    /* Создайте интерфейс ICalc2. В нём должно быть два метода:
     ■ int CountDistinct() — возвращает количество уникальных значений в контейнере данных;
     ■ int EqualToValue(int valueToCompare) — возвращает количество значений равных valueToCompare.*/
    internal interface ICalc2
    {
        int CountDistinct();
        int EqualToValue(int valueToCompare);
    }

}
