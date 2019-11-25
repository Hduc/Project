using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.DataAccess
{
    [Table("Attachment")]
    public class Attachment
    {
        public Guid Id { get; set; }

        public Guid? ProductId { get; set; }

        public Guid? ItemId { get; set; }

        [StringLength(300)] public string FileName { get; set; }

        [StringLength(10)] public string FileExt { get; set; }

        public byte[] FileContent { get; set; }

        public DateTime? CreatedDate { get; set; }

        public Guid? CreatedBy { get; set; }

        public virtual Product Product { get; set; }
    }
}