using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Umbraco.Core.Persistence;
using Umbraco.Core.Persistence.DatabaseAnnotations;

namespace Newman.Model
{
    [TableName("Newman_Email")]
    [PrimaryKey("Id", autoIncrement=true)]
    [ExplicitColumns]
    public class Email
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        public string Name {get;set;}

        [Column("subject")]
        public string Subject { get; set; }

        [Column("toAddress")]
        public string ToAddress { get; set; }

        [Column("body")]
        [SpecialDbType(SpecialDbTypes.NTEXT)]
        public string Body { get; set; }

    }
}