using System;
using System.Windows.Forms;
using SDLabsLib.Source.Log;
using System.Collections.Generic;
using SDLabsLib;
using System.Data;
using SDLabsLib.Source;

namespace SDLabsMain
{
    public partial class MainView : Form
    {
        private BindingSource sslaBS = new BindingSource();

        public MainView()
        {
            InitializeComponent();
            SSLActivityView.AllowUserToAddRows = false;
        }

        private void mMItemExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mMItemOpen_Click(object sender, EventArgs e)
        {
            try
            {
                IDataLoader dataProvider = new SonicSpeedInLiquidLoader(AppGlobalSettings.DataFileName);
                dataProvider.Execute();
                sslaBS.DataSource = dataProvider.SonicSpeedInLiquidList;
                SSLActivityView.DataSource = sslaBS;
            }
            catch (NotImplementedException ex)
            {
                MessageBox.Show("NotImplementedException: " + ex.Message);
                LogHelper.ErrorLog("NotImplementedException: " + ex.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
                LogHelper.ErrorLog("Exception: " + ex.Message);
            }
        }

        private void mMItemOpenMaterial_Click(object sender, EventArgs e)
        {
            try
            {
                MaterialView materialView = new MaterialView();
                SonicSpeedInLiquidActivity ssla = (sslaBS.Current as SonicSpeedInLiquidActivity);
                materialView.SetSonicSpeedInLiquidActivity(ssla);
                materialView.Save += MaterialView_Save;
                materialView.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
                LogHelper.ErrorLog("Exception: " + ex.Message);
            }
        }

        private void MaterialView_Save()
        {
            SSLActivityView.Invalidate();
        }

        private void mMItemAddMaterial_Click(object sender, EventArgs e)
        {
            try
            {
                sslaBS.Add(new SonicSpeedInLiquidActivity());
                sslaBS.MoveLast();
                mMItemOpenMaterial_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
                LogHelper.ErrorLog("Exception: " + ex.Message);
            }
        }

        private void mMItemSaveAll_Click(object sender, EventArgs e)
        {
            IDataSaver saveAction = new SonicSpeedInLiquidSaver(sslaBS, AppGlobalSettings.DataFileName);
            saveAction.Execute();
        }
    }
}
