using System.Collections.Generic;

using System.Numerics;
public static class Program
{
    public static void Main(string[] args)
    {

        BinaryTree<QuizItem> tree = GetTree();
        BinaryTreeNode<QuizItem> node = tree.Root;
        while (node != null)
        {
            if (node.Left != null || node.Right != null)
            {

                Console.Write(node.Data.Text);
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.Y:
                        WriteAnswer(" Yes");
                        node = node.Left;
                        break;
                    case ConsoleKey.N:
                        WriteAnswer(" No");
                        node = node.Right;
                        break;
                }
            }
            else
            {
                WriteAnswer(node.Data.Text);
                node = null;
            }
        }
    }
    private static BinaryTree<QuizItem> GetTree()
    {
        BinaryTree<QuizItem> tree = new BinaryTree<QuizItem>();
        tree.Root = new BinaryTreeNode<QuizItem>()
        {
            Data = new QuizItem("Merhaba Bugun Nasilsiniz"),
            Children = new List<TreeNode<QuizItem>>
            {
                new BinaryTreeNode<QuizItem>(){
                    Data = new QuizItem("İyiyim çok iyiyim")
                },

                new BinaryTreeNode<QuizItem>(){
                    Data = new QuizItem("Berbatim Noldu ki kardes"),
                    Children = new List<TreeNode<QuizItem>>()
                    {
                        new BinaryTreeNode<QuizItem>()
                        {
                            Data = new QuizItem("Allah iyilik versin")

                        },
                        new BinaryTreeNode<QuizItem>()
                        {
                            Data = new QuizItem("Allah sana kötülük versin")
                        }
                    }
                }
                ,
            }


        };
        tree.Count = 9;
        return tree;

    }
    private static void WriteAnswer(string text)
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine(text);
        Console.ForegroundColor = ConsoleColor.Gray;
    }
}
