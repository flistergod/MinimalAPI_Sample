namespace F1Emu.Api.Domain.Laps
{
    /// <summary>
    /// Sector/Lap information.
    /// </summary>
    public class Lap
    {
        /// <summary>
        /// Primary key.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Driver name.
        /// </summary>
        public string DriverName { get; set; }

        /// <summary>
        /// Number of the lap.
        /// </summary>
        public int LapIndex { get; set; }

        /// <summary>
        /// Sector of the lap for the current time.
        /// </summary>
        public int Sector { get; set; }

        /// <summary>
        /// The elapsed time including the current sector in the mm:ss.SSS format.
        /// </summary>
        public TimeSpan ElapsedTime { get; set; }

        /// <summary>
        /// The elapsed time only for the current sector in the mm:ss.SSS format.
        /// </summary>
        public TimeSpan SectorTime { get; set; }

        /// <summary>
        /// Date/time when the lap info is stored.
        /// </summary>
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// If true, the sector/lap time is invalid.
        /// </summary>
        public bool Invalid { get; set; }
    }
}
