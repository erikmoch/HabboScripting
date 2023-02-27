using System;
using System.Collections.Generic;
using System.Net;
using System.Xml;

// Token: 0x02000022 RID: 34
public class GClass0
{
	// Token: 0x060000E5 RID: 229 RVA: 0x0000DA8C File Offset: 0x0000BC8C
	public void method_0()
	{
		try
		{
			string xml;
			using (WebClient webClient = new WebClient())
			{
				xml = webClient.DownloadString(this.string_1 + "/main.xml");
			}
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(xml);
			XmlNodeList elementsByTagName = xmlDocument.GetElementsByTagName("repofile");
			XmlNodeList elementsByTagName2 = ((XmlElement)elementsByTagName[0]).GetElementsByTagName("information");
			foreach (object obj in elementsByTagName2)
			{
				XmlElement xmlElement = (XmlElement)obj;
				XmlNodeList elementsByTagName3 = xmlElement.GetElementsByTagName("id");
				XmlNodeList elementsByTagName4 = xmlElement.GetElementsByTagName("name");
				this.string_0 = elementsByTagName4[0].InnerText;
				this.string_2 = elementsByTagName3[0].InnerText;
			}
			XmlNodeList elementsByTagName5 = ((XmlElement)elementsByTagName[0]).GetElementsByTagName("category");
			foreach (object obj2 in elementsByTagName5)
			{
				XmlElement xmlElement2 = (XmlElement)obj2;
				XmlNodeList elementsByTagName3 = xmlElement2.GetElementsByTagName("id");
				XmlNodeList elementsByTagName4 = xmlElement2.GetElementsByTagName("name");
				GClass2 gclass = new GClass2();
				gclass.string_1 = elementsByTagName4[0].InnerText;
				gclass.string_0 = elementsByTagName3[0].InnerText;
			}
		}
		catch
		{
		}
	}

	// Token: 0x040000D6 RID: 214
	public string string_0;

	// Token: 0x040000D7 RID: 215
	public string string_1;

	// Token: 0x040000D8 RID: 216
	public string string_2;

	// Token: 0x040000D9 RID: 217
	public List<GClass1> list_0;

	// Token: 0x040000DA RID: 218
	public List<GClass2> list_1;
}
