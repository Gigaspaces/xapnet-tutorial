using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GigaSpaces.Core.Metadata;

namespace common
{
        [SpaceClass(FifoSupport = FifoSupport.Operation)]
        public class Payment
        {
            [SpaceID(AutoGenerate = true)]
            public String Id { set; get; }
            [SpaceIndex(Type = SpaceIndexType.Basic)]
            public long? UserId { set; get; }
            [SpaceRouting]
            [SpaceIndex(Type = SpaceIndexType.Basic)]
            public long? MerchantId { set; get; }
            public String Description { set; get; }
            public double? PaymentAmount { set; get; }
            public ETransactionStatus Status { set; get; }
            [SpaceIndex(Type = SpaceIndexType.Basic)]
            public DateTime CreatedDate { set; get; }

            public Payment(String paymentId)
            {
                this.Id = paymentId;
            }

            public Payment()
            {
            } 
    }

}
