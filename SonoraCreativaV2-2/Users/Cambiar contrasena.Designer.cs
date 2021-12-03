namespace SonoraCreativaV2_2.Users
{
    partial class Cambiar_contrasena
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
            this.groupBoxEUser = new System.Windows.Forms.GroupBox();
            this.textBoxCPassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxSelectId = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBoxEUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxAdminUsername);
            this.groupBox1.Controls.Add(this.textBoxAdminPW);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(375, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 214);
            this.groupBox1.TabIndex = 29;
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
            // groupBoxEUser
            // 
            this.groupBoxEUser.Controls.Add(this.textBoxCPassword);
            this.groupBoxEUser.Controls.Add(this.label7);
            this.groupBoxEUser.Controls.Add(this.textBoxPassword);
            this.groupBoxEUser.Controls.Add(this.label6);
            this.groupBoxEUser.Controls.Add(this.comboBoxSelectId);
            this.groupBoxEUser.Controls.Add(this.label10);
            this.groupBoxEUser.Controls.Add(this.textBoxUsername);
            this.groupBoxEUser.Controls.Add(this.label1);
            this.groupBoxEUser.Location = new System.Drawing.Point(11, 20);
            this.groupBoxEUser.Name = "groupBoxEUser";
            this.groupBoxEUser.Size = new System.Drawing.Size(358, 214);
            this.groupBoxEUser.TabIndex = 27;
            this.groupBoxEUser.TabStop = false;
            this.groupBoxEUser.Text = "Usuario a editar";
            // 
            // textBoxCPassword
            // 
            this.textBoxCPassword.Location = new System.Drawing.Point(146, 176);
            this.textBoxCPassword.Name = "textBoxCPassword";
            this.textBoxCPassword.Size = new System.Drawing.Size(198, 22);
            this.textBoxCPassword.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "Confirmar contraseña:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(146, 126);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(198, 22);
            this.textBoxPassword.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Contraseña:";
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
            this.buttonConfirm.Location = new System.Drawing.Point(300, 240);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(141, 37);
            this.buttonConfirm.TabIndex = 28;
            this.buttonConfirm.Text = "Confirmar";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            // 
            // Cambiar_contrasena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 296);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxEUser);
            this.Controls.Add(this.buttonConfirm);
            this.Name = "Cambiar_contrasena";
            this.Text = "Cambiar_contrasena";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxEUser.ResumeLayout(false);
            this.groupBoxEUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxAdminUsername;
        private System.Windows.Forms.TextBox textBoxAdminPW;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBoxEUser;
        private System.Windows.Forms.TextBox textBoxCPassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxSelectId;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonConfirm;
    }
}