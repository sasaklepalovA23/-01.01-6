namespace СашаЛАБА6
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvMatrix = new System.Windows.Forms.DataGridView();
            this.txtCols = new System.Windows.Forms.TextBox();
            this.txtRows = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkV = new System.Windows.Forms.CheckBox();
            this.chkB = new System.Windows.Forms.CheckBox();
            this.txtResV = new System.Windows.Forms.TextBox();
            this.txtResB = new System.Windows.Forms.TextBox();
            this.txtResA = new System.Windows.Forms.TextBox();
            this.chkA = new System.Windows.Forms.CheckBox();
            this.bthCreate = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.bthExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrix)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvMatrix);
            this.groupBox1.Controls.Add(this.txtCols);
            this.groupBox1.Controls.Add(this.txtRows);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1465, 360);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ввод данных матрицы";
            // 
            // dgvMatrix
            // 
            this.dgvMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatrix.Location = new System.Drawing.Point(414, 173);
            this.dgvMatrix.Name = "dgvMatrix";
            this.dgvMatrix.RowHeadersWidth = 51;
            this.dgvMatrix.RowTemplate.Height = 24;
            this.dgvMatrix.Size = new System.Drawing.Size(698, 181);
            this.dgvMatrix.TabIndex = 2;
            // 
            // txtCols
            // 
            this.txtCols.Location = new System.Drawing.Point(1143, 94);
            this.txtCols.Name = "txtCols";
            this.txtCols.Size = new System.Drawing.Size(242, 38);
            this.txtCols.TabIndex = 1;
            // 
            // txtRows
            // 
            this.txtRows.Location = new System.Drawing.Point(365, 94);
            this.txtRows.Name = "txtRows";
            this.txtRows.Size = new System.Drawing.Size(242, 38);
            this.txtRows.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(952, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "M-столбцов";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(683, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "матрица А[n,m]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(209, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "N-строк";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(578, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "задайте размер матрицы";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkV);
            this.groupBox2.Controls.Add(this.chkB);
            this.groupBox2.Controls.Add(this.txtResV);
            this.groupBox2.Controls.Add(this.txtResB);
            this.groupBox2.Controls.Add(this.txtResA);
            this.groupBox2.Controls.Add(this.chkA);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(13, 380);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1465, 265);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "найти";
            // 
            // chkV
            // 
            this.chkV.AutoSize = true;
            this.chkV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkV.Location = new System.Drawing.Point(6, 207);
            this.chkV.Name = "chkV";
            this.chkV.Size = new System.Drawing.Size(1062, 29);
            this.chkV.TabIndex = 0;
            this.chkV.Text = "в матрице А(6;6)найти произведение суммы четных чисел в 3-ей строке и сумму отриц" +
    " чисел 1-ого столбца";
            this.chkV.UseVisualStyleBackColor = true;
            this.chkV.CheckedChanged += new System.EventHandler(this.chkV_CheckedChanged);
            // 
            // chkB
            // 
            this.chkB.AutoSize = true;
            this.chkB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkB.Location = new System.Drawing.Point(6, 120);
            this.chkB.Name = "chkB";
            this.chkB.Size = new System.Drawing.Size(677, 29);
            this.chkB.TabIndex = 0;
            this.chkB.Text = "найти кол-во ториц элементов,находящихся на побочной диагонали";
            this.chkB.UseVisualStyleBackColor = true;
            // 
            // txtResV
            // 
            this.txtResV.Location = new System.Drawing.Point(1194, 207);
            this.txtResV.Name = "txtResV";
            this.txtResV.Size = new System.Drawing.Size(242, 38);
            this.txtResV.TabIndex = 1;
            // 
            // txtResB
            // 
            this.txtResB.Location = new System.Drawing.Point(1194, 112);
            this.txtResB.Name = "txtResB";
            this.txtResB.Size = new System.Drawing.Size(242, 38);
            this.txtResB.TabIndex = 1;
            // 
            // txtResA
            // 
            this.txtResA.Location = new System.Drawing.Point(1194, 37);
            this.txtResA.Name = "txtResA";
            this.txtResA.Size = new System.Drawing.Size(242, 38);
            this.txtResA.TabIndex = 1;
            // 
            // chkA
            // 
            this.chkA.AutoSize = true;
            this.chkA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkA.Location = new System.Drawing.Point(7, 51);
            this.chkA.Name = "chkA";
            this.chkA.Size = new System.Drawing.Size(450, 29);
            this.chkA.TabIndex = 0;
            this.chkA.Text = "найти сумму отриц некратных 5 элементов";
            this.chkA.UseVisualStyleBackColor = true;
            // 
            // bthCreate
            // 
            this.bthCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bthCreate.Location = new System.Drawing.Point(20, 664);
            this.bthCreate.Name = "bthCreate";
            this.bthCreate.Size = new System.Drawing.Size(222, 68);
            this.bthCreate.TabIndex = 2;
            this.bthCreate.Text = "создать таблицу";
            this.bthCreate.UseVisualStyleBackColor = true;
            this.bthCreate.Click += new System.EventHandler(this.bthCreate_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCalc.Location = new System.Drawing.Point(309, 664);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(930, 68);
            this.btnCalc.TabIndex = 2;
            this.btnCalc.Text = "перенест данные из таблицы в массив и решить задание";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // bthExit
            // 
            this.bthExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bthExit.Location = new System.Drawing.Point(1295, 664);
            this.bthExit.Name = "bthExit";
            this.bthExit.Size = new System.Drawing.Size(183, 68);
            this.bthExit.TabIndex = 2;
            this.bthExit.Text = "выход";
            this.bthExit.UseVisualStyleBackColor = true;
            this.bthExit.Click += new System.EventHandler(this.bthExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1490, 744);
            this.Controls.Add(this.bthExit);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.bthCreate);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Клепалова ИС24";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrix)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvMatrix;
        private System.Windows.Forms.TextBox txtCols;
        private System.Windows.Forms.TextBox txtRows;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkV;
        private System.Windows.Forms.CheckBox chkB;
        private System.Windows.Forms.CheckBox chkA;
        private System.Windows.Forms.TextBox txtResV;
        private System.Windows.Forms.TextBox txtResB;
        private System.Windows.Forms.TextBox txtResA;
        private System.Windows.Forms.Button bthCreate;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button bthExit;
    }
}

