using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ruleta
{
    public enum Farba
    {
        zelena,
        cervena,
        cierna,
    }
    public enum Lichost
    {
        ziadna,
        suda,
        licha,
    }
    public enum Rada
    {
        ziadna,
        prva, 
        druha,
        tretia,
    }
    public enum Rozsah // enum  nesmie byt cislo
    {
        ziadny,// nula vzdy nikam nepatri
        r1_12,
        r13_24,
        r25_36,
        r1_18,
        r19_36,

    }
}
