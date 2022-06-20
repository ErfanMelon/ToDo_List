using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDo_List.WorkWithDatabase
{
    class content : IRepository
    {
        List<string> dbpaths;// A place to store paths of data
        public content()
        {
            dbpaths = new List<string>() { $"{Application.StartupPath}\\DataBase" };
            dbpaths.Add($"{dbpaths[0]}\\TNames");
            dbpaths.Add($"{dbpaths[0]}\\TDetails");
            dbpaths.Add($"{dbpaths[0]}\\TState");
            CreateDB();
        }
        public bool AddTask(Task task)
        {
            if (!CreateDB())
                return false;
            List<FileInfo> filesizes = new List<FileInfo>();
            foreach (string path in dbpaths)
            {
                if (path == dbpaths[0])
                    continue;
                filesizes.Add(new FileInfo(path));
            }
            /*Data Be Like -> 
             * [TNames] TaskID#TaskName
             * [TDetails] TaskID#TaskDetail
             * [TState] TaskID#TaskState
            */
            try
            {
                task.TaskID = int.Parse(File.ReadAllText(dbpaths[0] + "\\id"));
                #region InsertName
                if (filesizes[0].Length == 0)
                {
                    File.WriteAllText(filesizes[0].FullName, $"{task.TaskID}#{task.TaskName}");
                }
                else
                {
                    File.AppendAllText(filesizes[0].FullName, $"\n{task.TaskID}#{task.TaskName}");
                }
                #endregion

                #region InsertDetail
                if (task.TaskDetail.Length != 0)
                    if (filesizes[1].Length == 0)
                    {
                        File.WriteAllText(filesizes[1].FullName, $"{task.TaskID}#{task.TaskDetail}");
                    }
                    else
                    {
                        File.AppendAllText(filesizes[1].FullName, $"\n{task.TaskID}#{task.TaskDetail}");
                    }
                #endregion//if not empty

                #region InsertState
                if (filesizes[2].Length == 0)
                {
                    File.WriteAllText(filesizes[2].FullName, $"{task.TaskID}#{task.TaskState}");
                }
                else
                {
                    File.AppendAllText(filesizes[2].FullName, $"\n{task.TaskID}#{task.TaskState}");
                }
                #endregion

                File.WriteAllText(dbpaths[0] + "\\id", (task.TaskID + 1).ToString());
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Task> All_Tasks()
        {
            List<Task> tasks = new List<Task>();
            try
            {

                if (!CreateDB())
                    return tasks;

                #region Containers
                Dictionary<int, string> tasknames = new Dictionary<int, string>();
                Dictionary<int, string> taskdetail = new Dictionary<int, string>();
                Dictionary<int, bool> taskstate = new Dictionary<int, bool>();

                List<string> file;
                int key;
                string value;
                #endregion

                #region ReadNames
                file = File.ReadAllLines(dbpaths[1]).ToList();
                file.RemoveAll(n => n == "");
                foreach (string data in file)
                {
                    key = int.Parse(data.Split('#')[0]);
                    value = data.Substring(data.IndexOf('#') + 1);
                    tasknames.Add(key, value);
                }
                #endregion

                #region ReadDetails
                file = File.ReadAllLines(dbpaths[2]).ToList();
                foreach (string data in file)
                {
                    key = int.Parse(data.Split('#')[0]);
                    value = data.Substring(data.IndexOf('#') + 1);
                    taskdetail.Add(key, value);
                }
                #endregion

                #region ReadStates
                file = File.ReadAllLines(dbpaths[3]).ToList();
                foreach (string data in file)
                {
                    key = int.Parse(data.Split('#')[0]);
                    value = data.Substring(data.IndexOf('#') + 1);
                    taskstate.Add(key, bool.Parse(value));
                }
                #endregion

                foreach (var taskid in tasknames.Keys)
                {
                    Task t = new Task();
                    t.TaskID = taskid;
                    t.TaskName = tasknames[taskid];
                    if (taskdetail.ContainsKey(taskid))
                        t.TaskDetail = taskdetail[taskid];
                    t.TaskState = taskstate[taskid];

                    tasks.Add(t);
                }
                return tasks;
            }
            catch
            {
                removeempty();
                return All_Tasks();
            }
        }

        public bool CreateDB()
        {
            try
            {
                if (Directory.Exists(dbpaths[0]))
                {
                    foreach (string path in dbpaths)
                    {
                        if (dbpaths[0] == path)
                            continue;//skip Directory

                        if (!File.Exists(path))
                        {
                            var file = File.CreateText(path);
                            file.Close();
                        }
                    }

                    if (!File.Exists(dbpaths[0] + "\\id"))
                    {
                        var idnum = File.Create(dbpaths[0] + "\\id");
                        idnum.Close();
                        File.WriteAllText(dbpaths[0] + "\\id", "1");
                    }
                }
                else
                {
                    Directory.CreateDirectory(dbpaths[0]);
                    CreateDB();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteTask(int taskid)
        {
            try
            {
                foreach (string path in dbpaths)
                {
                    if (path == dbpaths[0])
                        continue;
                    var readdatafile = File.ReadAllLines(path).ToList();
                    var selecttask = readdatafile.Where(n => n.Contains($"{taskid}#")).FirstOrDefault();
                    if (selecttask != null)
                        readdatafile.Remove(selecttask);
                    readdatafile.Sort();
                    File.WriteAllLines(path, readdatafile);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool EditTask(Task task)
        {
            try
            {
                #region EditName
                var readdatafile = File.ReadAllLines(dbpaths[1]).ToList();
                var selecttask = readdatafile.Where(n => n.Contains($"{task.TaskID}#")).FirstOrDefault();
                readdatafile.Remove(selecttask);
                readdatafile.Add($"{task.TaskID}#{task.TaskName}");
                readdatafile.Sort();
                File.WriteAllLines(dbpaths[1], readdatafile);
                #endregion

                #region EditDetail
                readdatafile = File.ReadAllLines(dbpaths[2]).ToList();
                selecttask = readdatafile.Where(n => n.Contains($"{task.TaskID}#")).FirstOrDefault();
                if (selecttask != null)
                    readdatafile.Remove(selecttask);
                if (task.TaskDetail.Count() != 0)
                    readdatafile.Add($"{task.TaskID}#{task.TaskDetail}");
                readdatafile.Sort();
                File.WriteAllLines(dbpaths[2], readdatafile);
                #endregion

                EditTaskState(task.TaskID, task.TaskState);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool EditTaskState(int taskid, bool changedstate)
        {
            try
            {
                var datafile = File.ReadAllLines(dbpaths[3]).ToList();
                var selecttask = datafile.Where(n => n.Contains($"{taskid}#")).FirstOrDefault();
                datafile.Remove(selecttask);
                datafile.Add($"{taskid}#{changedstate}");
                datafile.Sort();
                File.WriteAllLines(dbpaths[3], datafile);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Task FindTaskByID(int taskid)
        {
            Task t = new Task() { TaskID = taskid };

            var select = File.ReadAllLines(dbpaths[1]).ToList().Where(n => n.Contains($"{taskid}#")).FirstOrDefault();
            if (select != null)
            {
                t.TaskName = select.Substring(select.IndexOf('#') + 1);
            }
            select = File.ReadAllLines(dbpaths[2]).ToList().Where(n => n.Contains($"{taskid}#")).FirstOrDefault();
            if (select != null)
            {
                t.TaskDetail = select.Substring(select.IndexOf('#') + 1);
            }
            select = File.ReadAllLines(dbpaths[3]).ToList().Where(n => n.Contains($"{taskid}#")).FirstOrDefault();
            if (select != null)
            {
                t.TaskState = bool.Parse(select.Substring(select.IndexOf('#') + 1));
            }

            return t;
        }

        public bool RemoveDB()
        {
            try
            {
                if (Directory.Exists(dbpaths[0]))
                    Directory.Delete(dbpaths[0]);
                return true;
            }
            catch
            {
                return false;
            }
        }
        void removeempty()
        {
            try
            {
                foreach (string path in dbpaths)
                {
                    if (path == dbpaths[0])
                        continue;
                    List<string> datatoclean = File.ReadAllLines(path).ToList();
                    datatoclean.RemoveAll(d => d == "");
                    File.WriteAllLines(path, datatoclean);
                }
            }
            catch
            {

            }
        }
    }
}
