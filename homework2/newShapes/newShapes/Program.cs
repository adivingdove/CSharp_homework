using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace newShapes
{
    abstract class Shapes{
        protected double side;
        public Shapes() { }
        public Shapes(double side)
        {
            this.side = side;
        }

        public abstract double getSquare();
        public abstract bool isLegal();
        public abstract string getSide();

    }

    class rectangle : Shapes
    {
        private double long_side;

        public rectangle(double long_side,double side)
        {
            this.long_side = long_side;
            this.side = side;
        }

        public override double getSquare()
        {
            return long_side * side;
        }

        public override bool isLegal()
        {
            return long_side>0&&side>0;
        }

        public override string getSide()
        {
            return "边长为" + long_side + "和" + side;
        }
    }

    class square : Shapes
    {
        public square(double side)
        {
            this.side = side;
        }

        public override double getSquare()
        {
            return side * side;
        }

        public override bool isLegal()
        {
            return side>0;
        }

        public override string getSide()
        {
            return "边长为" + side;
        }
    }

    class round : Shapes
    {
        public round(double side)
        {
            this.side = side;
        }
        public override double getSquare()
        {
            return Math.PI * side * side;
        }

        public override bool isLegal()
        {
            return side>0;
        }

        public override string getSide()
        {
            return "边长为" + side;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 随机创建 10 个形状对象
            List<Shapes> shapes = new List<Shapes>();
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                // 随机生成形状类型（0: 长方形, 1: 正方形, 2: 圆形）
                int shapeType = random.Next(0, 3);

                switch (shapeType)
                {
                    case 0: // 长方形
                        double width = random.NextDouble() * 10 + 1; // 随机宽度
                        double height = random.NextDouble() * 10 + 1; // 随机高度
                        shapes.Add(new rectangle(width, height));
                        break;

                    case 1: // 正方形
                        double side = random.NextDouble() * 10 + 1; // 随机边长
                        shapes.Add(new square(side));
                        break;

                    case 2: // 圆形
                        double radius = random.NextDouble() * 10 + 1; // 随机半径
                        shapes.Add(new round(radius));
                        break;
                }
            }

            // 计算所有形状的面积之和
            double totalArea = 0;
            foreach (var shape in shapes)
            {
                if (shape.isLegal()) // 只计算合法的形状
                {
                    totalArea += shape.getSquare();
                }
            }

            // 输出结果
            Console.WriteLine($"随机创建的 10 个形状的总面积为: {totalArea:F2}");
        }
    }
}
