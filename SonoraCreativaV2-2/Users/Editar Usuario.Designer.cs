namespace SonoraCreativaV2_2.Users
{
    partial class Editar_Usuario
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
            this.groupBoxEditUser = new System.Windows.Forms.GroupBox();
            this.comboBoxSelectId = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonSaveChanges = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxNotes = new System.Windows.Forms.TextBox();
            this.comboBoxSchedule = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxUsertype = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMLastname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPLastname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxEditUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxEditUser
            // 
            this.groupBoxEditUser.Controls.Add(this.comboBoxSelectId);
            this.groupBoxEditUser.Controls.Add(this.label10);
            this.groupBoxEditUser.Controls.Add(this.buttonSaveChanges);
            this.groupBoxEditUser.Controls.Add(this.label9);
            this.groupBoxEditUser.Controls.Add(this.textBoxNotes);
            this.groupBoxEditUser.Controls.Add(this.comboBoxSchedule);
            this.groupBoxEditUser.Controls.Add(this.label8);
            this.groupBoxEditUser.Controls.Add(this.comboBoxUsertype);
            this.groupBoxEditUser.Controls.Add(this.label5);
            this.groupBoxEditUser.Controls.Add(this.textBoxUsername);
            this.groupBoxEditUser.Controls.Add(this.label4);
            this.groupBoxEditUser.Controls.Add(this.textBoxMLastname);
            this.groupBoxEditUser.Controls.Add(this.label3);
            this.groupBoxEditUser.Controls.Add(this.textBoxPLastname);
            this.groupBoxEditUser.Controls.Add(this.label2);
            this.groupBoxEditUser.Controls.Add(this.textBoxName);
            this.groupBoxEditUser.Controls.Add(this.label1);
            this.groupBoxEditUser.Location = new System.Drawing.Point(12, 22);
            this.groupBoxEditUser.Name = "groupBoxEditUser";
            this.groupBoxEditUser.Size = new System.Drawing.Size(776, 386);
            this.groupBoxEditUser.TabIndex = 3;
            this.groupBoxEditUser.TabStop = false;
            this.groupBoxEditUser.Text = "Editar usuario";
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
            // buttonSaveChanges
            // 
            this.buttonSaveChanges.Location = new System.Drawing.Point(303, 333);
            this.buttonSaveChanges.Name = "buttonSaveChanges";
            this.buttonSaveChanges.Size = new System.Drawing.Size(141, 37);
            this.buttonSaveChanges.TabIndex = 8;
            this.buttonSaveChanges.Text = "Guardar Cambios";
            this.buttonSaveChanges.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 217);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Notas:";
            // 
            // textBoxNotes
            // 
            this.textBoxNotes.Location = new System.Drawing.Point(87, 217);
            this.textBoxNotes.Multiline = true;
            this.textBoxNotes.Name = "textBoxNotes";
            this.textBoxNotes.Size = new System.Drawing.Size(597, 100);
            this.textBoxNotes.TabIndex = 16;
            // 
            // comboBoxSchedule
            // 
            this.comboBoxSchedule.FormattingEnabled = true;
            this.comboBoxSchedule.Items.AddRange(new object[] {
            "Matutino (8:00-14:00)",
            "Matutino Parcial",
            "Vespertino (14:00-22:00)",
            "Vespertino Parcial"});
            this.comboBoxSchedule.Location = new System.Drawing.Point(486, 126);
            this.comboBoxSchedule.Name = "comboBoxSchedule";
            this.comboBoxSchedule.Size = new System.Drawing.Size(198, 24);
            this.comboBoxSchedule.TabIndex = 15;
            this.comboBoxSchedule.Text = "Seleccione una opcion";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(435, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Turno:";
            // 
            // comboBoxUsertype
            // 
            this.comboBoxUsertype.FormattingEnabled = true;
            this.comboBoxUsertype.Items.AddRange(new object[] {
            "Empleado",
            "Administrador"});
            this.comboBoxUsertype.Location = new System.Drawing.Point(486, 80);
            this.comboBoxUsertype.Name = "comboBoxUsertype";
            this.comboBoxUsertype.Size = new System.Drawing.Size(198, 24);
            this.comboBoxUsertype.TabIndex = 9;
            this.comboBoxUsertype.Text = "Seleccione una opcion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(376, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tipo de usuario:";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(486, 34);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(198, 22);
            this.textBoxUsername.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(355, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nombre de usuario:";
            // 
            // textBoxMLastname
            // 
            this.textBoxMLastname.Location = new System.Drawing.Point(146, 171);
            this.textBoxMLastname.Name = "textBoxMLastname";
            this.textBoxMLastname.Size = new System.Drawing.Size(198, 22);
            this.textBoxMLastname.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Apellido materno:";
            // 
            // textBoxPLastname
            // 
            this.textBoxPLastname.Location = new System.Drawing.Point(146, 126);
            this.textBoxPLastname.Name = "textBoxPLastname";
            this.textBoxPLastname.Size = new System.Drawing.Size(198, 22);
            this.textBoxPLastname.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido paterno:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(146, 80);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(198, 22);
            this.textBoxName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // Editar_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 430);
            this.Controls.Add(this.groupBoxEditUser);
            this.Name = "Editar_Usuario";
            this.Text = "Editar_Usuario";
            this.Load += new System.EventHandler(this.Editar_Usuario_Load);
            this.groupBoxEditUser.ResumeLayout(false);
            this.groupBoxEditUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxEditUser;
        private System.Windows.Forms.ComboBox comboBoxSelectId;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonSaveChanges;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxNotes;
        private System.Windows.Forms.ComboBox comboBoxSchedule;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxUsertype;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxMLastname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPLastname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
    }
}