/* Umbra.Common | (c) 2024 by Una       ____ ___        ___.
 * Licensed under the terms of AGPL-3  |    |   \ _____ \_ |__ _______ _____
 *                                     |    |   //     \ | __ \\_  __ \\__  \
 * https://github.com/una-xiv/umbra    |    |  /|  Y Y  \| \_\ \|  | \/ / __ \_
 *                                     |______//__|_|  /____  /|__|   (____  /
 *     Umbra.Common is free software: you can        \/     \/             \/
 *     redistribute it and/or modify it under the terms of the GNU Affero
 *     General Public License as published by the Free Software Foundation,
 *     either version 3 of the License, or (at your option) any later version.
 *
 *     Umbra.Common is distributed in the hope that it will be useful,
 *     but WITHOUT ANY WARRANTY; without even the implied warranty of
 *     MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *     GNU Affero General Public License for more details.
 */

using System;

namespace Umbra.Common;

/// <summary>
/// Marks a <b>static</b> method as an initializer for the framework.
/// </summary>
/// <remarks>
/// The method is called and awaited when the framework is being initialized.
/// A framework initializer is typically used to find and register certain
/// types based on the assemblies in <see cref="Framework.Assemblies"/>.
/// <br/><br/>
/// <b>Important:</b> The method must be <b>static</b> and return <see cref="System.Threading.Tasks.Task"/>.
/// </remarks>
[AttributeUsage(AttributeTargets.Method)]
public class WhenFrameworkAsyncCompilingAttribute : Attribute;
