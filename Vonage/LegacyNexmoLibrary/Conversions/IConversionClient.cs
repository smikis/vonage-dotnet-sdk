using Nexmo.Api.Request;

namespace Nexmo.Api.Conversions
{
    [System.Obsolete("The Nexmo.Api.Conversions.IConversionClient interface is obsolete. " +
        "References to it should be switched to the new Vonage.Conversions.IConversionClient interface.")]
    public interface IConversionClient
    {
        /// <summary>
        /// Send a Conversion API request with information about the SMS message identified by message-id. 
        /// Nexmo uses your conversion data and internal information about message-id to help improve our routing of messages in the future.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="creds"></param>
        /// <returns></returns>
        bool SmsConversion(ConversionRequest request, Credentials creds = null);
        /// <summary>
        /// Send a Conversion API request with information about the Call or Text-To-Speech identified by message-id. 
        /// Nexmo uses your conversion data and internal information about message-id to help improve our routing of messages in the future.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="creds"></param>
        /// <returns></returns>
        bool VoiceConversion(ConversionRequest request, Credentials creds = null);
    }
}