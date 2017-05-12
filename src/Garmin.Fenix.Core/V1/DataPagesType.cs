namespace Garmin.Fenix.Core.V1
{
    public enum DataPagesType
    {
        Tracking,
        Navigation,
        Indoor
    }

    public enum DataPageType
    {
        OneField,
        TwoFields,
        ThreeFields,
        Altimeter,
        Barometer,
        Temperature,
        Compass,
        Map,
        HeartRate,
        Cadence,
        AltZones,
        VirtualPartner,
        CurrentRun,
        TotalRuns,
        Workouts,
        DualGrid
    }

    public enum Category
    {
        All,
        Time,
        SpeedAndDist,
        Navigation,
        TripData,
        Elevation,
        Aviation,
        Status,
        Heading,
        Fitness
    }
}
