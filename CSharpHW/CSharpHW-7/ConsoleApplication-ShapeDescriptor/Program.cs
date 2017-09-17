using System;
using System.Collections.Generic;

namespace ConsoleApplication_ShapeDescriptor
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var p1 = new Point();
           
            var shapeDescriptor = new ShapeDescriptor();
            shapeDescriptor.Print();
            
            var shapeDescriptor1 = new ShapeDescriptor(p1);
            shapeDescriptor1.Print();
            
            var shapeDescriptor2 = new ShapeDescriptor(p1, p1);
            shapeDescriptor2.Print();        
        }
    }
}