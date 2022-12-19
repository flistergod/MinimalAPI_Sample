using F1Emu.Api.Domain.Laps;

namespace F1Emu.Api.Infrastructure.SqlLap
{
    public class LapDataModel
    {
        public Guid Id { get; set; }
        public string DriverName { get; set; }
        public int LapIndex { get; set; }
        public int Sector { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
        public int Milliseconds { get; set; }
        public long ElapsedTime { get; set; }
        public long SectorTime { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool Invalid { get; set; }

        public Lap MapTo()
        {
            return new Lap()
            {
                Id = Id,
                DriverName = DriverName,
                LapIndex = LapIndex,
                Sector = Sector,
                CreatedOn = CreatedOn,
                ElapsedTime = new TimeSpan(this.ElapsedTime),
                SectorTime = new TimeSpan(this.SectorTime),
                Invalid = Invalid
            };
        }
        public LapDataModel MapFrom(Lap lap)
        {
            Id = lap.Id;
            DriverName = lap.DriverName;
            LapIndex = lap.LapIndex;
            Sector = lap.Sector;
            ElapsedTime = lap.ElapsedTime.Ticks;
            CreatedOn = lap.CreatedOn;
            Invalid = lap.Invalid;
            return this;
        }

    }

}
