using System;
using System.Threading.Tasks;

namespace ZXing.Mobile
{
	public partial class ResultWithRawImage
    {
		public Result Result { get; set; }
		public byte[] RawImage { get; set; }
	}
}
