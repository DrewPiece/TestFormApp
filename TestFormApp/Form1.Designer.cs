
namespace TestFormApp
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
            this.btnGreen = new System.Windows.Forms.Button();
            this.btnRed = new System.Windows.Forms.Button();
            this.btnBlue = new System.Windows.Forms.Button();
            this.btnYellow = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSequence = new System.Windows.Forms.Label();
            this.lblCountDown = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGreen
            // 
            this.btnGreen.BackColor = System.Drawing.Color.Transparent;
            this.btnGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGreen.ForeColor = System.Drawing.Color.Green;
            this.btnGreen.Location = new System.Drawing.Point(12, 34);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(232, 90);
            this.btnGreen.TabIndex = 0;
            this.btnGreen.Text = "Green";
            this.btnGreen.UseVisualStyleBackColor = false;
            this.btnGreen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnGreen_MouseDown);
            this.btnGreen.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnGreen_MouseUp);
            // 
            // btnRed
            // 
            this.btnRed.BackColor = System.Drawing.Color.Transparent;
            this.btnRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRed.ForeColor = System.Drawing.Color.Red;
            this.btnRed.Location = new System.Drawing.Point(12, 214);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(232, 90);
            this.btnRed.TabIndex = 1;
            this.btnRed.Text = "Red";
            this.btnRed.UseVisualStyleBackColor = false;
            this.btnRed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnRed_MouseDown);
            this.btnRed.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnRed_MouseUp);
            // 
            // btnBlue
            // 
            this.btnBlue.BackColor = System.Drawing.Color.Transparent;
            this.btnBlue.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlue.ForeColor = System.Drawing.Color.Blue;
            this.btnBlue.Location = new System.Drawing.Point(311, 34);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(232, 90);
            this.btnBlue.TabIndex = 2;
            this.btnBlue.Text = "Blue";
            this.btnBlue.UseVisualStyleBackColor = false;
            this.btnBlue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnBlue_MouseDown);
            this.btnBlue.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnBlue_MouseUp);
            // 
            // btnYellow
            // 
            this.btnYellow.BackColor = System.Drawing.Color.Transparent;
            this.btnYellow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYellow.ForeColor = System.Drawing.Color.Yellow;
            this.btnYellow.Location = new System.Drawing.Point(311, 214);
            this.btnYellow.Name = "btnYellow";
            this.btnYellow.Size = new System.Drawing.Size(232, 90);
            this.btnYellow.TabIndex = 3;
            this.btnYellow.Text = "Yellow";
            this.btnYellow.UseVisualStyleBackColor = false;
            this.btnYellow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnYellow_MouseDown);
            this.btnYellow.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnYellow_MouseUp);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(211, 332);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(136, 40);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(208, 392);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(139, 40);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "SUCCESS";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStatus.Visible = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(610, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 40);
            this.label1.TabIndex = 6;
            this.label1.Text = "Level";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLevel
            // 
            this.lblLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.Location = new System.Drawing.Point(610, 67);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(139, 30);
            this.lblLevel.TabIndex = 7;
            this.lblLevel.Text = "1";
            this.lblLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(578, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 40);
            this.label2.TabIndex = 8;
            this.label2.Text = "Sequence Count";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSequence
            // 
            this.lblSequence.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSequence.Location = new System.Drawing.Point(610, 185);
            this.lblSequence.Name = "lblSequence";
            this.lblSequence.Size = new System.Drawing.Size(139, 30);
            this.lblSequence.TabIndex = 9;
            this.lblSequence.Text = "1";
            this.lblSequence.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCountDown
            // 
            this.lblCountDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountDown.Location = new System.Drawing.Point(208, 149);
            this.lblCountDown.Name = "lblCountDown";
            this.lblCountDown.Size = new System.Drawing.Size(139, 30);
            this.lblCountDown.TabIndex = 10;
            this.lblCountDown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCountDown.Visible = false;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(615, 332);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(134, 39);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblCountDown);
            this.Controls.Add(this.lblSequence);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnYellow);
            this.Controls.Add(this.btnBlue);
            this.Controls.Add(this.btnRed);
            this.Controls.Add(this.btnGreen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGreen;
        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Button btnBlue;
        private System.Windows.Forms.Button btnYellow;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSequence;
        private System.Windows.Forms.Label lblCountDown;
        private System.Windows.Forms.Button btnReset;
    }
}

