namespace Farmacia_Final
{
    partial class Mostrar_Stocks
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonSalir_MS = new System.Windows.Forms.Button();
            this.buttonActualizar_MS = new System.Windows.Forms.Button();
            this.buttonBuscar_MS = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNombre_Producto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(66, 142);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(658, 259);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonSalir_MS
            // 
            this.buttonSalir_MS.Location = new System.Drawing.Point(646, 415);
            this.buttonSalir_MS.Name = "buttonSalir_MS";
            this.buttonSalir_MS.Size = new System.Drawing.Size(75, 23);
            this.buttonSalir_MS.TabIndex = 1;
            this.buttonSalir_MS.Text = "Salir";
            this.buttonSalir_MS.UseVisualStyleBackColor = true;
            this.buttonSalir_MS.Click += new System.EventHandler(this.buttonSalir_MS_Click);
            // 
            // buttonActualizar_MS
            // 
            this.buttonActualizar_MS.Location = new System.Drawing.Point(646, 90);
            this.buttonActualizar_MS.Name = "buttonActualizar_MS";
            this.buttonActualizar_MS.Size = new System.Drawing.Size(75, 23);
            this.buttonActualizar_MS.TabIndex = 2;
            this.buttonActualizar_MS.Text = "Actualizar";
            this.buttonActualizar_MS.UseVisualStyleBackColor = true;
            this.buttonActualizar_MS.Click += new System.EventHandler(this.buttonActualizar_MS_Click);
            // 
            // buttonBuscar_MS
            // 
            this.buttonBuscar_MS.Location = new System.Drawing.Point(352, 90);
            this.buttonBuscar_MS.Name = "buttonBuscar_MS";
            this.buttonBuscar_MS.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar_MS.TabIndex = 3;
            this.buttonBuscar_MS.Text = "Buscar";
            this.buttonBuscar_MS.UseVisualStyleBackColor = true;
            this.buttonBuscar_MS.Click += new System.EventHandler(this.buttonBuscar_MS_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre del producto:";
            // 
            // textBoxNombre_Producto
            // 
            this.textBoxNombre_Producto.Location = new System.Drawing.Point(194, 92);
            this.textBoxNombre_Producto.Name = "textBoxNombre_Producto";
            this.textBoxNombre_Producto.Size = new System.Drawing.Size(126, 20);
            this.textBoxNombre_Producto.TabIndex = 5;
            // 
            // Mostrar_Stocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxNombre_Producto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBuscar_MS);
            this.Controls.Add(this.buttonActualizar_MS);
            this.Controls.Add(this.buttonSalir_MS);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Mostrar_Stocks";
            this.Text = "Mostrar_Stocks";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonSalir_MS;
        private System.Windows.Forms.Button buttonActualizar_MS;
        private System.Windows.Forms.Button buttonBuscar_MS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNombre_Producto;
    }
}