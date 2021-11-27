using BAL.Interface;
using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using ViewModel;

namespace BAL.Service
{
    public class Login : ILogin
    {
        public readonly ILoginRepository _ILoginRepository;
        public Login(ILoginRepository ILoginRepository)
        {
            _ILoginRepository = ILoginRepository;
        }
        public VMUserDetails LoginDetails(VMUserDetails obj)
        {
            return _ILoginRepository.LoginDetails(obj);
         
        }
        public VMUserDetails Registration (VMUserDetails obj)
        {
            return _ILoginRepository.Registration(obj);
        }
       
    }
}
