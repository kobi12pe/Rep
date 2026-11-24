namespace TraficLight
{
    partial class Form1
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
            this.tmrLight = new System.Windows.Forms.Timer(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.pnlRed = new System.Windows.Forms.Panel();
            this.pnlYellow = new System.Windows.Forms.Panel();
            this.pnlGreen = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // tmrLight
            // 
            this.tmrLight.Tick += new System.EventHandler(this.tmrLight_Tick);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(120, 94);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(120, 161);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(120, 240);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // pnlRed
            // 
            this.pnlRed.Location = new System.Drawing.Point(503, 36);
            this.pnlRed.Name = "pnlRed";
            this.pnlRed.Size = new System.Drawing.Size(200, 100);
            this.pnlRed.TabIndex = 3;
            // 
            // pnlYellow
            // 
            this.pnlYellow.Location = new System.Drawing.Point(503, 163);
            this.pnlYellow.Name = "pnlYellow";
            this.pnlYellow.Size = new System.Drawing.Size(200, 100);
            this.pnlYellow.TabIndex = 4;
            // 
            // pnlGreen
            // 
            this.pnlGreen.Location = new System.Drawing.Point(503, 296);
            this.pnlGreen.Name = "pnlGreen";
            this.pnlGreen.Size = new System.Drawing.Size(200, 100);
            this.pnlGreen.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlGreen);
            this.Controls.Add(this.pnlYellow);
            this.Controls.Add(this.pnlRed);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Trafic Light";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmrLight;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Panel pnlRed;
        private System.Windows.Forms.Panel pnlYellow;
        private System.Windows.Forms.Panel pnlGreen;
    }
}

