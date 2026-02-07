using System.ComponentModel.DataAnnotations;
using Nekai.Common;

namespace NekaiManager.Data.DTOs;

public class SettingsDto
{
	public bool PreferDarkMode { get; set; }
	public DisplayLanguage PreferredLanguage { get; set; }
}