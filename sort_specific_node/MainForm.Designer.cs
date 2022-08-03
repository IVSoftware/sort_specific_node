
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
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Node0", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("A");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("X");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("N");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Y");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("H");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("z", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("b");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("t");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Node1", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode9,
            treeNode10,
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Node4");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Node5");
            this.treeView = new System.Windows.Forms.TreeView();
            this.checkBoxSorted = new System.Windows.Forms.CheckBox();
            this.buttonSortNode1 = new System.Windows.Forms.Button();
            this.buttonSortZ = new System.Windows.Forms.Button();
            this.buttonSortZDesc = new System.Windows.Forms.Button();
            this.textBoxList = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelAsc = new System.Windows.Forms.Label();
            this.labelDesc = new System.Windows.Forms.Label();
            this.labelZ = new System.Windows.Forms.Label();
            this.labelNode1 = new System.Windows.Forms.Label();
            this.buttonSortNode1Desc = new System.Windows.Forms.Button();
            this.buttonRevert = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView
            // 
            this.treeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView.Cursor = System.Windows.Forms.Cursors.Default;
            this.treeView.Location = new System.Drawing.Point(0, 0);
            this.treeView.Name = "treeView";
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
            this.treeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode12,
            treeNode13,
            treeNode14});
            this.treeView.Size = new System.Drawing.Size(290, 462);
            this.treeView.TabIndex = 0;
            // 
            // checkBoxSorted
            // 
            this.checkBoxSorted.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxSorted.AutoSize = true;
            this.checkBoxSorted.Location = new System.Drawing.Point(318, 11);
            this.checkBoxSorted.Name = "checkBoxSorted";
            this.checkBoxSorted.Size = new System.Drawing.Size(91, 29);
            this.checkBoxSorted.TabIndex = 1;
            this.checkBoxSorted.Text = "Sorted";
            this.checkBoxSorted.UseVisualStyleBackColor = true;
            this.checkBoxSorted.CheckedChanged += new System.EventHandler(this.checkBoxSorted_CheckedChanged);
            // 
            // buttonSortNode1
            // 
            this.buttonSortNode1.Location = new System.Drawing.Point(99, 30);
            this.buttonSortNode1.Name = "buttonSortNode1";
            this.buttonSortNode1.Size = new System.Drawing.Size(82, 32);
            this.buttonSortNode1.TabIndex = 2;
            this.buttonSortNode1.UseVisualStyleBackColor = true;
            this.buttonSortNode1.Click += new System.EventHandler(this.buttonSortNode1_Click);
            // 
            // buttonSortZ
            // 
            this.buttonSortZ.Location = new System.Drawing.Point(99, 69);
            this.buttonSortZ.Name = "buttonSortZ";
            this.buttonSortZ.Size = new System.Drawing.Size(82, 32);
            this.buttonSortZ.TabIndex = 2;
            this.buttonSortZ.UseVisualStyleBackColor = true;
            this.buttonSortZ.Click += new System.EventHandler(this.buttonSortZAsc_Click);
            // 
            // buttonSortZDesc
            // 
            this.buttonSortZDesc.Location = new System.Drawing.Point(188, 69);
            this.buttonSortZDesc.Name = "buttonSortZDesc";
            this.buttonSortZDesc.Size = new System.Drawing.Size(83, 32);
            this.buttonSortZDesc.TabIndex = 2;
            this.buttonSortZDesc.UseVisualStyleBackColor = true;
            this.buttonSortZDesc.Click += new System.EventHandler(this.buttonSortZDesc_Click);
            // 
            // textBoxList
            // 
            this.textBoxList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxList.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxList.Location = new System.Drawing.Point(318, 166);
            this.textBoxList.Multiline = true;
            this.textBoxList.Name = "textBoxList";
            this.textBoxList.Size = new System.Drawing.Size(275, 276);
            this.textBoxList.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.labelAsc, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelDesc, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelZ, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonSortZDesc, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonSortZ, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelNode1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonSortNode1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonSortNode1Desc, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(318, 55);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(275, 105);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // labelAsc
            // 
            this.labelAsc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAsc.Location = new System.Drawing.Point(99, 1);
            this.labelAsc.Name = "labelAsc";
            this.labelAsc.Size = new System.Drawing.Size(82, 25);
            this.labelAsc.TabIndex = 3;
            this.labelAsc.Text = "Asc";
            this.labelAsc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDesc
            // 
            this.labelDesc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDesc.Location = new System.Drawing.Point(188, 1);
            this.labelDesc.Name = "labelDesc";
            this.labelDesc.Size = new System.Drawing.Size(83, 25);
            this.labelDesc.TabIndex = 1;
            this.labelDesc.Text = "Desc";
            this.labelDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelZ
            // 
            this.labelZ.BackColor = System.Drawing.Color.PaleTurquoise;
            this.labelZ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelZ.Location = new System.Drawing.Point(5, 70);
            this.labelZ.Margin = new System.Windows.Forms.Padding(4);
            this.labelZ.Name = "labelZ";
            this.labelZ.Size = new System.Drawing.Size(86, 30);
            this.labelZ.TabIndex = 4;
            this.labelZ.Text = "z";
            this.labelZ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNode1
            // 
            this.labelNode1.BackColor = System.Drawing.Color.Honeydew;
            this.labelNode1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelNode1.Location = new System.Drawing.Point(5, 31);
            this.labelNode1.Margin = new System.Windows.Forms.Padding(4);
            this.labelNode1.Name = "labelNode1";
            this.labelNode1.Size = new System.Drawing.Size(86, 30);
            this.labelNode1.TabIndex = 5;
            this.labelNode1.Text = "Node1";
            this.labelNode1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSortNode1Desc
            // 
            this.buttonSortNode1Desc.Location = new System.Drawing.Point(188, 30);
            this.buttonSortNode1Desc.Name = "buttonSortNode1Desc";
            this.buttonSortNode1Desc.Size = new System.Drawing.Size(82, 32);
            this.buttonSortNode1Desc.TabIndex = 2;
            this.buttonSortNode1Desc.UseVisualStyleBackColor = true;
            this.buttonSortNode1Desc.Click += new System.EventHandler(this.buttonSortNode1Desc_Click);
            // 
            // buttonRevert
            // 
            this.buttonRevert.Location = new System.Drawing.Point(415, 8);
            this.buttonRevert.Name = "buttonRevert";
            this.buttonRevert.Size = new System.Drawing.Size(82, 32);
            this.buttonRevert.TabIndex = 2;
            this.buttonRevert.Text = "Revert";
            this.buttonRevert.UseVisualStyleBackColor = true;
            this.buttonRevert.Visible = false;
            this.buttonRevert.Click += new System.EventHandler(this.buttonRevert_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 454);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.textBoxList);
            this.Controls.Add(this.checkBoxSorted);
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.buttonRevert);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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

