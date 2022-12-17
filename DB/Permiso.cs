using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DB;

public class Permiso
{
    
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]public int  PermisoID { get; set; }
    public String Nombre { get; set; }
    public int EstadoID { get; set; }
    
    [ForeignKey("EstadoID")] 
    public virtual Estado Estado { get; set; }
}