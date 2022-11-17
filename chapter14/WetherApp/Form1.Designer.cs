
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
            this.cbPrifecture = new System.Windows.Forms.ComboBox();
            this.PrefectureName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbDay = new System.Windows.Forms.ComboBox();
            this.btDayGet = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbWetherInfo
            // 
            this.tbWetherInfo.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbWetherInfo.Location = new System.Drawing.Point(12, 323);
            this.tbWetherInfo.Multiline = true;
            this.tbWetherInfo.Name = "tbWetherInfo";
            this.tbWetherInfo.Size = new System.Drawing.Size(776, 115);
            this.tbWetherInfo.TabIndex = 0;
            // 
            // btWetherGet
            // 
            this.btWetherGet.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btWetherGet.Location = new System.Drawing.Point(198, 33);
            this.btWetherGet.Name = "btWetherGet";
            this.btWetherGet.Size = new System.Drawing.Size(103, 45);
            this.btWetherGet.TabIndex = 1;
            this.btWetherGet.Text = "決定";
            this.btWetherGet.UseVisualStyleBackColor = true;
            this.btWetherGet.Click += new System.EventHandler(this.btWetherGet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(12, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "天気概況";
            // 
            // cbPrifecture
            // 
            this.cbPrifecture.FormattingEnabled = true;
            this.cbPrifecture.Location = new System.Drawing.Point(7, 45);
            this.cbPrifecture.Name = "cbPrifecture";
            this.cbPrifecture.Size = new System.Drawing.Size(121, 20);
            this.cbPrifecture.TabIndex = 3;
            // 
            // PrefectureName
            // 
            this.PrefectureName.AutoSize = true;
            this.PrefectureName.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PrefectureName.Location = new System.Drawing.Point(3, 9);
            this.PrefectureName.Name = "PrefectureName";
            this.PrefectureName.Size = new System.Drawing.Size(307, 21);
            this.PrefectureName.TabIndex = 4;
            this.PrefectureName.Text = "天気を知りたい地方をお選びください";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(3, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = ".天気を知りたい日をお選びください";
            // 
            // cbDay
            // 
            this.cbDay.FormattingEnabled = true;
            this.cbDay.Location = new System.Drawing.Point(7, 142);
            this.cbDay.Name = "cbDay";
            this.cbDay.Size = new System.Drawing.Size(121, 20);
            this.cbDay.TabIndex = 7;
            // 
            // btDayGet
            // 
            this.btDayGet.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btDayGet.Location = new System.Drawing.Point(198, 125);
            this.btDayGet.Name = "btDayGet";
            this.btDayGet.Size = new System.Drawing.Size(103, 45);
            this.btDayGet.TabIndex = 1;
            this.btDayGet.Text = "決定";
            this.btDayGet.UseVisualStyleBackColor = true;
            //this.btDayGet.Click += new System.EventHandler(this.btDayGet_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(395, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "週間天気";
            // 
            // tbDay
            // 
            this.tbDay.Location = new System.Drawing.Point(399, 36);
            this.tbDay.Multiline = true;
            this.tbDay.Name = "tbDay";
            this.tbDay.Size = new System.Drawing.Size(389, 42);
            this.tbDay.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbDay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbDay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PrefectureName);
            this.Controls.Add(this.cbPrifecture);
            this.Controls.Add(this.btDayGet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btWetherGet);
            this.Controls.Add(this.tbWetherInfo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Button btDayGet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDay;
    }
}

