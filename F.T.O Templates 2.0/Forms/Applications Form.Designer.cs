namespace F.T.O_Templates_2._0.Forms
{
    partial class Applications_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Applications_Form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.reasons = new System.Windows.Forms.TextBox();
            this.rankandfullname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pint = new System.Windows.Forms.Button();
            this.onhold = new System.Windows.Forms.Button();
            this.pbdg = new System.Windows.Forms.Button();
            this.denied = new System.Windows.Forms.Button();
            this.closed = new System.Windows.Forms.Button();
            this.hired = new System.Windows.Forms.Button();
            this.blacklisted = new System.Windows.Forms.Button();
            this.accepted = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGreen;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(962, 92);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(184, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(621, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "F.T.O Application Response Templates";
            // 
            // reasons
            // 
            this.reasons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.reasons.Location = new System.Drawing.Point(697, 145);
            this.reasons.Name = "reasons";
            this.reasons.Size = new System.Drawing.Size(199, 20);
            this.reasons.TabIndex = 2;
            // 
            // rankandfullname
            // 
            this.rankandfullname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rankandfullname.Location = new System.Drawing.Point(28, 145);
            this.rankandfullname.Name = "rankandfullname";
            this.rankandfullname.Size = new System.Drawing.Size(199, 20);
            this.rankandfullname.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rank + Full Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(648, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(299, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Reason (Denied  / On-Hold)";
            // 
            // pint
            // 
            this.pint.BackColor = System.Drawing.Color.DarkOrange;
            this.pint.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pint.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pint.Location = new System.Drawing.Point(12, 384);
            this.pint.Name = "pint";
            this.pint.Size = new System.Drawing.Size(151, 68);
            this.pint.TabIndex = 3;
            this.pint.Text = "Pending Interview";
            this.pint.UseVisualStyleBackColor = false;
            this.pint.Click += new System.EventHandler(this.pint_Click);
            // 
            // onhold
            // 
            this.onhold.BackColor = System.Drawing.SystemColors.Control;
            this.onhold.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onhold.ForeColor = System.Drawing.SystemColors.ControlText;
            this.onhold.Location = new System.Drawing.Point(12, 458);
            this.onhold.Name = "onhold";
            this.onhold.Size = new System.Drawing.Size(151, 68);
            this.onhold.TabIndex = 3;
            this.onhold.Text = "On-Hold";
            this.onhold.UseVisualStyleBackColor = false;
            this.onhold.Click += new System.EventHandler(this.onhold_Click);
            // 
            // pbdg
            // 
            this.pbdg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(238)))), ((int)(((byte)(149)))));
            this.pbdg.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pbdg.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pbdg.Location = new System.Drawing.Point(278, 384);
            this.pbdg.Name = "pbdg";
            this.pbdg.Size = new System.Drawing.Size(151, 68);
            this.pbdg.TabIndex = 3;
            this.pbdg.Text = "Pending Badge";
            this.pbdg.UseVisualStyleBackColor = false;
            this.pbdg.Click += new System.EventHandler(this.pbdg_Click);
            // 
            // denied
            // 
            this.denied.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(17)))), ((int)(((byte)(24)))));
            this.denied.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.denied.ForeColor = System.Drawing.SystemColors.ControlText;
            this.denied.Location = new System.Drawing.Point(278, 458);
            this.denied.Name = "denied";
            this.denied.Size = new System.Drawing.Size(151, 68);
            this.denied.TabIndex = 3;
            this.denied.Text = "Denied";
            this.denied.UseVisualStyleBackColor = false;
            this.denied.Click += new System.EventHandler(this.denied_Click);
            // 
            // closed
            // 
            this.closed.BackColor = System.Drawing.SystemColors.Control;
            this.closed.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closed.ForeColor = System.Drawing.SystemColors.ControlText;
            this.closed.Location = new System.Drawing.Point(514, 458);
            this.closed.Name = "closed";
            this.closed.Size = new System.Drawing.Size(151, 68);
            this.closed.TabIndex = 3;
            this.closed.Text = "Closed";
            this.closed.UseVisualStyleBackColor = false;
            this.closed.Click += new System.EventHandler(this.closed_Click);
            // 
            // hired
            // 
            this.hired.BackColor = System.Drawing.Color.Lime;
            this.hired.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hired.ForeColor = System.Drawing.SystemColors.ControlText;
            this.hired.Location = new System.Drawing.Point(514, 384);
            this.hired.Name = "hired";
            this.hired.Size = new System.Drawing.Size(151, 68);
            this.hired.TabIndex = 3;
            this.hired.Text = "Hired";
            this.hired.UseVisualStyleBackColor = false;
            this.hired.Click += new System.EventHandler(this.hired_Click);
            // 
            // blacklisted
            // 
            this.blacklisted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(30)))), ((int)(((byte)(28)))));
            this.blacklisted.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blacklisted.ForeColor = System.Drawing.SystemColors.ControlText;
            this.blacklisted.Location = new System.Drawing.Point(756, 458);
            this.blacklisted.Name = "blacklisted";
            this.blacklisted.Size = new System.Drawing.Size(151, 68);
            this.blacklisted.TabIndex = 3;
            this.blacklisted.Text = "Blacklisted";
            this.blacklisted.UseVisualStyleBackColor = false;
            this.blacklisted.Click += new System.EventHandler(this.blacklisted_Click);
            // 
            // accepted
            // 
            this.accepted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.accepted.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accepted.ForeColor = System.Drawing.SystemColors.ControlText;
            this.accepted.Location = new System.Drawing.Point(756, 384);
            this.accepted.Name = "accepted";
            this.accepted.Size = new System.Drawing.Size(151, 68);
            this.accepted.TabIndex = 3;
            this.accepted.Text = "Accepted";
            this.accepted.UseVisualStyleBackColor = false;
            this.accepted.Click += new System.EventHandler(this.accepted_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkGreen;
            this.pictureBox1.Image = global::F.T.O_Templates_2._0.Properties.Resources.resume__1_;
            this.pictureBox1.Location = new System.Drawing.Point(115, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 63);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Applications_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 558);
            this.Controls.Add(this.blacklisted);
            this.Controls.Add(this.closed);
            this.Controls.Add(this.onhold);
            this.Controls.Add(this.denied);
            this.Controls.Add(this.accepted);
            this.Controls.Add(this.hired);
            this.Controls.Add(this.pbdg);
            this.Controls.Add(this.pint);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rankandfullname);
            this.Controls.Add(this.reasons);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Applications_Form";
            this.Text = "Applications Form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox reasons;
        private System.Windows.Forms.TextBox rankandfullname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button pint;
        private System.Windows.Forms.Button onhold;
        private System.Windows.Forms.Button pbdg;
        private System.Windows.Forms.Button denied;
        private System.Windows.Forms.Button closed;
        private System.Windows.Forms.Button hired;
        private System.Windows.Forms.Button blacklisted;
        private System.Windows.Forms.Button accepted;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}