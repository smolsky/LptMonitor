namespace InpOut32.Net
{
    partial class CSharpExample
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
          this.button1 = new System.Windows.Forms.Button();
          this.button2 = new System.Windows.Forms.Button();
          this.textBox1 = new System.Windows.Forms.TextBox();
          this.textBox2 = new System.Windows.Forms.TextBox();
          this.label1 = new System.Windows.Forms.Label();
          this.label2 = new System.Windows.Forms.Label();
          this.lblMessage = new System.Windows.Forms.Label();
          this.button3 = new System.Windows.Forms.Button();
          this.button4 = new System.Windows.Forms.Button();
          this.button5 = new System.Windows.Forms.Button();
          this.button6 = new System.Windows.Forms.Button();
          this.button7 = new System.Windows.Forms.Button();
          this._HideTimer = new System.Windows.Forms.Timer(this.components);
          this._LptReadTimer = new System.Windows.Forms.Timer(this.components);
          this.SuspendLayout();
          // 
          // button1
          // 
          this.button1.Location = new System.Drawing.Point(12, 108);
          this.button1.Name = "button1";
          this.button1.Size = new System.Drawing.Size(85, 23);
          this.button1.TabIndex = 0;
          this.button1.Text = "Read BYTE";
          this.button1.UseVisualStyleBackColor = true;
          this.button1.Click += new System.EventHandler(this.button1_Click);
          // 
          // button2
          // 
          this.button2.Location = new System.Drawing.Point(114, 108);
          this.button2.Name = "button2";
          this.button2.Size = new System.Drawing.Size(86, 23);
          this.button2.TabIndex = 1;
          this.button2.Text = "Write BYTE";
          this.button2.UseVisualStyleBackColor = true;
          this.button2.Click += new System.EventHandler(this.button2_Click);
          // 
          // textBox1
          // 
          this.textBox1.Location = new System.Drawing.Point(12, 25);
          this.textBox1.Name = "textBox1";
          this.textBox1.Size = new System.Drawing.Size(188, 20);
          this.textBox1.TabIndex = 2;
          this.textBox1.Text = "888";
          // 
          // textBox2
          // 
          this.textBox2.Location = new System.Drawing.Point(12, 71);
          this.textBox2.Name = "textBox2";
          this.textBox2.Size = new System.Drawing.Size(188, 20);
          this.textBox2.TabIndex = 3;
          // 
          // label1
          // 
          this.label1.AutoSize = true;
          this.label1.Location = new System.Drawing.Point(9, 9);
          this.label1.Name = "label1";
          this.label1.Size = new System.Drawing.Size(114, 13);
          this.label1.TabIndex = 5;
          this.label1.Text = "Port Address (Decimal)";
          // 
          // label2
          // 
          this.label2.AutoSize = true;
          this.label2.Location = new System.Drawing.Point(12, 55);
          this.label2.Name = "label2";
          this.label2.Size = new System.Drawing.Size(103, 13);
          this.label2.TabIndex = 6;
          this.label2.Text = "Port Value (Decimal)";
          // 
          // lblMessage
          // 
          this.lblMessage.AutoSize = true;
          this.lblMessage.Location = new System.Drawing.Point(9, 94);
          this.lblMessage.Name = "lblMessage";
          this.lblMessage.Size = new System.Drawing.Size(0, 13);
          this.lblMessage.TabIndex = 7;
          // 
          // button3
          // 
          this.button3.Location = new System.Drawing.Point(12, 137);
          this.button3.Name = "button3";
          this.button3.Size = new System.Drawing.Size(85, 23);
          this.button3.TabIndex = 8;
          this.button3.Text = "Read SHORT";
          this.button3.UseVisualStyleBackColor = true;
          this.button3.Click += new System.EventHandler(this.button3_Click);
          // 
          // button4
          // 
          this.button4.Location = new System.Drawing.Point(12, 166);
          this.button4.Name = "button4";
          this.button4.Size = new System.Drawing.Size(85, 23);
          this.button4.TabIndex = 9;
          this.button4.Text = "Read LONG";
          this.button4.UseVisualStyleBackColor = true;
          this.button4.Click += new System.EventHandler(this.button4_Click);
          // 
          // button5
          // 
          this.button5.Location = new System.Drawing.Point(114, 137);
          this.button5.Name = "button5";
          this.button5.Size = new System.Drawing.Size(86, 23);
          this.button5.TabIndex = 10;
          this.button5.Text = "Write SHORT";
          this.button5.UseVisualStyleBackColor = true;
          this.button5.Click += new System.EventHandler(this.button5_Click);
          // 
          // button6
          // 
          this.button6.Location = new System.Drawing.Point(114, 166);
          this.button6.Name = "button6";
          this.button6.Size = new System.Drawing.Size(86, 23);
          this.button6.TabIndex = 11;
          this.button6.Text = "Write LONG";
          this.button6.UseVisualStyleBackColor = true;
          this.button6.Click += new System.EventHandler(this.button6_Click);
          // 
          // button7
          // 
          this.button7.Location = new System.Drawing.Point(58, 195);
          this.button7.Name = "button7";
          this.button7.Size = new System.Drawing.Size(85, 23);
          this.button7.TabIndex = 12;
          this.button7.Text = "Beeper";
          this.button7.UseVisualStyleBackColor = true;
          this.button7.Click += new System.EventHandler(this.button7_Click);
          // 
          // _HideTimer
          // 
          this._HideTimer.Enabled = true;
          this._HideTimer.Tick += new System.EventHandler(this.HideTimer_Tick);
          // 
          // _LptReadTimer
          // 
          this._LptReadTimer.Tick += new System.EventHandler(this._LptReadTimer_Tick);
          // 
          // CSharpExample
          // 
          this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
          this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
          this.ClientSize = new System.Drawing.Size(212, 229);
          this.Controls.Add(this.button7);
          this.Controls.Add(this.button6);
          this.Controls.Add(this.button5);
          this.Controls.Add(this.button4);
          this.Controls.Add(this.button3);
          this.Controls.Add(this.lblMessage);
          this.Controls.Add(this.label2);
          this.Controls.Add(this.label1);
          this.Controls.Add(this.textBox2);
          this.Controls.Add(this.textBox1);
          this.Controls.Add(this.button2);
          this.Controls.Add(this.button1);
          this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
          this.Name = "CSharpExample";
          this.Text = "InpOut C# Test";
          this.Load += new System.EventHandler(this.CSharpExample_Load);
          this.ResumeLayout(false);
          this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Timer _HideTimer;
        private System.Windows.Forms.Timer _LptReadTimer;

    }
}

