//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Polyclinic_Rybakov.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Polyclinic
    {
        public Polyclinic()
        {
            this.Department = new HashSet<Department>();
        }
    
        public int Id_polyclinic { get; set; }
        public string Adress { get; set; }
        public string Director { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<Department> Department { get; set; }
    }
}
