using System;
using System.Collections.Generic;
using System.Text;
using ViewModel;

namespace BAL.Interface
{
    public interface ILogin
    {
  
        public VMUserDetails LoginDetails(VMUserDetails obj);
        public VMUserDetails Registration(VMUserDetails obj);

    }
}
