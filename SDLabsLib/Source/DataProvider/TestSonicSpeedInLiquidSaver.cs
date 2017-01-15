using SDLabsLib.Source.Entity;
using System;
using System.Collections.Generic;

namespace SDLabsLib.Source.DataProvider
{
    internal class TestSonicSpeedInLiquidSaver : IDataSaver
    {
        public TestSonicSpeedInLiquidSaver(string fileName){}

        public List<SonicSpeedInLiquidEntity> Source
        {
            set { throw new NotImplementedException(); }
        }

        public void Execute(){}
    }
}
