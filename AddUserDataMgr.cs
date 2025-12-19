using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS314App_mseibers
{
   public class AddUserDataMgr : DataMgr
    {
        public List<AddUserData> UserDataList = new List<AddUserData>();

        public AddUserDataMgr(string fileName) : base(fileName) 
        {
            UserDataList = readFromJson<AddUserData>();
        }

        public void UserData(AddUserData userData)
        {
            UserDataList.Add(userData);
            writeToJson(UserDataList);
        }
    }
}
