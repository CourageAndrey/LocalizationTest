namespace Test.WinForms
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.comboBoxLanguages = new System.Windows.Forms.ComboBox();
			this.languageBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.languageBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.languageBindingSource, "Button1", true));
			this.button1.Location = new System.Drawing.Point(57, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(99, 26);
			this.button1.TabIndex = 0;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.languageBindingSource, "Button2", true));
			this.button2.Location = new System.Drawing.Point(57, 44);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(99, 26);
			this.button2.TabIndex = 1;
			this.button2.Text = "button2";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// comboBoxLanguages
			// 
			this.comboBoxLanguages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxLanguages.FormattingEnabled = true;
			this.comboBoxLanguages.Location = new System.Drawing.Point(45, 81);
			this.comboBoxLanguages.Name = "comboBoxLanguages";
			this.comboBoxLanguages.Size = new System.Drawing.Size(121, 21);
			this.comboBoxLanguages.TabIndex = 2;
			this.comboBoxLanguages.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
			// 
			// languageBindingSource
			// 
			this.languageBindingSource.DataSource = typeof(Test.Localization.Language);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(12, 114);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(187, 98);
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(211, 224);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.comboBoxLanguages);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.languageBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.ComboBox comboBoxLanguages;
		private System.Windows.Forms.BindingSource languageBindingSource;
		private System.Windows.Forms.PictureBox pictureBox1;

	}
}

