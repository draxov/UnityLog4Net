using UnityEngine;
using System.Collections;
using System.IO;
using log4net;
using log4net.Config;

public class TestMono : MonoBehaviour 
{
	private const string LOGGER_CONFIG_FILE = "Log4NetConfig.txt";
	private const string RESOURCES_DEFAULT_CONFIG = "DefaultConfig";

	private static readonly ILog log = LogManager.GetLogger(typeof(TestMono));

	private void Start()
	{
		string sPersistentDataPath = Application.persistentDataPath;
		string sPathToConfg = sPersistentDataPath + Path.DirectorySeparatorChar + LOGGER_CONFIG_FILE;
		if (false == File.Exists(sPathToConfg))
		{
			TextAsset defaultConfig = Resources.Load<TextAsset>(RESOURCES_DEFAULT_CONFIG);
			if (null != defaultConfig)
			{
				using (FileStream stream = File.Create(sPathToConfg))
				{
					using (StreamWriter writer = new StreamWriter(stream))
					{
						writer.Write(defaultConfig.text);
					}
				}
			}
		}

		FileInfo configInfo = new FileInfo(sPathToConfg);

		// Set up a simple configuration that logs on the console.
		XmlConfigurator.ConfigureAndWatch(configInfo);
		
		log.Info("Test Unity.");
	}
}
