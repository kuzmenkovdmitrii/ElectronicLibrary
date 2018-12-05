using System;

namespace ElLib.DAL.Repository
{
    public abstract class CommonRepository
    {
        public void Save()
        {
        }

        protected void Dispose(bool disposing)
        {
            if (disposing)
            {
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
