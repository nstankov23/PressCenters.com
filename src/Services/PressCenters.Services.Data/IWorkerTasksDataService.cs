﻿namespace PressCenters.Services.Data
{
    using System.Threading.Tasks;

    using PressCenters.Data.Models;

    public interface IWorkerTasksDataService
    {
        WorkerTask GetForProcessing();

        Task UpdateAsync(WorkerTask workerTask);

        Task AddAsync(WorkerTask workerTask);
    }
}
