using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DB;

public class AdminLog
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int AdminLogID { get; set; }
    public DateTime Fecha { get; set; }
    public String Detalle { get; set; }
    public int UsuarioID { get; set; }
    public int MenuID { get; set; }
    
    [ForeignKey("UsuarioID")] public virtual Usuario Usuario { get; set; }
    [ForeignKey("MenuID")] public virtual Menu Menu { get; set; }
    
}