using FluentValidation;

namespace TimeTracker1.Models.Validation
{
    public class ClientInputModelValidator : AbstractValidator<ClientInputModel>
    {
        public ClientInputModelValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .Length(1, 100);
        }
    }
}
