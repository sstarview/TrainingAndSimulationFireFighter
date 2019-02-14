using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  class Task
  {

    public Administrator Giver { get; set; }
    public string TaskName { get; set; }
    public string Description { get; set; }
    public string DueDate { get; set; }
    public string AssignedUserGroup { get; set; }
    public string Status { get; set; }
    public string UsersWorkingOnCurrently { get; set; }

    public void AddTask(Administrator administrator)
    {
      if (Giver != administrator)
      {
        return;
      }

      AddTask
    }

    //public Task AddTask(string tName, string tDescription, string tdueDate, string tAssignedUserGroup, string tStatus, string iUsersWorkingOnCurrently)
    //{
    //  if (Giver == null)
    //  {
    //    return;
    //  }
    //  else
    //  {
    //    TaskName = tName;
    //    Description = tDescription;
    //    DueDate = tdueDate;

    //    AssignedUserGroup = tAssignedUserGroup;
    //    Status = tStatus;
    //    UsersWorkingOnCurrently = iUsersWorkingOnCurrently;

    //  }
    }

  }
}
