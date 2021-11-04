using CRUD.EfCore.src.Dto;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUD.EfCore.src.Entities
{
    public class Hero
    {
        public Hero(HeroDTO hero)
        {
            Name = hero.Name;
            RealName = hero.RealName;
            CreatedAt = DateTime.Now;
            GroupId = hero.GroupId;
        }

        public Hero() { }

        [Key]
        public int Id { get; set; }

        [MaxLength(80)]
        [MinLength(2)]
        public string Name { get; set; }

        [MaxLength(80)]
        [Required]
        public string RealName { get; set; }
        public DateTime CreatedAt { get; set; }
        public int? GroupId { get; set; }

        [ForeignKey("GroupId")]
        public Group Group { get; set; }

    }
}