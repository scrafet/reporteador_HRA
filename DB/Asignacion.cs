using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DB;

public class Asignacion
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int AsignacionID { get; set; }
    public int RolID { get; set; }
    public int UsuarioID { get; set; }
    public int GrupoID { get; set; }
    public int PermisoAsignacionID { get; set; }
    
    [ForeignKey("RolID")] 
    public virtual Rol Rol { get; set; }
    
    [ForeignKey("GrupoID")] 
    public virtual Grupo Grupo { get; set; } 
    
    [ForeignKey("UsuarioID")] 
    public virtual Usuario Usuario { get; set; } 
}