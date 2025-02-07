namespace MouseClick
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            btnClick=new Button();
            btnStop=new Button();
            countdownLabel=new Label();
            clickCountLabel=new Label();
            SuspendLayout();
            // 
            // btnClick
            // 
            btnClick.Location=new Point(311, 24);
            btnClick.Name="btnClick";
            btnClick.Size=new Size(106, 51);
            btnClick.TabIndex=0;
            btnClick.Text="Start";
            btnClick.UseVisualStyleBackColor=true;
            btnClick.Click+=btnClick_Click;
            // 
            // btnStop
            // 
            btnStop.Location=new Point(311, 100);
            btnStop.Name="btnStop";
            btnStop.Size=new Size(106, 51);
            btnStop.TabIndex=1;
            btnStop.Text="Stop";
            btnStop.UseVisualStyleBackColor=true;
            btnStop.Click+=btnStop_Click;
            // 
            // countdownLabel
            // 
            countdownLabel.AutoSize=true;
            countdownLabel.Location=new Point(35, 39);
            countdownLabel.Name="countdownLabel";
            countdownLabel.Size=new Size(231, 20);
            countdownLabel.TabIndex=2;
            countdownLabel.Text="Tiempo hasta el próximo click: 60";
            // 
            // clickCountLabel
            // 
            clickCountLabel.AutoSize=true;
            clickCountLabel.Location=new Point(35, 115);
            clickCountLabel.Name="clickCountLabel";
            clickCountLabel.Size=new Size(133, 20);
            clickCountLabel.TabIndex=3;
            clickCountLabel.Text="Clicks realizados: 0";
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(429, 163);
            Controls.Add(clickCountLabel);
            Controls.Add(countdownLabel);
            Controls.Add(btnStop);
            Controls.Add(btnClick);
            Name="Form1";
            Text="Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClick;
        private Button btnStop;
        private Label countdownLabel;
        private Label clickCountLabel;
    }
}
