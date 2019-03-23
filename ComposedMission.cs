using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    /**
    * This class calc the composed mission
    */
    public class ComposedMission : IMission
    {
        public event EventHandler<double> OnCalculate;
        public string Name { get; }
        public string Type { get; }
        private List<Function> Functions;
        /**
         * constructor.
         */
        public ComposedMission(string name)
        {
            Name = name;
            Type = "Composed";
            Functions = new List<Function>();
        }
        /********************
        * Function name:Add
        * The inputs:function
        * The output:Compossed Mission
        * The function operation:add the function to the array.
        ********************/
        public ComposedMission Add(Function f)
        {
            Functions.Add(f);
            return this;
        }
        /********************
        * Function name:Calculate
        * The inputs:double
        * The output:double
        * The function operation:calculate the value.
        ********************/
        public double Calculate(double value)
        {
            //For each function, turn on the value
            foreach (Function f in Functions)
            {
                value = f(value);
            }
            //if the event is not Null
            OnCalculate?.Invoke(this, value);
            return value;
        }
    }
}
