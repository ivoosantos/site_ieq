namespace SiteCRM.FrontEnd.Models
{
	public class MIssaoViewModel
	{
		public int id { get; set; }
		public string titulo { get; set; }
		public string slug { get; set; }
		public string texto { get; set; }

		//[IgnoreDataMember]
		//[BindNever]
		public string img { get; set; }
		public DateTime dataPost { get; set; }

		public virtual byte[] imgByte { get; set; }
	}
}
