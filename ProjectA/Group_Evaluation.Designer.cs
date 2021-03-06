﻿namespace ProjectA
{
    partial class Group_Evaluation
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
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comGroupId = new System.Windows.Forms.ComboBox();
            this.comEvaluationId = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.projectADataSet6 = new ProjectA.ProjectADataSet6();
            this.groupStudentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupStudentTableAdapter = new ProjectA.ProjectADataSet6TableAdapters.GroupStudentTableAdapter();
            this.groupIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectADataSet7 = new ProjectA.ProjectADataSet7();
            this.groupEvaluationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupEvaluationTableAdapter = new ProjectA.ProjectADataSet7TableAdapters.GroupEvaluationTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectADataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupStudentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectADataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupEvaluationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(186, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Group Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(186, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Evaluation Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(186, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Obtained Marks";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(297, 125);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(124, 21);
            this.textBox3.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(346, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 37);
            this.button1.TabIndex = 6;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comGroupId
            // 
            this.comGroupId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comGroupId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comGroupId.FormattingEnabled = true;
            this.comGroupId.Location = new System.Drawing.Point(297, 47);
            this.comGroupId.Name = "comGroupId";
            this.comGroupId.Size = new System.Drawing.Size(124, 23);
            this.comGroupId.TabIndex = 8;
            // 
            // comEvaluationId
            // 
            this.comEvaluationId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comEvaluationId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comEvaluationId.FormattingEnabled = true;
            this.comEvaluationId.Location = new System.Drawing.Point(297, 86);
            this.comEvaluationId.Name = "comEvaluationId";
            this.comEvaluationId.Size = new System.Drawing.Size(124, 23);
            this.comEvaluationId.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.groupIdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.groupEvaluationBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 221);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(642, 157);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(294, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 32);
            this.button2.TabIndex = 18;
            this.button2.Text = "Home";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(164, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(323, 31);
            this.label9.TabIndex = 22;
            this.label9.Text = "Assign Project to Group";
            // 
            // projectADataSet6
            // 
            this.projectADataSet6.DataSetName = "ProjectADataSet6";
            this.projectADataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupStudentBindingSource
            // 
            this.groupStudentBindingSource.DataMember = "GroupStudent";
            this.groupStudentBindingSource.DataSource = this.projectADataSet6;
            // 
            // groupStudentTableAdapter
            // 
            this.groupStudentTableAdapter.ClearBeforeFill = true;
            // 
            // groupIdDataGridViewTextBoxColumn
            // 
            this.groupIdDataGridViewTextBoxColumn.DataPropertyName = "GroupId";
            this.groupIdDataGridViewTextBoxColumn.HeaderText = "GroupId";
            this.groupIdDataGridViewTextBoxColumn.Name = "groupIdDataGridViewTextBoxColumn";
            this.groupIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // projectADataSet7
            // 
            this.projectADataSet7.DataSetName = "ProjectADataSet7";
            this.projectADataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupEvaluationBindingSource
            // 
            this.groupEvaluationBindingSource.DataMember = "GroupEvaluation";
            this.groupEvaluationBindingSource.DataSource = this.projectADataSet7;
            // 
            // groupEvaluationTableAdapter
            // 
            this.groupEvaluationTableAdapter.ClearBeforeFill = true;
            // 
            // Group_Evaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(642, 378);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comEvaluationId);
            this.Controls.Add(this.comGroupId);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(658, 417);
            this.MinimumSize = new System.Drawing.Size(658, 417);
            this.Name = "Group_Evaluation";
            this.Load += new System.EventHandler(this.Group_Evaluation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectADataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupStudentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectADataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupEvaluationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comGroupId;
        private System.Windows.Forms.ComboBox comEvaluationId;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
        private ProjectADataSet6 projectADataSet6;
        private System.Windows.Forms.BindingSource groupStudentBindingSource;
        private ProjectADataSet6TableAdapters.GroupStudentTableAdapter groupStudentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupIdDataGridViewTextBoxColumn;
        private ProjectADataSet7 projectADataSet7;
        private System.Windows.Forms.BindingSource groupEvaluationBindingSource;
        private ProjectADataSet7TableAdapters.GroupEvaluationTableAdapter groupEvaluationTableAdapter;
    }
}