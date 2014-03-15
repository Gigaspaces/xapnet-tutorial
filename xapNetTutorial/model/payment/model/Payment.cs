using System;

using GigaSpaces.Core.Metadata;  

namespace xaptutorial.model 
{
	[SpaceClass(FifoSupport = FifoSupport.Operation)]
	public class Payment   {
		[SpaceID(AutoGenerate = true)]
		private String Id;
		[SpaceIndex(Type = SpaceIndexType.Basic)]
		private long? UserId;
		[SpaceRouting]
		[SpaceIndex(Type = SpaceIndexType.Basic)]
		private long?  MerchantId;
		private String Description;
		private double? PaymentAmount;
		private Nullable<ETransactionStatus> Status;
		[SpaceIndex(Type = SpaceIndexType.Basic)]
		private DateTime CreatedDate;

		public Payment(String paymentId) {
			this.Id = paymentId;
		}

		public Payment() {
		}


		public String getPaymentId() {
			return Id;
		}

		public void setPaymentId(String paymentId) {
			this.Id = paymentId;
		}


		public long?  getUserId() {
			return UserId;
		}

		public void setUserId(long?  payingAccountId) {
			this.UserId = payingAccountId;
		}


		public long?  getMerchantId() {
			return MerchantId;
		}

		public void setMerchantId(long?  receivingMerchantId) {
			this.MerchantId = receivingMerchantId;
		}

		public String getDescription() {
			return Description;
		}

		public void setDescription(String description) {
			this.Description = description;
		}

		public Nullable<ETransactionStatus> getStatus() {
			return Status;
		}

		public void setStatus(ETransactionStatus status) {
			this.Status = status;
		}
			
		public DateTime getCreatedDate() {
			return CreatedDate;
		}

		public void setCreatedDate(DateTime d) {
			this.CreatedDate = d;
		}

		public void setPaymentAmount(double? paymentAmount) {
			this.PaymentAmount = paymentAmount;
		}

		public double? getPaymentAmount() {
			return PaymentAmount;
		}
	}
}
