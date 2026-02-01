using System.ComponentModel.DataAnnotations;

namespace NekaiManager.Data.DTOs;

public class SettingsDto
{
	public required bool PreferDarkMode { get; set; }
}