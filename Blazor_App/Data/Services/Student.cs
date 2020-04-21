using Employee_Model.Models.entityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_App.Data.Services
{
    public class Student
    {
        private readonly DB_VSContext dB_VSContext;
        public Student(DB_VSContext _dB_VSContext)
        {
            dB_VSContext = _dB_VSContext;
        }
        //for Displaying the details of students.
        public List<TblStudent> GetDetails()
        {
            var stdlist = dB_VSContext.TblStudent.ToList();
            return stdlist;
        }

        //For Inserting new Student Details in the database.

        public string Insert(TblStudent student)

        {
            dB_VSContext.TblStudent.Add(student);
            dB_VSContext.SaveChanges();
            return "Done";
        }
        //Displaying the detail of student by a particular ID

        public TblStudent GetDetailsByID(int id)
        {
            TblStudent std = dB_VSContext.TblStudent.FirstOrDefault(s => s.Id == id);
            return std;

        }

        //For Updating the details of an existing student Detail. 
        public string UpdateStudent(TblStudent student)
        {
            dB_VSContext.TblStudent.Update(student);
            dB_VSContext.SaveChanges();
            return "Updated Successfully";
        }

        //for deleting a detail of student
        public string Delete(TblStudent student)
        {
            dB_VSContext.Remove(student);
            dB_VSContext.SaveChanges();
            return "Deleted Successfully";

        }
    }
}
