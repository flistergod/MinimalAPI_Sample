namespace F1Emu.Api.Domain.Laps
{
    public class AddLapRequest
    {
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
        public string ElapsedTime { get; set; }



        /// <summary>
        /// The elapsed time only for the current sector in the mm:ss.SSS format.
        /// </summary>
        public string SectorTime { get; set; }
    }
}
