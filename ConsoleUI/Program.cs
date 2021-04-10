using Autofac;
using System;
using DemoLibrary;
using AutoMapper;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //BusinessLogic businessLogic = new BusinessLogic();

            ///  businessLogic.ProcessData();
            ///  

            //IContainer container = ContainerConfig.Configure();

            //using (var scope = container.BeginLifetimeScope())
            //{

            //    IApplication application = scope.Resolve<IApplication>();
            //    application.run();
            //}


            // 
            var config = new MapperConfiguration(cfg =>
            {
                // follows the format <sourceObject , Destination object > 
                cfg.CreateMap<Person, PersonDto>()

                        //  .ForMember( destinationObject => destinatin objec field , act => act.MapFrom(source object  => source object field ));
                        .ForMember(personDto => personDto.Id, act => act.MapFrom(p => p.PersonId));
            });

            // he configeration should be passed 
            var mapper = new Mapper(config);




            Person person = new DemoLibrary.Person()
            {
                PersonId = Guid.NewGuid().ToString(),
                Name = "dinith",
                Adress = "addess",
                Age = 25,
                CreatedDate = DateTime.Now
            };

            // format :  map<destinationObjectType>(source object)
            
            PersonDto dto = mapper.Map<PersonDto>(person);

            Console.ReadLine();
        }


        public void testMethod()
        {
            


        }
    }



}
