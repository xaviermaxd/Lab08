using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace lab08
{
    public interface IQrScanning
    {
        Task<string> ScanAsync();
    }
}
