﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xsis.Model
{

    [Table("x_pe_referensi")]
    public class Pe_Referensi
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required(AllowEmptyStrings =false)]
        public long id { get; set; }

        [Required(AllowEmptyStrings = false)]
        public long created_by { get; set; }

        [Column(TypeName = "DateTime")]
        [Required(AllowEmptyStrings = false)]
        public DateTime created_on { get; set; }

        public Nullable<long> modified_by { get; set; }

        [Column(TypeName = "DateTime")]
        public Nullable<DateTime> modified_on { get; set; }

        public Nullable<long> deleted_by { get; set; }

        [Column(TypeName = "DateTime")]
        public Nullable<DateTime> deleted_on { get; set; }

        [Required(AllowEmptyStrings =false)]
        public Boolean is_delete { get; set; }

        [Required(AllowEmptyStrings = false)]
        public long biodata_id { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string name { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string position { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(1000)]
        public string address_phone { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string relation { get; set; }

    }
}