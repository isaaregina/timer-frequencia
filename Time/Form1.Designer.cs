namespace Time
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStart = new System.Windows.Forms.Button();
            this.txtFrequencia = new System.Windows.Forms.TextBox();
            this.Frequencia = new System.Windows.Forms.Label();
            this.tempo = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.espaco = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnStart.Font = new System.Drawing.Font("JetBrains Mono", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnStart.Location = new System.Drawing.Point(176, 340);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(128, 50);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtFrequencia
            // 
            this.txtFrequencia.Font = new System.Drawing.Font("JetBrains Mono", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFrequencia.Location = new System.Drawing.Point(409, 273);
            this.txtFrequencia.Multiline = true;
            this.txtFrequencia.Name = "txtFrequencia";
            this.txtFrequencia.Size = new System.Drawing.Size(154, 32);
            this.txtFrequencia.TabIndex = 2;
            this.txtFrequencia.TextChanged += new System.EventHandler(this.txtFrequencia_TextChanged);
            // 
            // Frequencia
            // 
            this.Frequencia.AutoSize = true;
            this.Frequencia.Font = new System.Drawing.Font("JetBrains Mono", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Frequencia.ForeColor = System.Drawing.Color.White;
            this.Frequencia.Location = new System.Drawing.Point(235, 273);
            this.Frequencia.Name = "Frequencia";
            this.Frequencia.Size = new System.Drawing.Size(168, 31);
            this.Frequencia.TabIndex = 3;
            this.Frequencia.Text = "Frequência:";
            // 
            // tempo
            // 
            this.tempo.AutoSize = true;
            this.tempo.BackColor = System.Drawing.Color.SlateBlue;
            this.tempo.Font = new System.Drawing.Font("JetBrains Mono", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempo.ForeColor = System.Drawing.Color.White;
            this.tempo.Location = new System.Drawing.Point(224, 130);
            this.tempo.Name = "tempo";
            this.tempo.Size = new System.Drawing.Size(375, 63);
            this.tempo.TabIndex = 4;
            this.tempo.Text = "00 : 00 : 00";
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnStop.Font = new System.Drawing.Font("JetBrains Mono", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnStop.Location = new System.Drawing.Point(345, 340);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(128, 50);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "STOP";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnReset.Font = new System.Drawing.Font("JetBrains Mono", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnReset.Location = new System.Drawing.Point(520, 340);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(128, 50);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnExit.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExit.Location = new System.Drawing.Point(693, 400);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(95, 38);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // espaco
            // 
            this.espaco.AutoSize = true;
            this.espaco.BackColor = System.Drawing.Color.SlateBlue;
            this.espaco.Font = new System.Drawing.Font("Microsoft Sans Serif", 79.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.espaco.ForeColor = System.Drawing.Color.SlateBlue;
            this.espaco.Location = new System.Drawing.Point(197, 78);
            this.espaco.Name = "espaco";
            this.espaco.Size = new System.Drawing.Size(425, 153);
            this.espaco.TabIndex = 8;
            this.espaco.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.tempo);
            this.Controls.Add(this.Frequencia);
            this.Controls.Add(this.txtFrequencia);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.espaco);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "TIMER";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStart;
        public System.Windows.Forms.TextBox txtFrequencia;
        private System.Windows.Forms.Label Frequencia;
        public System.Windows.Forms.Label tempo;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label espaco;
    }
}

