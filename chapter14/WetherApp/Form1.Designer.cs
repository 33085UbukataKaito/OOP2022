
namespace WetherApp {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.tbWetherInfo = new System.Windows.Forms.TextBox();
            this.btWetherGet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbWetherInfo
            // 
            this.tbWetherInfo.Location = new System.Drawing.Point(12, 258);
            this.tbWetherInfo.Multiline = true;
            this.tbWetherInfo.Name = "tbWetherInfo";
            this.tbWetherInfo.Size = new System.Drawing.Size(776, 180);
            this.tbWetherInfo.TabIndex = 0;
            // 
            // btWetherGet
            // 
            this.btWetherGet.Location = new System.Drawing.Point(3, 1);
            this.btWetherGet.Name = "btWetherGet";
            this.btWetherGet.Size = new System.Drawing.Size(103, 45);
            this.btWetherGet.TabIndex = 1;
            this.btWetherGet.Text = "取得";
            this.btWetherGet.UseVisualStyleBackColor = true;
            this.btWetherGet.Click += new System.EventHandler(this.btWetherGet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(12, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "天気概況";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btWetherGet);
            this.Controls.Add(this.tbWetherInfo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbWetherInfo;
        private System.Windows.Forms.Button btWetherGet;
        private System.Windows.Forms.Label label1;
    }
}

