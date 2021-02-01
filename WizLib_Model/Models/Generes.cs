using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WizLib_Model.Models
{
    public class Generes
    {
        [Key]
        public int GenereId { get; set; }
        public string GenereName { get; set; }

        public string DisplayOrder { get; set; }
    }
}
