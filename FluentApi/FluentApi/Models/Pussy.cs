using FluentApi.Enums;

namespace FluentApi.Models;

public record Pussy
{
    public string Owner { get; set; }
    
    public int SemenAmount { get; set; }

    public string Dick { get; set; }
    
    public string Toy { get; set; }
    
    public WetStatus Status { get; set; }
}