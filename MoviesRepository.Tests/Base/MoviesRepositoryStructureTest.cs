
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using NUnit.Framework;

namespace MoviesRepository.Tests.Base
{
    /// <summary>
    /// !!! WARNING 
    /// !!! Project structure test.
    /// !!! DON'T CHANGE IT! 
    /// !!! Changes may cause the solution to be rejected.
    /// </summary>
    public class MoviesRepositoryStructureTest
    {
        [SetUp]
        public void Setup()
        {
        }

        /// <summary>
        /// !!! WARNING 
        /// !!! Project structure test.
        /// !!! DON'T CHANGE IT! 
        /// !!! Changes may cause the solution to be rejected.
        /// </summary>
        [Test]
        public void StructureTest()
        {

            Assembly assembly;
            Type type;
            Type methodReturnType;
            MethodInfo method;
            int methodsCount;
            ParameterInfo parameter;
            int parametersCount;
            int constructorsCount;
            List<string> constructorParameterNameTypeDictionary;
            ConstructorInfo constructor;
            int fieldsCount;
            FieldInfo field;
            Type fieldReturnType;
            PropertyInfo property;
            int propertiesCount;
            Type propertyReturnType;
            assembly = Assembly.Load(Decode("TW92aWVzUmVwb3NpdG9yeSwgVmVyc2lvbj0xLjAuMC4wLCBDdWx0dXJlPW5ldXRyYWwsIFB1YmxpY0tleVRva2VuPW51bGw=") /*"MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"*/ );
            Assert.IsNotNull(assembly, "Missing  MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null");

            type = assembly.GetTypes().FirstOrDefault(x => x.Name == Decode("UHJvZ3JhbQ==") /*"Program"*/ );
            Assert.IsNotNull(type, "Missing assembly: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Program");
            Assert.IsTrue(type.IsClass, "assembly: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Program is not class");
            Assert.IsTrue(type.IsPublic, "assembly: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Program is not public class");
            method = type.GetMethods().Where(m => !m.IsSpecialName).FirstOrDefault(x => x.Name == Decode("TWFpbg==") /*"Main"*/ ); Assert.IsNotNull(method, "method: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Program.Main(String[] args) does not exists");
            Assert.IsTrue(method.IsPublic, "method: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Program.Main(String[] args) is not public");
            Assert.IsTrue(method.IsStatic, "method: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Program.Main(String[] args) is not static");
            methodReturnType = method.ReturnType;
            Assert.AreEqual("System.Void", methodReturnType.FullName, "method: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Program.Main(String[] args) return type has changed");
            parametersCount = method.GetParameters().Length;
            Assert.AreEqual(1, parametersCount, "method: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Program.Main(String[] args) parameters count has changed");
            parameter = method.GetParameters().FirstOrDefault(x => x.Name == Decode("YXJncw==") /*"args"*/  && x.ParameterType.FullName == "System.String[]");
            Assert.IsNotNull(parameter, "method: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Program.Main(String[] args) parameter args does not exists or does not have type System.String[]");
            method = type.GetMethods().Where(m => !m.IsSpecialName).FirstOrDefault(x => x.Name == Decode("Q3JlYXRlV2ViSG9zdEJ1aWxkZXI=") /*"CreateWebHostBuilder"*/ ); Assert.IsNotNull(method, "method: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Program.CreateWebHostBuilder(String[] args) does not exists");
            Assert.IsTrue(method.IsPublic, "method: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Program.CreateWebHostBuilder(String[] args) is not public");
            Assert.IsTrue(method.IsStatic, "method: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Program.CreateWebHostBuilder(String[] args) is not static");
            methodReturnType = method.ReturnType;
            Assert.AreEqual("Microsoft.AspNetCore.Hosting.IWebHostBuilder", methodReturnType.FullName, "method: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Program.CreateWebHostBuilder(String[] args) return type has changed");
            parametersCount = method.GetParameters().Length;
            Assert.AreEqual(1, parametersCount, "method: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Program.CreateWebHostBuilder(String[] args) parameters count has changed");
            parameter = method.GetParameters().FirstOrDefault(x => x.Name == Decode("YXJncw==") /*"args"*/  && x.ParameterType.FullName == "System.String[]");
            Assert.IsNotNull(parameter, "method: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Program.CreateWebHostBuilder(String[] args) parameter args does not exists or does not have type System.String[]");
            constructorParameterNameTypeDictionary = new List<string>();
            constructor = type.GetConstructors().FirstOrDefault(x => x.GetParameters().Select(y => y.ParameterType.FullName).SequenceEqual(constructorParameterNameTypeDictionary));
            Assert.IsNotNull(constructor, "constructor: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Program() does not exists");

            type = assembly.GetTypes().FirstOrDefault(x => x.Name == Decode("U3RhcnR1cA==") /*"Startup"*/ );
            Assert.IsNotNull(type, "Missing assembly: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Startup");
            Assert.IsTrue(type.IsClass, "assembly: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Startup is not class");
            Assert.IsTrue(type.IsPublic, "assembly: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Startup is not public class");
            method = type.GetMethods().Where(m => !m.IsSpecialName).FirstOrDefault(x => x.Name == Decode("Q29uZmlndXJlU2VydmljZXM=") /*"ConfigureServices"*/ ); Assert.IsNotNull(method, "method: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Startup.ConfigureServices(IServiceCollection services) does not exists");
            Assert.IsTrue(method.IsPublic, "method: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Startup.ConfigureServices(IServiceCollection services) is not public");
            methodReturnType = method.ReturnType;
            Assert.AreEqual("System.Void", methodReturnType.FullName, "method: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Startup.ConfigureServices(IServiceCollection services) return type has changed");
            parametersCount = method.GetParameters().Length;
            Assert.AreEqual(1, parametersCount, "method: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Startup.ConfigureServices(IServiceCollection services) parameters count has changed");
            parameter = method.GetParameters().FirstOrDefault(x => x.Name == Decode("c2VydmljZXM=") /*"services"*/  && x.ParameterType.FullName == "Microsoft.Extensions.DependencyInjection.IServiceCollection");
            Assert.IsNotNull(parameter, "method: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Startup.ConfigureServices(IServiceCollection services) parameter services does not exists or does not have type Microsoft.Extensions.DependencyInjection.IServiceCollection");
            method = type.GetMethods().Where(m => !m.IsSpecialName).FirstOrDefault(x => x.Name == Decode("Q29uZmlndXJl") /*"Configure"*/ ); Assert.IsNotNull(method, "method: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Startup.Configure(IApplicationBuilder appIWebHostEnvironment env) does not exists");
            Assert.IsTrue(method.IsPublic, "method: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Startup.Configure(IApplicationBuilder appIWebHostEnvironment env) is not public");
            methodReturnType = method.ReturnType;
            Assert.AreEqual("System.Void", methodReturnType.FullName, "method: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Startup.Configure(IApplicationBuilder appIWebHostEnvironment env) return type has changed");
            parametersCount = method.GetParameters().Length;
            Assert.AreEqual(2, parametersCount, "method: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Startup.Configure(IApplicationBuilder appIWebHostEnvironment env) parameters count has changed");
            parameter = method.GetParameters().FirstOrDefault(x => x.Name == Decode("YXBw") /*"app"*/  && x.ParameterType.FullName == "Microsoft.AspNetCore.Builder.IApplicationBuilder");
            Assert.IsNotNull(parameter, "method: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Startup.Configure(IApplicationBuilder appIWebHostEnvironment env) parameter app does not exists or does not have type Microsoft.AspNetCore.Builder.IApplicationBuilder");
            parametersCount = method.GetParameters().Length;
            Assert.AreEqual(2, parametersCount, "method: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Startup.Configure(IApplicationBuilder appIWebHostEnvironment env) parameters count has changed");
            parameter = method.GetParameters().FirstOrDefault(x => x.Name == Decode("ZW52") /*"env"*/  && x.ParameterType.FullName == "Microsoft.AspNetCore.Hosting.IWebHostEnvironment");
            Assert.IsNotNull(parameter, "method: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Startup.Configure(IApplicationBuilder appIWebHostEnvironment env) parameter env does not exists or does not have type Microsoft.AspNetCore.Hosting.IWebHostEnvironment");
            constructorParameterNameTypeDictionary = new List<string>();
            constructorParameterNameTypeDictionary.Add("Microsoft.Extensions.Configuration.IConfiguration");
            constructor = type.GetConstructors().FirstOrDefault(x => x.GetParameters().Select(y => y.ParameterType.FullName).SequenceEqual(constructorParameterNameTypeDictionary));
            Assert.IsNotNull(constructor, "constructor: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Startup(IConfiguration configuration) does not exists");
            parametersCount = constructor.GetParameters().Length;
            Assert.AreEqual(1, parametersCount, "constructor: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Startup(IConfiguration configuration)  parameters count has changed");
            parameter = constructor.GetParameters().FirstOrDefault(x => x.Name == Decode("Y29uZmlndXJhdGlvbg==") /*"configuration"*/  && x.ParameterType.FullName == "Microsoft.Extensions.Configuration.IConfiguration");
            Assert.IsNotNull(parameter, "constructor: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Startup(IConfiguration configuration) parameter configuration does not exists or does not have type Microsoft.Extensions.Configuration.IConfiguration");
            property = type.GetProperties().Union(type.GetProperties().Where(x => type.GetInterfaces().SelectMany(y => y.GetProperties().Select(s => s.Name)).Any(y => y == x.Name))).FirstOrDefault(x => x.Name == Decode("Q29uZmlndXJhdGlvbg==") /*"Configuration"*/ );
            Assert.IsNotNull(property, "property: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Startup.IConfiguration Configuration does not exists");
            method = type.GetMethods().FirstOrDefault(x => x.Name == Decode("Z2V0X0NvbmZpZ3VyYXRpb24=") /*"get_Configuration"*/ ); Assert.IsNotNull(method, "method: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Startup.get_Configuration() does not exists");
            Assert.IsTrue(method.IsPublic, "method: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Startup.get_Configuration() is not public");
            methodReturnType = method.ReturnType;
            Assert.AreEqual("Microsoft.Extensions.Configuration.IConfiguration", methodReturnType.FullName, "method: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Startup.get_Configuration() return type has changed");
            propertyReturnType = property.PropertyType;
            Assert.AreEqual("Microsoft.Extensions.Configuration.IConfiguration", propertyReturnType.FullName, "property: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Startup.IConfiguration Configuration  type has changed");

            type = assembly.GetTypes().FirstOrDefault(x => x.Name == Decode("RXJyb3JWaWV3TW9kZWw=") /*"ErrorViewModel"*/ );
            Assert.IsNotNull(type, "Missing assembly: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Models.ErrorViewModel");
            Assert.IsTrue(type.IsClass, "assembly: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Models.ErrorViewModel is not class");
            Assert.IsTrue(type.IsPublic, "assembly: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Models.ErrorViewModel is not public class");
            constructorParameterNameTypeDictionary = new List<string>();
            constructor = type.GetConstructors().FirstOrDefault(x => x.GetParameters().Select(y => y.ParameterType.FullName).SequenceEqual(constructorParameterNameTypeDictionary));
            Assert.IsNotNull(constructor, "constructor: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Models.ErrorViewModel() does not exists");
            property = type.GetProperties().Union(type.GetProperties().Where(x => type.GetInterfaces().SelectMany(y => y.GetProperties().Select(s => s.Name)).Any(y => y == x.Name))).FirstOrDefault(x => x.Name == Decode("UmVxdWVzdElk") /*"RequestId"*/ );
            Assert.IsNotNull(property, "property: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Models.ErrorViewModel.String RequestId does not exists");
            method = type.GetMethods().FirstOrDefault(x => x.Name == Decode("Z2V0X1JlcXVlc3RJZA==") /*"get_RequestId"*/ ); Assert.IsNotNull(method, "method: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Models.ErrorViewModel.get_RequestId() does not exists");
            Assert.IsTrue(method.IsPublic, "method: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Models.ErrorViewModel.get_RequestId() is not public");
            methodReturnType = method.ReturnType;
            Assert.AreEqual("System.String", methodReturnType.FullName, "method: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Models.ErrorViewModel.get_RequestId() return type has changed");
            method = type.GetMethods().FirstOrDefault(x => x.Name == Decode("Z2V0X1JlcXVlc3RJZA==") /*"get_RequestId"*/ ); Assert.IsNotNull(method, "method: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Models.ErrorViewModel.get_RequestId() does not exists");
            Assert.IsTrue(method.IsPublic, "method: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Models.ErrorViewModel.get_RequestId() is not public");
            methodReturnType = method.ReturnType;
            Assert.AreEqual("System.String", methodReturnType.FullName, "method: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Models.ErrorViewModel.get_RequestId() return type has changed");
            propertyReturnType = property.PropertyType;
            Assert.AreEqual("System.String", propertyReturnType.FullName, "property: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Models.ErrorViewModel.String RequestId  type has changed");
            property = type.GetProperties().Union(type.GetProperties().Where(x => type.GetInterfaces().SelectMany(y => y.GetProperties().Select(s => s.Name)).Any(y => y == x.Name))).FirstOrDefault(x => x.Name == Decode("U2hvd1JlcXVlc3RJZA==") /*"ShowRequestId"*/ );
            Assert.IsNotNull(property, "property: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Models.ErrorViewModel.Boolean ShowRequestId does not exists");
            method = type.GetMethods().FirstOrDefault(x => x.Name == Decode("Z2V0X1Nob3dSZXF1ZXN0SWQ=") /*"get_ShowRequestId"*/ ); Assert.IsNotNull(method, "method: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Models.ErrorViewModel.get_ShowRequestId() does not exists");
            Assert.IsTrue(method.IsPublic, "method: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Models.ErrorViewModel.get_ShowRequestId() is not public");
            methodReturnType = method.ReturnType;
            Assert.AreEqual("System.Boolean", methodReturnType.FullName, "method: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Models.ErrorViewModel.get_ShowRequestId() return type has changed");
            propertyReturnType = property.PropertyType;
            Assert.AreEqual("System.Boolean", propertyReturnType.FullName, "property: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Models.ErrorViewModel.Boolean ShowRequestId  type has changed");

            type = assembly.GetTypes().FirstOrDefault(x => x.Name == Decode("TW92aWVzUmVwb3J0TW9kZWw=") /*"MoviesReportModel"*/ );
            Assert.IsNotNull(type, "Missing assembly: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Models.MoviesReportModel");
            Assert.IsTrue(type.IsClass, "assembly: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Models.MoviesReportModel is not class");
            Assert.IsTrue(type.IsPublic, "assembly: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Models.MoviesReportModel is not public class");
            constructorParameterNameTypeDictionary = new List<string>();
            constructor = type.GetConstructors().FirstOrDefault(x => x.GetParameters().Select(y => y.ParameterType.FullName).SequenceEqual(constructorParameterNameTypeDictionary));
            Assert.IsNotNull(constructor, "constructor: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Models.MoviesReportModel() does not exists");
            property = type.GetProperties().Union(type.GetProperties().Where(x => type.GetInterfaces().SelectMany(y => y.GetProperties().Select(s => s.Name)).Any(y => y == x.Name))).FirstOrDefault(x => x.Name == Decode("Q2F0ZWdvcmllcw==") /*"Categories"*/ );
            Assert.IsNotNull(property, "property: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Models.MoviesReportModel.IEnumerable`1 Categories does not exists");
            method = type.GetMethods().FirstOrDefault(x => x.Name == Decode("Z2V0X0NhdGVnb3JpZXM=") /*"get_Categories"*/ ); Assert.IsNotNull(method, "method: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Models.MoviesReportModel.get_Categories() does not exists");
            Assert.IsTrue(method.IsPublic, "method: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Models.MoviesReportModel.get_Categories() is not public");
            methodReturnType = method.ReturnType;
            Assert.AreEqual("System.Collections.Generic.IEnumerable`1[[Microsoft.AspNetCore.Mvc.Rendering.SelectListItem, Microsoft.AspNetCore.Mvc.ViewFeatures, Version=5.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60]]", methodReturnType.FullName, "method: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Models.MoviesReportModel.get_Categories() return type has changed");
            method = type.GetMethods().FirstOrDefault(x => x.Name == Decode("Z2V0X0NhdGVnb3JpZXM=") /*"get_Categories"*/ ); Assert.IsNotNull(method, "method: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Models.MoviesReportModel.get_Categories() does not exists");
            Assert.IsTrue(method.IsPublic, "method: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Models.MoviesReportModel.get_Categories() is not public");
            methodReturnType = method.ReturnType;
            Assert.AreEqual("System.Collections.Generic.IEnumerable`1[[Microsoft.AspNetCore.Mvc.Rendering.SelectListItem, Microsoft.AspNetCore.Mvc.ViewFeatures, Version=5.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60]]", methodReturnType.FullName, "method: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Models.MoviesReportModel.get_Categories() return type has changed");
            propertyReturnType = property.PropertyType;
            Assert.AreEqual("System.Collections.Generic.IEnumerable`1[[Microsoft.AspNetCore.Mvc.Rendering.SelectListItem, Microsoft.AspNetCore.Mvc.ViewFeatures, Version=5.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60]]", propertyReturnType.FullName, "property: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Models.MoviesReportModel.IEnumerable`1 Categories  type has changed");
            property = type.GetProperties().Union(type.GetProperties().Where(x => type.GetInterfaces().SelectMany(y => y.GetProperties().Select(s => s.Name)).Any(y => y == x.Name))).FirstOrDefault(x => x.Name == Decode("Q2F0ZWdvcnlJZA==") /*"CategoryId"*/ );
            Assert.IsNotNull(property, "property: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Models.MoviesReportModel.Nullable`1 CategoryId does not exists");
            method = type.GetMethods().FirstOrDefault(x => x.Name == Decode("Z2V0X0NhdGVnb3J5SWQ=") /*"get_CategoryId"*/ ); Assert.IsNotNull(method, "method: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Models.MoviesReportModel.get_CategoryId() does not exists");
            Assert.IsTrue(method.IsPublic, "method: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Models.MoviesReportModel.get_CategoryId() is not public");
            methodReturnType = method.ReturnType;
            Assert.AreEqual("System.Nullable`1[[System.Int32, System.Private.CoreLib, Version=5.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e]]", methodReturnType.FullName, "method: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Models.MoviesReportModel.get_CategoryId() return type has changed");
            method = type.GetMethods().FirstOrDefault(x => x.Name == Decode("Z2V0X0NhdGVnb3J5SWQ=") /*"get_CategoryId"*/ ); Assert.IsNotNull(method, "method: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Models.MoviesReportModel.get_CategoryId() does not exists");
            Assert.IsTrue(method.IsPublic, "method: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Models.MoviesReportModel.get_CategoryId() is not public");
            methodReturnType = method.ReturnType;
            Assert.AreEqual("System.Nullable`1[[System.Int32, System.Private.CoreLib, Version=5.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e]]", methodReturnType.FullName, "method: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Models.MoviesReportModel.get_CategoryId() return type has changed");
            propertyReturnType = property.PropertyType;
            Assert.AreEqual("System.Nullable`1[[System.Int32, System.Private.CoreLib, Version=5.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e]]", propertyReturnType.FullName, "property: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Models.MoviesReportModel.Nullable`1 CategoryId  type has changed");
            property = type.GetProperties().Union(type.GetProperties().Where(x => type.GetInterfaces().SelectMany(y => y.GetProperties().Select(s => s.Name)).Any(y => y == x.Name))).FirstOrDefault(x => x.Name == Decode("RnJvbVllYXI=") /*"FromYear"*/ );
            Assert.IsNotNull(property, "property: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Models.MoviesReportModel.Nullable`1 FromYear does not exists");
            method = type.GetMethods().FirstOrDefault(x => x.Name == Decode("Z2V0X0Zyb21ZZWFy") /*"get_FromYear"*/ ); Assert.IsNotNull(method, "method: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Models.MoviesReportModel.get_FromYear() does not exists");
            Assert.IsTrue(method.IsPublic, "method: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Models.MoviesReportModel.get_FromYear() is not public");
            methodReturnType = method.ReturnType;
            Assert.AreEqual("System.Nullable`1[[System.Int32, System.Private.CoreLib, Version=5.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e]]", methodReturnType.FullName, "method: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Models.MoviesReportModel.get_FromYear() return type has changed");
            method = type.GetMethods().FirstOrDefault(x => x.Name == Decode("Z2V0X0Zyb21ZZWFy") /*"get_FromYear"*/ ); Assert.IsNotNull(method, "method: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Models.MoviesReportModel.get_FromYear() does not exists");
            Assert.IsTrue(method.IsPublic, "method: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Models.MoviesReportModel.get_FromYear() is not public");
            methodReturnType = method.ReturnType;
            Assert.AreEqual("System.Nullable`1[[System.Int32, System.Private.CoreLib, Version=5.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e]]", methodReturnType.FullName, "method: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Models.MoviesReportModel.get_FromYear() return type has changed");
            propertyReturnType = property.PropertyType;
            Assert.AreEqual("System.Nullable`1[[System.Int32, System.Private.CoreLib, Version=5.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e]]", propertyReturnType.FullName, "property: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Models.MoviesReportModel.Nullable`1 FromYear  type has changed");
            property = type.GetProperties().Union(type.GetProperties().Where(x => type.GetInterfaces().SelectMany(y => y.GetProperties().Select(s => s.Name)).Any(y => y == x.Name))).FirstOrDefault(x => x.Name == Decode("TGltaXQ=") /*"Limit"*/ );
            Assert.IsNotNull(property, "property: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Models.MoviesReportModel.Int32 Limit does not exists");
            method = type.GetMethods().FirstOrDefault(x => x.Name == Decode("Z2V0X0xpbWl0") /*"get_Limit"*/ ); Assert.IsNotNull(method, "method: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Models.MoviesReportModel.get_Limit() does not exists");
            Assert.IsTrue(method.IsPublic, "method: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Models.MoviesReportModel.get_Limit() is not public");
            methodReturnType = method.ReturnType;
            Assert.AreEqual("System.Int32", methodReturnType.FullName, "method: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Models.MoviesReportModel.get_Limit() return type has changed");
            method = type.GetMethods().FirstOrDefault(x => x.Name == Decode("Z2V0X0xpbWl0") /*"get_Limit"*/ ); Assert.IsNotNull(method, "method: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Models.MoviesReportModel.get_Limit() does not exists");
            Assert.IsTrue(method.IsPublic, "method: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Models.MoviesReportModel.get_Limit() is not public");
            methodReturnType = method.ReturnType;
            Assert.AreEqual("System.Int32", methodReturnType.FullName, "method: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Models.MoviesReportModel.get_Limit() return type has changed");
            propertyReturnType = property.PropertyType;
            Assert.AreEqual("System.Int32", propertyReturnType.FullName, "property: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Models.MoviesReportModel.Int32 Limit  type has changed");
            property = type.GetProperties().Union(type.GetProperties().Where(x => type.GetInterfaces().SelectMany(y => y.GetProperties().Select(s => s.Name)).Any(y => y == x.Name))).FirstOrDefault(x => x.Name == Decode("U2VhcmNoUmVzdWx0cw==") /*"SearchResults"*/ );
            Assert.IsNotNull(property, "property: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Models.MoviesReportModel.IEnumerable`1 SearchResults does not exists");
            method = type.GetMethods().FirstOrDefault(x => x.Name == Decode("Z2V0X1NlYXJjaFJlc3VsdHM=") /*"get_SearchResults"*/ ); Assert.IsNotNull(method, "method: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Models.MoviesReportModel.get_SearchResults() does not exists");
            Assert.IsTrue(method.IsPublic, "method: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Models.MoviesReportModel.get_SearchResults() is not public");
            methodReturnType = method.ReturnType;
            Assert.AreEqual("System.Collections.Generic.IEnumerable`1[[MoviesRepository.Data.Models.MoviesReportItem, MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]", methodReturnType.FullName, "method: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Models.MoviesReportModel.get_SearchResults() return type has changed");
            method = type.GetMethods().FirstOrDefault(x => x.Name == Decode("Z2V0X1NlYXJjaFJlc3VsdHM=") /*"get_SearchResults"*/ ); Assert.IsNotNull(method, "method: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Models.MoviesReportModel.get_SearchResults() does not exists");
            Assert.IsTrue(method.IsPublic, "method: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Models.MoviesReportModel.get_SearchResults() is not public");
            methodReturnType = method.ReturnType;
            Assert.AreEqual("System.Collections.Generic.IEnumerable`1[[MoviesRepository.Data.Models.MoviesReportItem, MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]", methodReturnType.FullName, "method: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Models.MoviesReportModel.get_SearchResults() return type has changed");
            propertyReturnType = property.PropertyType;
            Assert.AreEqual("System.Collections.Generic.IEnumerable`1[[MoviesRepository.Data.Models.MoviesReportItem, MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]", propertyReturnType.FullName, "property: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Models.MoviesReportModel.IEnumerable`1 SearchResults  type has changed");
            property = type.GetProperties().Union(type.GetProperties().Where(x => type.GetInterfaces().SelectMany(y => y.GetProperties().Select(s => s.Name)).Any(y => y == x.Name))).FirstOrDefault(x => x.Name == Decode("VG9ZZWFy") /*"ToYear"*/ );
            Assert.IsNotNull(property, "property: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Models.MoviesReportModel.Nullable`1 ToYear does not exists");
            method = type.GetMethods().FirstOrDefault(x => x.Name == Decode("Z2V0X1RvWWVhcg==") /*"get_ToYear"*/ ); Assert.IsNotNull(method, "method: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Models.MoviesReportModel.get_ToYear() does not exists");
            Assert.IsTrue(method.IsPublic, "method: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Models.MoviesReportModel.get_ToYear() is not public");
            methodReturnType = method.ReturnType;
            Assert.AreEqual("System.Nullable`1[[System.Int32, System.Private.CoreLib, Version=5.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e]]", methodReturnType.FullName, "method: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Models.MoviesReportModel.get_ToYear() return type has changed");
            method = type.GetMethods().FirstOrDefault(x => x.Name == Decode("Z2V0X1RvWWVhcg==") /*"get_ToYear"*/ ); Assert.IsNotNull(method, "method: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Models.MoviesReportModel.get_ToYear() does not exists");
            Assert.IsTrue(method.IsPublic, "method: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Models.MoviesReportModel.get_ToYear() is not public");
            methodReturnType = method.ReturnType;
            Assert.AreEqual("System.Nullable`1[[System.Int32, System.Private.CoreLib, Version=5.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e]]", methodReturnType.FullName, "method: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Models.MoviesReportModel.get_ToYear() return type has changed");
            propertyReturnType = property.PropertyType;
            Assert.AreEqual("System.Nullable`1[[System.Int32, System.Private.CoreLib, Version=5.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e]]", propertyReturnType.FullName, "property: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Models.MoviesReportModel.Nullable`1 ToYear  type has changed");

            type = assembly.GetTypes().FirstOrDefault(x => x.Name == Decode("QmFzZUNvbnRyb2xsZXI=") /*"BaseController"*/ );
            Assert.IsNotNull(type, "Missing assembly: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Controllers.BaseController");
            Assert.IsTrue(type.IsClass, "assembly: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Controllers.BaseController is not class");
            Assert.IsTrue(type.IsAbstract, "assembly: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Controllers.BaseController is not abstract class");
            Assert.IsTrue(type.IsPublic, "assembly: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Controllers.BaseController is not public class");
            method = type.GetMethods().Where(m => !m.IsSpecialName).FirstOrDefault(x => x.Name == Decode("RGlzcG9zZQ==") /*"Dispose"*/ ); Assert.IsNotNull(method, "method: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Controllers.BaseController.Dispose() does not exists");
            Assert.IsTrue(method.IsVirtual, "method: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Controllers.BaseController.Dispose() is not virtual");
            methodReturnType = method.ReturnType;
            Assert.AreEqual("System.Void", methodReturnType.FullName, "method: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Controllers.BaseController.Dispose() return type has changed");
            constructorParameterNameTypeDictionary = new List<string>();
            constructor = type.GetConstructors().FirstOrDefault(x => x.GetParameters().Select(y => y.ParameterType.FullName).SequenceEqual(constructorParameterNameTypeDictionary));
            Assert.IsNotNull(constructor, "constructor: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Controllers.BaseController() does not exists");

            type = assembly.GetTypes().FirstOrDefault(x => x.Name == Decode("SG9tZUNvbnRyb2xsZXI=") /*"HomeController"*/ );
            Assert.IsNotNull(type, "Missing assembly: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Controllers.HomeController");
            Assert.IsTrue(type.IsClass, "assembly: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Controllers.HomeController is not class");
            Assert.IsTrue(type.IsPublic, "assembly: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Controllers.HomeController is not public class");
            
            method = type.GetMethods().Where(m => !m.IsSpecialName && m.GetParameters().Length == 0).FirstOrDefault(x => x.Name == Decode("SW5kZXg=") /*"Index"*/ ); 
            Assert.IsNotNull(method, "method: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Controllers.HomeController.Index() does not exists");
            Assert.IsTrue(method.IsPublic, "method: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Controllers.HomeController.Index() is not public");
            methodReturnType = method.ReturnType;
            Assert.AreEqual("Microsoft.AspNetCore.Mvc.ActionResult", methodReturnType.FullName, "method: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Controllers.HomeController.Index() return type has changed");
            
            method = type.GetMethods().Where(m => !m.IsSpecialName && m.GetParameters().Length == 1).FirstOrDefault(x => x.Name == Decode("SW5kZXg=") /*"Index"*/ );             
            Assert.IsNotNull(method, "method: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Controllers.HomeController.Index(MoviesReportModel model) does not exists");
            Assert.IsTrue(method.IsPublic, "method: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Controllers.HomeController.Index(MoviesReportModel model) is not public");
            methodReturnType = method.ReturnType;
            Assert.AreEqual("Microsoft.AspNetCore.Mvc.ActionResult", methodReturnType.FullName, "method: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Controllers.HomeController.Index(MoviesReportModel model) return type has changed");
            parametersCount = method.GetParameters().Length;
            Assert.AreEqual(1, parametersCount, "method: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Controllers.HomeController.Index(MoviesReportModel model) parameters count has changed");
            constructorParameterNameTypeDictionary = new List<string>();
            constructor = type.GetConstructors().FirstOrDefault(x => x.GetParameters().Select(y => y.ParameterType.FullName).SequenceEqual(constructorParameterNameTypeDictionary));
            Assert.IsNotNull(constructor, "constructor: MoviesRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Controllers.HomeController() does not exists");
        }

        /// <summary>
        /// !!! WARNING 
        /// !!! Project structure test.
        /// !!! DON'T CHANGE IT! 
        /// !!! Changes may cause the solution to be rejected.
        /// </summary>
        private string Decode(string text)
        {
            return System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(text));
        }
    }
}
