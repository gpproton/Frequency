using Proton.Frequency.Common.Enums;
using Proton.Frequency.Common.Shared;

namespace Proton.Frequency.Common.Entity;

public sealed class Terminal : GroupedBaseEntity {
    public string? Identifier { get; set; }
    public string? Name { get; set; }
    public bool Active { get; set; }
    public ActivityStatus Status { get; set; }
    public Channel Channel { get; set; } = null!;
    public Guid ChannelId { get; set; }
    public Location? Location { get; set; }
    public Guid? LocationId { get; set; }
    public bool Proxy { get; set; } = true;
    public ICollection<Node>? Nodes { get; set; }
    public ICollection<Log>? Logs { get; set; }
}
