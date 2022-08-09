using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace test_2.Models
{
    [Table("Pets")]
    public class Pet
    {
        [Column("Id")]
        public int Id { get; set; }

        [Column("Name")]
        public string Name { get; set; }

        [Column("Adopted")]
        public bool Adopted { get; set; }

        public Person Person { get; set; }

        public Pet()
        {

        }      
        public Pet( string name ,bool adopted, Person person)
        {
            Name = name;
            Adopted = adopted;
            Person = person;    
        }       


    }
}
