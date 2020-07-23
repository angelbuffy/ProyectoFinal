namespace Farmacia_Final
{
    partial class Servicios_Realizados
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
            this.buttonRegistrarSR = new System.Windows.Forms.Button();
            this.buttonSalirSR = new System.Windows.Forms.Button();
            this.textBoxDNI_SR = new System.Windows.Forms.TextBox();
            this.textBoxNombres_SR = new System.Windows.Forms.TextBox();
            this.textBoxApellidos_SR = new System.Windows.Forms.TextBox();
            this.textBoxServicio_SR = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonRegistrarSR
            // 
            this.buttonRegistrarSR.Location = new System.Drawing.Point(207, 370);
            this.buttonRegistrarSR.Name = "buttonRegistrarSR";
            this.buttonRegistrarSR.Size = new System.Drawing.Size(75, 23);
            this.buttonRegistrarSR.TabIndex = 0;
            this.buttonRegistrarSR.Text = "Registrar";
            this.buttonRegistrarSR.UseVisualStyleBackColor = true;
            this.buttonRegistrarSR.Click += new System.EventHandler(this.buttonRegistrarSR_Click);
            // 
            // buttonSalirSR
            // 
            this.buttonSalirSR.Location = new System.Drawing.Point(519, 370);
            this.buttonSalirSR.Name = "buttonSalirSR";
            this.buttonSalirSR.Size = new System.Drawing.Size(75, 23);
            this.buttonSalirSR.TabIndex = 1;
            this.buttonSalirSR.Text = "Salir";
            this.buttonSalirSR.UseVisualStyleBackColor = true;
            this.buttonSalirSR.Click += new System.EventHandler(this.buttonSalirSR_Click);
            // 
            // textBoxDNI_SR
            // 
            this.textBoxDNI_SR.Location = new System.Drawing.Point(235, 86);
            this.textBoxDNI_SR.Name = "textBoxDNI_SR";
            this.textBoxDNI_SR.Size = new System.Drawing.Size(100, 20);
            this.textBoxDNI_SR.TabIndex = 2;
            // 
            // textBoxNombres_SR
            // 
            this.textBoxNombres_SR.Location = new System.Drawing.Point(235, 148);
            this.textBoxNombres_SR.Name = "textBoxNombres_SR";
            this.textBoxNombres_SR.Size = new System.Drawing.Size(290, 20);
            this.textBoxNombres_SR.TabIndex = 3;
            // 
            // textBoxApellidos_SR
            // 
            this.textBoxApellidos_SR.Location = new System.Drawing.Point(235, 216);
            this.textBoxApellidos_SR.Name = "textBoxApellidos_SR";
            this.textBoxApellidos_SR.Size = new System.Drawing.Size(290, 20);
            this.textBoxApellidos_SR.TabIndex = 4;
            // 
            // textBoxServicio_SR
            // 
            this.textBoxServicio_SR.Location = new System.Drawing.Point(235, 284);
            this.textBoxServicio_SR.Name = "textBoxServicio_SR";
            this.textBoxServicio_SR.Size = new System.Drawing.Size(290, 20);
            this.textBoxServicio_SR.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(258, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Servicios Realizados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "DNI:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nombres";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Apellidos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(95, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Servicio";
            // 
            // Servicios_Realizados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxServicio_SR);
            this.Controls.Add(this.textBoxApellidos_SR);
            this.Controls.Add(this.textBoxNombres_SR);
            this.Controls.Add(this.textBoxDNI_SR);
            this.Controls.Add(this.buttonSalirSR);
            this.Controls.Add(this.buttonRegistrarSR);
            this.Name = "Servicios_Realizados";
            this.Text = "Servicios_Realizados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRegistrarSR;
        private System.Windows.Forms.Button buttonSalirSR;
        private System.Windows.Forms.TextBox textBoxDNI_SR;
        private System.Windows.Forms.TextBox textBoxNombres_SR;
        private System.Windows.Forms.TextBox textBoxApellidos_SR;
        private System.Windows.Forms.TextBox textBoxServicio_SR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}