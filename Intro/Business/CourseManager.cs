using Intro.DataAccess.Abstracts;
using Intro.DataAccess.Concretes;
using Intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.Business;

public class CourseManager  //operasyon tutucu sınıflar
{
    /*Course[] courses = new Course[3];  //global scorp
    //contructor --> yapıcı blok
    public CourseManager()
    {

        //courses = {course1,course2,course3};
        courses[0] =  course1;
        courses[1] =  course2;
        courses[2] =  course3;

    }*/


    //dependency injection
    private readonly ICourseDal _courseDal;   //Doğru olan bu

    /*public CourseManager(CourseDal courseDal)
    {
        _courseDal = courseDal;
    }*/

    public CourseManager(ICourseDal courseDal)
    {
        _courseDal = courseDal;
    }

    public List<Course> GetAll() //void döndürmez
    {
        //business rules iş kuralları

        //CourseDal courseDal = new CourseDal();       // Doğru değil

        return _courseDal.GetAll();
        //veri kaynağından çekilir
        //Console.WriteLine("Kurslar listelendi");
    }
}
