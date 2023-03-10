using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XbShopSolution.Data.Abstract
{
    public class Auditable
    {
        public DateTime? CreateDate { get; set; }
        [MaxLength(256)]
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        [MaxLength(256)]
        public string UpdatedBy { get; set; }
        public string SeoDescription { set; get; }
        public string SeoTitle { set; get; }
        public string SeoAlias { set; get; }
        [MaxLength(256)]
        public string SeoKeyword { get; set; }
        [MaxLength(256)]
        public string MetaTitle { get; set; }

    }
}
