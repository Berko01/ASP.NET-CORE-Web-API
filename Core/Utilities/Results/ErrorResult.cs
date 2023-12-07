﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
	internal class ErrorResult : Result
	{
		public ErrorResult(bool success, string message) : base(false, message)
		{
		}

		public ErrorResult(bool success) : base(false)
		{
		}
	}
}
