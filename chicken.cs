using System;

namespace program {

    class chicken : chick {
         
        private string color { get; set; }

        public string Color {
            get {
                return color;
            }
            private set{}
        }

        public chicken(string name, int weight, string color, byte[] coordinates) : base(name, weight, coordinates) {
            this.color = color;
        }

        public override void printValues() {
            System.Console.WriteLine("{0}`s color is {1}", this.Name, this.Color + ".");
            System.Console.Write("His weight is {0}. Coordinates:", this.Weight);

            foreach(byte el in this.Coordinates) {
                System.Console.Write(" " + el);
            }

            System.Console.WriteLine(";");
            System.Console.WriteLine("-----------------------");
        }

        public void peck() {
            System.Console.WriteLine("Chick has been pecked by " + this.Name);
        }

    }

}