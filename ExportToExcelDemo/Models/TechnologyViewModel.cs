using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExportToExcelDemo.Models
{
    public class TechnologyViewModel
    {
        public List<Technology> Technologies
        {
            get
            {
                return StaticData.Technologies;
            }
        }
    }
}