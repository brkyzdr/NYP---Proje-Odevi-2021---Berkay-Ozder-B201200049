
namespace Savas.Desktop
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelWarPlace = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelScor = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panelWarPlace.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelWarPlace
            // 
            this.panelWarPlace.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelWarPlace.Controls.Add(this.label4);
            this.panelWarPlace.Controls.Add(this.labelTime);
            this.panelWarPlace.Controls.Add(this.labelScor);
            this.panelWarPlace.Controls.Add(this.label7);
            this.panelWarPlace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWarPlace.Location = new System.Drawing.Point(0, 0);
            this.panelWarPlace.Name = "panelWarPlace";
            this.panelWarPlace.Size = new System.Drawing.Size(1400, 700);
            this.panelWarPlace.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("AlphaSmart 3000", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(577, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "SÜRE";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTime
            // 
            this.labelTime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTime.BackColor = System.Drawing.SystemColors.Control;
            this.labelTime.Font = new System.Drawing.Font("AlphaSmart 3000", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelTime.Location = new System.Drawing.Point(577, 36);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(100, 23);
            this.labelTime.TabIndex = 7;
            this.labelTime.Text = "0:00";
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelScor
            // 
            this.labelScor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelScor.BackColor = System.Drawing.SystemColors.Control;
            this.labelScor.Font = new System.Drawing.Font("AlphaSmart 3000", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelScor.Location = new System.Drawing.Point(673, 36);
            this.labelScor.Name = "labelScor";
            this.labelScor.Size = new System.Drawing.Size(100, 23);
            this.labelScor.TabIndex = 8;
            this.labelScor.Text = "0";
            this.labelScor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Font = new System.Drawing.Font("AlphaSmart 3000", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(673, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 9;
            this.label7.Text = "SKOR";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 700);
            this.Controls.Add(this.panelWarPlace);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AnaForm_KeyDown);
            this.panelWarPlace.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelWarPlace;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelScor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
    }
}

