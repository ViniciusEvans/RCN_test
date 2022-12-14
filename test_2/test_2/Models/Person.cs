using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace test_2.Models
{
    [Table("Pessoas")]
    public class Person
    {
        [Column("Id")]
        [Display(Name = "id")]
        public int Id { get; set; }

        [Column("Name")]
        [Display(Name = "Nome")]
        public string Name { get; set; }

        [Column("Age")]
        [Display(Name = "Idade")]
        public int Age { get; set; }

        [Column("Sons")]
        [Display(Name = "Filhos")]
        public int Sons { get; set; }


        public ICollection<Pet> Pets { get; set; } = new List<Pet>();
        public int QtdPet { get; internal set; }

        public Person()
        {

        }   

        public Person(string name, int age, int sons)
        {
            Name = name;
            Age = age;
            Sons = sons;
        }
  
    }
} 
