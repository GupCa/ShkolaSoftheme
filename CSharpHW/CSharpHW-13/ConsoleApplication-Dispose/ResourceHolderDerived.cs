using System;

namespace ConsoleApplication_Dispose
{
    public class ResourceHolderDerived : ResourceHolderBase
    {
        private bool _disposed = false;

        public ResourceHolderDerived()
        {
            Console.WriteLine("Constructor from derived.");
        }

        public new void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected override void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    Console.WriteLine("Dispose managed resources in derive.");
                }

                Console.WriteLine("Dispose unmanaged resources in derive.");

                _disposed = true;
            }
        }
    }
}