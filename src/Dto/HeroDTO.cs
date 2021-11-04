using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.EfCore.src.Dto
{
    public class HeroDTO
    {
        public string Name { get; set; }
        public string RealName { get; set; }
        public int? GroupId { get; set; }

    }
}
