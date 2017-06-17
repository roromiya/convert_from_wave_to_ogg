namespace convertogg
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.latetxt = new System.Windows.Forms.TextBox();
            this.filenametxt = new System.Windows.Forms.TextBox();
            this.convertbtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.bittxt = new System.Windows.Forms.TextBox();
            this.channelcheck = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bitratetxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "파일명:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "샘플레이트값:";
            // 
            // latetxt
            // 
            this.latetxt.Location = new System.Drawing.Point(93, 70);
            this.latetxt.Name = "latetxt";
            this.latetxt.Size = new System.Drawing.Size(67, 21);
            this.latetxt.TabIndex = 2;
            // 
            // filenametxt
            // 
            this.filenametxt.Location = new System.Drawing.Point(57, 21);
            this.filenametxt.Name = "filenametxt";
            this.filenametxt.Size = new System.Drawing.Size(247, 21);
            this.filenametxt.TabIndex = 3;
            // 
            // convertbtn
            // 
            this.convertbtn.Location = new System.Drawing.Point(229, 128);
            this.convertbtn.Name = "convertbtn";
            this.convertbtn.Size = new System.Drawing.Size(75, 23);
            this.convertbtn.TabIndex = 4;
            this.convertbtn.Text = "Convert!";
            this.convertbtn.UseVisualStyleBackColor = true;
            this.convertbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "비트값:";
            // 
            // bittxt
            // 
            this.bittxt.Location = new System.Drawing.Point(57, 94);
            this.bittxt.Name = "bittxt";
            this.bittxt.Size = new System.Drawing.Size(37, 21);
            this.bittxt.TabIndex = 7;
            // 
            // channelcheck
            // 
            this.channelcheck.AutoSize = true;
            this.channelcheck.Location = new System.Drawing.Point(8, 135);
            this.channelcheck.Name = "channelcheck";
            this.channelcheck.Size = new System.Drawing.Size(116, 16);
            this.channelcheck.TabIndex = 8;
            this.channelcheck.Text = "모노 채널로 변경";
            this.channelcheck.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "비트레이트:";
            // 
            // bitratetxt
            // 
            this.bitratetxt.Location = new System.Drawing.Point(81, 46);
            this.bitratetxt.Name = "bitratetxt";
            this.bitratetxt.Size = new System.Drawing.Size(100, 21);
            this.bitratetxt.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 163);
            this.Controls.Add(this.bitratetxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.channelcheck);
            this.Controls.Add(this.bittxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.convertbtn);
            this.Controls.Add(this.filenametxt);
            this.Controls.Add(this.latetxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox latetxt;
        private System.Windows.Forms.TextBox filenametxt;
        private System.Windows.Forms.Button convertbtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox bittxt;
        private System.Windows.Forms.CheckBox channelcheck;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox bitratetxt;
    }
}

