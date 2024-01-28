using DailyPlanner.Domain.Entity;
using DailyPlanner.Domain.Result;

namespace DailyPlanner.Domain.Interfaces.Validations
{
    public interface IReportValidator : IBaseValidator<Report>
    {
        /// <summary>
        /// Проверка наличия пользователя и отчёта с тем же именем
        /// </summary>
        /// <param name="report"></param>
        /// <param name="user"></param>
        /// <returns></returns>
        BaseResult CreateValidator(Report report, User user);
    }
}
