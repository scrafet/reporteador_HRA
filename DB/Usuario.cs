using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DB;

public class Usuario
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int UsuarioID { get; set; }
    public String Nombre { get; set; } 
    public String Password { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool SuperUser { get; set; }
    public int EstadoID { get; set; }
    public int RolID { get; set; }
    public int GrupoID { get; set; }
    
    [ForeignKey("RolID")] 
    public virtual Rol Rol { get; set; }
    
    [ForeignKey("GrupoID")] 
    public virtual Grupo Grupo { get; set; } 
    
    [ForeignKey("EstadoID")] 
    public virtual Estado Estado { get; set; }
    
    
}