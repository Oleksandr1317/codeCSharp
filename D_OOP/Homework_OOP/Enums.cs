using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_OOP
{
    public enum TrafficLight // enum - ключевое слово перечисления
    {
        Red,
        Yellow,
        Green
    }
    public enum Race : int // любое enum - наследуется от инта
    {
        Elf = 30,
        Ork = 40,
        Terrain = 20 // это мы явно поставили инты которые стоят по умолчанию,но мы можем ставить вообще любые инты
    }
}
