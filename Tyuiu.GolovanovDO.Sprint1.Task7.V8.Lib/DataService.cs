﻿using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.GolovanovDO.Sprint1.Task7.V8.Lib
{
    public class DataService : ISprint1Task7V8
    {
        public double Calculate(double x, double y)
        {
            double res = x * Math.Log(x) + (y / (Math.Cos(x) - (x / 3.0)));
            res = Math.Round(res, 3);
            return res;
        }
    }
}
