using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DB;

public class Grupo
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int GrupoID { get; set; }
    public String Nombre { get; set; }
    public int EstadoID { get; set; }

    public virtual ICollection<Usuario> Usuarios { get; set; }
}