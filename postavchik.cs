//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _19._12
{
    using System;
    using System.Collections.Generic;
    
    public partial class postavchik
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public postavchik()
        {
            this.kategoria = new HashSet<kategoria>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public string adres { get; set; }
        public string vladelec { get; set; }
        public int id_magazine { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<kategoria> kategoria { get; set; }
        public virtual magazine magazine { get; set; }
    }
}
