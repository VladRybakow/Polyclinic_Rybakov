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
    
    public partial class Doctor
    {
        public Doctor()
        {
            this.Applicationsss = new HashSet<Applicationsss>();
            this.Service = new HashSet<Service>();
        }
    
        public int Id_doctor { get; set; }
        public string FullName { get; set; }
        public string Telephone { get; set; }
        public Nullable<int> Id_doctorType { get; set; }
    
        public virtual ICollection<Applicationsss> Applicationsss { get; set; }
        public virtual DoctorType DoctorType { get; set; }
        public virtual ICollection<Service> Service { get; set; }
    }
}
