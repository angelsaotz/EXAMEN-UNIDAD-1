namespace EXAMEN_UNIDAD_1
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
            DGVDATOS = new DataGridView();
            CARGARD = new Button();
            ((System.ComponentModel.ISupportInitialize)DGVDATOS).BeginInit();
            SuspendLayout();
            // 
            // DGVDATOS
            // 
            DGVDATOS.BackgroundColor = SystemColors.HighlightText;
            DGVDATOS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVDATOS.Location = new Point(27, 103);
            DGVDATOS.Name = "DGVDATOS";
            DGVDATOS.RowHeadersWidth = 51;
            DGVDATOS.Size = new Size(736, 335);
            DGVDATOS.TabIndex = 0;
            DGVDATOS.CellContentClick += DGVDATOS_CellContentClick;
            // 
            // CARGARD
            // 
            CARGARD.BackColor = SystemColors.Window;
            CARGARD.Font = new Font("Franklin Gothic Heavy", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CARGARD.Location = new Point(211, 29);
            CARGARD.Name = "CARGARD";
            CARGARD.Size = new Size(368, 57);
            CARGARD.TabIndex = 1;
            CARGARD.Text = "CARGAR DATOS";
            CARGARD.UseVisualStyleBackColor = false;
            CARGARD.Click += CARGARD_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(CARGARD);
            Controls.Add(DGVDATOS);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)DGVDATOS).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DGVDATOS;
        private Button CARGARD;
    }
}
