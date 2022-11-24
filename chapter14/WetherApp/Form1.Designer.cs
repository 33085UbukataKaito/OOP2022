
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
            this.pbWether = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTempMax = new System.Windows.Forms.TextBox();
            this.tbTempMin = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pb4 = new System.Windows.Forms.PictureBox();
            this.pb5 = new System.Windows.Forms.PictureBox();
            this.pb6 = new System.Windows.Forms.PictureBox();
            this.pb7 = new System.Windows.Forms.PictureBox();
            this.tbmax2 = new System.Windows.Forms.TextBox();
            this.tbmax3 = new System.Windows.Forms.TextBox();
            this.tbmax4 = new System.Windows.Forms.TextBox();
            this.tbmax5 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbWether)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb7)).BeginInit();
            this.SuspendLayout();
            // 
            // tbWetherInfo
            // 
            this.tbWetherInfo.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbWetherInfo.Location = new System.Drawing.Point(7, 267);
            this.tbWetherInfo.Multiline = true;
            this.tbWetherInfo.Name = "tbWetherInfo";
            this.tbWetherInfo.Size = new System.Drawing.Size(781, 186);
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
            this.label1.Location = new System.Drawing.Point(7, 235);
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
            this.PrefectureName.Font = new System.Drawing.Font("HGP創英角ﾎﾟｯﾌﾟ体", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PrefectureName.Location = new System.Drawing.Point(3, 8);
            this.PrefectureName.Name = "PrefectureName";
            this.PrefectureName.Size = new System.Drawing.Size(264, 16);
            this.PrefectureName.TabIndex = 4;
            this.PrefectureName.Text = "天気を知りたい地方をお選びください";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("HGP創英角ｺﾞｼｯｸUB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(406, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 19);
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
            this.tbDay.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbDay.Location = new System.Drawing.Point(7, 194);
            this.tbDay.Multiline = true;
            this.tbDay.Name = "tbDay";
            this.tbDay.Size = new System.Drawing.Size(183, 27);
            this.tbDay.TabIndex = 9;
            // 
            // pbWether
            // 
            this.pbWether.Location = new System.Drawing.Point(7, 30);
            this.pbWether.Name = "pbWether";
            this.pbWether.Size = new System.Drawing.Size(183, 160);
            this.pbWether.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbWether.TabIndex = 11;
            this.pbWether.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("HGP創英角ｺﾞｼｯｸUB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(215, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "最高気温";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("HGP創英角ｺﾞｼｯｸUB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(218, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "最低気温";
            // 
            // tbTempMax
            // 
            this.tbTempMax.BackColor = System.Drawing.Color.White;
            this.tbTempMax.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbTempMax.ForeColor = System.Drawing.Color.Red;
            this.tbTempMax.Location = new System.Drawing.Point(212, 65);
            this.tbTempMax.Multiline = true;
            this.tbTempMax.Name = "tbTempMax";
            this.tbTempMax.Size = new System.Drawing.Size(76, 43);
            this.tbTempMax.TabIndex = 15;
            // 
            // tbTempMin
            // 
            this.tbTempMin.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbTempMin.ForeColor = System.Drawing.Color.Blue;
            this.tbTempMin.Location = new System.Drawing.Point(212, 174);
            this.tbTempMin.Multiline = true;
            this.tbTempMin.Name = "tbTempMin";
            this.tbTempMin.Size = new System.Drawing.Size(76, 47);
            this.tbTempMin.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("HG創英角ｺﾞｼｯｸUB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(398, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(220, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "週間天気概況(明後日以降）";
            // 
            // pb4
            // 
            this.pb4.Location = new System.Drawing.Point(401, 66);
            this.pb4.Name = "pb4";
            this.pb4.Size = new System.Drawing.Size(85, 86);
            this.pb4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb4.TabIndex = 16;
            this.pb4.TabStop = false;
            // 
            // pb5
            // 
            this.pb5.Location = new System.Drawing.Point(498, 66);
            this.pb5.Name = "pb5";
            this.pb5.Size = new System.Drawing.Size(92, 86);
            this.pb5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb5.TabIndex = 16;
            this.pb5.TabStop = false;
            // 
            // pb6
            // 
            this.pb6.Location = new System.Drawing.Point(605, 66);
            this.pb6.Name = "pb6";
            this.pb6.Size = new System.Drawing.Size(89, 86);
            this.pb6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb6.TabIndex = 16;
            this.pb6.TabStop = false;
            // 
            // pb7
            // 
            this.pb7.Location = new System.Drawing.Point(700, 65);
            this.pb7.Name = "pb7";
            this.pb7.Size = new System.Drawing.Size(88, 87);
            this.pb7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb7.TabIndex = 16;
            this.pb7.TabStop = false;
            // 
            // tbmax2
            // 
            this.tbmax2.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbmax2.ForeColor = System.Drawing.Color.Black;
            this.tbmax2.Location = new System.Drawing.Point(405, 184);
            this.tbmax2.Multiline = true;
            this.tbmax2.Name = "tbmax2";
            this.tbmax2.Size = new System.Drawing.Size(76, 47);
            this.tbmax2.TabIndex = 15;
            // 
            // tbmax3
            // 
            this.tbmax3.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbmax3.ForeColor = System.Drawing.Color.Black;
            this.tbmax3.Location = new System.Drawing.Point(507, 182);
            this.tbmax3.Multiline = true;
            this.tbmax3.Name = "tbmax3";
            this.tbmax3.Size = new System.Drawing.Size(76, 47);
            this.tbmax3.TabIndex = 15;
            // 
            // tbmax4
            // 
            this.tbmax4.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbmax4.ForeColor = System.Drawing.Color.Black;
            this.tbmax4.Location = new System.Drawing.Point(613, 183);
            this.tbmax4.Multiline = true;
            this.tbmax4.Name = "tbmax4";
            this.tbmax4.Size = new System.Drawing.Size(76, 47);
            this.tbmax4.TabIndex = 15;
            // 
            // tbmax5
            // 
            this.tbmax5.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbmax5.ForeColor = System.Drawing.Color.Black;
            this.tbmax5.Location = new System.Drawing.Point(707, 182);
            this.tbmax5.Multiline = true;
            this.tbmax5.Name = "tbmax5";
            this.tbmax5.Size = new System.Drawing.Size(76, 47);
            this.tbmax5.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("HGP創英角ｺﾞｼｯｸUB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(398, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "最高";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(435, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 12);
            this.label7.TabIndex = 18;
            this.label7.Text = "/";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("HGP創英角ｺﾞｼｯｸUB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(449, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "最低";
            // 
            // WetherApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pb7);
            this.Controls.Add(this.pb6);
            this.Controls.Add(this.pb5);
            this.Controls.Add(this.pb4);
            this.Controls.Add(this.tbmax5);
            this.Controls.Add(this.tbmax4);
            this.Controls.Add(this.tbmax3);
            this.Controls.Add(this.tbmax2);
            this.Controls.Add(this.tbTempMin);
            this.Controls.Add(this.tbTempMax);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pbWether);
            this.Controls.Add(this.tbDay);
            this.Controls.Add(this.cbDay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PrefectureName);
            this.Controls.Add(this.cbPrifecture);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btWetherGet);
            this.Controls.Add(this.tbWetherInfo);
            this.Name = "WetherApp";
            this.Text = "天気予報アプリ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbWether)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb7)).EndInit();
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
        private System.Windows.Forms.PictureBox pbWether;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbTempMax;
        private System.Windows.Forms.TextBox tbTempMin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pb4;
        private System.Windows.Forms.PictureBox pb5;
        private System.Windows.Forms.PictureBox pb6;
        private System.Windows.Forms.PictureBox pb7;
        private System.Windows.Forms.TextBox tbmax2;
        private System.Windows.Forms.TextBox tbmax3;
        private System.Windows.Forms.TextBox tbmax4;
        private System.Windows.Forms.TextBox tbmax5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

