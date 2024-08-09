using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RepositoryPattern.Entity
{
    public class EntityPattern
    {
        [Key]
        [Column("pk_id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome do usuário é obrigatório")]
        [StringLength(50)]
        [Column("ds_name")]
        public string Name { get; set; }

        [Required]
        [Column("dh_inclusao")]
        public DateTime DateOfInclusion { get; set; }

        public EntityPattern() { }

        protected EntityPattern(int id, string name, DateTime dateOfInclusion) 
        {
            Id = id;
            Name = name;
            DateOfInclusion = dateOfInclusion;
        }
    }
}
