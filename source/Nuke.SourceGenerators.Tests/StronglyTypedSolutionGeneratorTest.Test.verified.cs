﻿//HintName: StronglyTypedSolutionGenerator.cs
using Nuke.Common.ProjectModel;

internal class Solution : Nuke.Common.ProjectModel.Solution
{
    private Nuke.Common.ProjectModel.Solution SolutionFolder => this;
    public Project _build => SolutionFolder.GetProject("_build");
    public Project Nuke_Common => SolutionFolder.GetProject("Nuke.Common");
    public Project Nuke_Common_Tests => SolutionFolder.GetProject("Nuke.Common.Tests");
    public Project Nuke_MSBuildLocator => SolutionFolder.GetProject("Nuke.MSBuildLocator");
    public Project Nuke_CodeGeneration => SolutionFolder.GetProject("Nuke.CodeGeneration");
    public Project Nuke_GlobalTool => SolutionFolder.GetProject("Nuke.GlobalTool");
    public Project Nuke_GlobalTool_Tests => SolutionFolder.GetProject("Nuke.GlobalTool.Tests");
    public Project Nuke_MSBuildTasks => SolutionFolder.GetProject("Nuke.MSBuildTasks");
    public Project Nuke_Components => SolutionFolder.GetProject("Nuke.Components");
    public Project Nuke_SourceGenerators => SolutionFolder.GetProject("Nuke.SourceGenerators");
    public Project Nuke_SourceGenerators_Tests => SolutionFolder.GetProject("Nuke.SourceGenerators.Tests");
    public _misc misc => new(SolutionFolder.GetSolutionFolder("misc"));
    internal class _misc
    {
        private SolutionFolder SolutionFolder { get; }

        public _misc(SolutionFolder solutionFolder) => SolutionFolder = solutionFolder;
    }
}