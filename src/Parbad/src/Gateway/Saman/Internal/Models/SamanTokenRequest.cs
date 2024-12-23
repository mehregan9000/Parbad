// Copyright (c) Parbad. All rights reserved.
// Licensed under the GNU GENERAL PUBLIC License, Version 3.0. See License.txt in the project root for license information.

using Newtonsoft.Json;

namespace Parbad.Gateway.Saman.Internal.Models;

internal class SamanTokenRequest
{
    [JsonProperty("action")]
    public string Action { get; set; }
        
    public string TerminalId { get; set; }
        
    public long Amount { get; set; }
        
    public string ResNum { get; set; }
        
    public string RedirectUrl { get; set; }
        
    public string CellNumber { get; set; }
}
