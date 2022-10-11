using System;

namespace SideProjectsIt.Shared.Infrastructure.Security.Encryption;

[AttributeUsage(AttributeTargets.Property)]
public class HashedAttribute : Attribute
{
}