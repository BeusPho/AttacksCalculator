namespace AttacksCalculator.Entities;

internal class ChartStep
{
    public string Key { get; set; }

    public double ValueNoMods { get; set; }

    public double ValueLethalHits { get; set; }
    
    public double ValueSustainedHits { get; set; }
    
    public double ValueDevWounds { get; set; }
}
