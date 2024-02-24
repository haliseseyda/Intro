using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.Entities;

public class Course  //Nesne ve özellikleri ayrıca tipleri  // Veri tutucu sınıflar
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public double Price { get; set; }
}
