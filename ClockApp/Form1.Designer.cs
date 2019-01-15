namespace ClockApp
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.clockBar = new CircularProgressBar.CircularProgressBar();
            this.updateTick = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // clockBar
            // 
            this.clockBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.clockBar.AnimationSpeed = 0;
            this.clockBar.BackColor = System.Drawing.Color.Transparent;
            this.clockBar.Font = new System.Drawing.Font("微軟正黑體", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.clockBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.clockBar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.clockBar.InnerMargin = 2;
            this.clockBar.InnerWidth = -1;
            this.clockBar.Location = new System.Drawing.Point(12, 12);
            this.clockBar.MarqueeAnimationSpeed = 2000;
            this.clockBar.Maximum = 86400;
            this.clockBar.Name = "clockBar";
            this.clockBar.OuterColor = System.Drawing.SystemColors.AppWorkspace;
            this.clockBar.OuterMargin = -25;
            this.clockBar.OuterWidth = 26;
            this.clockBar.ProgressColor = System.Drawing.Color.OrangeRed;
            this.clockBar.ProgressWidth = 25;
            this.clockBar.SecondaryFont = new System.Drawing.Font("微軟正黑體", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.clockBar.Size = new System.Drawing.Size(500, 500);
            this.clockBar.StartAngle = 270;
            this.clockBar.Step = 1;
            this.clockBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.clockBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.clockBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.clockBar.SubscriptText = "";
            this.clockBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.clockBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.clockBar.SuperscriptText = "";
            this.clockBar.TabIndex = 0;
            this.clockBar.Text = "00:00:00";
            this.clockBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            // 
            // updateTick
            // 
            this.updateTick.Enabled = true;
            this.updateTick.Interval = 1000;
            this.updateTick.Tick += new System.EventHandler(this.updateTick_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 545);
            this.Controls.Add(this.clockBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Clock";
            this.TopMost = true;
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer updateTick;
        private CircularProgressBar.CircularProgressBar clockBar;
    }
}

