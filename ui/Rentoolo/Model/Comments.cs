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
    
    public partial class Comments
    {
        public int Id { get; set; }
        public System.Guid UserId { get; set; }
        public string UserName { get; set; }
        public int AdvertId { get; set; }
        public string Comment { get; set; }
        public System.DateTime Date { get; set; }
        public int Likes { get; set; }
        public int DisLikes { get; set; }
        public int Type { get; set; }
    }
}
