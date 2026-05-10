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
            return $"{MenuHandler.vTab}Bil nr: {Uuid}\n{MenuHandler.vTab}Färg: {Color}\n{MenuHandler.vTab}Vikt: {Whight} Kg\n{MenuHandler.vTab}Längd: {Length} m\n{MenuHandler.vTab}Hjul: {Wheels} st\n{MenuHandler.vTab}Dörrar: {NumberOfDoors} st";
        }

        //public string ToString2()
        //{
        //    return $"{MenuHandler.line30}{MenuHandler.line30}\n{MenuHandler.vTab}Bil nr: {Uuid}\tFärg: {Color}\tVikt: {Whight} Kg\t{MenuHandler.vTab}Längd: {Length} m\n{MenuHandler.vTab}Hjul: {Wheels} st\tDörrar: {NumberOfDoors} st\n";
        //}
    }
}