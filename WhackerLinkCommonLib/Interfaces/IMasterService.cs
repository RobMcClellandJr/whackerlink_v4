﻿using Serilog;
using WhackerLinkCommonLib.Models;
using WhackerLinkServer.Models;

namespace WhackerLinkCommonLib.Interfaces
{
    public interface IMasterService
    {
        ILogger Logger {  get; }
        List<Affiliation> GetAffiliations();
        List<VoiceChannel> GetVoiceChannels();
        List<string> GetAvailableVoiceChannels();
        List<string> GetControlChannels();
        List<RidAclEntry> GetRidAcl();
        bool GetRidAclEnabled();
        void Start(CancellationToken cancellationToken);
    }
}