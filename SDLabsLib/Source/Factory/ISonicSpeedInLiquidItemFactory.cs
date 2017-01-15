using SDLabsLib.Source.Entity;
using SDLabsLib.Source.DataProvider;
using System.Collections.Generic;

namespace SDLabsLib.Source.Factory
{
    public interface ISonicSpeedInLiquidItemFactory
    {
        void SonicSpeedInLiquidListSaver(List<SonicSpeedInLiquidEntity> items);
        IDataLoader SonicSpeedInLiquidListLoader();
    }
}
