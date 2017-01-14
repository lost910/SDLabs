using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SDLabsLib.Source
{
    public class SonicSpeedInLiquidItemFactory : ISonicSpeedInLiquidItemFactory
    {
        public IDataLoader SonicSpeedInLiquidListLoader()
        {
            IDataLoader dataProvider = new SonicSpeedInLiquidLoader(AppGlobalSettings.DataFileName);
            dataProvider.Execute();
            return dataProvider;
        }

        public void SonicSpeedInLiquidListSaver(List<SonicSpeedInLiquidActivity> items)
        {
            IDataSaver saveAction = new SonicSpeedInLiquidSaver(AppGlobalSettings.DataFileName);
            saveAction.Source = items;
            saveAction.Execute();
        }
    }
}
