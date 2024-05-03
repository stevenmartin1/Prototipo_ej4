namespace ClasePrototipos
{
    partial class PersonasForm
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
            lstwPersonas = new ListView();
            DocumentoCol = new ColumnHeader();
            NombreCol = new ColumnHeader();
            ApellidoCol = new ColumnHeader();
            TelefonoCol = new ColumnHeader();
            SuspendLayout();
            // 
            // lstwPersonas
            // 
            lstwPersonas.Columns.AddRange(new ColumnHeader[] { DocumentoCol, NombreCol, ApellidoCol, TelefonoCol });
            lstwPersonas.FullRowSelect = true;
            lstwPersonas.GridLines = true;
            lstwPersonas.Location = new Point(88, 45);
            lstwPersonas.Name = "lstwPersonas";
            lstwPersonas.Size = new Size(616, 310);
            lstwPersonas.TabIndex = 0;
            lstwPersonas.UseCompatibleStateImageBehavior = false;
            lstwPersonas.View = View.Details;
            // 
            // DocumentoCol
            // 
            DocumentoCol.Text = "Documento";
            // 
            // NombreCol
            // 
            NombreCol.Text = "Nombre";
            // 
            // ApellidoCol
            // 
            ApellidoCol.Text = "Apellido";
            // 
            // TelefonoCol
            // 
            TelefonoCol.Text = "Telefono";
            // 
            // PersonasForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstwPersonas);
            Name = "PersonasForm";
            Text = "Form1";
            Load += PersonasForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView lstwPersonas;
        private ColumnHeader DocumentoCol;
        private ColumnHeader NombreCol;
        private ColumnHeader ApellidoCol;
        private ColumnHeader TelefonoCol;
    }
}
