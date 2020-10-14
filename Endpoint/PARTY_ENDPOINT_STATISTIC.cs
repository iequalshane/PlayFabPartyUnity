using System;
using PartyCSharpSDK.Interop;

namespace PartyCSharpSDK
{
    //typedef enum PARTY_ENDPOINT_STATISTIC
    //{
    //    PARTY_ENDPOINT_STATISTIC_CURRENTLY_QUEUED_SEND_MESSAGES,
    //    PARTY_ENDPOINT_STATISTIC_CURRENTLY_QUEUED_SEND_MESSAGE_BYTES,
    //    PARTY_ENDPOINT_STATISTIC_CURRENTLY_ACTIVE_SEND_MESSAGES,
    //    PARTY_ENDPOINT_STATISTIC_CURRENTLY_ACTIVE_SEND_MESSAGE_BYTES,
    //    PARTY_ENDPOINT_STATISTIC_TIMED_OUT_SEND_MESSAGES,
    //    PARTY_ENDPOINT_STATISTIC_TIMED_OUT_SEND_MESSAGE_BYTES,
    //    PARTY_ENDPOINT_STATISTIC_CANCELED_SEND_MESSAGES,
    //    PARTY_ENDPOINT_STATISTIC_CANCELED_SEND_MESSAGE_BYTES,
    //} PARTY_ENDPOINT_STATISTIC;
    public enum PARTY_ENDPOINT_STATISTIC : UInt32
    {
        PARTY_ENDPOINT_STATISTIC_CURRENTLY_QUEUED_SEND_MESSAGES = 0,
        PARTY_ENDPOINT_STATISTIC_CURRENTLY_QUEUED_SEND_MESSAGE_BYTES = 1,
        PARTY_ENDPOINT_STATISTIC_CURRENTLY_ACTIVE_SEND_MESSAGES = 2,
        PARTY_ENDPOINT_STATISTIC_CURRENTLY_ACTIVE_SEND_MESSAGE_BYTES = 3,
        PARTY_ENDPOINT_STATISTIC_TIMED_OUT_SEND_MESSAGES = 4,
        PARTY_ENDPOINT_STATISTIC_TIMED_OUT_SEND_MESSAGE_BYTES = 5,
        PARTY_ENDPOINT_STATISTIC_CANCELED_SEND_MESSAGES = 6,
        PARTY_ENDPOINT_STATISTIC_CANCELED_SEND_MESSAGE_BYTES = 7,
    }
}