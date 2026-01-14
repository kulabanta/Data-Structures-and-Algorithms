using DsaPreparation.Tree.Tree;
using Tree.Tree.TreeTraversal;

namespace Tree
{
    public class TreeSolution
    {
        public static void Main(string[] args)
        {
            //TreeNode root = new TreeNode(1);
            //root.left = new TreeNode(2);
            //root.right = new TreeNode(3);
            //root.left.left = new TreeNode(4);
            //root.left.right = new TreeNode(5);
            //root.right.left = new TreeNode(6);
            //root.right.right = new TreeNode(7);
            //root.right.right.right = new TreeNode(9);

            //PreInPostOrderInSingleStackIteration traversal = new();
            //var res = traversal.TreeTraversal(root);
            //foreach(var p in res)
            //{
            //    foreach(var q in p)
            //    {
            //        Console.Write(q + " ");
            //    }
            //    Console.WriteLine();
            //}

            //Person p = new()
            //{
            //    name = "kula",
            //    age = 20
            //};
            //Console.WriteLine($"name : {p.name}, age : {p.age}");
            //ChangePerson(p);
            //Console.WriteLine($"name : {p.name}, age : {p.age}");
            //string name = "kula";
            //Console.WriteLine($"name : {name}");
            //ChangeName(name);
            //Console.WriteLine($"name : {name}");

            //ParallelAndBatchTask operation = new();
            //operation.PerformBatchAndParallelOperations(1000, 20, 3);
        }
        public static void ChangePerson(Person p)
        {
            p.age = 34;
            p.name = "tulu";
        }
        public static void ChangeName(string  name)
        {
            name = "tulu";
        }
        public class Person
        {
            public int age;
            public string name;
        }

    }
}