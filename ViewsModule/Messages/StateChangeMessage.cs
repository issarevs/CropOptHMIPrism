using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewsModule.Messages
{
    public enum SystemState { NoBar, HeadDet, TailDet, HeadCutDet, TailCutDet, HeadDetTransit, HeadDetTailCut, TransitTailCut };
    public class StateChangeMessage
    {
    }
}
