﻿//
//  IGroupInfo.cs
//
//  Author:
//       Jarl Gullberg <jarl.gullberg@gmail.com>
//
//  Copyright (c) 2017 Jarl Gullberg
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU Lesser General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU Lesser General Public License for more details.
//
//  You should have received a copy of the GNU Lesser General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.
//

using System.Collections.Generic;

namespace Remora.Commands.CommandInformation
{
    /// <summary>
    /// Contains information about a specific command group.
    /// </summary>
    public interface IGroupInfo
    {
        /// <summary>
        /// Gets the name of the group.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Gets the group's description, if any.
        /// </summary>
        string? Description { get; }

        /// <summary>
        /// Gets a read-only list of the group's aliases.
        /// </summary>
        IReadOnlyList<string> Aliases { get; }

        /// <summary>
        /// Gets a value indicating whether the command group was requested to be hidden from help commands.
        /// </summary>
        bool Hidden { get; }

        /// <summary>
        /// Gets a list of commands contained in this group.
        /// </summary>
        IReadOnlyList<ICommandInfo> Commands { get; }

        /// <summary>
        /// Gets a list of child groups contained in this group tree.
        /// </summary>
        IReadOnlyList<IGroupInfo> ChildGroups { get; }
    }
}
