﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TimeTracker.Core
{
	public class Model
	{
		private HashSet<String> _roles = new HashSet<string>(StringComparer.InvariantCultureIgnoreCase);
		private List<User> _people = new List<User>();
		private List<Project> _projects = new List<Project>();

		public IEnumerable<Project> Projects { get { return _projects; } }
		public IEnumerable<User> People { get { return _people; } }
		public IEnumerable<String> Roles { get { return _roles; } }
		
		public void AddRole(string role)
		{
			if (!_roles.Contains(role))
			{
				string ucFirst = role.Substring(0, 1).ToUpperInvariant() + role.Substring(1).ToLowerInvariant();
				_roles.Add(ucFirst);
			}
		}

		public Model()
		{
			_projects = new List<Project>();
		}
	}
}