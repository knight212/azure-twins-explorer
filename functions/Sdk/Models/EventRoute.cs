// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace AdtExplorer.Functions.Sdk.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A route which directs notification and telemetry events to an endpoint.
    /// Endpoints are a destination outside of Azure Digital Twins such as an
    /// EventHub.
    /// </summary>
    public partial class EventRoute
    {
        /// <summary>
        /// Initializes a new instance of the EventRoute class.
        /// </summary>
        public EventRoute()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EventRoute class.
        /// </summary>
        /// <param name="endpointId">The id of the endpoint this event route is
        /// bound to.</param>
        /// <param name="id">The id of the event route.</param>
        /// <param name="filter">An expression which describes the events which
        /// are routed to the endpoint.</param>
        public EventRoute(string endpointId, string id = default(string), string filter = default(string))
        {
            Id = id;
            EndpointId = endpointId;
            Filter = filter;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the id of the event route.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets or sets the id of the endpoint this event route is bound to.
        /// </summary>
        [JsonProperty(PropertyName = "endpointId")]
        public string EndpointId { get; set; }

        /// <summary>
        /// Gets or sets an expression which describes the events which are
        /// routed to the endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "filter")]
        public string Filter { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (EndpointId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "EndpointId");
            }
        }
    }
}
