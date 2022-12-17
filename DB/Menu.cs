using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DB;

public class Menu
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int MenuID { get; set; }
    public String Nombre { get; set; }
    public int MenuPadreID { get; set; }
    public String Url { get; set; }
    public String Icono { get; set; }
    public int EstadoID { get; set; }
    
    [ForeignKey("EstadoID")] 
    public virtual Estado Estado { get; set; }
}