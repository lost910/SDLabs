using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SDLabsLib.Source
{
    public class SonicSpeedInLiquidSaver : IDataSaver
    {
        private List<SonicSpeedInLiquidActivity> _source;
        private string _saveFile;

        public SonicSpeedInLiquidSaver(string fileName)
        {
            this._saveFile = fileName;
        }

        public List<SonicSpeedInLiquidActivity> Source
        {
            set { _source = value; }
        }

        public void Execute()
        {
            if (!File.Exists(_saveFile))
                throw new FileNotFoundException();

            XDocument doc = new XDocument(new XElement("SonicSpeedInLiquidActivitys"));
            foreach (SonicSpeedInLiquidActivity item in _source)
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
