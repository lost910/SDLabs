using System;
using System.Windows.Forms;
using SDLabsLib.Source.Helper;
using System.Collections.Generic;
using SDLabsLib.Source.Factory;
using SDLabsLib.Source.Entity;
using SDLabsLib.Source.Common;

namespace SDLabsMain
{
    public partial class MainView : Form
    {
        private BindingSource _dataBindProvider;
        private SonicSpeedInLiquidFactory _factory;

        public MainView()
        {
            InitializeComponent();
            EntityViewer.AllowUserToAddRows = false;
            _dataBindProvider = new BindingSource();
            _factory = new SonicSpeedInLiquidFactory(AppGlobalSettings.TestMode);
        }

        private void mMItemExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mMItemOpen_Click(object sender, EventArgs e)
        {
            try
            {
                _dataBindProvider.DataSource = _factory.Create();
                EntityViewer.DataSource = _dataBindProvider;
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
                SonicSpeedInLiquidEntity ssla = (_dataBindProvider.Current as SonicSpeedInLiquidEntity);
                materialView.SetSonicSpeedInLiquidEntity(ssla);
                materialView.Save += MaterialView_Save;
                materialView.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
                LogHelper.ErrorLog("Exception: " + ex.Message);
            }
        }

        private void MaterialView_Save(object e)
        {
            if (e != null)
                _dataBindProvider.Add(e as SonicSpeedInLiquidEntity);

            EntityViewer.Invalidate();
        }

        private void mMItemAddMaterial_Click(object sender, EventArgs e)
        {
            try
            {
                MaterialView materialView = new MaterialView();
                materialView.SetSonicSpeedInLiquidEntity(null);
                materialView.Save += MaterialView_Save;
                materialView.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
                LogHelper.ErrorLog("Exception: " + ex.Message);
            }
        }

        private void mMItemSaveAll_Click(object sender, EventArgs e)
        {
            try
            {
                _factory.Save((List<SonicSpeedInLiquidEntity>)_dataBindProvider.DataSource);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
                LogHelper.ErrorLog("Exception: " + ex.Message);
            }
        }

        private void MItemRemoveEntity_Click(object sender, EventArgs e)
        {
            try
            {
                _dataBindProvider.Remove(_dataBindProvider.Current as SonicSpeedInLiquidEntity);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
                LogHelper.ErrorLog("Exception: " + ex.Message);
            }
        }
    }
}
