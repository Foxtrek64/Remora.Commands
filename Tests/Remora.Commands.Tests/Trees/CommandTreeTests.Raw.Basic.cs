//
//  CommandTreeTests.Raw.Basic.cs
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

using Remora.Commands.Tests.Data.DummyModules;
using Remora.Commands.Trees;
using Xunit;

namespace Remora.Commands.Tests.Trees
{
    public static partial class CommandTreeTests
    {
        public static partial class Raw
        {
            /// <summary>
            /// Tests basic requirements.
            /// </summary>
            public class Basic
            {
                /// <summary>
                /// Tests whether the tree can be successfully searched.
                /// </summary>
                [Fact]
                public void SearchIsSuccessfulIfAMatchingCommandExists()
                {
                    var builder = new CommandTreeBuilder();
                    builder.RegisterModule<NamedGroupWithCommandsWithNestedNamedGroupWithCommands>();

                    var tree = builder.Build();

                    var result = tree.Search("a c d");
                    Assert.NotEmpty(result);
                }

                /// <summary>
                /// Tests whether the tree can be successfully searched.
                /// </summary>
                [Fact]
                public void SearchIsUnsuccessfulIfNoMatchingCommandExists()
                {
                    var builder = new CommandTreeBuilder();
                    builder.RegisterModule<NamedGroupWithCommandsWithNestedNamedGroupWithCommands>();

                    var tree = builder.Build();

                    var result = tree.Search("a d c");
                    Assert.Empty(result);
                }
            }
        }
    }
}
