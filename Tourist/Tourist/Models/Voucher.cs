//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tourist.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Voucher
    {
        public int Id { get; set; }
        public int Place { get; set; }
    
        public virtual Hotel Hotel { get; set; }
    }
}
