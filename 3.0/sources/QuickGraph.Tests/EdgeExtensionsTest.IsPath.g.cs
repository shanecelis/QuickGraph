// <copyright file="EdgeExtensionsTest.IsPath.g.cs" company="Jonathan de Halleux">Copyright http://quickgraph.codeplex.com/</copyright>
// <auto-generated>
// This file contains automatically generated unit tests.
// Do NOT modify this file manually.
// 
// When Pex is invoked again,
// it might remove or update any previously generated unit tests.
// 
// If the contents of this file becomes outdated, e.g. if it does not
// compile anymore, you may delete this file and invoke Pex again.
// </auto-generated>
using System;
using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace QuickGraph
{
    public partial class EdgeExtensionsTest
    {
        [TestMethod]
        [PexGeneratedBy(typeof(EdgeExtensionsTest))]
        public void IsPath02()
        {
            bool b;
            Edge<int>[] edges = new Edge<int>[0];
            b = this.IsPath<int, Edge<int>>((IEnumerable<Edge<int>>)edges);
            Assert.AreEqual<bool>(true, b);
        }
        [TestMethod]
        [PexGeneratedBy(typeof(EdgeExtensionsTest))]
        [PexRaisedException(typeof(NullReferenceException))]
        public void IsPath03()
        {
            bool b;
            Edge<int>[] edges = new Edge<int>[1];
            b = this.IsPath<int, Edge<int>>((IEnumerable<Edge<int>>)edges);
        }
        [TestMethod]
        [PexGeneratedBy(typeof(EdgeExtensionsTest))]
        public void IsPath04()
        {
            Edge<int> edge;
            bool b;
            edge = EdgeFactory.Create(0, 0);
            Edge<int>[] edges = new Edge<int>[1];
            edges[0] = edge;
            b = this.IsPath<int, Edge<int>>((IEnumerable<Edge<int>>)edges);
            Assert.AreEqual<bool>(true, b);
        }
        [TestMethod]
        [PexGeneratedBy(typeof(EdgeExtensionsTest))]
        public void IsPath06()
        {
            Edge<int> edge;
            bool b;
            edge = EdgeFactory.Create(0, 0);
            Edge<int>[] edges = new Edge<int>[2];
            edges[0] = edge;
            edges[1] = edge;
            b = this.IsPath<int, Edge<int>>((IEnumerable<Edge<int>>)edges);
            Assert.AreEqual<bool>(true, b);
        }
        [TestMethod]
        [PexGeneratedBy(typeof(EdgeExtensionsTest))]
        public void IsPath07()
        {
            Edge<int> edge;
            bool b;
            edge = EdgeFactory.Create(0, int.MinValue);
            Edge<int>[] edges = new Edge<int>[2];
            edges[0] = edge;
            edges[1] = edge;
            b = this.IsPath<int, Edge<int>>((IEnumerable<Edge<int>>)edges);
            Assert.AreEqual<bool>(false, b);
        }
        [TestMethod]
        [PexGeneratedBy(typeof(EdgeExtensionsTest))]
        public void IsPath09()
        {
            Edge<int> edge;
            bool b;
            edge = EdgeFactory.Create(0, 0);
            Edge<int>[] edges = new Edge<int>[3];
            edges[0] = edge;
            edges[1] = edge;
            edges[2] = edge;
            b = this.IsPath<int, Edge<int>>((IEnumerable<Edge<int>>)edges);
            Assert.AreEqual<bool>(true, b);
        }
        [TestMethod]
        [PexGeneratedBy(typeof(EdgeExtensionsTest))]
        [ExpectedException(typeof(ContractException))]
        public void IsPath11()
        {
            if (!PexContract.HasRuntimeContracts(typeof(EdgeExtensions)))
                Assert.Inconclusive
                    ("assembly QuickGraph is not instrumented with runtime contracts");
            bool b;
            Edge<int>[] edges = new Edge<int>[1];
            b = this.IsPath<int, Edge<int>>((IEnumerable<Edge<int>>)edges);
        }
        [TestMethod]
        [PexGeneratedBy(typeof(EdgeExtensionsTest))]
        [ExpectedException(typeof(ContractException))]
        public void IsPath13()
        {
            if (!PexContract.HasRuntimeContracts(typeof(EdgeExtensions)))
                Assert.Inconclusive
                    ("assembly QuickGraph is not instrumented with runtime contracts");
            Edge<int> edge;
            bool b;
            edge = EdgeFactory.Create(0, 0);
            Edge<int>[] edges = new Edge<int>[2];
            edges[0] = edge;
            b = this.IsPath<int, Edge<int>>((IEnumerable<Edge<int>>)edges);
        }
    }
}
