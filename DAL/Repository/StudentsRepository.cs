using DAL.Interface;
using DataModel.DataModel;
using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using ViewModel;


namespace DAL.Repository
{
    public class StudentsRepository : IStudentsRepository
    {
        private readonly ApplicationContext _ApplicationContext;
        private SqlConnection con;

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

        public IEnumerable<VmStudent> GetListbyStory()
        {
            
            
       
            SqlConnection con = new SqlConnection("Server=CHETUIWK1433\\SQL2017;Database=Db_Student;User Id=sa;password=Chetu@123;MultipleActiveResultSets=true");

            SqlCommand cmd = new SqlCommand("Usd_GetList", con)
            {
                CommandType = CommandType.StoredProcedure
                
            };
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            con.Open();
            sd.Fill(dt);
            con.Close();
            List<VmStudent> lst = new List<VmStudent>();
            foreach (DataRow dr in dt.Rows)
            {
                var model = new VmStudent
                {
                    ID =  Convert.ToInt32(dr["Id"]),
                    Batch = Convert.ToInt32(dr["Batch"]),
                    Coures = Convert.ToString(dr["Coures"]),
                    Name = Convert.ToString(dr["Name"]),
                    RollNo = Convert.ToString(dr["RollNo"])
                };
                lst.Add(model);

            }
            return lst;

            //var empRecord = _ApplicationContext.StudentDetails.fr($ "RetrieveEmployeeRecord {id}").ToList(); 
        }
    }
}
