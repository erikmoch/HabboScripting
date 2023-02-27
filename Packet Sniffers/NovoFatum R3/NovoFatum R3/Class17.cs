using System;

// Token: 0x0200002E RID: 46
internal static class Class17
{
	// Token: 0x06000121 RID: 289 RVA: 0x0000E930 File Offset: 0x0000CB30
	public static void smethod_0(byte[] byte_0)
	{
		bool flag = false;
		Class13 @class = new Class13(byte_0);
		Class28.smethod_2(@class.Int32_1, byte_0);
		Class1.class11_0.method_6(byte_0);
		if (Class17.bool_0)
		{
			switch (Class17.short_0)
			{
			case 0:
				Class1.string_3 = @class.method_0();
				Class28.smethod_4("Working for " + Class1.string_3);
				break;
			case 1:
			{
				Class17.int_1 = @class.Int32_1;
				Class14 class2 = new Class14(Class17.int_1);
				class2.method_3(Class24.class23_3.method_4().ToLower());
				Class1.class19_0.method_8(class2.method_5());
				Class28.smethod_3("Pwned Server Security! Sent custom keys! 8-)");
				Class17.bool_0 = false;
				flag = true;
				break;
			}
			}
			Class17.short_0 += 1;
		}
		if (!flag)
		{
			byte[] byte_ = @class.method_3();
			Class1.class19_0.method_8(byte_);
		}
	}

	// Token: 0x06000122 RID: 290 RVA: 0x0000EA18 File Offset: 0x0000CC18
	public static void smethod_1(byte[] byte_0)
	{
		bool flag = false;
		Class13 @class = new Class13(byte_0);
		Class28.smethod_0(@class.Int32_1, byte_0);
		Class1.class11_0.method_5(byte_0);
		if (Class17.bool_1)
		{
			switch (Class17.short_1)
			{
			case 0:
			{
				Class17.int_0 = @class.Int32_1;
				string string_ = @class.method_0();
				Class24.smethod_1(string_);
				Class14 class2 = new Class14(Class17.int_0);
				class2.method_3(Class24.string_1);
				class2.method_2(false);
				flag = true;
				Class1.class19_0.method_7(class2.method_5());
				Class28.smethod_4("Wait for banner exploit sulake 8-)");
				break;
			}
			case 1:
			{
				Class17.int_2 = @class.Int32_1;
				Class24.smethod_2(@class.method_0());
				Class14 class3 = new Class14(Class17.int_2);
				class3.method_3("1");
				Class1.class19_0.method_7(class3.method_5());
				Class24.class25_1 = new Class25();
				Class24.class25_1.method_0(new byte[]
				{
					1
				});
				while (!Class24.class25_1.bool_0)
				{
				}
				Class17.bool_1 = false;
				flag = true;
				Class28.smethod_4("Pwned Client Security! Sent pwned data to client 8-)");
				break;
			}
			}
			Class17.short_1 += 1;
		}
		if (!flag)
		{
			byte[] byte_ = @class.method_3();
			Class1.class19_0.method_7(byte_);
		}
	}

	// Token: 0x040000E8 RID: 232
	public static short short_0 = 0;

	// Token: 0x040000E9 RID: 233
	public static short short_1 = 0;

	// Token: 0x040000EA RID: 234
	public static bool bool_0 = true;

	// Token: 0x040000EB RID: 235
	public static bool bool_1 = true;

	// Token: 0x040000EC RID: 236
	private static int int_0;

	// Token: 0x040000ED RID: 237
	private static int int_1;

	// Token: 0x040000EE RID: 238
	private static int int_2;
}
