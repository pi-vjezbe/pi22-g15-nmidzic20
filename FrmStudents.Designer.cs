namespace Evaluation_Manager
{
    partial class FrmStudents
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btnEvaluateStudent = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(68, 48);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(662, 283);
			this.dataGridView1.TabIndex = 0;
			// 
			// btnEvaluateStudent
			// 
			this.btnEvaluateStudent.Location = new System.Drawing.Point(621, 376);
			this.btnEvaluateStudent.Name = "btnEvaluateStudent";
			this.btnEvaluateStudent.Size = new System.Drawing.Size(109, 33);
			this.btnEvaluateStudent.TabIndex = 1;
			this.btnEvaluateStudent.Text = "Evaluiraj studenta";
			this.btnEvaluateStudent.UseVisualStyleBackColor = true;
			this.btnEvaluateStudent.Click += new System.EventHandler(this.btnEvaluateStudent_Click);
			// 
			// FrmStudents
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnEvaluateStudent);
			this.Controls.Add(this.dataGridView1);
			this.Name = "FrmStudents";
			this.Text = "FrmStudents";
			this.Load += new System.EventHandler(this.FrmStudents_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnEvaluateStudent;
		}
}