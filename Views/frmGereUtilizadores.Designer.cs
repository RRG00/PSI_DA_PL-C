﻿namespace iTasks
{
    partial class frmGereUtilizadores
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
            this.btGravarGestor = new System.Windows.Forms.Button();
            this.txtNomeGestor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdGestor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstListaGestores = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btCleanGestor = new System.Windows.Forms.Button();
            this.btApagarGestor = new System.Windows.Forms.Button();
            this.btAttGestor = new System.Windows.Forms.Button();
            this.chkGereUtilizadores = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPasswordGestor = new System.Windows.Forms.TextBox();
            this.cbDepartamento = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsernameGestor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btCleanProg = new System.Windows.Forms.Button();
            this.btApagarProg = new System.Windows.Forms.Button();
            this.btAttProg = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.cbGestorProg = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btGravarProg = new System.Windows.Forms.Button();
            this.txtPasswordProg = new System.Windows.Forms.TextBox();
            this.cbNivelProg = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUsernameProg = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lstListaProgramadores = new System.Windows.Forms.ListBox();
            this.txtIdProg = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNomeProg = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btGravarGestor
            // 
            this.btGravarGestor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btGravarGestor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btGravarGestor.FlatAppearance.BorderSize = 0;
            this.btGravarGestor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGravarGestor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGravarGestor.ForeColor = System.Drawing.Color.White;
            this.btGravarGestor.Location = new System.Drawing.Point(294, 288);
            this.btGravarGestor.Name = "btGravarGestor";
            this.btGravarGestor.Size = new System.Drawing.Size(201, 30);
            this.btGravarGestor.TabIndex = 8;
            this.btGravarGestor.Text = "💾 Gravar Dados";
            this.btGravarGestor.UseVisualStyleBackColor = false;
            this.btGravarGestor.Click += new System.EventHandler(this.btGravarGestor_Click);
            // 
            // txtNomeGestor
            // 
            this.txtNomeGestor.BackColor = System.Drawing.Color.White;
            this.txtNomeGestor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeGestor.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeGestor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.txtNomeGestor.Location = new System.Drawing.Point(294, 80);
            this.txtNomeGestor.Name = "txtNomeGestor";
            this.txtNomeGestor.Size = new System.Drawing.Size(201, 25);
            this.txtNomeGestor.TabIndex = 3;
            this.txtNomeGestor.Enter += new System.EventHandler(this.txtNomeGestor_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label4.Location = new System.Drawing.Point(291, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 35;
            this.label4.Text = "Nome:";
            // 
            // txtIdGestor
            // 
            this.txtIdGestor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.txtIdGestor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdGestor.Enabled = false;
            this.txtIdGestor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdGestor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.txtIdGestor.Location = new System.Drawing.Point(294, 35);
            this.txtIdGestor.Name = "txtIdGestor";
            this.txtIdGestor.ReadOnly = true;
            this.txtIdGestor.Size = new System.Drawing.Size(62, 23);
            this.txtIdGestor.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label1.Location = new System.Drawing.Point(291, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 15);
            this.label1.TabIndex = 33;
            this.label1.Text = "Id:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lstListaGestores);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.groupBox1.Location = new System.Drawing.Point(6, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 446);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "📋 Lista";
            // 
            // lstListaGestores
            // 
            this.lstListaGestores.BackColor = System.Drawing.Color.White;
            this.lstListaGestores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstListaGestores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstListaGestores.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstListaGestores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lstListaGestores.FormattingEnabled = true;
            this.lstListaGestores.ItemHeight = 17;
            this.lstListaGestores.Location = new System.Drawing.Point(3, 21);
            this.lstListaGestores.Name = "lstListaGestores";
            this.lstListaGestores.Size = new System.Drawing.Size(268, 422);
            this.lstListaGestores.TabIndex = 1;
            this.lstListaGestores.SelectedIndexChanged += new System.EventHandler(this.lstListaGestores_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btCleanGestor);
            this.groupBox2.Controls.Add(this.btApagarGestor);
            this.groupBox2.Controls.Add(this.btAttGestor);
            this.groupBox2.Controls.Add(this.chkGereUtilizadores);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btGravarGestor);
            this.groupBox2.Controls.Add(this.txtPasswordGestor);
            this.groupBox2.Controls.Add(this.cbDepartamento);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtUsernameGestor);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.txtIdGestor);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtNomeGestor);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(511, 396);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "👨‍💼 Gestores";
            // 
            // btCleanGestor
            // 
            this.btCleanGestor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btCleanGestor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCleanGestor.FlatAppearance.BorderSize = 0;
            this.btCleanGestor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCleanGestor.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCleanGestor.ForeColor = System.Drawing.Color.White;
            this.btCleanGestor.Location = new System.Drawing.Point(399, 34);
            this.btCleanGestor.Name = "btCleanGestor";
            this.btCleanGestor.Size = new System.Drawing.Size(95, 25);
            this.btCleanGestor.TabIndex = 43;
            this.btCleanGestor.Text = "🧹 Limpar";
            this.btCleanGestor.UseVisualStyleBackColor = false;
            this.btCleanGestor.Click += new System.EventHandler(this.btCleanGestor_Click);
            // 
            // btApagarGestor
            // 
            this.btApagarGestor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btApagarGestor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btApagarGestor.FlatAppearance.BorderSize = 0;
            this.btApagarGestor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btApagarGestor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btApagarGestor.ForeColor = System.Drawing.Color.White;
            this.btApagarGestor.Location = new System.Drawing.Point(294, 354);
            this.btApagarGestor.Name = "btApagarGestor";
            this.btApagarGestor.Size = new System.Drawing.Size(201, 30);
            this.btApagarGestor.TabIndex = 10;
            this.btApagarGestor.Text = "🗑️ Apagar Dados";
            this.btApagarGestor.UseVisualStyleBackColor = false;
            this.btApagarGestor.Click += new System.EventHandler(this.btApagarGestor_Click);
            // 
            // btAttGestor
            // 
            this.btAttGestor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btAttGestor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAttGestor.FlatAppearance.BorderSize = 0;
            this.btAttGestor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAttGestor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAttGestor.ForeColor = System.Drawing.Color.White;
            this.btAttGestor.Location = new System.Drawing.Point(293, 321);
            this.btAttGestor.Name = "btAttGestor";
            this.btAttGestor.Size = new System.Drawing.Size(201, 30);
            this.btAttGestor.TabIndex = 9;
            this.btAttGestor.Text = "✏️ Atualizar Dados";
            this.btAttGestor.UseVisualStyleBackColor = false;
            this.btAttGestor.Click += new System.EventHandler(this.btAttGestor_Click);
            // 
            // chkGereUtilizadores
            // 
            this.chkGereUtilizadores.AutoSize = true;
            this.chkGereUtilizadores.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGereUtilizadores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.chkGereUtilizadores.Location = new System.Drawing.Point(294, 245);
            this.chkGereUtilizadores.Name = "chkGereUtilizadores";
            this.chkGereUtilizadores.Size = new System.Drawing.Size(139, 19);
            this.chkGereUtilizadores.TabIndex = 7;
            this.chkGereUtilizadores.Text = "👥 Gere Utilizadores";
            this.chkGereUtilizadores.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label5.Location = new System.Drawing.Point(291, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 15);
            this.label5.TabIndex = 42;
            this.label5.Text = "Departamento:";
            // 
            // txtPasswordGestor
            // 
            this.txtPasswordGestor.BackColor = System.Drawing.Color.White;
            this.txtPasswordGestor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPasswordGestor.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordGestor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.txtPasswordGestor.Location = new System.Drawing.Point(294, 165);
            this.txtPasswordGestor.Name = "txtPasswordGestor";
            this.txtPasswordGestor.PasswordChar = '●';
            this.txtPasswordGestor.Size = new System.Drawing.Size(201, 25);
            this.txtPasswordGestor.TabIndex = 5;
            // 
            // cbDepartamento
            // 
            this.cbDepartamento.BackColor = System.Drawing.Color.White;
            this.cbDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepartamento.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDepartamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.cbDepartamento.FormattingEnabled = true;
            this.cbDepartamento.Location = new System.Drawing.Point(294, 209);
            this.cbDepartamento.Name = "cbDepartamento";
            this.cbDepartamento.Size = new System.Drawing.Size(201, 23);
            this.cbDepartamento.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label3.Location = new System.Drawing.Point(291, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 39;
            this.label3.Text = "Password:";
            // 
            // txtUsernameGestor
            // 
            this.txtUsernameGestor.BackColor = System.Drawing.Color.White;
            this.txtUsernameGestor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsernameGestor.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsernameGestor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.txtUsernameGestor.Location = new System.Drawing.Point(294, 122);
            this.txtUsernameGestor.Name = "txtUsernameGestor";
            this.txtUsernameGestor.Size = new System.Drawing.Size(201, 25);
            this.txtUsernameGestor.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label2.Location = new System.Drawing.Point(291, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 37;
            this.label2.Text = "Username:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.btCleanProg);
            this.groupBox3.Controls.Add(this.btApagarProg);
            this.groupBox3.Controls.Add(this.btAttProg);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.cbGestorProg);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.btGravarProg);
            this.groupBox3.Controls.Add(this.txtPasswordProg);
            this.groupBox3.Controls.Add(this.cbNivelProg);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtUsernameProg);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.txtIdProg);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtNomeProg);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.groupBox3.Location = new System.Drawing.Point(529, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(511, 396);
            this.groupBox3.TabIndex = 39;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "👨‍💻 Programadores";
            // 
            // btCleanProg
            // 
            this.btCleanProg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btCleanProg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCleanProg.FlatAppearance.BorderSize = 0;
            this.btCleanProg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCleanProg.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCleanProg.ForeColor = System.Drawing.Color.White;
            this.btCleanProg.Location = new System.Drawing.Point(399, 35);
            this.btCleanProg.Name = "btCleanProg";
            this.btCleanProg.Size = new System.Drawing.Size(95, 25);
            this.btCleanProg.TabIndex = 44;
            this.btCleanProg.Text = "🧹 Limpar";
            this.btCleanProg.UseVisualStyleBackColor = false;
            this.btCleanProg.Click += new System.EventHandler(this.btCleanProg_Click);
            // 
            // btApagarProg
            // 
            this.btApagarProg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btApagarProg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btApagarProg.FlatAppearance.BorderSize = 0;
            this.btApagarProg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btApagarProg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btApagarProg.ForeColor = System.Drawing.Color.White;
            this.btApagarProg.Location = new System.Drawing.Point(294, 354);
            this.btApagarProg.Name = "btApagarProg";
            this.btApagarProg.Size = new System.Drawing.Size(201, 30);
            this.btApagarProg.TabIndex = 20;
            this.btApagarProg.Text = "🗑️ Apagar Dados";
            this.btApagarProg.UseVisualStyleBackColor = false;
            this.btApagarProg.Click += new System.EventHandler(this.btApagarProg_Click);
            // 
            // btAttProg
            // 
            this.btAttProg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btAttProg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAttProg.FlatAppearance.BorderSize = 0;
            this.btAttProg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAttProg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAttProg.ForeColor = System.Drawing.Color.White;
            this.btAttProg.Location = new System.Drawing.Point(293, 321);
            this.btAttProg.Name = "btAttProg";
            this.btAttProg.Size = new System.Drawing.Size(201, 30);
            this.btAttProg.TabIndex = 19;
            this.btAttProg.Text = "✏️ Atualizar Dados";
            this.btAttProg.UseVisualStyleBackColor = false;
            this.btAttProg.Click += new System.EventHandler(this.btAttProg_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label11.Location = new System.Drawing.Point(291, 236);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 15);
            this.label11.TabIndex = 44;
            this.label11.Text = "Gestor:";
            // 
            // cbGestorProg
            // 
            this.cbGestorProg.BackColor = System.Drawing.Color.White;
            this.cbGestorProg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGestorProg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGestorProg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.cbGestorProg.FormattingEnabled = true;
            this.cbGestorProg.Location = new System.Drawing.Point(294, 253);
            this.cbGestorProg.Name = "cbGestorProg";
            this.cbGestorProg.Size = new System.Drawing.Size(201, 23);
            this.cbGestorProg.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label6.Location = new System.Drawing.Point(291, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 15);
            this.label6.TabIndex = 42;
            this.label6.Text = "Nível de Experiência:";
            // 
            // btGravarProg
            // 
            this.btGravarProg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btGravarProg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btGravarProg.FlatAppearance.BorderSize = 0;
            this.btGravarProg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGravarProg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGravarProg.ForeColor = System.Drawing.Color.White;
            this.btGravarProg.Location = new System.Drawing.Point(294, 288);
            this.btGravarProg.Name = "btGravarProg";
            this.btGravarProg.Size = new System.Drawing.Size(201, 30);
            this.btGravarProg.TabIndex = 18;
            this.btGravarProg.Text = "💾 Gravar Dados";
            this.btGravarProg.UseVisualStyleBackColor = false;
            this.btGravarProg.Click += new System.EventHandler(this.btGravarProg_Click);
            // 
            // txtPasswordProg
            // 
            this.txtPasswordProg.BackColor = System.Drawing.Color.White;
            this.txtPasswordProg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPasswordProg.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordProg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.txtPasswordProg.Location = new System.Drawing.Point(294, 165);
            this.txtPasswordProg.Name = "txtPasswordProg";
            this.txtPasswordProg.PasswordChar = '●';
            this.txtPasswordProg.Size = new System.Drawing.Size(201, 25);
            this.txtPasswordProg.TabIndex = 15;
            // 
            // cbNivelProg
            // 
            this.cbNivelProg.BackColor = System.Drawing.Color.White;
            this.cbNivelProg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNivelProg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNivelProg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.cbNivelProg.FormattingEnabled = true;
            this.cbNivelProg.Location = new System.Drawing.Point(294, 209);
            this.cbNivelProg.Name = "cbNivelProg";
            this.cbNivelProg.Size = new System.Drawing.Size(201, 23);
            this.cbNivelProg.TabIndex = 16;
            this.cbNivelProg.Click += new System.EventHandler(this.s);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label7.Location = new System.Drawing.Point(291, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 15);
            this.label7.TabIndex = 39;
            this.label7.Text = "Password:";
            // 
            // txtUsernameProg
            // 
            this.txtUsernameProg.BackColor = System.Drawing.Color.White;
            this.txtUsernameProg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsernameProg.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsernameProg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.txtUsernameProg.Location = new System.Drawing.Point(294, 122);
            this.txtUsernameProg.Name = "txtUsernameProg";
            this.txtUsernameProg.Size = new System.Drawing.Size(201, 25);
            this.txtUsernameProg.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label8.Location = new System.Drawing.Point(291, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 37;
            this.label8.Text = "Username:";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.lstListaProgramadores);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.groupBox4.Location = new System.Drawing.Point(6, 28);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(274, 446);
            this.groupBox4.TabIndex = 32;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "📋 Lista";
            // 
            // lstListaProgramadores
            // 
            this.lstListaProgramadores.BackColor = System.Drawing.Color.White;
            this.lstListaProgramadores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstListaProgramadores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstListaProgramadores.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstListaProgramadores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lstListaProgramadores.FormattingEnabled = true;
            this.lstListaProgramadores.ItemHeight = 17;
            this.lstListaProgramadores.Location = new System.Drawing.Point(3, 21);
            this.lstListaProgramadores.Name = "lstListaProgramadores";
            this.lstListaProgramadores.Size = new System.Drawing.Size(268, 422);
            this.lstListaProgramadores.TabIndex = 11;
            this.lstListaProgramadores.SelectedIndexChanged += new System.EventHandler(this.lstListaProgramadores_SelectedIndexChanged);
            // 
            // txtIdProg
            // 
            this.txtIdProg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.txtIdProg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdProg.Enabled = false;
            this.txtIdProg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdProg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.txtIdProg.Location = new System.Drawing.Point(294, 35);
            this.txtIdProg.Name = "txtIdProg";
            this.txtIdProg.ReadOnly = true;
            this.txtIdProg.Size = new System.Drawing.Size(62, 23);
            this.txtIdProg.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label9.Location = new System.Drawing.Point(291, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 15);
            this.label9.TabIndex = 33;
            this.label9.Text = "Id:";
            // 
            // txtNomeProg
            // 
            this.txtNomeProg.BackColor = System.Drawing.Color.White;
            this.txtNomeProg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeProg.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeProg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.txtNomeProg.Location = new System.Drawing.Point(294, 80);
            this.txtNomeProg.Name = "txtNomeProg";
            this.txtNomeProg.Size = new System.Drawing.Size(201, 25);
            this.txtNomeProg.TabIndex = 13;
            this.txtNomeProg.Enter += new System.EventHandler(this.txtNomeProg_Enter);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label10.Location = new System.Drawing.Point(291, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 15);
            this.label10.TabIndex = 35;
            this.label10.Text = "Nome:";
            // 
            // frmGereUtilizadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1051, 414);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmGereUtilizadores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iTask - Gestão de Utilizadores";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btGravarGestor;
        private System.Windows.Forms.TextBox txtNomeGestor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdGestor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstListaGestores;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPasswordGestor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsernameGestor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkGereUtilizadores;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbDepartamento;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btGravarProg;
        private System.Windows.Forms.TextBox txtPasswordProg;
        private System.Windows.Forms.ComboBox cbNivelProg;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUsernameProg;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox lstListaProgramadores;
        private System.Windows.Forms.TextBox txtIdProg;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNomeProg;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbGestorProg;
        private System.Windows.Forms.Button btApagarGestor;
        private System.Windows.Forms.Button btAttGestor;
        private System.Windows.Forms.Button btApagarProg;
        private System.Windows.Forms.Button btAttProg;
        private System.Windows.Forms.Button btCleanGestor;
        private System.Windows.Forms.Button btCleanProg;
    }
}