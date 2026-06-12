using System;
using System.ComponentModel.DataAnnotations;
// Este modelo define como lucirá en C# una fila o entrada en la base de datos

namespace AspNetCoreTodo.Models
{
    public class TodoItem
    {
        //La propiedad Id es un GUID o un Identificador Global Único. Los
        //Guid son cadenas largas de letras
        public Guid Id { get; set; }
        
        /*La propiedad IsDone es un booleano ( valores true/false ), De forma
predeterminada, sera falso para todos los nuevos elementos. */
        public bool IsDone { get; set; }

        [Required]

        public string Title { get; set; }

        public DateTimeOffset? DueAt { get; set; }
    }
}
