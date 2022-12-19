using Dapper;
using F1Emu.Api.Domain.Laps;
using System.Data.SqlClient;

namespace F1Emu.Api.Infrastructure.SqlLap
{
    public class SqlLapRepository : ILapRepository
    {

        private readonly string connectionString;
        public SqlLapRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }


        public async Task<Lap> Add(Lap lap)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();
                var sqlStatement = @"
                INSERT INTO [dbo].[Laps]
                ([Id]
                ,[DriverName]
                ,[LapIndex]
                ,[Sector]
                ,[ElapsedTime]
                ,[CreatedOn])
                VALUES(
                @Id,
                @DriverName,
                @LapIndex,
                @Sector,
                @ElapsedTime,
                @CreatedOn
                )";
                await connection.ExecuteAsync(sqlStatement, new
                LapDataModel().MapFrom(lap));
            }
            return lap;
        }


        public Task Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Lap>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<Lap> GetSingle(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task Update(Guid id, bool isInvalid)
        {
            throw new NotImplementedException();
        }
    }
}
