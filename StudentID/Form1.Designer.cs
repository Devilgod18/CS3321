namespace StudentLogin
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.courses1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courses2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courses3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courses4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentDataSet1 = new StudentID.studentDataSet1();
            this.gradeTableAdapter = new StudentID.studentDataSet1TableAdapters.GradeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.courses1DataGridViewTextBoxColumn,
            this.courses2DataGridViewTextBoxColumn,
            this.courses3DataGridViewTextBoxColumn,
            this.courses4DataGridViewTextBoxColumn,
            this.studentIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.gradeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 165);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(707, 273);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // courses1DataGridViewTextBoxColumn
            // 
            this.courses1DataGridViewTextBoxColumn.DataPropertyName = "Courses 1";
            this.courses1DataGridViewTextBoxColumn.HeaderText = "Courses 1";
            this.courses1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.courses1DataGridViewTextBoxColumn.Name = "courses1DataGridViewTextBoxColumn";
            this.courses1DataGridViewTextBoxColumn.Width = 125;
            // 
            // courses2DataGridViewTextBoxColumn
            // 
            this.courses2DataGridViewTextBoxColumn.DataPropertyName = "Courses 2";
            this.courses2DataGridViewTextBoxColumn.HeaderText = "Courses 2";
            this.courses2DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.courses2DataGridViewTextBoxColumn.Name = "courses2DataGridViewTextBoxColumn";
            this.courses2DataGridViewTextBoxColumn.Width = 125;
            // 
            // courses3DataGridViewTextBoxColumn
            // 
            this.courses3DataGridViewTextBoxColumn.DataPropertyName = "Courses 3";
            this.courses3DataGridViewTextBoxColumn.HeaderText = "Courses 3";
            this.courses3DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.courses3DataGridViewTextBoxColumn.Name = "courses3DataGridViewTextBoxColumn";
            this.courses3DataGridViewTextBoxColumn.Width = 125;
            // 
            // courses4DataGridViewTextBoxColumn
            // 
            this.courses4DataGridViewTextBoxColumn.DataPropertyName = "Courses 4";
            this.courses4DataGridViewTextBoxColumn.HeaderText = "Courses 4";
            this.courses4DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.courses4DataGridViewTextBoxColumn.Name = "courses4DataGridViewTextBoxColumn";
            this.courses4DataGridViewTextBoxColumn.Width = 125;
            // 
            // studentIDDataGridViewTextBoxColumn
            // 
            this.studentIDDataGridViewTextBoxColumn.DataPropertyName = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.HeaderText = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentIDDataGridViewTextBoxColumn.Name = "studentIDDataGridViewTextBoxColumn";
            this.studentIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // gradeBindingSource
            // 
            this.gradeBindingSource.DataMember = "Grade";
            this.gradeBindingSource.DataSource = this.studentDataSet1;
            // 
            // studentDataSet1
            // 
            this.studentDataSet1.DataSetName = "studentDataSet1";
            this.studentDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gradeTableAdapter
            // 
            this.gradeTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 473);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Grades";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private StudentID.studentDataSet1 studentDataSet1;
        private System.Windows.Forms.BindingSource gradeBindingSource;
        private StudentID.studentDataSet1TableAdapters.GradeTableAdapter gradeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn courses1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courses2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courses3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courses4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
    }
}