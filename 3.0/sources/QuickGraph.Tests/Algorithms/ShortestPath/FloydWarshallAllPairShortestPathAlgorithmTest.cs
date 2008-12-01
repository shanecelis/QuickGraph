﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuickGraph.Unit;
using QuickGraph.Algorithms.ShortestPath;
using QuickGraph.Collections;

namespace QuickGraph.Tests.Algorithms.ShortestPath
{
    [TestFixture, CurrentFixture]
    public class BoostFloydWarshallTest
    {
        [Test]
        public void Compute()
        {
            var g = new AdjacencyGraph<char, Edge<char>>();
            var distances = new Dictionary<Edge<char>, double>();

            var vertices = "ABCDE";
            g.AddVertexRange(vertices);
            AddEdge(g, distances, 'A', 'C', 1);
            AddEdge(g, distances, 'B', 'B', 2);
            AddEdge(g, distances, 'B', 'D', 1);
            AddEdge(g, distances, 'B', 'E', 2);
            AddEdge(g, distances, 'C', 'B', 7);
            AddEdge(g, distances, 'C', 'D', 3);
            AddEdge(g, distances, 'D', 'E', 1);
            AddEdge(g, distances, 'E', 'A', 1);
            AddEdge(g, distances, 'E', 'B', 1);

            var fw = new FloydWarshallAllShortestPathAlgorithm<char, Edge<char>>(g, e => distances[e]);

            fw.Compute();
            fw.Dump(Console.Out);
            foreach (var i in vertices)
                foreach (var j in vertices)
                {
                    Console.Write("{0} -> {1}:", i, j);
                    IEnumerable<Edge<char>> path;
                    if (fw.TryGetPath(i, j, out path))
                    {
                        double cost = 0;
                        foreach (var edge in path)
                        {
                            Console.Write("{0}, ", edge.Source);
                            cost += distances[edge];
                        }
                        Console.Write("{0} --- {1}", j, cost);
                    }
                    Console.WriteLine();
                }
            {
                double distance;
                Assert.IsTrue(fw.TryGetDistance('A', 'A', out distance));
                Assert.AreEqual(0, distance);

                Assert.IsTrue(fw.TryGetDistance('A', 'B', out distance));
                Assert.AreEqual(6, distance);

                Assert.IsTrue(fw.TryGetDistance('A', 'C', out distance));
                Assert.AreEqual(1, distance);

                Assert.IsTrue(fw.TryGetDistance('A', 'D', out distance));
                Assert.AreEqual(4, distance);

                Assert.IsTrue(fw.TryGetDistance('A', 'E', out distance));
                Assert.AreEqual(5, distance);
            }
        }

        private static void AddEdge(
            AdjacencyGraph<char, Edge<char>> g,
            Dictionary<Edge<char>, double> distances,
            char source, char target, double weight)
        {
            var ac = new Edge<char>(source, target); distances[ac] = weight; g.AddEdge(ac);
        }
    }

}
