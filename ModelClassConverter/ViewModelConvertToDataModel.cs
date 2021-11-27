using DataModel;
using DataModel.DataModel;
using System.Collections.Generic;
using System.Text;
using ViewModel;

namespace ModelClassConverter
{
  public  class ViewModelConvertToDataModel
    {
        public StudentDetails VmStudenttoStudent(VmStudent obj)
        {
            StudentDetails ob2 = new StudentDetails();
            ob2.Name = obj.Name;
            ob2.Batch = obj.Batch;
            ob2.Coures = obj.Coures;
            ob2.ID = obj.ID;
            ob2.RollNo = obj.RollNo;
            return ob2;
        }

        public Userdetails VmUserdetailstoUserdetailst(VMUserDetails obj)
        {
            Userdetails UserData = new Userdetails();
            UserData.Email = obj.Email;
            UserData.UserName = obj.UserName;
            UserData.FirstName = obj.FirstName;
            UserData.LastName = obj.LastName;
            UserData.Password = obj.Password;
            UserData.Active = true;
            return UserData ;
        }
    }
}
