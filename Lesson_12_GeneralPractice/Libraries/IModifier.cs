using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_12_GeneralPractice.Libraries
{
    public interface IModifier
    {
        int AddFeature(int toAdd);
        int RemoveFeature(int toRemove);
    }

    public class Doors : IModifier
    {
        public int AddFeature(int toAdd)
        {
            return toAdd;
        }

        public int RemoveFeature(int toRemove)
        {
            return toRemove * -1;
        }
    }

    public class Seats : IModifier
    {
        public int AddFeature(int toAdd)
        {
            throw new NotImplementedException();
        }

        public int RemoveFeature(int toRemove)
        {
            throw new NotImplementedException();
        }
    }
}
