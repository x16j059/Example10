namespace Example10
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
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.tbxAge = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LbLResult = new System.Windows.Forms.Label();
            this.btnJudge = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "年齢は";
            // 
            // tbxAge
            // 
            this.tbxAge.Location = new System.Drawing.Point(57, 63);
            this.tbxAge.Name = "tbxAge";
            this.tbxAge.Size = new System.Drawing.Size(100, 19);
            this.tbxAge.TabIndex = 1;
            this.tbxAge.TextChanged += new System.EventHandler(this.tbxAge_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "歳";
            // 
            // LbLResult
            // 
            this.LbLResult.AutoSize = true;
            this.LbLResult.Location = new System.Drawing.Point(157, 212);
            this.LbLResult.Name = "LbLResult";
            this.LbLResult.Size = new System.Drawing.Size(0, 12);
            this.LbLResult.TabIndex = 3;
            // 
            // btnJudge
            // 
            this.btnJudge.Location = new System.Drawing.Point(197, 63);
            this.btnJudge.Name = "btnJudge";
            this.btnJudge.Size = new System.Drawing.Size(75, 23);
            this.btnJudge.TabIndex = 4;
            this.btnJudge.Text = "判定";
            this.btnJudge.UseVisualStyleBackColor = true;
            this.btnJudge.Click += new System.EventHandler(this.btnJudge_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnJudge);
            this.Controls.Add(this.LbLResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxAge);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "年齢判定";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxAge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LbLResult;
        private System.Windows.Forms.Button btnJudge;
    }
}

