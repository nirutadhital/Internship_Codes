namespace GenericsBasics {
    public class Vessel<T> {
        protected T capacity;

        public Vessel(T capacity) {
            this.capacity = capacity;
        }
    }
}