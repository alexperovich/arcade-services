// <auto-generated>
// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
//
// </auto-generated>

namespace Microsoft.DotNet.Maestro.Client
{
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for Channels.
    /// </summary>
    public static partial class ChannelsExtensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='classification'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<Channel>> GetAsync(this IChannels operations, string classification = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(classification, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='name'>
            /// </param>
            /// <param name='classification'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Channel> CreateChannelAsync(this IChannels operations, string name, string classification, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateChannelWithHttpMessagesAsync(name, classification, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Channel> GetChannelAsync(this IChannels operations, int id, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetChannelWithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Channel> DeleteChannelAsync(this IChannels operations, int id, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteChannelWithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='channelId'>
            /// </param>
            /// <param name='buildId'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task AddBuildToChannelAsync(this IChannels operations, int channelId, int buildId, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.AddBuildToChannelWithHttpMessagesAsync(channelId, buildId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='channelId'>
            /// </param>
            /// <param name='pipelineId'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task AddPipelineToChannelAsync(this IChannels operations, int channelId, int pipelineId, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.AddPipelineToChannelWithHttpMessagesAsync(channelId, pipelineId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='channelId'>
            /// </param>
            /// <param name='pipelineId'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeletePipelineFromChannelAsync(this IChannels operations, int channelId, int pipelineId, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeletePipelineFromChannelWithHttpMessagesAsync(channelId, pipelineId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}
