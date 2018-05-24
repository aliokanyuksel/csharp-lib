using System;
using System.IO;
using System.Collections.Generic;
using System.Xml;
public static class xmltest
{
  public static void Main(string[] args)
  {
	string filename=args[0];
	string rawxml = File.ReadAllText(filename);
	XmlDocument xmlDoc = new XmlDocument();
	xmlDoc.LoadXml(rawxml);
	XmlNodeList elemlist = xmlDoc.GetElementsByTagName("name");
	string name = elemlist[0].InnerXml;
	Console.WriteLine(name);
  }
}
