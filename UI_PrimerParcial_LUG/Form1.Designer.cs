namespace UI_PrimerParcial_LUG
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
            BtnCancelar = new Button();
            label9 = new Label();
            BtnSalir = new Button();
            BtnModificar = new Button();
            label8 = new Label();
            TxtIdModificar = new TextBox();
            TxtIdEliminar = new TextBox();
            BtnEliminar = new Button();
            label7 = new Label();
            DtvPartidos = new DataGridView();
            BtnGuardar = new Button();
            DatePartido = new DateTimePicker();
            label6 = new Label();
            TxtEquipVisitante = new TextBox();
            label5 = new Label();
            TxtEquipoLocal = new TextBox();
            label4 = new Label();
            CmbTipoDeporte = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label10 = new Label();
            TxtMarcadorLocal = new TextBox();
            TxtMarcadorVisitante = new TextBox();
            BtnConfirmar = new Button();
            ((System.ComponentModel.ISupportInitialize)DtvPartidos).BeginInit();
            SuspendLayout();
            // 
            // BtnCancelar
            // 
            BtnCancelar.Location = new Point(226, 436);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(88, 23);
            BtnCancelar.TabIndex = 43;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(551, 356);
            label9.Name = "label9";
            label9.Size = new Size(92, 15);
            label9.TabIndex = 41;
            label9.Text = "Marcador Local:";
            // 
            // BtnSalir
            // 
            BtnSalir.Location = new Point(763, 436);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(75, 23);
            BtnSalir.TabIndex = 40;
            BtnSalir.Text = "Salir";
            BtnSalir.UseVisualStyleBackColor = true;
            BtnSalir.Click += BtnSalir_Click;
            // 
            // BtnModificar
            // 
            BtnModificar.Location = new Point(753, 384);
            BtnModificar.Name = "BtnModificar";
            BtnModificar.Size = new Size(75, 23);
            BtnModificar.TabIndex = 39;
            BtnModificar.Text = "Modificar";
            BtnModificar.UseVisualStyleBackColor = true;
            BtnModificar.Click += BtnModificar_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(605, 291);
            label8.Name = "label8";
            label8.Size = new Size(223, 15);
            label8.TabIndex = 38;
            label8.Text = "Actializar marcador Partido, ingrese el ID:";
            // 
            // TxtIdModificar
            // 
            TxtIdModificar.Location = new Point(605, 309);
            TxtIdModificar.Name = "TxtIdModificar";
            TxtIdModificar.Size = new Size(222, 23);
            TxtIdModificar.TabIndex = 37;
            // 
            // TxtIdEliminar
            // 
            TxtIdEliminar.Location = new Point(256, 320);
            TxtIdEliminar.Name = "TxtIdEliminar";
            TxtIdEliminar.Size = new Size(164, 23);
            TxtIdEliminar.TabIndex = 36;
            // 
            // BtnEliminar
            // 
            BtnEliminar.Location = new Point(349, 356);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(75, 23);
            BtnEliminar.TabIndex = 35;
            BtnEliminar.Text = "Eliminar";
            BtnEliminar.UseVisualStyleBackColor = true;
            BtnEliminar.Click += BtnEliminar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(256, 291);
            label7.Name = "label7";
            label7.Size = new Size(164, 15);
            label7.TabIndex = 34;
            label7.Text = "Eliminar Partido, ingrese el ID:";
            // 
            // DtvPartidos
            // 
            DtvPartidos.AllowUserToAddRows = false;
            DtvPartidos.AllowUserToDeleteRows = false;
            DtvPartidos.AllowUserToOrderColumns = true;
            DtvPartidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DtvPartidos.Location = new Point(226, 50);
            DtvPartidos.Name = "DtvPartidos";
            DtvPartidos.ReadOnly = true;
            DtvPartidos.Size = new Size(617, 224);
            DtvPartidos.TabIndex = 33;
            // 
            // BtnGuardar
            // 
            BtnGuardar.Location = new Point(12, 436);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(92, 23);
            BtnGuardar.TabIndex = 32;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.UseVisualStyleBackColor = true;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // DatePartido
            // 
            DatePartido.Location = new Point(8, 335);
            DatePartido.Name = "DatePartido";
            DatePartido.Size = new Size(200, 23);
            DatePartido.TabIndex = 31;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(8, 299);
            label6.Name = "label6";
            label6.Size = new Size(98, 15);
            label6.TabIndex = 30;
            label6.Text = "Fecha del Partido";
            // 
            // TxtEquipVisitante
            // 
            TxtEquipVisitante.Location = new Point(8, 259);
            TxtEquipVisitante.Name = "TxtEquipVisitante";
            TxtEquipVisitante.Size = new Size(150, 23);
            TxtEquipVisitante.TabIndex = 29;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 224);
            label5.Name = "label5";
            label5.Size = new Size(92, 15);
            label5.TabIndex = 28;
            label5.Text = "Equipo Visitante";
            // 
            // TxtEquipoLocal
            // 
            TxtEquipoLocal.Location = new Point(8, 167);
            TxtEquipoLocal.Name = "TxtEquipoLocal";
            TxtEquipoLocal.Size = new Size(150, 23);
            TxtEquipoLocal.TabIndex = 27;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 134);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 26;
            label4.Text = "Equipo Local";
            // 
            // CmbTipoDeporte
            // 
            CmbTipoDeporte.FormattingEnabled = true;
            CmbTipoDeporte.Location = new Point(8, 86);
            CmbTipoDeporte.Name = "CmbTipoDeporte";
            CmbTipoDeporte.Size = new Size(150, 23);
            CmbTipoDeporte.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 50);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 24;
            label3.Text = "Deporte";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(237, 9);
            label2.Name = "label2";
            label2.Size = new Size(163, 25);
            label2.TabIndex = 23;
            label2.Text = "Todos los Partidos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(9, 9);
            label1.Name = "label1";
            label1.Size = new Size(132, 25);
            label1.TabIndex = 22;
            label1.Text = "Nuevo Partido";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(691, 356);
            label10.Name = "label10";
            label10.Size = new Size(109, 15);
            label10.TabIndex = 44;
            label10.Text = "Marcador Visitante:";
            // 
            // TxtMarcadorLocal
            // 
            TxtMarcadorLocal.Location = new Point(652, 348);
            TxtMarcadorLocal.Name = "TxtMarcadorLocal";
            TxtMarcadorLocal.Size = new Size(29, 23);
            TxtMarcadorLocal.TabIndex = 45;
            // 
            // TxtMarcadorVisitante
            // 
            TxtMarcadorVisitante.Location = new Point(806, 348);
            TxtMarcadorVisitante.Name = "TxtMarcadorVisitante";
            TxtMarcadorVisitante.Size = new Size(29, 23);
            TxtMarcadorVisitante.TabIndex = 46;
            // 
            // BtnConfirmar
            // 
            BtnConfirmar.Location = new Point(121, 436);
            BtnConfirmar.Name = "BtnConfirmar";
            BtnConfirmar.Size = new Size(87, 23);
            BtnConfirmar.TabIndex = 47;
            BtnConfirmar.Text = "Confirmar";
            BtnConfirmar.UseVisualStyleBackColor = true;
            BtnConfirmar.Click += BtnConfirmar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(855, 481);
            Controls.Add(BtnConfirmar);
            Controls.Add(TxtMarcadorVisitante);
            Controls.Add(TxtMarcadorLocal);
            Controls.Add(label10);
            Controls.Add(BtnCancelar);
            Controls.Add(label9);
            Controls.Add(BtnSalir);
            Controls.Add(BtnModificar);
            Controls.Add(label8);
            Controls.Add(TxtIdModificar);
            Controls.Add(TxtIdEliminar);
            Controls.Add(BtnEliminar);
            Controls.Add(label7);
            Controls.Add(DtvPartidos);
            Controls.Add(BtnGuardar);
            Controls.Add(DatePartido);
            Controls.Add(label6);
            Controls.Add(TxtEquipVisitante);
            Controls.Add(label5);
            Controls.Add(TxtEquipoLocal);
            Controls.Add(label4);
            Controls.Add(CmbTipoDeporte);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)DtvPartidos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnCancelar;
        private Label label9;
        private Button BtnSalir;
        private Button BtnModificar;
        private Label label8;
        private TextBox TxtIdModificar;
        private TextBox TxtIdEliminar;
        private Button BtnEliminar;
        private Label label7;
        private DataGridView DtvPartidos;
        private Button BtnGuardar;
        private DateTimePicker DatePartido;
        private Label label6;
        private TextBox TxtEquipVisitante;
        private Label label5;
        private TextBox TxtEquipoLocal;
        private Label label4;
        private ComboBox CmbTipoDeporte;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label10;
        private TextBox TxtMarcadorLocal;
        private TextBox TxtMarcadorVisitante;
        private Button BtnConfirmar;
    }
}
