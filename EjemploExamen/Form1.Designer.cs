namespace EjemploExamen
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblNombre = new System.Windows.Forms.Label();
            this.ldlDestinatario = new System.Windows.Forms.Label();
            this.lblNota = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDestinatario = new System.Windows.Forms.TextBox();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.rbYa = new System.Windows.Forms.RadioButton();
            this.rbHoy = new System.Windows.Forms.RadioButton();
            this.rbMañana = new System.Windows.Forms.RadioButton();
            this.gbUrgencia = new System.Windows.Forms.GroupBox();
            this.gbTipo = new System.Windows.Forms.GroupBox();
            this.rbPublica = new System.Windows.Forms.RadioButton();
            this.rbPersonal = new System.Windows.Forms.RadioButton();
            this.rbEmpresa = new System.Windows.Forms.RadioButton();
            this.btnAlmacenar = new System.Windows.Forms.Button();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.gbUrgencia.SuspendLayout();
            this.gbTipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(25, 34);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(79, 17);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Tu &Nombre";
            // 
            // ldlDestinatario
            // 
            this.ldlDestinatario.AutoSize = true;
            this.ldlDestinatario.Location = new System.Drawing.Point(626, 32);
            this.ldlDestinatario.Name = "ldlDestinatario";
            this.ldlDestinatario.Size = new System.Drawing.Size(84, 17);
            this.ldlDestinatario.TabIndex = 2;
            this.ldlDestinatario.Text = "&Destinatario";
            // 
            // lblNota
            // 
            this.lblNota.AutoSize = true;
            this.lblNota.Location = new System.Drawing.Point(25, 109);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(38, 17);
            this.lblNota.TabIndex = 4;
            this.lblNota.Text = "&Nota";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(110, 34);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(134, 24);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.Tag = "LightPink";
            this.txtNombre.MouseEnter += new System.EventHandler(this.MouseEnter);
            this.txtNombre.MouseLeave += new System.EventHandler(this.MouseLeave);
            // 
            // txtDestinatario
            // 
            this.txtDestinatario.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDestinatario.Location = new System.Drawing.Point(727, 29);
            this.txtDestinatario.Name = "txtDestinatario";
            this.txtDestinatario.Size = new System.Drawing.Size(128, 24);
            this.txtDestinatario.TabIndex = 3;
            this.txtDestinatario.Tag = "LightPink";
            this.txtDestinatario.MouseEnter += new System.EventHandler(this.MouseEnter);
            this.txtDestinatario.MouseLeave += new System.EventHandler(this.MouseLeave);
            // 
            // txtNota
            // 
            this.txtNota.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNota.Location = new System.Drawing.Point(69, 75);
            this.txtNota.Multiline = true;
            this.txtNota.Name = "txtNota";
            this.txtNota.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNota.Size = new System.Drawing.Size(786, 122);
            this.txtNota.TabIndex = 5;
            this.txtNota.Tag = "Aquamarine";
            this.txtNota.Enter += new System.EventHandler(this.txtNota_Enter);
            this.txtNota.MouseEnter += new System.EventHandler(this.MouseEnter);
            this.txtNota.MouseLeave += new System.EventHandler(this.MouseLeave);
            // 
            // rbYa
            // 
            this.rbYa.AutoSize = true;
            this.rbYa.Location = new System.Drawing.Point(6, 34);
            this.rbYa.Name = "rbYa";
            this.rbYa.Size = new System.Drawing.Size(46, 21);
            this.rbYa.TabIndex = 6;
            this.rbYa.TabStop = true;
            this.rbYa.Text = "Ya";
            this.rbYa.UseVisualStyleBackColor = true;
            this.rbYa.CheckedChanged += new System.EventHandler(this.CheckedChangedUrgencia);
            // 
            // rbHoy
            // 
            this.rbHoy.AutoSize = true;
            this.rbHoy.Location = new System.Drawing.Point(71, 34);
            this.rbHoy.Name = "rbHoy";
            this.rbHoy.Size = new System.Drawing.Size(54, 21);
            this.rbHoy.TabIndex = 7;
            this.rbHoy.TabStop = true;
            this.rbHoy.Text = "Hoy";
            this.rbHoy.UseVisualStyleBackColor = true;
            this.rbHoy.CheckedChanged += new System.EventHandler(this.CheckedChangedUrgencia);
            // 
            // rbMañana
            // 
            this.rbMañana.AutoSize = true;
            this.rbMañana.Location = new System.Drawing.Point(131, 34);
            this.rbMañana.Name = "rbMañana";
            this.rbMañana.Size = new System.Drawing.Size(80, 21);
            this.rbMañana.TabIndex = 8;
            this.rbMañana.TabStop = true;
            this.rbMañana.Text = "Mañana";
            this.rbMañana.UseVisualStyleBackColor = true;
            this.rbMañana.CheckedChanged += new System.EventHandler(this.CheckedChangedUrgencia);
            // 
            // gbUrgencia
            // 
            this.gbUrgencia.Controls.Add(this.rbYa);
            this.gbUrgencia.Controls.Add(this.rbMañana);
            this.gbUrgencia.Controls.Add(this.rbHoy);
            this.gbUrgencia.Location = new System.Drawing.Point(28, 203);
            this.gbUrgencia.Name = "gbUrgencia";
            this.gbUrgencia.Size = new System.Drawing.Size(240, 77);
            this.gbUrgencia.TabIndex = 6;
            this.gbUrgencia.TabStop = false;
            this.gbUrgencia.Text = "Urgencia";
            // 
            // gbTipo
            // 
            this.gbTipo.Controls.Add(this.rbPublica);
            this.gbTipo.Controls.Add(this.rbPersonal);
            this.gbTipo.Controls.Add(this.rbEmpresa);
            this.gbTipo.Location = new System.Drawing.Point(577, 203);
            this.gbTipo.Name = "gbTipo";
            this.gbTipo.Size = new System.Drawing.Size(278, 77);
            this.gbTipo.TabIndex = 7;
            this.gbTipo.TabStop = false;
            this.gbTipo.Text = "Tipo";
            // 
            // rbPublica
            // 
            this.rbPublica.AutoSize = true;
            this.rbPublica.Location = new System.Drawing.Point(6, 34);
            this.rbPublica.Name = "rbPublica";
            this.rbPublica.Size = new System.Drawing.Size(75, 21);
            this.rbPublica.TabIndex = 6;
            this.rbPublica.TabStop = true;
            this.rbPublica.Text = "Publica";
            this.rbPublica.UseVisualStyleBackColor = true;
            this.rbPublica.CheckedChanged += new System.EventHandler(this.CheckedChangedTipo);
            // 
            // rbPersonal
            // 
            this.rbPersonal.AutoSize = true;
            this.rbPersonal.Location = new System.Drawing.Point(178, 34);
            this.rbPersonal.Name = "rbPersonal";
            this.rbPersonal.Size = new System.Drawing.Size(85, 21);
            this.rbPersonal.TabIndex = 8;
            this.rbPersonal.TabStop = true;
            this.rbPersonal.Text = "Personal";
            this.rbPersonal.UseVisualStyleBackColor = true;
            this.rbPersonal.CheckedChanged += new System.EventHandler(this.CheckedChangedTipo);
            // 
            // rbEmpresa
            // 
            this.rbEmpresa.AutoSize = true;
            this.rbEmpresa.Location = new System.Drawing.Point(87, 34);
            this.rbEmpresa.Name = "rbEmpresa";
            this.rbEmpresa.Size = new System.Drawing.Size(85, 21);
            this.rbEmpresa.TabIndex = 7;
            this.rbEmpresa.TabStop = true;
            this.rbEmpresa.Text = "Empresa";
            this.rbEmpresa.UseVisualStyleBackColor = true;
            this.rbEmpresa.CheckedChanged += new System.EventHandler(this.CheckedChangedTipo);
            // 
            // btnAlmacenar
            // 
            this.btnAlmacenar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlmacenar.Location = new System.Drawing.Point(181, 286);
            this.btnAlmacenar.Name = "btnAlmacenar";
            this.btnAlmacenar.Size = new System.Drawing.Size(129, 62);
            this.btnAlmacenar.TabIndex = 8;
            this.btnAlmacenar.Text = "&Almacenar";
            this.btnAlmacenar.UseVisualStyleBackColor = true;
            this.btnAlmacenar.Click += new System.EventHandler(this.btnAlmacenar_Click);
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVisualizar.Location = new System.Drawing.Point(316, 286);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(129, 62);
            this.btnVisualizar.TabIndex = 9;
            this.btnVisualizar.Text = "&Visualizar";
            this.btnVisualizar.UseVisualStyleBackColor = true;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrar.Location = new System.Drawing.Point(451, 286);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(129, 62);
            this.btnBorrar.TabIndex = 10;
            this.btnBorrar.TabStop = false;
            this.btnBorrar.Text = "&Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Location = new System.Drawing.Point(586, 286);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(129, 62);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.TabStop = false;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(31, 375);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 17);
            this.lblError.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 416);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnVisualizar);
            this.Controls.Add(this.btnAlmacenar);
            this.Controls.Add(this.gbTipo);
            this.Controls.Add(this.gbUrgencia);
            this.Controls.Add(this.txtNota);
            this.Controls.Add(this.txtDestinatario);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNota);
            this.Controls.Add(this.ldlDestinatario);
            this.Controls.Add(this.lblNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Gestor de Notas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbUrgencia.ResumeLayout(false);
            this.gbUrgencia.PerformLayout();
            this.gbTipo.ResumeLayout(false);
            this.gbTipo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label ldlDestinatario;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDestinatario;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.RadioButton rbYa;
        private System.Windows.Forms.RadioButton rbHoy;
        private System.Windows.Forms.RadioButton rbMañana;
        private System.Windows.Forms.GroupBox gbUrgencia;
        private System.Windows.Forms.GroupBox gbTipo;
        private System.Windows.Forms.RadioButton rbPublica;
        private System.Windows.Forms.RadioButton rbPersonal;
        private System.Windows.Forms.RadioButton rbEmpresa;
        private System.Windows.Forms.Button btnAlmacenar;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblError;
    }
}

