namespace Drones
{
    public class Drone
    {
        public string Model { get; set; }
        public string Operator { get; set; }
        public double Distance { get; set; }
        public double Height { get; set; }
        public double Speed { get; set; }
        public string Status { get; set; }

        public Drone (string Model, string Operator, double Distance, double Height, double Speed, string Status)
        {
            this.Model = Model;
            this.Operator = Operator;
            this.Distance = Distance;
            this.Height = Height;
            this.Speed = Speed;
            this.Status = Status;
        }
        
    }
}
