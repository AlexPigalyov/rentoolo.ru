//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Rentoolo.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Phones
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public string Pwd { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public bool Blocked { get; set; }
        public System.DateTime LastActive { get; set; }
        public double Balance { get; set; }
        public System.DateTime WhenHistoryChecked { get; set; }
        public double BalanceUpdatePerMonth { get; set; }
        public System.DateTime BalanceUpdatePerMonthUpdateDate { get; set; }
        public int IdentificateStatus { get; set; }
        public bool Commision { get; set; }
    }
}
