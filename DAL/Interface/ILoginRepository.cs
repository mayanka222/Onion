using System;
using System.Collections.Generic;
using System.Text;
using ViewModel;

namespace DAL.Interface
{
    public interface ILoginRepository
    {
        public VMUserDetails LoginDetails(VMUserDetails obj);
        public VMUserDetails Registration(VMUserDetails obj);
    }
}
