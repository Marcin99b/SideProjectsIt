﻿using System.Collections.Generic;

namespace SideProjectsIt.Shared.Infrastructure.Modules;

internal record ModuleInfo(string Name, IEnumerable<string> Policies);