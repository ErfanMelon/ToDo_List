using System;
using System.Windows.Forms;
using TaskScheduler;

namespace ToDo_List.Utility
{
    static class Reminder
    {
        static TaskScheduler.TaskScheduler objScheduler;

        //To hold Task Definition
        static ITaskDefinition objTaskDef;

        //To hold Trigger Information
        static ITimeTrigger objTrigger;

        //To hold Action Information
        static IExecAction objAction;


        public static void CreateTask(string taskname, string author, string description, DateTime dtregistertime, string triggerid, string startboundary, string endboundary, string actionid, string path, string arg)
        {
            try
            {
                objScheduler = new TaskScheduler.TaskScheduler();
                objScheduler.Connect();

                //Setting Task Definition
                SetTaskDefinition(author, description, dtregistertime);
                //Setting Task Trigger Information
                SetTriggerInfo(triggerid, startboundary, endboundary);
                //Setting Task Action Information
                SetActionInfo(actionid, path, arg);

                //Getting the roort folder
                ITaskFolder root = objScheduler.GetFolder("\\");
                //Registering the task, if the task is already exist then it will be updated
                IRegisteredTask regTask = root.RegisterTaskDefinition(taskname, objTaskDef, (int)_TASK_CREATION.TASK_CREATE_OR_UPDATE, null, null, _TASK_LOGON_TYPE.TASK_LOGON_INTERACTIVE_TOKEN, "");

                //To execute the task immediately calling Run()
                //IRunningTask runtask = regTask.Run(null);

                // MessageBox.Show("Task is created successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Setting Task Definition
        private static void SetTaskDefinition(string author, string description, DateTime registerinfodate)
        {
            try
            {
                objTaskDef = objScheduler.NewTask(0);
                //Registration Info for task
                //Name of the task Author
                objTaskDef.RegistrationInfo.Author = author;// "ToDo_Application";
                //Description of the task 
                objTaskDef.RegistrationInfo.Description = description;// "AlarmForEvent";
                //Registration date of the task 
                objTaskDef.RegistrationInfo.Date = registerinfodate.ToString("yyyy-MM-ddTHH:mm:ss");// DateTime.Today.ToString("yyyy-MM-ddTHH:mm:ss"); //Date format 

                //Settings for task
                //Thread Priority
                objTaskDef.Settings.Priority = 7;
                //Enabling the task
                objTaskDef.Settings.Enabled = true;
                //To hide/show the task
                objTaskDef.Settings.Hidden = false;
                //Execution Time Lmit for task
                objTaskDef.Settings.ExecutionTimeLimit = "PT10M"; //10 minutes
                                                                  //Specifying no need of network connection
                objTaskDef.Settings.RunOnlyIfNetworkAvailable = false;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Setting Task Trigger Information
        private static void SetTriggerInfo(string triggerid, string startboundary, string endboundary)
        {
            try
            {
                //Trigger information based on time - TASK_TRIGGER_TIME
                objTrigger = (ITimeTrigger)objTaskDef.Triggers.Create(_TASK_TRIGGER_TYPE2.TASK_TRIGGER_TIME);
                //Trigger ID
                objTrigger.Id = triggerid;
                //Start Time

                objTrigger.StartBoundary = startboundary;// "2014-01-09T10:10:00"; //yyyy-MM-ddTHH:mm:ss
                                                         //End Time

                objTrigger.EndBoundary = endboundary;// "2016-01-01T07:30:00"; //yyyy-MM-ddTHH:mm:ss
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Setting Task Action Information
        private static void SetActionInfo(string actionid, string path, string arg)
        {
            try
            {
                //Action information based on exe- TASK_ACTION_EXEC
                objAction = (IExecAction)objTaskDef.Actions.Create(_TASK_ACTION_TYPE.TASK_ACTION_EXEC);
                //Action ID
                objAction.Id = actionid;
                //Set the path of the exe file to execute, Here mspaint will be opened
                objAction.Path = path;
                objAction.Arguments = arg;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void DeleteTask(string taskname)
        {
            try
            {
                TaskScheduler.TaskScheduler objScheduler = new TaskScheduler.TaskScheduler();
                objScheduler.Connect();

                ITaskFolder containingFolder = objScheduler.GetFolder("\\");
                //Deleting the task
                containingFolder.DeleteTask(taskname, 0);  //Give name of the Task
                //MessageBox.Show("Task deleted...");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

}
