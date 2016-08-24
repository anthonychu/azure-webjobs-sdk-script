﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System.Collections.Generic;
using Colors.Net;
using WebJobs.Script.Cli.Common.Models;

namespace WebJobs.Script.Cli.Interfaces
{
    internal interface ITipsManager
    {
        void Record(bool failed);
        IEnumerable<Invocation> GetInvocations(int count);
        IEnumerable<Invocation> GetAll();
        void DisplayTips(params string[] tips);
    }
}