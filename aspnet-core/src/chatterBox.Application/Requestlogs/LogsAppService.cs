using Abp.Json;
using chatterBox.DTO;
using chatterBox.EntityFrameworkCore;
using chatterBox.Logs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Identity;

namespace chatterBox.Requestlogs
{
    [Authorize]
    public class LogsAppService : ApplicationService
    {

        private readonly chatterBoxDbContext _dbContext;

        public LogsAppService(chatterBoxDbContext dbContext)
        {
            _dbContext = dbContext;

        }

        public async Task<IEnumerable<RequestLogs>> GetLogs(int timeSpan)
        {
            DateTime endTime = DateTime.Now;
            DateTime startTime = endTime.AddMinutes(-timeSpan);
            
            var result = await _dbContext.logs.Where(log => (log.creationTime >= startTime && log.creationTime <= endTime)).OrderByDescending
                (m => m.creationTime).ToListAsync();
            return result;
        }

}
}
