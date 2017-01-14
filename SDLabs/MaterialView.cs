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

        public delegate void SaveEventHandler();
        public event SaveEventHandler Save;

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

        private void MaterialView_FormClosing(object sender, FormClosingEventArgs e)
        {
            _sonicSpeedInLiquidActivity.Material = this.txtMaterial.Text;
            _sonicSpeedInLiquidActivity.Type = this.txtType.Text;
            _sonicSpeedInLiquidActivity.Temperature = Int32.Parse(this.txtTemperature.Text);
            _sonicSpeedInLiquidActivity.Speed = Int32.Parse(this.txtSpeed.Text);
            Save();
        }

        
    }
}
