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
        private BindingSource source;
        private string _saveFile;

        public SonicSpeedInLiquidSaver(BindingSource source, string fileName)
        {
            this.source = source;
            this._saveFile = fileName;
        }

        public void Execute()
        {
            if (!File.Exists(_saveFile))
                throw new FileNotFoundException();

            XDocument doc = new XDocument(new XElement("SonicSpeedInLiquidActivitys"));
            foreach (SonicSpeedInLiquidActivity item in source)
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
