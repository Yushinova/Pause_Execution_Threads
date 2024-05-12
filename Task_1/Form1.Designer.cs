namespace Task_1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.minInput = new System.Windows.Forms.TextBox();
            this.maxInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.startSimple = new System.Windows.Forms.Button();
            this.stopSimple = new System.Windows.Forms.Button();
            this.outputSimple = new System.Windows.Forms.TextBox();
            this.startFib = new System.Windows.Forms.Button();
            this.stopFib = new System.Windows.Forms.Button();
            this.outputFib = new System.Windows.Forms.TextBox();
            this.Restart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(47, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Генерировать простые числа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(425, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(302, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Генерировать числа Фибоначчи";
            // 
            // minInput
            // 
            this.minInput.Location = new System.Drawing.Point(74, 88);
            this.minInput.Name = "minInput";
            this.minInput.Size = new System.Drawing.Size(87, 20);
            this.minInput.TabIndex = 2;
            this.minInput.TextChanged += new System.EventHandler(this.minInput_TextChanged);
            // 
            // maxInput
            // 
            this.maxInput.Location = new System.Drawing.Point(235, 88);
            this.maxInput.Name = "maxInput";
            this.maxInput.Size = new System.Drawing.Size(87, 20);
            this.maxInput.TabIndex = 3;
            this.maxInput.TextChanged += new System.EventHandler(this.maxInput_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "ОТ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(205, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "ДО";
            // 
            // startSimple
            // 
            this.startSimple.Location = new System.Drawing.Point(74, 142);
            this.startSimple.Name = "startSimple";
            this.startSimple.Size = new System.Drawing.Size(100, 32);
            this.startSimple.TabIndex = 6;
            this.startSimple.Text = "START";
            this.startSimple.UseVisualStyleBackColor = true;
            this.startSimple.Click += new System.EventHandler(this.startSimple_Click);
            // 
            // stopSimple
            // 
            this.stopSimple.Location = new System.Drawing.Point(208, 142);
            this.stopSimple.Name = "stopSimple";
            this.stopSimple.Size = new System.Drawing.Size(100, 32);
            this.stopSimple.TabIndex = 7;
            this.stopSimple.Text = "PAUSE";
            this.stopSimple.UseVisualStyleBackColor = true;
            this.stopSimple.Click += new System.EventHandler(this.stopSimple_Click);
            // 
            // outputSimple
            // 
            this.outputSimple.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputSimple.Location = new System.Drawing.Point(110, 206);
            this.outputSimple.MaximumSize = new System.Drawing.Size(150, 40);
            this.outputSimple.MinimumSize = new System.Drawing.Size(50, 40);
            this.outputSimple.Name = "outputSimple";
            this.outputSimple.ReadOnly = true;
            this.outputSimple.Size = new System.Drawing.Size(150, 20);
            this.outputSimple.TabIndex = 8;
            // 
            // startFib
            // 
            this.startFib.Location = new System.Drawing.Point(449, 88);
            this.startFib.Name = "startFib";
            this.startFib.Size = new System.Drawing.Size(100, 32);
            this.startFib.TabIndex = 9;
            this.startFib.Text = "START";
            this.startFib.UseVisualStyleBackColor = true;
            this.startFib.Click += new System.EventHandler(this.startFib_Click);
            // 
            // stopFib
            // 
            this.stopFib.Location = new System.Drawing.Point(596, 88);
            this.stopFib.Name = "stopFib";
            this.stopFib.Size = new System.Drawing.Size(100, 32);
            this.stopFib.TabIndex = 10;
            this.stopFib.Text = "PAUSE";
            this.stopFib.UseVisualStyleBackColor = true;
            this.stopFib.Click += new System.EventHandler(this.stopFib_Click);
            // 
            // outputFib
            // 
            this.outputFib.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputFib.Location = new System.Drawing.Point(497, 149);
            this.outputFib.MaximumSize = new System.Drawing.Size(150, 40);
            this.outputFib.MinimumSize = new System.Drawing.Size(50, 40);
            this.outputFib.Name = "outputFib";
            this.outputFib.ReadOnly = true;
            this.outputFib.Size = new System.Drawing.Size(150, 20);
            this.outputFib.TabIndex = 11;
            // 
            // Restart
            // 
            this.Restart.Location = new System.Drawing.Point(327, 317);
            this.Restart.Name = "Restart";
            this.Restart.Size = new System.Drawing.Size(153, 52);
            this.Restart.TabIndex = 12;
            this.Restart.Text = "RESTART";
            this.Restart.UseVisualStyleBackColor = true;
            this.Restart.Click += new System.EventHandler(this.Restart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Restart);
            this.Controls.Add(this.outputFib);
            this.Controls.Add(this.stopFib);
            this.Controls.Add(this.startFib);
            this.Controls.Add(this.outputSimple);
            this.Controls.Add(this.stopSimple);
            this.Controls.Add(this.startSimple);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.maxInput);
            this.Controls.Add(this.minInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox minInput;
        private System.Windows.Forms.TextBox maxInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button startSimple;
        private System.Windows.Forms.Button stopSimple;
        private System.Windows.Forms.TextBox outputSimple;
        private System.Windows.Forms.Button startFib;
        private System.Windows.Forms.Button stopFib;
        private System.Windows.Forms.TextBox outputFib;
        private System.Windows.Forms.Button Restart;
    }
}

