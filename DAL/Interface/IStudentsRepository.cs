using System;
using System.Collections.Generic;
using System.Text;
using ViewModel;

namespace DAL.Interface
{
  public  interface IStudentsRepository
    {

        public int Getcal(int no);
        public IEnumerable<VmStudent> Getlist();
        public bool AddStudents(VmStudent obj);

    }
}
