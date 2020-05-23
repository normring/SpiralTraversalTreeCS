using System; 
using System.Collections;

public class Node { 
	public int value; 
	public Node left, right; 

	public Node(int d) 
	{ 
		value = d; 
		left = right = null; 
	} 
} 

class Tree { 
	public Node root; 
    private Stack st1 = new Stack(), st2 = new Stack();

	public virtual void PrintSpiral(Node root) 
	{ 
		if (root == null) 
		{ 
			return; 
		}

		st1.Push(root);

		while (true)
		{
			while (st1.Count > 0)
			{
				Node curr = (Node)st1.Pop();
				System.Console.WriteLine(curr.value + " ");
				if (curr.left != null)
				{
					st2.Push(curr.left);
				}

				if (curr.right != null)
				{
					st2.Push(curr.right);
				}
			}
			if (st2.Count == 0)
					break;

			while (st2.Count > 0) 
			{
				Node curr = (Node)st2.Pop();
				System.Console.WriteLine(curr.value + " ");

				if (curr.right != null)
				{
					st1.Push(curr.right);
				}
				if (curr.left != null)
				{
					st1.Push(curr.left);
				}
			}
			if (st1.Count == 0)
					break;
		}
	} 

	public static void Main(string[] args) 
	{ 
		Tree tree = new Tree(); 
		tree.root = new Node(1); 
		tree.root.left = new Node(2); 
		tree.root.right = new Node(3); 
		tree.root.left.left = new Node(4);
		tree.root.left.right = new Node(5);
		tree.root.right.right = new Node(6);
		tree.root.left.right.left = new Node(7);
		tree.root.left.right.right = new Node(8);
		tree.root.right.right.left = new Node(9);
		Console.WriteLine("Spiral order traversal of the binary tree is "); 
		tree.PrintSpiral(tree.root); 
	} 
} 

