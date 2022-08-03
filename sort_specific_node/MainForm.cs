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
            var labels = new List<string>() { node.Text };

            var traverse = node.Parent;
            while (traverse != null)
            {
                labels.Insert(0, traverse.Text);
                traverse = traverse.Parent;
            }
            var path = string.Join(@"\", labels);

            textBoxList.AppendText($"{path}{Environment.NewLine}");
            return false;
        }
        bool SortIfNodeMatch(TreeNode node, SortIfNodeMatchArgs args)
        {
            checkBoxSorted.Checked = false;
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
        }

        private void buttonSortZAsc_Click(object sender, EventArgs e)
        {
            var args =
               new SortIfNodeMatchArgs
               {
                   Predicate = (node) => node.Text == "z",

                   // This will sort in the order of A-Z
                   Sorter = (a, b) => a.Text.CompareTo(b.Text),
               };
            treeView.Iterate(SortIfNodeMatch, args);
            treeView.Iterate(LogPath, null);
        }

        private void buttonSortZDesc_Click(object sender, EventArgs e)
        {
            var args =
               new SortIfNodeMatchArgs
               {
                   Predicate = (node) => node.Text == "z",

                   // This will sort in the order of Z-A
                   Sorter = (a, b) => b.Text.CompareTo(a.Text),
               };
            treeView.Iterate(SortIfNodeMatch, args);
            treeView.Iterate(LogPath, null);
        }

        private void buttonSortNode1_Click(object sender, EventArgs e)
        {
            var args =
               new SortIfNodeMatchArgs
               {
                    Predicate = (node) => node.Text == "Node1",

                    // This will sort in the order of A-Z
                    Sorter = (a, b) => a.Text.CompareTo(b.Text),
               };
            treeView.Iterate(SortIfNodeMatch, args);
            treeView.Iterate(LogPath, null);
        }

        private void buttonSortNode1Desc_Click(object sender, EventArgs e)
        {
            var args =
               new SortIfNodeMatchArgs
               {
                   Predicate = (node) => node.Text == "Node1",

                   // This will sort in the order of Z-A
                   Sorter = (a, b) => b.Text.CompareTo(a.Text),
               };
            treeView.Iterate(SortIfNodeMatch, args);
            treeView.Iterate(LogPath, null);
        }
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
    }
}
