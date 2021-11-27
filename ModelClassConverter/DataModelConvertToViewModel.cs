using DataModel;
using DataModel.DataModel;
using System;
using System.Collections.Generic;
using System.Text;
using ViewModel;

namespace ModelClassConverter
{
   public class DataModelConvertToViewModel
    {
        public VmStudent StudentToVmStudent(StudentDetails obj)
        {
            VmStudent ob2 = new VmStudent();
            ob2.Name = obj.Name;
            ob2.Batch = obj.Batch;
            ob2.Coures= obj.Coures;
            ob2.ID = obj.ID;
            ob2.RollNo = obj.RollNo;
            return ob2;
        }
  
        public VMUserDetails UserdetailtsVMUserDetails(Userdetails obj)
        {
            VMUserDetails UserData = new VMUserDetails();
            UserData.Email = obj.Email;
            UserData.UserName = obj.UserName;
            UserData.FirstName = obj.FirstName;
            UserData.LastName = obj.LastName;
            UserData.Password = obj.Password;
            UserData.ID = obj.ID;
            UserData.Active = true;
            return UserData;
        }
    }
}
