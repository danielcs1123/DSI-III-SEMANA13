namespace Pedidos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nombres = new System.Windows.Forms.TextBox();
            this.txt_apellidos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rbtn_masculino = new System.Windows.Forms.RadioButton();
            this.rbtn_femenino = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_documento = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.dgv_cliente = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cliente)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro de cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(13, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID:";
            // 
            // txt_id
            // 
            this.txt_id.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(16, 113);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(73, 20);
            this.txt_id.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(92, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombres:";
            // 
            // txt_nombres
            // 
            this.txt_nombres.Enabled = false;
            this.txt_nombres.Location = new System.Drawing.Point(95, 113);
            this.txt_nombres.Name = "txt_nombres";
            this.txt_nombres.Size = new System.Drawing.Size(304, 20);
            this.txt_nombres.TabIndex = 4;
            // 
            // txt_apellidos
            // 
            this.txt_apellidos.Enabled = false;
            this.txt_apellidos.Location = new System.Drawing.Point(405, 113);
            this.txt_apellidos.Name = "txt_apellidos";
            this.txt_apellidos.Size = new System.Drawing.Size(304, 20);
            this.txt_apellidos.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(402, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Apellidos:";
            // 
            // rbtn_masculino
            // 
            this.rbtn_masculino.AutoSize = true;
            this.rbtn_masculino.Checked = true;
            this.rbtn_masculino.Enabled = false;
            this.rbtn_masculino.Location = new System.Drawing.Point(744, 114);
            this.rbtn_masculino.Name = "rbtn_masculino";
            this.rbtn_masculino.Size = new System.Drawing.Size(34, 17);
            this.rbtn_masculino.TabIndex = 7;
            this.rbtn_masculino.TabStop = true;
            this.rbtn_masculino.Text = "M";
            this.rbtn_masculino.UseVisualStyleBackColor = true;
            // 
            // rbtn_femenino
            // 
            this.rbtn_femenino.AutoSize = true;
            this.rbtn_femenino.Enabled = false;
            this.rbtn_femenino.Location = new System.Drawing.Point(784, 114);
            this.rbtn_femenino.Name = "rbtn_femenino";
            this.rbtn_femenino.Size = new System.Drawing.Size(31, 17);
            this.rbtn_femenino.TabIndex = 8;
            this.rbtn_femenino.Text = "F";
            this.rbtn_femenino.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(741, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Sexo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(13, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Fecha de nacimiento:";
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.Enabled = false;
            this.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha.Location = new System.Drawing.Point(16, 171);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(145, 20);
            this.dtp_fecha.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(167, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Tipo de documento:";
            // 
            // cmb_documento
            // 
            this.cmb_documento.Enabled = false;
            this.cmb_documento.FormattingEnabled = true;
            this.cmb_documento.Location = new System.Drawing.Point(167, 171);
            this.cmb_documento.Name = "cmb_documento";
            this.cmb_documento.Size = new System.Drawing.Size(240, 21);
            this.cmb_documento.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(410, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "N° Documento:";
            // 
            // txt_numero
            // 
            this.txt_numero.Enabled = false;
            this.txt_numero.Location = new System.Drawing.Point(413, 171);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(121, 20);
            this.txt_numero.TabIndex = 15;
            // 
            // txt_direccion
            // 
            this.txt_direccion.Enabled = false;
            this.txt_direccion.Location = new System.Drawing.Point(540, 171);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(347, 20);
            this.txt_direccion.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(537, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Dirección:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(13, 207);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 17);
            this.label10.TabIndex = 18;
            this.label10.Text = "Teléfono:";
            // 
            // txt_telefono
            // 
            this.txt_telefono.Enabled = false;
            this.txt_telefono.Location = new System.Drawing.Point(16, 227);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(145, 20);
            this.txt_telefono.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Location = new System.Drawing.Point(167, 207);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 17);
            this.label11.TabIndex = 20;
            this.label11.Text = "Email:";
            // 
            // txt_email
            // 
            this.txt_email.Enabled = false;
            this.txt_email.Location = new System.Drawing.Point(167, 227);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(367, 20);
            this.txt_email.TabIndex = 21;
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nuevo.ForeColor = System.Drawing.Color.White;
            this.btn_nuevo.Location = new System.Drawing.Point(617, 12);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(86, 43);
            this.btn_nuevo.TabIndex = 22;
            this.btn_nuevo.Text = "Nuevo";
            this.btn_nuevo.UseVisualStyleBackColor = false;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.Green;
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.Color.White;
            this.btn_guardar.Location = new System.Drawing.Point(709, 12);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(86, 43);
            this.btn_guardar.TabIndex = 23;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.ForeColor = System.Drawing.Color.White;
            this.btn_salir.Location = new System.Drawing.Point(801, 11);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(86, 43);
            this.btn_salir.TabIndex = 24;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = false;
            // 
            // dgv_cliente
            // 
            this.dgv_cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cliente.Location = new System.Drawing.Point(16, 264);
            this.dgv_cliente.Name = "dgv_cliente";
            this.dgv_cliente.Size = new System.Drawing.Size(871, 203);
            this.dgv_cliente.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(901, 479);
            this.Controls.Add(this.dgv_cliente);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_nuevo);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_direccion);
            this.Controls.Add(this.txt_numero);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmb_documento);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtp_fecha);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rbtn_femenino);
            this.Controls.Add(this.rbtn_masculino);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_apellidos);
            this.Controls.Add(this.txt_nombres);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nombres;
        private System.Windows.Forms.TextBox txt_apellidos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbtn_masculino;
        private System.Windows.Forms.RadioButton rbtn_femenino;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtp_fecha;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_documento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.DataGridView dgv_cliente;
    }
}

