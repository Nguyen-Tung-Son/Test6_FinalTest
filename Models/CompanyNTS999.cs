using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Test6_FinalTest.Models;

namespace Test6_FinalTest.Models;
[Table("CompanyNTS999")]
public class CompanyNTS999
{
    [Key, StringLength(20), Display(Name = "ID")]
    public string? CompanyId {get; set;}
    [Required, StringLength(50), Display(Name = "Tên")]
    public string? CompanyName {get; set;}
}
 