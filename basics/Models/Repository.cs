using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace basics.Models
{
    public class Repository
    {
        private static readonly List<Course> _courses = new();

        static Repository()
        {
            _courses= new List<Course>
            {
                new Course (){
                    Id = 1, 
                    Title="Aspnet-Course", 
                    Description = "An educational course", 
                    Image = "1.jpg",
                    Tags = new string[]{"aspnet","web development"},
                    isActive= true,
                    isHome=true
                    },
                new Course (){
                    Id = 2,
                    Title="Php Course", 
                    Description = "An educational course",
                     Image = "2.jpg",
                    Tags = new string[]{"php","web development"},
                    isActive= true,
                    isHome=true
                    },
                new Course (){
                    Id = 3, 
                    Title="Javascript Course",
                    Description = "An educational course ", Image = "3.jpg",
                    Tags = new string[]{"javascript","web development"},
                    isActive= true,
                    isHome=true
                    },
                new Course (){
                    Id = 4, 
                    Title="Django Course",
                    Description = "An educational course", 
                    Image = "1.jpg",
                    Tags = new string[]{"Django","web development"},
                    isActive= true,
                    isHome=true
                    }
                  
            };
        }
        public static List<Course> Courses
        {
            get
            {
                return _courses;
            }
        }

        public static Course? GetById(int? id)
        {
            return _courses.FirstOrDefault(c => c.Id ==id);
        }
    }
}