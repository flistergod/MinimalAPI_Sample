namespace F1Emu.Api.Domain.Laps
{
    public interface ILapRepository
    {
        Task<Lap> Add(Lap lap);
        Task Delete(Guid id);
        Task<IEnumerable<Lap>> Get();
        Task<Lap> GetSingle(Guid id);
        Task Update(Guid id, bool isInvalid);
    }
}
