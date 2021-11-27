using DAL.Interface;
using DataModel;
using Entity;
using System;
using System.Collections.Generic;
using System.Text;
using ViewModel;
using System.Linq;
using ModelClassConverter;

namespace DAL.Repository
{
    public class LoginRepository : ILoginRepository
    {
        private readonly ApplicationContext _ApplicationContext;
        private readonly DataModelConvertToViewModel _DataModelConvertToViewModel;
        private readonly ViewModelConvertToDataModel _ViewModelConvertToDataModel;
        public LoginRepository(ApplicationContext ApplicationContext, DataModelConvertToViewModel DataModelConvertToViewModel, ViewModelConvertToDataModel ViewModelConvertToDataModel)
        {
            _DataModelConvertToViewModel = DataModelConvertToViewModel;
            _ViewModelConvertToDataModel = ViewModelConvertToDataModel;
            _ApplicationContext = ApplicationContext;
        }

        public VMUserDetails LoginDetails(VMUserDetails obj)
        {
            Userdetails CheckUser = new Userdetails();
             CheckUser = _ApplicationContext.Userdetails.Where(x => x.UserName == obj.UserName && x.Password == obj.Password).FirstOrDefault();
            if (CheckUser != null)
            {
                obj = null;
                obj = _DataModelConvertToViewModel.UserdetailtsVMUserDetails(CheckUser);
                obj.Status = true;
                obj.message="User Valid";
                return obj;
            }
            else
            {
                obj.message = "Data not Found";
                obj.Status = false;
                return obj;
            }
        }

        public VMUserDetails Registration(VMUserDetails obj)
        {
            Userdetails CheckUser = new Userdetails();
            CheckUser = _ApplicationContext.Userdetails.Where(x => x.Email == obj.Email).FirstOrDefault();
            if (CheckUser != null)
            {
                obj = null;
                obj = _DataModelConvertToViewModel.UserdetailtsVMUserDetails(CheckUser);
                obj.message = "User Already Exist";
                obj.Status = false;
                return obj;
            }
            else
            {
                Userdetails UserData = new Userdetails();
                UserData =_ViewModelConvertToDataModel.VmUserdetailstoUserdetailst(obj);
                UserData.Active = true;
                UserData.Created = DateTime.Now;
                _ApplicationContext.Userdetails.Add(UserData);
                _ApplicationContext.SaveChanges();

                Userdetails DataCheck = new Userdetails();
                DataCheck= _ApplicationContext.Userdetails.Where(x => x.UserName == obj.UserName).FirstOrDefault();

                VMUserDetails obj2 = new VMUserDetails();
                obj2= _DataModelConvertToViewModel.UserdetailtsVMUserDetails(DataCheck);   
                obj2.Active = DataCheck.Active;
                obj.Status = true;
                obj.message = "Data Save";
                return obj2;
            }
         
        }
    }
}
