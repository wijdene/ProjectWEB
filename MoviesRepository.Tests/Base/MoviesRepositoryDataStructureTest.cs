
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
    public class MoviesRepositoryDataStructureTest
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
            assembly = Assembly.Load(Decode("TW92aWVSZXBvc2l0b3J5LkRhdGEsIFZlcnNpb249MS4wLjAuMCwgQ3VsdHVyZT1uZXV0cmFsLCBQdWJsaWNLZXlUb2tlbj1udWxs") /*"MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"*/ );
            Assert.IsNotNull(assembly, "Missing  MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null");

                type = assembly.GetTypes().FirstOrDefault(x=>x.Name == Decode("Q2F0ZWdvcnlSZXBvc2l0b3J5") /*"CategoryRepository"*/ );
                Assert.IsNotNull(type, "Missing assembly: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Repositories.CategoryRepository");
                    Assert.IsTrue(type.IsClass, "assembly: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Repositories.CategoryRepository is not class");
                    Assert.IsTrue(type.IsPublic, "assembly: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Repositories.CategoryRepository is not public class");
                            method = type.GetMethods().Where(m => !m.IsSpecialName).FirstOrDefault(x=>x.Name == Decode("Q291bnQ=") /*"Count"*/ );                            Assert.IsNotNull(method, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Repositories.CategoryRepository.Count() does not exists");
                            Assert.IsTrue(method.IsPublic, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Repositories.CategoryRepository.Count() is not public");
                            Assert.IsTrue(method.IsVirtual, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Repositories.CategoryRepository.Count() is not virtual");
                            methodReturnType = method.ReturnType;
                            Assert.AreEqual("System.Int64",methodReturnType.FullName, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Repositories.CategoryRepository.Count() return type has changed");
                            method = type.GetMethods().Where(m => !m.IsSpecialName).FirstOrDefault(x=>x.Name == Decode("RmluZA==") /*"Find"*/ );                            Assert.IsNotNull(method, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Repositories.CategoryRepository.Find(Int32 id) does not exists");
                            Assert.IsTrue(method.IsPublic, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Repositories.CategoryRepository.Find(Int32 id) is not public");
                            Assert.IsTrue(method.IsVirtual, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Repositories.CategoryRepository.Find(Int32 id) is not virtual");
                            methodReturnType = method.ReturnType;
                            Assert.AreEqual("MoviesRepository.Data.Models.Category",methodReturnType.FullName, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Repositories.CategoryRepository.Find(Int32 id) return type has changed");
                                parametersCount = method.GetParameters().Length;
                                Assert.AreEqual(1,parametersCount, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Repositories.CategoryRepository.Find(Int32 id) parameters count has changed");
                                parameter = method.GetParameters().FirstOrDefault(x=>x.Name == Decode("aWQ=") /*"id"*/  && x.ParameterType.FullName == "System.Int32");
                                Assert.IsNotNull(parameter, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Repositories.CategoryRepository.Find(Int32 id) parameter id does not exists or does not have type System.Int32");
                            method = type.GetMethods().Where(m => !m.IsSpecialName).FirstOrDefault(x=>x.Name == Decode("RmluZEFsbA==") /*"FindAll"*/ );                            Assert.IsNotNull(method, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Repositories.CategoryRepository.FindAll() does not exists");
                            Assert.IsTrue(method.IsPublic, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Repositories.CategoryRepository.FindAll() is not public");
                            Assert.IsTrue(method.IsVirtual, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Repositories.CategoryRepository.FindAll() is not virtual");
                            methodReturnType = method.ReturnType;
                            Assert.AreEqual("System.Collections.Generic.IEnumerable`1[[MoviesRepository.Data.Models.Category, MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]",methodReturnType.FullName, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Repositories.CategoryRepository.FindAll() return type has changed");
                            method = type.GetMethods().Where(m => !m.IsSpecialName).FirstOrDefault(x=>x.Name == Decode("RmluZEJ5TmFtZQ==") /*"FindByName"*/ );                            Assert.IsNotNull(method, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Repositories.CategoryRepository.FindByName(String name) does not exists");
                            Assert.IsTrue(method.IsPublic, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Repositories.CategoryRepository.FindByName(String name) is not public");
                            Assert.IsTrue(method.IsVirtual, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Repositories.CategoryRepository.FindByName(String name) is not virtual");
                            methodReturnType = method.ReturnType;
                            Assert.AreEqual("MoviesRepository.Data.Models.Category",methodReturnType.FullName, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Repositories.CategoryRepository.FindByName(String name) return type has changed");
                                parametersCount = method.GetParameters().Length;
                                Assert.AreEqual(1,parametersCount, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Repositories.CategoryRepository.FindByName(String name) parameters count has changed");
                                parameter = method.GetParameters().FirstOrDefault(x=>x.Name == Decode("bmFtZQ==") /*"name"*/  && x.ParameterType.FullName == "System.String");
                                Assert.IsNotNull(parameter, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Repositories.CategoryRepository.FindByName(String name) parameter name does not exists or does not have type System.String");
                            method = type.GetMethods().Where(m => !m.IsSpecialName).FirstOrDefault(x=>x.Name == Decode("U2F2ZQ==") /*"Save"*/ );                            Assert.IsNotNull(method, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Repositories.CategoryRepository.Save(Category category) does not exists");
                            Assert.IsTrue(method.IsPublic, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Repositories.CategoryRepository.Save(Category category) is not public");
                            Assert.IsTrue(method.IsVirtual, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Repositories.CategoryRepository.Save(Category category) is not virtual");
                            methodReturnType = method.ReturnType;
                            Assert.AreEqual("System.Boolean",methodReturnType.FullName, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Repositories.CategoryRepository.Save(Category category) return type has changed");
                                parametersCount = method.GetParameters().Length;
                                Assert.AreEqual(1,parametersCount, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Repositories.CategoryRepository.Save(Category category) parameters count has changed");
                                parameter = method.GetParameters().FirstOrDefault(x=>x.Name == Decode("Y2F0ZWdvcnk=") /*"category"*/  && x.ParameterType.FullName == "MoviesRepository.Data.Models.Category");
                                Assert.IsNotNull(parameter, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Repositories.CategoryRepository.Save(Category category) parameter category does not exists or does not have type MoviesRepository.Data.Models.Category");
                        constructorParameterNameTypeDictionary = new List<string>();
                            constructorParameterNameTypeDictionary.Add("System.Data.SQLite.SQLiteConnection");
                            constructor = type.GetConstructors().FirstOrDefault(x=>x.GetParameters().Select(y=>y.ParameterType.FullName).SequenceEqual(constructorParameterNameTypeDictionary));
                            Assert.IsNotNull(constructor, "constructor: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Repositories.CategoryRepository(SQLiteConnection connection) does not exists");
                                parametersCount = constructor.GetParameters().Length;
                                Assert.AreEqual(1,parametersCount, "constructor: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Repositories.CategoryRepository(SQLiteConnection connection)  parameters count has changed");
                                parameter = constructor.GetParameters().FirstOrDefault(x=>x.Name == Decode("Y29ubmVjdGlvbg==") /*"connection"*/  && x.ParameterType.FullName == "System.Data.SQLite.SQLiteConnection");
                                Assert.IsNotNull(parameter, "constructor: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Repositories.CategoryRepository(SQLiteConnection connection) parameter connection does not exists or does not have type System.Data.SQLite.SQLiteConnection");

                type = assembly.GetTypes().FirstOrDefault(x=>x.Name == Decode("SUNhdGVnb3J5UmVwb3NpdG9yeQ==") /*"ICategoryRepository"*/ );
                Assert.IsNotNull(type, "Missing assembly: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Repositories.ICategoryRepository");
                    Assert.IsTrue(type.IsAbstract, "assembly: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Repositories.ICategoryRepository is not abstract class");
                    Assert.IsTrue(type.IsInterface, "assembly: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Repositories.ICategoryRepository is not interface");
                    Assert.IsTrue(type.IsPublic, "assembly: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Repositories.ICategoryRepository is not public class");
                            method = type.GetMethods().Where(m => !m.IsSpecialName).FirstOrDefault(x=>x.Name == Decode("Q291bnQ=") /*"Count"*/ );                            Assert.IsNotNull(method, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Repositories.ICategoryRepository.Count() does not exists");
                            Assert.IsTrue(method.IsPublic, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Repositories.ICategoryRepository.Count() is not public");
                            Assert.IsTrue(method.IsAbstract, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Repositories.ICategoryRepository.Count() is not abstract");
                            Assert.IsTrue(method.IsVirtual, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Repositories.ICategoryRepository.Count() is not virtual");
                            methodReturnType = method.ReturnType;
                            Assert.AreEqual("System.Int64",methodReturnType.FullName, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Repositories.ICategoryRepository.Count() return type has changed");
                            method = type.GetMethods().Where(m => !m.IsSpecialName).FirstOrDefault(x=>x.Name == Decode("RmluZA==") /*"Find"*/ );                            Assert.IsNotNull(method, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Repositories.ICategoryRepository.Find(Int32 id) does not exists");
                            Assert.IsTrue(method.IsPublic, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Repositories.ICategoryRepository.Find(Int32 id) is not public");
                            Assert.IsTrue(method.IsAbstract, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Repositories.ICategoryRepository.Find(Int32 id) is not abstract");
                            Assert.IsTrue(method.IsVirtual, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Repositories.ICategoryRepository.Find(Int32 id) is not virtual");
                            methodReturnType = method.ReturnType;
                            Assert.AreEqual("MoviesRepository.Data.Models.Category",methodReturnType.FullName, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Repositories.ICategoryRepository.Find(Int32 id) return type has changed");
                                parametersCount = method.GetParameters().Length;
                                Assert.AreEqual(1,parametersCount, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Repositories.ICategoryRepository.Find(Int32 id) parameters count has changed");
                                parameter = method.GetParameters().FirstOrDefault(x=>x.Name == Decode("aWQ=") /*"id"*/  && x.ParameterType.FullName == "System.Int32");
                                Assert.IsNotNull(parameter, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Repositories.ICategoryRepository.Find(Int32 id) parameter id does not exists or does not have type System.Int32");
                            method = type.GetMethods().Where(m => !m.IsSpecialName).FirstOrDefault(x=>x.Name == Decode("RmluZEFsbA==") /*"FindAll"*/ );                            Assert.IsNotNull(method, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Repositories.ICategoryRepository.FindAll() does not exists");
                            Assert.IsTrue(method.IsPublic, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Repositories.ICategoryRepository.FindAll() is not public");
                            Assert.IsTrue(method.IsAbstract, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Repositories.ICategoryRepository.FindAll() is not abstract");
                            Assert.IsTrue(method.IsVirtual, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Repositories.ICategoryRepository.FindAll() is not virtual");
                            methodReturnType = method.ReturnType;
                            Assert.AreEqual("System.Collections.Generic.IEnumerable`1[[MoviesRepository.Data.Models.Category, MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]",methodReturnType.FullName, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Repositories.ICategoryRepository.FindAll() return type has changed");
                            method = type.GetMethods().Where(m => !m.IsSpecialName).FirstOrDefault(x=>x.Name == Decode("RmluZEJ5TmFtZQ==") /*"FindByName"*/ );                            Assert.IsNotNull(method, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Repositories.ICategoryRepository.FindByName(String name) does not exists");
                            Assert.IsTrue(method.IsPublic, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Repositories.ICategoryRepository.FindByName(String name) is not public");
                            Assert.IsTrue(method.IsAbstract, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Repositories.ICategoryRepository.FindByName(String name) is not abstract");
                            Assert.IsTrue(method.IsVirtual, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Repositories.ICategoryRepository.FindByName(String name) is not virtual");
                            methodReturnType = method.ReturnType;
                            Assert.AreEqual("MoviesRepository.Data.Models.Category",methodReturnType.FullName, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Repositories.ICategoryRepository.FindByName(String name) return type has changed");
                                parametersCount = method.GetParameters().Length;
                                Assert.AreEqual(1,parametersCount, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Repositories.ICategoryRepository.FindByName(String name) parameters count has changed");
                                parameter = method.GetParameters().FirstOrDefault(x=>x.Name == Decode("bmFtZQ==") /*"name"*/  && x.ParameterType.FullName == "System.String");
                                Assert.IsNotNull(parameter, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Repositories.ICategoryRepository.FindByName(String name) parameter name does not exists or does not have type System.String");
                            method = type.GetMethods().Where(m => !m.IsSpecialName).FirstOrDefault(x=>x.Name == Decode("U2F2ZQ==") /*"Save"*/ );                            Assert.IsNotNull(method, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Repositories.ICategoryRepository.Save(Category category) does not exists");
                            Assert.IsTrue(method.IsPublic, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Repositories.ICategoryRepository.Save(Category category) is not public");
                            Assert.IsTrue(method.IsAbstract, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Repositories.ICategoryRepository.Save(Category category) is not abstract");
                            Assert.IsTrue(method.IsVirtual, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Repositories.ICategoryRepository.Save(Category category) is not virtual");
                            methodReturnType = method.ReturnType;
                            Assert.AreEqual("System.Boolean",methodReturnType.FullName, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Repositories.ICategoryRepository.Save(Category category) return type has changed");
                                parametersCount = method.GetParameters().Length;
                                Assert.AreEqual(1,parametersCount, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Repositories.ICategoryRepository.Save(Category category) parameters count has changed");
                                parameter = method.GetParameters().FirstOrDefault(x=>x.Name == Decode("Y2F0ZWdvcnk=") /*"category"*/  && x.ParameterType.FullName == "MoviesRepository.Data.Models.Category");
                                Assert.IsNotNull(parameter, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Repositories.ICategoryRepository.Save(Category category) parameter category does not exists or does not have type MoviesRepository.Data.Models.Category");

                type = assembly.GetTypes().FirstOrDefault(x=>x.Name == Decode("SU1vdmllUmVwb3J0") /*"IMovieReport"*/ );
                Assert.IsNotNull(type, "Missing assembly: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Repositories.IMovieReport");
                    Assert.IsTrue(type.IsAbstract, "assembly: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Repositories.IMovieReport is not abstract class");
                    Assert.IsTrue(type.IsInterface, "assembly: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Repositories.IMovieReport is not interface");
                    Assert.IsTrue(type.IsPublic, "assembly: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Repositories.IMovieReport is not public class");
                            method = type.GetMethods().Where(m => !m.IsSpecialName).FirstOrDefault(x=>x.Name == Decode("R2V0") /*"Get"*/ );                            Assert.IsNotNull(method, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Repositories.IMovieReport.Get(Nullable`1 limitNullable`1 fromYearNullable`1 toYearInt32[] categoriesIds) does not exists");
                            Assert.IsTrue(method.IsPublic, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Repositories.IMovieReport.Get(Nullable`1 limitNullable`1 fromYearNullable`1 toYearInt32[] categoriesIds) is not public");
                            Assert.IsTrue(method.IsAbstract, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Repositories.IMovieReport.Get(Nullable`1 limitNullable`1 fromYearNullable`1 toYearInt32[] categoriesIds) is not abstract");
                            Assert.IsTrue(method.IsVirtual, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Repositories.IMovieReport.Get(Nullable`1 limitNullable`1 fromYearNullable`1 toYearInt32[] categoriesIds) is not virtual");
                            methodReturnType = method.ReturnType;
                            Assert.AreEqual("MoviesRepository.Data.Models.MoviesReportItem[]",methodReturnType.FullName, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Repositories.IMovieReport.Get(Nullable`1 limitNullable`1 fromYearNullable`1 toYearInt32[] categoriesIds) return type has changed");
                                parametersCount = method.GetParameters().Length;
                                Assert.AreEqual(4,parametersCount, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Repositories.IMovieReport.Get(Nullable`1 limitNullable`1 fromYearNullable`1 toYearInt32[] categoriesIds) parameters count has changed");
                                parameter = method.GetParameters().FirstOrDefault(x=>x.Name == Decode("bGltaXQ=") /*"limit"*/  && x.ParameterType.IsGenericType && x.ParameterType.FullName.StartsWith("System.Nullable`1[[System.Int32"));
                                Assert.IsNotNull(parameter, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Repositories.IMovieReport.Get(Nullable`1 limitNullable`1 fromYearNullable`1 toYearInt32[] categoriesIds) parameter limit does not exists or does not have type System.Nullable`1[[System.Int32, System.Private.CoreLib, Version=5.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e]]");
                                parametersCount = method.GetParameters().Length;
                                Assert.AreEqual(4,parametersCount, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Repositories.IMovieReport.Get(Nullable`1 limitNullable`1 fromYearNullable`1 toYearInt32[] categoriesIds) parameters count has changed");
                                parameter = method.GetParameters().FirstOrDefault(x=>x.Name == Decode("ZnJvbVllYXI=") /*"fromYear"*/  && x.ParameterType.IsGenericType && x.ParameterType.FullName.StartsWith("System.Nullable`1[[System.Int32"));
                                Assert.IsNotNull(parameter, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Repositories.IMovieReport.Get(Nullable`1 limitNullable`1 fromYearNullable`1 toYearInt32[] categoriesIds) parameter fromYear does not exists or does not have type System.Nullable`1[[System.Int32, System.Private.CoreLib, Version=5.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e]]");
                                parametersCount = method.GetParameters().Length;
                                Assert.AreEqual(4,parametersCount, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Repositories.IMovieReport.Get(Nullable`1 limitNullable`1 fromYearNullable`1 toYearInt32[] categoriesIds) parameters count has changed");
                                parameter = method.GetParameters().FirstOrDefault(x=>x.Name == Decode("dG9ZZWFy") /*"toYear"*/  && x.ParameterType.IsGenericType && x.ParameterType.FullName.StartsWith("System.Nullable`1[[System.Int32"));
                                Assert.IsNotNull(parameter, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Repositories.IMovieReport.Get(Nullable`1 limitNullable`1 fromYearNullable`1 toYearInt32[] categoriesIds) parameter toYear does not exists or does not have type System.Nullable`1[[System.Int32, System.Private.CoreLib, Version=5.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e]]");
                                parametersCount = method.GetParameters().Length;
                                Assert.AreEqual(4,parametersCount, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Repositories.IMovieReport.Get(Nullable`1 limitNullable`1 fromYearNullable`1 toYearInt32[] categoriesIds) parameters count has changed");
                                parameter = method.GetParameters().FirstOrDefault(x=>x.Name == Decode("Y2F0ZWdvcmllc0lkcw==") /*"categoriesIds"*/  && x.ParameterType.FullName == "System.Int32[]");
                                Assert.IsNotNull(parameter, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Repositories.IMovieReport.Get(Nullable`1 limitNullable`1 fromYearNullable`1 toYearInt32[] categoriesIds) parameter categoriesIds does not exists or does not have type System.Int32[]");

                type = assembly.GetTypes().FirstOrDefault(x=>x.Name == Decode("TW92aWVSZXBvcnQ=") /*"MovieReport"*/ );
                Assert.IsNotNull(type, "Missing assembly: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Repositories.MovieReport");
                    Assert.IsTrue(type.IsClass, "assembly: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Repositories.MovieReport is not class");
                    Assert.IsTrue(type.IsPublic, "assembly: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Repositories.MovieReport is not public class");
                            method = type.GetMethods().Where(m => !m.IsSpecialName).FirstOrDefault(x=>x.Name == Decode("R2V0") /*"Get"*/ );                            Assert.IsNotNull(method, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Repositories.MovieReport.Get(Nullable`1 limitNullable`1 fromYearNullable`1 toYearInt32[] categoriesIds) does not exists");
                            Assert.IsTrue(method.IsPublic, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Repositories.MovieReport.Get(Nullable`1 limitNullable`1 fromYearNullable`1 toYearInt32[] categoriesIds) is not public");
                            Assert.IsTrue(method.IsVirtual, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Repositories.MovieReport.Get(Nullable`1 limitNullable`1 fromYearNullable`1 toYearInt32[] categoriesIds) is not virtual");
                            methodReturnType = method.ReturnType;
                            Assert.AreEqual("MoviesRepository.Data.Models.MoviesReportItem[]",methodReturnType.FullName, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Repositories.MovieReport.Get(Nullable`1 limitNullable`1 fromYearNullable`1 toYearInt32[] categoriesIds) return type has changed");
                                parametersCount = method.GetParameters().Length;
                                Assert.AreEqual(4,parametersCount, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Repositories.MovieReport.Get(Nullable`1 limitNullable`1 fromYearNullable`1 toYearInt32[] categoriesIds) parameters count has changed");
                                parameter = method.GetParameters().FirstOrDefault(x=>x.Name == Decode("bGltaXQ=") /*"limit"*/  && x.ParameterType.IsGenericType && x.ParameterType.FullName.StartsWith("System.Nullable`1[[System.Int32"));
                                Assert.IsNotNull(parameter, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Repositories.MovieReport.Get(Nullable`1 limitNullable`1 fromYearNullable`1 toYearInt32[] categoriesIds) parameter limit does not exists or does not have type System.Nullable`1[[System.Int32, System.Private.CoreLib, Version=5.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e]]");
                                parametersCount = method.GetParameters().Length;
                                Assert.AreEqual(4,parametersCount, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Repositories.MovieReport.Get(Nullable`1 limitNullable`1 fromYearNullable`1 toYearInt32[] categoriesIds) parameters count has changed");
                                parameter = method.GetParameters().FirstOrDefault(x=>x.Name == Decode("ZnJvbVllYXI=") /*"fromYear"*/  && x.ParameterType.IsGenericType && x.ParameterType.FullName.StartsWith("System.Nullable`1[[System.Int32"));
                                Assert.IsNotNull(parameter, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Repositories.MovieReport.Get(Nullable`1 limitNullable`1 fromYearNullable`1 toYearInt32[] categoriesIds) parameter fromYear does not exists or does not have type System.Nullable`1[[System.Int32, System.Private.CoreLib, Version=5.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e]]");
                                parametersCount = method.GetParameters().Length;
                                Assert.AreEqual(4,parametersCount, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Repositories.MovieReport.Get(Nullable`1 limitNullable`1 fromYearNullable`1 toYearInt32[] categoriesIds) parameters count has changed");
                                parameter = method.GetParameters().FirstOrDefault(x=>x.Name == Decode("dG9ZZWFy") /*"toYear"*/  && x.ParameterType.IsGenericType && x.ParameterType.FullName.StartsWith("System.Nullable`1[[System.Int32"));
                                Assert.IsNotNull(parameter, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Repositories.MovieReport.Get(Nullable`1 limitNullable`1 fromYearNullable`1 toYearInt32[] categoriesIds) parameter toYear does not exists or does not have type System.Nullable`1[[System.Int32, System.Private.CoreLib, Version=5.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e]]");
                                parametersCount = method.GetParameters().Length;
                                Assert.AreEqual(4,parametersCount, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Repositories.MovieReport.Get(Nullable`1 limitNullable`1 fromYearNullable`1 toYearInt32[] categoriesIds) parameters count has changed");
                                parameter = method.GetParameters().FirstOrDefault(x=>x.Name == Decode("Y2F0ZWdvcmllc0lkcw==") /*"categoriesIds"*/  && x.ParameterType.FullName == "System.Int32[]");
                                Assert.IsNotNull(parameter, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Repositories.MovieReport.Get(Nullable`1 limitNullable`1 fromYearNullable`1 toYearInt32[] categoriesIds) parameter categoriesIds does not exists or does not have type System.Int32[]");
                        constructorParameterNameTypeDictionary = new List<string>();
                            constructorParameterNameTypeDictionary.Add("System.Data.SQLite.SQLiteConnection");
                            constructor = type.GetConstructors().FirstOrDefault(x=>x.GetParameters().Select(y=>y.ParameterType.FullName).SequenceEqual(constructorParameterNameTypeDictionary));
                            Assert.IsNotNull(constructor, "constructor: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Repositories.MovieReport(SQLiteConnection connection) does not exists");
                                parametersCount = constructor.GetParameters().Length;
                                Assert.AreEqual(1,parametersCount, "constructor: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Repositories.MovieReport(SQLiteConnection connection)  parameters count has changed");
                                parameter = constructor.GetParameters().FirstOrDefault(x=>x.Name == Decode("Y29ubmVjdGlvbg==") /*"connection"*/  && x.ParameterType.FullName == "System.Data.SQLite.SQLiteConnection");
                                Assert.IsNotNull(parameter, "constructor: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Repositories.MovieReport(SQLiteConnection connection) parameter connection does not exists or does not have type System.Data.SQLite.SQLiteConnection");

                type = assembly.GetTypes().FirstOrDefault(x=>x.Name == Decode("Q2F0ZWdvcnk=") /*"Category"*/ );
                Assert.IsNotNull(type, "Missing assembly: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Models.Category");
                    Assert.IsTrue(type.IsClass, "assembly: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Models.Category is not class");
                    Assert.IsTrue(type.IsPublic, "assembly: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Models.Category is not public class");
                        constructorParameterNameTypeDictionary = new List<string>();
                            constructorParameterNameTypeDictionary.Add("System.String");
                            constructorParameterNameTypeDictionary.Add("System.Int32");
                            constructor = type.GetConstructors().FirstOrDefault(x=>x.GetParameters().Select(y=>y.ParameterType.FullName).SequenceEqual(constructorParameterNameTypeDictionary));
                            Assert.IsNotNull(constructor, "constructor: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Models.Category(String nameInt32 id) does not exists");
                                parametersCount = constructor.GetParameters().Length;
                                Assert.AreEqual(2,parametersCount, "constructor: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Models.Category(String nameInt32 id)  parameters count has changed");
                                parameter = constructor.GetParameters().FirstOrDefault(x=>x.Name == Decode("bmFtZQ==") /*"name"*/  && x.ParameterType.FullName == "System.String");
                                Assert.IsNotNull(parameter, "constructor: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Models.Category(String nameInt32 id) parameter name does not exists or does not have type System.String");
                                parametersCount = constructor.GetParameters().Length;
                                Assert.AreEqual(2,parametersCount, "constructor: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Models.Category(String nameInt32 id)  parameters count has changed");
                                parameter = constructor.GetParameters().FirstOrDefault(x=>x.Name == Decode("aWQ=") /*"id"*/  && x.ParameterType.FullName == "System.Int32");
                                Assert.IsNotNull(parameter, "constructor: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Models.Category(String nameInt32 id) parameter id does not exists or does not have type System.Int32");
                            property = type.GetProperties().Union(type.GetProperties().Where(x=>type.GetInterfaces().SelectMany(y=>y.GetProperties().Select(s=>s.Name)).Any(y => y == x.Name))).FirstOrDefault(x=>x.Name == Decode("SWQ=") /*"Id"*/ );
                            Assert.IsNotNull(property, "property: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Models.Category.Int32 Id does not exists");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X0lk") /*"get_Id"*/ );                                Assert.IsNotNull(method, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Models.Category.get_Id() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Models.Category.get_Id() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.Int32",methodReturnType.FullName, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Models.Category.get_Id() return type has changed");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X0lk") /*"get_Id"*/ );                                Assert.IsNotNull(method, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Models.Category.get_Id() does not exists");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.Int32",methodReturnType.FullName, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Models.Category.get_Id() return type has changed");
                            propertyReturnType = property.PropertyType;
                            Assert.AreEqual("System.Int32",propertyReturnType.FullName, "property: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Models.Category.Int32 Id  type has changed");
                            property = type.GetProperties().Union(type.GetProperties().Where(x=>type.GetInterfaces().SelectMany(y=>y.GetProperties().Select(s=>s.Name)).Any(y => y == x.Name))).FirstOrDefault(x=>x.Name == Decode("TmFtZQ==") /*"Name"*/ );
                            Assert.IsNotNull(property, "property: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Models.Category.String Name does not exists");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X05hbWU=") /*"get_Name"*/ );                                Assert.IsNotNull(method, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Models.Category.get_Name() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Models.Category.get_Name() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.String",methodReturnType.FullName, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Models.Category.get_Name() return type has changed");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X05hbWU=") /*"get_Name"*/ );                                Assert.IsNotNull(method, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Models.Category.get_Name() does not exists");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.String",methodReturnType.FullName, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Models.Category.get_Name() return type has changed");
                            propertyReturnType = property.PropertyType;
                            Assert.AreEqual("System.String",propertyReturnType.FullName, "property: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Models.Category.String Name  type has changed");

                type = assembly.GetTypes().FirstOrDefault(x=>x.Name == Decode("TW92aWVzUmVwb3J0SXRlbQ==") /*"MoviesReportItem"*/ );
                Assert.IsNotNull(type, "Missing assembly: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Models.MoviesReportItem");
                    Assert.IsTrue(type.IsClass, "assembly: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Models.MoviesReportItem is not class");
                    Assert.IsTrue(type.IsPublic, "assembly: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Models.MoviesReportItem is not public class");
                        constructorParameterNameTypeDictionary = new List<string>();
                            constructor = type.GetConstructors().FirstOrDefault(x=>x.GetParameters().Select(y=>y.ParameterType.FullName).SequenceEqual(constructorParameterNameTypeDictionary));
                            Assert.IsNotNull(constructor, "constructor: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Models.MoviesReportItem() does not exists");
                            property = type.GetProperties().Union(type.GetProperties().Where(x=>type.GetInterfaces().SelectMany(y=>y.GetProperties().Select(s=>s.Name)).Any(y => y == x.Name))).FirstOrDefault(x=>x.Name == Decode("QWN0b3JOYW1lcw==") /*"ActorNames"*/ );
                            Assert.IsNotNull(property, "property: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Models.MoviesReportItem.String ActorNames does not exists");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X0FjdG9yTmFtZXM=") /*"get_ActorNames"*/ );                                Assert.IsNotNull(method, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Models.MoviesReportItem.get_ActorNames() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Models.MoviesReportItem.get_ActorNames() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.String",methodReturnType.FullName, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Models.MoviesReportItem.get_ActorNames() return type has changed");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X0FjdG9yTmFtZXM=") /*"get_ActorNames"*/ );                                Assert.IsNotNull(method, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Models.MoviesReportItem.get_ActorNames() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Models.MoviesReportItem.get_ActorNames() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.String",methodReturnType.FullName, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Models.MoviesReportItem.get_ActorNames() return type has changed");
                            propertyReturnType = property.PropertyType;
                            Assert.AreEqual("System.String",propertyReturnType.FullName, "property: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Models.MoviesReportItem.String ActorNames  type has changed");
                            property = type.GetProperties().Union(type.GetProperties().Where(x=>type.GetInterfaces().SelectMany(y=>y.GetProperties().Select(s=>s.Name)).Any(y => y == x.Name))).FirstOrDefault(x=>x.Name == Decode("Q2F0ZWdvcnlOYW1l") /*"CategoryName"*/ );
                            Assert.IsNotNull(property, "property: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Models.MoviesReportItem.String CategoryName does not exists");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X0NhdGVnb3J5TmFtZQ==") /*"get_CategoryName"*/ );                                Assert.IsNotNull(method, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Models.MoviesReportItem.get_CategoryName() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Models.MoviesReportItem.get_CategoryName() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.String",methodReturnType.FullName, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Models.MoviesReportItem.get_CategoryName() return type has changed");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X0NhdGVnb3J5TmFtZQ==") /*"get_CategoryName"*/ );                                Assert.IsNotNull(method, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Models.MoviesReportItem.get_CategoryName() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Models.MoviesReportItem.get_CategoryName() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.String",methodReturnType.FullName, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Models.MoviesReportItem.get_CategoryName() return type has changed");
                            propertyReturnType = property.PropertyType;
                            Assert.AreEqual("System.String",propertyReturnType.FullName, "property: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Models.MoviesReportItem.String CategoryName  type has changed");
                            property = type.GetProperties().Union(type.GetProperties().Where(x=>type.GetInterfaces().SelectMany(y=>y.GetProperties().Select(s=>s.Name)).Any(y => y == x.Name))).FirstOrDefault(x=>x.Name == Decode("TnVtYmVyT2ZBY3RvcnM=") /*"NumberOfActors"*/ );
                            Assert.IsNotNull(property, "property: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Models.MoviesReportItem.Int32 NumberOfActors does not exists");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X051bWJlck9mQWN0b3Jz") /*"get_NumberOfActors"*/ );                                Assert.IsNotNull(method, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Models.MoviesReportItem.get_NumberOfActors() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Models.MoviesReportItem.get_NumberOfActors() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.Int32",methodReturnType.FullName, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Models.MoviesReportItem.get_NumberOfActors() return type has changed");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X051bWJlck9mQWN0b3Jz") /*"get_NumberOfActors"*/ );                                Assert.IsNotNull(method, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Models.MoviesReportItem.get_NumberOfActors() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Models.MoviesReportItem.get_NumberOfActors() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.Int32",methodReturnType.FullName, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Models.MoviesReportItem.get_NumberOfActors() return type has changed");
                            propertyReturnType = property.PropertyType;
                            Assert.AreEqual("System.Int32",propertyReturnType.FullName, "property: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Models.MoviesReportItem.Int32 NumberOfActors  type has changed");
                            property = type.GetProperties().Union(type.GetProperties().Where(x=>type.GetInterfaces().SelectMany(y=>y.GetProperties().Select(s=>s.Name)).Any(y => y == x.Name))).FirstOrDefault(x=>x.Name == Decode("VGl0bGU=") /*"Title"*/ );
                            Assert.IsNotNull(property, "property: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Models.MoviesReportItem.String Title does not exists");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X1RpdGxl") /*"get_Title"*/ );                                Assert.IsNotNull(method, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Models.MoviesReportItem.get_Title() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Models.MoviesReportItem.get_Title() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.String",methodReturnType.FullName, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Models.MoviesReportItem.get_Title() return type has changed");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X1RpdGxl") /*"get_Title"*/ );                                Assert.IsNotNull(method, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Models.MoviesReportItem.get_Title() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Models.MoviesReportItem.get_Title() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.String",methodReturnType.FullName, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Models.MoviesReportItem.get_Title() return type has changed");
                            propertyReturnType = property.PropertyType;
                            Assert.AreEqual("System.String",propertyReturnType.FullName, "property: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Models.MoviesReportItem.String Title  type has changed");
                            property = type.GetProperties().Union(type.GetProperties().Where(x=>type.GetInterfaces().SelectMany(y=>y.GetProperties().Select(s=>s.Name)).Any(y => y == x.Name))).FirstOrDefault(x=>x.Name == Decode("WWVhck9mUHJvZHVjdGlvbg==") /*"YearOfProduction"*/ );
                            Assert.IsNotNull(property, "property: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Models.MoviesReportItem.Int32 YearOfProduction does not exists");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X1llYXJPZlByb2R1Y3Rpb24=") /*"get_YearOfProduction"*/ );                                Assert.IsNotNull(method, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Models.MoviesReportItem.get_YearOfProduction() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Models.MoviesReportItem.get_YearOfProduction() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.Int32",methodReturnType.FullName, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Models.MoviesReportItem.get_YearOfProduction() return type has changed");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X1llYXJPZlByb2R1Y3Rpb24=") /*"get_YearOfProduction"*/ );                                Assert.IsNotNull(method, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Models.MoviesReportItem.get_YearOfProduction() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Models.MoviesReportItem.get_YearOfProduction() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.Int32",methodReturnType.FullName, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Models.MoviesReportItem.get_YearOfProduction() return type has changed");
                            propertyReturnType = property.PropertyType;
                            Assert.AreEqual("System.Int32",propertyReturnType.FullName, "property: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Models.MoviesReportItem.Int32 YearOfProduction  type has changed");

                type = assembly.GetTypes().FirstOrDefault(x=>x.Name == Decode("RGF0YVNldEhlbHBlcg==") /*"DataSetHelper"*/ );
                Assert.IsNotNull(type, "Missing assembly: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Helpers.DataSetHelper");
                    Assert.IsTrue(type.IsClass, "assembly: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Helpers.DataSetHelper is not class");
                    Assert.IsTrue(type.IsAbstract, "assembly: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Helpers.DataSetHelper is not abstract class");
                    Assert.IsTrue(type.IsPublic, "assembly: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Helpers.DataSetHelper is not public class");
                    Assert.IsTrue(type.IsSealed, "assembly: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Helpers.DataSetHelper is not sealed type");
                            method = type.GetMethods().Where(m => !m.IsSpecialName).FirstOrDefault(x=>x.Name == Decode("Q3JlYXRlRmxhdFhNTERhdGFTZXRBZnRlckluc2VydA==") /*"CreateFlatXMLDataSetAfterInsert"*/ );                            Assert.IsNotNull(method, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Helpers.DataSetHelper.CreateFlatXMLDataSetAfterInsert() does not exists");
                            Assert.IsTrue(method.IsPublic, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Helpers.DataSetHelper.CreateFlatXMLDataSetAfterInsert() is not public");
                            Assert.IsTrue(method.IsStatic, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Helpers.DataSetHelper.CreateFlatXMLDataSetAfterInsert() is not static");
                            methodReturnType = method.ReturnType;
                            Assert.AreEqual("System.Data.DataSet",methodReturnType.FullName, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Helpers.DataSetHelper.CreateFlatXMLDataSetAfterInsert() return type has changed");
                            method = type.GetMethods().Where(m => !m.IsSpecialName).FirstOrDefault(x=>x.Name == Decode("Q3JlYXRlRmxhdFhNTERhdGFTZXRBZnRlclVwZGF0ZQ==") /*"CreateFlatXMLDataSetAfterUpdate"*/ );                            Assert.IsNotNull(method, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Helpers.DataSetHelper.CreateFlatXMLDataSetAfterUpdate() does not exists");
                            Assert.IsTrue(method.IsPublic, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Helpers.DataSetHelper.CreateFlatXMLDataSetAfterUpdate() is not public");
                            Assert.IsTrue(method.IsStatic, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Helpers.DataSetHelper.CreateFlatXMLDataSetAfterUpdate() is not static");
                            methodReturnType = method.ReturnType;
                            Assert.AreEqual("System.Data.DataSet",methodReturnType.FullName, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Helpers.DataSetHelper.CreateFlatXMLDataSetAfterUpdate() return type has changed");
                            method = type.GetMethods().Where(m => !m.IsSpecialName).FirstOrDefault(x=>x.Name == Decode("Q3JlYXRlRmxhdFhNTERhdGFTZXR0RGVmYXVsdA==") /*"CreateFlatXMLDataSettDefault"*/ );                            Assert.IsNotNull(method, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Helpers.DataSetHelper.CreateFlatXMLDataSettDefault() does not exists");
                            Assert.IsTrue(method.IsPublic, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Helpers.DataSetHelper.CreateFlatXMLDataSettDefault() is not public");
                            Assert.IsTrue(method.IsStatic, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Helpers.DataSetHelper.CreateFlatXMLDataSettDefault() is not static");
                            methodReturnType = method.ReturnType;
                            Assert.AreEqual("System.Data.DataSet",methodReturnType.FullName, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Helpers.DataSetHelper.CreateFlatXMLDataSettDefault() return type has changed");

                type = assembly.GetTypes().FirstOrDefault(x=>x.Name == Decode("RGJIZWxwZXI=") /*"DbHelper"*/ );
                Assert.IsNotNull(type, "Missing assembly: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Helpers.DbHelper");
                    Assert.IsTrue(type.IsClass, "assembly: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Helpers.DbHelper is not class");
                    Assert.IsTrue(type.IsAbstract, "assembly: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Helpers.DbHelper is not abstract class");
                    Assert.IsTrue(type.IsPublic, "assembly: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Helpers.DbHelper is not public class");
                    Assert.IsTrue(type.IsSealed, "assembly: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Helpers.DbHelper is not sealed type");
                            method = type.GetMethods().Where(m => !m.IsSpecialName).FirstOrDefault(x=>x.Name == Decode("R2V0Q29ubmVjdGlvbg==") /*"GetConnection"*/ );                            Assert.IsNotNull(method, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Helpers.DbHelper.GetConnection() does not exists");
                            Assert.IsTrue(method.IsPublic, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Helpers.DbHelper.GetConnection() is not public");
                            Assert.IsTrue(method.IsStatic, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Helpers.DbHelper.GetConnection() is not static");
                            methodReturnType = method.ReturnType;
                            Assert.AreEqual("System.Data.SQLite.SQLiteConnection",methodReturnType.FullName, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Helpers.DbHelper.GetConnection() return type has changed");
                            method = type.GetMethods().Where(m => !m.IsSpecialName).FirstOrDefault(x=>x.Name == Decode("RmlsbERhdGE=") /*"FillData"*/ );                            Assert.IsNotNull(method, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Helpers.DbHelper.FillData(SQLiteConnection connectionDataSet dataSet) does not exists");
                            Assert.IsTrue(method.IsPublic, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Helpers.DbHelper.FillData(SQLiteConnection connectionDataSet dataSet) is not public");
                            Assert.IsTrue(method.IsStatic, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Helpers.DbHelper.FillData(SQLiteConnection connectionDataSet dataSet) is not static");
                            methodReturnType = method.ReturnType;
                            Assert.AreEqual("System.Void",methodReturnType.FullName, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Helpers.DbHelper.FillData(SQLiteConnection connectionDataSet dataSet) return type has changed");
                                parametersCount = method.GetParameters().Length;
                                Assert.AreEqual(2,parametersCount, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Helpers.DbHelper.FillData(SQLiteConnection connectionDataSet dataSet) parameters count has changed");
                                parameter = method.GetParameters().FirstOrDefault(x=>x.Name == Decode("Y29ubmVjdGlvbg==") /*"connection"*/  && x.ParameterType.FullName == "System.Data.SQLite.SQLiteConnection");
                                Assert.IsNotNull(parameter, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Helpers.DbHelper.FillData(SQLiteConnection connectionDataSet dataSet) parameter connection does not exists or does not have type System.Data.SQLite.SQLiteConnection");
                                parametersCount = method.GetParameters().Length;
                                Assert.AreEqual(2,parametersCount, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Helpers.DbHelper.FillData(SQLiteConnection connectionDataSet dataSet) parameters count has changed");
                                parameter = method.GetParameters().FirstOrDefault(x=>x.Name == Decode("ZGF0YVNldA==") /*"dataSet"*/  && x.ParameterType.FullName == "System.Data.DataSet");
                                Assert.IsNotNull(parameter, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Helpers.DbHelper.FillData(SQLiteConnection connectionDataSet dataSet) parameter dataSet does not exists or does not have type System.Data.DataSet");
                            method = type.GetMethods().Where(m => !m.IsSpecialName).FirstOrDefault(x=>x.Name == Decode("SW5pdFNjaGVtYQ==") /*"InitSchema"*/ );                            Assert.IsNotNull(method, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Helpers.DbHelper.InitSchema(SQLiteConnection connection) does not exists");
                            Assert.IsTrue(method.IsPublic, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Helpers.DbHelper.InitSchema(SQLiteConnection connection) is not public");
                            Assert.IsTrue(method.IsStatic, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Helpers.DbHelper.InitSchema(SQLiteConnection connection) is not static");
                            methodReturnType = method.ReturnType;
                            Assert.AreEqual("System.Void",methodReturnType.FullName, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Helpers.DbHelper.InitSchema(SQLiteConnection connection) return type has changed");
                                parametersCount = method.GetParameters().Length;
                                Assert.AreEqual(1,parametersCount, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Helpers.DbHelper.InitSchema(SQLiteConnection connection) parameters count has changed");
                                parameter = method.GetParameters().FirstOrDefault(x=>x.Name == Decode("Y29ubmVjdGlvbg==") /*"connection"*/  && x.ParameterType.FullName == "System.Data.SQLite.SQLiteConnection");
                                Assert.IsNotNull(parameter, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Helpers.DbHelper.InitSchema(SQLiteConnection connection) parameter connection does not exists or does not have type System.Data.SQLite.SQLiteConnection");
                            method = type.GetMethods().Where(m => !m.IsSpecialName).FirstOrDefault(x=>x.Name == Decode("UmVhZFJlc291cmNl") /*"ReadResource"*/ );                            Assert.IsNotNull(method, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Helpers.DbHelper.ReadResource(String fileName) does not exists");
                            Assert.IsTrue(method.IsPublic, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Helpers.DbHelper.ReadResource(String fileName) is not public");
                            Assert.IsTrue(method.IsStatic, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Helpers.DbHelper.ReadResource(String fileName) is not static");
                            methodReturnType = method.ReturnType;
                            Assert.AreEqual("System.String",methodReturnType.FullName, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Helpers.DbHelper.ReadResource(String fileName) return type has changed");
                                parametersCount = method.GetParameters().Length;
                                Assert.AreEqual(1,parametersCount, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Helpers.DbHelper.ReadResource(String fileName) parameters count has changed");
                                parameter = method.GetParameters().FirstOrDefault(x=>x.Name == Decode("ZmlsZU5hbWU=") /*"fileName"*/  && x.ParameterType.FullName == "System.String");
                                Assert.IsNotNull(parameter, "method: MovieRepository.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:MoviesRepository.Data.Helpers.DbHelper.ReadResource(String fileName) parameter fileName does not exists or does not have type System.String");


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
