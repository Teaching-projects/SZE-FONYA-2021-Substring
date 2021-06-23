using System;
using DotNetGraph.Attributes;
using DotNetGraph.Compiler;
using DotNetGraph.Core;
using DotNetGraph.Edge;
using DotNetGraph.Extensions;
using DotNetGraph.Node;
using DotNetGraph.SubGraph;
using System.Drawing;
using System.IO;
using DotNetGraph;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {
        public static string stringInvert(string str)
        {
            char[] chars = str.ToCharArray();
            char[] result = new char[chars.Length];
            for (int i = 0, j = str.Length - 1; i < str.Length; i++, j--)
            {
                result[i] = chars[j];
            }
            return new string(result);
        }
        static void Main(string[] args)
        {
            var badchar = 0;
            var text = "";
            do
            {
                badchar = 0;
                Console.WriteLine("Adjon meg egy szót az {a, b} abc felett: ");
                text = Console.ReadLine();
                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i] == 'a' || text[i] == 'b' )
                    {
                        badchar = badchar;
                    }
                    else
                    {
                        badchar++;
                    }
                }
                //Console.WriteLine(badchar);
            } while (badchar > 0);
            
            var num_of_states = 0;
            var graph = new DotGraph("MyGraph", true);
            for (int i = 0; i < text.Length; i++)
            {
                var myNode = new DotNode("State" + (i+1))
                {
                    Shape = DotNodeShape.Circle,
                    Label = "State" + (i+1),
                    FillColor = Color.White,
                    FontColor = Color.Black,
                    Style = DotNodeStyle.Solid,
                    Width = 0.5f,
                    Height = 0.5f,
                    PenWidth = 1.5f
                };
                graph.Elements.Add(myNode);
                num_of_states++;
            }
            var lastNode = new DotNode("last_State")
            {
                Shape = DotNodeShape.DoubleCircle,
                Label = "State" + (num_of_states+1),
                FillColor = Color.White,
                FontColor = Color.Black,
                Style = DotNodeStyle.Solid,
                Width = 0.5f,
                Height = 0.5f,
                PenWidth = 1.5f
            };
            graph.Elements.Add(lastNode);
            for (int i = 0; i < num_of_states - 1; i++)
            {
                var myEdge = new DotEdge("State" + (i + 1), "State" + (i + 2))
                {
                    ArrowTail = DotEdgeArrowType.Crow,
                    ArrowHead = DotEdgeArrowType.Normal,
                    Color = Color.Black,
                    FontColor = Color.Black,
                    Label = text[i].ToString(),
                    Style = DotEdgeStyle.Solid,
                    PenWidth = 1.5f
                };
                graph.Elements.Add(myEdge);
            }
            
            var lastEdge = new DotEdge("State" + (num_of_states), "last_State")
            {
                ArrowHead = DotEdgeArrowType.Vee,
                ArrowTail = DotEdgeArrowType.Tee, 
                Color = Color.Black,
                FontColor = Color.Black,
                Label = text[text.Length-1].ToString(),
                Style = DotEdgeStyle.Solid,
                PenWidth = 1.5f
            };
            graph.Elements.Add(lastEdge);

            string[] prefixes = new string[text.Length];
            var opposite = "";
            var segedtext = "";
            for (int i = 0; i < text.Length; i++)
            {
                //prefixes[i] = text.Substring(0, i );
                if (text[i] == 'a')
                {
                    opposite = "b";
                }
                else if (text[i] == 'b')
                {
                    opposite = "a";
                }
                else
                {
                    Console.WriteLine("Érvénytelen karakter!");
                }

                segedtext = text.Substring(0, i) + opposite;
                var segedtext_length = 0;
                var back = 0;
                segedtext_length = segedtext.Length;
                Console.WriteLine(segedtext);
                for (int j = 0; j < segedtext.Length; j++)
                {
                    
                    Console.WriteLine(segedtext.Length);
                    if (segedtext.Equals(text.Substring(0, segedtext.Length)))
                    {
                        back = segedtext.Length + 1;
                        //Console.WriteLine(segedtext + "  egyezés  " + text.Substring(0, segedtext.Length));
                    }
                    else
                    {
                        
                        //Console.WriteLine(segedtext + "  nincs egyezés  " + text.Substring(0, segedtext.Length));
                        segedtext = segedtext.Substring(1, segedtext.Length - 1);
                        j--;
                        back = 1;
                    }

                    
                }
                var backEdge = new DotEdge("State" + segedtext_length, "State" + back)
                {
                    ArrowHead = DotEdgeArrowType.Normal,
                    Color = Color.Black,
                    FontColor = Color.Black,
                    Label = opposite,
                    Style = DotEdgeStyle.Solid,
                    PenWidth = 1.5f
                };
                graph.Elements.Add(backEdge);
               
                //var segedtext2 = stringInvert(segedtext);
                //Console.WriteLine(segedtext);
                // Console.WriteLine(prefixes[i]);
            }

            var lastBackEdge = new DotEdge( "last_State", "last_State" )
            {
                ArrowHead = DotEdgeArrowType.Normal,
                Color = Color.Black,
                FontColor = Color.Black,
                Label = "a, b",
                Style = DotEdgeStyle.Solid,
                PenWidth = 1.5f
            };
            graph.Elements.Add(lastBackEdge);
            Console.ReadLine();
            


            /*
            // Create an edge with nodes and attributes
            var myEdge = new DotEdge(myNode1, myNode2)
            {
                ArrowHead = DotEdgeArrowType.Box,
                ArrowTail = DotEdgeArrowType.Diamond,
                Color = Color.Red,
                FontColor = Color.Black,
                Label = "My edge!",
                Style = DotEdgeStyle.Dashed,
                PenWidth = 1.5f,
                Position = new DotPosition(50, 50)
            };

            // Add the edge to the graph
            graph.Elements.Add(myEdge);
            var myEdge2 = new DotEdge(myNode1, myNode3)
            {
                ArrowHead = DotEdgeArrowType.Box,
                ArrowTail = DotEdgeArrowType.Diamond,
                Color = Color.Red,
                FontColor = Color.Black,
                Label = "My edge!",
                Style = DotEdgeStyle.Dashed,
                PenWidth = 1.5f,
                Position = new DotPosition(50, 50)
            };

            // Add the edge to the graph
            graph.Elements.Add(myEdge2);
            */
            var dot = graph.Compile(true);
            // Indented version
            //var dot = graph.Compile(true);

            // Save it to a file
            File.WriteAllText("myFile.dot", dot);
        }
    }
}
