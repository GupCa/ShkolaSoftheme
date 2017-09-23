using System;

namespace ConsoleApplication_Dispose
{
    public class ResourceHolderBase : IDisposable
    {
        private bool _disposed = false;

        public ResourceHolderBase()
        {
            Console.WriteLine("Constructor from base.");
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    Console.WriteLine("Dispose managed resources in base.");
                }

                Console.WriteLine("Dispose unmanaged resources in base.");

                _disposed = true;
            }
        }

        ~ResourceHolderBase()
        {
            Dispose(false);
            Console.WriteLine("Destructor.");
        }
    }
}