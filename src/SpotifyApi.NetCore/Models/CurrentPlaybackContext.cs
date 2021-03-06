// Generated by https://quicktype.io

namespace SpotifyApi.NetCore
{
    using System;
    using Newtonsoft.Json;

    /// <summary>
    /// Currently Playing Object
    /// </summary>
    /// <remarks> https://developer.spotify.com/documentation/web-api/reference/player/get-the-users-currently-playing-track/ </remarks>
    public abstract partial class CurrentPlaybackContext
    {
        /// <summary>
        /// Unix Millisecond Timestamp when data was fetched.
        /// </summary>
        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }

        [JsonProperty("device", NullValueHandling = NullValueHandling.Ignore)]
        public Device Device { get; set; }

        /// <summary>
        /// Progress into the currently playing track. Can be null.
        /// </summary>
        [JsonProperty("progress_ms", NullValueHandling = NullValueHandling.Ignore)]
        public long? ProgressMs { get; set; }

        [JsonProperty("is_playing")]
        public bool IsPlaying { get; set; }

        /// <summary>
        /// The object type of the currently playing item. Can be one of track, episode, ad or unknown.
        /// </summary>
        [JsonProperty("currently_playing_type")]
        public string CurrentlyPlayingType { get; set; }

        [JsonProperty("shuffle_state", NullValueHandling = NullValueHandling.Ignore)]
        public bool ShuffleState { get; set; }

        [JsonProperty("repeat_state", NullValueHandling = NullValueHandling.Ignore)]
        public string RepeatState { get; set; }

        /// <summary>
        /// A Context Object. Can be null.
        /// </summary>
        [JsonProperty("context")]
        public Context Context { get; set; }

        /// <summary>
        /// Allows to update the user interface based on which playback actions are available within the current context.
        /// </summary>
        [JsonProperty("actions")]
        public Actions Actions { get; set; }
    }

    public partial class Context
    {
        /// <summary>
        /// The external_urls of the context, or null if not available.
        /// </summary>
        [JsonProperty("external_urls")]
        public ExternalUrls ExternalUrls { get; set; }

        /// <summary>
        /// The href of the context, or null if not available.
        /// </summary>
        [JsonProperty("href")]
        public Uri Href { get; set; }

        /// <summary>
        /// The object type of the item�s context. Can be one of album , artist or playlist.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// The uri of the context.
        /// </summary>
        [JsonProperty("uri")]
        public string Uri { get; set; }
    }
}
