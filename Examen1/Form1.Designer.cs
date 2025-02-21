namespace Examen1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DGV = new DataGridView();
            openFileDialog1 = new OpenFileDialog();
            BTN_CARGAR = new Button();
            ((System.ComponentModel.ISupportInitialize)DGV).BeginInit();
            SuspendLayout();
            // 
            // DGV
            // 
            DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV.Location = new Point(12, 12);
            DGV.Name = "DGV";
            DGV.RowHeadersWidth = 51;
            DGV.Size = new Size(786, 567);
            DGV.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            openFileDialog1.AutoUpgradeEnabled = false;
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "Archivo CSV|*.csv";
            // 
            // BTN_CARGAR
            // 
            BTN_CARGAR.Location = new Point(309, 585);
            BTN_CARGAR.Name = "BTN_CARGAR";
            BTN_CARGAR.Size = new Size(182, 29);
            BTN_CARGAR.TabIndex = 1;
            BTN_CARGAR.Text = "CARGAR ARCHIVO";
            BTN_CARGAR.UseVisualStyleBackColor = true;
            BTN_CARGAR.Click += BTN_CARGAR_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(810, 626);
            Controls.Add(BTN_CARGAR);
            Controls.Add(DGV);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)DGV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DGV;
        private OpenFileDialog openFileDialog1;
        private Button BTN_CARGAR;
    }
}
