using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DB;

public class Rol
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int RolID { get; set; }
    public String Nombre { get; set; }
    public int EstadoID { get; set; }
    
    [ForeignKey("EstadoID")] 
    public virtual Estado Estado { get; set; }
}