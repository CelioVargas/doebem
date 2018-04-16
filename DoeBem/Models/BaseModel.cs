using System;
using System.ComponentModel.DataAnnotations;

namespace DoeBem.Models
{
    public class BaseModel
    {
        [Key]
        public Guid Id { get; set; }
    }
}
