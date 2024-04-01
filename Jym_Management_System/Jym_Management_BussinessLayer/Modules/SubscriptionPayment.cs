﻿using System;
using System.Collections.Generic;

namespace Jym_Management_DataAccessLayer.Entities
{
    public partial class TbSubscriptionPayment
    {
        public int? PaymentId { get; set; }
        public int? SubscriptionId { get; set; }
        public DateTime? PaymentDate { get; set; }
        public decimal? PaymentAmount { get; set; }
        public short? CreatedByUserId { get; set; }

        public virtual TbUser? CreatedByUser { get; set; }
        public virtual Subscription? Subscription { get; set; }
    }
}