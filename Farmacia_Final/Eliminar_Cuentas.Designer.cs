namespace Farmacia_Final
{
    partial class Eliminar_Cuentas
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
            this.buttonEliminar_cuenta = new System.Windows.Forms.Button();
            this.Salir_Elimnar_Cuentas = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnMostrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textUsuario = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eliminar cuentas";
            // 
            // buttonEliminar_cuenta
            // 
            this.buttonEliminar_cuenta.Location = new System.Drawing.Point(135, 481);
            this.buttonEliminar_cuenta.Name = "buttonEliminar_cuenta";
            this.buttonEliminar_cuenta.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminar_cuenta.TabIndex = 3;
            this.buttonEliminar_cuenta.Text = "Eliminar";
            this.buttonEliminar_cuenta.UseVisualStyleBackColor = true;
            this.buttonEliminar_cuenta.Click += new System.EventHandler(this.buttonEliminar_cuenta_Click);
            // 
            // Salir_Elimnar_Cuentas
            // 
            this.Salir_Elimnar_Cuentas.Location = new System.Drawing.Point(333, 481);
            this.Salir_Elimnar_Cuentas.Name = "Salir_Elimnar_Cuentas";
            this.Salir_Elimnar_Cuentas.Size = new System.Drawing.Size(75, 23);
            this.Salir_Elimnar_Cuentas.TabIndex = 4;
            this.Salir_Elimnar_Cuentas.Text = "Salir";
            this.Salir_Elimnar_Cuentas.UseVisualStyleBackColor = true;
            this.Salir_Elimnar_Cuentas.Click += new System.EventHandler(this.Salir_Elimnar_Cuentas_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(484, 245);
            this.dataGridView1.TabIndex = 5;
            // 
            // BtnMostrar
            // 
            this.BtnMostrar.Location = new System.Drawing.Point(441, 350);
            this.BtnMostrar.Name = "BtnMostrar";
            this.BtnMostrar.Size = new System.Drawing.Size(75, 23);
            this.BtnMostrar.TabIndex = 6;
            this.BtnMostrar.Text = "Actualizar";
            this.BtnMostrar.UseVisualStyleBackColor = true;
            this.BtnMostrar.Click += new System.EventHandler(this.BtnMostrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 408);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Usuario";
            // 
            // textUsuario
            // 
            this.textUsuario.Location = new System.Drawing.Point(110, 405);
            this.textUsuario.Name = "textUsuario";
            this.textUsuario.Size = new System.Drawing.Size(100, 20);
            this.textUsuario.TabIndex = 8;
            this.textUsuario.TextChanged += new System.EventHandler(this.textUsuario_TextChanged);
            // 
            // Eliminar_Cuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 532);
            this.Controls.Add(this.textUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnMostrar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Salir_Elimnar_Cuentas);
            this.Controls.Add(this.buttonEliminar_cuenta);
            this.Controls.Add(this.label1);
            this.Name = "Eliminar_Cuentas";
            this.Text = "Eliminar_Cuentas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonEliminar_cuenta;
        private System.Windows.Forms.Button Salir_Elimnar_Cuentas;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnMostrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textUsuario;
    }
}