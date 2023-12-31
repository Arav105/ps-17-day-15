﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ps_17
{
    public class Tri : Shape
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public Tri(double sideA, double sideB, double sideC)
        {
            ShapeType = "Triangle";
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public override double Area
        {
            get
            {
                double sides = (SideA + SideB + SideC) / 2;
                return Math.Sqrt(sides * (sides - SideA) * (sides - SideB) * (sides - SideC));
            }
        }

        public override double Perimeter => SideA + SideB + SideC;


    }
}
