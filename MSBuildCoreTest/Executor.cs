using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Build.Evaluation;

namespace MSBuildCoreTest
{
    class Executor
    {
        public void Execute()
        {
            var projectFile = @"..\..\..\MSBuildCoreTest.csproj";
            var project = new Project(projectFile); // throws System.StackOverflowException
            var targetNames = project.Targets.Select(x => x.Value.Name);
        }
    }
}
