// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Diagnostics;
using System.Security.Permissions;

namespace Microsoft.Win32
{
    /// <devdoc>
    /// <para>Represents the method that will handle the <see cref='Microsoft.Win32.SystemEvents.SessionSwitch'/> event.</para>
    /// </devdoc>
    public delegate void SessionSwitchEventHandler(object sender, SessionSwitchEventArgs e);
}

