using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SDLabsLib.Source
{
    public interface ISonicSpeedInLiquidItemFactory
    {
        void SonicSpeedInLiquidListSaver(List<SonicSpeedInLiquidActivity> items);
        IDataLoader SonicSpeedInLiquidListLoader();
    }
}
