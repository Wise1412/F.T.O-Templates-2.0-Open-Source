namespace F.T.O_Templates_2._0
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.trainingfiles = new System.Windows.Forms.Button();
            this.apps = new System.Windows.Forms.Button();
            this.PanelMain = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.DarkGreen;
            this.panelMenu.Controls.Add(this.trainingfiles);
            this.panelMenu.Controls.Add(this.apps);
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(409, 597);
            this.panelMenu.TabIndex = 0;
            // 
            // trainingfiles
            // 
            this.trainingfiles.BackColor = System.Drawing.Color.DarkGreen;
            this.trainingfiles.FlatAppearance.BorderSize = 0;
            this.trainingfiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.trainingfiles.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trainingfiles.ForeColor = System.Drawing.SystemColors.Control;
            this.trainingfiles.Image = global::F.T.O_Templates_2._0.Properties.Resources.file;
            this.trainingfiles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.trainingfiles.Location = new System.Drawing.Point(0, 133);
            this.trainingfiles.Name = "trainingfiles";
            this.trainingfiles.Size = new System.Drawing.Size(409, 136);
            this.trainingfiles.TabIndex = 0;
            this.trainingfiles.Text = "F.T.O Training Files";
            this.trainingfiles.UseVisualStyleBackColor = false;
            this.trainingfiles.Click += new System.EventHandler(this.trainingfiles_Click);
            // 
            // apps
            // 
            this.apps.BackColor = System.Drawing.Color.DarkGreen;
            this.apps.FlatAppearance.BorderSize = 0;
            this.apps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.apps.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apps.ForeColor = System.Drawing.SystemColors.Control;
            this.apps.Image = global::F.T.O_Templates_2._0.Properties.Resources.resume__1_;
            this.apps.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.apps.Location = new System.Drawing.Point(0, 0);
            this.apps.Name = "apps";
            this.apps.Size = new System.Drawing.Size(409, 136);
            this.apps.TabIndex = 0;
            this.apps.Text = "F.T.O Application Responses";
            this.apps.UseVisualStyleBackColor = false;
            this.apps.Click += new System.EventHandler(this.apps_Click);
            // 
            // PanelMain
            // 
            this.PanelMain.Location = new System.Drawing.Point(407, 0);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(975, 597);
            this.PanelMain.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1381, 599);
            this.Controls.Add(this.PanelMain);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Field Training Operations Templates";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button apps;
        private System.Windows.Forms.Button trainingfiles;
        private System.Windows.Forms.Panel PanelMain;
    }
}

