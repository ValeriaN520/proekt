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
    
    public partial class doljnost
    {
        public int id { get; set; }
        public string name { get; set; }
        public int id_sotrudnik { get; set; }
    
        public virtual sotrudnik sotrudnik { get; set; }
    }
}
