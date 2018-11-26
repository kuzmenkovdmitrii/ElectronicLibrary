using System;
using ElLib.DAL.Context;

namespace ElLib.DAL.Repository
{
    public abstract class CommonRepository
    {
        public ApplicationContext DB { get; set; }

        public void Save()
        {
        }

        protected void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (DB != null)
                {
                    //DB.Dispose();
                    DB = null;
                }
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
