using System.Numerics;
public static class Program
{
    public static void Main(string[] args)
    {

        // Tree<Person> company = new Tree<Person>();
        // company.Root = new TreeNode<Person>()
        // {
        //     Data = new Person(100, "Marcin Jamro", "CEO"),
        //     Parent = null
        // };
        // company.Root.Children = new List<TreeNode<Person>>()
        // {
        //     new TreeNode<Person>()
        //     {
        //         Data = new Person(1, "John Smith", "Head of Development"),
        //         Parent = company.Root
        //     },
        //     new TreeNode<Person>()
        //     {
        //         Data = new Person(50, "Mary Fox", "Head of Research"),
        //         Parent = company.Root
        //     },
        //     new TreeNode<Person>()
        //     {
        //         Data = new Person(150, "Lily Smith", "Head of Sales"),
        //         Parent = company.Root
        //     }
        // };
        // company.Root.Children[2].Children = new List<TreeNode<Person>>()
        // {
        //     new TreeNode<Person>()
        //     {
        //             Data = new Person(30, "Anthony Black", "Sales Specialist"),
        //         Parent = company.Root.Children[2]
        //     }
        // };

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
            Data = new QuizItem("Do you have experience in developing applications?"),
            Children = new List<TreeNode<QuizItem>>()
            {
                new BinaryTreeNode<QuizItem>()
                {
                    Data = new QuizItem("Have you worked as a developer for more than 5 years?"),
                    Children = new List<TreeNode<QuizItem>>()
                    {
                            new BinaryTreeNode<QuizItem>()
                            {
                                Data = new QuizItem("Apply as a senior developer!")
                            },
                            new BinaryTreeNode<QuizItem>()
                            {
                                Data = new QuizItem("Apply as a middledeveloper!")
                            }
                    }
                },
                new BinaryTreeNode<QuizItem>()
                {
                    Data = new QuizItem("Have you completed the university?"),
                    Children = new List<TreeNode<QuizItem>>()
                    {
                        new BinaryTreeNode<QuizItem>()
                        {
                            Data = new QuizItem("Apply for a junior developer!")
                        },
                        new BinaryTreeNode<QuizItem>()
                        {
                            Data = new QuizItem("Will you find some time during the semester?"),
                            Children = new List<TreeNode<QuizItem>>()
                            {
                                new BinaryTreeNode<QuizItem>()
                                {
                                    Data = new QuizItem("Apply for our long-time internship program!")
                                },
                                new BinaryTreeNode<QuizItem>()
                                {
                                    Data = new QuizItem("Apply for summer internship program!")
                                }
                            }
                        }
                    }
                }
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