UnityLog4Net
============

An adaptation of Log4Net that works with Unity

The priority is to make this work for all rather than specific versions of Unity

Made for Net 2.0 Subset

<h2>Installation</h2>
Place the Assets/Log4Net folder anywhere in your project

<h2>Usage</h2>
To use, you will nead to use the XmlConfigurator class to load an xml file to configure the system.

There is a UnityLogManager for doing unity related things with the logging (like passing objects).

To find out more about using log4net, please read the website, it has plenty of info:
https://logging.apache.org/log4net/release/manual/configuration.html

<h2>Release Notes</h2>
 - Updated to work with Unity 5

<h4>Log4Net Appenders that do not work in this adaption</h4>

AdoNetAppender
AspNetTraceAppender
DebugAppender
EventLogAppender
ManagedColoredConsoleAppender
UdpAppender
RemoteSyslogAppender
