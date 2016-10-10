﻿namespace IntegratedAuthoringToolWF
{
	partial class TextToSpeechForm
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this._voiceComboBox = new System.Windows.Forms.ComboBox();
			this._speachRateSlider = new System.Windows.Forms.TrackBar();
			this._pitchValueLabel = new System.Windows.Forms.Label();
			this._pitchSlider = new System.Windows.Forms.TrackBar();
			this._generateButton = new System.Windows.Forms.Button();
			this._rateTextBox = new System.Windows.Forms.TextBox();
			this._dialogOptions = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this._visemeDisplay = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this._speachRateSlider)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._pitchSlider)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.tableLayoutPanel5.SuspendLayout();
			this.tableLayoutPanel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this._visemeDisplay)).BeginInit();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.AcceptsReturn = true;
			this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox1.Location = new System.Drawing.Point(3, 36);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox1.Size = new System.Drawing.Size(468, 222);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "Hello, World!";
			this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
			// 
			// button1
			// 
			this.button1.Dock = System.Windows.Forms.DockStyle.Top;
			this.button1.Location = new System.Drawing.Point(3, 3);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(82, 33);
			this.button1.TabIndex = 1;
			this.button1.Text = "Test Speech";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.OnTestButtonClick);
			// 
			// _voiceComboBox
			// 
			this._voiceComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this._voiceComboBox.FormattingEnabled = true;
			this._voiceComboBox.Location = new System.Drawing.Point(3, 3);
			this._voiceComboBox.Name = "_voiceComboBox";
			this._voiceComboBox.Size = new System.Drawing.Size(362, 21);
			this._voiceComboBox.TabIndex = 2;
			this._voiceComboBox.SelectionChangeCommitted += new System.EventHandler(this.OnVoiceSelectionChange);
			// 
			// _speachRateSlider
			// 
			this._speachRateSlider.Dock = System.Windows.Forms.DockStyle.Fill;
			this._speachRateSlider.Location = new System.Drawing.Point(3, 30);
			this._speachRateSlider.Maximum = 3000;
			this._speachRateSlider.Minimum = 300;
			this._speachRateSlider.Name = "_speachRateSlider";
			this._speachRateSlider.Size = new System.Drawing.Size(362, 45);
			this._speachRateSlider.TabIndex = 3;
			this._speachRateSlider.TickStyle = System.Windows.Forms.TickStyle.None;
			this._speachRateSlider.Value = 1000;
			this._speachRateSlider.ValueChanged += new System.EventHandler(this.OnRateValueChanged);
			// 
			// _pitchValueLabel
			// 
			this._pitchValueLabel.AutoSize = true;
			this._pitchValueLabel.Location = new System.Drawing.Point(3, 155);
			this._pitchValueLabel.Name = "_pitchValueLabel";
			this._pitchValueLabel.Size = new System.Drawing.Size(89, 13);
			this._pitchValueLabel.TabIndex = 6;
			this._pitchValueLabel.Text = "_pitchValueLabel";
			// 
			// _pitchSlider
			// 
			this._pitchSlider.Dock = System.Windows.Forms.DockStyle.Fill;
			this._pitchSlider.Location = new System.Drawing.Point(3, 107);
			this._pitchSlider.Minimum = -10;
			this._pitchSlider.Name = "_pitchSlider";
			this._pitchSlider.Size = new System.Drawing.Size(362, 45);
			this._pitchSlider.TabIndex = 5;
			this._pitchSlider.TickStyle = System.Windows.Forms.TickStyle.None;
			this._pitchSlider.ValueChanged += new System.EventHandler(this.OnPitchValueChanged);
			// 
			// _generateButton
			// 
			this._generateButton.Dock = System.Windows.Forms.DockStyle.Top;
			this._generateButton.Location = new System.Drawing.Point(3, 130);
			this._generateButton.Name = "_generateButton";
			this._generateButton.Size = new System.Drawing.Size(82, 34);
			this._generateButton.TabIndex = 7;
			this._generateButton.Text = "Generate";
			this._generateButton.UseVisualStyleBackColor = true;
			this._generateButton.Click += new System.EventHandler(this.OnGenerateButtonClick);
			// 
			// _rateTextBox
			// 
			this._rateTextBox.Location = new System.Drawing.Point(3, 81);
			this._rateTextBox.Name = "_rateTextBox";
			this._rateTextBox.Size = new System.Drawing.Size(100, 20);
			this._rateTextBox.TabIndex = 8;
			this._rateTextBox.Validated += new System.EventHandler(this.OnValidatedRateTextBox);
			// 
			// _dialogOptions
			// 
			this._dialogOptions.Dock = System.Windows.Forms.DockStyle.Fill;
			this._dialogOptions.FormattingEnabled = true;
			this._dialogOptions.Location = new System.Drawing.Point(100, 3);
			this._dialogOptions.Name = "_dialogOptions";
			this._dialogOptions.Size = new System.Drawing.Size(365, 21);
			this._dialogOptions.TabIndex = 9;
			this._dialogOptions.SelectionChangeCommitted += new System.EventHandler(this._dialogOptions_SelectionChangeCommitted);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(91, 27);
			this.label1.TabIndex = 10;
			this.label1.Text = "Available Dialogs:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.AutoSize = true;
			this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this._dialogOptions, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(468, 27);
			this.tableLayoutPanel1.TabIndex = 11;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 1;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.textBox1, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 2);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(5, 5);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 3;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 190F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(474, 451);
			this.tableLayoutPanel2.TabIndex = 12;
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.AutoSize = true;
			this.tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel3.ColumnCount = 2;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 1, 0);
			this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
			this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 264);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 1;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(468, 184);
			this.tableLayoutPanel3.TabIndex = 13;
			// 
			// tableLayoutPanel5
			// 
			this.tableLayoutPanel5.ColumnCount = 1;
			this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel5.Controls.Add(this.button1, 0, 0);
			this.tableLayoutPanel5.Controls.Add(this._generateButton, 0, 2);
			this.tableLayoutPanel5.Controls.Add(this._visemeDisplay, 0, 1);
			this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel5.Location = new System.Drawing.Point(377, 3);
			this.tableLayoutPanel5.Name = "tableLayoutPanel5";
			this.tableLayoutPanel5.RowCount = 4;
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel5.Size = new System.Drawing.Size(88, 178);
			this.tableLayoutPanel5.TabIndex = 13;
			// 
			// tableLayoutPanel4
			// 
			this.tableLayoutPanel4.AutoSize = true;
			this.tableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel4.ColumnCount = 1;
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel4.Controls.Add(this._rateTextBox, 0, 2);
			this.tableLayoutPanel4.Controls.Add(this._pitchValueLabel, 0, 4);
			this.tableLayoutPanel4.Controls.Add(this._voiceComboBox, 0, 0);
			this.tableLayoutPanel4.Controls.Add(this._pitchSlider, 0, 3);
			this.tableLayoutPanel4.Controls.Add(this._speachRateSlider, 0, 1);
			this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel4.Name = "tableLayoutPanel4";
			this.tableLayoutPanel4.RowCount = 5;
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel4.Size = new System.Drawing.Size(368, 178);
			this.tableLayoutPanel4.TabIndex = 13;
			// 
			// _visemeDisplay
			// 
			this._visemeDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
			this._visemeDisplay.Location = new System.Drawing.Point(3, 42);
			this._visemeDisplay.Name = "_visemeDisplay";
			this._visemeDisplay.Size = new System.Drawing.Size(82, 82);
			this._visemeDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this._visemeDisplay.TabIndex = 8;
			this._visemeDisplay.TabStop = false;
			// 
			// TextToSpeechForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 461);
			this.Controls.Add(this.tableLayoutPanel2);
			this.MinimumSize = new System.Drawing.Size(500, 500);
			this.Name = "TextToSpeechForm";
			this.Padding = new System.Windows.Forms.Padding(5);
			this.Text = "Form1";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnFormClosed);
			((System.ComponentModel.ISupportInitialize)(this._speachRateSlider)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._pitchSlider)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel3.PerformLayout();
			this.tableLayoutPanel5.ResumeLayout(false);
			this.tableLayoutPanel4.ResumeLayout(false);
			this.tableLayoutPanel4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this._visemeDisplay)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ComboBox _voiceComboBox;
		private System.Windows.Forms.TrackBar _speachRateSlider;
		private System.Windows.Forms.Label _pitchValueLabel;
		private System.Windows.Forms.TrackBar _pitchSlider;
		private System.Windows.Forms.Button _generateButton;
		private System.Windows.Forms.TextBox _rateTextBox;
		private System.Windows.Forms.ComboBox _dialogOptions;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
		private System.Windows.Forms.PictureBox _visemeDisplay;
	}
}