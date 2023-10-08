namespace Stopwatch
{
    partial class Stopwatch
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonMulai = new System.Windows.Forms.Button();
            this.buttonBerhenti = new System.Windows.Forms.Button();
            this.labelstopwatch = new System.Windows.Forms.Label();
            this.timerstopwatch = new System.Windows.Forms.Timer(this.components);
            this.labelMenit = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelDetik = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonMulai
            // 
            this.buttonMulai.Location = new System.Drawing.Point(202, 238);
            this.buttonMulai.Name = "buttonMulai";
            this.buttonMulai.Size = new System.Drawing.Size(94, 29);
            this.buttonMulai.TabIndex = 0;
            this.buttonMulai.Text = "Mulai";
            this.buttonMulai.UseVisualStyleBackColor = true;
            this.buttonMulai.Click += new System.EventHandler(this.buttonMulai_Click);
            // 
            // buttonBerhenti
            // 
            this.buttonBerhenti.Location = new System.Drawing.Point(468, 238);
            this.buttonBerhenti.Name = "buttonBerhenti";
            this.buttonBerhenti.Size = new System.Drawing.Size(94, 29);
            this.buttonBerhenti.TabIndex = 1;
            this.buttonBerhenti.Text = "berhenti";
            this.buttonBerhenti.UseVisualStyleBackColor = true;
            this.buttonBerhenti.Click += new System.EventHandler(this.buttonBerhenti_Click);
            // 
            // labelstopwatch
            // 
            this.labelstopwatch.AutoSize = true;
            this.labelstopwatch.Location = new System.Drawing.Point(2, 43);
            this.labelstopwatch.Name = "labelstopwatch";
            this.labelstopwatch.Size = new System.Drawing.Size(110, 20);
            this.labelstopwatch.TabIndex = 2;
            this.labelstopwatch.Text = "labelstopwatch";
            // 
            // timerstopwatch
            // 
            this.timerstopwatch.Tick += new System.EventHandler(this.timerstopwatch_Tick);
            // 
            // labelMenit
            // 
            this.labelMenit.AutoSize = true;
            this.labelMenit.Location = new System.Drawing.Point(322, 103);
            this.labelMenit.Name = "labelMenit";
            this.labelMenit.Size = new System.Drawing.Size(17, 20);
            this.labelMenit.TabIndex = 3;
            this.labelMenit.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(371, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = ":";
            // 
            // labelDetik
            // 
            this.labelDetik.AutoSize = true;
            this.labelDetik.Location = new System.Drawing.Point(410, 103);
            this.labelDetik.Name = "labelDetik";
            this.labelDetik.Size = new System.Drawing.Size(17, 20);
            this.labelDetik.TabIndex = 5;
            this.labelDetik.Text = "0";
            // 
            // Stopwatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelDetik);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelMenit);
            this.Controls.Add(this.labelstopwatch);
            this.Controls.Add(this.buttonBerhenti);
            this.Controls.Add(this.buttonMulai);
            this.Name = "Stopwatch";
            this.Text = "Stopwatch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonMulai;
        private Button buttonBerhenti;
        private Label labelstopwatch;
        private System.Windows.Forms.Timer timerstopwatch;
        private Label labelMenit;
        private Label label2;
        private Label labelDetik;
    }
}