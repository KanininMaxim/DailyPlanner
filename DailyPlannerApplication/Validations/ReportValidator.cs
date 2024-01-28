using DailyPlanner.Domain.Entity;
using DailyPlanner.Domain.Enum;
using DailyPlanner.Domain.Interfaces.Validations;
using DailyPlanner.Domain.Result;
using DailyPlanner.Application.Resources;

namespace DailyPlanner.Application.Validations
{
    public class ReportValidator : IReportValidator
    {
        public BaseResult ValidateOnNull(Report model)
        {
            if (model == null)
            {
                return new BaseResult()
                {
                    ErrorMessage = ErrorMessage.ReportNotFound,
                    ErrorCode = (int)ErrorCodes.ReportNotFound
                };
            }
            return new BaseResult();
        }

        public BaseResult CreateValidator(Report report, User user)
        {
            if (user == null)
            {
                return new BaseResult()
                {
                    ErrorMessage = ErrorMessage.UserNotFound,
                    ErrorCode = (int)ErrorCodes.UserNotFound
                };
            }

            if (report != null)
            {
                return new BaseResult()
                {
                    ErrorMessage = ErrorMessage.ReportAlreadyExists,
                    ErrorCode = (int)ErrorCodes.ReportAlreadyExists
                };
            }
            return new BaseResult();
        }
    }
}
