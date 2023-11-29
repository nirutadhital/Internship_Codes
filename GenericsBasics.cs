namespace GenericsBasics {
    public class Vessel<T> {
        protected T Capacity;

        public Vessel(T capacity) {
            this.Capacity = capacity;
        }
    }
}