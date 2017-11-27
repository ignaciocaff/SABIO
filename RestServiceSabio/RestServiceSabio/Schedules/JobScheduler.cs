using Quartz;
using Quartz.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestServiceSabio.Schedules
{
    public class JobScheduler
    {
        public static void Start()

        {
            IScheduler scheduler = StdSchedulerFactory.GetDefaultScheduler().Result;

            scheduler.Start();

            IJobDetail job = JobBuilder.Create<IOJob>().Build();

            ITrigger trigger = TriggerBuilder.Create()

                .WithIdentity("IOJob", "IO")

                .WithCronSchedule("0 5 0 1/1 * ? *")

                .WithPriority(1)

                .Build();

            scheduler.ScheduleJob(job, trigger);
        }
    }
}
