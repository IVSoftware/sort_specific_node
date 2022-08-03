using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sort_specific_node
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            treeView.Sorted = false;
            treeView.Invalidated += (sender, e) => checkBoxSorted.Checked = treeView.Sorted;
            treeView.ExpandAll();
            treeView.Iterate(Index, null);
            treeView.Iterate(LogPath, null);
            treeView.BeforeSelect += (sender, e) => e.Cancel = !_isTreeInitialized;
            Task.Delay(10).GetAwaiter().OnCompleted(() => _isTreeInitialized = true);
        }
        private bool _isTreeInitialized = false;
        bool LogPath(TreeNode node, object unused)
        {
            var path = node.Path();
            textBoxList.AppendText($"{path}{Environment.NewLine}");
            return false;
        }
        bool SortIfNodeMatch(TreeNode node, SortIfNodeMatchArgs args)
        {
            checkBoxSorted.Checked = false;
            buttonRevert.Visible = true;
            if((args.Predicate == null) || (args.Predicate(node)))
            {
                var list = node.Nodes.Cast<TreeNode>().ToList();
                list.Sort((a, b) => args.Sorter(a, b));
                node.Nodes.Clear();
                foreach (var sorted in list)
                {
                    node.Nodes.Add(sorted);
                }
                return args.Predicate != null;
            }
            return false;
        }
        // Overloaded so that the arg can be 'object'
        bool SortIfNodeMatch(TreeNode node, object args) =>
            SortIfNodeMatch(node, (SortIfNodeMatchArgs)args);
        class SortIfNodeMatchArgs
        {
            public Predicate<TreeNode> Predicate { get; set; }
            public Func<TreeNode, TreeNode, int> Sorter { get; set; }
        }
        bool Index(TreeNode node, object unused)
        {
            node.Tag = node.Index;
            return false;
        }

        private void checkBoxSorted_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxSorted.Checked)
            {
                treeView.Sort();
                buttonRevert.Visible = true;
            }
            else
            {
                treeView.Sorted = false;
                revert();
            }
            treeView.Iterate(LogPath, null);
        }

        private void revert()
        {
            var args =
               new SortIfNodeMatchArgs
               {
                   Predicate = null,

                   // This will sort in the original order.
                   Sorter = (a, b) => ((int)a.Tag).CompareTo(((int)b.Tag)),
               };
            treeView.Iterate(SortIfNodeMatch, args);
            buttonRevert.Visible = false;
        }

        private void buttonSortZAsc_Click(object sender, EventArgs e)
        {
            treeView.SortIfNodeFound(
                @"Node1\z", 
                (a, b) => a.Text.CompareTo(b.Text) // A-Z
            );
            treeView.Iterate(LogPath, null);
            buttonRevert.Visible = true;
        }

        private void buttonSortZDesc_Click(object sender, EventArgs e)
        {
            treeView.SortIfNodeFound(
                @"Node1\z", 
                (a, b) => b.Text.CompareTo(a.Text) // Z-A
            );
            treeView.Iterate(LogPath, null);
            buttonRevert.Visible = true;
        }

        private void buttonSortNode1_Click(object sender, EventArgs e)
        {
            treeView.SortIfNodeFound(
                @"Node1",
                (a, b) => a.Text.CompareTo(b.Text) // A-Z
            );
            treeView.Iterate(LogPath, null);
            buttonRevert.Visible = true;
        }

        private void buttonSortNode1Desc_Click(object sender, EventArgs e)
        {
            treeView.SortIfNodeFound(
                @"Node1",
                (a, b) => b.Text.CompareTo(a.Text) // Z-A
            );
            treeView.Iterate(LogPath, null);
            buttonRevert.Visible = true;
        }

        private void buttonRevert_Click(object sender, EventArgs e) => revert();
    }

    delegate bool Fx(TreeNode node, object args);
    static class Extensions
    {
        public static bool Iterate(
            this object unk,    // A TreeView or TreeNode
            Fx fx,              // A function that returns true to stop iteration
            object args
         )
        {
            TreeNodeCollection nodes;
            if (unk is TreeNode treeNode)
            {
                if (fx(treeNode, args)) return true;
                nodes = treeNode.Nodes;
            }
            else if (unk is TreeView treeView)
            {
                nodes = treeView.Nodes;
            }
            else throw new NotImplementedException($"Invalid type '{unk.GetType().Name}'");

            foreach (TreeNode node in nodes)
            {
                if(node.Iterate(fx, args)) return true;
            }
            return false;
        }

        public static string Path(this TreeNode node)
        {
            var labels = new List<string>() { node.Text };
            var traverse = node.Parent;
            while (traverse != null)
            {
                labels.Insert(0, traverse.Text);
                traverse = traverse.Parent;
            }
            return string.Join(@"\", labels);
        }

        public static TreeNode Find(this TreeView treeView, string path)
        {
            var parse = path.Split('\\');
            var nodes = treeView.Nodes;
            TreeNode node = null;
            foreach (var text in parse)
            {
                node = nodes.Cast<TreeNode>().FirstOrDefault(node => node.Text == text);
                if (node == null) break;
                nodes = node.Nodes;
            }
            return node;
        }

        public static void Sort(
            this TreeNode node,
            Func<TreeNode, TreeNode, int> sorter)
        {
            // Make sure the TreeView will allow reordering
            if (node.TreeView != null)
            {
                node.TreeView.Sorted = false;
            }
            // Copy the nodes to a list
            var list = node.Nodes.Cast<TreeNode>().ToList();
            // Sort the list however the `Sorter` says to.
            list.Sort((a, b) => sorter(a, b));
            // Clear the 'old' order
            node.Nodes.Clear();
            // Install the 'new' order
            foreach (var sorted in list)
            {
                node.Nodes.Add(sorted);
            }
        }

        public static bool SortIfNodeFound(
            this TreeView treeView, 
            string path, 
            Func<TreeNode, TreeNode, int> sorter)
        {
            var node = treeView.Find(path);
            node?.Sort(sorter);
            return node != null;
        }
    }
}
