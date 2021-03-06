//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnlineShoppingWebAPIProject.Models
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [DataContract]public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            this.Carts = new HashSet<Cart>();
            this.OrderDetails = new HashSet<OrderDetail>();
            this.Users = new HashSet<User>();
        }

        [DataMember] public int ProductId { get; set; }
        [DataMember] public string ProductName { get; set; }
        [DataMember] public string ProductDescription { get; set; }
        [DataMember] public Nullable<decimal> ProductPrice { get; set; }
        [DataMember] public Nullable<int> ProductStock { get; set; }
        [DataMember] public string ProductImg1 { get; set; }
        [DataMember] public string ProductImg2 { get; set; }
        [DataMember] public string ProductImg3 { get; set; }
        [DataMember] public string ProductImg4 { get; set; }
        [DataMember] public string ProductBrand { get; set; }
        [DataMember] public Nullable<int> CategoryId { get; set; }
        [DataMember] public Nullable<int> RetailerId { get; set; }
        [DataMember] public string ProductStatus { get; set; }
        [DataMember]public string ProductRemark { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [IgnoreDataMember] public virtual ICollection<Cart> Carts { get; set; }
        [IgnoreDataMember]public virtual Category Category { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        [IgnoreDataMember] public virtual User User { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [IgnoreDataMember] public virtual ICollection<User> Users { get; set; }
    }
}
