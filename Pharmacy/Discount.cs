//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pharmacy
{
    using System;
    using System.Collections.Generic;
    
    public partial class Discount
    {
        public int DrugId { get; set; }
        public int Discount1 { get; set; }
    
        public virtual Drugs Drugs { get; set; }
    }
}