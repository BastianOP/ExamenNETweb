//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExamenNET.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pedido
    {
        public int Id { get; set; }
        public Nullable<int> Cliente { get; set; }
        public Nullable<int> Producto { get; set; }
    
        public virtual Clientes Clientes { get; set; }
        public virtual Productos Productos { get; set; }
    }
}
