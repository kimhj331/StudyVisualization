﻿namespace BogusMqttPublishApp
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBrokerIp = new System.Windows.Forms.TextBox();
            this.BtnConn = new System.Windows.Forms.Button();
            this.RtbLog = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "MQTT Broker IP";
            // 
            // TxtBrokerIp
            // 
            this.TxtBrokerIp.Location = new System.Drawing.Point(124, 70);
            this.TxtBrokerIp.Name = "TxtBrokerIp";
            this.TxtBrokerIp.Size = new System.Drawing.Size(384, 21);
            this.TxtBrokerIp.TabIndex = 1;
            // 
            // BtnConn
            // 
            this.BtnConn.Location = new System.Drawing.Point(514, 68);
            this.BtnConn.Name = "BtnConn";
            this.BtnConn.Size = new System.Drawing.Size(75, 23);
            this.BtnConn.TabIndex = 2;
            this.BtnConn.Text = "Connect";
            this.BtnConn.UseVisualStyleBackColor = true;
            this.BtnConn.Click += new System.EventHandler(this.BtnConn_Click);
            // 
            // RtbLog
            // 
            this.RtbLog.Location = new System.Drawing.Point(24, 108);
            this.RtbLog.Name = "RtbLog";
            this.RtbLog.Size = new System.Drawing.Size(565, 252);
            this.RtbLog.TabIndex = 3;
            this.RtbLog.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 382);
            this.Controls.Add(this.RtbLog);
            this.Controls.Add(this.BtnConn);
            this.Controls.Add(this.TxtBrokerIp);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "MQTT Fake Pulisher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBrokerIp;
        private System.Windows.Forms.Button BtnConn;
        private System.Windows.Forms.RichTextBox RtbLog;
    }
}

