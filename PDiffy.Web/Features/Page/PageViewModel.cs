﻿using System;

namespace PDiffy.Web.Features.Page
{
	public class PageViewModel
	{
		public string Name { get; set; }

		public DateTime? LastComparisonDate { get; set; }
		public bool HumanComparisonRequired { get; set; }

        public bool ComparisonExists { get; set; }
		public bool ComparisonStillValid { get; set; }
	}
}