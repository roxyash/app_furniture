//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OrderFurniture.ModelBD
{
    using System;
    using System.Collections.Generic;
    
    public partial class Furniture
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Furniture()
        {
            this.SpecificationFurniture = new HashSet<SpecificationFurniture>();
        }
    
        public string Article { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }
        public Nullable<int> Count { get; set; }
        public string OwnSupplier { get; set; }
        public byte[] Picture { get; set; }
        public string TypeFurniture { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<double> Weight { get; set; }
    
        public virtual Supplier Supplier { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SpecificationFurniture> SpecificationFurniture { get; set; }
    }
}
