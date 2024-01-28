using DailyPlanner.Domain.Dto.Report;
using DailyPlanner.Domain.Result;

namespace DailyPlanner.Domain.Interfaces.Services
{
    public interface IReportService
    {
        Task<CollectionResult<ReportDto>> GetReportsAsync(long userId); 

        Task<BaseResult<ReportDto>> GetReportByIdAsync(long id);

        Task<BaseResult<ReportDto>> CreateReportAsync(CreateReportDto dto);

        Task<BaseResult<ReportDto>> DeleteReportAsync(long id);

        Task<BaseResult<ReportDto>> UpdateReportAsync(UpdateReportDto dto);
    }
}
