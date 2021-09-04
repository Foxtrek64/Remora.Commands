//
//  UInt32Parser.cs
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

using System.Threading;
using System.Threading.Tasks;
using JetBrains.Annotations;
using Remora.Commands.Results;
using Remora.Results;

namespace Remora.Commands.Parsers
{
    /// <summary>
    /// Parses <see cref="uint"/>s.
    /// </summary>
    [PublicAPI]
    public class UInt32Parser : AbstractTypeParser<uint>
    {
        /// <inheritdoc />
        public override ValueTask<Result<uint>> TryParseAsync(string? value, CancellationToken ct)
        {
            return new ValueTask<Result<uint>>
            (
                !uint.TryParse(value, out var result)
                ? new ParsingError<uint>(value)
                : Result<uint>.FromSuccess(result)
            );
        }
    }
}
