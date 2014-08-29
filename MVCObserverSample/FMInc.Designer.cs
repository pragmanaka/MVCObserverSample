namespace MVCObserverSample
{
    partial class FMInc
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
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
            this.btnViewSub = new System.Windows.Forms.Button();
            this.lblValue = new System.Windows.Forms.Label();
            this.btnInc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnViewSub
            // 
            this.btnViewSub.Location = new System.Drawing.Point(12, 78);
            this.btnViewSub.Name = "btnViewSub";
            this.btnViewSub.Size = new System.Drawing.Size(142, 43);
            this.btnViewSub.TabIndex = 6;
            this.btnViewSub.Text = "ViewSub";
            this.btnViewSub.UseVisualStyleBackColor = true;
            this.btnViewSub.Click += new System.EventHandler(this.btnViewSub_Click);
            // 
            // lblValue
            // 
            this.lblValue.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblValue.Location = new System.Drawing.Point(12, 12);
            this.lblValue.Name = "lblValue";
            this.lblValue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblValue.Size = new System.Drawing.Size(142, 48);
            this.lblValue.TabIndex = 5;
            this.lblValue.Text = "0";
            this.lblValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnInc
            // 
            this.btnInc.Location = new System.Drawing.Point(160, 12);
            this.btnInc.Name = "btnInc";
            this.btnInc.Size = new System.Drawing.Size(112, 109);
            this.btnInc.TabIndex = 4;
            this.btnInc.Text = "Inc";
            this.btnInc.UseVisualStyleBackColor = true;
            this.btnInc.Click += new System.EventHandler(this.btnInc_Click);
            // 
            // FMInc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 133);
            this.Controls.Add(this.btnViewSub);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.btnInc);
            this.Name = "FMInc";
            this.Text = "FMInc";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnViewSub;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Button btnInc;
    }
}

