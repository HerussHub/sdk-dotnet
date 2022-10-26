namespace MercadoPago.Client.Payment
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Payment's data.
    /// </summary>
    public class PaymentDataRequest
    {
        /// <summary>
        /// Payment data.
        /// </summary>
        public PaymentRulesRequest Rules { get; set; }
    }
}