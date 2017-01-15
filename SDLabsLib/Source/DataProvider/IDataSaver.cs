using SDLabsLib.Source.Entity;
using System.Collections.Generic;

namespace SDLabsLib.Source.DataProvider
{
    public interface IDataSaver
    {
        List<SonicSpeedInLiquidEntity> Source { set; }

        void Execute();
    }
}
