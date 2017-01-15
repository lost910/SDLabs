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
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.mMItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.MItemSaveAll = new System.Windows.Forms.ToolStripMenuItem();
            this.MItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mMItemMaterials = new System.Windows.Forms.ToolStripMenuItem();
            this.MItemOpenMaterial = new System.Windows.Forms.ToolStripMenuItem();
            this.MItemAddMaterial = new System.Windows.Forms.ToolStripMenuItem();
            this.Status = new System.Windows.Forms.StatusStrip();
            this.EntityViewer = new System.Windows.Forms.DataGridView();
            this.MItemRemoveEntity = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EntityViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mMItemFile,
            this.mMItemMaterials});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(661, 24);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "MenuControl";
            // 
            // mMItemFile
            // 
            this.mMItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MItemOpen,
            this.MItemSaveAll,
            this.MItemExit});
            this.mMItemFile.Name = "mMItemFile";
            this.mMItemFile.Size = new System.Drawing.Size(48, 20);
            this.mMItemFile.Text = "Файл";
            // 
            // MItemOpen
            // 
            this.MItemOpen.Name = "MItemOpen";
            this.MItemOpen.Size = new System.Drawing.Size(152, 22);
            this.MItemOpen.Text = "Открыть";
            this.MItemOpen.Click += new System.EventHandler(this.mMItemOpen_Click);
            // 
            // MItemSaveAll
            // 
            this.MItemSaveAll.Name = "MItemSaveAll";
            this.MItemSaveAll.Size = new System.Drawing.Size(152, 22);
            this.MItemSaveAll.Text = "Сохранить";
            this.MItemSaveAll.Click += new System.EventHandler(this.mMItemSaveAll_Click);
            // 
            // MItemExit
            // 
            this.MItemExit.Name = "MItemExit";
            this.MItemExit.Size = new System.Drawing.Size(152, 22);
            this.MItemExit.Text = "Выход";
            this.MItemExit.Click += new System.EventHandler(this.mMItemExit_Click);
            // 
            // mMItemMaterials
            // 
            this.mMItemMaterials.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MItemOpenMaterial,
            this.MItemAddMaterial,
            this.MItemRemoveEntity});
            this.mMItemMaterials.Name = "mMItemMaterials";
            this.mMItemMaterials.Size = new System.Drawing.Size(72, 20);
            this.mMItemMaterials.Text = "Вещества";
            // 
            // MItemOpenMaterial
            // 
            this.MItemOpenMaterial.Name = "MItemOpenMaterial";
            this.MItemOpenMaterial.Size = new System.Drawing.Size(220, 22);
            this.MItemOpenMaterial.Text = "Открыть данные вещества";
            this.MItemOpenMaterial.Click += new System.EventHandler(this.mMItemOpenMaterial_Click);
            // 
            // MItemAddMaterial
            // 
            this.MItemAddMaterial.Name = "MItemAddMaterial";
            this.MItemAddMaterial.Size = new System.Drawing.Size(220, 22);
            this.MItemAddMaterial.Text = "Добавить вещество";
            this.MItemAddMaterial.Click += new System.EventHandler(this.mMItemAddMaterial_Click);
            // 
            // Status
            // 
            this.Status.Location = new System.Drawing.Point(0, 351);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(661, 22);
            this.Status.TabIndex = 1;
            this.Status.Text = "statusStrip1";
            // 
            // EntityViewer
            // 
            this.EntityViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EntityViewer.Location = new System.Drawing.Point(12, 27);
            this.EntityViewer.Name = "EntityViewer";
            this.EntityViewer.Size = new System.Drawing.Size(637, 321);
            this.EntityViewer.TabIndex = 2;
            // 
            // MItemRemoveEntity
            // 
            this.MItemRemoveEntity.Name = "MItemRemoveEntity";
            this.MItemRemoveEntity.Size = new System.Drawing.Size(220, 22);
            this.MItemRemoveEntity.Text = "Удалить вещество";
            this.MItemRemoveEntity.Click += new System.EventHandler(this.MItemRemoveEntity_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 373);
            this.Controls.Add(this.EntityViewer);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.MainMenu);
            this.MainMenuStrip = this.MainMenu;
            this.Name = "MainView";
            this.Text = "SD:4281";
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EntityViewer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem mMItemFile;
        private System.Windows.Forms.ToolStripMenuItem MItemOpen;
        private System.Windows.Forms.ToolStripMenuItem MItemExit;
        private System.Windows.Forms.StatusStrip Status;
        private System.Windows.Forms.DataGridView EntityViewer;
        private System.Windows.Forms.ToolStripMenuItem mMItemMaterials;
        private System.Windows.Forms.ToolStripMenuItem MItemOpenMaterial;
        private System.Windows.Forms.ToolStripMenuItem MItemAddMaterial;
        private System.Windows.Forms.ToolStripMenuItem MItemSaveAll;
        private System.Windows.Forms.ToolStripMenuItem MItemRemoveEntity;
    }
}

