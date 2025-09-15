using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMIMANAGEMENT
{
    internal class BmiManagement
    {
        public List<Person> personList = new List<Person>();

        public List<Person> Enquire(string status)
        {
            List<Person> matchedPersonList = new List<Person>();
            string localStatus="";
            foreach (Person person in personList) {
                double BMI = 703 * (person.Weight / (person.Height * person.Height));
                if (BMI >= 25)
                {
                    localStatus = "Overweight";
                }else if (BMI <= 18.5)
                {
                    localStatus = "Underweight";
                }else if(BMI>18.5 && BMI < 25)
                {
                    localStatus = "Normal";
                }

                if (localStatus == status)
                {
                    matchedPersonList.Add(person);
                }
            }

            return matchedPersonList;
        }
        public double AverageWeight()
        {
            double sumWeight = 0;
            double avgWeight = 1;
            foreach (Person person in personList) {
                sumWeight += person.Weight;
            }
            avgWeight = sumWeight * 0.45;
            return avgWeight;
        }
    }
}
