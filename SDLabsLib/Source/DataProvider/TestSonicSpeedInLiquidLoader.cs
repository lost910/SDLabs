using SDLabsLib.Source.Entity;
using System;
using System.Collections.Generic;

namespace SDLabsLib.Source.DataProvider
{
    internal class TestSonicSpeedInLiquidLoader : IDataLoader
    {
        private readonly string _dataFileName = String.Empty;
        private List<SonicSpeedInLiquidEntity> _sonicSpeedInLiquidList;

        public List<SonicSpeedInLiquidEntity> SonicSpeedInLiquidList
        {
            get { return _sonicSpeedInLiquidList; }
        }

        public TestSonicSpeedInLiquidLoader()
        {
            _sonicSpeedInLiquidList = new List<SonicSpeedInLiquidEntity>();
        }

        public TestSonicSpeedInLiquidLoader(string cap)
        {
            _sonicSpeedInLiquidList = new List<SonicSpeedInLiquidEntity>();
        }

        public void Execute()
        {
            {
                SonicSpeedInLiquidEntity ssla = new SonicSpeedInLiquidEntity()
                {
                    Material = "Анилин",
                    Type = "Чистое вещество",
                    Temperature = 20,
                    Speed = 1656
                };
                _sonicSpeedInLiquidList.Add(ssla);
            }
            {
                SonicSpeedInLiquidEntity ssla = new SonicSpeedInLiquidEntity()
                {
                    Material = "Ртуть",
                    Type = "Чистое вещество",
                    Temperature = 20,
                    Speed = 1451
                };
                _sonicSpeedInLiquidList.Add(ssla);
            }
            {
                SonicSpeedInLiquidEntity ssla = new SonicSpeedInLiquidEntity()
                {
                    Material = "Кедровое",
                    Type = "Масло",
                    Temperature = 29,
                    Speed = 1406
                };
                _sonicSpeedInLiquidList.Add(ssla);
            }
        }
    }
}
