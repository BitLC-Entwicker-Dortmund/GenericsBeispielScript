using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsBeispielScript {
    internal class GenerischeKlasse<T> {
        private T[] elements = new T[2];

        public void Add(T t) {
            elements[0] = t;
        }

        public T Show() {
            return elements[0];
        }
    }

}
