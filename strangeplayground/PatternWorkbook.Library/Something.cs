using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PatternWorkbook.Library
{
    public sealed class Something : IDisposable
    {
        private readonly Stream stream;

        public void Dispose()
        {
            //GC.SuppressFinalize();
            stream.Dispose();
        }

        //finalizer
        ~Something()
        {
        }
    }
}
