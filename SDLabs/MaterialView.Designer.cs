namespace SDLabsMain
{
    partial class MaterialView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaterial = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTemperature = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSpeed = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вещество:";
            // 
            // txtMaterial
            // 
            this.txtMaterial.Location = new System.Drawing.Point(77, 10);
            this.txtMaterial.Name = "txtMaterial";
            this.txtMaterial.ReadOnly = true;
            this.txtMaterial.Size = new System.Drawing.Size(195, 20);
            this.txtMaterial.TabIndex = 1;
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(77, 36);
            this.txtType.Name = "txtType";
            this.txtType.ReadOnly = true;
            this.txtType.Size = new System.Drawing.Size(195, 20);
            this.txtType.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Тип:";
            // 
            // txtTemperature
            // 
            this.txtTemperature.Location = new System.Drawing.Point(96, 62);
            this.txtTemperature.Name = "txtTemperature";
            this.txtTemperature.ReadOnly = true;
            this.txtTemperature.Size = new System.Drawing.Size(176, 20);
            this.txtTemperature.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Температура:";
            // 
            // txtSpeed
            // 
            this.txtSpeed.Location = new System.Drawing.Point(77, 88);
            this.txtSpeed.Name = "txtSpeed";
            this.txtSpeed.ReadOnly = true;
            this.txtSpeed.Size = new System.Drawing.Size(195, 20);
            this.txtSpeed.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Скорость:";
            // 
            // MaterialView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 124);
            this.Controls.Add(this.txtSpeed);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTemperature);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaterial);
            this.Controls.Add(this.label1);
            this.Name = "MaterialView";
            this.Text = "Вещество";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaterial;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTemperature;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSpeed;
        private System.Windows.Forms.Label label4;
    }
}