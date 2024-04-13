//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            this.OrderProduct = new HashSet<OrderProduct>();
        }
    
        public string ArticleNumber { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }
        public decimal Cost { get; set; }
        public Nullable<byte> MaxDiscountAmount { get; set; }
        public string Manufacturer { get; set; }
        public string Supplier { get; set; }
        public Nullable<int> Category { get; set; }
        public Nullable<byte> DiscountAmount { get; set; }
        public int QuantityInStock { get; set; }
        public string Description { get; set; }
        public string Photo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderProduct> OrderProduct { get; set; }
        public virtual ProductCategory ProductCategory { get; set; }
    }
}