using Newtonsoft.Json;

namespace IctBaden.Api1NCE.Models
{
    /// <summary>
    /// Pdp Context
    /// </summary>
    public class PdpContext
    {
        [JsonProperty("breakout_ip")]
        public string BreakoutIp { get; set; }
        [JsonProperty("ci")]
        public string Ci { get; set; }
        [JsonProperty("created")]
        public string Created { get; set; }
        [JsonProperty("duration")]
        public string Duration { get; set; }
        [JsonProperty("endpoint_id")]
        public string EndpointId { get; set; }
        [JsonProperty("ggsn_control_plane_ip_address")]
        public string GgsnControlPlaneIpAddress { get; set; }
        [JsonProperty("ggsn_data_plane_ip_address")]
        public string GgsnDataPlaneIpAddress { get; set; }
        [JsonProperty("gtp_version")]
        public string GtpVersion { get; set; }
        [JsonProperty("imeisv")]
        public string Imeisv { get; set; }
        [JsonProperty("imsi")]
        public string Imsi { get; set; }
        [JsonProperty("imsi_id")]
        public string ImsiId { get; set; }
        [JsonProperty("lac")]
        public int Lac { get; set; }
        [JsonProperty("mcc")]
        public string Mcc { get; set; }
        [JsonProperty("mnc")]
        public string Mnc { get; set; }
        [JsonProperty("nsapi")]
        public string Nsapi { get; set; }
        [JsonProperty("operator_id")]
        public string OperatorId { get; set; }
        [JsonProperty("organisation_id")]
        public string OrganisationId { get; set; }
        [JsonProperty("pdp_context_id")]
        public string PdpContextId { get; set; }
        [JsonProperty("rac")]
        public string Rac { get; set; }
        [JsonProperty("rat_type")]
        public Location RatType { get; set; }
        [JsonProperty("ratezone_id")]
        public string RatezoneId { get; set; }
        [JsonProperty("region")]
        public string Region { get; set; }
        [JsonProperty("sac")]
        public string Sac { get; set; }
        [JsonProperty("sgsn_control_plane_ip_address")]
        public string SgsnControlPlaneIpAddress { get; set; }
        [JsonProperty("sgsn_data_plane_ip_address")]
        public string SgsnDataPlaneIpAddress { get; set; }
        [JsonProperty("sim_id")]
        public string SimId { get; set; }
        [JsonProperty("tariff_id")]
        public string TariffId { get; set; }
        [JsonProperty("tariff_profile_id")]
        public string TariffProfileId { get; set; }
        [JsonProperty("teid_control_plane")]
        public string TeidControlPlane { get; set; }
        [JsonProperty("teid_data_plane")]
        public string TeidDataPlane { get; set; }
        [JsonProperty("ue_ip_address")]
        public string UeIpAddress { get; set; }
    }
}
