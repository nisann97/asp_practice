﻿using System;
namespace test.Services.Interfaces
{
	public interface ISettingService
	{
		Task<Dictionary<string, string>> GetAllAsync();
	}
}

