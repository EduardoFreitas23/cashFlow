using CashFlow.Domain.Enums;

namespace CashFlow.Domain.Extensions;

public static class PaymentTypeExtensions {
    public static string PaymentTypeString(this PaymentType paymentType) {
        return paymentType switch {
            PaymentType.Cash => "Dinheiro",
            PaymentType.CreditCard => "Cart�o de Cr�dio",
            PaymentType.DebitCard => "Cart�o de D�bito",
            PaymentType.EletronicTransfer => "Transferencia Bancaria",
            _ => string.Empty
        };
    }
}
