using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson_11_GeneralPractice.Libraries;

namespace Lesson_11_GeneralPractice
{
    public class Vehicle

    {
        private readonly IDoorModifier _doorModifier;
        private readonly ICostModifier _costModifier;

        public delegate void VehicleCalculations(Vehicle vehicle);


        private int _numDoors;
        private bool _electric;
        private double _cost;
        private string _name;
        private string _brand;
        private string _registrationNumber;

        public Vehicle(int d, bool e, double c, string n, string t, IDoorModifier doorModifier, ICostModifier costModifier)
        {
            _numDoors = d;
            _electric = e;
            _cost = c;
            _name = n;
            _brand = t;
            _doorModifier = doorModifier;
            _costModifier = costModifier;
        }
        public int GetNumDoors()
        {
            return _numDoors;
        }

        public void SetNumDoors(int doorsModifier)
        {
            _numDoors += _doorModifier.AddDoors(doorsModifier);

        }

        public double GetCost()
        {
            return _cost;
        }
        public string GetName()
        {
            return _name;
        }

        public string GetBrand()
        {
            return _brand;
        }

        

        public void ShowVehiclePrice(VehicleCalculations newCalc, Vehicle vehicle)
        {
            newCalc(vehicle);
        }

        

        



    }
    public class ChangeDoors : IDoorModifier
    {
        public int AddDoors(int doorsToAdd)
        {
            return doorsToAdd;

        }

        public int RemoveDoors(int doorsToRemove)
        {
            doorsToRemove *= -1;
            return doorsToRemove;
        }

        public int ChangeNumDoors(int numDoorsToModifyBy)
        {
            throw new NotImplementedException();
        }
    }



    public class ModifyVehicleCost : ICostModifier
    {
        public void CostModifier(Vehicle vehicle, double changeToCost)
        {
            throw new NotImplementedException();
        }


    }

    
}
