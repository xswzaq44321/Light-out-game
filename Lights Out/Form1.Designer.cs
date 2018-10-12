namespace Lights_Out
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.button_start = new System.Windows.Forms.Button();
			this.textBox_size = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.button_back = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button_start
			// 
			this.button_start.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.button_start.Location = new System.Drawing.Point(337, 262);
			this.button_start.Name = "button_start";
			this.button_start.Size = new System.Drawing.Size(90, 22);
			this.button_start.TabIndex = 0;
			this.button_start.Text = "Start";
			this.button_start.UseVisualStyleBackColor = true;
			this.button_start.Click += new System.EventHandler(this.button_start_Click);
			// 
			// textBox_size
			// 
			this.textBox_size.Location = new System.Drawing.Point(219, 262);
			this.textBox_size.Name = "textBox_size";
			this.textBox_size.Size = new System.Drawing.Size(100, 22);
			this.textBox_size.TabIndex = 1;
			this.textBox_size.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_size_KeyDown);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(103, 265);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(108, 16);
			this.label1.TabIndex = 2;
			this.label1.Text = "Enter board Size:";
			// 
			// button_back
			// 
			this.button_back.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.button_back.Location = new System.Drawing.Point(12, 12);
			this.button_back.Name = "button_back";
			this.button_back.Size = new System.Drawing.Size(25, 25);
			this.button_back.TabIndex = 3;
			this.button_back.Text = "←";
			this.button_back.UseVisualStyleBackColor = true;
			this.button_back.Click += new System.EventHandler(this.button_back_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(623, 577);
			this.Controls.Add(this.button_back);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox_size);
			this.Controls.Add(this.button_start);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button_start;
		private System.Windows.Forms.TextBox textBox_size;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button_back;
	}
}

