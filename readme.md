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

So, to answer the question "is any method to sort (A-Z) a specific node of a TreeView" let's say we manufacture such a method by making an extension for `TreeView` that does just that. For the `path` argument specify the entire hierarchal path like @"Node1" or @"Node1\z".

    public static bool SortIfNodeFound(
        this TreeView treeView, 
        string path, 
        Func<TreeNode, TreeNode, int> sorter)
    {
        var node = treeView.Find(path);
        node?.Sort(sorter);
        return node != null;
    }




















It achieves this outcome by iterating the `TreeView` looking for a match for an arbitrary [Predicate](https://docs.microsoft.com/en-us/dotnet/api/system.predicate-1?view=net-6.0). If found, it applies an individualized sort method (specified at runtime) to that specific node and avoids making a call the `Sort` method for the entire `TreeView` because that would add an unnecessary layer of complexity.

***
**Method that sorts a node based on a specified comparer function**

`SortIfNodeMatch` takes a `TreeNode` as its first argument and an args class named `SortIfNodeMatchArgs` as its second. When called, the `Predicate` member will be evaluated, and if `true` the node will be sorted.

        bool SortIfNodeMatch(TreeNode node, SortIfNodeMatchArgs args)
        {
            if(args.Predicate(node))
            {
                // Copy the nodes to a list
                var list = node.Nodes.Cast<TreeNode>().ToList();
                // Sort the list however the `Sorter` says to.
                list.Sort((a, b) => args.Sorter(a, b));
                // Clear the 'old' order
                node.Nodes.Clear();
                // Install the 'new' order
                foreach (var sorted in list)
                {
                    node.Nodes.Add(sorted);
                }
                return true;
            }
            return false;
        }

        // Also overloaded so that the arg can be 'object'
        bool SortIfNodeMatch(TreeNode node, object args) =>
            SortIfNodeMatch(node, (SortIfNodeMatchArgs)args);

***
**Args class *arbitrarily* defines "what is a match" and "how to sort"**

    class SortIfNodeMatchArgs
    {
        public Predicate<TreeNode> Predicate { get; set; }
        public Func<TreeNode, TreeNode, int> Sorter { get; set; }
    }

***
**Instantiate a `SortIfNodeMatchArgs` object then Iterate the `TreeView`**

*For example, if the node we want is "z" and the order we want (A-Z) then do this:*

    var args =
        new SortIfNodeMatchArgs
        {
            // This will match if the node is "z"
            Predicate = (node) => node.Text == "z",

            // This will sort in the order A-Z
            Sorter = (a, b) => a.Text.CompareTo(b.Text),
        };

***
Now, iterate the tree until the match is found then apply the sort.

    treeView.Iterate(SortIfNodeMatch, args);
    treeView.ExpandAll();

***
**Extension to iterate a `TreeView` with an arbitrary `Func(node, args)`**

Whenever there's a `TreeView` then we're probably going to want to iterate it for various ends sooner or later. Using an extension similar to this one not only fits the bill for this occasion, but also offers a handy generic and widely reusable way to perform other operations on some or all of the nodes in the tree.

    delegate bool Fx(TreeNode node, object args);
    static class Extensions
    {
        public static bool Iterate(
            this object unk,    // A TreeView or TreeNode
            Fx fx,              // A function that returns true to stop iteration
            object args         // Anything you want
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
