using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ToDo_List.Utility;

namespace ToDo_List.WorkWithDatabase
{
    class content : IRepository
    {
        List<string> dbpaths;// A place to store paths of data
        public content()
        {
            dbpaths = new List<string>() { $"{Application.StartupPath}\\DataBase" };
            dbpaths.Add($"{dbpaths[0]}\\TNames");//1
            dbpaths.Add($"{dbpaths[0]}\\TDetails");//2
            dbpaths.Add($"{dbpaths[0]}\\TState");//3
            dbpaths.Add($"{dbpaths[0]}\\TReminder");//4
            CreateDB();
        }
        public bool AddTask(Task task)
        {
            if (!CreateDB())
                return false;

            /*Data Be Like -> 
             * [TNames] TaskID#TaskName
             * [TDetails] TaskID#TaskDetail
             * [TState] TaskID#TaskState
             * [TReminder] TaskID#TaskReminder
            */
            try
            {
                task.TaskID = int.Parse(File.ReadAllText(dbpaths[0] + "\\id"));//read unused id from db
                File.WriteAllText(dbpaths[0] + "\\id", (task.TaskID + 1).ToString());//change unused id [increase by 1]

                #region InsertName
                File.AppendAllText(dbpaths[1], $"\n{task.TaskID}#{task.TaskName}");
                #endregion

                #region InsertDetail
                if (task.TaskDetail.Length != 0)
                    File.AppendAllText(dbpaths[2], $"\n{task.TaskID}#{task.TaskDetail}");
                #endregion//if not empty

                #region InsertState
                File.AppendAllText(dbpaths[3], $"\n{task.TaskID}#{task.TaskState}");
                #endregion

                #region InsertReminder
                if (task.TaskReminder != DateTime.MinValue)
                {
                    File.AppendAllText(dbpaths[4], $"\n{task.TaskID}#{task.TaskReminder.ToString("dd-MM-yyyy HH:mm:ss")}");
                    Reminder.CreateTask("Task_" + task.TaskID, "TodoList", task.TaskDetail, DateTime.Now, "task" + task.TaskID, task.TaskReminder.ToString("yyyy-MM-ddTHH:mm:ss"), task.TaskReminder.AddDays(2).ToString("yyyy-MM-ddTHH:mm:ss"), "t" + task.TaskID, Application.StartupPath + "\\ToDo_List.exe", $"{task.TaskID} {task.TaskName} {task.TaskReminder.ToString("dd-MM-yyyy HH:mm:ss")}");
                }
                #endregion// if not mindatetime

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ErrorInfo:\n{ex.Message}", "ProgramError", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                Dictionary<int, dynamic> tasknames = new Dictionary<int, dynamic>();
                Dictionary<int, dynamic> taskdetail = new Dictionary<int, dynamic>();
                Dictionary<int, dynamic> taskstate = new Dictionary<int, dynamic>();
                Dictionary<int, dynamic> taskreminder = new Dictionary<int, dynamic>();
                #endregion

                #region ReadNames
                tasknames = Getdata<string>(dbpaths[1]);
                #endregion

                #region ReadDetails
                taskdetail = Getdata<string>(dbpaths[2]);
                #endregion

                #region ReadStates
                taskstate = Getdata<bool>(dbpaths[3]);
                #endregion

                #region ReadReminders
                taskreminder = Getdata<DateTime>(dbpaths[4]);
                #endregion

                foreach (var taskid in tasknames.Keys)
                {
                    Task t = new Task();
                    t.TaskID = taskid;
                    t.TaskName = tasknames[taskid];
                    if (taskdetail.ContainsKey(taskid))
                        t.TaskDetail = taskdetail[taskid];
                    if (taskreminder.ContainsKey(taskid))
                        t.TaskReminder = taskreminder[taskid];
                    t.TaskState = taskstate[taskid];
                    tasks.Add(t);
                }
                return tasks;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ErrorInfo:\n{ex.Message}", "ProgramError", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return tasks;
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
            catch (Exception ex)
            {
                MessageBox.Show($"ErrorInfo:\n{ex.Message}", "ProgramError", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool DeleteReminder(int taskid)
        {
            try
            {
                var datafile = File.ReadAllLines(dbpaths[4]).ToList();
                var selecttask = datafile.Where(n => n.Contains($"{taskid}#")).FirstOrDefault();
                datafile.Remove(selecttask);
                datafile.Sort();
                datafile.RemoveAll(d => d == "");
                File.WriteAllLines(dbpaths[4], datafile);

                Reminder.DeleteTask($"Task_{taskid}");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ErrorInfo:\n{ex.Message}", "ProgramError", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool DeleteTask(int taskid)
        {
            try
            {
                //Delete TaskReminder if exist
                if (FindTaskByID(taskid).TaskReminder != DateTime.MinValue)
                    Reminder.DeleteTask($"Task_{taskid}");

                //delete task from files
                foreach (string path in dbpaths)
                {
                    if (path == dbpaths[0])
                        continue;
                    var readdatafile = File.ReadAllLines(path).ToList();
                    var selecttask = readdatafile.Where(n => n.Contains($"{taskid}#")).FirstOrDefault();
                    if (selecttask != null)
                        readdatafile.Remove(selecttask);
                    readdatafile.Sort();
                    readdatafile.RemoveAll(d => d == "");//remove whitespaces from file
                    File.WriteAllLines(path, readdatafile);
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ErrorInfo:\n{ex.Message}", "ProgramError", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool EditTask(Task task)
        {
            try
            {
                #region EditName
                Edit(dbpaths[1], task.TaskID, task.TaskName);
                #endregion

                #region EditDetail
                Edit(dbpaths[2], task.TaskID, task.TaskDetail);
                #endregion

                EditTaskState(task.TaskID, task.TaskState);

                #region EditReminder
                if (task.TaskReminder == DateTime.MinValue)
                    Edit(dbpaths[4], task.TaskID, "");
                else
                {
                    Edit(dbpaths[4], task.TaskID, task.TaskReminder.ToString("dd-MM-yyyy HH:mm:ss"));
                    Reminder.CreateTask("Task_" + task.TaskID, "TodoList", task.TaskDetail, DateTime.Now, "task" + task.TaskID, task.TaskReminder.ToString("yyyy-MM-ddTHH:mm:ss"), task.TaskReminder.AddDays(2).ToString("yyyy-MM-ddTHH:mm:ss"), "t" + task.TaskID, Application.StartupPath + "\\ToDo_List.exe", $"{task.TaskID} {task.TaskName} {task.TaskReminder.ToString("dd-MM-yyyy HH:mm:ss")}");
                }
                #endregion

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ErrorInfo:\n{ex.Message}", "ProgramError", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool EditTaskState(int taskid, bool changedstate)
        {
            try
            {
                Edit(dbpaths[3], taskid, changedstate.ToString());
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ErrorInfo:\n{ex.Message}", "ProgramError", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public Task FindTaskByID(int taskid)
        {
            Task t = new Task() { TaskID = taskid };

            t.TaskName = Find(dbpaths[1], taskid);

            t.TaskDetail = Find(dbpaths[2], taskid);

            bool.TryParse(Find(dbpaths[3], taskid), out bool b);
            t.TaskState = b;
            DateTime.TryParseExact(Find(dbpaths[4], taskid), "dd-MM-yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out DateTime d);
            t.TaskReminder = d;

            return t;
        }
        public bool RemoveDB()
        {
            try
            {
                if (Directory.Exists(dbpaths[0]))
                {

                    var checkfordeletereminder = new FileInfo(dbpaths[4]);
                    if (checkfordeletereminder.Exists && checkfordeletereminder.Length != 0)
                        foreach (string remind in File.ReadAllLines(dbpaths[4]).ToList())
                        {
                            Reminder.DeleteTask($"Task_{remind.Split('#').ToList()[0]}");
                        }
                    deletefilefolder(dbpaths[0]);
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ErrorInfo:\n{ex.Message}", "ProgramError", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        void deletefilefolder(string dirpath)
        {
            foreach (string file in Directory.GetFiles(dirpath))
            {
                File.Delete(file);
            }
            foreach (string dir in Directory.GetDirectories(dirpath))
            {
                deletefilefolder(dir);
            }
            Directory.Delete(dirpath);
        }
        public void removeempty()
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
            catch (Exception ex)
            {
                MessageBox.Show($"ErrorInfo:\n{ex.Message}", "ProgramError", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Edit(string filepath, int taskid, string value)
        {
            List<string> readdatafile = File.ReadAllLines(filepath).ToList();
            readdatafile.RemoveAll(d => d == "");
            string selecttask = readdatafile.Where(n => n.Contains($"{taskid}#")).FirstOrDefault();
            if (selecttask != null)
                readdatafile.Remove(selecttask);
            if (value != "")
                readdatafile.Add($"{taskid}#{value}");
            readdatafile.Sort();
            readdatafile.RemoveAll(d => d == "");
            File.WriteAllLines(filepath, readdatafile);
        }
        private string Find(string filepath, int taskid)
        {
            string select = File.ReadAllLines(filepath).ToList().Where(n => n.Contains($"{taskid}#")).FirstOrDefault();
            if (select != null)
            {
                return select.Substring(select.IndexOf('#') + 1);
            }
            return null;
        }
        private Dictionary<int, dynamic> Getdata<T>(string path)
        {
            Dictionary<int, dynamic> keyValuePairs = new Dictionary<int, dynamic>();
            List<string> file = File.ReadAllLines(path).ToList();
            file.RemoveAll(n => n == "");

            int key;
            string value;

            //Collect Datetime
            if (typeof(T) == typeof(DateTime))
            {
                foreach (string data in file)
                {
                    key = int.Parse(data.Split('#')[0]);
                    value = data.Substring(data.IndexOf('#') + 1);
                    keyValuePairs.Add(key, DateTime.ParseExact(value, "dd-MM-yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture));
                }
                return keyValuePairs;
            }
            //Collect Another data
            foreach (string data in file)
            {
                key = int.Parse(data.Split('#')[0]);
                value = data.Substring(data.IndexOf('#') + 1);
                keyValuePairs.Add(key, Convert.ChangeType(value, typeof(T)));
            }
            return keyValuePairs;
        }
    }
}
