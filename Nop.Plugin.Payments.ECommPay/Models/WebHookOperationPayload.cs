using Newtonsoft.Json;

namespace Nop.Plugin.Payments.ECommPay.Models
{
    /// <summary>
    /// Represents a operation payload of the web hook request
    /// </summary>
    public class WebHookOperationPayload
    {
        #region Properties

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        #endregion
    }
}
