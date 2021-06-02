using System;
using TqlBootcamp.Models;
using System.Linq;
using System.Collections.Generic;

namespace TqlBootcamp
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var _context = new BootcampContext();


/*
            /*Querys
             * 
             * sqlversion  -long version and difficult
             * var scores = from s in _context.Students
             *              join asc in_context.AssessmentScores
             *              on s.Id equals asc.StudentId
             *              join a in _context.Assessments
             *              on asc.AssessemtId equals a.Id
             *              select new {s, asc, a };
             *          foreach(var s in scores) 
             *          { Console.Writeline($"{Score.s.sLastname} {s.ascActualScore}");
             * 
             * 
              var avgPoints = (from asc in _context.AssessmentScores
                                select new { asc.ActualScore })
                                .Average(asc => asc.ActualScore);
                OR  
                avgPoints = _context.AssessmentScores.Average(asc => asc.ActualScore);
                 console.Writeline($"Average points on assessments is { avgPoints }");
             */

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

            // add assessment scores */          
            var gitScore = new AssessmentScore()
            {
                StudentId = Jeff.Id, AssessmentID = git.ID, ActualScore = 100
            };
            var sqlScore = new AssessmentScore()
            {
                StudentId = Jeff.Id,  AssessmentID = sql.ID, ActualScore= 90,
            };
            _context.AssessmentScores.AddRange(gitScore, sqlScore);
            if(_context.SaveChanges() != 2) { throw new Exception("Insert Assessment score failed!"); }; 
            

         
        }
        

    }


 }


