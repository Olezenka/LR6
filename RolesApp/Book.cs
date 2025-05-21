namespace RolesApp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Book
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Avtor { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        public int Page { get; set; }
    }
}
