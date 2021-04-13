namespace EHTool
{
    partial class EHTool
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
            this.btn1Abort = new System.Windows.Forms.Button();
            this.btn2Startautomation = new System.Windows.Forms.Button();
            this.btn3Pause = new System.Windows.Forms.Button();
            this.btn4Continuemanual = new System.Windows.Forms.Button();
            this.btn5ValidateDutid = new System.Windows.Forms.Button();
            this.btn6Pauseonfailed = new System.Windows.Forms.Button();
            this.btn7Savetestrecord = new System.Windows.Forms.Button();
            this.btnManualmode = new System.Windows.Forms.Button();
            this.btn9Startoperarator = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openConfigurarionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.lblfilepath = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn1Abort
            // 
            this.btn1Abort.Location = new System.Drawing.Point(86, 149);
            this.btn1Abort.Name = "btn1Abort";
            this.btn1Abort.Size = new System.Drawing.Size(286, 81);
            this.btn1Abort.TabIndex = 0;
            this.btn1Abort.Text = "AbortTestOnFail";
            this.btn1Abort.UseVisualStyleBackColor = true;
            this.btn1Abort.Click += new System.EventHandler(this.btn1Abort_Click);
            // 
            // btn2Startautomation
            // 
            this.btn2Startautomation.Location = new System.Drawing.Point(446, 149);
            this.btn2Startautomation.Name = "btn2Startautomation";
            this.btn2Startautomation.Size = new System.Drawing.Size(286, 81);
            this.btn2Startautomation.TabIndex = 1;
            this.btn2Startautomation.Text = "StartInAutomationMode";
            this.btn2Startautomation.UseVisualStyleBackColor = true;
            this.btn2Startautomation.Click += new System.EventHandler(this.btn2Startautomation_Click);
            // 
            // btn3Pause
            // 
            this.btn3Pause.Location = new System.Drawing.Point(836, 149);
            this.btn3Pause.Name = "btn3Pause";
            this.btn3Pause.Size = new System.Drawing.Size(286, 81);
            this.btn3Pause.TabIndex = 2;
            this.btn3Pause.Text = "PauseOnMeasurement";
            this.btn3Pause.UseVisualStyleBackColor = true;
            this.btn3Pause.Click += new System.EventHandler(this.btn3Pause_Click);
            // 
            // btn4Continuemanual
            // 
            this.btn4Continuemanual.Location = new System.Drawing.Point(86, 305);
            this.btn4Continuemanual.Name = "btn4Continuemanual";
            this.btn4Continuemanual.Size = new System.Drawing.Size(286, 81);
            this.btn4Continuemanual.TabIndex = 3;
            this.btn4Continuemanual.Text = "ContinueManualTestOnError";
            this.btn4Continuemanual.UseVisualStyleBackColor = true;
            this.btn4Continuemanual.Click += new System.EventHandler(this.btn4Continuemanual_Click);
            // 
            // btn5ValidateDutid
            // 
            this.btn5ValidateDutid.Location = new System.Drawing.Point(446, 305);
            this.btn5ValidateDutid.Name = "btn5ValidateDutid";
            this.btn5ValidateDutid.Size = new System.Drawing.Size(286, 81);
            this.btn5ValidateDutid.TabIndex = 4;
            this.btn5ValidateDutid.Text = "ValidateDutId";
            this.btn5ValidateDutid.UseVisualStyleBackColor = true;
            this.btn5ValidateDutid.Click += new System.EventHandler(this.btn5ValidateDutid_Click);
            // 
            // btn6Pauseonfailed
            // 
            this.btn6Pauseonfailed.Location = new System.Drawing.Point(836, 305);
            this.btn6Pauseonfailed.Name = "btn6Pauseonfailed";
            this.btn6Pauseonfailed.Size = new System.Drawing.Size(286, 81);
            this.btn6Pauseonfailed.TabIndex = 5;
            this.btn6Pauseonfailed.Text = "PauseOnFailedMeasurement";
            this.btn6Pauseonfailed.UseVisualStyleBackColor = true;
            this.btn6Pauseonfailed.Click += new System.EventHandler(this.btn6Pauseonfailed_Click);
            // 
            // btn7Savetestrecord
            // 
            this.btn7Savetestrecord.Location = new System.Drawing.Point(86, 476);
            this.btn7Savetestrecord.Name = "btn7Savetestrecord";
            this.btn7Savetestrecord.Size = new System.Drawing.Size(286, 81);
            this.btn7Savetestrecord.TabIndex = 6;
            this.btn7Savetestrecord.Text = "SaveTestRecordData";
            this.btn7Savetestrecord.UseVisualStyleBackColor = true;
            this.btn7Savetestrecord.Click += new System.EventHandler(this.btn7Savetestrecord_Click);
            // 
            // btnManualmode
            // 
            this.btnManualmode.Location = new System.Drawing.Point(446, 476);
            this.btnManualmode.Name = "btnManualmode";
            this.btnManualmode.Size = new System.Drawing.Size(286, 81);
            this.btnManualmode.TabIndex = 7;
            this.btnManualmode.Text = "ManualModeEnabled";
            this.btnManualmode.UseVisualStyleBackColor = true;
            this.btnManualmode.Click += new System.EventHandler(this.btnManualmode_Click);
            // 
            // btn9Startoperarator
            // 
            this.btn9Startoperarator.Location = new System.Drawing.Point(836, 476);
            this.btn9Startoperarator.Name = "btn9Startoperarator";
            this.btn9Startoperarator.Size = new System.Drawing.Size(286, 81);
            this.btn9Startoperarator.TabIndex = 8;
            this.btn9Startoperarator.Text = "StartOperatorGui";
            this.btn9Startoperarator.UseVisualStyleBackColor = true;
            this.btn9Startoperarator.Click += new System.EventHandler(this.btn9Startoperarator_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1198, 33);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openConfigurarionToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openConfigurarionToolStripMenuItem
            // 
            this.openConfigurarionToolStripMenuItem.Name = "openConfigurarionToolStripMenuItem";
            this.openConfigurarionToolStripMenuItem.Size = new System.Drawing.Size(254, 30);
            this.openConfigurarionToolStripMenuItem.Text = "Open Configurarion";
            this.openConfigurarionToolStripMenuItem.Click += new System.EventHandler(this.openConfigurarionToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(949, 620);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 60);
            this.button1.TabIndex = 10;
            this.button1.Text = "Another Solution >>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblfilepath
            // 
            this.lblfilepath.AutoSize = true;
            this.lblfilepath.Location = new System.Drawing.Point(133, 52);
            this.lblfilepath.Name = "lblfilepath";
            this.lblfilepath.Size = new System.Drawing.Size(0, 20);
            this.lblfilepath.TabIndex = 11;
            // 
            // EHTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 692);
            this.Controls.Add(this.lblfilepath);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn9Startoperarator);
            this.Controls.Add(this.btnManualmode);
            this.Controls.Add(this.btn7Savetestrecord);
            this.Controls.Add(this.btn6Pauseonfailed);
            this.Controls.Add(this.btn5ValidateDutid);
            this.Controls.Add(this.btn4Continuemanual);
            this.Controls.Add(this.btn3Pause);
            this.Controls.Add(this.btn2Startautomation);
            this.Controls.Add(this.btn1Abort);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EHTool";
            this.Text = "HC Tool made by : Kesavaraj";
            this.Load += new System.EventHandler(this.EHTool_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1Abort;
        private System.Windows.Forms.Button btn2Startautomation;
        private System.Windows.Forms.Button btn3Pause;
        private System.Windows.Forms.Button btn4Continuemanual;
        private System.Windows.Forms.Button btn5ValidateDutid;
        private System.Windows.Forms.Button btn6Pauseonfailed;
        private System.Windows.Forms.Button btn7Savetestrecord;
        private System.Windows.Forms.Button btnManualmode;
        private System.Windows.Forms.Button btn9Startoperarator;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openConfigurarionToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblfilepath;
    }
}