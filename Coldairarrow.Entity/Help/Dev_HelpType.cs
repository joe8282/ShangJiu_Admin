using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coldairarrow.Entity.Help
{
    /// <summary>
    /// Dev_HelpType
    /// </summary>
    [Table("Dev_HelpType")]
    public class Dev_HelpType
    {

        /// <summary>
        /// Id
        /// </summary>
        [Key, Column(Order = 1)]
        public String Id { get; set; }

        /// <summary>
        /// ¿‡–Õ√˚≥∆
        /// </summary>
        public String Name { get; set; }

        /// <summary>
        /// ≈≈–Ú
        /// </summary>
        public Int32? Sort { get; set; }

    }
}