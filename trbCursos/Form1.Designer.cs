namespace trbCursos
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
            this.components = new System.ComponentModel.Container();
            this.clbCurso = new System.Windows.Forms.CheckedListBox();
            this.clbDisciplinas = new System.Windows.Forms.CheckedListBox();
            this.btnGerar = new System.Windows.Forms.Button();
            this.dgvGrade = new System.Windows.Forms.DataGridView();
            this.dbCursoDataSet1 = new trbCursos.dbCursoDataSet1();
            this.tbGradeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbGradeTableAdapter = new trbCursos.dbCursoDataSet1TableAdapters.tbGradeTableAdapter();
            this.txtCodCursoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCodDisciplinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbCursoDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGradeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // clbCurso
            // 
            this.clbCurso.FormattingEnabled = true;
            this.clbCurso.Location = new System.Drawing.Point(12, 12);
            this.clbCurso.Name = "clbCurso";
            this.clbCurso.Size = new System.Drawing.Size(189, 424);
            this.clbCurso.TabIndex = 0;
            this.clbCurso.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ClbCurso_ItemCheck);
            // 
            // clbDisciplinas
            // 
            this.clbDisciplinas.FormattingEnabled = true;
            this.clbDisciplinas.Location = new System.Drawing.Point(224, 12);
            this.clbDisciplinas.Name = "clbDisciplinas";
            this.clbDisciplinas.Size = new System.Drawing.Size(189, 424);
            this.clbDisciplinas.TabIndex = 1;
            this.clbDisciplinas.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ClbDisciplinas_ItemCheck);
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(429, 184);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(103, 44);
            this.btnGerar.TabIndex = 2;
            this.btnGerar.Text = "GERAR GRADE";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.BtnGerar_Click);
            // 
            // dgvGrade
            // 
            this.dgvGrade.AutoGenerateColumns = false;
            this.dgvGrade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrade.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtCodCursoDataGridViewTextBoxColumn,
            this.txtCodDisciplinaDataGridViewTextBoxColumn});
            this.dgvGrade.DataSource = this.tbGradeBindingSource;
            this.dgvGrade.Location = new System.Drawing.Point(548, 12);
            this.dgvGrade.Name = "dgvGrade";
            this.dgvGrade.Size = new System.Drawing.Size(240, 424);
            this.dgvGrade.TabIndex = 3;
            // 
            // dbCursoDataSet1
            // 
            this.dbCursoDataSet1.DataSetName = "dbCursoDataSet1";
            this.dbCursoDataSet1.EnforceConstraints = false;
            this.dbCursoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbGradeBindingSource
            // 
            this.tbGradeBindingSource.DataMember = "tbGrade";
            this.tbGradeBindingSource.DataSource = this.dbCursoDataSet1;
            // 
            // tbGradeTableAdapter
            // 
            this.tbGradeTableAdapter.ClearBeforeFill = true;
            // 
            // txtCodCursoDataGridViewTextBoxColumn
            // 
            this.txtCodCursoDataGridViewTextBoxColumn.DataPropertyName = "txtCodCurso";
            this.txtCodCursoDataGridViewTextBoxColumn.HeaderText = "txtCodCurso";
            this.txtCodCursoDataGridViewTextBoxColumn.Name = "txtCodCursoDataGridViewTextBoxColumn";
            // 
            // txtCodDisciplinaDataGridViewTextBoxColumn
            // 
            this.txtCodDisciplinaDataGridViewTextBoxColumn.DataPropertyName = "txtCodDisciplina";
            this.txtCodDisciplinaDataGridViewTextBoxColumn.HeaderText = "txtCodDisciplina";
            this.txtCodDisciplinaDataGridViewTextBoxColumn.Name = "txtCodDisciplinaDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvGrade);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.clbDisciplinas);
            this.Controls.Add(this.clbCurso);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbCursoDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGradeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.CheckedListBox clbCurso;
        private System.Windows.Forms.Button btnGerar;
        public System.Windows.Forms.CheckedListBox clbDisciplinas;
        private dbCursoDataSet1 dbCursoDataSet1;
        private System.Windows.Forms.BindingSource tbGradeBindingSource;
        private dbCursoDataSet1TableAdapters.tbGradeTableAdapter tbGradeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCodCursoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCodDisciplinaDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridView dgvGrade;
    }
}

