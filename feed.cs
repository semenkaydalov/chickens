using System;

namespace program {

    struct feed {

        private string name, stim, sat;
        private int stimulant;
        private int satiety;
   
        public void setValues(string name, int stimulant, int satiety) {
            this.name = name;
            this.stimulant = stimulant;
            this.satiety = satiety;

            stim = "low stimulus";
            sat = "low nutritional value";
            
            if (stimulant > 5) {
                stim = "high stimulus";
            }
            if (satiety > 5) {
                sat = "high nutritional value";
            }
        }

        public void printValues() {
            System.Console.WriteLine("You choose feed with {0} and {1}", stim, sat);
        }

    }

}