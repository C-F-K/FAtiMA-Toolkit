﻿namespace EmotionalDecisionMakingWF
{
    partial class MainForm
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
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.buttonEditReaction = new System.Windows.Forms.Button();
            this.buttonAddReaction = new System.Windows.Forms.Button();
            this.buttonRemoveReaction = new System.Windows.Forms.Button();
            this.dataGridViewReactiveActions = new System.Windows.Forms.DataGridView();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.conditionSetEditor = new GAIPS.AssetEditorTools.ConditionSetEditorControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReactiveActions)).BeginInit();
            this.groupBox8.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.buttonEditReaction);
            this.groupBox7.Controls.Add(this.buttonAddReaction);
            this.groupBox7.Controls.Add(this.buttonRemoveReaction);
            this.groupBox7.Controls.Add(this.dataGridViewReactiveActions);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox7.Location = new System.Drawing.Point(0, 0);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(495, 276);
            this.groupBox7.TabIndex = 3;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Decision Rules";
            this.groupBox7.Enter += new System.EventHandler(this.groupBox7_Enter);
            // 
            // buttonEditReaction
            // 
            this.buttonEditReaction.Location = new System.Drawing.Point(66, 19);
            this.buttonEditReaction.Name = "buttonEditReaction";
            this.buttonEditReaction.Size = new System.Drawing.Size(70, 23);
            this.buttonEditReaction.TabIndex = 9;
            this.buttonEditReaction.Text = "Edit";
            this.buttonEditReaction.UseVisualStyleBackColor = true;
            this.buttonEditReaction.Click += new System.EventHandler(this.buttonEditReaction_Click);
            // 
            // buttonAddReaction
            // 
            this.buttonAddReaction.Location = new System.Drawing.Point(6, 19);
            this.buttonAddReaction.Name = "buttonAddReaction";
            this.buttonAddReaction.Size = new System.Drawing.Size(54, 23);
            this.buttonAddReaction.TabIndex = 7;
            this.buttonAddReaction.Text = "Add";
            this.buttonAddReaction.UseVisualStyleBackColor = true;
            this.buttonAddReaction.Click += new System.EventHandler(this.buttonAddReaction_Click);
            // 
            // buttonRemoveReaction
            // 
            this.buttonRemoveReaction.Location = new System.Drawing.Point(142, 19);
            this.buttonRemoveReaction.Name = "buttonRemoveReaction";
            this.buttonRemoveReaction.Size = new System.Drawing.Size(70, 23);
            this.buttonRemoveReaction.TabIndex = 8;
            this.buttonRemoveReaction.Text = "Remove";
            this.buttonRemoveReaction.UseVisualStyleBackColor = true;
            this.buttonRemoveReaction.Click += new System.EventHandler(this.buttonRemoveReaction_Click);
            // 
            // dataGridViewReactiveActions
            // 
            this.dataGridViewReactiveActions.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridViewReactiveActions.AllowUserToAddRows = false;
            this.dataGridViewReactiveActions.AllowUserToDeleteRows = false;
            this.dataGridViewReactiveActions.AllowUserToOrderColumns = true;
            this.dataGridViewReactiveActions.AllowUserToResizeRows = false;
            this.dataGridViewReactiveActions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewReactiveActions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewReactiveActions.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewReactiveActions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReactiveActions.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dataGridViewReactiveActions.Location = new System.Drawing.Point(6, 54);
            this.dataGridViewReactiveActions.Name = "dataGridViewReactiveActions";
            this.dataGridViewReactiveActions.ReadOnly = true;
            this.dataGridViewReactiveActions.RowHeadersVisible = false;
            this.dataGridViewReactiveActions.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewReactiveActions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewReactiveActions.Size = new System.Drawing.Size(483, 216);
            this.dataGridViewReactiveActions.TabIndex = 2;
            this.dataGridViewReactiveActions.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewReactiveActions_CellMouseDoubleClick);
            this.dataGridViewReactiveActions.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewReactiveActions_RowEnter);
            // 
            // groupBox8
            // 
            this.groupBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox8.Controls.Add(this.conditionSetEditor);
            this.groupBox8.Location = new System.Drawing.Point(0, 3);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(495, 171);
            this.groupBox8.TabIndex = 11;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Conditions";
            // 
            // conditionSetEditor
            // 
            this.conditionSetEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.conditionSetEditor.Location = new System.Drawing.Point(3, 16);
            this.conditionSetEditor.Name = "conditionSetEditor";
            this.conditionSetEditor.Size = new System.Drawing.Size(489, 152);
            this.conditionSetEditor.TabIndex = 0;
            this.conditionSetEditor.View = null;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.richTextBoxDescription);
            this.groupBox2.Location = new System.Drawing.Point(0, 180);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(495, 89);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Description";
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxDescription.CausesValidation = false;
            this.richTextBoxDescription.Location = new System.Drawing.Point(9, 19);
            this.richTextBoxDescription.Multiline = false;
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(480, 64);
            this.richTextBoxDescription.TabIndex = 0;
            this.richTextBoxDescription.Text = "";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 27);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox7);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox8);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(495, 553);
            this.splitContainer1.SplitterDistance = 276;
            this.splitContainer1.TabIndex = 17;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 592);
            this.Controls.Add(this.splitContainer1);
            this.EditorName = "EDM Editor";
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Controls.SetChildIndex(this.splitContainer1, 0);
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReactiveActions)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button buttonEditReaction;
        private System.Windows.Forms.Button buttonAddReaction;
        private System.Windows.Forms.Button buttonRemoveReaction;
        private System.Windows.Forms.DataGridView dataGridViewReactiveActions;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.SplitContainer splitContainer1;
		private GAIPS.AssetEditorTools.ConditionSetEditorControl conditionSetEditor;
	}
}
