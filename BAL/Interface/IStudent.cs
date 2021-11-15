using System;
using System.Collections.Generic;
using System.Text;
using ViewModel;

namespace BAL.Interface
{
  public  interface IStudent
    {
        public int  Getcal(int no);
        public IEnumerable<VmStudent> Getlist();
        public bool AddStudents(VmStudent obj);
    }
}
