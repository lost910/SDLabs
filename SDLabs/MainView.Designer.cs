namespace SDLabsMain
{
    partial class MainView
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.mMItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mMItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mMItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mMItemMaterials = new System.Windows.Forms.ToolStripMenuItem();
            this.mMItemOpenMaterial = new System.Windows.Forms.ToolStripMenuItem();
            this.mMItemAddMaterial = new System.Windows.Forms.ToolStripMenuItem();
            this.Status = new System.Windows.Forms.StatusStrip();
            this.SSLActivityView = new System.Windows.Forms.DataGridView();
            this.mMItemSaveAll = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SSLActivityView)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mMItemFile,
            this.mMItemMaterials});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(661, 24);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "MenuControl";
            // 
            // mMItemFile
            // 
            this.mMItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mMItemOpen,
            this.mMItemSaveAll,
            this.mMItemExit});
            this.mMItemFile.Name = "mMItemFile";
            this.mMItemFile.Size = new System.Drawing.Size(48, 20);
            this.mMItemFile.Text = "Файл";
            // 
            // mMItemOpen
            // 
            this.mMItemOpen.Name = "mMItemOpen";
            this.mMItemOpen.Size = new System.Drawing.Size(152, 22);
            this.mMItemOpen.Text = "Открыть";
            this.mMItemOpen.Click += new System.EventHandler(this.mMItemOpen_Click);
            // 
            // mMItemExit
            // 
            this.mMItemExit.Name = "mMItemExit";
            this.mMItemExit.Size = new System.Drawing.Size(152, 22);
            this.mMItemExit.Text = "Выход";
            this.mMItemExit.Click += new System.EventHandler(this.mMItemExit_Click);
            // 
            // mMItemMaterials
            // 
            this.mMItemMaterials.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mMItemOpenMaterial,
            this.mMItemAddMaterial});
            this.mMItemMaterials.Name = "mMItemMaterials";
            this.mMItemMaterials.Size = new System.Drawing.Size(72, 20);
            this.mMItemMaterials.Text = "Вещества";
            // 
            // mMItemOpenMaterial
            // 
            this.mMItemOpenMaterial.Name = "mMItemOpenMaterial";
            this.mMItemOpenMaterial.Size = new System.Drawing.Size(220, 22);
            this.mMItemOpenMaterial.Text = "Открыть данные вещества";
            this.mMItemOpenMaterial.Click += new System.EventHandler(this.mMItemOpenMaterial_Click);
            // 
            // mMItemAddMaterial
            // 
            this.mMItemAddMaterial.Name = "mMItemAddMaterial";
            this.mMItemAddMaterial.Size = new System.Drawing.Size(220, 22);
            this.mMItemAddMaterial.Text = "Добавить вещество";
            this.mMItemAddMaterial.Click += new System.EventHandler(this.mMItemAddMaterial_Click);
            // 
            // Status
            // 
            this.Status.Location = new System.Drawing.Point(0, 351);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(661, 22);
            this.Status.TabIndex = 1;
            this.Status.Text = "statusStrip1";
            // 
            // SSLActivityView
            // 
            this.SSLActivityView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SSLActivityView.Location = new System.Drawing.Point(12, 27);
            this.SSLActivityView.Name = "SSLActivityView";
            this.SSLActivityView.Size = new System.Drawing.Size(637, 321);
            this.SSLActivityView.TabIndex = 2;
            // 
            // mMItemSaveAll
            // 
            this.mMItemSaveAll.Name = "mMItemSaveAll";
            this.mMItemSaveAll.Size = new System.Drawing.Size(152, 22);
            this.mMItemSaveAll.Text = "Сохранить";
            this.mMItemSaveAll.Click += new System.EventHandler(this.mMItemSaveAll_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 373);
            this.Controls.Add(this.SSLActivityView);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MainView";
            this.Text = "SD:4281";
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SSLActivityView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem mMItemFile;
        private System.Windows.Forms.ToolStripMenuItem mMItemOpen;
        private System.Windows.Forms.ToolStripMenuItem mMItemExit;
        private System.Windows.Forms.StatusStrip Status;
        private System.Windows.Forms.DataGridView SSLActivityView;
        private System.Windows.Forms.ToolStripMenuItem mMItemMaterials;
        private System.Windows.Forms.ToolStripMenuItem mMItemOpenMaterial;
        private System.Windows.Forms.ToolStripMenuItem mMItemAddMaterial;
        private System.Windows.Forms.ToolStripMenuItem mMItemSaveAll;
    }
}

