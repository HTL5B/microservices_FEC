using Model;

namespace Domain;

public class PaymentRepo:ARepositoryAsync<PaymentContext, Payment>
{
    public PaymentRepo(PaymentContext context) : base(context)
    {
    }
}