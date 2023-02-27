using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace NovoFatum_R3.Properties
{
	// Token: 0x02000043 RID: 67
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	[CompilerGenerated]
	[DebuggerNonUserCode]
	internal class Resources
	{
		// Token: 0x060001EA RID: 490 RVA: 0x000028F1 File Offset: 0x00000AF1
		internal Resources()
		{
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x060001EB RID: 491 RVA: 0x00016B04 File Offset: 0x00014D04
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager_0
		{
			get
			{
				if (object.ReferenceEquals(Resources.resourceManager_0, null))
				{
					ResourceManager resourceManager = new ResourceManager("NovoFatum_R3.Properties.Resources", typeof(Resources).Assembly);
					Resources.resourceManager_0 = resourceManager;
				}
				return Resources.resourceManager_0;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x060001EC RID: 492 RVA: 0x00016B48 File Offset: 0x00014D48
		// (set) Token: 0x060001ED RID: 493 RVA: 0x000034AF File Offset: 0x000016AF
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo CultureInfo_0
		{
			get
			{
				return Resources.cultureInfo_0;
			}
			set
			{
				Resources.cultureInfo_0 = value;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x060001EE RID: 494 RVA: 0x00016B5C File Offset: 0x00014D5C
		internal static Bitmap Bitmap_0
		{
			get
			{
				object @object = Resources.ResourceManager_0.GetObject("auto_1", Resources.cultureInfo_0);
				return (Bitmap)@object;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x060001EF RID: 495 RVA: 0x00016B88 File Offset: 0x00014D88
		internal static Bitmap Bitmap_1
		{
			get
			{
				object @object = Resources.ResourceManager_0.GetObject("auto_2", Resources.cultureInfo_0);
				return (Bitmap)@object;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x060001F0 RID: 496 RVA: 0x00016BB4 File Offset: 0x00014DB4
		internal static Bitmap Bitmap_2
		{
			get
			{
				object @object = Resources.ResourceManager_0.GetObject("auto_final", Resources.cultureInfo_0);
				return (Bitmap)@object;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x060001F1 RID: 497 RVA: 0x00016BE0 File Offset: 0x00014DE0
		internal static Bitmap Bitmap_3
		{
			get
			{
				object @object = Resources.ResourceManager_0.GetObject("box_pixel1", Resources.cultureInfo_0);
				return (Bitmap)@object;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x060001F2 RID: 498 RVA: 0x00016C0C File Offset: 0x00014E0C
		internal static Bitmap Bitmap_4
		{
			get
			{
				object @object = Resources.ResourceManager_0.GetObject("frank_05", Resources.cultureInfo_0);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x060001F3 RID: 499 RVA: 0x00016C38 File Offset: 0x00014E38
		internal static Bitmap Bitmap_5
		{
			get
			{
				object @object = Resources.ResourceManager_0.GetObject("Loading", Resources.cultureInfo_0);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x060001F4 RID: 500 RVA: 0x00016C64 File Offset: 0x00014E64
		internal static Bitmap Bitmap_6
		{
			get
			{
				object @object = Resources.ResourceManager_0.GetObject("skull", Resources.cultureInfo_0);
				return (Bitmap)@object;
			}
		}

		// Token: 0x04000170 RID: 368
		private static ResourceManager resourceManager_0;

		// Token: 0x04000171 RID: 369
		private static CultureInfo cultureInfo_0;
	}
}
