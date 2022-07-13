
namespace MultiTaskSample
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTask1 = new System.Windows.Forms.TextBox();
            this.txtTask2 = new System.Windows.Forms.TextBox();
            this.txtTask3 = new System.Windows.Forms.TextBox();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "タスク1";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(260, 25);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "開始";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "タスク1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "タスク1";
            // 
            // txtTask1
            // 
            this.txtTask1.Location = new System.Drawing.Point(115, 27);
            this.txtTask1.Name = "txtTask1";
            this.txtTask1.ReadOnly = true;
            this.txtTask1.Size = new System.Drawing.Size(75, 19);
            this.txtTask1.TabIndex = 5;
            this.txtTask1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTask2
            // 
            this.txtTask2.Location = new System.Drawing.Point(115, 78);
            this.txtTask2.Name = "txtTask2";
            this.txtTask2.ReadOnly = true;
            this.txtTask2.Size = new System.Drawing.Size(75, 19);
            this.txtTask2.TabIndex = 6;
            this.txtTask2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTask3
            // 
            this.txtTask3.Location = new System.Drawing.Point(115, 131);
            this.txtTask3.Name = "txtTask3";
            this.txtTask3.ReadOnly = true;
            this.txtTask3.Size = new System.Drawing.Size(75, 19);
            this.txtTask3.TabIndex = 7;
            this.txtTask3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMsg
            // 
            this.txtMsg.Location = new System.Drawing.Point(248, 131);
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.ReadOnly = true;
            this.txtMsg.Size = new System.Drawing.Size(100, 19);
            this.txtMsg.TabIndex = 8;
            this.txtMsg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 177);
            this.Controls.Add(this.txtMsg);
            this.Controls.Add(this.txtTask3);
            this.Controls.Add(this.txtTask2);
            this.Controls.Add(this.txtTask1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTask1;
        private System.Windows.Forms.TextBox txtTask2;
        private System.Windows.Forms.TextBox txtTask3;
        private System.Windows.Forms.TextBox txtMsg;
    }
}

