using SDLabsLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SDLabsMain
{
    public partial class MaterialView : Form
    {
        private SonicSpeedInLiquidActivity _sonicSpeedInLiquidActivity = null;

        public SonicSpeedInLiquidActivity SonicSpeedInLiquidActivity
        {
            get { return _sonicSpeedInLiquidActivity; }
        }

        public MaterialView()
        {
            InitializeComponent();
            _sonicSpeedInLiquidActivity = null;
        }

        public void SetSonicSpeedInLiquidActivity(SonicSpeedInLiquidActivity ssla)
        {
            this._sonicSpeedInLiquidActivity = ssla;
            this.txtMaterial.Text = ssla.Material;
            this.txtType.Text = ssla.Type;
            this.txtTemperature.Text = ssla.Temperature.ToString();
            this.txtSpeed.Text = ssla.Speed.ToString();
        }
    }
}
