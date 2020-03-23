using System;
using System.Collections.Generic;
using System.Text;

namespace Browse_History___Iterator_Pattern
{
    public interface Iterator <T>
    {
        Boolean HasNext();
        T Current();
        void Next();

    }
}
