using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9_Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            var magnitude = double.Parse(Console.ReadLine());
            var inputMeasure = Console.ReadLine().ToLower();
            var outputMeasure = Console.ReadLine().ToLower();

            double inputInMeters = 0;
            double output = 0;

            if (inputMeasure == "m")
            {
                inputInMeters = magnitude;
            }
            if (inputMeasure == "mm")
            {
                inputInMeters = magnitude * 0.001;
            }
            if (inputMeasure == "cm")
            {
                inputInMeters = magnitude * 0.01;
            }
            if (inputMeasure == "mi")
            {
                inputInMeters = magnitude / 0.000621371192;
            }
            if (inputMeasure == "in")
            {
                inputInMeters = magnitude / 39.3700787;
            }
            if (inputMeasure == "km")
            {
                inputInMeters = magnitude * 1000;
            }
            if (inputMeasure == "ft")
            {
                inputInMeters = magnitude / 3.2808399;
            }
            if (inputMeasure == "yd")
            {
                inputInMeters = magnitude / 1.0936133;
            }


            if (outputMeasure == "m")
            {
                output = inputInMeters;
            }
            if (outputMeasure == "mm")
            {
                output = inputInMeters / 0.001;
            }
            if (outputMeasure == "cm")
            {
                output = inputInMeters / 0.01;
            }
            if (outputMeasure == "mi")
            {
                output = inputInMeters * 0.000621371192;
            }
            if (outputMeasure == "in")
            {
                output = inputInMeters * 39.3700787;
            }
            if (outputMeasure == "km")
            {
                output = inputInMeters / 1000;
            }
            if (outputMeasure == "ft")
            {
                output = inputInMeters * 3.2808399;
            }
            if (outputMeasure == "yd")
            {
                output = inputInMeters * 1.0936133;
            }

            Console.WriteLine(output + " " + outputMeasure);
        }
    }
}
