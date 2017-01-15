using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Linq;
using SDLabsLib.Source.Entity;

namespace SDLabsLib.Source.DataProvider
{
    public enum LoadStatus
    {
        None = 0,
        Success = 1,
        FileNameIsEmpty = -1,
        FileNotExists = -2,
        GeneralError = -100
    }

    internal class SonicSpeedInLiquidLoader : IDataLoader
    {
        private string _dataFileName = String.Empty;
        private List<SonicSpeedInLiquidEntity> _sonicSpeedInLiquidList;
        private LoadStatus _status = LoadStatus.None;

        public List<SonicSpeedInLiquidEntity> SonicSpeedInLiquidList
        {
            get { return _sonicSpeedInLiquidList; }
        }

        public LoadStatus Status
        {
            get { return _status; }
        }

        public SonicSpeedInLiquidLoader(string fileName)
        {
            _sonicSpeedInLiquidList = new List<SonicSpeedInLiquidEntity>();
            _dataFileName = fileName;
        }

        public void Execute()
        {
            if(_dataFileName == String.Empty)
                _status = LoadStatus.FileNameIsEmpty;

            if (!File.Exists(_dataFileName))
            {
                _status = LoadStatus.FileNotExists;
                throw new FileNotFoundException();
            }

            XDocument doc = XDocument.Load(_dataFileName);
            foreach(XElement item in doc.Root.Elements())
            {
                SonicSpeedInLiquidEntity ssla = new SonicSpeedInLiquidEntity()
                {
                    Material = item.Element("Material").Value,
                    Type = item.Element("Type").Value,
                    Temperature = Int32.Parse(item.Element("Temperature").Value),
                    Speed = Int32.Parse(item.Element("Speed").Value)
                };
                _sonicSpeedInLiquidList.Add(ssla);
            }

            _status = LoadStatus.Success;

        }
    }
}
