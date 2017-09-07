namespace False_Artist
{
    partial class start
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
            this.start_btn = new System.Windows.Forms.Button();
            this.people = new System.Windows.Forms.TextBox();
            this.text_people = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // start_btn
            // 
            this.start_btn.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.start_btn.Location = new System.Drawing.Point(152, 209);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(212, 48);
            this.start_btn.TabIndex = 0;
            this.start_btn.Text = "Start";
            this.start_btn.UseVisualStyleBackColor = true;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // people
            // 
            this.people.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.people.Location = new System.Drawing.Point(152, 87);
            this.people.Name = "people";
            this.people.Size = new System.Drawing.Size(136, 55);
            this.people.TabIndex = 1;
            // 
            // text_people
            // 
            this.text_people.AutoSize = true;
            this.text_people.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.text_people.Location = new System.Drawing.Point(294, 90);
            this.text_people.Name = "text_people";
            this.text_people.Size = new System.Drawing.Size(68, 48);
            this.text_people.TabIndex = 2;
            this.text_people.Text = "人";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label.Location = new System.Drawing.Point(148, 48);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(111, 24);
            this.label.TabIndex = 3;
            this.label.Text = "プレイ人数";
            // 
            // start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 340);
            this.Controls.Add(this.label);
            this.Controls.Add(this.text_people);
            this.Controls.Add(this.people);
            this.Controls.Add(this.start_btn);
            this.Name = "start";
            this.Text = "Start";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.TextBox people;
        private System.Windows.Forms.Label text_people;
        private System.Windows.Forms.Label label;
    }
}

