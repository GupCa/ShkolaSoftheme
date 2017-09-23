namespace ConsoleApplication_GenericIterator
{
    abstract class Aggregate<T> //IEnumerable
    {
        public abstract Iterator<T> CreateIterator();
    }
}