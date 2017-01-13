using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Linq;

namespace SDLabsLib
{
    public enum LoadStatus
    {
        None = 0,
        Success = 1,
        FileNameIsEmpty = -1,
        FileNotExists = -2,
        GeneralError = -100
    }


    public class SonicSpeedInLiquidProvider : IDataProvider
    {
        private string _dataFileName = String.Empty;
        private List<SonicSpeedInLiquidActivity> _sonicSpeedInLiquidList;
        private LoadStatus _status = LoadStatus.None;

        public List<SonicSpeedInLiquidActivity> SonicSpeedInLiquidList
        {
            get { return _sonicSpeedInLiquidList; }
        }

        public LoadStatus Status
        {
            get { return _status; }
        }

        public SonicSpeedInLiquidProvider(string fileName)
        {
            _sonicSpeedInLiquidList = new List<SonicSpeedInLiquidActivity>();
            _dataFileName = fileName;
        }

        public void Execute()
        {
            if (!File.Exists(_dataFileName))
                throw new FileNotFoundException();

            XDocument doc = XDocument.Load(_dataFileName);
            foreach(XElement item in doc.Root.Elements())
            {
                SonicSpeedInLiquidActivity ssla = new SonicSpeedInLiquidActivity()
                {
                    Material = item.Element("Material").Value,
                    Type = item.Element("Type").Value,
                    Temperature = Int32.Parse(item.Element("Temperature").Value),
                    Speed = Int32.Parse(item.Element("Speed").Value)
                };
                _sonicSpeedInLiquidList.Add(ssla);
            }
                
        }
    }
}
