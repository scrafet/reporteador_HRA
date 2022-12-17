using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DB;

public class PermisoAsignacion
{
    
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int PermisoAsignacionID { get; set; }
    
    public int PermisoID { get; set; }
    public int ReporteID { get; set; }
    public int MenuID { get; set; }
    
    [ForeignKey("PermisoID")]
    public virtual Permiso Permiso { get; set; }
}