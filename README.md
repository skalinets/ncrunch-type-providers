ncrunch-type-providers
======================

This is a demo repository to reproduce issues mentioned in http://forum.ncrunch.net/yaf_postsm6566_Problem-using-NCrunch-with-FSharp-Data-SqlClient.aspx

### Output from NCrunch


```
NCrunch: If you are experiencing problems in getting this project to build, have a look at http://www.ncrunch.net/documentation/troubleshooting_project-build-issues
System.ArgumentException: The parameter is incorrect. (Exception from HRESULT: 0x80070057 (E_INVALIDARG))
   at System.Reflection.AssemblyName.nInit(RuntimeAssembly& assembly, Boolean forIntrospection, Boolean raiseResolveEvent)
   at System.Reflection.AssemblyName..ctor(String assemblyName)
   at Gallio.Common.Reflection.Impl.CecilReflectionPolicy.GetAssemblyReferences(StaticAssemblyWrapper assembly)
   at Gallio.Common.Reflection.Impl.StaticAssemblyWrapper.<GetReferencedAssemblies>b__2()
   at Gallio.Common.Memoizer`1.Memoize(Func`1 populator)
   at Gallio.Common.Reflection.Impl.StaticAssemblyWrapper.GetReferencedAssemblies()
   at Gallio.Model.DefaultTestFrameworkManager.SelectTestFrameworksForCodeElementsImpl(IEnumerable`1 filteredTestFrameworkHandlesWithoutFallback, TestFrameworkFallbackMode testFrameworkFallbackMode, TestFrameworkOptions testFrameworkOptions, IEnumerable`1 codeElements)
   at Gallio.Model.DefaultTestFrameworkManager.FilteredTestDriver.DescribeImpl(IReflectionPolicy reflectionPolicy, IList`1 codeElements, TestExplorationOptions testExplorationOptions, IMessageSink messageSink, IProgressMonitor progressMonitor)
   at Gallio.Model.BaseTestDriver.Describe(IReflectionPolicy reflectionPolicy, IList`1 codeElements, TestExplorationOptions testExplorationOptions, IMessageSink messageSink, IProgressMonitor progressMonitor)
   at nCrunch.Module.Gallio.Integration.GallioWrapper.FindFrameworkTestsInAssembly(ReflectedAssembly assembly, FilePath assemblyFilePath, IList`1 referencedAssemblyFilePaths)
   at nCrunch.Module.Gallio.Integration.GallioTestFramework.FindFrameworkTestsInAssembly(ReflectedAssembly assembly, FilePath assemblyFilePath, IList`1 referencedAssemblyFilePaths, ComponentUniqueName testComponentUniqueName)
   at nCrunch.TestExecution.TestFinder.FindTestsForFrameworks(ReflectedAssembly assembly, FilePath assemblyFilePath, IList`1 referencedAssemblyFilePaths, TestFrameworkDescription[] frameworks, ComponentUniqueName testComponentUniqueName)
   at nCrunch.Compiler.StaticManipulation.BuiltAssembly.DiscoverTests(TestFrameworkDescription[] applicableTestFrameworks, ComponentUniqueName testComponentUniqueName)
   at nCrunch.Compiler.RemoteBuildRunner.(ComponentBuildParameters , FilePath , BuildOutput , DirectoryPath[] , FilePath[] )
   at nCrunch.Compiler.RemoteBuildRunner.Build(ComponentBuildParameters parameters)

```
