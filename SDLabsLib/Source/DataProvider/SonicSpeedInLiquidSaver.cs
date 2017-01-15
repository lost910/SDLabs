using SDLabsLib.Source.Entity;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;

namespace SDLabsLib.Source.DataProvider
{
    internal class SonicSpeedInLiquidSaver : IDataSaver
    {
        private List<SonicSpeedInLiquidEntity> _source;
        private string _saveFile;

        public SonicSpeedInLiquidSaver(string fileName)
        {
            this._saveFile = fileName;
        }

        public List<SonicSpeedInLiquidEntity> Source
        {
            set { _source = value; }
        }

        public void Execute()
        {
            if (!File.Exists(_saveFile))
                throw new FileNotFoundException();

            XDocument doc = new XDocument(new XElement("SonicSpeedInLiquidActivitys"));
            foreach (SonicSpeedInLiquidEntity item in _source)
            {
                doc.Root.Add(
                    new XElement("SonicSpeedInLiquidActivity", 
                                new XElement("Material", item.Material),
                                new XElement("Type", item.Type),
                                new XElement("Temperature", item.Temperature),
                                new XElement("Speed", item.Speed)
                    )
                );

            }
            doc.Save(_saveFile);
        }
    }
}
