using System;
using System.Collections.Generic;

namespace DbFirst.Models;

public partial class Bill
{
    public string BillId { get; set; } = null!;

    public string? CusId { get; set; }

    public string? AgreementId { get; set; }

    public DateOnly? Date { get; set; }

    public string? PaymentImg { get; set; }

    public string? Status { get; set; }

    public virtual RentalAgreement? Agreement { get; set; }

    public virtual Customer? Cus { get; set; }
}
