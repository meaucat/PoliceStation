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
    
    public partial class Aplication
    {
        public int id { get; set; }
        public Nullable<int> idUser { get; set; }
        public Nullable<int> idCriminal { get; set; }
        public string alibi { get; set; }
        public Nullable<int> idPoliceman { get; set; }
        public Nullable<bool> status { get; set; }
        public string name { get; set; }
        public Nullable<int> age { get; set; }
        public Nullable<int> height { get; set; }
        public Nullable<int> weight { get; set; }
        public Nullable<int> idGender { get; set; }
        public string description { get; set; }
    
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
        public virtual User User2 { get; set; }
        public virtual Gender Gender { get; set; }
    }
}
