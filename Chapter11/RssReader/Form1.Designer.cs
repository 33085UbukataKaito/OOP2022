
namespace RssReader {
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
            this.btRSSget = new System.Windows.Forms.Button();
            this.cbRSSURL = new System.Windows.Forms.ComboBox();
            this.lbRSSTitle = new System.Windows.Forms.ListBox();
            this.btPreview = new System.Windows.Forms.Button();
            this.btNext = new System.Windows.Forms.Button();
            this.wvBrowser = new Microsoft.Toolkit.Forms.UI.Controls.WebView();
            ((System.ComponentModel.ISupportInitialize)(this.wvBrowser)).BeginInit();
            this.SuspendLayout();
            // 
            // btRSSget
            // 
            this.btRSSget.Location = new System.Drawing.Point(963, 12);
            this.btRSSget.Name = "btRSSget";
            this.btRSSget.Size = new System.Drawing.Size(75, 23);
            this.btRSSget.TabIndex = 0;
            this.btRSSget.Text = "取得";
            this.btRSSget.UseVisualStyleBackColor = true;
            this.btRSSget.Click += new System.EventHandler(this.btRSSget_Click);
            // 
            // cbRSSURL
            // 
            this.cbRSSURL.FormattingEnabled = true;
            this.cbRSSURL.Location = new System.Drawing.Point(23, 12);
            this.cbRSSURL.Name = "cbRSSURL";
            this.cbRSSURL.Size = new System.Drawing.Size(909, 20);
            this.cbRSSURL.TabIndex = 1;
            // 
            // lbRSSTitle
            // 
            this.lbRSSTitle.FormattingEnabled = true;
            this.lbRSSTitle.ItemHeight = 12;
            this.lbRSSTitle.Location = new System.Drawing.Point(23, 88);
            this.lbRSSTitle.Name = "lbRSSTitle";
            this.lbRSSTitle.Size = new System.Drawing.Size(214, 772);
            this.lbRSSTitle.TabIndex = 2;
            this.lbRSSTitle.Click += new System.EventHandler(this.lbRSSTitle_Click);
            // 
            // btPreview
            // 
            this.btPreview.Location = new System.Drawing.Point(23, 54);
            this.btPreview.Name = "btPreview";
            this.btPreview.Size = new System.Drawing.Size(75, 23);
            this.btPreview.TabIndex = 4;
            this.btPreview.Text = "前の記事";
            this.btPreview.UseVisualStyleBackColor = true;
            this.btPreview.Click += new System.EventHandler(this.btPreview_Click);
            // 
            // btNext
            // 
            this.btNext.Location = new System.Drawing.Point(162, 54);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(75, 23);
            this.btNext.TabIndex = 4;
            this.btNext.Text = "次の記事";
            this.btNext.UseVisualStyleBackColor = true;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // wvBrowser
            // 
            this.wvBrowser.Location = new System.Drawing.Point(263, 54);
            this.wvBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.wvBrowser.Name = "wvBrowser";
            this.wvBrowser.Size = new System.Drawing.Size(784, 806);
            this.wvBrowser.TabIndex = 5;
            this.wvBrowser.NavigationCompleted += new System.EventHandler<Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT.WebViewControlNavigationCompletedEventArgs>(this.wvBrowser_NavigationCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 942);
            this.Controls.Add(this.wvBrowser);
            this.Controls.Add(this.btNext);
            this.Controls.Add(this.btPreview);
            this.Controls.Add(this.lbRSSTitle);
            this.Controls.Add(this.cbRSSURL);
            this.Controls.Add(this.btRSSget);
            this.Name = "Form1";
            this.Text = "RSSReader";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wvBrowser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btRSSget;
        private System.Windows.Forms.ComboBox cbRSSURL;
        private System.Windows.Forms.ListBox lbRSSTitle;
        private System.Windows.Forms.Button btPreview;
        private System.Windows.Forms.Button btNext;
        private Microsoft.Toolkit.Forms.UI.Controls.WebView wvBrowser;
    }
}

