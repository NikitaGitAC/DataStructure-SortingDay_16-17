namespace Binarytree
{
    class program
    {
        public static void Main(string[]args)
        {
            Console.WriteLine("Data Structures and Algorithms Programs");
            binarytreecode binaryTree = new binarytreecode();

            binaryTree.Add(50);
            binaryTree.Add(20);
            binaryTree.Add(30);
            binaryTree.Add(15);
            binaryTree.Add(60);
            binaryTree.Add(80);
            binaryTree.TravarsePreorder(binaryTree.Root);
        }
    }
}