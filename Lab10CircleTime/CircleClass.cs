using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10CircleTime
{
    class Circle
    {
            #region Fields

            private double radius;

            #endregion

            #region Properties
            public double Radius
            {

                get
                {
                    return radius;
                }
                set
                {
                    radius = value;
                }
            }
            #endregion

            #region Constructors

            public Circle()
            {

            }
            public Circle(double _radius)
            {
                radius = _radius;
            }

            #endregion

            #region Methods

            public double CalculateCircumference(double circumference)
            {
                circumference = Math.Round(Math.PI * (radius * 2),2);
                return circumference;
            }

            public double CalculateArea(double area)
            {
                area = Math.Round(Math.PI * (radius * radius),2);
                return area;
            }

            #endregion
    }
}
