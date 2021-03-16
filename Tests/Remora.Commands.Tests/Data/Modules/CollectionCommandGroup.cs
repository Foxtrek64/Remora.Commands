//
//  CollectionCommandGroup.cs
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
using System.Threading.Tasks;
using Remora.Commands.Attributes;
using Remora.Commands.Groups;
using Remora.Results;

#pragma warning disable CS1591, SA1600

namespace Remora.Commands.Tests.Data.Modules
{
    [Group("test")]
    public class CollectionCommandGroup : CommandGroup
    {
        [Command("positional-collection")]
        public Task<IResult> PositionalCollection(IEnumerable<string> values)
        {
            return Task.FromResult<IResult>(Result.FromSuccess());
        }

        [Command("named-collection")]
        public Task<IResult> NamedCollection([Option("values")] IEnumerable<string> values)
        {
            return Task.FromResult<IResult>(Result.FromSuccess());
        }

        [Command("positional-collection-and-named-value")]
        public Task<IResult> PositionalCollection(IEnumerable<string> values, [Option("named")] string named)
        {
            return Task.FromResult<IResult>(Result.FromSuccess());
        }

        [Command("collection-with-min-count")]
        public Task<IResult> MinCountCollection([Range(Min = 1)] IEnumerable<string> values)
        {
            return Task.FromResult<IResult>(Result.FromSuccess());
        }

        [Command("collection-with-max-count")]
        public Task<IResult> MaxCountCollection([Range(Max = 2)] IEnumerable<string> values)
        {
            return Task.FromResult<IResult>(Result.FromSuccess());
        }

        [Command("collection-with-min-and-max-count")]
        public Task<IResult> MinMaxCountCollection([Range(Min = 1, Max = 2)] IEnumerable<string> values)
        {
            return Task.FromResult<IResult>(Result.FromSuccess());
        }

        [Command("constrained-collection-with-positional-value")]
        public Task<IResult> ConstrainedCollectionWithPositional([Range(Max = 2)] IEnumerable<string> values, string value)
        {
            return Task.FromResult<IResult>(Result.FromSuccess());
        }

        [Command("array-collection")]
        public Task<IResult> ArrayCollection(string[] values)
        {
            return Task.FromResult<IResult>(Result.FromSuccess());
        }

        [Command("params-collection")]
        public Task<IResult> ParamsCollection(params string[] values)
        {
            return Task.FromResult<IResult>(Result.FromSuccess());
        }
    }
}
