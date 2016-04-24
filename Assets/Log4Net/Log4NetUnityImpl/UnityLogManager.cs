using System;
using System.Reflection;
using log4net.Core;

namespace log4net.Unity
{
    public static class UnityLogManager
    {
        public static I_IUnityLog GetLogger(Type type)
        {
            return GetLogger(Assembly.GetCallingAssembly(), type.FullName);
        }
        public static I_IUnityLog GetLogger(Assembly repositoryAssembly, string name)
        {
            return new UnityLogWrapper(LoggerManager.GetLogger(repositoryAssembly, name));
        }
    }
}