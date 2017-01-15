using SDLabsLib.Source.Entity;
using SDLabsLib.Source.Helper;
using System;
using System.Windows.Forms;

namespace SDLabsMain
{
    public partial class MaterialView : Form
    {
        private SonicSpeedInLiquidEntity _sonicSpeedInLiquidEntity;

        public delegate void SaveEventHandler(object e);
        public event SaveEventHandler Save;
        private bool _newItem;

        public SonicSpeedInLiquidEntity SonicSpeedInLiquidActivity
        {
            get { return _sonicSpeedInLiquidEntity; }
        }

        public MaterialView()
        {
            InitializeComponent();
            _sonicSpeedInLiquidEntity = null;
        }

        public void SetSonicSpeedInLiquidEntity(SonicSpeedInLiquidEntity ssla)
        {
            if (ssla != null)
            {
                this.txtMaterial.Text = ssla.Material;
                this.txtType.Text = ssla.Type;
                this.txtTemperature.Text = ssla.Temperature.ToString();
                this.txtSpeed.Text = ssla.Speed.ToString();
                this._sonicSpeedInLiquidEntity = ssla;
            }
            else
            {
                this._sonicSpeedInLiquidEntity = new SonicSpeedInLiquidEntity();
                _newItem = true;
            }
        }

        private void MaterialView_FormClosing(object sender, FormClosingEventArgs e)
        {
            _sonicSpeedInLiquidEntity.Material = this.txtMaterial.Text;
            _sonicSpeedInLiquidEntity.Type = this.txtType.Text;
            _sonicSpeedInLiquidEntity.Temperature = Int32.Parse(this.txtTemperature.Text);
            _sonicSpeedInLiquidEntity.Speed = Int32.Parse(this.txtSpeed.Text);

            if (EntityValidationHelper.Validate(_sonicSpeedInLiquidEntity))
            {
                if (_newItem)
                    Save(_sonicSpeedInLiquidEntity);
                else
                    Save(null);
            }
            else
            {
                e.Cancel = true;
                MessageBox.Show("Введены некорректные значения","Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        
    }
}
