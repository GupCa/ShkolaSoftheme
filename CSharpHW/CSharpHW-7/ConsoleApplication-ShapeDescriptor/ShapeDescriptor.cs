using System;

namespace ConsoleApplication_ShapeDescriptor
{
    public class ShapeDescriptor
    {
        public Shapes ShapeType { get; set; }
        
        public ShapeDescriptor()
        {
            ShapeType = Shapes.Nothing;
        }
        
        public ShapeDescriptor(params Point[] p)
        {
            switch (p.Length)
            {
                case 0:
                    ShapeType=Shapes.Nothing;
                    break;
                    
                case 1:
                    ShapeType=Shapes.Point;
                    break;
                    
                case 2:
                    ShapeType=Shapes.Line;
                    break;    
                 
                case 3:
                    ShapeType=Shapes.Triangle;
                    break;
                    
                case 4:
                    ShapeType=Shapes.Parallelogram;
                    break;  
                 
                case 5:
                    ShapeType=Shapes.Pentagon;
                    break;  
                 
                case 6:
                    ShapeType=Shapes.Hexagon;
                    break;    
                        
                default:
                    ShapeType=Shapes.Polygon;
                    break;  
            }
        }

        public void Print()
        {
            Console.WriteLine("{0}", ShapeType);
        }
    }
}