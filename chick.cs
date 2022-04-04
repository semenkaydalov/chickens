using System;

namespace program {

    class chick : egg {

        public chick (string name) : base(name) {}

        public chick (string name, int weight, byte[] coordinates) : base(name, weight, coordinates) {}
 
    }

}