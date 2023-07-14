using FluentValidation;

namespace SipayApi.Validator
{
    public class PersonValidator : AbstractValidator<Person>
    {
        public PersonValidator()
        {
            RuleFor(person => person.Id).NotNull();
            RuleFor(person => person.Name).NotNull().WithMessage("Name {Name} is required.");
            RuleFor(person => person.Lastname).NotNull();
            RuleFor(person => person.Phone).NotNull();
            RuleFor(person => person.AccessLevel).NotNull();
            RuleFor(person => person.Salary).NotNull().LessThanOrEqualTo(50000);
            RuleFor(person => person.Salary).LessThanOrEqualTo(person => person.Salary);


        }

    }
}
