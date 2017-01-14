using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SDLabsLib.Source
{
    public class SonicSpeedInLiquidFactory
    {
        private bool _testMode;
        private ISonicSpeedInLiquidItemFactory Factory;

        public SonicSpeedInLiquidFactory(bool testmode)
        {
            _testMode = testmode;
            if (_testMode)
                Factory = new TestSonicSpeedInLiquidItemFactory();
            else
                Factory = new SonicSpeedInLiquidItemFactory();
        }

        public List<SonicSpeedInLiquidActivity> Create()
        {
            return Factory.SonicSpeedInLiquidListLoader().SonicSpeedInLiquidList;
        }

        public void Save(List<SonicSpeedInLiquidActivity> items)
        {
            Factory.SonicSpeedInLiquidListSaver(items);
        }
    }
}
