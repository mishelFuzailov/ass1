using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public delegate double Function(double val);
    /**
     * This class is the container of he functions.
     */
    public class FunctionsContainer
    {
        private Dictionary<string, Function> Functions;
        /**
         * constructor.
         */
        public FunctionsContainer()
        {
            Functions = new Dictionary<string, Function>();
        }
        /**
         * this function:
         * set - the correct function in the container
         * get - the correct function from the container.
         */
        public Function this[string name]
        {
            //return the current function
            get
            {
                //if the function is exist
                if (Functions.ContainsKey(name))
                {
                    return Functions[name];
                }
                //if the dictionary not contains the name
                else
                {
                    Functions[name] = val => val;
                    return Functions[name];
                }         
            }
            //check is the name is not null, if its not turn the function to container
            set => Functions[name] = value ?? throw new ArgumentNullException(nameof(value));
        }
        /********************
        * Function name:getAllMissions
        * The inputs:--
        * The output:list of functions
        * The function operation:return list of all functions names
        ********************/
        public List<string> getAllMissions()
        {
            //create a new list
            List<string> missions = new List<string>();
            //for each item in the container, add the key to the list
            foreach(var item in Functions.Keys)
            {
                missions.Add(item);
            }
            return missions;
        }
    }
}
