Earth<string>.Population = "8_000_000_000";
Earth<long>.Population = 8_000_000_000;

// Statik klaslar generic ola bilər.
static class Earth<T>
{
    public static T Population { get; set; }
}