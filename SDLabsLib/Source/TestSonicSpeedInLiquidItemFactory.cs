using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SDLabsLib.Source
{
    public class TestSonicSpeedInLiquidItemFactory : ISonicSpeedInLiquidItemFactory
    {
        public IDataLoader SonicSpeedInLiquidListLoader()
        {
            IDataLoader dataProvider = new TestSonicSpeedInLiquidLoader(AppGlobalSettings.DataFileName);
            dataProvider.Execute();
            return dataProvider;
        }

        public void SonicSpeedInLiquidListSaver(List<SonicSpeedInLiquidActivity> items)
        {
            IDataSaver saveAction = new TestSonicSpeedInLiquidSaver(AppGlobalSettings.DataFileName);
            saveAction.Source = items;
            saveAction.Execute();
        }
    }
}
