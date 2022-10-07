using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDI2.Services
{
    interface IServicesAnimals
    {
        string NameAnimal { set; get; }
        string SpeciesAnimal { set; get; }
        string BasedEat { set; get; }

        void AnimalEat(string SpaciesAnimal);
        void AnimalRun(string NameAnimal);
    }

    public class ServicesAnimals : IServicesAnimals
    {
        public string NameAnimal { set; get; }
        public string SpeciesAnimal { set; get; }
        public string BasedEat { set; get; }

        public ServicesAnimals(string nameAnimal, string speciesAnimal, string basedEat)
        {
            this.NameAnimal = nameAnimal;
            this.SpeciesAnimal = speciesAnimal;
            this.BasedEat = basedEat;
        }

        public void AnimalEat(string SpeciesAnimal)
        {
            Console.WriteLine("THE ANIMALS " + SpeciesAnimal + "FOR EAT");
        }

        public void AnimalEat(string NameAnimal, string BaseEat)
        {
            Console.WriteLine("THE ANIMAL " + NameAnimal + "EAT " + BaseEat);
        }

        public void AnimalRun(string NameAnimal)
        {
            Console.WriteLine("THE ANIMAL " + NameAnimal + "She is known for running a lot");
        }
    }

}
