//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BorAutoWorkers.AppData
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public int position_id { get; set; }
        public int salary { get; set; }
    
        public virtual Positions Positions { get; set; }
    }
}
