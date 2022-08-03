# Sort Specific Node


This example will apply an sort to a specific single node in a `TreeView` leaving the rest untouched. 

![before and after sort node z ascending](https://github.com/IVSoftware/sort_specific_node/blob/master/sort_specific_node/ReadMe/screenshot.png)

***
**Find the target node**

Given a constraint on the `TreeView` that the fully-qualified path to any node (for example, "Node1\z") is unique, the target can be obtained very efficiently by making an extension for `TreeView` that returns the specified node (or `null` if not found).

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

***
**Sort children of target node**

This extension for `TreeNode` sorts its children according to the coparer function passed in as an argument.

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

***
**Method to sort (A-Z) a specific node of a TreeView.**

So, to answer the question **Is there any method to sort a specific node of a TreeView from A-Z** let's say we manufacture such a method by making an extension for `TreeView` that does just that. For the `path` argument specify the entire hierarchal path like @"Node1" or @"Node1\z".

    public static bool SortIfNodeFound(
        this TreeView treeView, 
        string path, 
        Func<TreeNode, TreeNode, int> sorter)
    {
        var node = treeView.Find(path);
        node?.Sort(sorter);
        return node != null;
    }
