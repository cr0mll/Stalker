using System;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace Stalker.Core;

[Serializable]
public class Investigation
{
    
    public string Name { get; set; } = "New Investigation";
    
    public string Description { get; set; } = "New investigation.";
    
    public InvestigationStatus Status { get; set; } = InvestigationStatus.Open;
    
    public readonly DateTime TimeOfCreation = DateTime.Now;
    
    public readonly DateTime? TimeOfClosing = null;
}

public enum InvestigationStatus : byte
{
    Open,
    Closed
}