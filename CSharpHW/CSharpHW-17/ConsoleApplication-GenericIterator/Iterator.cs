namespace ConsoleApplication_GenericIterator
{
    abstract class Iterator<T> //IEnumerator
    {
        public abstract T First();
        
        public abstract T Next();
        
        public abstract bool IsDone();
        
        public abstract T CurrentItem();
    }
}