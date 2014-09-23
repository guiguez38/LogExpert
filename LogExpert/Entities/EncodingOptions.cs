﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LogExpert
{
	/// <summary>
	/// Holds some encoding options.
	/// </summary>
	public class EncodingOptions
	{
		/// <summary>
		/// Sets or gets the Encoding which shall be used when reading a file. A value of null means 'please autodetect' via BOM.
		/// </summary>
		public Encoding Encoding { get; set; }

		/// <summary>
		/// The Encoding to be used when autodetect cannot be applied (missing BOM). Only used when Encoding is set to null.
		/// </summary>
		public Encoding DefaultEncoding { get; set; }
	}
}