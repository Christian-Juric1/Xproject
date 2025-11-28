using System;

using Xproject.Core.Models.Enums;

namespace Xproject.Core.Models;

public class Project
{
	public Guid Id { get; set; } = Guid.NewGuid();
	public string Name { get; set; } = string.Empty;
	public string Description { get; set; } = string.Empty;
	public ProjectStatus Status { get; set; }
	public decimal? Budget { get; set; }
	public DateTime StartDate { get; set; }
	public DateTime? EndDate { get; set; }
	public DateTime CreatedAt { get; set; }
}