using SDLabsLib.Source.Entity;
using SDLabsLib.Source.Common;
using SDLabsLib.Source.DataProvider;
using System.Collections.Generic;

namespace SDLabsLib.Source.Factory
{
    internal class SonicSpeedInLiquidItemFactory : ISonicSpeedInLiquidItemFactory
    {
        public IDataLoader SonicSpeedInLiquidListLoader()
        {
            IDataLoader dataProvider = new SonicSpeedInLiquidLoader(AppGlobalSettings.DataFileName);
            dataProvider.Execute();
            return dataProvider;
        }

        public void SonicSpeedInLiquidListSaver(List<SonicSpeedInLiquidEntity> items)
        {
            IDataSaver saveAction = new SonicSpeedInLiquidSaver(AppGlobalSettings.DataFileName);
            saveAction.Source = items;
            saveAction.Execute();
        }
    }
}
