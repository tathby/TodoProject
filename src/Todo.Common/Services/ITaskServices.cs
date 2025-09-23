using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.Common.Request;

namespace Todo.Common.Services
{
    public interface ITaskServices
    {
        Task CreateTaskAsync(CreateTaskRequest request);
    }

    public class TaskService : ITaskServices
    {
        public async Task CreateTaskAsync(CreateTaskRequest request)
        {
            await Task.CompletedTask;
        }
    }
}
