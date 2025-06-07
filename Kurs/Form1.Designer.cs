namespace Kurs
{
    partial class FormBase
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButtonFull = new System.Windows.Forms.RadioButton();
            this.radioButtonRand = new System.Windows.Forms.RadioButton();
            this.radioButtonOne = new System.Windows.Forms.RadioButton();
            this.radioButtonFractional = new System.Windows.Forms.RadioButton();
            this.radioButtonLat = new System.Windows.Forms.RadioButton();
            this.buttonFill = new System.Windows.Forms.Button();
            this.labelA = new System.Windows.Forms.Label();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.labelB = new System.Windows.Forms.Label();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.labelC = new System.Windows.Forms.Label();
            this.textBoxD = new System.Windows.Forms.TextBox();
            this.labelD = new System.Windows.Forms.Label();
            this.textBoxE = new System.Windows.Forms.TextBox();
            this.labelE = new System.Windows.Forms.Label();
            this.buttonPlan = new System.Windows.Forms.Button();
            this.labelError = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReferenceFill = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(519, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Количество факторов (1-5):";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(710, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(24, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(505, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Заполните факторное пространство";
            this.label2.Visible = false;
            // 
            // radioButtonFull
            // 
            this.radioButtonFull.AutoSize = true;
            this.radioButtonFull.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.radioButtonFull.Location = new System.Drawing.Point(12, 32);
            this.radioButtonFull.Name = "radioButtonFull";
            this.radioButtonFull.Size = new System.Drawing.Size(246, 21);
            this.radioButtonFull.TabIndex = 4;
            this.radioButtonFull.TabStop = true;
            this.radioButtonFull.Text = "Полный факторный эксперимент";
            this.radioButtonFull.UseVisualStyleBackColor = true;
            this.radioButtonFull.CheckedChanged += new System.EventHandler(this.radioButtonFull_CheckedChanged);
            // 
            // radioButtonRand
            // 
            this.radioButtonRand.AutoSize = true;
            this.radioButtonRand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.radioButtonRand.Location = new System.Drawing.Point(12, 78);
            this.radioButtonRand.Name = "radioButtonRand";
            this.radioButtonRand.Size = new System.Drawing.Size(200, 21);
            this.radioButtonRand.TabIndex = 5;
            this.radioButtonRand.TabStop = true;
            this.radioButtonRand.Text = "Рандомизированный план";
            this.radioButtonRand.UseVisualStyleBackColor = true;
            this.radioButtonRand.CheckedChanged += new System.EventHandler(this.radioButtonRand_CheckedChanged);
            // 
            // radioButtonOne
            // 
            this.radioButtonOne.AutoSize = true;
            this.radioButtonOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.radioButtonOne.Location = new System.Drawing.Point(12, 126);
            this.radioButtonOne.Name = "radioButtonOne";
            this.radioButtonOne.Size = new System.Drawing.Size(342, 21);
            this.radioButtonOne.TabIndex = 6;
            this.radioButtonOne.TabStop = true;
            this.radioButtonOne.Text = "Эксперимент с изменением фактора по одному";
            this.radioButtonOne.UseVisualStyleBackColor = true;
            this.radioButtonOne.CheckedChanged += new System.EventHandler(this.radioButtonOne_CheckedChanged);
            // 
            // radioButtonFractional
            // 
            this.radioButtonFractional.AutoSize = true;
            this.radioButtonFractional.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.radioButtonFractional.Location = new System.Drawing.Point(12, 179);
            this.radioButtonFractional.Name = "radioButtonFractional";
            this.radioButtonFractional.Size = new System.Drawing.Size(255, 21);
            this.radioButtonFractional.TabIndex = 7;
            this.radioButtonFractional.TabStop = true;
            this.radioButtonFractional.Text = "Дробный факторный эксперимент";
            this.radioButtonFractional.UseVisualStyleBackColor = true;
            this.radioButtonFractional.CheckedChanged += new System.EventHandler(this.radioButtonFractional_CheckedChanged);
            // 
            // radioButtonLat
            // 
            this.radioButtonLat.AutoSize = true;
            this.radioButtonLat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.radioButtonLat.Location = new System.Drawing.Point(12, 229);
            this.radioButtonLat.Name = "radioButtonLat";
            this.radioButtonLat.Size = new System.Drawing.Size(154, 21);
            this.radioButtonLat.TabIndex = 8;
            this.radioButtonLat.TabStop = true;
            this.radioButtonLat.Text = "Латинский квадрат";
            this.radioButtonLat.UseVisualStyleBackColor = true;
            this.radioButtonLat.CheckedChanged += new System.EventHandler(this.radioButtonLat_CheckedChanged);
            // 
            // buttonFill
            // 
            this.buttonFill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.buttonFill.Location = new System.Drawing.Point(514, 57);
            this.buttonFill.Name = "buttonFill";
            this.buttonFill.Size = new System.Drawing.Size(226, 23);
            this.buttonFill.TabIndex = 10;
            this.buttonFill.Text = "Заполнить количество уровней";
            this.buttonFill.UseVisualStyleBackColor = true;
            this.buttonFill.Visible = false;
            this.buttonFill.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelA.Location = new System.Drawing.Point(365, 125);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(71, 16);
            this.labelA.TabIndex = 11;
            this.labelA.Text = "Фактор A:";
            this.labelA.Visible = false;
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(442, 125);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(159, 20);
            this.textBoxA.TabIndex = 12;
            this.textBoxA.Visible = false;
            this.textBoxA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxA_KeyPress);
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(442, 156);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(159, 20);
            this.textBoxB.TabIndex = 14;
            this.textBoxB.Visible = false;
            this.textBoxB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxB_KeyPress);
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelB.Location = new System.Drawing.Point(365, 156);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(71, 16);
            this.labelB.TabIndex = 13;
            this.labelB.Text = "Фактор B:";
            this.labelB.Visible = false;
            // 
            // textBoxC
            // 
            this.textBoxC.Location = new System.Drawing.Point(442, 186);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(159, 20);
            this.textBoxC.TabIndex = 16;
            this.textBoxC.Visible = false;
            this.textBoxC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxC_KeyPress);
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelC.Location = new System.Drawing.Point(365, 186);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(71, 16);
            this.labelC.TabIndex = 15;
            this.labelC.Text = "Фактор C:";
            this.labelC.Visible = false;
            // 
            // textBoxD
            // 
            this.textBoxD.Location = new System.Drawing.Point(685, 126);
            this.textBoxD.Name = "textBoxD";
            this.textBoxD.Size = new System.Drawing.Size(159, 20);
            this.textBoxD.TabIndex = 18;
            this.textBoxD.Visible = false;
            this.textBoxD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxD_KeyPress);
            // 
            // labelD
            // 
            this.labelD.AutoSize = true;
            this.labelD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelD.Location = new System.Drawing.Point(607, 125);
            this.labelD.Name = "labelD";
            this.labelD.Size = new System.Drawing.Size(72, 16);
            this.labelD.TabIndex = 17;
            this.labelD.Text = "Фактор D:";
            this.labelD.Visible = false;
            // 
            // textBoxE
            // 
            this.textBoxE.Location = new System.Drawing.Point(685, 157);
            this.textBoxE.Name = "textBoxE";
            this.textBoxE.Size = new System.Drawing.Size(159, 20);
            this.textBoxE.TabIndex = 20;
            this.textBoxE.Visible = false;
            this.textBoxE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxE_KeyPress);
            // 
            // labelE
            // 
            this.labelE.AutoSize = true;
            this.labelE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelE.Location = new System.Drawing.Point(608, 158);
            this.labelE.Name = "labelE";
            this.labelE.Size = new System.Drawing.Size(71, 16);
            this.labelE.TabIndex = 19;
            this.labelE.Text = "Фактор E:";
            this.labelE.Visible = false;
            // 
            // buttonPlan
            // 
            this.buttonPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.buttonPlan.Location = new System.Drawing.Point(508, 242);
            this.buttonPlan.Name = "buttonPlan";
            this.buttonPlan.Size = new System.Drawing.Size(226, 23);
            this.buttonPlan.TabIndex = 22;
            this.buttonPlan.Text = "Составить план";
            this.buttonPlan.UseVisualStyleBackColor = true;
            this.buttonPlan.Visible = false;
            this.buttonPlan.Click += new System.EventHandler(this.buttonPlan_Click);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(480, 268);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(290, 16);
            this.labelError.TabIndex = 23;
            this.labelError.Text = "Необходимо заполнить все поля для ввода";
            this.labelError.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(856, 24);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ReferenceFill});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // ReferenceFill
            // 
            this.ReferenceFill.Name = "ReferenceFill";
            this.ReferenceFill.Size = new System.Drawing.Size(288, 22);
            this.ReferenceFill.Text = "Заполнение факторного пространства";
            this.ReferenceFill.Click += new System.EventHandler(this.ReferenceFill_Click);
            // 
            // FormBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(856, 294);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.buttonPlan);
            this.Controls.Add(this.buttonFill);
            this.Controls.Add(this.textBoxE);
            this.Controls.Add(this.labelE);
            this.Controls.Add(this.textBoxD);
            this.Controls.Add(this.labelD);
            this.Controls.Add(this.textBoxC);
            this.Controls.Add(this.labelC);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.radioButtonLat);
            this.Controls.Add(this.radioButtonFractional);
            this.Controls.Add(this.radioButtonOne);
            this.Controls.Add(this.radioButtonRand);
            this.Controls.Add(this.radioButtonFull);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormBase";
            this.Text = "Планирование модельных экспериментов";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButtonFull;
        private System.Windows.Forms.RadioButton radioButtonRand;
        private System.Windows.Forms.RadioButton radioButtonOne;
        private System.Windows.Forms.RadioButton radioButtonFractional;
        private System.Windows.Forms.RadioButton radioButtonLat;
        private System.Windows.Forms.Button buttonFill;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.TextBox textBoxC;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.TextBox textBoxD;
        private System.Windows.Forms.Label labelD;
        private System.Windows.Forms.TextBox textBoxE;
        private System.Windows.Forms.Label labelE;
        private System.Windows.Forms.Button buttonPlan;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReferenceFill;
    }
}

