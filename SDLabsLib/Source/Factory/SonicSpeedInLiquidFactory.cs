using SDLabsLib.Source.Entity;
using System.Collections.Generic;

namespace SDLabsLib.Source.Factory
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

        public List<SonicSpeedInLiquidEntity> Create()
        {
            return Factory.SonicSpeedInLiquidListLoader().SonicSpeedInLiquidList;
        }

        public void Save(List<SonicSpeedInLiquidEntity> items)
        {
            Factory.SonicSpeedInLiquidListSaver(items);
        }
    }
}
