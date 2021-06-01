using System;
using TqlBootcamp.Models;

namespace TqlBootcamp
{
    class Program
    {
        public static Student newStudent { get; private set; }

        static void Main(string[] args)
        {
            var _context = new BootcampContext();
            //add the student            
            var Jeff = new Student()
            {
                Firstname = "Jeff",
                Lastname = "North",
                TargetSalary = 85000,
                InBootcamp = true
            };
            _context.Students.Add(Jeff);
            if(_context.SaveChanges() != 1) { throw new Exception("Insert student failed!"); };
            // add the assessments
            var git = new Assessment() { Topic = "Git", NumberOfQuestions = 6, MaxPoints = 120 };
            var sql = new Assessment() { Topic = "SQL", NumberOfQuestions = 12, MaxPoints = 110 };
            var cs = new Assessment() { Topic = "C#", NumberOfQuestions = 12, MaxPoints = 110 };
            var js = new Assessment() { Topic = "JavaScript", NumberOfQuestions = 12, MaxPoints = 110 };
            var ng = new Assessment() { Topic = "Angular", NumberOfQuestions = 12, MaxPoints = 110 };
            _context.Assessments.AddRange(git, sql, cs, js, ng);
            if(_context.SaveChanges() !=5) { throw new Exception("Insert assessments failed!"); };

            // add assessment scores           
            var gitScore = new AssessmentScore()
            {
                StudentId = Jeff.Id, AssessmentID = sql.ID, ActualScore = 100
            };
            var sqlScore = new AssessmentScore()
            {
                StudentId = Jeff.Id,
                ActualScore = 90,
                AssessmentID = sql.ID,
            };
            _context.AssessmentScores.Add(sqlScore);
            if(_context.SaveChanges() != 1) { throw new Exception("Insert Assessment score failed!"); };          
          
        }
        

    }


 }


