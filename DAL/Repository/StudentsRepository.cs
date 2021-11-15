using DAL.Interface;
using DataModel.DataModel;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ViewModel;


namespace DAL.Repository
{
    public class StudentsRepository : IStudentsRepository
    {
        private readonly ApplicationContext _ApplicationContext;

        public StudentsRepository(ApplicationContext ApplicationContext)
        {
            _ApplicationContext = ApplicationContext;
        }

        public bool AddStudents(VmStudent obj)
        {
            if (obj != null)
            {
                StudentDetails obj2 = new StudentDetails();
                obj2.Batch = obj.Batch;
                obj2.Coures = obj.Coures;
                obj2.Name = obj.Name;
                obj2.RollNo = obj.RollNo;
                _ApplicationContext.StudentDetails.Add(obj2);
                _ApplicationContext.SaveChanges();
                return true;
            }
            else 
            {
                return false;
            }
        }

        public int Getcal(int no)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<VmStudent> Getlist()
        {
            var x=  _ApplicationContext.StudentDetails.ToList();

            List<VmStudent> lst = new List<VmStudent>();
            foreach (var item in x)
            {
                VmStudent obj = new VmStudent();
                obj.ID = item.ID;   
                lst.Add(obj);
            }
            return lst;
        }
    }
}
