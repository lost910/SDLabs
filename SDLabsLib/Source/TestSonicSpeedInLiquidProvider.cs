using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SDLabsLib
{
    public class TestSonicSpeedInLiquidProvider : IDataProvider
    {
        private readonly string _dataFileName = String.Empty;
        private List<SonicSpeedInLiquidActivity> _sonicSpeedInLiquidList;

        public List<SonicSpeedInLiquidActivity> SonicSpeedInLiquidList
        {
            get { return _sonicSpeedInLiquidList; }
        }

        public TestSonicSpeedInLiquidProvider()
        {
            _sonicSpeedInLiquidList = new List<SonicSpeedInLiquidActivity>();
        }

        public TestSonicSpeedInLiquidProvider(string cap)
        {
            _sonicSpeedInLiquidList = new List<SonicSpeedInLiquidActivity>();
        }

        public void Execute()
        {
            {
                SonicSpeedInLiquidActivity ssla = new SonicSpeedInLiquidActivity()
                {
                    Material = "Анилин",
                    Type = "Чистое вещество",
                    Temperature = 20,
                    Speed = 1656
                };
                _sonicSpeedInLiquidList.Add(ssla);
            }
            {
                SonicSpeedInLiquidActivity ssla = new SonicSpeedInLiquidActivity()
                {
                    Material = "Ртуть",
                    Type = "Чистое вещество",
                    Temperature = 20,
                    Speed = 1451
                };
                _sonicSpeedInLiquidList.Add(ssla);
            }
            {
                SonicSpeedInLiquidActivity ssla = new SonicSpeedInLiquidActivity()
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
