namespace ClassLibrary
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Table2
    {
        public int Id { get; set; }

        public int? Table1Id { get; set; }

        public DateTime? DataForTable2 { get; set; }

        public virtual Table1 Table1 { get; set; }
    }
}
