//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CrudMaquila.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class clientes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public clientes()
        {
            this.produccion_terminada = new HashSet<produccion_terminada>();
        }
        [Display(Name = "id")]
        public int id { get; set; }
        [Display(Name = "nombre del cliente")]
        public string nombre { get; set; }
        [Display(Name = "telefono del cliente")]
        public Nullable<int> telefono { get; set; }
        [Display(Name = "direccion del cliente")]
        public string direccion { get; set; }
        [Display(Name = "e-mail del cliente")]
        public string email { get; set; }
        [Display(Name = "pago")]
        public string estado_pago { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<produccion_terminada> produccion_terminada { get; set; }
    }
}