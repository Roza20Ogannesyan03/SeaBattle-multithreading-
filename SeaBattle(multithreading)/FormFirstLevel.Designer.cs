
namespace SeaBattle_multithreading_
{
    partial class FormFirstLevel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFirstLevel));
            this.dataGridViewField = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewMove = new System.Windows.Forms.DataGridView();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonToRun = new System.Windows.Forms.Button();
            this.label1Level = new System.Windows.Forms.Label();
            this.pictureBoxA = new System.Windows.Forms.PictureBox();
            this.pictureBoxB = new System.Windows.Forms.PictureBox();
            this.Column5 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewImageColumn();
            this.buttonStartOver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxB)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewField
            // 
            this.dataGridViewField.AllowUserToAddRows = false;
            this.dataGridViewField.AllowUserToDeleteRows = false;
            this.dataGridViewField.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewField.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewField.ColumnHeadersVisible = false;
            this.dataGridViewField.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridViewField.Location = new System.Drawing.Point(56, 98);
            this.dataGridViewField.Name = "dataGridViewField";
            this.dataGridViewField.ReadOnly = true;
            this.dataGridViewField.RowHeadersVisible = false;
            this.dataGridViewField.RowTemplate.Height = 50;
            this.dataGridViewField.Size = new System.Drawing.Size(205, 205);
            this.dataGridViewField.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 50;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 50;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 50;
            // 
            // dataGridViewMove
            // 
            this.dataGridViewMove.AllowUserToAddRows = false;
            this.dataGridViewMove.AllowUserToDeleteRows = false;
            this.dataGridViewMove.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewMove.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMove.ColumnHeadersVisible = false;
            this.dataGridViewMove.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6});
            this.dataGridViewMove.Location = new System.Drawing.Point(568, 145);
            this.dataGridViewMove.Name = "dataGridViewMove";
            this.dataGridViewMove.ReadOnly = true;
            this.dataGridViewMove.RowHeadersVisible = false;
            this.dataGridViewMove.RowTemplate.Height = 50;
            this.dataGridViewMove.Size = new System.Drawing.Size(105, 205);
            this.dataGridViewMove.TabIndex = 1;
            // 
            // buttonUp
            // 
            this.buttonUp.BackColor = System.Drawing.Color.White;
            this.buttonUp.ForeColor = System.Drawing.Color.Black;
            this.buttonUp.Image = ((System.Drawing.Image)(resources.GetObject("buttonUp.Image")));
            this.buttonUp.Location = new System.Drawing.Point(538, 357);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(40, 33);
            this.buttonUp.TabIndex = 2;
            this.buttonUp.UseVisualStyleBackColor = false;
            this.buttonUp.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.BackColor = System.Drawing.Color.White;
            this.buttonDown.Image = ((System.Drawing.Image)(resources.GetObject("buttonDown.Image")));
            this.buttonDown.Location = new System.Drawing.Point(584, 357);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(41, 32);
            this.buttonDown.TabIndex = 3;
            this.buttonDown.UseVisualStyleBackColor = false;
            this.buttonDown.UseWaitCursor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.BackColor = System.Drawing.Color.White;
            this.buttonRight.Image = ((System.Drawing.Image)(resources.GetObject("buttonRight.Image")));
            this.buttonRight.Location = new System.Drawing.Point(631, 356);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(42, 33);
            this.buttonRight.TabIndex = 4;
            this.buttonRight.UseVisualStyleBackColor = false;
            this.buttonRight.UseWaitCursor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.BackColor = System.Drawing.Color.White;
            this.buttonLeft.Image = ((System.Drawing.Image)(resources.GetObject("buttonLeft.Image")));
            this.buttonLeft.Location = new System.Drawing.Point(679, 356);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(43, 32);
            this.buttonLeft.TabIndex = 5;
            this.buttonLeft.UseVisualStyleBackColor = false;
            this.buttonLeft.UseWaitCursor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonToRun
            // 
            this.buttonToRun.BackColor = System.Drawing.Color.Fuchsia;
            this.buttonToRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonToRun.Location = new System.Drawing.Point(56, 321);
            this.buttonToRun.Name = "buttonToRun";
            this.buttonToRun.Size = new System.Drawing.Size(205, 36);
            this.buttonToRun.TabIndex = 7;
            this.buttonToRun.Text = "Запустить";
            this.buttonToRun.UseVisualStyleBackColor = false;
            this.buttonToRun.Click += new System.EventHandler(this.buttonToRun_Click);
            // 
            // label1Level
            // 
            this.label1Level.AutoSize = true;
            this.label1Level.BackColor = System.Drawing.Color.Fuchsia;
            this.label1Level.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1Level.Location = new System.Drawing.Point(324, 48);
            this.label1Level.Name = "label1Level";
            this.label1Level.Size = new System.Drawing.Size(161, 33);
            this.label1Level.TabIndex = 8;
            this.label1Level.Text = "Уровень 1";
            // 
            // pictureBoxA
            // 
            this.pictureBoxA.ErrorImage = null;
            this.pictureBoxA.Location = new System.Drawing.Point(568, 98);
            this.pictureBoxA.Name = "pictureBoxA";
            this.pictureBoxA.Size = new System.Drawing.Size(55, 50);
            this.pictureBoxA.TabIndex = 9;
            this.pictureBoxA.TabStop = false;
            // 
            // pictureBoxB
            // 
            this.pictureBoxB.Location = new System.Drawing.Point(618, 98);
            this.pictureBoxB.Name = "pictureBoxB";
            this.pictureBoxB.Size = new System.Drawing.Size(55, 50);
            this.pictureBoxB.TabIndex = 10;
            this.pictureBoxB.TabStop = false;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column5.Width = 50;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Column6";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column6.Width = 50;
            // 
            // buttonStartOver
            // 
            this.buttonStartOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStartOver.Location = new System.Drawing.Point(56, 381);
            this.buttonStartOver.Name = "buttonStartOver";
            this.buttonStartOver.Size = new System.Drawing.Size(205, 32);
            this.buttonStartOver.TabIndex = 11;
            this.buttonStartOver.Text = "Начать заново";
            this.buttonStartOver.UseVisualStyleBackColor = true;
            // 
            // FormFirstLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonStartOver);
            this.Controls.Add(this.pictureBoxB);
            this.Controls.Add(this.pictureBoxA);
            this.Controls.Add(this.label1Level);
            this.Controls.Add(this.buttonToRun);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.dataGridViewMove);
            this.Controls.Add(this.dataGridViewField);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FormFirstLevel";
            this.Text = "Морской бой(многопоточность)";
            this.Load += new System.EventHandler(this.FormFirstLevel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewField;
        private System.Windows.Forms.DataGridView dataGridViewMove;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonToRun;
        private System.Windows.Forms.Label label1Level;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.PictureBox pictureBoxA;
        private System.Windows.Forms.PictureBox pictureBoxB;
        private System.Windows.Forms.DataGridViewImageColumn Column5;
        private System.Windows.Forms.DataGridViewImageColumn Column6;
        private System.Windows.Forms.Button buttonStartOver;
    }
}

