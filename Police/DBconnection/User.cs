//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Police.DBconnection
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            this.Aplication = new HashSet<Aplication>();
            this.Aplication1 = new HashSet<Aplication>();
            this.Aplication2 = new HashSet<Aplication>();
        }
    
        public int id { get; set; }
        public Nullable<int> idRole { get; set; }
        public Nullable<int> age { get; set; }
        public Nullable<int> height { get; set; }
        public Nullable<int> idGender { get; set; }
        public string description { get; set; }
        public string password { get; set; }
        public string login { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Aplication> Aplication { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Aplication> Aplication1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Aplication> Aplication2 { get; set; }
        public virtual Gender Gender { get; set; }
        public virtual Role Role { get; set; }
    }
}
