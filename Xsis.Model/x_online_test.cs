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
    
    public partial class x_online_test
    {
        public long online_test_id { get; set; }
        public long created_by { get; set; }
        public System.DateTime created_on { get; set; }
        public long modified_by { get; set; }
        public System.DateTime modified_on { get; set; }
        public long deleted_by { get; set; }
        public System.DateTime deleted_on { get; set; }
        public bool is_delete { get; set; }
        public long biodata_id { get; set; }
        public string period_code { get; set; }
        public int period { get; set; }
        public System.DateTime test_date { get; set; }
        public System.DateTime expired_test { get; set; }
        public string user_access { get; set; }
        public string status { get; set; }
    }
}
