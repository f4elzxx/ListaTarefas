namespace ListaTarefas
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblTitulo = new System.Windows.Forms.Label();
            this.grbApagar = new System.Windows.Forms.GroupBox();
            this.BtnApagar = new System.Windows.Forms.Button();
            this.lblApagar = new System.Windows.Forms.Label();
            this.GrbInserir = new System.Windows.Forms.GroupBox();
            this.TxbData = new System.Windows.Forms.TextBox();
            this.LblData = new System.Windows.Forms.Label();
            this.TxbObs = new System.Windows.Forms.TextBox();
            this.BtnInserir = new System.Windows.Forms.Button();
            this.lblCategoriaProd = new System.Windows.Forms.Label();
            this.TxbLocal = new System.Windows.Forms.TextBox();
            this.LblLocal = new System.Windows.Forms.Label();
            this.TxbTarefa = new System.Windows.Forms.TextBox();
            this.LblTarefa = new System.Windows.Forms.Label();
            this.DgvTarefas = new System.Windows.Forms.DataGridView();
            this.GrbEdit = new System.Windows.Forms.GroupBox();
            this.TxbDataEdit = new System.Windows.Forms.TextBox();
            this.LblDataEdit = new System.Windows.Forms.Label();
            this.TxbObsEdit = new System.Windows.Forms.TextBox();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.LblObsEdit = new System.Windows.Forms.Label();
            this.TxbLocalEdit = new System.Windows.Forms.TextBox();
            this.LblLocalEdit = new System.Windows.Forms.Label();
            this.TxbTarefaEdit = new System.Windows.Forms.TextBox();
            this.LblTarefaEdit = new System.Windows.Forms.Label();
            this.PbExit = new System.Windows.Forms.PictureBox();
            this.grbApagar.SuspendLayout();
            this.GrbInserir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTarefas)).BeginInit();
            this.GrbEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbExit)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.Color.Black;
            this.LblTitulo.Location = new System.Drawing.Point(382, 9);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(152, 42);
            this.LblTitulo.TabIndex = 0;
            this.LblTitulo.Text = "Tarefas";
            // 
            // grbApagar
            // 
            this.grbApagar.Controls.Add(this.BtnApagar);
            this.grbApagar.Controls.Add(this.lblApagar);
            this.grbApagar.Enabled = false;
            this.grbApagar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grbApagar.Location = new System.Drawing.Point(85, 646);
            this.grbApagar.Name = "grbApagar";
            this.grbApagar.Size = new System.Drawing.Size(370, 58);
            this.grbApagar.TabIndex = 18;
            this.grbApagar.TabStop = false;
            this.grbApagar.Text = "Apagar";
            // 
            // BtnApagar
            // 
            this.BtnApagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnApagar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnApagar.Location = new System.Drawing.Point(289, 17);
            this.BtnApagar.Name = "BtnApagar";
            this.BtnApagar.Size = new System.Drawing.Size(75, 35);
            this.BtnApagar.TabIndex = 1;
            this.BtnApagar.Text = "Apagar";
            this.BtnApagar.UseVisualStyleBackColor = false;
            this.BtnApagar.Click += new System.EventHandler(this.BtnApagar_Click);
            // 
            // lblApagar
            // 
            this.lblApagar.AutoSize = true;
            this.lblApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApagar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblApagar.Location = new System.Drawing.Point(16, 26);
            this.lblApagar.Name = "lblApagar";
            this.lblApagar.Size = new System.Drawing.Size(215, 16);
            this.lblApagar.TabIndex = 0;
            this.lblApagar.Text = "Selecione uma tarefa para apagar.";
            // 
            // GrbInserir
            // 
            this.GrbInserir.Controls.Add(this.TxbData);
            this.GrbInserir.Controls.Add(this.LblData);
            this.GrbInserir.Controls.Add(this.TxbObs);
            this.GrbInserir.Controls.Add(this.BtnInserir);
            this.GrbInserir.Controls.Add(this.lblCategoriaProd);
            this.GrbInserir.Controls.Add(this.TxbLocal);
            this.GrbInserir.Controls.Add(this.LblLocal);
            this.GrbInserir.Controls.Add(this.TxbTarefa);
            this.GrbInserir.Controls.Add(this.LblTarefa);
            this.GrbInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrbInserir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GrbInserir.Location = new System.Drawing.Point(85, 407);
            this.GrbInserir.Name = "GrbInserir";
            this.GrbInserir.Size = new System.Drawing.Size(370, 233);
            this.GrbInserir.TabIndex = 16;
            this.GrbInserir.TabStop = false;
            this.GrbInserir.Text = "Inserir";
            // 
            // TxbData
            // 
            this.TxbData.Location = new System.Drawing.Point(159, 130);
            this.TxbData.Name = "TxbData";
            this.TxbData.Size = new System.Drawing.Size(192, 26);
            this.TxbData.TabIndex = 9;
            // 
            // LblData
            // 
            this.LblData.AutoSize = true;
            this.LblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblData.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblData.Location = new System.Drawing.Point(103, 133);
            this.LblData.Name = "LblData";
            this.LblData.Size = new System.Drawing.Size(48, 20);
            this.LblData.TabIndex = 8;
            this.LblData.Text = "Data:";
            // 
            // TxbObs
            // 
            this.TxbObs.Location = new System.Drawing.Point(159, 98);
            this.TxbObs.Name = "TxbObs";
            this.TxbObs.Size = new System.Drawing.Size(192, 26);
            this.TxbObs.TabIndex = 7;
            // 
            // BtnInserir
            // 
            this.BtnInserir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnInserir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInserir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnInserir.Location = new System.Drawing.Point(10, 172);
            this.BtnInserir.Name = "BtnInserir";
            this.BtnInserir.Size = new System.Drawing.Size(341, 39);
            this.BtnInserir.TabIndex = 6;
            this.BtnInserir.Text = "Inserir";
            this.BtnInserir.UseVisualStyleBackColor = false;
            this.BtnInserir.Click += new System.EventHandler(this.BtnInserir_Click);
            // 
            // lblCategoriaProd
            // 
            this.lblCategoriaProd.AutoSize = true;
            this.lblCategoriaProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaProd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCategoriaProd.Location = new System.Drawing.Point(56, 101);
            this.lblCategoriaProd.Name = "lblCategoriaProd";
            this.lblCategoriaProd.Size = new System.Drawing.Size(98, 20);
            this.lblCategoriaProd.TabIndex = 4;
            this.lblCategoriaProd.Text = "Observação:";
            // 
            // TxbLocal
            // 
            this.TxbLocal.Location = new System.Drawing.Point(159, 65);
            this.TxbLocal.Name = "TxbLocal";
            this.TxbLocal.Size = new System.Drawing.Size(192, 26);
            this.TxbLocal.TabIndex = 3;
            // 
            // LblLocal
            // 
            this.LblLocal.AutoSize = true;
            this.LblLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLocal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblLocal.Location = new System.Drawing.Point(103, 65);
            this.LblLocal.Name = "LblLocal";
            this.LblLocal.Size = new System.Drawing.Size(51, 20);
            this.LblLocal.TabIndex = 2;
            this.LblLocal.Text = "Local:";
            // 
            // TxbTarefa
            // 
            this.TxbTarefa.Location = new System.Drawing.Point(159, 29);
            this.TxbTarefa.Name = "TxbTarefa";
            this.TxbTarefa.Size = new System.Drawing.Size(192, 26);
            this.TxbTarefa.TabIndex = 1;
            // 
            // LblTarefa
            // 
            this.LblTarefa.AutoSize = true;
            this.LblTarefa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTarefa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblTarefa.Location = new System.Drawing.Point(94, 29);
            this.LblTarefa.Name = "LblTarefa";
            this.LblTarefa.Size = new System.Drawing.Size(59, 20);
            this.LblTarefa.TabIndex = 0;
            this.LblTarefa.Text = "Tarefa:";
            // 
            // DgvTarefas
            // 
            this.DgvTarefas.AllowUserToAddRows = false;
            this.DgvTarefas.AllowUserToDeleteRows = false;
            this.DgvTarefas.AllowUserToResizeColumns = false;
            this.DgvTarefas.AllowUserToResizeRows = false;
            this.DgvTarefas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvTarefas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTarefas.Location = new System.Drawing.Point(70, 57);
            this.DgvTarefas.Name = "DgvTarefas";
            this.DgvTarefas.ReadOnly = true;
            this.DgvTarefas.Size = new System.Drawing.Size(783, 334);
            this.DgvTarefas.TabIndex = 15;
            this.DgvTarefas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvTarefas_CellContentClick);
            // 
            // GrbEdit
            // 
            this.GrbEdit.Controls.Add(this.TxbDataEdit);
            this.GrbEdit.Controls.Add(this.LblDataEdit);
            this.GrbEdit.Controls.Add(this.TxbObsEdit);
            this.GrbEdit.Controls.Add(this.BtnEditar);
            this.GrbEdit.Controls.Add(this.LblObsEdit);
            this.GrbEdit.Controls.Add(this.TxbLocalEdit);
            this.GrbEdit.Controls.Add(this.LblLocalEdit);
            this.GrbEdit.Controls.Add(this.TxbTarefaEdit);
            this.GrbEdit.Controls.Add(this.LblTarefaEdit);
            this.GrbEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrbEdit.ForeColor = System.Drawing.Color.Black;
            this.GrbEdit.Location = new System.Drawing.Point(461, 407);
            this.GrbEdit.Name = "GrbEdit";
            this.GrbEdit.Size = new System.Drawing.Size(370, 233);
            this.GrbEdit.TabIndex = 17;
            this.GrbEdit.TabStop = false;
            this.GrbEdit.Text = "Editar";
            // 
            // TxbDataEdit
            // 
            this.TxbDataEdit.Location = new System.Drawing.Point(159, 130);
            this.TxbDataEdit.Name = "TxbDataEdit";
            this.TxbDataEdit.Size = new System.Drawing.Size(192, 26);
            this.TxbDataEdit.TabIndex = 9;
            // 
            // LblDataEdit
            // 
            this.LblDataEdit.AutoSize = true;
            this.LblDataEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDataEdit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblDataEdit.Location = new System.Drawing.Point(103, 133);
            this.LblDataEdit.Name = "LblDataEdit";
            this.LblDataEdit.Size = new System.Drawing.Size(48, 20);
            this.LblDataEdit.TabIndex = 8;
            this.LblDataEdit.Text = "Data:";
            // 
            // TxbObsEdit
            // 
            this.TxbObsEdit.Location = new System.Drawing.Point(159, 98);
            this.TxbObsEdit.Name = "TxbObsEdit";
            this.TxbObsEdit.Size = new System.Drawing.Size(192, 26);
            this.TxbObsEdit.TabIndex = 7;
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.ForeColor = System.Drawing.Color.Black;
            this.BtnEditar.Location = new System.Drawing.Point(10, 172);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(341, 39);
            this.BtnEditar.TabIndex = 6;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // LblObsEdit
            // 
            this.LblObsEdit.AutoSize = true;
            this.LblObsEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblObsEdit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblObsEdit.Location = new System.Drawing.Point(56, 101);
            this.LblObsEdit.Name = "LblObsEdit";
            this.LblObsEdit.Size = new System.Drawing.Size(98, 20);
            this.LblObsEdit.TabIndex = 4;
            this.LblObsEdit.Text = "Observação:";
            // 
            // TxbLocalEdit
            // 
            this.TxbLocalEdit.Location = new System.Drawing.Point(159, 65);
            this.TxbLocalEdit.Name = "TxbLocalEdit";
            this.TxbLocalEdit.Size = new System.Drawing.Size(192, 26);
            this.TxbLocalEdit.TabIndex = 3;
            // 
            // LblLocalEdit
            // 
            this.LblLocalEdit.AutoSize = true;
            this.LblLocalEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLocalEdit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblLocalEdit.Location = new System.Drawing.Point(103, 65);
            this.LblLocalEdit.Name = "LblLocalEdit";
            this.LblLocalEdit.Size = new System.Drawing.Size(51, 20);
            this.LblLocalEdit.TabIndex = 2;
            this.LblLocalEdit.Text = "Local:";
            // 
            // TxbTarefaEdit
            // 
            this.TxbTarefaEdit.Location = new System.Drawing.Point(159, 29);
            this.TxbTarefaEdit.Name = "TxbTarefaEdit";
            this.TxbTarefaEdit.Size = new System.Drawing.Size(192, 26);
            this.TxbTarefaEdit.TabIndex = 1;
            // 
            // LblTarefaEdit
            // 
            this.LblTarefaEdit.AutoSize = true;
            this.LblTarefaEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTarefaEdit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblTarefaEdit.Location = new System.Drawing.Point(94, 29);
            this.LblTarefaEdit.Name = "LblTarefaEdit";
            this.LblTarefaEdit.Size = new System.Drawing.Size(59, 20);
            this.LblTarefaEdit.TabIndex = 0;
            this.LblTarefaEdit.Text = "Tarefa:";
            // 
            // PbExit
            // 
            this.PbExit.Image = global::ListaTarefas.Properties.Resources.Prancheta_1;
            this.PbExit.Location = new System.Drawing.Point(849, -6);
            this.PbExit.Name = "PbExit";
            this.PbExit.Size = new System.Drawing.Size(75, 87);
            this.PbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbExit.TabIndex = 19;
            this.PbExit.TabStop = false;
            this.PbExit.Click += new System.EventHandler(this.PbExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(922, 730);
            this.Controls.Add(this.GrbEdit);
            this.Controls.Add(this.grbApagar);
            this.Controls.Add(this.GrbInserir);
            this.Controls.Add(this.DgvTarefas);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.PbExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.grbApagar.ResumeLayout(false);
            this.grbApagar.PerformLayout();
            this.GrbInserir.ResumeLayout(false);
            this.GrbInserir.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTarefas)).EndInit();
            this.GrbEdit.ResumeLayout(false);
            this.GrbEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.GroupBox grbApagar;
        private System.Windows.Forms.Button BtnApagar;
        private System.Windows.Forms.Label lblApagar;
        private System.Windows.Forms.GroupBox GrbInserir;
        private System.Windows.Forms.TextBox TxbData;
        private System.Windows.Forms.Label LblData;
        private System.Windows.Forms.TextBox TxbObs;
        private System.Windows.Forms.Button BtnInserir;
        private System.Windows.Forms.Label lblCategoriaProd;
        private System.Windows.Forms.TextBox TxbLocal;
        private System.Windows.Forms.Label LblLocal;
        private System.Windows.Forms.TextBox TxbTarefa;
        private System.Windows.Forms.Label LblTarefa;
        private System.Windows.Forms.DataGridView DgvTarefas;
        private System.Windows.Forms.GroupBox GrbEdit;
        private System.Windows.Forms.TextBox TxbDataEdit;
        private System.Windows.Forms.Label LblDataEdit;
        private System.Windows.Forms.TextBox TxbObsEdit;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Label LblObsEdit;
        private System.Windows.Forms.TextBox TxbLocalEdit;
        private System.Windows.Forms.Label LblLocalEdit;
        private System.Windows.Forms.TextBox TxbTarefaEdit;
        private System.Windows.Forms.Label LblTarefaEdit;
        private System.Windows.Forms.PictureBox PbExit;
    }
}

