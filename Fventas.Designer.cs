﻿namespace Torres_Anibal_Parcial
{
    partial class Fventas
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idtipoLabel;
            System.Windows.Forms.Label fechaventaLabel;
            System.Windows.Forms.Label idtipopagoLabel;
            System.Windows.Forms.Label idusuarioLabel;
            System.Windows.Forms.Label nfvvLabel;
            System.Windows.Forms.Label idventaLabel;
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblregistroxden = new System.Windows.Forms.Label();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnPrimero = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotalVenta = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblIvaVenta = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSumaVenta = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlEdicion = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.pnlProductosGrid = new System.Windows.Forms.Panel();
            this.btnQuitarProductosGrid = new System.Windows.Forms.Button();
            this.btnAgregarProductosGrid = new System.Windows.Forms.Button();
            this.tipodocumentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipospagosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detallesventasTableAdapter = new Torres_Anibal_Parcial.DBDataSetventasTableAdapters.detallesventasTableAdapter();
            this.detallesventasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosTableAdapter = new Torres_Anibal_Parcial.DBDataSetventasTableAdapters.usuariosTableAdapter();
            this.tipospagosTableAdapter = new Torres_Anibal_Parcial.DBDataSetventasTableAdapters.tipospagosTableAdapter();
            this.tipodocumentoTableAdapter = new Torres_Anibal_Parcial.DBDataSetventasTableAdapters.tipodocumentoTableAdapter();
            this.tableAdapterManager = new Torres_Anibal_Parcial.DBDataSetventasTableAdapters.TableAdapterManager();
            this.ventasTableAdapter = new Torres_Anibal_Parcial.DBDataSetventasTableAdapters.ventasTableAdapter();
            this.ventasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBDataSetventas = new Torres_Anibal_Parcial.DBDataSetventas();
            this.idtipoComboBox = new System.Windows.Forms.ComboBox();
            this.fechaventaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.idtipopagoComboBox = new System.Windows.Forms.ComboBox();
            this.idusuarioComboBox = new System.Windows.Forms.ComboBox();
            this.nfvvComboBox = new System.Windows.Forms.ComboBox();
            this.idventaTextBox = new System.Windows.Forms.TextBox();
            this.dventasTableAdapter11 = new Torres_Anibal_Parcial.DBDataSetventasTableAdapters.dventasTableAdapter1();
            this.detallesventasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.detallesventasDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idtipoLabel = new System.Windows.Forms.Label();
            fechaventaLabel = new System.Windows.Forms.Label();
            idtipopagoLabel = new System.Windows.Forms.Label();
            idusuarioLabel = new System.Windows.Forms.Label();
            nfvvLabel = new System.Windows.Forms.Label();
            idventaLabel = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlEdicion.SuspendLayout();
            this.pnlProductosGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipodocumentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipospagosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallesventasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSetventas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallesventasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallesventasDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idtipoLabel
            // 
            idtipoLabel.AutoSize = true;
            idtipoLabel.Location = new System.Drawing.Point(516, 58);
            idtipoLabel.Name = "idtipoLabel";
            idtipoLabel.Size = new System.Drawing.Size(35, 13);
            idtipoLabel.TabIndex = 43;
            idtipoLabel.Text = "idtipo:";
            // 
            // fechaventaLabel
            // 
            fechaventaLabel.AutoSize = true;
            fechaventaLabel.Location = new System.Drawing.Point(416, 16);
            fechaventaLabel.Name = "fechaventaLabel";
            fechaventaLabel.Size = new System.Drawing.Size(64, 13);
            fechaventaLabel.TabIndex = 41;
            fechaventaLabel.Text = "fechaventa:";
            // 
            // idtipopagoLabel
            // 
            idtipopagoLabel.AutoSize = true;
            idtipopagoLabel.Location = new System.Drawing.Point(314, 55);
            idtipopagoLabel.Name = "idtipopagoLabel";
            idtipopagoLabel.Size = new System.Drawing.Size(59, 13);
            idtipopagoLabel.TabIndex = 39;
            idtipopagoLabel.Text = "idtipopago:";
            // 
            // idusuarioLabel
            // 
            idusuarioLabel.AutoSize = true;
            idusuarioLabel.Location = new System.Drawing.Point(5, 52);
            idusuarioLabel.Name = "idusuarioLabel";
            idusuarioLabel.Size = new System.Drawing.Size(52, 13);
            idusuarioLabel.TabIndex = 37;
            idusuarioLabel.Text = "idusuario:";
            // 
            // nfvvLabel
            // 
            nfvvLabel.AutoSize = true;
            nfvvLabel.Location = new System.Drawing.Point(143, 14);
            nfvvLabel.Name = "nfvvLabel";
            nfvvLabel.Size = new System.Drawing.Size(31, 13);
            nfvvLabel.TabIndex = 35;
            nfvvLabel.Text = "nfvv:";
            // 
            // idventaLabel
            // 
            idventaLabel.AutoSize = true;
            idventaLabel.Location = new System.Drawing.Point(5, 15);
            idventaLabel.Name = "idventaLabel";
            idventaLabel.Size = new System.Drawing.Size(45, 13);
            idventaLabel.TabIndex = 33;
            idventaLabel.Text = "idventa:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblregistroxden);
            this.panel2.Controls.Add(this.btnUltimo);
            this.panel2.Controls.Add(this.btnSiguiente);
            this.panel2.Controls.Add(this.btnAnterior);
            this.panel2.Controls.Add(this.btnPrimero);
            this.panel2.Location = new System.Drawing.Point(37, 440);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(204, 49);
            this.panel2.TabIndex = 21;
            // 
            // lblregistroxden
            // 
            this.lblregistroxden.AutoSize = true;
            this.lblregistroxden.Location = new System.Drawing.Point(71, 16);
            this.lblregistroxden.Name = "lblregistroxden";
            this.lblregistroxden.Size = new System.Drawing.Size(36, 13);
            this.lblregistroxden.TabIndex = 6;
            this.lblregistroxden.Text = "x de n";
            // 
            // btnUltimo
            // 
            this.btnUltimo.Location = new System.Drawing.Point(167, 3);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(32, 38);
            this.btnUltimo.TabIndex = 3;
            this.btnUltimo.Text = ">|";
            this.btnUltimo.UseVisualStyleBackColor = true;
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(129, 3);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(32, 38);
            this.btnSiguiente.TabIndex = 2;
            this.btnSiguiente.Text = ">";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(38, 3);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(32, 38);
            this.btnAnterior.TabIndex = 1;
            this.btnAnterior.Text = "<";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnPrimero
            // 
            this.btnPrimero.Location = new System.Drawing.Point(7, 3);
            this.btnPrimero.Name = "btnPrimero";
            this.btnPrimero.Size = new System.Drawing.Size(32, 38);
            this.btnPrimero.TabIndex = 0;
            this.btnPrimero.Text = "|<";
            this.btnPrimero.UseVisualStyleBackColor = true;
            this.btnPrimero.Click += new System.EventHandler(this.btnPrimero_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTotalVenta);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblIvaVenta);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblSumaVenta);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(517, 335);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 92);
            this.panel1.TabIndex = 20;
            // 
            // lblTotalVenta
            // 
            this.lblTotalVenta.AutoSize = true;
            this.lblTotalVenta.Location = new System.Drawing.Point(142, 61);
            this.lblTotalVenta.Name = "lblTotalVenta";
            this.lblTotalVenta.Size = new System.Drawing.Size(46, 13);
            this.lblTotalVenta.TabIndex = 5;
            this.lblTotalVenta.Text = "0000.00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "TOTAL:";
            // 
            // lblIvaVenta
            // 
            this.lblIvaVenta.AutoSize = true;
            this.lblIvaVenta.Location = new System.Drawing.Point(154, 36);
            this.lblIvaVenta.Name = "lblIvaVenta";
            this.lblIvaVenta.Size = new System.Drawing.Size(34, 13);
            this.lblIvaVenta.TabIndex = 3;
            this.lblIvaVenta.Text = "00.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "IVA:";
            // 
            // lblSumaVenta
            // 
            this.lblSumaVenta.AutoSize = true;
            this.lblSumaVenta.Location = new System.Drawing.Point(142, 12);
            this.lblSumaVenta.Name = "lblSumaVenta";
            this.lblSumaVenta.Size = new System.Drawing.Size(46, 13);
            this.lblSumaVenta.TabIndex = 1;
            this.lblSumaVenta.Text = "0000.00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SUMA:";
            // 
            // pnlEdicion
            // 
            this.pnlEdicion.Controls.Add(this.btnBuscar);
            this.pnlEdicion.Controls.Add(this.btnEliminar);
            this.pnlEdicion.Controls.Add(this.btnModificar);
            this.pnlEdicion.Controls.Add(this.btnAgregar);
            this.pnlEdicion.Location = new System.Drawing.Point(259, 440);
            this.pnlEdicion.Name = "pnlEdicion";
            this.pnlEdicion.Size = new System.Drawing.Size(260, 49);
            this.pnlEdicion.TabIndex = 47;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(200, 3);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(53, 38);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(146, 3);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(53, 38);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(73, 3);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(72, 38);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(5, 3);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(67, 38);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Nuevo";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // pnlProductosGrid
            // 
            this.pnlProductosGrid.Controls.Add(this.btnQuitarProductosGrid);
            this.pnlProductosGrid.Controls.Add(this.btnAgregarProductosGrid);
            this.pnlProductosGrid.Location = new System.Drawing.Point(50, 347);
            this.pnlProductosGrid.Name = "pnlProductosGrid";
            this.pnlProductosGrid.Size = new System.Drawing.Size(94, 49);
            this.pnlProductosGrid.TabIndex = 48;
            this.pnlProductosGrid.Visible = false;
            // 
            // btnQuitarProductosGrid
            // 
            this.btnQuitarProductosGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarProductosGrid.Location = new System.Drawing.Point(52, 4);
            this.btnQuitarProductosGrid.Name = "btnQuitarProductosGrid";
            this.btnQuitarProductosGrid.Size = new System.Drawing.Size(31, 38);
            this.btnQuitarProductosGrid.TabIndex = 1;
            this.btnQuitarProductosGrid.Text = "-";
            this.btnQuitarProductosGrid.UseVisualStyleBackColor = true;
            this.btnQuitarProductosGrid.Click += new System.EventHandler(this.btnQuitarProductosGrid_Click);
            // 
            // btnAgregarProductosGrid
            // 
            this.btnAgregarProductosGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProductosGrid.Location = new System.Drawing.Point(5, 4);
            this.btnAgregarProductosGrid.Name = "btnAgregarProductosGrid";
            this.btnAgregarProductosGrid.Size = new System.Drawing.Size(47, 38);
            this.btnAgregarProductosGrid.TabIndex = 0;
            this.btnAgregarProductosGrid.Text = "+";
            this.btnAgregarProductosGrid.UseVisualStyleBackColor = true;
            this.btnAgregarProductosGrid.Click += new System.EventHandler(this.btnAgregarProductosGrid_Click);
            // 
            // tipodocumentoBindingSource
            // 
            this.tipodocumentoBindingSource.DataMember = "tipodocumento";
            // 
            // tipospagosBindingSource
            // 
            this.tipospagosBindingSource.DataMember = "tipospagos";
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "usuarios";
            // 
            // detallesventasTableAdapter
            // 
            this.detallesventasTableAdapter.ClearBeforeFill = true;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // tipospagosTableAdapter
            // 
            this.tipospagosTableAdapter.ClearBeforeFill = true;
            // 
            // tipodocumentoTableAdapter
            // 
            this.tipodocumentoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.dventasTableAdapter1 = null;
            this.tableAdapterManager.productosTableAdapter = null;
            this.tableAdapterManager.tipodocumentoTableAdapter = this.tipodocumentoTableAdapter;
            this.tableAdapterManager.tipospagosTableAdapter = this.tipospagosTableAdapter;
            this.tableAdapterManager.UpdateOrder = Torres_Anibal_Parcial.DBDataSetventasTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuariosTableAdapter = this.usuariosTableAdapter;
            this.tableAdapterManager.ventasTableAdapter = this.ventasTableAdapter;
            // 
            // ventasTableAdapter
            // 
            this.ventasTableAdapter.ClearBeforeFill = true;
            // 
            // ventasBindingSource
            // 
            this.ventasBindingSource.DataMember = "ventas";
            // 
            // dBDataSetventas
            // 
            this.dBDataSetventas.DataSetName = "DBDataSetventas";
            this.dBDataSetventas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idtipoComboBox
            // 
            this.idtipoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventasBindingSource, "idtipo", true));
            this.idtipoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ventasBindingSource, "idtipo", true));
            this.idtipoComboBox.DataSource = this.tipodocumentoBindingSource;
            this.idtipoComboBox.DisplayMember = "tipo";
            this.idtipoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.idtipoComboBox.FormattingEnabled = true;
            this.idtipoComboBox.Location = new System.Drawing.Point(586, 55);
            this.idtipoComboBox.Name = "idtipoComboBox";
            this.idtipoComboBox.Size = new System.Drawing.Size(100, 21);
            this.idtipoComboBox.TabIndex = 44;
            this.idtipoComboBox.ValueMember = "idtipo";
            // 
            // fechaventaDateTimePicker
            // 
            this.fechaventaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ventasBindingSource, "fechaventa", true));
            this.fechaventaDateTimePicker.Location = new System.Drawing.Point(486, 12);
            this.fechaventaDateTimePicker.Name = "fechaventaDateTimePicker";
            this.fechaventaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaventaDateTimePicker.TabIndex = 42;
            // 
            // idtipopagoComboBox
            // 
            this.idtipopagoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventasBindingSource, "idtipopago", true));
            this.idtipopagoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ventasBindingSource, "idtipopago", true));
            this.idtipopagoComboBox.DataSource = this.tipospagosBindingSource;
            this.idtipopagoComboBox.DisplayMember = "tipopago";
            this.idtipopagoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.idtipopagoComboBox.FormattingEnabled = true;
            this.idtipopagoComboBox.Location = new System.Drawing.Point(384, 52);
            this.idtipopagoComboBox.Name = "idtipopagoComboBox";
            this.idtipopagoComboBox.Size = new System.Drawing.Size(101, 21);
            this.idtipopagoComboBox.TabIndex = 40;
            this.idtipopagoComboBox.ValueMember = "idtipopago";
            // 
            // idusuarioComboBox
            // 
            this.idusuarioComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventasBindingSource, "idusuario", true));
            this.idusuarioComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ventasBindingSource, "idusuario", true));
            this.idusuarioComboBox.DataSource = this.usuariosBindingSource;
            this.idusuarioComboBox.DisplayMember = "nombre";
            this.idusuarioComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.idusuarioComboBox.FormattingEnabled = true;
            this.idusuarioComboBox.Location = new System.Drawing.Point(75, 49);
            this.idusuarioComboBox.Name = "idusuarioComboBox";
            this.idusuarioComboBox.Size = new System.Drawing.Size(200, 21);
            this.idusuarioComboBox.TabIndex = 38;
            this.idusuarioComboBox.ValueMember = "idusuario";
            // 
            // nfvvComboBox
            // 
            this.nfvvComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventasBindingSource, "nfvv", true));
            this.nfvvComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ventasBindingSource, "idventa", true));
            this.nfvvComboBox.DataSource = this.ventasBindingSource;
            this.nfvvComboBox.DisplayMember = "nfvv";
            this.nfvvComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nfvvComboBox.FormattingEnabled = true;
            this.nfvvComboBox.Location = new System.Drawing.Point(213, 11);
            this.nfvvComboBox.Name = "nfvvComboBox";
            this.nfvvComboBox.Size = new System.Drawing.Size(42, 21);
            this.nfvvComboBox.TabIndex = 36;
            this.nfvvComboBox.ValueMember = "idventa";
            // 
            // idventaTextBox
            // 
            this.idventaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventasBindingSource, "idventa", true));
            this.idventaTextBox.Location = new System.Drawing.Point(75, 12);
            this.idventaTextBox.Name = "idventaTextBox";
            this.idventaTextBox.Size = new System.Drawing.Size(41, 20);
            this.idventaTextBox.TabIndex = 34;
            // 
            // dventasTableAdapter11
            // 
            this.dventasTableAdapter11.ClearBeforeFill = true;
            // 
            // detallesventasBindingSource1
            // 
            this.detallesventasBindingSource1.DataMember = "detallesventas";
            this.detallesventasBindingSource1.DataSource = this.dBDataSetventas;
            // 
            // detallesventasDataGridView
            // 
            this.detallesventasDataGridView.AutoGenerateColumns = false;
            this.detallesventasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detallesventasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.detallesventasDataGridView.DataSource = this.detallesventasBindingSource1;
            this.detallesventasDataGridView.Location = new System.Drawing.Point(8, 124);
            this.detallesventasDataGridView.Name = "detallesventasDataGridView";
            this.detallesventasDataGridView.Size = new System.Drawing.Size(717, 189);
            this.detallesventasDataGridView.TabIndex = 48;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "iddetalle";
            this.dataGridViewTextBoxColumn1.HeaderText = "iddetalle";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "idventa";
            this.dataGridViewTextBoxColumn2.HeaderText = "idventa";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "idproducto";
            this.dataGridViewTextBoxColumn3.HeaderText = "idproducto";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "cantidad";
            this.dataGridViewTextBoxColumn4.HeaderText = "cantidad";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "descuento";
            this.dataGridViewTextBoxColumn5.HeaderText = "descuento";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "precio";
            this.dataGridViewTextBoxColumn6.HeaderText = "precio";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "codigo";
            this.dataGridViewTextBoxColumn7.HeaderText = "codigo";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn8.HeaderText = "nombre";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "subtotal";
            this.dataGridViewTextBoxColumn9.HeaderText = "subtotal";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // Fventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(737, 509);
            this.Controls.Add(this.detallesventasDataGridView);
            this.Controls.Add(this.pnlProductosGrid);
            this.Controls.Add(this.pnlEdicion);
            this.Controls.Add(idventaLabel);
            this.Controls.Add(this.idventaTextBox);
            this.Controls.Add(nfvvLabel);
            this.Controls.Add(this.nfvvComboBox);
            this.Controls.Add(idusuarioLabel);
            this.Controls.Add(this.idusuarioComboBox);
            this.Controls.Add(idtipopagoLabel);
            this.Controls.Add(this.idtipopagoComboBox);
            this.Controls.Add(fechaventaLabel);
            this.Controls.Add(this.fechaventaDateTimePicker);
            this.Controls.Add(idtipoLabel);
            this.Controls.Add(this.idtipoComboBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Fventas";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.Fventas_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlEdicion.ResumeLayout(false);
            this.pnlProductosGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tipodocumentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipospagosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallesventasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSetventas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallesventasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallesventasDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblregistroxden;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnPrimero;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTotalVenta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblIvaVenta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSumaVenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlEdicion;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Panel pnlProductosGrid;
        private System.Windows.Forms.Button btnQuitarProductosGrid;
        private System.Windows.Forms.Button btnAgregarProductosGrid;
        private System.Windows.Forms.BindingSource tipodocumentoBindingSource;
        private System.Windows.Forms.BindingSource tipospagosBindingSource;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private DBDataSetventasTableAdapters.detallesventasTableAdapter detallesventasTableAdapter;
        private System.Windows.Forms.BindingSource detallesventasBindingSource;
        private DBDataSetventasTableAdapters.usuariosTableAdapter usuariosTableAdapter;
        private DBDataSetventasTableAdapters.tipospagosTableAdapter tipospagosTableAdapter;
        private DBDataSetventasTableAdapters.tipodocumentoTableAdapter tipodocumentoTableAdapter;
        private DBDataSetventasTableAdapters.TableAdapterManager tableAdapterManager;
        private DBDataSetventasTableAdapters.ventasTableAdapter ventasTableAdapter;
        private System.Windows.Forms.BindingSource ventasBindingSource;
        private DBDataSetventas dBDataSetventas;
        private System.Windows.Forms.ComboBox idtipoComboBox;
        private System.Windows.Forms.DateTimePicker fechaventaDateTimePicker;
        private System.Windows.Forms.ComboBox idtipopagoComboBox;
        private System.Windows.Forms.ComboBox idusuarioComboBox;
        private System.Windows.Forms.ComboBox nfvvComboBox;
        private System.Windows.Forms.TextBox idventaTextBox;
        private DBDataSetventasTableAdapters.dventasTableAdapter1 dventasTableAdapter11;
        private System.Windows.Forms.BindingSource detallesventasBindingSource1;
        private System.Windows.Forms.DataGridView detallesventasDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    }
}