using Exercise4.UtilitesClasses;

namespace Exercise4
{
    public class Boat : Vehicle
    {
        decimal maxWaterDepth;
        decimal maxSpeed;
        decimal deplacement;

        public Boat(string uuid, string color, int whight, int length, decimal maxWaterDepth, decimal maxSpeed, decimal deplacement)
            : base(uuid, color, whight, length, "Boat")
        {
            this.maxWaterDepth = maxWaterDepth;
            this.maxSpeed = maxSpeed;
            this.deplacement = deplacement;
        }

        public decimal MaxWaterDepth
        {
            get => maxWaterDepth;
            set => maxWaterDepth = value;
        }

        public decimal MaxSpeed
        {
            get => maxSpeed;
            set => maxSpeed = value;
        }

        public decimal Deplacement
        {
            get => deplacement;
            set => deplacement = value;
        }

        public override string ToString()
        {
            return $"{MenuHandler.vTab}Båt nr: {Uuid}\n{MenuHandler.vTab}Färg: {Color}\n{MenuHandler.vTab}Vikt: {Whight} Kg\n{MenuHandler.vTab}Längd: {Length} m\n{MenuHandler.vTab}Maxdjup: {MaxWaterDepth} m\n{MenuHandler.vTab}Maxhastighet: {MaxSpeed} kn\n{MenuHandler.vTab}Deplacement: {Deplacement} ton\n";
        }

        //public string ToString2()
        //{
        //    return $"Båt nr: {Uuid}\n{MenuHandler.vTab}Färg: {Color}\n{MenuHandler.vTab}Vikt: {Whight} Kg\n{MenuHandler.vTab}Längd: {Length} m\n{MenuHandler.vTab}Maxdjup: {MaxWaterDepth} m\n{MenuHandler.vTab}Maxhastighet: {MaxSpeed} kn\n{MenuHandler.vTab}Deplacement: {Deplacement} ton\n";
        //}
    }
}