using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ToDo_List.WorkWithDatabase
{
    interface IRepository
    {
        bool CreateDB();
        bool RemoveDB();
        bool AddTask(Task task);
        bool EditTask(Task task);
        bool EditTaskState(int taskid, bool changedstate);
        bool DeleteTask(int taskid);
        List<Task> All_Tasks();
        Task FindTaskByID(int taskid);
        bool DeleteReminder(int taskid);
    }
    struct Task
    {
        public int TaskID { get; set; }
        public string TaskName { get; set; }
        public string TaskDetail { get; set; }
        public bool TaskState { get; set; }
        public DateTime TaskReminder { get; set; }
    }
}
