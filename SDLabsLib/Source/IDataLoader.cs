using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SDLabsLib
{
    public interface IDataLoader
    {
        List<SonicSpeedInLiquidActivity> SonicSpeedInLiquidList { get; }

        void Execute();
    }
}
