using F1Emu.Api.Domain.Laps;
using F1Emu.Api.Domain;

namespace F1Emu.Api.Tests
{

    public class TestLapRespository : ILapRepository
    {
        List<Lap> laps = new();
        public Task<Lap> Add(Lap lap)
        {
            laps.Add(lap);
            return Task.FromResult(lap);
        }

        public Task Delete(Guid id)
        {
            var lap = laps.FirstOrDefault(l => l.Id == id);
            if (lap is null)
            {
                throw new EntityNotFoundException();
            }
            laps.RemoveAll(l => l.Id == id);
            return Task.CompletedTask;
        }

        public async Task<IEnumerable<Lap>> Get()
        {
            return await Task.FromResult(laps);
        }

        public Task<Lap> GetSingle(Guid id)
        {
            var lap = laps.FirstOrDefault(l => l.Id == id);
            if (lap is null)
            {
                throw new EntityNotFoundException();
            }
            return Task.FromResult(lap);
        }

        public Task Update(Guid id, bool isInvalid)
        {
            var lap = laps.FirstOrDefault(l => l.Id == id);
            if (lap is null)
            {
                throw new EntityNotFoundException();
            }
            lap.Invalid = isInvalid;
            return Task.CompletedTask;
        }
    }

}