using System;
using System.Collections.Generic;
using System.Text;

namespace Struct {
    struct Point {
        public double X;
        public double Y;

        public override string ToString() {
            return $"({X},{Y})";
        }
    }
}
