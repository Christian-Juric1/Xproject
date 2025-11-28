using System;

using Xproject.Core.Models.Enums;

namespace Xproject.Core.Models;

public class ProjectTask
{
	public Guid Id { get; set; } = Guid.NewGuid();
	public string Name { get; set; } = string.Empty;
	public string Description { get; set; } = string.Empty;
	public TaskStatus Status { get; set; }
	public TaskPriority Priority { get; set; }
	public DateTime StartDate { get; set; }
	public DateTime? DueDate { get; set; }
	public DateTime CreatedAt { get; set; }
}