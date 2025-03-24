
namespace TestScores_Assignment5
{
    partial class FormTestScores
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
            this.listTestScores = new System.Windows.Forms.ListView();
            this.listScoreAverage = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalcAverage = new System.Windows.Forms.Button();
            this.btnSendtoFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listTestScores
            // 
            this.listTestScores.HideSelection = false;
            this.listTestScores.Location = new System.Drawing.Point(36, 76);
            this.listTestScores.Name = "listTestScores";
            this.listTestScores.Size = new System.Drawing.Size(338, 451);
            this.listTestScores.TabIndex = 0;
            this.listTestScores.UseCompatibleStateImageBehavior = false;
            this.listTestScores.View = System.Windows.Forms.View.List;
            // 
            // listScoreAverage
            // 
            this.listScoreAverage.HideSelection = false;
            this.listScoreAverage.Location = new System.Drawing.Point(629, 76);
            this.listScoreAverage.Name = "listScoreAverage";
            this.listScoreAverage.Size = new System.Drawing.Size(338, 451);
            this.listScoreAverage.TabIndex = 1;
            this.listScoreAverage.UseCompatibleStateImageBehavior = false;
            this.listScoreAverage.View = System.Windows.Forms.View.List;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Students\' Test Scores";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(631, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(336, 34);
            this.label2.TabIndex = 3;
            this.label2.Text = "Students\' Score Averages";
            // 
            // btnCalcAverage
            // 
            this.btnCalcAverage.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcAverage.Location = new System.Drawing.Point(416, 231);
            this.btnCalcAverage.Name = "btnCalcAverage";
            this.btnCalcAverage.Size = new System.Drawing.Size(172, 44);
            this.btnCalcAverage.TabIndex = 4;
            this.btnCalcAverage.Text = "Calculate Average";
            this.btnCalcAverage.UseVisualStyleBackColor = true;
            this.btnCalcAverage.Click += new System.EventHandler(this.btnCalcAverage_Click);
            // 
            // btnSendtoFile
            // 
            this.btnSendtoFile.Font = new System.Drawing.Font("Modern No. 20", 10F);
            this.btnSendtoFile.Location = new System.Drawing.Point(416, 293);
            this.btnSendtoFile.Name = "btnSendtoFile";
            this.btnSendtoFile.Size = new System.Drawing.Size(172, 44);
            this.btnSendtoFile.TabIndex = 5;
            this.btnSendtoFile.Text = "Store Average";
            this.btnSendtoFile.UseVisualStyleBackColor = true;
            this.btnSendtoFile.Click += new System.EventHandler(this.btnSendtoFile_Click);
            // 
            // FormTestScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 566);
            this.Controls.Add(this.btnSendtoFile);
            this.Controls.Add(this.btnCalcAverage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listScoreAverage);
            this.Controls.Add(this.listTestScores);
            this.Name = "FormTestScores";
            this.Text = "Test Score Average Calculator";
            this.Load += new System.EventHandler(this.ListBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listTestScores;
        private System.Windows.Forms.ListView listScoreAverage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalcAverage;
        private System.Windows.Forms.Button btnSendtoFile;
    }
}

