
namespace Filosofiya
{
    partial class Предпочтения
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
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxNewTime = new System.Windows.Forms.CheckBox();
            this.checkBoxMiddleAges = new System.Windows.Forms.CheckBox();
            this.checkBoxAntique = new System.Windows.Forms.CheckBox();
            this.checkBoxMater = new System.Windows.Forms.CheckBox();
            this.checkBoxIdeal = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(382, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Выбрать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(465, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "По эпохам:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(273, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "По типам мировоззрения:";
            // 
            // checkBoxNewTime
            // 
            this.checkBoxNewTime.AutoSize = true;
            this.checkBoxNewTime.BackColor = System.Drawing.Color.White;
            this.checkBoxNewTime.Location = new System.Drawing.Point(469, 140);
            this.checkBoxNewTime.Name = "checkBoxNewTime";
            this.checkBoxNewTime.Size = new System.Drawing.Size(171, 17);
            this.checkBoxNewTime.TabIndex = 14;
            this.checkBoxNewTime.Text = "Философы Нового Времени";
            this.checkBoxNewTime.UseVisualStyleBackColor = false;
            // 
            // checkBoxMiddleAges
            // 
            this.checkBoxMiddleAges.AutoSize = true;
            this.checkBoxMiddleAges.BackColor = System.Drawing.Color.White;
            this.checkBoxMiddleAges.Location = new System.Drawing.Point(469, 117);
            this.checkBoxMiddleAges.Name = "checkBoxMiddleAges";
            this.checkBoxMiddleAges.Size = new System.Drawing.Size(164, 17);
            this.checkBoxMiddleAges.TabIndex = 13;
            this.checkBoxMiddleAges.Text = "Средневековые философы";
            this.checkBoxMiddleAges.UseVisualStyleBackColor = false;
            // 
            // checkBoxAntique
            // 
            this.checkBoxAntique.AutoSize = true;
            this.checkBoxAntique.BackColor = System.Drawing.Color.White;
            this.checkBoxAntique.Location = new System.Drawing.Point(469, 94);
            this.checkBoxAntique.Name = "checkBoxAntique";
            this.checkBoxAntique.Size = new System.Drawing.Size(132, 17);
            this.checkBoxAntique.TabIndex = 12;
            this.checkBoxAntique.Text = "Античные философы";
            this.checkBoxAntique.UseVisualStyleBackColor = false;
            // 
            // checkBoxMater
            // 
            this.checkBoxMater.AutoSize = true;
            this.checkBoxMater.BackColor = System.Drawing.Color.White;
            this.checkBoxMater.Location = new System.Drawing.Point(290, 127);
            this.checkBoxMater.Name = "checkBoxMater";
            this.checkBoxMater.Size = new System.Drawing.Size(96, 17);
            this.checkBoxMater.TabIndex = 11;
            this.checkBoxMater.Text = "Материализм";
            this.checkBoxMater.UseVisualStyleBackColor = false;
            // 
            // checkBoxIdeal
            // 
            this.checkBoxIdeal.AutoSize = true;
            this.checkBoxIdeal.BackColor = System.Drawing.Color.White;
            this.checkBoxIdeal.Location = new System.Drawing.Point(290, 104);
            this.checkBoxIdeal.Name = "checkBoxIdeal";
            this.checkBoxIdeal.Size = new System.Drawing.Size(78, 17);
            this.checkBoxIdeal.TabIndex = 10;
            this.checkBoxIdeal.Text = "Идеализм";
            this.checkBoxIdeal.UseVisualStyleBackColor = false;
            // 
            // Предпочтения
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(913, 488);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBoxNewTime);
            this.Controls.Add(this.checkBoxMiddleAges);
            this.Controls.Add(this.checkBoxAntique);
            this.Controls.Add(this.checkBoxMater);
            this.Controls.Add(this.checkBoxIdeal);
            this.Controls.Add(this.button1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Предпочтения";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выберите предпочтения:";
            this.Load += new System.EventHandler(this.Предпочтения_Load);
            this.Validating += new System.ComponentModel.CancelEventHandler(this.Предпочтения_Validating);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxNewTime;
        private System.Windows.Forms.CheckBox checkBoxMiddleAges;
        private System.Windows.Forms.CheckBox checkBoxAntique;
        private System.Windows.Forms.CheckBox checkBoxMater;
        private System.Windows.Forms.CheckBox checkBoxIdeal;
    }
}

