using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public interface IReportService
    {
        Task<dynamic> GetInventoryReportAsync();
        Task<decimal> CalculateTotalInventoryValueAsync();
        Task<IEnumerable<dynamic>> GetCategoryWiseReportAsync();
    }
}

