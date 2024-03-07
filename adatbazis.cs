using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;//project->manage->browse-> Microsoft.EntityFrameworkCore,
                                    //Microsoft.EntityFrameworkCore.Sqlite
                                    //OswaldTechnologies.Extensions.Hosting.windowsFormLifetime,
                                    //Microsoft.Extensions.Hosting
                                    //Microsoft.Extensions.DependencyInjection
                                    //7.0 versions preferebyl
using Microsoft.VisualBasic.ApplicationServices;

namespace Pc_parts
{
     public class adatbazis  :  DbContext
     {
         public DbSet<products> orderible_ware { get; set; } //database set
         

     }
    public class products
    {
        public string Type {  get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public Int32 Price { get; set; }
    }
    


}
