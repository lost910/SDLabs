using System;
using System.Windows.Forms;
using SDLabsLib.Source.Log;
using System.Collections.Generic;
using SDLabsLib;

namespace SDLabsMain
{
    public partial class MainView : Form
    {
        private List<SonicSpeedInLiquidActivity> sslaList;
        private BindingSource sslaBS = new BindingSource();

        public MainView()
        {
            InitializeComponent();
        }

        private void mMItemExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mMItemOpen_Click(object sender, EventArgs e)
        {
            try
            {
                // throw new NotImplementedException("Invalid parameters");
                //throw new Exception("Invalid parameters");
                MockSonicSpeedInLiquidProvider dataProvider = new MockSonicSpeedInLiquidProvider();
                dataProvider.Execute();
                sslaBS.DataSource = dataProvider.SonicSpeedInLiquidList;
                SSLActivityView.DataSource = sslaBS;
            }
            catch (NotImplementedException ex)
            {
                //MessageBox.Show("NotImplementedException: " + ex.Message);
                LogHelper.ErrorLog("NotImplementedException: " + ex.Message);
            }
            catch(Exception ex)
            {
                //MessageBox.Show("Exception: " + ex.Message);
                LogHelper.ErrorLog("Exception: " + ex.Message);
            }
        }

        private void mMItemOpenMaterial_Click(object sender, EventArgs e)
        {
            MaterialView materialView = new MaterialView();
            SonicSpeedInLiquidActivity ssla = (sslaBS.Current as SonicSpeedInLiquidActivity);
            materialView.SetSonicSpeedInLiquidActivity(ssla);
            materialView.ShowDialog();
        }
    }
}
