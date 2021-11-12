
namespace _8.hét
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
            this.mainpanel = new System.Windows.Forms.Panel();
            this.createTimer = new System.Windows.Forms.Timer(this.components);
            this.conveyorTimer = new System.Windows.Forms.Timer(this.components);
            this.btncar = new System.Windows.Forms.Button();
            this.btnball = new System.Windows.Forms.Button();
            this.lblnext = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnpresent = new System.Windows.Forms.Button();
            this.btncolorribben = new System.Windows.Forms.Button();
            this.btncolorbox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainpanel
            // 
            this.mainpanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainpanel.Location = new System.Drawing.Point(0, 80);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(775, 277);
            this.mainpanel.TabIndex = 0;
            // 
            // createTimer
            // 
            this.createTimer.Enabled = true;
            this.createTimer.Interval = 3000;
            this.createTimer.Tick += new System.EventHandler(this.createTimer_Tick);
            // 
            // conveyorTimer
            // 
            this.conveyorTimer.Enabled = true;
            this.conveyorTimer.Interval = 10;
            this.conveyorTimer.Tick += new System.EventHandler(this.conveyorTimer_Tick);
            // 
            // btncar
            // 
            this.btncar.Location = new System.Drawing.Point(13, 13);
            this.btncar.Name = "btncar";
            this.btncar.Size = new System.Drawing.Size(75, 61);
            this.btncar.TabIndex = 1;
            this.btncar.Text = "Car";
            this.btncar.UseVisualStyleBackColor = true;
            this.btncar.Click += new System.EventHandler(this.btncar_Click);
            // 
            // btnball
            // 
            this.btnball.Location = new System.Drawing.Point(95, 12);
            this.btnball.Name = "btnball";
            this.btnball.Size = new System.Drawing.Size(75, 62);
            this.btnball.TabIndex = 2;
            this.btnball.Text = "Ball";
            this.btnball.UseVisualStyleBackColor = true;
            this.btnball.Click += new System.EventHandler(this.btnball_Click);
            // 
            // lblnext
            // 
            this.lblnext.AutoSize = true;
            this.lblnext.Location = new System.Drawing.Point(558, -2);
            this.lblnext.Name = "lblnext";
            this.lblnext.Size = new System.Drawing.Size(65, 13);
            this.lblnext.TabIndex = 3;
            this.lblnext.Text = "Coming next";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.Location = new System.Drawing.Point(291, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnpresent
            // 
            this.btnpresent.Location = new System.Drawing.Point(176, 12);
            this.btnpresent.Name = "btnpresent";
            this.btnpresent.Size = new System.Drawing.Size(76, 62);
            this.btnpresent.TabIndex = 5;
            this.btnpresent.Text = "Present";
            this.btnpresent.UseVisualStyleBackColor = true;
            this.btnpresent.Click += new System.EventHandler(this.btnpresent_Click);
            // 
            // btncolorribben
            // 
            this.btncolorribben.BackColor = System.Drawing.Color.Yellow;
            this.btncolorribben.Location = new System.Drawing.Point(372, 42);
            this.btncolorribben.Name = "btncolorribben";
            this.btncolorribben.Size = new System.Drawing.Size(75, 23);
            this.btncolorribben.TabIndex = 6;
            this.btncolorribben.UseVisualStyleBackColor = false;
            this.btncolorribben.Click += new System.EventHandler(this.button1_Click);
            // 
            // btncolorbox
            // 
            this.btncolorbox.BackColor = System.Drawing.Color.Red;
            this.btncolorbox.Location = new System.Drawing.Point(291, 42);
            this.btncolorbox.Name = "btncolorbox";
            this.btncolorbox.Size = new System.Drawing.Size(75, 23);
            this.btncolorbox.TabIndex = 7;
            this.btncolorbox.UseVisualStyleBackColor = false;
            this.btncolorbox.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncolorbox);
            this.Controls.Add(this.btncolorribben);
            this.Controls.Add(this.btnpresent);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblnext);
            this.Controls.Add(this.btnball);
            this.Controls.Add(this.btncar);
            this.Controls.Add(this.mainpanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.Timer createTimer;
        private System.Windows.Forms.Timer conveyorTimer;
        private System.Windows.Forms.Button btncar;
        private System.Windows.Forms.Button btnball;
        private System.Windows.Forms.Label lblnext;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnpresent;
        private System.Windows.Forms.Button btncolorribben;
        private System.Windows.Forms.Button btncolorbox;
    }
}

