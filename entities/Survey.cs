using System;
using System.ComponentModel.DataAnnotations;

namespace EF6CodeFirstApplication.entities
{
    public class Survey
    {
        public int Id { get; set; }

        [StringLength(256)]
        public string Title { get; set; }

        public int CreatorId { get; set; }
        public DateTime CreationTime { get; set; }
        public virtual User Creator { get; set; }

        public int? ModifierId { get; set; }
        public DateTime? ModifiedTime { get; set; }
        public virtual User Modifier { get; set; }
    }
}
