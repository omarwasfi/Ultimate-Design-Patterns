using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor_Pattern
{
    public interface Operation
    {
        public void Apply(HeadingNode heading);
        public void Apply(AnchorNode anchor);

    }
}
