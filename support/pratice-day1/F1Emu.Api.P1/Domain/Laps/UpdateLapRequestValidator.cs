using FluentValidation;

namespace F1Emu.Api.Domain.Laps
{
    public class UpdateLapRequestValidator : AbstractValidator<UpdateLapRequest>
    {
        public UpdateLapRequestValidator()
        {
        }
    }
}
