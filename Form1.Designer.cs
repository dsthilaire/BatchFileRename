namespace BatchFileRename
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
            System.Windows.Forms.GroupBox groupBox2;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Button btnRun;
            System.Windows.Forms.Button btnRemove;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Button btnRemoveAll;
            this.txtReplace = new System.Windows.Forms.TextBox();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.lbFiles = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            groupBox2 = new System.Windows.Forms.GroupBox();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            btnRun = new System.Windows.Forms.Button();
            btnRemove = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            btnRemoveAll = new System.Windows.Forms.Button();
            groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnRemoveAll);
            groupBox2.Controls.Add(this.label4);
            groupBox2.Controls.Add(this.txtReplace);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(this.txtFind);
            groupBox2.Controls.Add(btnRun);
            groupBox2.Controls.Add(btnRemove);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(this.lbFiles);
            groupBox2.Location = new System.Drawing.Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(353, 292);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Input Files";
            // 
            // txtReplace
            // 
            this.txtReplace.Location = new System.Drawing.Point(226, 227);
            this.txtReplace.Name = "txtReplace";
            this.txtReplace.Size = new System.Drawing.Size(110, 20);
            this.txtReplace.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(194, 230);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(26, 13);
            label2.TabIndex = 17;
            label2.Text = "with";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(20, 230);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(50, 13);
            label1.TabIndex = 16;
            label1.Text = "Replace ";
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(76, 227);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(110, 20);
            this.txtFind.TabIndex = 15;
            // 
            // btnRun
            // 
            btnRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnRun.Location = new System.Drawing.Point(201, 253);
            btnRun.Name = "btnRun";
            btnRun.Size = new System.Drawing.Size(135, 23);
            btnRun.TabIndex = 14;
            btnRun.Text = "Rename Files";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnRemove
            // 
            btnRemove.Location = new System.Drawing.Point(74, 193);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new System.Drawing.Size(128, 23);
            btnRemove.TabIndex = 13;
            btnRemove.Text = "Remove Selected";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(6, 24);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(269, 13);
            label3.TabIndex = 12;
            label3.Text = "Drag and drop files from Windows Explorer onto list box.";
            // 
            // lbFiles
            // 
            this.lbFiles.AllowDrop = true;
            this.lbFiles.FormattingEnabled = true;
            this.lbFiles.Location = new System.Drawing.Point(6, 40);
            this.lbFiles.Name = "lbFiles";
            this.lbFiles.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbFiles.Size = new System.Drawing.Size(330, 147);
            this.lbFiles.Sorted = true;
            this.lbFiles.TabIndex = 11;
            this.lbFiles.DragDrop += new System.Windows.Forms.DragEventHandler(this.lbFiles_DragDrop);
            this.lbFiles.DragEnter += new System.Windows.Forms.DragEventHandler(this.lbFiles_DragEnter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Start with \'/\' for regex";
            // 
            // btnRemoveAll
            // 
            btnRemoveAll.Location = new System.Drawing.Point(208, 193);
            btnRemoveAll.Name = "btnRemoveAll";
            btnRemoveAll.Size = new System.Drawing.Size(128, 23);
            btnRemoveAll.TabIndex = 20;
            btnRemoveAll.Text = "Remove All";
            btnRemoveAll.UseVisualStyleBackColor = true;
            btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 317);
            this.Controls.Add(groupBox2);
            this.Name = "Form1";
            this.Text = "Batch File Rename";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbFiles;
        private System.Windows.Forms.TextBox txtReplace;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Label label4;
    }
}

