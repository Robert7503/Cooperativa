
namespace Cooperativa.Vistas
{
    partial class UsuariosView
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
            this.lblClaveUsuario = new System.Windows.Forms.Label();
            this.txtUsuarioID = new System.Windows.Forms.TextBox();
            this.txtUsuarioNombre = new System.Windows.Forms.TextBox();
            this.txtUsuarioEMAIL = new System.Windows.Forms.TextBox();
            this.txtUsuarioCLAVE = new System.Windows.Forms.TextBox();
            this.UsuariodataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnNuevoUsuario = new System.Windows.Forms.Button();
            this.btnGuardarUsuario = new System.Windows.Forms.Button();
            this.btnEliminarUsuario = new System.Windows.Forms.Button();
            this.cboxAdmin = new System.Windows.Forms.CheckBox();
            this.btnUsuarioModificar = new System.Windows.Forms.Button();
            this.btnUsuarioCancelar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.UsuariodataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(367, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Email:";
            // 
            // lblClaveUsuario
            // 
            this.lblClaveUsuario.AutoSize = true;
            this.lblClaveUsuario.Location = new System.Drawing.Point(374, 165);
            this.lblClaveUsuario.Name = "lblClaveUsuario";
            this.lblClaveUsuario.Size = new System.Drawing.Size(59, 18);
            this.lblClaveUsuario.TabIndex = 0;
            this.lblClaveUsuario.Text = "Clave:";
            // 
            // txtUsuarioID
            // 
            this.txtUsuarioID.Location = new System.Drawing.Point(92, 102);
            this.txtUsuarioID.Name = "txtUsuarioID";
            this.txtUsuarioID.ReadOnly = true;
            this.txtUsuarioID.Size = new System.Drawing.Size(251, 26);
            this.txtUsuarioID.TabIndex = 1;
            // 
            // txtUsuarioNombre
            // 
            this.txtUsuarioNombre.Location = new System.Drawing.Point(452, 102);
            this.txtUsuarioNombre.Name = "txtUsuarioNombre";
            this.txtUsuarioNombre.Size = new System.Drawing.Size(262, 26);
            this.txtUsuarioNombre.TabIndex = 1;
            // 
            // txtUsuarioEMAIL
            // 
            this.txtUsuarioEMAIL.Location = new System.Drawing.Point(92, 162);
            this.txtUsuarioEMAIL.Name = "txtUsuarioEMAIL";
            this.txtUsuarioEMAIL.Size = new System.Drawing.Size(251, 26);
            this.txtUsuarioEMAIL.TabIndex = 1;
            // 
            // txtUsuarioCLAVE
            // 
            this.txtUsuarioCLAVE.Location = new System.Drawing.Point(452, 162);
            this.txtUsuarioCLAVE.Name = "txtUsuarioCLAVE";
            this.txtUsuarioCLAVE.PasswordChar = '*';
            this.txtUsuarioCLAVE.Size = new System.Drawing.Size(262, 26);
            this.txtUsuarioCLAVE.TabIndex = 1;
            // 
            // UsuariodataGridView1
            // 
            this.UsuariodataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UsuariodataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsuariodataGridView1.Location = new System.Drawing.Point(2, 374);
            this.UsuariodataGridView1.Name = "UsuariodataGridView1";
            this.UsuariodataGridView1.Size = new System.Drawing.Size(733, 135);
            this.UsuariodataGridView1.TabIndex = 3;
            // 
            // btnNuevoUsuario
            // 
            this.btnNuevoUsuario.BackColor = System.Drawing.Color.Aquamarine;
            this.btnNuevoUsuario.Location = new System.Drawing.Point(12, 319);
            this.btnNuevoUsuario.Name = "btnNuevoUsuario";
            this.btnNuevoUsuario.Size = new System.Drawing.Size(137, 34);
            this.btnNuevoUsuario.TabIndex = 4;
            this.btnNuevoUsuario.Text = "Nuevo";
            this.btnNuevoUsuario.UseVisualStyleBackColor = false;
            // 
            // btnGuardarUsuario
            // 
            this.btnGuardarUsuario.BackColor = System.Drawing.Color.GreenYellow;
            this.btnGuardarUsuario.Enabled = false;
            this.btnGuardarUsuario.Location = new System.Drawing.Point(298, 319);
            this.btnGuardarUsuario.Name = "btnGuardarUsuario";
            this.btnGuardarUsuario.Size = new System.Drawing.Size(137, 34);
            this.btnGuardarUsuario.TabIndex = 4;
            this.btnGuardarUsuario.Text = "Guardar";
            this.btnGuardarUsuario.UseVisualStyleBackColor = false;
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.BackColor = System.Drawing.Color.LightCoral;
            this.btnEliminarUsuario.Location = new System.Drawing.Point(445, 319);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(137, 34);
            this.btnEliminarUsuario.TabIndex = 4;
            this.btnEliminarUsuario.Text = "Eliminar";
            this.btnEliminarUsuario.UseVisualStyleBackColor = false;
            // 
            // cboxAdmin
            // 
            this.cboxAdmin.AutoSize = true;
            this.cboxAdmin.Location = new System.Drawing.Point(92, 218);
            this.cboxAdmin.Name = "cboxAdmin";
            this.cboxAdmin.Size = new System.Drawing.Size(119, 22);
            this.cboxAdmin.TabIndex = 5;
            this.cboxAdmin.Text = "Soy Cliente";
            this.cboxAdmin.UseVisualStyleBackColor = true;
            // 
            // btnUsuarioModificar
            // 
            this.btnUsuarioModificar.BackColor = System.Drawing.Color.Aquamarine;
            this.btnUsuarioModificar.Location = new System.Drawing.Point(155, 319);
            this.btnUsuarioModificar.Name = "btnUsuarioModificar";
            this.btnUsuarioModificar.Size = new System.Drawing.Size(137, 34);
            this.btnUsuarioModificar.TabIndex = 4;
            this.btnUsuarioModificar.Text = "Modificar";
            this.btnUsuarioModificar.UseVisualStyleBackColor = false;
            this.btnUsuarioModificar.Click += new System.EventHandler(this.btnUsuarioModificar_Click);
            // 
            // btnUsuarioCancelar
            // 
            this.btnUsuarioCancelar.BackColor = System.Drawing.Color.Aquamarine;
            this.btnUsuarioCancelar.Enabled = false;
            this.btnUsuarioCancelar.Location = new System.Drawing.Point(588, 319);
            this.btnUsuarioCancelar.Name = "btnUsuarioCancelar";
            this.btnUsuarioCancelar.Size = new System.Drawing.Size(137, 34);
            this.btnUsuarioCancelar.TabIndex = 4;
            this.btnUsuarioCancelar.Text = "Cancelar";
            this.btnUsuarioCancelar.UseVisualStyleBackColor = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // UsuariosView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(737, 513);
            this.Controls.Add(this.cboxAdmin);
            this.Controls.Add(this.btnEliminarUsuario);
            this.Controls.Add(this.btnGuardarUsuario);
            this.Controls.Add(this.btnUsuarioCancelar);
            this.Controls.Add(this.btnUsuarioModificar);
            this.Controls.Add(this.btnNuevoUsuario);
            this.Controls.Add(this.UsuariodataGridView1);
            this.Controls.Add(this.txtUsuarioCLAVE);
            this.Controls.Add(this.txtUsuarioEMAIL);
            this.Controls.Add(this.txtUsuarioNombre);
            this.Controls.Add(this.txtUsuarioID);
            this.Controls.Add(this.lblClaveUsuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "UsuariosView";
            this.Text = "Registro de Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.UsuariodataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblClaveUsuario;
        public System.Windows.Forms.CheckBox cboxAdmin;
        public System.Windows.Forms.TextBox txtUsuarioID;
        public System.Windows.Forms.TextBox txtUsuarioNombre;
        public System.Windows.Forms.TextBox txtUsuarioEMAIL;
        public System.Windows.Forms.TextBox txtUsuarioCLAVE;
        public System.Windows.Forms.Button btnNuevoUsuario;
        public System.Windows.Forms.Button btnGuardarUsuario;
        public System.Windows.Forms.Button btnEliminarUsuario;
        public System.Windows.Forms.Button btnUsuarioModificar;
        public System.Windows.Forms.Button btnUsuarioCancelar;
        public System.Windows.Forms.ErrorProvider errorProvider1;
        public System.Windows.Forms.DataGridView UsuariodataGridView1;
    }
}