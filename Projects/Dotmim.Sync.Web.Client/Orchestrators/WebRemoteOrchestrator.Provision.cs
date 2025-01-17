﻿using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Dotmim.Sync.Batch;
using Dotmim.Sync.Enumerations;
using Dotmim.Sync.Serialization;

namespace Dotmim.Sync.Web.Client
{
    public partial class WebRemoteOrchestrator : RemoteOrchestrator
    {

        public override Task<bool> DeprovisionAsync(string scopeName, SyncProvision provision = SyncProvision.NotSet)
                => throw new NotImplementedException();
        public override Task<ScopeInfo> ProvisionAsync(ScopeInfo serverScopeInfo, SyncProvision provision = SyncProvision.NotSet, bool overwrite = false)
            => throw new NotImplementedException();
        public override Task<ScopeInfo> ProvisionAsync(string scopeName, SyncProvision provision = SyncProvision.NotSet, bool overwrite = false)
            => throw new NotImplementedException();
        public override Task<ScopeInfo> ProvisionAsync(string scopeName, SyncSetup setup = null, SyncProvision provision = SyncProvision.NotSet, bool overwrite = false)
            => throw new NotImplementedException();
        public override Task<ScopeInfo> ProvisionAsync(SyncProvision provision = SyncProvision.NotSet, bool overwrite = false)
            => throw new NotImplementedException();
        public override Task<ScopeInfo> ProvisionAsync(SyncSetup setup, SyncProvision provision = SyncProvision.NotSet, bool overwrite = false)
            => throw new NotImplementedException();
        public override Task<bool> DeprovisionAsync(string scopeName, SyncSetup setup, SyncProvision provision = SyncProvision.NotSet)
            => throw new NotImplementedException();
        public override Task<bool> DeprovisionAsync(SyncProvision provision = SyncProvision.NotSet)
            => throw new NotImplementedException();
        public override Task<bool> DeprovisionAsync(SyncSetup setup, SyncProvision provision = SyncProvision.NotSet)
            => throw new NotImplementedException();



    }
}
