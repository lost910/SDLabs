using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SDLabsLib
{
    public interface IDataProvider
    {
        List<SonicSpeedInLiquidActivity> SonicSpeedInLiquidList { get; }

        void Execute();
    }
}
