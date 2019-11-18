using System;

namespace Planner
{
    public class Building
    {
        public Building(string address){
            _address = address;
        }
        
        //Private Fields
        private string _designer = "James McClarty";
        DateTime _dateConstructed = new DateTime();
        private string _address;
        private string _owner;

        //Public Fields
        public int Stories {get; set;}
        public double Width {get; set;}
        public double Depth {get; set;}
        public double Volume
        {
            get
            {
                return Width * Depth * (3 * Stories);
            }
        }

        //Public Methods
        public void Construct(){
                _dateConstructed = DateTime.Now;
        }

        public void Purchase(string buyer){
            _owner = buyer;
        }

        public void DisplayInfo(){
            Console.WriteLine($"{_address}");
            Console.WriteLine($"_________________________");
            Console.WriteLine($"Constructed by {_designer}");
            Console.WriteLine($"Constructed on {_dateConstructed}");
            Console.WriteLine($"Owned by {_owner}");
            Console.WriteLine($"Cubic meters of space: {Volume}");
        }
    }
}