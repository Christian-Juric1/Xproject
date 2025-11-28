using System;

namespace Xproject.Core.Models;

public class User
{
	public Guid Id { get; set; } = Guid.NewGuid();
	public string FirstName { get; set; } = string.Empty;
	public string LastName { get; set; } = string.Empty;
	public string UserName { get; set; } = string.Empty;
	public string Email { get; set; } = string.Empty;
	public string PasswordHash { get; set; } = string.Empty;
	public bool IsActive { get; set; }
	public DateTime LastLogin { get; set; }
	public DateTime CreatedAt { get; set; }
	public DateTime UpdatedAt { get; set; }

	public string Name => $"{FirstName} {LastName}";
}