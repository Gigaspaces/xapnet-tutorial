using System;
using GigaSpaces.Core.Metadata;


namespace xaptutorial.model
{
	[SpaceClass]
	public class Account {
		[SpaceID]
		[SpaceRouting]
		private long? Id { set; get; }
		private String Number{ set; get; }
		private double? Receipts{ set; get; }
		private double? FeeAmount{ set; get; }
		private Nullable<EAccountStatus> Status{ set; get; }
		[SpaceVersion]
		private int Version{ set; get; }

		public Account()
		{
			this.Status = EAccountStatus.INACTIVE;
		}
 		
		public int getVersion() {
			return Version;
		}

		public void setVersion(int version) {
			this.Version = version;
		}

        public void setId(int? id)
        {
            this.Id = id;
        }

        public long? getId()
        {
            return Id;
        }

		public String getNumber() {
			return Number;
		}

		public void setNumber(String number) {
			this.Number = number;
		}

		public double? getReceipts() {
			return Receipts;
		}

		public void setReceipts(double? receipts) {
			this.Receipts = receipts;
		}

        public double? getFeeAmount()
        {
			return FeeAmount;
		}

        public void setFeeAmount(double? feeAmount)
        {
			this.FeeAmount = feeAmount;
		}

		public Nullable<EAccountStatus> getStatus() {
			return Status;
		}

		public void setStatus(EAccountStatus status) {
			this.Status = status;
		}
	}
}