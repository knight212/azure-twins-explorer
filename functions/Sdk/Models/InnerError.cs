// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace AdtExplorer.Functions.Sdk.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A more specific error description than was provided by the containing
    /// error.
    /// </summary>
    public partial class InnerError
    {
        /// <summary>
        /// Initializes a new instance of the InnerError class.
        /// </summary>
        public InnerError()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the InnerError class.
        /// </summary>
        /// <param name="code">A more specific error code than was provided by
        /// the containing error.</param>
        /// <param name="innererror">An object containing more specific
        /// information than the current object about the error.</param>
        public InnerError(string code = default(string), InnerError innererror = default(InnerError))
        {
            Code = code;
            Innererror = innererror;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a more specific error code than was provided by the
        /// containing error.
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets an object containing more specific information than
        /// the current object about the error.
        /// </summary>
        [JsonProperty(PropertyName = "innererror")]
        public InnerError Innererror { get; set; }

    }
}
