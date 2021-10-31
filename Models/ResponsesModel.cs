using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace Flamingo.Models
{
    [Table("tbl_responses")]
    public class ResponsesModel
    {
        [Key]
        [Column("resp_id")]
        public Guid Id { get; set; }
        
        public string Name { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Subject { get; set; }
        [Column("msg")]
        public string Message { get; set; }
    }
    public class ResponseContext: FlemingoModel
    {
        public DbSet<ResponsesModel> Responses { get; set; }

    }
}