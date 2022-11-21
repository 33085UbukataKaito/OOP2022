
namespace WetherApp {
    partial class WetherApp {
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
            this.cbPrifecture = new System.Windows.Forms.ComboBox();
            this.PrefectureName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbDay = new System.Windows.Forms.ComboBox();
            this.tbDay = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pbWether = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbWether)).BeginInit();
            this.SuspendLayout();
            // 
            // tbWetherInfo
            // 
            this.tbWetherInfo.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbWetherInfo.Location = new System.Drawing.Point(12, 276);
            this.tbWetherInfo.Multiline = true;
            this.tbWetherInfo.Name = "tbWetherInfo";
            this.tbWetherInfo.Size = new System.Drawing.Size(776, 162);
            this.tbWetherInfo.TabIndex = 0;
            // 
            // btWetherGet
            // 
            this.btWetherGet.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btWetherGet.Location = new System.Drawing.Point(722, 5);
            this.btWetherGet.Name = "btWetherGet";
            this.btWetherGet.Size = new System.Drawing.Size(66, 29);
            this.btWetherGet.TabIndex = 1;
            this.btWetherGet.Text = "決定";
            this.btWetherGet.UseVisualStyleBackColor = true;
            this.btWetherGet.Click += new System.EventHandler(this.btWetherGet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(7, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "天気概況";
            // 
            // cbPrifecture
            // 
            this.cbPrifecture.FormattingEnabled = true;
            this.cbPrifecture.Location = new System.Drawing.Point(289, 9);
            this.cbPrifecture.Name = "cbPrifecture";
            this.cbPrifecture.Size = new System.Drawing.Size(111, 20);
            this.cbPrifecture.TabIndex = 3;
            // 
            // PrefectureName
            // 
            this.PrefectureName.AutoSize = true;
            this.PrefectureName.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PrefectureName.Location = new System.Drawing.Point(3, 8);
            this.PrefectureName.Name = "PrefectureName";
            this.PrefectureName.Size = new System.Drawing.Size(280, 19);
            this.PrefectureName.TabIndex = 4;
            this.PrefectureName.Text = "天気を知りたい地方をお選びください";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(406, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "日にちをお選びください";
            // 
            // cbDay
            // 
            this.cbDay.FormattingEnabled = true;
            this.cbDay.Location = new System.Drawing.Point(605, 8);
            this.cbDay.Name = "cbDay";
            this.cbDay.Size = new System.Drawing.Size(111, 20);
            this.cbDay.TabIndex = 7;
            // 
            // tbDay
            // 
            this.tbDay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDay.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbDay.Location = new System.Drawing.Point(58, 218);
            this.tbDay.Multiline = true;
            this.tbDay.Name = "tbDay";
            this.tbDay.Size = new System.Drawing.Size(183, 23);
            this.tbDay.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(4, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "天気";
            // 
            // pbWether
            // 
            this.pbWether.Location = new System.Drawing.Point(58, 59);
            this.pbWether.Name = "pbWether";
            this.pbWether.Size = new System.Drawing.Size(183, 160);
            this.pbWether.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbWether.TabIndex = 11;
            this.pbWether.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(289, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "最高気温";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(399, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "最低気温";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(289, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "風速";
            // 
            // WetherApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pbWether);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbDay);
            this.Controls.Add(this.cbDay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PrefectureName);
            this.Controls.Add(this.cbPrifecture);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btWetherGet);
            this.Controls.Add(this.tbWetherInfo);
            this.Name = "WetherApp";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbWether)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbWetherInfo;
        private System.Windows.Forms.Button btWetherGet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPrifecture;
        private System.Windows.Forms.Label PrefectureName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbDay;
        private System.Windows.Forms.TextBox tbDay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbWether;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

