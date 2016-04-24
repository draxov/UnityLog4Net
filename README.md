UnityLog4Net
============

An adaptation of Log4Net that works with Unity

The priority is to make this work for all rather than specific versions of Unity

Made for Net 2.0 Subset

To use, you will nead to use the XmlConfigurator class to load an xml file to configure the system.
There is a UnityLogManager for doing unity related things with the logging (like passing objects).
To find out more about using log4net, please read the website, it has plenty of info:
https://logging.apache.org/log4net/release/manual/configuration.html

Release Notes
 - Updated to work with Unity 5

Log4Net Appenders that do not work in this adaption:

AdoNetAppender
AspNetTraceAppender
DebugAppender
EventLogAppender
ManagedColoredConsoleAppender
UdpAppender
RemoteSyslogAppender
