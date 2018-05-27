using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace MSBuildCoreTest
{
    internal class Program
    {
        

        private static void Main(string[] args)
        {
            Locator.Setup();
            new Executor().Execute();
        }
    }
}