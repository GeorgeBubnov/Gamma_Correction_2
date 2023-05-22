
namespace Gamma_Correction_2
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
            this.inputPicture = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnOFD = new System.Windows.Forms.Button();
            this.btnCorrect = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numGamma = new System.Windows.Forms.NumericUpDown();
            this.outputPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.inputPicture)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGamma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // inputPicture
            // 
            this.inputPicture.Location = new System.Drawing.Point(0, 0);
            this.inputPicture.Margin = new System.Windows.Forms.Padding(2);
            this.inputPicture.Name = "inputPicture";
            this.inputPicture.Size = new System.Drawing.Size(400, 370);
            this.inputPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.inputPicture.TabIndex = 8;
            this.inputPicture.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.progressBar1.Location = new System.Drawing.Point(0, 0);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(800, 22);
            this.progressBar1.TabIndex = 10;
            // 
            // btnOFD
            // 
            this.btnOFD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOFD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOFD.Location = new System.Drawing.Point(190, 39);
            this.btnOFD.Margin = new System.Windows.Forms.Padding(2);
            this.btnOFD.Name = "btnOFD";
            this.btnOFD.Size = new System.Drawing.Size(190, 30);
            this.btnOFD.TabIndex = 9;
            this.btnOFD.Text = "Открыть изображение";
            this.btnOFD.UseVisualStyleBackColor = true;
            this.btnOFD.Click += new System.EventHandler(this.btnOFD_Click);
            // 
            // btnCorrect
            // 
            this.btnCorrect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCorrect.Location = new System.Drawing.Point(384, 39);
            this.btnCorrect.Margin = new System.Windows.Forms.Padding(2);
            this.btnCorrect.Name = "btnCorrect";
            this.btnCorrect.Size = new System.Drawing.Size(143, 30);
            this.btnCorrect.TabIndex = 11;
            this.btnCorrect.Text = "Изменить гамму";
            this.btnCorrect.UseVisualStyleBackColor = true;
            this.btnCorrect.Click += new System.EventHandler(this.btnCorrect_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numGamma);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.btnCorrect);
            this.panel1.Controls.Add(this.btnOFD);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 370);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 80);
            this.panel1.TabIndex = 12;
            // 
            // numGamma
            // 
            this.numGamma.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numGamma.DecimalPlaces = 1;
            this.numGamma.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numGamma.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numGamma.Location = new System.Drawing.Point(532, 39);
            this.numGamma.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            65536});
            this.numGamma.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numGamma.Name = "numGamma";
            this.numGamma.Size = new System.Drawing.Size(67, 29);
            this.numGamma.TabIndex = 12;
            this.numGamma.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // outputPicture
            // 
            this.outputPicture.Location = new System.Drawing.Point(400, 0);
            this.outputPicture.Margin = new System.Windows.Forms.Padding(2);
            this.outputPicture.Name = "outputPicture";
            this.outputPicture.Size = new System.Drawing.Size(400, 370);
            this.outputPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.outputPicture.TabIndex = 13;
            this.outputPicture.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.outputPicture);
            this.Controls.Add(this.inputPicture);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Гамма-коррекция";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.inputPicture)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numGamma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox inputPicture;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnOFD;
        private System.Windows.Forms.Button btnCorrect;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numGamma;
        private System.Windows.Forms.PictureBox outputPicture;
    }
}

