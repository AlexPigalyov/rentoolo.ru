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
    
    public partial class ItemLikes
    {
        public long Id { get; set; }
        public int ObjectType { get; set; }
        public long ObjectId { get; set; }
        public System.Guid UserId { get; set; }
        public System.DateTime Date { get; set; }
    }
}
