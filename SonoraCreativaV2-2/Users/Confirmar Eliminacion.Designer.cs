namespace SonoraCreativaV2_2.Users
{
    partial class Confirmar_Eliminacion
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxAdminUsername = new System.Windows.Forms.TextBox();
            this.textBoxAdminPW = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxDeleteUser = new System.Windows.Forms.GroupBox();
            this.comboBoxSelectId = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBoxDeleteUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxAdminUsername);
            this.groupBox1.Controls.Add(this.textBoxAdminPW);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(11, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 122);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Introducir datos de administrador";
            // 
            // textBoxAdminUsername
            // 
            this.textBoxAdminUsername.Location = new System.Drawing.Point(154, 29);
            this.textBoxAdminUsername.Name = "textBoxAdminUsername";
            this.textBoxAdminUsername.Size = new System.Drawing.Size(198, 22);
            this.textBoxAdminUsername.TabIndex = 7;
            // 
            // textBoxAdminPW
            // 
            this.textBoxAdminPW.Location = new System.Drawing.Point(154, 77);
            this.textBoxAdminPW.Name = "textBoxAdminPW";
            this.textBoxAdminPW.Size = new System.Drawing.Size(198, 22);
            this.textBoxAdminPW.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nombre de usuario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Contraseña:";
            // 
            // groupBoxDeleteUser
            // 
            this.groupBoxDeleteUser.Controls.Add(this.comboBoxSelectId);
            this.groupBoxDeleteUser.Controls.Add(this.label10);
            this.groupBoxDeleteUser.Controls.Add(this.textBoxUsername);
            this.groupBoxDeleteUser.Controls.Add(this.label1);
            this.groupBoxDeleteUser.Location = new System.Drawing.Point(11, 13);
            this.groupBoxDeleteUser.Name = "groupBoxDeleteUser";
            this.groupBoxDeleteUser.Size = new System.Drawing.Size(358, 119);
            this.groupBoxDeleteUser.TabIndex = 30;
            this.groupBoxDeleteUser.TabStop = false;
            this.groupBoxDeleteUser.Text = "Usuario a Eliminar";
            // 
            // comboBoxSelectId
            // 
            this.comboBoxSelectId.FormattingEnabled = true;
            this.comboBoxSelectId.Items.AddRange(new object[] {
            "Matutino (8:00-14:00)",
            "Matutino Parcial",
            "Vespertino (14:00-22:00)",
            "Vespertino Parcial"});
            this.comboBoxSelectId.Location = new System.Drawing.Point(146, 32);
            this.comboBoxSelectId.Name = "comboBoxSelectId";
            this.comboBoxSelectId.Size = new System.Drawing.Size(198, 24);
            this.comboBoxSelectId.TabIndex = 19;
            this.comboBoxSelectId.Text = "Seleccione id...";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 16);
            this.label10.TabIndex = 18;
            this.label10.Text = "Seleccionar Usuario:";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(146, 80);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(198, 22);
            this.textBoxUsername.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de usuario:";
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(109, 266);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(141, 37);
            this.buttonConfirm.TabIndex = 31;
            this.buttonConfirm.Text = "Confirmar";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            // 
            // Confirmar_Eliminacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 316);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxDeleteUser);
            this.Controls.Add(this.buttonConfirm);
            this.Name = "Confirmar_Eliminacion";
            this.Text = "Confirmar_Eliminacion";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxDeleteUser.ResumeLayout(false);
            this.groupBoxDeleteUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxAdminUsername;
        private System.Windows.Forms.TextBox textBoxAdminPW;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBoxDeleteUser;
        private System.Windows.Forms.ComboBox comboBoxSelectId;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonConfirm;
    }
}