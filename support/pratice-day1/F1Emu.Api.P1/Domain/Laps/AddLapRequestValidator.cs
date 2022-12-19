using FluentValidation;

namespace F1Emu.Api.Domain.Laps
{
    public class AddLapRequestValidator : AbstractValidator<AddLapRequest>
    {
        public AddLapRequestValidator()
        {
        }
    }
}
