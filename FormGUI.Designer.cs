namespace AspnetCompilerGUI
{
    partial class FormGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGUI));
            this.buttonCompile = new System.Windows.Forms.Button();
            this.textSourceVirtual = new System.Windows.Forms.TextBox();
            this.textTarget = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkFull = new System.Windows.Forms.CheckBox();
            this.checkFixed = new System.Windows.Forms.CheckBox();
            this.checkDebug = new System.Windows.Forms.CheckBox();
            this.checkOverwrite = new System.Windows.Forms.CheckBox();
            this.checkUpdateable = new System.Windows.Forms.CheckBox();
            this.groupMerge = new System.Windows.Forms.GroupBox();
            this.checkXML = new System.Windows.Forms.CheckBox();
            this.checkRemoveCompiled = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radioMergeNone = new System.Windows.Forms.RadioButton();
            this.radioMergeMulti = new System.Windows.Forms.RadioButton();
            this.radioMergeSingle = new System.Windows.Forms.RadioButton();
            this.textMergeSingle = new System.Windows.Forms.TextBox();
            this.textMergeMulti = new System.Windows.Forms.TextBox();
            this.textResult = new System.Windows.Forms.TextBox();
            this.buttonTarget = new System.Windows.Forms.Button();
            this.folderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.radioVirtual = new System.Windows.Forms.RadioButton();
            this.radioPhysical = new System.Windows.Forms.RadioButton();
            this.checkTarget = new System.Windows.Forms.CheckBox();
            this.buttonSourcePhysical = new System.Windows.Forms.Button();
            this.textSourcePhysical = new System.Windows.Forms.TextBox();
            this.radioMetabase = new System.Windows.Forms.RadioButton();
            this.textSourceMetabase = new System.Windows.Forms.TextBox();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupMerge.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCompile
            // 
            this.buttonCompile.Location = new System.Drawing.Point(288, 491);
            this.buttonCompile.Name = "buttonCompile";
            this.buttonCompile.Size = new System.Drawing.Size(121, 26);
            this.buttonCompile.TabIndex = 25;
            this.buttonCompile.Text = "Compile";
            this.buttonCompile.UseVisualStyleBackColor = true;
            this.buttonCompile.Click += new System.EventHandler(this.buttonCompile_Click);
            // 
            // textSourceVirtual
            // 
            this.textSourceVirtual.Enabled = false;
            this.textSourceVirtual.Location = new System.Drawing.Point(123, 38);
            this.textSourceVirtual.Name = "textSourceVirtual";
            this.textSourceVirtual.Size = new System.Drawing.Size(252, 20);
            this.textSourceVirtual.TabIndex = 5;
            // 
            // textTarget
            // 
            this.textTarget.Location = new System.Drawing.Point(123, 99);
            this.textTarget.Name = "textTarget";
            this.textTarget.Size = new System.Drawing.Size(252, 20);
            this.textTarget.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkFull);
            this.groupBox1.Controls.Add(this.checkFixed);
            this.groupBox1.Controls.Add(this.checkDebug);
            this.groupBox1.Controls.Add(this.checkOverwrite);
            this.groupBox1.Controls.Add(this.checkUpdateable);
            this.groupBox1.Location = new System.Drawing.Point(12, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 91);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Compilation";
            // 
            // checkFull
            // 
            this.checkFull.AutoSize = true;
            this.checkFull.Location = new System.Drawing.Point(6, 66);
            this.checkFull.Name = "checkFull";
            this.checkFull.Size = new System.Drawing.Size(76, 17);
            this.checkFull.TabIndex = 13;
            this.checkFull.Text = "Full rebuild";
            this.checkFull.UseVisualStyleBackColor = true;
            // 
            // checkFixed
            // 
            this.checkFixed.AutoSize = true;
            this.checkFixed.Checked = true;
            this.checkFixed.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkFixed.Location = new System.Drawing.Point(191, 43);
            this.checkFixed.Name = "checkFixed";
            this.checkFixed.Size = new System.Drawing.Size(154, 17);
            this.checkFixed.TabIndex = 15;
            this.checkFixed.Text = "Fixed names for assemblies";
            this.checkFixed.UseVisualStyleBackColor = true;
            // 
            // checkDebug
            // 
            this.checkDebug.AutoSize = true;
            this.checkDebug.Location = new System.Drawing.Point(191, 20);
            this.checkDebug.Name = "checkDebug";
            this.checkDebug.Size = new System.Drawing.Size(149, 17);
            this.checkDebug.TabIndex = 14;
            this.checkDebug.Text = "Compile with Debug mode";
            this.checkDebug.UseVisualStyleBackColor = true;
            // 
            // checkOverwrite
            // 
            this.checkOverwrite.AutoSize = true;
            this.checkOverwrite.Checked = true;
            this.checkOverwrite.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkOverwrite.Location = new System.Drawing.Point(7, 43);
            this.checkOverwrite.Name = "checkOverwrite";
            this.checkOverwrite.Size = new System.Drawing.Size(128, 17);
            this.checkOverwrite.TabIndex = 12;
            this.checkOverwrite.Text = "Overwrite output path";
            this.checkOverwrite.UseVisualStyleBackColor = true;
            // 
            // checkUpdateable
            // 
            this.checkUpdateable.AutoSize = true;
            this.checkUpdateable.Checked = true;
            this.checkUpdateable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkUpdateable.Location = new System.Drawing.Point(7, 20);
            this.checkUpdateable.Name = "checkUpdateable";
            this.checkUpdateable.Size = new System.Drawing.Size(149, 17);
            this.checkUpdateable.TabIndex = 11;
            this.checkUpdateable.Text = "ASPX files are updateable";
            this.checkUpdateable.UseVisualStyleBackColor = true;
            // 
            // groupMerge
            // 
            this.groupMerge.Controls.Add(this.checkXML);
            this.groupMerge.Controls.Add(this.checkRemoveCompiled);
            this.groupMerge.Controls.Add(this.label2);
            this.groupMerge.Controls.Add(this.label1);
            this.groupMerge.Controls.Add(this.radioMergeNone);
            this.groupMerge.Controls.Add(this.radioMergeMulti);
            this.groupMerge.Controls.Add(this.radioMergeSingle);
            this.groupMerge.Controls.Add(this.textMergeSingle);
            this.groupMerge.Controls.Add(this.textMergeMulti);
            this.groupMerge.Location = new System.Drawing.Point(12, 225);
            this.groupMerge.Name = "groupMerge";
            this.groupMerge.Size = new System.Drawing.Size(397, 123);
            this.groupMerge.TabIndex = 4;
            this.groupMerge.TabStop = false;
            this.groupMerge.Text = "Merging";
            // 
            // checkXML
            // 
            this.checkXML.AutoSize = true;
            this.checkXML.Location = new System.Drawing.Point(190, 96);
            this.checkXML.Name = "checkXML";
            this.checkXML.Size = new System.Drawing.Size(159, 17);
            this.checkXML.TabIndex = 22;
            this.checkXML.Text = "Merges XML documentation";
            this.checkXML.UseVisualStyleBackColor = true;
            // 
            // checkRemoveCompiled
            // 
            this.checkRemoveCompiled.AutoSize = true;
            this.checkRemoveCompiled.Location = new System.Drawing.Point(6, 96);
            this.checkRemoveCompiled.Name = "checkRemoveCompiled";
            this.checkRemoveCompiled.Size = new System.Drawing.Size(135, 17);
            this.checkRemoveCompiled.TabIndex = 21;
            this.checkRemoveCompiled.Text = "Remove .compiled files";
            this.checkRemoveCompiled.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Prefix :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Output :";
            // 
            // radioMergeNone
            // 
            this.radioMergeNone.AutoSize = true;
            this.radioMergeNone.Checked = true;
            this.radioMergeNone.Location = new System.Drawing.Point(7, 21);
            this.radioMergeNone.Name = "radioMergeNone";
            this.radioMergeNone.Size = new System.Drawing.Size(51, 17);
            this.radioMergeNone.TabIndex = 16;
            this.radioMergeNone.TabStop = true;
            this.radioMergeNone.Text = "None";
            this.radioMergeNone.UseVisualStyleBackColor = true;
            // 
            // radioMergeMulti
            // 
            this.radioMergeMulti.AutoSize = true;
            this.radioMergeMulti.Location = new System.Drawing.Point(7, 66);
            this.radioMergeMulti.Name = "radioMergeMulti";
            this.radioMergeMulti.Size = new System.Drawing.Size(106, 17);
            this.radioMergeMulti.TabIndex = 19;
            this.radioMergeMulti.Text = "One per directory";
            this.radioMergeMulti.UseVisualStyleBackColor = true;
            this.radioMergeMulti.CheckedChanged += new System.EventHandler(this.radioMergeMulti_CheckedChanged);
            // 
            // radioMergeSingle
            // 
            this.radioMergeSingle.AutoSize = true;
            this.radioMergeSingle.Location = new System.Drawing.Point(7, 44);
            this.radioMergeSingle.Name = "radioMergeSingle";
            this.radioMergeSingle.Size = new System.Drawing.Size(101, 17);
            this.radioMergeSingle.TabIndex = 17;
            this.radioMergeSingle.Text = "Single Assembly";
            this.radioMergeSingle.UseVisualStyleBackColor = true;
            this.radioMergeSingle.CheckedChanged += new System.EventHandler(this.radioMergeSingle_CheckedChanged);
            // 
            // textMergeSingle
            // 
            this.textMergeSingle.Enabled = false;
            this.textMergeSingle.Location = new System.Drawing.Point(190, 41);
            this.textMergeSingle.Name = "textMergeSingle";
            this.textMergeSingle.Size = new System.Drawing.Size(198, 20);
            this.textMergeSingle.TabIndex = 18;
            // 
            // textMergeMulti
            // 
            this.textMergeMulti.Enabled = false;
            this.textMergeMulti.Location = new System.Drawing.Point(190, 64);
            this.textMergeMulti.Name = "textMergeMulti";
            this.textMergeMulti.Size = new System.Drawing.Size(198, 20);
            this.textMergeMulti.TabIndex = 20;
            // 
            // textResult
            // 
            this.textResult.Location = new System.Drawing.Point(12, 357);
            this.textResult.Multiline = true;
            this.textResult.Name = "textResult";
            this.textResult.ReadOnly = true;
            this.textResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textResult.Size = new System.Drawing.Size(397, 124);
            this.textResult.TabIndex = 23;
            // 
            // buttonTarget
            // 
            this.buttonTarget.Location = new System.Drawing.Point(381, 98);
            this.buttonTarget.Name = "buttonTarget";
            this.buttonTarget.Size = new System.Drawing.Size(28, 21);
            this.buttonTarget.TabIndex = 10;
            this.buttonTarget.Text = "...";
            this.buttonTarget.UseVisualStyleBackColor = true;
            this.buttonTarget.Click += new System.EventHandler(this.buttonTarget_Click);
            // 
            // radioVirtual
            // 
            this.radioVirtual.AutoSize = true;
            this.radioVirtual.Location = new System.Drawing.Point(13, 39);
            this.radioVirtual.Name = "radioVirtual";
            this.radioVirtual.Size = new System.Drawing.Size(85, 17);
            this.radioVirtual.TabIndex = 4;
            this.radioVirtual.Text = "Virtual Path :";
            this.radioVirtual.UseVisualStyleBackColor = true;
            this.radioVirtual.CheckedChanged += new System.EventHandler(this.radioVirtual_CheckedChanged);
            // 
            // radioPhysical
            // 
            this.radioPhysical.AutoSize = true;
            this.radioPhysical.Checked = true;
            this.radioPhysical.Location = new System.Drawing.Point(13, 13);
            this.radioPhysical.Name = "radioPhysical";
            this.radioPhysical.Size = new System.Drawing.Size(92, 17);
            this.radioPhysical.TabIndex = 1;
            this.radioPhysical.TabStop = true;
            this.radioPhysical.Text = "Phisical Path :";
            this.radioPhysical.UseVisualStyleBackColor = true;
            this.radioPhysical.CheckedChanged += new System.EventHandler(this.radioPhysical_CheckedChanged);
            // 
            // checkTarget
            // 
            this.checkTarget.AutoSize = true;
            this.checkTarget.Checked = true;
            this.checkTarget.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkTarget.Location = new System.Drawing.Point(13, 101);
            this.checkTarget.Name = "checkTarget";
            this.checkTarget.Size = new System.Drawing.Size(88, 17);
            this.checkTarget.TabIndex = 9;
            this.checkTarget.Text = "Target Path :";
            this.checkTarget.UseVisualStyleBackColor = true;
            this.checkTarget.CheckedChanged += new System.EventHandler(this.checkTarget_CheckedChanged);
            // 
            // buttonSourcePhysical
            // 
            this.buttonSourcePhysical.Location = new System.Drawing.Point(381, 12);
            this.buttonSourcePhysical.Name = "buttonSourcePhysical";
            this.buttonSourcePhysical.Size = new System.Drawing.Size(28, 21);
            this.buttonSourcePhysical.TabIndex = 3;
            this.buttonSourcePhysical.Text = "...";
            this.buttonSourcePhysical.UseVisualStyleBackColor = true;
            this.buttonSourcePhysical.Click += new System.EventHandler(this.buttonSourcePhysical_Click);
            // 
            // textSourcePhysical
            // 
            this.textSourcePhysical.Location = new System.Drawing.Point(123, 12);
            this.textSourcePhysical.Name = "textSourcePhysical";
            this.textSourcePhysical.Size = new System.Drawing.Size(252, 20);
            this.textSourcePhysical.TabIndex = 2;
            // 
            // radioMetabase
            // 
            this.radioMetabase.Location = new System.Drawing.Point(13, 65);
            this.radioMetabase.Name = "radioMetabase";
            this.radioMetabase.Size = new System.Drawing.Size(104, 20);
            this.radioMetabase.TabIndex = 6;
            this.radioMetabase.Text = "Metabase Path :";
            this.radioMetabase.UseVisualStyleBackColor = true;
            this.radioMetabase.CheckedChanged += new System.EventHandler(this.radioMetabase_CheckedChanged);
            // 
            // textSourceMetabase
            // 
            this.textSourceMetabase.Enabled = false;
            this.textSourceMetabase.Location = new System.Drawing.Point(123, 64);
            this.textSourceMetabase.Name = "textSourceMetabase";
            this.textSourceMetabase.Size = new System.Drawing.Size(252, 20);
            this.textSourceMetabase.TabIndex = 7;
            this.textSourceMetabase.Text = "/LM/W3SVC/";
            // 
            // buttonAbout
            // 
            this.buttonAbout.Location = new System.Drawing.Point(161, 490);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(121, 27);
            this.buttonAbout.TabIndex = 24;
            this.buttonAbout.Text = "About...";
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // FormGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 524);
            this.Controls.Add(this.buttonAbout);
            this.Controls.Add(this.radioMetabase);
            this.Controls.Add(this.textSourceMetabase);
            this.Controls.Add(this.buttonSourcePhysical);
            this.Controls.Add(this.textSourcePhysical);
            this.Controls.Add(this.checkTarget);
            this.Controls.Add(this.radioPhysical);
            this.Controls.Add(this.radioVirtual);
            this.Controls.Add(this.buttonTarget);
            this.Controls.Add(this.textResult);
            this.Controls.Add(this.groupMerge);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textTarget);
            this.Controls.Add(this.textSourceVirtual);
            this.Controls.Add(this.buttonCompile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormGUI";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ASP.NET Web Project Compiler 1.0";
            this.Load += new System.EventHandler(this.FormGUI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupMerge.ResumeLayout(false);
            this.groupMerge.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCompile;
        private System.Windows.Forms.TextBox textSourceVirtual;
        private System.Windows.Forms.TextBox textTarget;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupMerge;
        private System.Windows.Forms.TextBox textResult;
        private System.Windows.Forms.CheckBox checkFixed;
        private System.Windows.Forms.CheckBox checkDebug;
        private System.Windows.Forms.CheckBox checkOverwrite;
        private System.Windows.Forms.CheckBox checkUpdateable;
        private System.Windows.Forms.RadioButton radioMergeNone;
        private System.Windows.Forms.RadioButton radioMergeMulti;
        private System.Windows.Forms.RadioButton radioMergeSingle;
        private System.Windows.Forms.TextBox textMergeSingle;
        private System.Windows.Forms.TextBox textMergeMulti;
        private System.Windows.Forms.Button buttonTarget;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderDialog;
        private System.Windows.Forms.RadioButton radioVirtual;
        private System.Windows.Forms.RadioButton radioPhysical;
        private System.Windows.Forms.CheckBox checkTarget;
        private System.Windows.Forms.Button buttonSourcePhysical;
        private System.Windows.Forms.TextBox textSourcePhysical;
        private System.Windows.Forms.RadioButton radioMetabase;
        private System.Windows.Forms.TextBox textSourceMetabase;
        private System.Windows.Forms.CheckBox checkXML;
        private System.Windows.Forms.CheckBox checkRemoveCompiled;
        private System.Windows.Forms.CheckBox checkFull;
        private System.Windows.Forms.Button buttonAbout;
    }
}

