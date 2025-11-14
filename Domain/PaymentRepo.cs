using Model;

namespace Domain;

public class PaymentRepo:ARepositoryAsync<PaymentContext, PaymentContext>
{
    public PaymentRepo(PaymentContext context) : base(context)
    {
    }
}