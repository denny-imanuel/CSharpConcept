using System.Threading.Tasks;
using CSharpConcept;
using CSharpConcept.Implementation;

namespace MyCSharp1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            var tree = new MyBinaryTree(3);
            tree.InsertNode(tree.root, 2); Console.WriteLine(); tree.BfsUsingStack(tree.root);
            tree.InsertNode(tree.root, 4); Console.WriteLine(); tree.BfsUsingStack(tree.root);
            tree.InsertNode(tree.root, 1); Console.WriteLine(); tree.BfsUsingStack(tree.root);
            tree.InsertNode(tree.root, 5); Console.WriteLine(); tree.BfsUsingStack(tree.root);
        }
    }
}