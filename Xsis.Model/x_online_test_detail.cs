//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Xsis.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class x_online_test_detail
    {
        public long id { get; set; }
        public long created_by { get; set; }
        public System.DateTime create_on { get; set; }
        public long modified_by { get; set; }
        public System.DateTime modified_on { get; set; }
        public long delete_by { get; set; }
        public System.DateTime delete_on { get; set; }
        public bool is_delete { get; set; }
        public long online_test_id { get; set; }
        public long test_type_id { get; set; }
        public int test_order { get; set; }
    }
}