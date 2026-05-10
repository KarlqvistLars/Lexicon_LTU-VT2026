using Exercise4.UtilitesClasses;

namespace Exercise4
{
    public class Car : Vehicle
    {
        int numberOfDoors;
        int wheels;

        public Car(string uuid, string color, int whight, int length, int numberOfDoors, int wheels)
            : base(uuid, color, whight, length, "Car")
        {
            this.numberOfDoors = numberOfDoors;
            this.wheels = wheels;
        }

        public int NumberOfDoors
        {
            get => numberOfDoors;
            set => numberOfDoors = value;
        }

        public int Wheels
        {
            get => wheels;
            set => wheels = value;
        }

        public override string ToString()
        {
            return $"{Utilities.vTab}Bil nr: {Uuid}\n{Utilities.vTab}Färg: {Color}\n{Utilities.vTab}Vikt: {Whight} Kg\n{Utilities.vTab}Längd: {Length} m\n{Utilities.vTab}Hjul: {Wheels} st\n{Utilities.vTab}Dörrar: {NumberOfDoors} st";
        }

        //public string ToString2()
        //{
        //    return $"{MenuHandler.line30}{MenuHandler.line30}\n{MenuHandler.vTab}Bil nr: {Uuid}\tFärg: {Color}\tVikt: {Whight} Kg\t{MenuHandler.vTab}Längd: {Length} m\n{MenuHandler.vTab}Hjul: {Wheels} st\tDörrar: {NumberOfDoors} st\n";
        //}
    }
}