﻿namespace Frm_Moficar_Configuracion_Turnos
{
    partial class Frm_Modificar_Configuracion_Turnos
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Modificar_Configuracion_Turnos));
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_num_cama = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_num_habitacion = new System.Windows.Forms.Button();
            this.txtnum_cama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnum_habitacion = new System.Windows.Forms.TextBox();
            this.btn_tipo_turno = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txttipo_turno = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.Ayuda = new AyudaSpreadNet.AyudaSprNet();
            this.grilla_turnos = new System.Windows.Forms.DataGridView();
            this.V = new System.Windows.Forms.DataGridViewImageColumn();
            this.M = new System.Windows.Forms.DataGridViewImageColumn();
            this.ID_TURNOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COD_TURNOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOM_TURNOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COD_HABITACIONS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOM_HABITACIONS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COD_CAMAS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUM_CAMAS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VIGENCIAS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_turnos)).BeginInit();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Image = ((System.Drawing.Image)(resources.GetObject("label13.Image")));
            this.label13.Location = new System.Drawing.Point(7, 156);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(631, 25);
            this.label13.TabIndex = 226;
            this.label13.Text = "Listado";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.btn_num_cama);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btn_num_habitacion);
            this.groupBox1.Controls.Add(this.txtnum_cama);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtnum_habitacion);
            this.groupBox1.Controls.Add(this.btn_tipo_turno);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txttipo_turno);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(3, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(635, 101);
            this.groupBox1.TabIndex = 225;
            this.groupBox1.TabStop = false;
            // 
            // btn_num_cama
            // 
            this.btn_num_cama.Image = ((System.Drawing.Image)(resources.GetObject("btn_num_cama.Image")));
            this.btn_num_cama.Location = new System.Drawing.Point(244, 67);
            this.btn_num_cama.Name = "btn_num_cama";
            this.btn_num_cama.Size = new System.Drawing.Size(27, 23);
            this.btn_num_cama.TabIndex = 200;
            this.btn_num_cama.UseVisualStyleBackColor = true;
            this.btn_num_cama.Click += new System.EventHandler(this.btn_num_cama_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 199;
            this.label3.Text = "N° Camas";
            // 
            // btn_num_habitacion
            // 
            this.btn_num_habitacion.Image = ((System.Drawing.Image)(resources.GetObject("btn_num_habitacion.Image")));
            this.btn_num_habitacion.Location = new System.Drawing.Point(528, 39);
            this.btn_num_habitacion.Name = "btn_num_habitacion";
            this.btn_num_habitacion.Size = new System.Drawing.Size(27, 23);
            this.btn_num_habitacion.TabIndex = 191;
            this.btn_num_habitacion.UseVisualStyleBackColor = true;
            this.btn_num_habitacion.Click += new System.EventHandler(this.btn_num_habitacion_Click);
            // 
            // txtnum_cama
            // 
            this.txtnum_cama.BackColor = System.Drawing.Color.White;
            this.txtnum_cama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnum_cama.Location = new System.Drawing.Point(78, 69);
            this.txtnum_cama.Name = "txtnum_cama";
            this.txtnum_cama.Size = new System.Drawing.Size(160, 20);
            this.txtnum_cama.TabIndex = 198;
            this.txtnum_cama.Enter += new System.EventHandler(this.CambiarColor_TextEnter);
            this.txtnum_cama.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnum_cama_KeyPress);
            this.txtnum_cama.Leave += new System.EventHandler(this.CambiarBlanco_TextLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(288, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 190;
            this.label1.Text = "Habitación";
            // 
            // txtnum_habitacion
            // 
            this.txtnum_habitacion.BackColor = System.Drawing.Color.White;
            this.txtnum_habitacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnum_habitacion.Location = new System.Drawing.Point(362, 41);
            this.txtnum_habitacion.Name = "txtnum_habitacion";
            this.txtnum_habitacion.Size = new System.Drawing.Size(160, 20);
            this.txtnum_habitacion.TabIndex = 189;
            this.txtnum_habitacion.Enter += new System.EventHandler(this.CambiarColor_TextEnter);
            this.txtnum_habitacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnum_habitacion_KeyPress);
            this.txtnum_habitacion.Leave += new System.EventHandler(this.CambiarBlanco_TextLeave);
            // 
            // btn_tipo_turno
            // 
            this.btn_tipo_turno.Image = ((System.Drawing.Image)(resources.GetObject("btn_tipo_turno.Image")));
            this.btn_tipo_turno.Location = new System.Drawing.Point(244, 39);
            this.btn_tipo_turno.Name = "btn_tipo_turno";
            this.btn_tipo_turno.Size = new System.Drawing.Size(27, 23);
            this.btn_tipo_turno.TabIndex = 183;
            this.btn_tipo_turno.UseVisualStyleBackColor = true;
            this.btn_tipo_turno.Click += new System.EventHandler(this.btn_tipo_turno_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tipo Turno";
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            this.label7.Location = new System.Drawing.Point(6, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(618, 25);
            this.label7.TabIndex = 79;
            this.label7.Text = "Configuración de Camas en los Turnos";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txttipo_turno
            // 
            this.txttipo_turno.BackColor = System.Drawing.Color.White;
            this.txttipo_turno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttipo_turno.Location = new System.Drawing.Point(78, 42);
            this.txttipo_turno.Name = "txttipo_turno";
            this.txttipo_turno.Size = new System.Drawing.Size(160, 20);
            this.txttipo_turno.TabIndex = 3;
            this.txttipo_turno.Enter += new System.EventHandler(this.CambiarColor_TextEnter);
            this.txttipo_turno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttipo_turno_KeyPress);
            this.txttipo_turno.Leave += new System.EventHandler(this.CambiarBlanco_TextLeave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 2;
            // 
            // LblUsuario
            // 
            this.LblUsuario.BackColor = System.Drawing.Color.Silver;
            this.LblUsuario.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuario.Location = new System.Drawing.Point(2, 5);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(131, 25);
            this.LblUsuario.TabIndex = 224;
            this.LblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Image = ((System.Drawing.Image)(resources.GetObject("btn_limpiar.Image")));
            this.btn_limpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_limpiar.Location = new System.Drawing.Point(372, 5);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(98, 47);
            this.btn_limpiar.TabIndex = 223;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Image = global::Modificar_Configuracion_Turnos.Properties.Resources.save;
            this.btn_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_guardar.Location = new System.Drawing.Point(262, 5);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(104, 47);
            this.btn_guardar.TabIndex = 222;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // Ayuda
            // 
            this.Ayuda.AnchoColumnas = null;
            this.Ayuda.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Ayuda.Location = new System.Drawing.Point(498, -14);
            this.Ayuda.Multi_Seleccion = false;
            this.Ayuda.Name = "Ayuda";
            this.Ayuda.Nombre_BD_Datos = null;
            this.Ayuda.NombreColumnas = null;
            this.Ayuda.Package = null;
            this.Ayuda.Pass = null;
            this.Ayuda.Procedimiento = null;
            this.Ayuda.Size = new System.Drawing.Size(58, 66);
            this.Ayuda.TabIndex = 228;
            this.Ayuda.TipoBase = 0;
            this.Ayuda.TituloConsulta = null;
            this.Ayuda.User = null;
            this.Ayuda.UseWaitCursor = true;
            this.Ayuda.Visible = false;
            // 
            // grilla_turnos
            // 
            this.grilla_turnos.AllowUserToAddRows = false;
            this.grilla_turnos.AllowUserToDeleteRows = false;
            this.grilla_turnos.AllowUserToResizeColumns = false;
            this.grilla_turnos.AllowUserToResizeRows = false;
            this.grilla_turnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla_turnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.V,
            this.M,
            this.ID_TURNOS,
            this.COD_TURNOS,
            this.NOM_TURNOS,
            this.COD_HABITACIONS,
            this.NOM_HABITACIONS,
            this.COD_CAMAS,
            this.NUM_CAMAS,
            this.VIGENCIAS});
            this.grilla_turnos.Location = new System.Drawing.Point(7, 182);
            this.grilla_turnos.Name = "grilla_turnos";
            this.grilla_turnos.ReadOnly = true;
            this.grilla_turnos.RowHeadersVisible = false;
            this.grilla_turnos.Size = new System.Drawing.Size(631, 236);
            this.grilla_turnos.TabIndex = 229;
            this.grilla_turnos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grilla_turnos_CellContentDoubleClick);
            this.grilla_turnos.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.grilla_turnos_CellPainting);
            // 
            // V
            // 
            this.V.HeaderText = "V";
            this.V.Name = "V";
            this.V.ReadOnly = true;
            this.V.Width = 30;
            // 
            // M
            // 
            this.M.HeaderText = "M";
            this.M.Image = global::Modificar_Configuracion_Turnos.Properties.Resources.ver_ficha;
            this.M.Name = "M";
            this.M.ReadOnly = true;
            // 
            // ID_TURNOS
            // 
            this.ID_TURNOS.DataPropertyName = "ID_TURNOS";
            this.ID_TURNOS.HeaderText = "ID_TURNOS";
            this.ID_TURNOS.Name = "ID_TURNOS";
            this.ID_TURNOS.ReadOnly = true;
            this.ID_TURNOS.Width = 30;
            // 
            // COD_TURNOS
            // 
            this.COD_TURNOS.DataPropertyName = "COD_TURNOS";
            this.COD_TURNOS.HeaderText = "COD_TURNOS";
            this.COD_TURNOS.Name = "COD_TURNOS";
            this.COD_TURNOS.ReadOnly = true;
            // 
            // NOM_TURNOS
            // 
            this.NOM_TURNOS.DataPropertyName = "NOM_TURNOS";
            this.NOM_TURNOS.HeaderText = "TURNOS";
            this.NOM_TURNOS.Name = "NOM_TURNOS";
            this.NOM_TURNOS.ReadOnly = true;
            // 
            // COD_HABITACIONS
            // 
            this.COD_HABITACIONS.DataPropertyName = "COD_HABITACIONS";
            this.COD_HABITACIONS.HeaderText = "COD_HABITACION";
            this.COD_HABITACIONS.Name = "COD_HABITACIONS";
            this.COD_HABITACIONS.ReadOnly = true;
            this.COD_HABITACIONS.Width = 30;
            // 
            // NOM_HABITACIONS
            // 
            this.NOM_HABITACIONS.DataPropertyName = "NOM_HABITACIONS";
            this.NOM_HABITACIONS.HeaderText = "HABITACION";
            this.NOM_HABITACIONS.Name = "NOM_HABITACIONS";
            this.NOM_HABITACIONS.ReadOnly = true;
            this.NOM_HABITACIONS.Width = 250;
            // 
            // COD_CAMAS
            // 
            this.COD_CAMAS.DataPropertyName = "COD_CAMAS";
            this.COD_CAMAS.HeaderText = "COD_CAMAS";
            this.COD_CAMAS.Name = "COD_CAMAS";
            this.COD_CAMAS.ReadOnly = true;
            this.COD_CAMAS.Width = 30;
            // 
            // NUM_CAMAS
            // 
            this.NUM_CAMAS.DataPropertyName = "NUM_CAMAS";
            this.NUM_CAMAS.HeaderText = "NUM_CAMAS";
            this.NUM_CAMAS.Name = "NUM_CAMAS";
            this.NUM_CAMAS.ReadOnly = true;
            this.NUM_CAMAS.Width = 50;
            // 
            // VIGENCIAS
            // 
            this.VIGENCIAS.DataPropertyName = "VIGENCIA";
            this.VIGENCIAS.HeaderText = "VIGENCIAS";
            this.VIGENCIAS.Name = "VIGENCIAS";
            this.VIGENCIAS.ReadOnly = true;
            this.VIGENCIAS.Width = 50;
            // 
            // Frm_Modificar_Configuracion_Turnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 430);
            this.Controls.Add(this.grilla_turnos);
            this.Controls.Add(this.Ayuda);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LblUsuario);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_guardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Modificar_Configuracion_Turnos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Configuracion Turnos";
            this.Load += new System.EventHandler(this.Frm_Modificar_Configuracion_Turnos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_turnos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_num_cama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_num_habitacion;
        private System.Windows.Forms.TextBox txtnum_cama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnum_habitacion;
        private System.Windows.Forms.Button btn_tipo_turno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txttipo_turno;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_guardar;
        private AyudaSpreadNet.AyudaSprNet Ayuda;
        private System.Windows.Forms.DataGridView grilla_turnos;
        private System.Windows.Forms.DataGridViewImageColumn V;
        private System.Windows.Forms.DataGridViewImageColumn M;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_TURNOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_TURNOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOM_TURNOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_HABITACIONS;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOM_HABITACIONS;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_CAMAS;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUM_CAMAS;
        private System.Windows.Forms.DataGridViewTextBoxColumn VIGENCIAS;

    }
}

