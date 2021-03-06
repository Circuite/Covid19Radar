﻿using Newtonsoft.Json;

namespace Covid19Radar.Models
{
    [JsonObject("userParameter")]
    public class UserParameter: IUser
    {
        /// <summary>
        /// User UUID / take care misunderstand Becon ID
        /// </summary>
        /// <value>User UUID</value>
        [JsonProperty("userUuid")]
        public string UserUuid { get; set; }

        /// <summary>
        /// User Major 0 to 65536
        /// </summary>
        /// <value>User Major</value>
        [JsonProperty("major")]
        public string Major { get; set; }

        /// <summary>
        /// User Minor 0 to 65536
        /// </summary>
        /// <value>User Minor</value>
        [JsonProperty("minor")]
        public string Minor { get; set; }
    }
}
