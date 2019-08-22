﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xsis.Model
{

    [Table("x_rencana_jadwal_detail")]
    public class Rencana_Jadwal_Detail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long rencana_jadwal_detail_id { get; set; }

        public long created_by { get; set; }

        [Column(TypeName = "Date")]
        public DateTime created_on { get; set; }

        public long modified_by { get; set; }

        [Column(TypeName = "Date")]
        public DateTime modified_on { get; set; }

        public long deleted_by { get; set; }

        [Column(TypeName = "Date")]
        public DateTime deleted_on { get; set; }

        public Boolean is_delete { get; set; }

        public long rencana_jadwal_id { get; set; }

        public long biodata_id { get; set; }

    }
}