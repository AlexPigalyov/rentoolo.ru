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
    
    public partial class ExchangeProducts
    {
        public long Id { get; set; }
        public long AdvertId { get; set; }
        public string Comment { get; set; }
        public string WantedObject { get; set; }
        public string Header { get; set; }
        public Nullable<long> SelectedRequestId { get; set; }
    }
}
