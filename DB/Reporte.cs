using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DB;

public class Reporte
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ReporteID { get; set; }
    public String Nombre { get; set; }
    public String Url { get; set; }
    public int  EstadoID { get; set; }
    
    [ForeignKey("EstadoID")] 
    public virtual Estado Estado { get; set; }
}