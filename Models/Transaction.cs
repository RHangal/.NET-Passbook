using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankTransaction.Models
{
	public class Transaction
	{
		[Key]
		public int TransactionId{ get; set;}

		[Required(ErrorMessage ="This field is required.")]
		[DisplayName("Account Number")]
		[Column(TypeName ="varchar(12)")]
		[MaxLength(12,ErrorMessage ="Maximum 12 characters only.")]
		public String AccountNumber{ get; set;}

        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Beneficiary Name")]
		[Column(TypeName ="varchar(100)")]
		public String BeneficiaryName{ get; set;}

        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Bank Name")]
        [Column(TypeName ="varchar(100)")]
		public String BankName{ get; set;}

        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("SWIFT Code")]
        [Column(TypeName ="varchar(11)")]
        [MaxLength(11, ErrorMessage = "Maximum 11 characters only.")]
        public String SWIFTCode{ get; set;}

        [Required(ErrorMessage = "This field is required.")]
        public int Amount{ get; set;}

		[DisplayFormat(DataFormatString ="{0:MMM-dd-yy}")]
		public DateTime Date{ get; set;}
	}
}

