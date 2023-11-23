using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ToDoList.Models;

public class Todo
{
    public int Id { get; set; }

    [DisplayName("Título")]
    [Required(ErrorMessage = "Campo obrigatório")]
    public string? Title { get; set; }

    [DisplayName("Concluído")]
    public bool Done { get; set; }
    
    [DisplayName("Criado em")]
    public DateTime CreatedAt { get; set; } = DateTime.Now;

    [DisplayName("Última atualização")]
    public DateTime LastUpdatedDate { get; set; } = DateTime.Now;

    [DisplayName("Usuário")]
    public string? User { get; set; }
}