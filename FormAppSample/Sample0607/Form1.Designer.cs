
namespace Sample0607 {
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
            this.btRandom = new System.Windows.Forms.Button();
            this.number = new System.Windows.Forms.NumericUpDown();
            this.number2 = new System.Windows.Forms.NumericUpDown();
            this.number3 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.number)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.number2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.number3)).BeginInit();
            this.SuspendLayout();
            // 
            // btRandom
            // 
            this.btRandom.BackColor = System.Drawing.Color.Lime;
            this.btRandom.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btRandom.Location = new System.Drawing.Point(70, 29);
            this.btRandom.Name = "btRandom";
            this.btRandom.Size = new System.Drawing.Size(203, 84);
            this.btRandom.TabIndex = 0;
            this.btRandom.Text = "乱数";
            this.btRandom.UseVisualStyleBackColor = false;
            this.btRandom.Click += new System.EventHandler(this.btRandom_Click);
            // 
            // number
            // 
            this.number.BackColor = System.Drawing.Color.Lime;
            this.number.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.number.Location = new System.Drawing.Point(473, 45);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(120, 55);
            this.number.TabIndex = 1;
            // 
            // number2
            // 
            this.number2.BackColor = System.Drawing.Color.Lime;
            this.number2.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.number2.Location = new System.Drawing.Point(153, 275);
            this.number2.Name = "number2";
            this.number2.Size = new System.Drawing.Size(120, 55);
            this.number2.TabIndex = 2;
            // 
            // number3
            // 
            this.number3.BackColor = System.Drawing.Color.Lime;
            this.number3.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.number3.Location = new System.Drawing.Point(473, 275);
            this.number3.Name = "number3";
            this.number3.Size = new System.Drawing.Size(120, 55);
            this.number3.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.number3);
            this.Controls.Add(this.number2);
            this.Controls.Add(this.number);
            this.Controls.Add(this.btRandom);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.number)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.number2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.number3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btRandom;
        private System.Windows.Forms.NumericUpDown number;
        private System.Windows.Forms.NumericUpDown number2;
        private System.Windows.Forms.NumericUpDown number3;
    }
}

