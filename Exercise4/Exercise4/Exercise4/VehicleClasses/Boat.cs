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
            return $"{Utilities.vTab}Båt nr: {Uuid}\n{Utilities.vTab}Färg: {Color}\n{Utilities.vTab}Vikt: {Whight} Kg\n{Utilities.vTab}Längd: {Length} m\n{Utilities.vTab}Maxdjup: {MaxWaterDepth} m\n{Utilities.vTab}Maxhastighet: {MaxSpeed} kn\n{Utilities.vTab}Deplacement: {Deplacement} ton\n";
        }

        string thisType = "Båt";
        public override string ToString2()
        {
            return $"{Utilities.line30}{Utilities.line30}\n{Utilities.vTab}{thisType} nr: {Uuid}\n{Utilities.vTab}Färg: {Color}\tVikt: {Whight} Kg\tLängd: {Length} m\n{Utilities.vTab}Specifikt för {thisType}:\n{Utilities.vTab}Maxdjup: {MaxWaterDepth} m\tMaxhastighet: {MaxSpeed} kn\tDeplacement: {Deplacement} ton";
        }
    }
}