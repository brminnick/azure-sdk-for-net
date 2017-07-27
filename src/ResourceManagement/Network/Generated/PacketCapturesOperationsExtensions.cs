// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network.Fluent
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Network;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for PacketCapturesOperations.
    /// </summary>
    public static partial class PacketCapturesOperationsExtensions
    {
            
            /// <summary>
            /// Create and start a packet capture on the specified VM.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkWatcherName'>
            /// The name of the network watcher.
            /// </param>
            /// <param name='packetCaptureName'>
            /// The name of the packet capture session.
            /// </param>
            /// <param name='parameters'>
            /// Parameters that define the create packet capture operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PacketCaptureResultInner> CreateAsync(this IPacketCapturesOperations operations, string resourceGroupName, string networkWatcherName, string packetCaptureName, PacketCaptureInner parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(resourceGroupName, networkWatcherName, packetCaptureName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            
            /// <summary>
            /// Gets a packet capture session by name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkWatcherName'>
            /// The name of the network watcher.
            /// </param>
            /// <param name='packetCaptureName'>
            /// The name of the packet capture session.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PacketCaptureResultInner> GetAsync(this IPacketCapturesOperations operations, string resourceGroupName, string networkWatcherName, string packetCaptureName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, networkWatcherName, packetCaptureName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            
            /// <summary>
            /// Deletes the specified packet capture session.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkWatcherName'>
            /// The name of the network watcher.
            /// </param>
            /// <param name='packetCaptureName'>
            /// The name of the packet capture session.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IPacketCapturesOperations operations, string resourceGroupName, string networkWatcherName, string packetCaptureName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, networkWatcherName, packetCaptureName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            
            /// <summary>
            /// Stops a specified packet capture session.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkWatcherName'>
            /// The name of the network watcher.
            /// </param>
            /// <param name='packetCaptureName'>
            /// The name of the packet capture session.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task StopAsync(this IPacketCapturesOperations operations, string resourceGroupName, string networkWatcherName, string packetCaptureName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.StopWithHttpMessagesAsync(resourceGroupName, networkWatcherName, packetCaptureName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            
            /// <summary>
            /// Query the status of a running packet capture session.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkWatcherName'>
            /// The name of the Network Watcher resource.
            /// </param>
            /// <param name='packetCaptureName'>
            /// The name given to the packet capture session.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PacketCaptureQueryStatusResultInner> GetStatusAsync(this IPacketCapturesOperations operations, string resourceGroupName, string networkWatcherName, string packetCaptureName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetStatusWithHttpMessagesAsync(resourceGroupName, networkWatcherName, packetCaptureName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            
            /// <summary>
            /// Lists all packet capture sessions within the specified resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkWatcherName'>
            /// The name of the Network Watcher resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<PacketCaptureResultInner>> ListAsync(this IPacketCapturesOperations operations, string resourceGroupName, string networkWatcherName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, networkWatcherName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            
            /// <summary>
            /// Create and start a packet capture on the specified VM.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkWatcherName'>
            /// The name of the network watcher.
            /// </param>
            /// <param name='packetCaptureName'>
            /// The name of the packet capture session.
            /// </param>
            /// <param name='parameters'>
            /// Parameters that define the create packet capture operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PacketCaptureResultInner> BeginCreateAsync(this IPacketCapturesOperations operations, string resourceGroupName, string networkWatcherName, string packetCaptureName, PacketCaptureInner parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateWithHttpMessagesAsync(resourceGroupName, networkWatcherName, packetCaptureName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            
            /// <summary>
            /// Deletes the specified packet capture session.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkWatcherName'>
            /// The name of the network watcher.
            /// </param>
            /// <param name='packetCaptureName'>
            /// The name of the packet capture session.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IPacketCapturesOperations operations, string resourceGroupName, string networkWatcherName, string packetCaptureName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, networkWatcherName, packetCaptureName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            
            /// <summary>
            /// Stops a specified packet capture session.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkWatcherName'>
            /// The name of the network watcher.
            /// </param>
            /// <param name='packetCaptureName'>
            /// The name of the packet capture session.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginStopAsync(this IPacketCapturesOperations operations, string resourceGroupName, string networkWatcherName, string packetCaptureName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginStopWithHttpMessagesAsync(resourceGroupName, networkWatcherName, packetCaptureName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            
            /// <summary>
            /// Query the status of a running packet capture session.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkWatcherName'>
            /// The name of the Network Watcher resource.
            /// </param>
            /// <param name='packetCaptureName'>
            /// The name given to the packet capture session.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PacketCaptureQueryStatusResultInner> BeginGetStatusAsync(this IPacketCapturesOperations operations, string resourceGroupName, string networkWatcherName, string packetCaptureName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginGetStatusWithHttpMessagesAsync(resourceGroupName, networkWatcherName, packetCaptureName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}