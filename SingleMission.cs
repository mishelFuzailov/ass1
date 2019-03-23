using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    /**
     * This class calc the single mission
     */
    public class SingleMission : IMission
    {
        public event EventHandler<double> OnCalculate;
        public string Name { get; }
        public string Type { get; }
        private readonly Function Function;
        /**
         * constructor.
         */
        public SingleMission(Function function, string name)
        {
            Name = name;
            Function = function;
            Type = "Single";
        }
        /********************
        * Function name:Calculate
        * The inputs:double
        * The output:double
        * The function operation:calculate the value.
        ********************/
        public double Calculate(double value)
        {
            double calc = Function(value);
            //if the event is not null, calculate.
            OnCalculate?.Invoke(this, calc);
            //return the calculated number.
            return calc;
        }
    }
}
