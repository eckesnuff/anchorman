using Strife.Models;

namespace anchorman_se.Models;

public record Home : Content
{
    public required string Heading { get; init; }
    public required string OrgNo { get; init; }
}