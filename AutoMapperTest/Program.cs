using System;
using AutoMapper;
namespace AutoMapperTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
          
           var config = new MapperConfiguration(cfg=>cfg.CreateMap<Person ,Employee >());
            IMapper imap = config.CreateMapper();
            Person p = new Person();
            p.Fname = "Mohd";
            p.Lname = "Imran";
            p.Id = "12345";
            var e = imap.Map<Employee >(p);
            Console.WriteLine("Fname is :"+e.Fname +", Lname is :"+e.Lname +", Id is :"+e.Id );
            Console.ReadLine();
        }
    }
}
