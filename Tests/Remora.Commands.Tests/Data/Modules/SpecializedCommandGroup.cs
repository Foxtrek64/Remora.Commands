//
//  SpecializedCommandGroup.cs
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

using System.Threading.Tasks;
using Remora.Commands.Attributes;
using Remora.Commands.Groups;
using Remora.Results;

#pragma warning disable CS1591, SA1600

namespace Remora.Commands.Tests.Data.Modules
{
    [Group("test")]
    public class SpecializedCommandGroup : CommandGroup
    {
        [Command("switch")]
        public Task<IResult> SingleBoolSwitch([Switch("enable")] bool value = false)
        {
            return Task.FromResult<IResult>(OperationResult.FromSuccess());
        }

        [Command("switch-short-name")]
        public Task<IResult> SingleShortBoolSwitch([Switch('e')] bool value = false)
        {
            return Task.FromResult<IResult>(OperationResult.FromSuccess());
        }

        [Command("switch-short-and-long-name")]
        public Task<IResult> SingleShortAndLongBoolSwitch([Switch('e', "enable")] bool value = false)
        {
            return Task.FromResult<IResult>(OperationResult.FromSuccess());
        }

        [Command("option")]
        public Task<IResult> SingleNamedBool([Option("enable")] bool value = false)
        {
            return Task.FromResult<IResult>(OperationResult.FromSuccess());
        }

        [Command("option-short-name")]
        public Task<IResult> SingleShortNamedBool([Option('e')] bool value = false)
        {
            return Task.FromResult<IResult>(OperationResult.FromSuccess());
        }

        [Command("option-short-and-long-name")]
        public Task<IResult> SingleShortAndLongNamedBool([Option('e', "enable")] bool value = false)
        {
            return Task.FromResult<IResult>(OperationResult.FromSuccess());
        }
    }
}
