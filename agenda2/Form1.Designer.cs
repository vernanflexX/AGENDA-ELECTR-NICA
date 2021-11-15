namespace agenda2
{
    partial class AGENDA
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
            this.eliminar = new System.Windows.Forms.Button();
            this.agregar = new System.Windows.Forms.Button();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textApellido = new System.Windows.Forms.TextBox();
            this.textDireccion = new System.Windows.Forms.TextBox();
            this.textMovil = new System.Windows.Forms.TextBox();
            this.textTelefono = new System.Windows.Forms.TextBox();
            this.textCorreo = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.Label();
            this.apellido = new System.Windows.Forms.Label();
            this.fechanacimiento = new System.Windows.Forms.Label();
            this.direccion = new System.Windows.Forms.Label();
            this.genero = new System.Windows.Forms.Label();
            this.estadocivil = new System.Windows.Forms.Label();
            this.movil = new System.Windows.Forms.Label();
            this.telefono = new System.Windows.Forms.Label();
            this.correo = new System.Windows.Forms.Label();
            this.IDPersona = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.modificar = new System.Windows.Forms.Button();
            this.buscar = new System.Windows.Forms.Button();
            this.limpiar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBuscar = new System.Windows.Forms.TextBox();
            this.textFecha = new System.Windows.Forms.DateTimePicker();
            this.textGenero = new System.Windows.Forms.CheckedListBox();
            this.textEstadoc = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // eliminar
            // 
            this.eliminar.Location = new System.Drawing.Point(216, 381);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(120, 50);
            this.eliminar.TabIndex = 0;
            this.eliminar.Text = "ELIMINAR";
            this.eliminar.UseVisualStyleBackColor = true;
            this.eliminar.Click += new System.EventHandler(this.eliminar_Click);
            // 
            // agregar
            // 
            this.agregar.Location = new System.Drawing.Point(51, 381);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(120, 50);
            this.agregar.TabIndex = 1;
            this.agregar.Text = "AGREGAR";
            this.agregar.UseVisualStyleBackColor = true;
            this.agregar.Click += new System.EventHandler(this.agregar_Click);
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(40, 72);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(154, 26);
            this.textNombre.TabIndex = 2;
            this.textNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textApellido
            // 
            this.textApellido.Location = new System.Drawing.Point(40, 141);
            this.textApellido.Name = "textApellido";
            this.textApellido.Size = new System.Drawing.Size(154, 26);
            this.textApellido.TabIndex = 3;
            this.textApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textDireccion
            // 
            this.textDireccion.Location = new System.Drawing.Point(352, 72);
            this.textDireccion.Name = "textDireccion";
            this.textDireccion.Size = new System.Drawing.Size(154, 26);
            this.textDireccion.TabIndex = 4;
            this.textDireccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textMovil
            // 
            this.textMovil.Location = new System.Drawing.Point(678, 72);
            this.textMovil.Name = "textMovil";
            this.textMovil.Size = new System.Drawing.Size(154, 26);
            this.textMovil.TabIndex = 8;
            this.textMovil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textTelefono
            // 
            this.textTelefono.Location = new System.Drawing.Point(678, 141);
            this.textTelefono.Name = "textTelefono";
            this.textTelefono.Size = new System.Drawing.Size(154, 26);
            this.textTelefono.TabIndex = 9;
            this.textTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textCorreo
            // 
            this.textCorreo.Location = new System.Drawing.Point(678, 219);
            this.textCorreo.Name = "textCorreo";
            this.textCorreo.Size = new System.Drawing.Size(154, 26);
            this.textCorreo.TabIndex = 10;
            this.textCorreo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Location = new System.Drawing.Point(73, 38);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(79, 20);
            this.nombre.TabIndex = 11;
            this.nombre.Text = "NOMBRE";
            // 
            // apellido
            // 
            this.apellido.AutoSize = true;
            this.apellido.Location = new System.Drawing.Point(64, 111);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(88, 20);
            this.apellido.TabIndex = 12;
            this.apellido.Text = "APELLIDO";
            // 
            // fechanacimiento
            // 
            this.fechanacimiento.AutoSize = true;
            this.fechanacimiento.Location = new System.Drawing.Point(25, 186);
            this.fechanacimiento.Name = "fechanacimiento";
            this.fechanacimiento.Size = new System.Drawing.Size(194, 20);
            this.fechanacimiento.TabIndex = 13;
            this.fechanacimiento.Text = "FECHA DE NACIMIENTO";
            // 
            // direccion
            // 
            this.direccion.AutoSize = true;
            this.direccion.Location = new System.Drawing.Point(381, 38);
            this.direccion.Name = "direccion";
            this.direccion.Size = new System.Drawing.Size(99, 20);
            this.direccion.TabIndex = 14;
            this.direccion.Text = "DIRECCION";
            // 
            // genero
            // 
            this.genero.AutoSize = true;
            this.genero.Location = new System.Drawing.Point(390, 111);
            this.genero.Name = "genero";
            this.genero.Size = new System.Drawing.Size(79, 20);
            this.genero.TabIndex = 15;
            this.genero.Text = "GENERO";
            // 
            // estadocivil
            // 
            this.estadocivil.AutoSize = true;
            this.estadocivil.Location = new System.Drawing.Point(376, 210);
            this.estadocivil.Name = "estadocivil";
            this.estadocivil.Size = new System.Drawing.Size(120, 20);
            this.estadocivil.TabIndex = 16;
            this.estadocivil.Text = "ESTADO CIVIL";
            // 
            // movil
            // 
            this.movil.AutoSize = true;
            this.movil.Location = new System.Drawing.Point(716, 37);
            this.movil.Name = "movil";
            this.movil.Size = new System.Drawing.Size(59, 20);
            this.movil.TabIndex = 17;
            this.movil.Text = "MOVIL";
            // 
            // telefono
            // 
            this.telefono.AutoSize = true;
            this.telefono.Location = new System.Drawing.Point(699, 115);
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(94, 20);
            this.telefono.TabIndex = 18;
            this.telefono.Text = "TELEFONO";
            // 
            // correo
            // 
            this.correo.AutoSize = true;
            this.correo.Location = new System.Drawing.Point(657, 186);
            this.correo.Name = "correo";
            this.correo.Size = new System.Drawing.Size(197, 20);
            this.correo.TabIndex = 19;
            this.correo.Text = "CORREO ELECTRÓNICO";
            // 
            // IDPersona
            // 
            this.IDPersona.AutoSize = true;
            this.IDPersona.Location = new System.Drawing.Point(73, 263);
            this.IDPersona.Name = "IDPersona";
            this.IDPersona.Size = new System.Drawing.Size(85, 20);
            this.IDPersona.TabIndex = 20;
            this.IDPersona.Text = "IDPersona";
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(40, 297);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(154, 26);
            this.textID.TabIndex = 21;
            this.textID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // modificar
            // 
            this.modificar.Location = new System.Drawing.Point(376, 381);
            this.modificar.Name = "modificar";
            this.modificar.Size = new System.Drawing.Size(120, 50);
            this.modificar.TabIndex = 22;
            this.modificar.Text = "MODIFICAR";
            this.modificar.UseVisualStyleBackColor = true;
            this.modificar.Click += new System.EventHandler(this.modificar_Click);
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(545, 381);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(120, 50);
            this.buscar.TabIndex = 23;
            this.buscar.Text = "BUSCAR";
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // limpiar
            // 
            this.limpiar.Location = new System.Drawing.Point(712, 381);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(120, 50);
            this.limpiar.TabIndex = 24;
            this.limpiar.Text = "REFRESCAR";
            this.limpiar.UseVisualStyleBackColor = true;
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(390, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(470, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "INTRODUZCA EL ID DE LA PERSONA QUE QUIERE BUSCAR";
            // 
            // textBuscar
            // 
            this.textBuscar.Location = new System.Drawing.Point(557, 311);
            this.textBuscar.Name = "textBuscar";
            this.textBuscar.Size = new System.Drawing.Size(196, 26);
            this.textBuscar.TabIndex = 26;
            this.textBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textFecha
            // 
            this.textFecha.Location = new System.Drawing.Point(27, 219);
            this.textFecha.Name = "textFecha";
            this.textFecha.Size = new System.Drawing.Size(192, 26);
            this.textFecha.TabIndex = 27;
            // 
            // textGenero
            // 
            this.textGenero.FormattingEnabled = true;
            this.textGenero.Items.AddRange(new object[] {
            "Masculino",
            "Femenino ",
            "Indefinido"});
            this.textGenero.Location = new System.Drawing.Point(380, 133);
            this.textGenero.Name = "textGenero";
            this.textGenero.Size = new System.Drawing.Size(112, 73);
            this.textGenero.TabIndex = 29;
            // 
            // textEstadoc
            // 
            this.textEstadoc.FormattingEnabled = true;
            this.textEstadoc.Items.AddRange(new object[] {
            "Soltero",
            "Casado"});
            this.textEstadoc.Location = new System.Drawing.Point(385, 233);
            this.textEstadoc.Name = "textEstadoc";
            this.textEstadoc.Size = new System.Drawing.Size(101, 50);
            this.textEstadoc.TabIndex = 30;
            // 
            // AGENDA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(894, 493);
            this.Controls.Add(this.textEstadoc);
            this.Controls.Add(this.textGenero);
            this.Controls.Add(this.textFecha);
            this.Controls.Add(this.textBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.limpiar);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.modificar);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.IDPersona);
            this.Controls.Add(this.correo);
            this.Controls.Add(this.telefono);
            this.Controls.Add(this.movil);
            this.Controls.Add(this.estadocivil);
            this.Controls.Add(this.genero);
            this.Controls.Add(this.direccion);
            this.Controls.Add(this.fechanacimiento);
            this.Controls.Add(this.apellido);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.textCorreo);
            this.Controls.Add(this.textTelefono);
            this.Controls.Add(this.textMovil);
            this.Controls.Add(this.textDireccion);
            this.Controls.Add(this.textApellido);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.agregar);
            this.Controls.Add(this.eliminar);
            this.Name = "AGENDA";
            this.Text = "AGENDA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button eliminar;
        private System.Windows.Forms.Button agregar;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textApellido;
        private System.Windows.Forms.TextBox textDireccion;
        private System.Windows.Forms.TextBox textMovil;
        private System.Windows.Forms.TextBox textTelefono;
        private System.Windows.Forms.TextBox textCorreo;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.Label apellido;
        private System.Windows.Forms.Label fechanacimiento;
        private System.Windows.Forms.Label direccion;
        private System.Windows.Forms.Label genero;
        private System.Windows.Forms.Label estadocivil;
        private System.Windows.Forms.Label movil;
        private System.Windows.Forms.Label telefono;
        private System.Windows.Forms.Label correo;
        private System.Windows.Forms.Label IDPersona;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Button modificar;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBuscar;
        private System.Windows.Forms.DateTimePicker textFecha;
        private System.Windows.Forms.CheckedListBox textGenero;
        private System.Windows.Forms.CheckedListBox textEstadoc;
    }
}

