using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SDLabsLib.Source
{
    internal class TestSonicSpeedInLiquidSaver : IDataSaver
    {

        public TestSonicSpeedInLiquidSaver(string fileName)
        {

        }

        public List<SonicSpeedInLiquidActivity> Source
        {
            set
            {
                throw new NotImplementedException();
            }
        }

        public void Execute()
        {

        }
    }
}
