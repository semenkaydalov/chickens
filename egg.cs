using System;

namespace program {

    abstract class egg : project.IRun {

        private static int count;

        private string name;
        private int weight;
        private byte[] coordinates;

        public string Name {
            get {
                return name;
            } 
            private set{}
        }

        public int Weight{
            get {
                System.Console.Write("Weight = ");
                return this.weight;
            }
            set {
                if (value < 1)
                    this.weight = 1;
                else if (value > 5)
                    this.weight = 5;
                else
                    this.weight = value;    
            }
        }

        public float speed { get; set; }

        public byte[] Coordinates {
            get {
                return coordinates;
            } 
            private set{}
        }

        public void setValues(string name, int weight, byte[] coordinates) {
            this.name = name;
            this.weight = weight;
            this.coordinates = coordinates;
        }

        public void setValues(string name, int weight) {
            this.name = name;
            this.weight = weight;
        }

        public void setValues(string name) {
            this.name = name;
        }

        public virtual void printValues() {
            System.Console.Write("{0}'s weight: {1}. Coordinates:", this.name, this.weight);
            foreach(byte el in this.coordinates) {
                System.Console.Write(" " + el);
            }
            System.Console.WriteLine(";");
            System.Console.WriteLine("-----------------------");
        }
        
        public egg (string name, int weight, byte[] coordinates){
            System.Console.WriteLine("Object has been created");
            this.setValues(name, weight, coordinates);
        } 

        public egg (string name, int weight){
            System.Console.WriteLine("Object has been created");
            this.setValues(name, weight);
        }

        public egg(string name){
            System.Console.WriteLine("Object has been created");
            this.name = name;
        }

        public void printName() {
            System.Console.WriteLine(this.name);
        }

        public void run() {
            System.Console.WriteLine(this.Name + " is running!");
            this.coordinates[1]++;
        }
 
    }

}