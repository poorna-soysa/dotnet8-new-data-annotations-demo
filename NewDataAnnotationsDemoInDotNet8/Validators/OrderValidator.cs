using FluentValidation;
using NewDataAnnotationsDemoInDotNet8.Models;

namespace NewDataAnnotationsDemoInDotNet8.Validators;

public sealed class OrderValidator : AbstractValidator<Order>
{
    public OrderValidator()
    {
        RuleFor(order => order.Id)
         .NotEmpty();

        RuleFor(order => order.CustomerName)
         .NotEmpty()
         
         .WithMessage("Customer Name is required!");

        RuleFor(order => order.CustomerEmail)
         .NotEmpty()
         .WithMessage("Customer Email is required!")
         .EmailAddress();

        RuleFor(order => order.Total)
           .GreaterThan(0);

        RuleFor(order => order.ShippedDate)
          .GreaterThan(order => order.OrderDate);
    }
}
