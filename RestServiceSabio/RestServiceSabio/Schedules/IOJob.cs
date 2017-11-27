using Quartz;
using RestServiceSabio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestServiceSabio.Schedules
{
    public class IOJob : IJob
    {
        public Task Execute(IJobExecutionContext context)
        {
            try
            {
                SabioDbContext contextDb = new SabioDbContext();
                contextDb.Usuarios.Where(x => x.Area == 8).ToList().ForEach(y => y.Habili = 0);
                contextDb.SaveChanges();
                return Task.FromResult(0);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message.ToString());
            }
        }
    }
}
