﻿using Biggy.Core;
using Biggy.Data.Json;
using PDiffy.Web.Features.History;
using PDiffy.Web.Features.Page;
using PDiffy.Web.Infrastructure;

namespace PDiffy.Web.Data
{
	public class Biggy
	{
		private static BiggyList<PageModel> _biggyPageList;
	    private static BiggyList<KnownImageModel> _biggyKnownImageList;

	    public static BiggyList<PageModel> PageList
		{
			get
			{
				return _biggyPageList 
					?? (_biggyPageList = new BiggyList<PageModel>(new JsonStore<PageModel>(Environment.DataStorePath, "Biggy", "Pages")));
			}
		}

	    public static BiggyList<KnownImageModel> KnownImageList
	    {
	        get
	        {
	            return _biggyKnownImageList
                    ?? (_biggyKnownImageList = new BiggyList<KnownImageModel>(new JsonStore<KnownImageModel>(Environment.DataStorePath, "Biggy","KnownImages")));
	        }
	    }
	}
}