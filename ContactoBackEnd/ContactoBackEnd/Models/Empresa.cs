namespace ContactoBackEnd.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Empresa")]
    public partial class Empresa
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string NombreEmpresa { get; set; }

        [Required]
        [StringLength(100)]
        public string Direccion_1 { get; set; }

        [StringLength(100)]
        public string Direccion_2 { get; set; }

        public int SectorId { get; set; }

        [Required]
        [StringLength(50)]
        public string Pais { get; set; }

        [Required]
        [StringLength(10)]
        public string Telefono { get; set; }

        [StringLength(10)]
        public string Telefono2 { get; set; }

        public virtual Sector Sector { get; set; }
    }
}
