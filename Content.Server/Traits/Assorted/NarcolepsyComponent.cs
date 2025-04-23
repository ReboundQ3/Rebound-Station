using System.Numerics;
using Content.Shared.Dataset;
using Robust.Shared.Prototypes;

namespace Content.Server.Traits.Assorted;

/// <summary>
/// This is used for the narcolepsy trait.
/// </summary>
[RegisterComponent, Access(typeof(NarcolepsySystem))]
public sealed partial class NarcolepsyComponent : Component
{
    /// <summary>
    /// The random time between incidents, (min, max).
    /// </summary>
    [DataField("timeBetweenIncidents", required: true)]
    public Vector2 TimeBetweenIncidents { get; private set; }

    /// <summary>
    /// The duration of incidents, (min, max).
    /// </summary>
    [DataField("durationOfIncident", required: true)]
    public Vector2 DurationOfIncident { get; private set; }

    public float NextIncidentTime;

    /// <summary>
    ///     LateStation copied the sleep dataset from the sleeping component.
    ///     and it is used for the narcolepsy component.
    ///     This is the same dataset as the one used by the sleeping component.
    /// </summary>
    [DataField]
    public ProtoId<LocalizedDatasetPrototype> ForceSaySleepDataset = "ForceSaySleepDataset";
}
