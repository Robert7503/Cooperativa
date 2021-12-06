
namespace Cooperativa.Vistas
{
    partial class TransaccionesClientesView
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtClienteIdT = new System.Windows.Forms.TextBox();
            this.txtTransaccionT = new System.Windows.Forms.TextBox();
            this.txtMonedaT = new System.Windows.Forms.TextBox();
            this.txtCantidadT = new System.Windows.Forms.TextBox();
            this.btnRealizarT = new System.Windows.Forms.Button();
            this.btnNuevoT = new System.Windows.Forms.Button();
            this.btnSalirT = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TransacciondataGridView1 = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.TransacciondataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Transaccion:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Moneda:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cantidad:";
            // 
            // txtClienteIdT
            // 
            this.txtClienteIdT.Location = new System.Drawing.Point(167, 91);
            this.txtClienteIdT.Name = "txtClienteIdT";
            this.txtClienteIdT.Size = new System.Drawing.Size(267, 26);
            this.txtClienteIdT.TabIndex = 1;
            // 
            // txtTransaccionT
            // 
            this.txtTransaccionT.Location = new System.Drawing.Point(167, 147);
            this.txtTransaccionT.Name = "txtTransaccionT";
            this.txtTransaccionT.Size = new System.Drawing.Size(267, 26);
            this.txtTransaccionT.TabIndex = 1;
            // 
            // txtMonedaT
            // 
            this.txtMonedaT.Location = new System.Drawing.Point(167, 208);
            this.txtMonedaT.Name = "txtMonedaT";
            this.txtMonedaT.Size = new System.Drawing.Size(267, 26);
            this.txtMonedaT.TabIndex = 1;
            // 
            // txtCantidadT
            // 
            this.txtCantidadT.Location = new System.Drawing.Point(167, 263);
            this.txtCantidadT.Name = "txtCantidadT";
            this.txtCantidadT.Size = new System.Drawing.Size(267, 26);
            this.txtCantidadT.TabIndex = 1;
            // 
            // btnRealizarT
            // 
            this.btnRealizarT.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnRealizarT.Location = new System.Drawing.Point(496, 94);
            this.btnRealizarT.Name = "btnRealizarT";
            this.btnRealizarT.Size = new System.Drawing.Size(133, 37);
            this.btnRealizarT.TabIndex = 2;
            this.btnRealizarT.Text = "Realizar";
            this.btnRealizarT.UseVisualStyleBackColor = false;
            // 
            // btnNuevoT
            // 
            this.btnNuevoT.BackColor = System.Drawing.Color.SpringGreen;
            this.btnNuevoT.Enabled = false;
            this.btnNuevoT.Location = new System.Drawing.Point(496, 170);
            this.btnNuevoT.Name = "btnNuevoT";
            this.btnNuevoT.Size = new System.Drawing.Size(133, 37);
            this.btnNuevoT.TabIndex = 2;
            this.btnNuevoT.Text = "Nuevo";
            this.btnNuevoT.UseVisualStyleBackColor = false;
            // 
            // btnSalirT
            // 
            this.btnSalirT.BackColor = System.Drawing.Color.Salmon;
            this.btnSalirT.Location = new System.Drawing.Point(496, 247);
            this.btnSalirT.Name = "btnSalirT";
            this.btnSalirT.Size = new System.Drawing.Size(133, 37);
            this.btnSalirT.TabIndex = 2;
            this.btnSalirT.Text = "Salir";
            this.btnSalirT.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(214, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Transacciones HN";
            // 
            // TransacciondataGridView1
            // 
            this.TransacciondataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TransacciondataGridView1.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.TransacciondataGridView1.Location = new System.Drawing.Point(4, 328);
            this.TransacciondataGridView1.Name = "TransacciondataGridView1";
            this.TransacciondataGridView1.Size = new System.Drawing.Size(697, 172);
            this.TransacciondataGridView1.TabIndex = 4;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // TransaccionesClientesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(703, 504);
            this.Controls.Add(this.TransacciondataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSalirT);
            this.Controls.Add(this.btnNuevoT);
            this.Controls.Add(this.btnRealizarT);
            this.Controls.Add(this.txtCantidadT);
            this.Controls.Add(this.txtMonedaT);
            this.Controls.Add(this.txtTransaccionT);
            this.Controls.Add(this.txtClienteIdT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "TransaccionesClientesView";
            this.Text = "TransaccionesClientes";
            ((System.ComponentModel.ISupportInitialize)(this.TransacciondataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.DataGridView TransacciondataGridView1;
        public System.Windows.Forms.TextBox txtClienteIdT;
        public System.Windows.Forms.TextBox txtTransaccionT;
        public System.Windows.Forms.TextBox txtMonedaT;
        public System.Windows.Forms.TextBox txtCantidadT;
        public System.Windows.Forms.Button btnRealizarT;
        public System.Windows.Forms.Button btnNuevoT;
        public System.Windows.Forms.Button btnSalirT;
        public System.Windows.Forms.ErrorProvider errorProvider1;
    }
}