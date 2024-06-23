using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TodoApis.Models;

public class Todo
{
    public Guid Id { get; set; }

    public required string Title { get; set; }

    public required string Description { get; set; }

    public DateTime EndDateTime {get;set;}
}
