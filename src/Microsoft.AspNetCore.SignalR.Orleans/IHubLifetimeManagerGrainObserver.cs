﻿using Orleans;

namespace Microsoft.AspNetCore.SignalR;

internal interface IHubLifetimeManagerGrainObserver : IGrainObserver
{
    Task SendAllAsync(string methodName, object?[] args);
    Task SendAllExceptAsync(string methodName, object?[] args, IReadOnlyList<string> excludedConnectionIds);
    Task SendConnectionAsync(string connectionId, string methodName, object?[] args);
    Task SendGroupAsync(string groupName, string methodName, object?[] args);
    Task SendGroupExceptAsync(string groupName, string methodName, object?[] args, IReadOnlyList<string> excludedConnectionIds);
    Task SendUserAsync(string userId, string methodName, object?[] args);
    Task AddToGroupAsync(string connectionId, string groupName);
    Task<bool> RemoveFromGroupAsync(string connectionId, string groupName);
}