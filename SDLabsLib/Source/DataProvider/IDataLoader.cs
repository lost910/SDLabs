using SDLabsLib.Source.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SDLabsLib.Source.DataProvider
{
    public interface IDataLoader
    {
        List<SonicSpeedInLiquidEntity> SonicSpeedInLiquidList { get; }

        void Execute();
    }
}
