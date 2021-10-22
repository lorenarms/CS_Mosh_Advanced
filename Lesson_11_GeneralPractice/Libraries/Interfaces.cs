using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_11_GeneralPractice.Libraries
{
    

    public interface ICostModifier
    {
        void CostModifier(Vehicle vehicle, double changeToCost);
    }
}
