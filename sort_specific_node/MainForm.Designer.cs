
namespace sort_specific_node
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Node");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("etc");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Node0", new System.Windows.Forms.TreeNode[] { treeNode1, treeNode2 });
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("A");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("X");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("N");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Y");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("H");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("z", new System.Windows.Forms.TreeNode[] { treeNode5, treeNode6, treeNode7, treeNode8 });
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("b");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("t");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Node1", new System.Windows.Forms.TreeNode[] { treeNode4, treeNode9, treeNode10, treeNode11 });
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Node4");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Node5");
            treeView = new System.Windows.Forms.TreeView();
            checkBoxSorted = new System.Windows.Forms.CheckBox();
            buttonSortNode1 = new System.Windows.Forms.Button();
            buttonSortZ = new System.Windows.Forms.Button();
            buttonSortZDesc = new System.Windows.Forms.Button();
            textBoxList = new System.Windows.Forms.TextBox();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            labelAsc = new System.Windows.Forms.Label();
            labelDesc = new System.Windows.Forms.Label();
            labelZ = new System.Windows.Forms.Label();
            labelNode1 = new System.Windows.Forms.Label();
            buttonSortNode1Desc = new System.Windows.Forms.Button();
            buttonRevert = new System.Windows.Forms.Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // treeView
            // 
            treeView.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            treeView.Location = new System.Drawing.Point(0, 0);
            treeView.Name = "treeView";
            treeNode1.Name = "Node";
            treeNode1.Text = "Node";
            treeNode2.Name = "etc";
            treeNode2.Text = "etc";
            treeNode3.Name = "Node0";
            treeNode3.Text = "Node0";
            treeNode4.Name = "A";
            treeNode4.Text = "A";
            treeNode5.Name = "X";
            treeNode5.Text = "X";
            treeNode6.Name = "N";
            treeNode6.Text = "N";
            treeNode7.Name = "Y";
            treeNode7.Text = "Y";
            treeNode8.Name = "H";
            treeNode8.Text = "H";
            treeNode9.BackColor = System.Drawing.Color.PaleTurquoise;
            treeNode9.ForeColor = System.Drawing.Color.DarkSlateGray;
            treeNode9.Name = "z";
            treeNode9.Text = "z";
            treeNode10.Name = "b";
            treeNode10.Text = "b";
            treeNode11.Name = "t";
            treeNode11.Text = "t";
            treeNode12.BackColor = System.Drawing.Color.Honeydew;
            treeNode12.ForeColor = System.Drawing.Color.DarkSlateGray;
            treeNode12.Name = "b";
            treeNode12.Text = "Node1";
            treeNode13.Name = "Node4";
            treeNode13.Text = "Node4";
            treeNode14.Name = "Node5";
            treeNode14.Text = "Node5";
            treeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] { treeNode3, treeNode12, treeNode13, treeNode14 });
            treeView.Size = new System.Drawing.Size(290, 462);
            treeView.TabIndex = 0;
            // 
            // checkBoxSorted
            // 
            checkBoxSorted.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            checkBoxSorted.AutoSize = true;
            checkBoxSorted.Location = new System.Drawing.Point(318, 11);
            checkBoxSorted.Name = "checkBoxSorted";
            checkBoxSorted.Size = new System.Drawing.Size(91, 29);
            checkBoxSorted.TabIndex = 1;
            checkBoxSorted.Text = "Sorted";
            checkBoxSorted.UseVisualStyleBackColor = true;
            checkBoxSorted.CheckedChanged += checkBoxSorted_CheckedChanged;
            // 
            // buttonSortNode1
            // 
            buttonSortNode1.Location = new System.Drawing.Point(99, 30);
            buttonSortNode1.Name = "buttonSortNode1";
            buttonSortNode1.Size = new System.Drawing.Size(82, 32);
            buttonSortNode1.TabIndex = 2;
            buttonSortNode1.UseVisualStyleBackColor = true;
            buttonSortNode1.Click += buttonSortNode1_Click;
            // 
            // buttonSortZ
            // 
            buttonSortZ.Location = new System.Drawing.Point(99, 69);
            buttonSortZ.Name = "buttonSortZ";
            buttonSortZ.Size = new System.Drawing.Size(82, 32);
            buttonSortZ.TabIndex = 2;
            buttonSortZ.UseVisualStyleBackColor = true;
            buttonSortZ.Click += buttonSortZAsc_Click;
            // 
            // buttonSortZDesc
            // 
            buttonSortZDesc.Location = new System.Drawing.Point(188, 69);
            buttonSortZDesc.Name = "buttonSortZDesc";
            buttonSortZDesc.Size = new System.Drawing.Size(83, 32);
            buttonSortZDesc.TabIndex = 2;
            buttonSortZDesc.UseVisualStyleBackColor = true;
            buttonSortZDesc.Click += buttonSortZDesc_Click;
            // 
            // textBoxList
            // 
            textBoxList.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            textBoxList.Font = new System.Drawing.Font("Segoe UI", 7F);
            textBoxList.Location = new System.Drawing.Point(318, 166);
            textBoxList.Multiline = true;
            textBoxList.Name = "textBoxList";
            textBoxList.Size = new System.Drawing.Size(275, 276);
            textBoxList.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(labelAsc, 1, 0);
            tableLayoutPanel1.Controls.Add(labelDesc, 2, 0);
            tableLayoutPanel1.Controls.Add(labelZ, 0, 2);
            tableLayoutPanel1.Controls.Add(buttonSortZDesc, 2, 2);
            tableLayoutPanel1.Controls.Add(buttonSortZ, 1, 2);
            tableLayoutPanel1.Controls.Add(labelNode1, 0, 1);
            tableLayoutPanel1.Controls.Add(buttonSortNode1, 1, 1);
            tableLayoutPanel1.Controls.Add(buttonSortNode1Desc, 2, 1);
            tableLayoutPanel1.Location = new System.Drawing.Point(318, 55);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new System.Drawing.Size(275, 105);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // labelAsc
            // 
            labelAsc.Dock = System.Windows.Forms.DockStyle.Fill;
            labelAsc.Location = new System.Drawing.Point(99, 1);
            labelAsc.Name = "labelAsc";
            labelAsc.Size = new System.Drawing.Size(82, 25);
            labelAsc.TabIndex = 3;
            labelAsc.Text = "Asc";
            labelAsc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDesc
            // 
            labelDesc.Dock = System.Windows.Forms.DockStyle.Fill;
            labelDesc.Location = new System.Drawing.Point(188, 1);
            labelDesc.Name = "labelDesc";
            labelDesc.Size = new System.Drawing.Size(83, 25);
            labelDesc.TabIndex = 1;
            labelDesc.Text = "Desc";
            labelDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelZ
            // 
            labelZ.BackColor = System.Drawing.Color.PaleTurquoise;
            labelZ.Dock = System.Windows.Forms.DockStyle.Fill;
            labelZ.Location = new System.Drawing.Point(5, 70);
            labelZ.Margin = new System.Windows.Forms.Padding(4);
            labelZ.Name = "labelZ";
            labelZ.Size = new System.Drawing.Size(86, 30);
            labelZ.TabIndex = 4;
            labelZ.Text = "z";
            labelZ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNode1
            // 
            labelNode1.BackColor = System.Drawing.Color.Honeydew;
            labelNode1.Dock = System.Windows.Forms.DockStyle.Fill;
            labelNode1.Location = new System.Drawing.Point(5, 31);
            labelNode1.Margin = new System.Windows.Forms.Padding(4);
            labelNode1.Name = "labelNode1";
            labelNode1.Size = new System.Drawing.Size(86, 30);
            labelNode1.TabIndex = 5;
            labelNode1.Text = "Node1";
            labelNode1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSortNode1Desc
            // 
            buttonSortNode1Desc.Location = new System.Drawing.Point(188, 30);
            buttonSortNode1Desc.Name = "buttonSortNode1Desc";
            buttonSortNode1Desc.Size = new System.Drawing.Size(82, 32);
            buttonSortNode1Desc.TabIndex = 2;
            buttonSortNode1Desc.UseVisualStyleBackColor = true;
            buttonSortNode1Desc.Click += buttonSortNode1Desc_Click;
            // 
            // buttonRevert
            // 
            buttonRevert.Location = new System.Drawing.Point(415, 8);
            buttonRevert.Name = "buttonRevert";
            buttonRevert.Size = new System.Drawing.Size(82, 32);
            buttonRevert.TabIndex = 2;
            buttonRevert.Text = "Revert";
            buttonRevert.UseVisualStyleBackColor = true;
            buttonRevert.Visible = false;
            buttonRevert.Click += buttonRevert_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(618, 454);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(textBoxList);
            Controls.Add(checkBoxSorted);
            Controls.Add(treeView);
            Controls.Add(buttonRevert);
            Name = "MainForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Main Form";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.CheckBox checkBoxSorted;
        private System.Windows.Forms.Button buttonSortNode1;
        private System.Windows.Forms.Button buttonSortZ;
        private System.Windows.Forms.Button buttonSortZDesc;
        private System.Windows.Forms.TextBox textBoxList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelNode1;
        private System.Windows.Forms.Label labelAsc;
        private System.Windows.Forms.Label labelDesc;
        private System.Windows.Forms.Label labelZ;
        private System.Windows.Forms.Button buttonSortNode1Desc;
        private System.Windows.Forms.Button buttonRevert;
    }
}

