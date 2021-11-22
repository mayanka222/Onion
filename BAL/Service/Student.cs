using BAL.Interface;
using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using ViewModel;

namespace BAL.Service
{
    public class Student : IStudent
    {
        private readonly IStudentsRepository _IStudentsRepository;

        public Student(IStudentsRepository IStudentsRepository)
        {
            _IStudentsRepository = IStudentsRepository;
        }

        public bool AddStudents(VmStudent obj)
        { 
            return _IStudentsRepository.AddStudents(obj);

        }

        public IEnumerable<VmStudent> Getlist()
        {
         return _IStudentsRepository.Getlist();
        }

        public IEnumerable<VmStudent> GetListbyStory()
        {
            return _IStudentsRepository.GetListbyStory();
           
        }

        int IStudent.Getcal(int no)
        {
            return _IStudentsRepository.Getcal(no);    
        }
       
    
    }
}
