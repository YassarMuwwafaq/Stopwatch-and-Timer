namespace Stopwatch
{
    partial class formtimer
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
            this.labelmenit = new System.Windows.Forms.Label();
            this.labeldetik = new System.Windows.Forms.Label();
            this.labelTimerMenit = new System.Windows.Forms.Label();
            this.labelTimerDetik = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxMenit = new System.Windows.Forms.TextBox();
            this.textBoxDetik = new System.Windows.Forms.TextBox();
            this.buttonmulai = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelmenit
            // 
            this.labelmenit.AutoSize = true;
            this.labelmenit.Location = new System.Drawing.Point(30, 28);
            this.labelmenit.Name = "labelmenit";
            this.labelmenit.Size = new System.Drawing.Size(47, 20);
            this.labelmenit.TabIndex = 0;
            this.labelmenit.Text = "Menit";
            // 
            // labeldetik
            // 
            this.labeldetik.AutoSize = true;
            this.labeldetik.Location = new System.Drawing.Point(30, 79);
            this.labeldetik.Name = "labeldetik";
            this.labeldetik.Size = new System.Drawing.Size(44, 20);
            this.labeldetik.TabIndex = 1;
            this.labeldetik.Text = "Detik";
            // 
            // labelTimerMenit
            // 
            this.labelTimerMenit.AutoSize = true;
            this.labelTimerMenit.Location = new System.Drawing.Point(115, 157);
            this.labelTimerMenit.Name = "labelTimerMenit";
            this.labelTimerMenit.Size = new System.Drawing.Size(17, 20);
            this.labelTimerMenit.TabIndex = 2;
            this.labelTimerMenit.Text = "0";
            // 
            // labelTimerDetik
            // 
            this.labelTimerDetik.AutoSize = true;
            this.labelTimerDetik.Location = new System.Drawing.Point(188, 157);
            this.labelTimerDetik.Name = "labelTimerDetik";
            this.labelTimerDetik.Size = new System.Drawing.Size(17, 20);
            this.labelTimerDetik.TabIndex = 3;
            this.labelTimerDetik.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(156, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = ":";
            // 
            // textBoxMenit
            // 
            this.textBoxMenit.Location = new System.Drawing.Point(87, 28);
            this.textBoxMenit.Name = "textBoxMenit";
            this.textBoxMenit.Size = new System.Drawing.Size(45, 27);
            this.textBoxMenit.TabIndex = 5;
            this.textBoxMenit.Text = "1";
            // 
            // textBoxDetik
            // 
            this.textBoxDetik.Location = new System.Drawing.Point(87, 79);
            this.textBoxDetik.Name = "textBoxDetik";
            this.textBoxDetik.Size = new System.Drawing.Size(45, 27);
            this.textBoxDetik.TabIndex = 6;
            this.textBoxDetik.Text = "15";
            // 
            // buttonmulai
            // 
            this.buttonmulai.Location = new System.Drawing.Point(239, 53);
            this.buttonmulai.Name = "buttonmulai";
            this.buttonmulai.Size = new System.Drawing.Size(94, 29);
            this.buttonmulai.TabIndex = 7;
            this.buttonmulai.Text = "Mulai";
            this.buttonmulai.UseVisualStyleBackColor = true;
            this.buttonmulai.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // formtimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 253);
            this.Controls.Add(this.buttonmulai);
            this.Controls.Add(this.textBoxDetik);
            this.Controls.Add(this.textBoxMenit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelTimerDetik);
            this.Controls.Add(this.labelTimerMenit);
            this.Controls.Add(this.labeldetik);
            this.Controls.Add(this.labelmenit);
            this.Name = "formtimer";
            this.Text = "formtimer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelmenit;
        private Label labeldetik;
        private Label labelTimerMenit;
        private Label labelTimerDetik;
        private Label label5;
        private TextBox textBoxMenit;
        private TextBox textBoxDetik;
        private Button buttonmulai;
        private System.Windows.Forms.Timer timer1;
    }
}