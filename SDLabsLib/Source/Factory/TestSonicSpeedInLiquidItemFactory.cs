using SDLabsLib.Source.Entity;
using SDLabsLib.Source.Common;
using SDLabsLib.Source.DataProvider;
using System.Collections.Generic;

namespace SDLabsLib.Source.Factory
{
    internal class TestSonicSpeedInLiquidItemFactory : ISonicSpeedInLiquidItemFactory
    {
        public IDataLoader SonicSpeedInLiquidListLoader()
        {
            IDataLoader dataProvider = new TestSonicSpeedInLiquidLoader(AppGlobalSettings.DataFileName);
            dataProvider.Execute();
            return dataProvider;
        }

        public void SonicSpeedInLiquidListSaver(List<SonicSpeedInLiquidEntity> items)
        {
            IDataSaver saveAction = new TestSonicSpeedInLiquidSaver(AppGlobalSettings.DataFileName);
            saveAction.Source = items;
            saveAction.Execute();
        }
    }
}
