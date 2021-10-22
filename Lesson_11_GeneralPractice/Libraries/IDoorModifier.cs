using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_11_GeneralPractice.Libraries
{
    public interface IDoorModifier
    {
        int ChangeNumDoors(int numDoorsToModifyBy);
        int RemoveDoors(int doorsToRemove);

        int AddDoors(int doorsToAdd);
    }
}
