using System;
using NServiceBus.MessageRouting.RoutingSlips.Samples.Messages;
using NServiceBus.Unicast;
using log4net;
using NServiceBus.Diagnostics;

namespace NServiceBus.MessageRouting.RoutingSlips.Samples.ResultHost 
{
    using NServiceBus;

	/*
		This class configures this endpoint as a Server. More information about how to configure the NServiceBus host
		can be found here: http://nservicebus.com/GenericHost.aspx
	*/
    public class EndpointConfig : IConfigureThisEndpoint, AsA_Server
    {
    }

    public class Startup : IWantCustomInitialization
    {
        public void Init()
        {
            Configure.Instance.RoutingSlips().Diagnostics();
            SetLoggingLibrary.Log4Net();
        }
    }
}