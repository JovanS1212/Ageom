namespace AgeomProj
{
    partial class frmUvod
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
            this.lblIgraj = new System.Windows.Forms.Label();
            this.btnFormule = new System.Windows.Forms.Button();
            this.btnSveska = new System.Windows.Forms.Button();
            this.pnlSveska = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblIgraj
            // 
            this.lblIgraj.AutoSize = true;
            this.lblIgraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIgraj.Location = new System.Drawing.Point(638, 277);
            this.lblIgraj.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIgraj.Name = "lblIgraj";
            this.lblIgraj.Size = new System.Drawing.Size(95, 31);
            this.lblIgraj.TabIndex = 0;
            this.lblIgraj.Text = "IGRAJ";
            this.lblIgraj.Click += new System.EventHandler(this.lblIgraj_Click);
            // 
            // btnFormule
            // 
            this.btnFormule.BackColor = System.Drawing.Color.Transparent;
            this.btnFormule.Location = new System.Drawing.Point(780, 527);
            this.btnFormule.Margin = new System.Windows.Forms.Padding(4);
            this.btnFormule.Name = "btnFormule";
            this.btnFormule.Size = new System.Drawing.Size(100, 28);
            this.btnFormule.TabIndex = 1;
            this.btnFormule.Text = "Formule";
            this.btnFormule.UseVisualStyleBackColor = false;
            this.btnFormule.Click += new System.EventHandler(this.btnFormule_Click);
            // 
            // btnSveska
            // 
            this.btnSveska.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSveska.Location = new System.Drawing.Point(45, 12);
            this.btnSveska.Name = "btnSveska";
            this.btnSveska.Size = new System.Drawing.Size(122, 51);
            this.btnSveska.TabIndex = 2;
            this.btnSveska.Text = "SVESKA";
            this.btnSveska.UseVisualStyleBackColor = true;
            this.btnSveska.Click += new System.EventHandler(this.btnSveska_Click);
            // 
            // pnlSveska
            // 
            this.pnlSveska.Enabled = false;
            this.pnlSveska.Location = new System.Drawing.Point(356, 35);
            this.pnlSveska.Name = "pnlSveska";
            this.pnlSveska.Size = new System.Drawing.Size(40, 28);
            this.pnlSveska.TabIndex = 3;
            this.pnlSveska.Visible = false;
            this.pnlSveska.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlSveska_Paint);
            this.pnlSveska.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlSveska_MouseDown);
            this.pnlSveska.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlSveska_MouseMove);
            this.pnlSveska.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlSveska_MouseUp);
            // 
            // frmUvod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1373, 775);
            this.Controls.Add(this.lblIgraj);
            this.Controls.Add(this.btnSveska);
            this.Controls.Add(this.pnlSveska);
            this.Controls.Add(this.btnFormule);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmUvod";
            this.Text = "Ageom";
            this.Load += new System.EventHandler(this.frmUvod_Load);
            this.ResizeEnd += new System.EventHandler(this.frmUvod_ResizeEnd);
            this.SizeChanged += new System.EventHandler(this.frmUvod_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmUvod_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.frmUvod_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIgraj;
        private System.Windows.Forms.Button btnFormule;
        private System.Windows.Forms.Button btnSveska;
        private System.Windows.Forms.Panel pnlSveska;
    }
}

