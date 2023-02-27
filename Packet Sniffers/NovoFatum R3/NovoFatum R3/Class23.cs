using System;

// Token: 0x02000034 RID: 52
internal class Class23 : IDisposable
{
	// Token: 0x0600013D RID: 317 RVA: 0x000031B1 File Offset: 0x000013B1
	public Class23()
	{
		this.uint_0 = new uint[500];
		this.int_2 = 1;
	}

	// Token: 0x0600013E RID: 318 RVA: 0x0000F158 File Offset: 0x0000D358
	public Class23(long value)
	{
		this.uint_0 = new uint[500];
		long num = value;
		this.int_2 = 0;
		while (value != 0L && this.int_2 < 500)
		{
			this.uint_0[this.int_2] = (uint)(value & 4294967295L);
			value >>= 32;
			this.int_2++;
		}
		if (num > 0L)
		{
			if (value != 0L || (this.uint_0[499] & 2147483648U) != 0U)
			{
				throw new ArithmeticException("Positive overflow in constructor.");
			}
		}
		else if (num < 0L && (value != -1L || (this.uint_0[this.int_2 - 1] & 2147483648U) == 0U))
		{
			throw new ArithmeticException("Negative underflow in constructor.");
		}
		if (this.int_2 == 0)
		{
			this.int_2 = 1;
		}
	}

	// Token: 0x0600013F RID: 319 RVA: 0x0000F280 File Offset: 0x0000D480
	public Class23(ulong value)
	{
		this.uint_0 = new uint[500];
		this.int_2 = 0;
		while (value != 0UL && this.int_2 < 500)
		{
			this.uint_0[this.int_2] = (uint)(value & 4294967295UL);
			value >>= 32;
			this.int_2++;
		}
		if (value != 0UL || (this.uint_0[499] & 2147483648U) != 0U)
		{
			throw new ArithmeticException("Positive overflow in constructor.");
		}
		if (this.int_2 == 0)
		{
			this.int_2 = 1;
		}
	}

	// Token: 0x06000140 RID: 320 RVA: 0x0000F34C File Offset: 0x0000D54C
	public Class23(Class23 bi)
	{
		this.uint_0 = new uint[500];
		this.int_2 = bi.int_2;
		for (int i = 0; i < this.int_2; i++)
		{
			this.uint_0[i] = bi.uint_0[i];
		}
	}

	// Token: 0x06000141 RID: 321 RVA: 0x0000F3A8 File Offset: 0x0000D5A8
	public Class23(string value, int radix)
	{
		Class23 class23_ = new Class23(1L);
		Class23 @class = new Class23();
		value = value.ToUpper().Trim();
		int num = 0;
		if (value[0] == '-')
		{
			num = 1;
		}
		for (int i = value.Length - 1; i >= num; i--)
		{
			int num2 = (int)value[i];
			if (num2 >= 48 && num2 <= 57)
			{
				num2 -= 48;
			}
			else if (num2 >= 65 && num2 <= 90)
			{
				num2 = num2 - 65 + 10;
			}
			else
			{
				num2 = 9999999;
			}
			if (num2 >= radix)
			{
				throw new ArithmeticException("Invalid string in constructor.");
			}
			if (value[0] == '-')
			{
				num2 = -num2;
			}
			@class = Class23.smethod_4(@class, Class23.smethod_8(class23_, Class23.smethod_2(num2)));
			if (i - 1 >= num)
			{
				class23_ = Class23.smethod_8(class23_, Class23.smethod_2(radix));
			}
		}
		if (value[0] == '-')
		{
			if ((@class.uint_0[499] & 2147483648U) == 0U)
			{
				throw new ArithmeticException("Negative underflow in constructor.");
			}
		}
		else if ((@class.uint_0[499] & 2147483648U) != 0U)
		{
			throw new ArithmeticException("Positive overflow in constructor.");
		}
		this.uint_0 = new uint[500];
		for (int i = 0; i < @class.int_2; i++)
		{
			this.uint_0[i] = @class.uint_0[i];
		}
		this.int_2 = @class.int_2;
	}

	// Token: 0x06000142 RID: 322 RVA: 0x0000F54C File Offset: 0x0000D74C
	public Class23(byte[] inData)
	{
		this.int_2 = inData.Length >> 2;
		int num = inData.Length & 3;
		if (num != 0)
		{
			this.int_2++;
		}
		if (this.int_2 > 500)
		{
			throw new ArithmeticException("Byte overflow in constructor.");
		}
		this.uint_0 = new uint[500];
		int i = inData.Length - 1;
		int num2 = 0;
		while (i >= 3)
		{
			this.uint_0[num2] = (uint)(((int)inData[i - 3] << 24) + ((int)inData[i - 2] << 16) + ((int)inData[i - 1] << 8) + (int)inData[i]);
			i -= 4;
			num2++;
		}
		if (num == 1)
		{
			this.uint_0[this.int_2 - 1] = (uint)inData[0];
		}
		else if (num == 2)
		{
			this.uint_0[this.int_2 - 1] = (uint)(((int)inData[0] << 8) + (int)inData[1]);
		}
		else if (num == 3)
		{
			this.uint_0[this.int_2 - 1] = (uint)(((int)inData[0] << 16) + ((int)inData[1] << 8) + (int)inData[2]);
		}
		while (this.int_2 > 1 && this.uint_0[this.int_2 - 1] == 0U)
		{
			this.int_2--;
		}
	}

	// Token: 0x06000143 RID: 323 RVA: 0x0000F694 File Offset: 0x0000D894
	public Class23(byte[] inData, int inLen)
	{
		this.int_2 = inLen >> 2;
		int num = inLen & 3;
		if (num != 0)
		{
			this.int_2++;
		}
		if (this.int_2 > 500 || inLen > inData.Length)
		{
			throw new ArithmeticException("Byte overflow in constructor.");
		}
		this.uint_0 = new uint[500];
		int i = inLen - 1;
		int num2 = 0;
		while (i >= 3)
		{
			this.uint_0[num2] = (uint)(((int)inData[i - 3] << 24) + ((int)inData[i - 2] << 16) + ((int)inData[i - 1] << 8) + (int)inData[i]);
			i -= 4;
			num2++;
		}
		if (num == 1)
		{
			this.uint_0[this.int_2 - 1] = (uint)inData[0];
		}
		else if (num == 2)
		{
			this.uint_0[this.int_2 - 1] = (uint)(((int)inData[0] << 8) + (int)inData[1]);
		}
		else if (num == 3)
		{
			this.uint_0[this.int_2 - 1] = (uint)(((int)inData[0] << 16) + ((int)inData[1] << 8) + (int)inData[2]);
		}
		if (this.int_2 == 0)
		{
			this.int_2 = 1;
		}
		while (this.int_2 > 1 && this.uint_0[this.int_2 - 1] == 0U)
		{
			this.int_2--;
		}
	}

	// Token: 0x06000144 RID: 324 RVA: 0x0000F7F4 File Offset: 0x0000D9F4
	public Class23(uint[] inData)
	{
		this.int_2 = inData.Length;
		if (this.int_2 > 500)
		{
			throw new ArithmeticException("Byte overflow in constructor.");
		}
		this.uint_0 = new uint[500];
		int i = this.int_2 - 1;
		int num = 0;
		while (i >= 0)
		{
			this.uint_0[num] = inData[i];
			i--;
			num++;
		}
		while (this.int_2 > 1 && this.uint_0[this.int_2 - 1] == 0U)
		{
			this.int_2--;
		}
	}

	// Token: 0x06000145 RID: 325 RVA: 0x0000F8A4 File Offset: 0x0000DAA4
	public static Class23 smethod_0(long long_0)
	{
		return new Class23(long_0);
	}

	// Token: 0x06000146 RID: 326 RVA: 0x0000F8BC File Offset: 0x0000DABC
	public static Class23 smethod_1(ulong ulong_0)
	{
		return new Class23(ulong_0);
	}

	// Token: 0x06000147 RID: 327 RVA: 0x0000F8D4 File Offset: 0x0000DAD4
	public static Class23 smethod_2(int int_3)
	{
		return new Class23((long)int_3);
	}

	// Token: 0x06000148 RID: 328 RVA: 0x0000F8EC File Offset: 0x0000DAEC
	public static Class23 smethod_3(uint uint_1)
	{
		return new Class23((ulong)uint_1);
	}

	// Token: 0x06000149 RID: 329 RVA: 0x0000F904 File Offset: 0x0000DB04
	public static Class23 smethod_4(Class23 class23_0, Class23 class23_1)
	{
		Class23 @class = new Class23();
		@class.int_2 = ((class23_0.int_2 > class23_1.int_2) ? class23_0.int_2 : class23_1.int_2);
		long num = 0L;
		for (int i = 0; i < @class.int_2; i++)
		{
			long num2 = (long)((ulong)class23_0.uint_0[i] + (ulong)class23_1.uint_0[i] + (ulong)num);
			num = num2 >> 32;
			@class.uint_0[i] = (uint)(num2 & 4294967295L);
		}
		if (num != 0L && @class.int_2 < 500)
		{
			@class.uint_0[@class.int_2] = (uint)num;
			@class.int_2++;
		}
		while (@class.int_2 > 1 && @class.uint_0[@class.int_2 - 1] == 0U)
		{
			@class.int_2--;
		}
		int num3 = 499;
		if ((class23_0.uint_0[499] & 2147483648U) == (class23_1.uint_0[499] & 2147483648U) && (@class.uint_0[num3] & 2147483648U) != (class23_0.uint_0[num3] & 2147483648U))
		{
			throw new ArithmeticException();
		}
		return @class;
	}

	// Token: 0x0600014A RID: 330 RVA: 0x0000FA54 File Offset: 0x0000DC54
	public static Class23 smethod_5(Class23 class23_0)
	{
		Class23 @class = new Class23(class23_0);
		long num = 1L;
		int num2 = 0;
		while (num != 0L && num2 < 500)
		{
			long num3 = (long)((ulong)@class.uint_0[num2]);
			num3 += 1L;
			@class.uint_0[num2] = (uint)(num3 & 4294967295L);
			num = num3 >> 32;
			num2++;
		}
		if (num2 > @class.int_2)
		{
			@class.int_2 = num2;
		}
		else
		{
			while (@class.int_2 > 1 && @class.uint_0[@class.int_2 - 1] == 0U)
			{
				@class.int_2--;
			}
		}
		int num4 = 499;
		if ((class23_0.uint_0[499] & 2147483648U) == 0U && (@class.uint_0[num4] & 2147483648U) != (class23_0.uint_0[num4] & 2147483648U))
		{
			throw new ArithmeticException("Overflow in ++.");
		}
		return @class;
	}

	// Token: 0x0600014B RID: 331 RVA: 0x0000FB60 File Offset: 0x0000DD60
	public static Class23 smethod_6(Class23 class23_0, Class23 class23_1)
	{
		Class23 @class = new Class23();
		@class.int_2 = ((class23_0.int_2 > class23_1.int_2) ? class23_0.int_2 : class23_1.int_2);
		long num = 0L;
		for (int i = 0; i < @class.int_2; i++)
		{
			long num2 = (long)((ulong)class23_0.uint_0[i] - (ulong)class23_1.uint_0[i] - (ulong)num);
			@class.uint_0[i] = (uint)(num2 & 4294967295L);
			if (num2 < 0L)
			{
				num = 1L;
			}
			else
			{
				num = 0L;
			}
		}
		if (num != 0L)
		{
			for (int i = @class.int_2; i < 500; i++)
			{
				@class.uint_0[i] = uint.MaxValue;
			}
			@class.int_2 = 500;
		}
		while (@class.int_2 > 1 && @class.uint_0[@class.int_2 - 1] == 0U)
		{
			@class.int_2--;
		}
		int num3 = 499;
		if ((class23_0.uint_0[499] & 2147483648U) != (class23_1.uint_0[499] & 2147483648U) && (@class.uint_0[num3] & 2147483648U) != (class23_0.uint_0[num3] & 2147483648U))
		{
			throw new ArithmeticException();
		}
		return @class;
	}

	// Token: 0x0600014C RID: 332 RVA: 0x0000FCD0 File Offset: 0x0000DED0
	public static Class23 smethod_7(Class23 class23_0)
	{
		Class23 @class = new Class23(class23_0);
		bool flag = true;
		int num = 0;
		while (flag && num < 500)
		{
			long num2 = (long)((ulong)@class.uint_0[num]);
			num2 -= 1L;
			@class.uint_0[num] = (uint)(num2 & 4294967295L);
			if (num2 >= 0L)
			{
				flag = false;
			}
			num++;
		}
		if (num > @class.int_2)
		{
			@class.int_2 = num;
		}
		while (@class.int_2 > 1 && @class.uint_0[@class.int_2 - 1] == 0U)
		{
			@class.int_2--;
		}
		int num3 = 499;
		if ((class23_0.uint_0[499] & 2147483648U) != 0U && (@class.uint_0[num3] & 2147483648U) != (class23_0.uint_0[num3] & 2147483648U))
		{
			throw new ArithmeticException("Underflow in --.");
		}
		return @class;
	}

	// Token: 0x0600014D RID: 333 RVA: 0x0000FDD8 File Offset: 0x0000DFD8
	public static Class23 smethod_8(Class23 class23_0, Class23 class23_1)
	{
		int num = 499;
		bool flag = false;
		bool flag2 = false;
		try
		{
			if ((class23_0.uint_0[num] & 2147483648U) != 0U)
			{
				flag = true;
				class23_0 = Class23.smethod_14(class23_0);
			}
			if ((class23_1.uint_0[num] & 2147483648U) != 0U)
			{
				flag2 = true;
				class23_1 = Class23.smethod_14(class23_1);
			}
		}
		catch (Exception)
		{
		}
		Class23 @class = new Class23();
		try
		{
			for (int i = 0; i < class23_0.int_2; i++)
			{
				if (class23_0.uint_0[i] != 0U)
				{
					ulong num2 = 0UL;
					int j = 0;
					int num3 = i;
					while (j < class23_1.int_2)
					{
						ulong num4 = (ulong)class23_0.uint_0[i] * (ulong)class23_1.uint_0[j] + (ulong)@class.uint_0[num3] + num2;
						@class.uint_0[num3] = (uint)(num4 & 4294967295UL);
						num2 = num4 >> 32;
						j++;
						num3++;
					}
					if (num2 != 0UL)
					{
						@class.uint_0[i + class23_1.int_2] = (uint)num2;
					}
				}
			}
		}
		catch (Exception)
		{
			throw new ArithmeticException("Multiplication overflow.");
		}
		@class.int_2 = class23_0.int_2 + class23_1.int_2;
		if (@class.int_2 > 500)
		{
			@class.int_2 = 500;
		}
		while (@class.int_2 > 1 && @class.uint_0[@class.int_2 - 1] == 0U)
		{
			@class.int_2--;
		}
		if ((@class.uint_0[num] & 2147483648U) != 0U)
		{
			if (flag != flag2 && @class.uint_0[num] == 2147483648U)
			{
				if (@class.int_2 == 1)
				{
					return @class;
				}
				bool flag3 = true;
				int i = 0;
				while (i < @class.int_2 - 1 && flag3)
				{
					if (@class.uint_0[i] != 0U)
					{
						flag3 = false;
					}
					i++;
				}
				if (flag3)
				{
					return @class;
				}
			}
			throw new ArithmeticException("Multiplication overflow.");
		}
		Class23 result;
		if (flag != flag2)
		{
			result = Class23.smethod_14(@class);
		}
		else
		{
			result = @class;
		}
		return result;
	}

	// Token: 0x0600014E RID: 334 RVA: 0x0001002C File Offset: 0x0000E22C
	public static Class23 smethod_9(Class23 class23_0, int int_3)
	{
		Class23 @class = new Class23(class23_0);
		@class.int_2 = Class23.smethod_10(@class.uint_0, int_3);
		return @class;
	}

	// Token: 0x0600014F RID: 335 RVA: 0x00010058 File Offset: 0x0000E258
	private static int smethod_10(uint[] uint_1, int int_3)
	{
		int num = 32;
		int num2 = uint_1.Length;
		while (num2 > 1 && uint_1[num2 - 1] == 0U)
		{
			num2--;
		}
		for (int i = int_3; i > 0; i -= num)
		{
			if (i < num)
			{
				num = i;
			}
			ulong num3 = 0UL;
			for (int j = 0; j < num2; j++)
			{
				ulong num4 = (ulong)uint_1[j] << num;
				num4 |= num3;
				uint_1[j] = (uint)(num4 & 4294967295UL);
				num3 = num4 >> 32;
			}
			if (num3 != 0UL && num2 + 1 <= uint_1.Length)
			{
				uint_1[num2] = (uint)num3;
				num2++;
			}
		}
		return num2;
	}

	// Token: 0x06000150 RID: 336 RVA: 0x0001010C File Offset: 0x0000E30C
	public static Class23 smethod_11(Class23 class23_0, int int_3)
	{
		Class23 @class = new Class23(class23_0);
		@class.int_2 = Class23.smethod_12(@class.uint_0, int_3);
		if ((class23_0.uint_0[499] & 2147483648U) != 0U)
		{
			int i;
			for (i = 499; i >= @class.int_2; i--)
			{
				@class.uint_0[i] = uint.MaxValue;
			}
			uint num = 2147483648U;
			i = 0;
			while (i < 32 && (@class.uint_0[@class.int_2 - 1] & num) == 0U)
			{
				@class.uint_0[@class.int_2 - 1] |= num;
				num >>= 1;
				i++;
			}
			@class.int_2 = 500;
		}
		return @class;
	}

	// Token: 0x06000151 RID: 337 RVA: 0x000101CC File Offset: 0x0000E3CC
	private static int smethod_12(uint[] uint_1, int int_3)
	{
		int num = 32;
		int num2 = 0;
		int num3 = uint_1.Length;
		while (num3 > 1 && uint_1[num3 - 1] == 0U)
		{
			num3--;
		}
		for (int i = int_3; i > 0; i -= num)
		{
			if (i < num)
			{
				num = i;
				num2 = 32 - num;
			}
			ulong num4 = 0UL;
			for (int j = num3 - 1; j >= 0; j--)
			{
				ulong num5 = (ulong)uint_1[j] >> num;
				num5 |= num4;
				num4 = (ulong)uint_1[j] << num2;
				uint_1[j] = (uint)num5;
			}
		}
		while (num3 > 1 && uint_1[num3 - 1] == 0U)
		{
			num3--;
		}
		return num3;
	}

	// Token: 0x06000152 RID: 338 RVA: 0x00010284 File Offset: 0x0000E484
	public static Class23 smethod_13(Class23 class23_0)
	{
		Class23 @class = new Class23(class23_0);
		for (int i = 0; i < 500; i++)
		{
			@class.uint_0[i] = ~class23_0.uint_0[i];
		}
		@class.int_2 = 500;
		while (@class.int_2 > 1 && @class.uint_0[@class.int_2 - 1] == 0U)
		{
			@class.int_2--;
		}
		return @class;
	}

	// Token: 0x06000153 RID: 339 RVA: 0x00010300 File Offset: 0x0000E500
	public static Class23 smethod_14(Class23 class23_0)
	{
		Class23 result;
		if (class23_0.int_2 == 1 && class23_0.uint_0[0] == 0U)
		{
			result = new Class23();
		}
		else
		{
			Class23 @class = new Class23(class23_0);
			for (int i = 0; i < 500; i++)
			{
				@class.uint_0[i] = ~class23_0.uint_0[i];
			}
			long num = 1L;
			int num2 = 0;
			while (num != 0L && num2 < 500)
			{
				long num3 = (long)((ulong)@class.uint_0[num2]);
				num3 += 1L;
				@class.uint_0[num2] = (uint)(num3 & 4294967295L);
				num = num3 >> 32;
				num2++;
			}
			if ((class23_0.uint_0[499] & 2147483648U) == (@class.uint_0[499] & 2147483648U))
			{
				throw new ArithmeticException("Overflow in negation.\n");
			}
			@class.int_2 = 500;
			while (@class.int_2 > 1 && @class.uint_0[@class.int_2 - 1] == 0U)
			{
				@class.int_2--;
			}
			result = @class;
		}
		return result;
	}

	// Token: 0x06000154 RID: 340 RVA: 0x000031D7 File Offset: 0x000013D7
	public static bool smethod_15(Class23 class23_0, Class23 class23_1)
	{
		return class23_0.Equals(class23_1);
	}

	// Token: 0x06000155 RID: 341 RVA: 0x000031E0 File Offset: 0x000013E0
	public static bool smethod_16(Class23 class23_0, Class23 class23_1)
	{
		return !class23_0.Equals(class23_1);
	}

	// Token: 0x06000156 RID: 342 RVA: 0x00010440 File Offset: 0x0000E640
	public override bool Equals(object o)
	{
		Class23 @class = (Class23)o;
		bool result;
		if (this.int_2 != @class.int_2)
		{
			result = false;
		}
		else
		{
			for (int i = 0; i < this.int_2; i++)
			{
				if (this.uint_0[i] != @class.uint_0[i])
				{
					return false;
				}
			}
			result = true;
		}
		return result;
	}

	// Token: 0x06000157 RID: 343 RVA: 0x00010498 File Offset: 0x0000E698
	public override int GetHashCode()
	{
		return this.ToString().GetHashCode();
	}

	// Token: 0x06000158 RID: 344 RVA: 0x000104B4 File Offset: 0x0000E6B4
	public static bool smethod_17(Class23 class23_0, Class23 class23_1)
	{
		int num = 499;
		bool result;
		if ((class23_0.uint_0[499] & 2147483648U) != 0U && (class23_1.uint_0[num] & 2147483648U) == 0U)
		{
			result = false;
		}
		else if ((class23_0.uint_0[num] & 2147483648U) == 0U && (class23_1.uint_0[num] & 2147483648U) != 0U)
		{
			result = true;
		}
		else
		{
			int num2 = (class23_0.int_2 > class23_1.int_2) ? class23_0.int_2 : class23_1.int_2;
			num = num2 - 1;
			while (num >= 0 && class23_0.uint_0[num] == class23_1.uint_0[num])
			{
				num--;
			}
			result = (num >= 0 && class23_0.uint_0[num] > class23_1.uint_0[num]);
		}
		return result;
	}

	// Token: 0x06000159 RID: 345 RVA: 0x00010594 File Offset: 0x0000E794
	public static bool smethod_18(Class23 class23_0, Class23 class23_1)
	{
		int num = 499;
		bool result;
		if ((class23_0.uint_0[499] & 2147483648U) != 0U && (class23_1.uint_0[num] & 2147483648U) == 0U)
		{
			result = true;
		}
		else if ((class23_0.uint_0[num] & 2147483648U) == 0U && (class23_1.uint_0[num] & 2147483648U) != 0U)
		{
			result = false;
		}
		else
		{
			int num2 = (class23_0.int_2 > class23_1.int_2) ? class23_0.int_2 : class23_1.int_2;
			num = num2 - 1;
			while (num >= 0 && class23_0.uint_0[num] == class23_1.uint_0[num])
			{
				num--;
			}
			result = (num >= 0 && class23_0.uint_0[num] < class23_1.uint_0[num]);
		}
		return result;
	}

	// Token: 0x0600015A RID: 346 RVA: 0x000031EC File Offset: 0x000013EC
	public static bool smethod_19(Class23 class23_0, Class23 class23_1)
	{
		return Class23.smethod_15(class23_0, class23_1) || Class23.smethod_17(class23_0, class23_1);
	}

	// Token: 0x0600015B RID: 347 RVA: 0x00003201 File Offset: 0x00001401
	public static bool smethod_20(Class23 class23_0, Class23 class23_1)
	{
		return Class23.smethod_15(class23_0, class23_1) || Class23.smethod_18(class23_0, class23_1);
	}

	// Token: 0x0600015C RID: 348 RVA: 0x00010674 File Offset: 0x0000E874
	private static void smethod_21(Class23 class23_0, Class23 class23_1, Class23 class23_2, Class23 class23_3)
	{
		uint[] array = new uint[500];
		int num = class23_0.int_2 + 1;
		uint[] array2 = new uint[num];
		uint num2 = 2147483648U;
		uint num3 = class23_1.uint_0[class23_1.int_2 - 1];
		int num4 = 0;
		int num5 = 0;
		while (num2 != 0U && (num3 & num2) == 0U)
		{
			num4++;
			num2 >>= 1;
		}
		for (int i = 0; i < class23_0.int_2; i++)
		{
			array2[i] = class23_0.uint_0[i];
		}
		Class23.smethod_10(array2, num4);
		class23_1 = Class23.smethod_9(class23_1, num4);
		int j = num - class23_1.int_2;
		int num6 = num - 1;
		ulong num7 = (ulong)class23_1.uint_0[class23_1.int_2 - 1];
		ulong num8 = (ulong)class23_1.uint_0[class23_1.int_2 - 2];
		int num9 = class23_1.int_2 + 1;
		uint[] array3 = new uint[num9];
		while (j > 0)
		{
			ulong num10 = ((ulong)array2[num6] << 32) + (ulong)array2[num6 - 1];
			ulong num11 = num10 / num7;
			ulong num12 = num10 % num7;
			bool flag = false;
			while (!flag)
			{
				flag = true;
				if (num11 == 4294967296UL || num11 * num8 > (num12 << 32) + (ulong)array2[num6 - 2])
				{
					num11 -= 1UL;
					num12 += num7;
					if (num12 < 4294967296UL)
					{
						flag = false;
					}
				}
			}
			for (int k = 0; k < num9; k++)
			{
				array3[k] = array2[num6 - k];
			}
			Class23 @class = new Class23(array3);
			Class23 class2 = Class23.smethod_8(class23_1, Class23.smethod_0((long)num11));
			while (Class23.smethod_17(class2, @class))
			{
				num11 -= 1UL;
				class2 = Class23.smethod_6(class2, class23_1);
			}
			Class23 class3 = Class23.smethod_6(@class, class2);
			for (int k = 0; k < num9; k++)
			{
				array2[num6 - k] = class3.uint_0[class23_1.int_2 - k];
			}
			array[num5++] = (uint)num11;
			num6--;
			j--;
		}
		class23_2.int_2 = num5;
		int l = 0;
		int m = class23_2.int_2 - 1;
		while (m >= 0)
		{
			class23_2.uint_0[l] = array[m];
			m--;
			l++;
		}
		while (l < 500)
		{
			class23_2.uint_0[l] = 0U;
			l++;
		}
		while (class23_2.int_2 > 1 && class23_2.uint_0[class23_2.int_2 - 1] == 0U)
		{
			class23_2.int_2--;
		}
		if (class23_2.int_2 == 0)
		{
			class23_2.int_2 = 1;
		}
		class23_3.int_2 = Class23.smethod_12(array2, num4);
		for (l = 0; l < class23_3.int_2; l++)
		{
			class23_3.uint_0[l] = array2[l];
		}
		while (l < 500)
		{
			class23_3.uint_0[l] = 0U;
			l++;
		}
	}

	// Token: 0x0600015D RID: 349 RVA: 0x00010984 File Offset: 0x0000EB84
	private static void smethod_22(Class23 class23_0, Class23 class23_1, Class23 class23_2, Class23 class23_3)
	{
		uint[] array = new uint[500];
		int num = 0;
		int i;
		for (i = 0; i < 500; i++)
		{
			class23_3.uint_0[i] = class23_0.uint_0[i];
		}
		class23_3.int_2 = class23_0.int_2;
		while (class23_3.int_2 > 1 && class23_3.uint_0[class23_3.int_2 - 1] == 0U)
		{
			class23_3.int_2--;
		}
		ulong num2 = (ulong)class23_1.uint_0[0];
		int j = class23_3.int_2 - 1;
		ulong num3 = (ulong)class23_3.uint_0[j];
		if (num3 >= num2)
		{
			ulong num4 = num3 / num2;
			array[num++] = (uint)num4;
			class23_3.uint_0[j] = (uint)(num3 % num2);
		}
		j--;
		while (j >= 0)
		{
			num3 = ((ulong)class23_3.uint_0[j + 1] << 32) + (ulong)class23_3.uint_0[j];
			ulong num4 = num3 / num2;
			array[num++] = (uint)num4;
			class23_3.uint_0[j + 1] = 0U;
			class23_3.uint_0[j--] = (uint)(num3 % num2);
		}
		class23_2.int_2 = num;
		int k = 0;
		i = class23_2.int_2 - 1;
		while (i >= 0)
		{
			class23_2.uint_0[k] = array[i];
			i--;
			k++;
		}
		while (k < 500)
		{
			class23_2.uint_0[k] = 0U;
			k++;
		}
		while (class23_2.int_2 > 1 && class23_2.uint_0[class23_2.int_2 - 1] == 0U)
		{
			class23_2.int_2--;
		}
		if (class23_2.int_2 == 0)
		{
			class23_2.int_2 = 1;
		}
		while (class23_3.int_2 > 1 && class23_3.uint_0[class23_3.int_2 - 1] == 0U)
		{
			class23_3.int_2--;
		}
	}

	// Token: 0x0600015E RID: 350 RVA: 0x00010B70 File Offset: 0x0000ED70
	public static Class23 smethod_23(Class23 class23_0, Class23 class23_1)
	{
		Class23 @class = new Class23();
		Class23 class23_2 = new Class23();
		int num = 499;
		bool flag = false;
		bool flag2 = false;
		if ((class23_0.uint_0[499] & 2147483648U) != 0U)
		{
			class23_0 = Class23.smethod_14(class23_0);
			flag2 = true;
		}
		if ((class23_1.uint_0[num] & 2147483648U) != 0U)
		{
			class23_1 = Class23.smethod_14(class23_1);
			flag = true;
		}
		Class23 result;
		if (Class23.smethod_18(class23_0, class23_1))
		{
			result = @class;
		}
		else
		{
			if (class23_1.int_2 == 1)
			{
				Class23.smethod_22(class23_0, class23_1, @class, class23_2);
			}
			else
			{
				Class23.smethod_21(class23_0, class23_1, @class, class23_2);
			}
			if (flag2 != flag)
			{
				result = Class23.smethod_14(@class);
			}
			else
			{
				result = @class;
			}
		}
		return result;
	}

	// Token: 0x0600015F RID: 351 RVA: 0x00010C20 File Offset: 0x0000EE20
	public static Class23 smethod_24(Class23 class23_0, Class23 class23_1)
	{
		Class23 class23_2 = new Class23();
		Class23 @class = new Class23(class23_0);
		int num = 499;
		bool flag = false;
		if ((class23_0.uint_0[499] & 2147483648U) != 0U)
		{
			class23_0 = Class23.smethod_14(class23_0);
			flag = true;
		}
		if ((class23_1.uint_0[num] & 2147483648U) != 0U)
		{
			class23_1 = Class23.smethod_14(class23_1);
		}
		Class23 result;
		if (Class23.smethod_18(class23_0, class23_1))
		{
			result = @class;
		}
		else
		{
			if (class23_1.int_2 == 1)
			{
				Class23.smethod_22(class23_0, class23_1, class23_2, @class);
			}
			else
			{
				Class23.smethod_21(class23_0, class23_1, class23_2, @class);
			}
			if (flag)
			{
				result = Class23.smethod_14(@class);
			}
			else
			{
				result = @class;
			}
		}
		return result;
	}

	// Token: 0x06000160 RID: 352 RVA: 0x00010CCC File Offset: 0x0000EECC
	public static Class23 smethod_25(Class23 class23_0, Class23 class23_1)
	{
		Class23 @class = new Class23();
		int num = (class23_0.int_2 > class23_1.int_2) ? class23_0.int_2 : class23_1.int_2;
		for (int i = 0; i < num; i++)
		{
			uint num2 = class23_0.uint_0[i] & class23_1.uint_0[i];
			@class.uint_0[i] = num2;
		}
		@class.int_2 = 500;
		while (@class.int_2 > 1 && @class.uint_0[@class.int_2 - 1] == 0U)
		{
			@class.int_2--;
		}
		return @class;
	}

	// Token: 0x06000161 RID: 353 RVA: 0x00010D6C File Offset: 0x0000EF6C
	public static Class23 smethod_26(Class23 class23_0, Class23 class23_1)
	{
		Class23 @class = new Class23();
		int num = (class23_0.int_2 > class23_1.int_2) ? class23_0.int_2 : class23_1.int_2;
		for (int i = 0; i < num; i++)
		{
			uint num2 = class23_0.uint_0[i] | class23_1.uint_0[i];
			@class.uint_0[i] = num2;
		}
		@class.int_2 = 500;
		while (@class.int_2 > 1 && @class.uint_0[@class.int_2 - 1] == 0U)
		{
			@class.int_2--;
		}
		return @class;
	}

	// Token: 0x06000162 RID: 354 RVA: 0x00010E0C File Offset: 0x0000F00C
	public static Class23 smethod_27(Class23 class23_0, Class23 class23_1)
	{
		Class23 @class = new Class23();
		int num = (class23_0.int_2 > class23_1.int_2) ? class23_0.int_2 : class23_1.int_2;
		for (int i = 0; i < num; i++)
		{
			uint num2 = class23_0.uint_0[i] ^ class23_1.uint_0[i];
			@class.uint_0[i] = num2;
		}
		@class.int_2 = 500;
		while (@class.int_2 > 1 && @class.uint_0[@class.int_2 - 1] == 0U)
		{
			@class.int_2--;
		}
		return @class;
	}

	// Token: 0x06000163 RID: 355 RVA: 0x00010EAC File Offset: 0x0000F0AC
	public Class23 method_0(Class23 class23_0)
	{
		Class23 result;
		if (Class23.smethod_17(this, class23_0))
		{
			result = new Class23(this);
		}
		else
		{
			result = new Class23(class23_0);
		}
		return result;
	}

	// Token: 0x06000164 RID: 356 RVA: 0x00010ED8 File Offset: 0x0000F0D8
	public Class23 method_1(Class23 class23_0)
	{
		Class23 result;
		if (Class23.smethod_18(this, class23_0))
		{
			result = new Class23(this);
		}
		else
		{
			result = new Class23(class23_0);
		}
		return result;
	}

	// Token: 0x06000165 RID: 357 RVA: 0x00010F04 File Offset: 0x0000F104
	public Class23 method_2()
	{
		Class23 result;
		if ((this.uint_0[499] & 2147483648U) != 0U)
		{
			result = Class23.smethod_14(this);
		}
		else
		{
			result = new Class23(this);
		}
		return result;
	}

	// Token: 0x06000166 RID: 358 RVA: 0x00010F3C File Offset: 0x0000F13C
	public override string ToString()
	{
		return this.method_3(10);
	}

	// Token: 0x06000167 RID: 359 RVA: 0x00010F54 File Offset: 0x0000F154
	public string method_3(int int_3)
	{
		if (int_3 < 2 || int_3 > 36)
		{
			throw new ArgumentException("Radix must be >= 2 and <= 36");
		}
		string text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
		string text2 = "";
		Class23 @class = this;
		bool flag = false;
		if ((@class.uint_0[499] & 2147483648U) != 0U)
		{
			flag = true;
			try
			{
				@class = Class23.smethod_14(@class);
			}
			catch (Exception)
			{
			}
		}
		Class23 class2 = new Class23();
		Class23 class3 = new Class23();
		Class23 class23_ = new Class23((long)int_3);
		if (@class.int_2 == 1 && @class.uint_0[0] == 0U)
		{
			text2 = "0";
		}
		else
		{
			while (@class.int_2 > 1 || (@class.int_2 == 1 && @class.uint_0[0] != 0U))
			{
				Class23.smethod_22(@class, class23_, class2, class3);
				if (class3.uint_0[0] < 10U)
				{
					text2 = class3.uint_0[0] + text2;
				}
				else
				{
					text2 = text[(int)(class3.uint_0[0] - 10U)] + text2;
				}
				@class = class2;
			}
			if (flag)
			{
				text2 = "-" + text2;
			}
		}
		return text2;
	}

	// Token: 0x06000168 RID: 360 RVA: 0x000110A4 File Offset: 0x0000F2A4
	public string method_4()
	{
		string text = this.uint_0[this.int_2 - 1].ToString("X");
		for (int i = this.int_2 - 2; i >= 0; i--)
		{
			text += this.uint_0[i].ToString("X8");
		}
		return text;
	}

	// Token: 0x06000169 RID: 361 RVA: 0x00011108 File Offset: 0x0000F308
	public Class23 method_5(Class23 class23_0, Class23 class23_1)
	{
		if ((class23_0.uint_0[499] & 2147483648U) != 0U)
		{
			throw new ArithmeticException("Positive exponents only.");
		}
		Class23 @class = Class23.smethod_2(1);
		bool flag = false;
		Class23 class2;
		if ((this.uint_0[499] & 2147483648U) != 0U)
		{
			class2 = Class23.smethod_24(Class23.smethod_14(this), class23_1);
			flag = true;
		}
		else
		{
			class2 = Class23.smethod_24(this, class23_1);
		}
		if ((class23_1.uint_0[499] & 2147483648U) != 0U)
		{
			class23_1 = Class23.smethod_14(class23_1);
		}
		Class23 class3 = new Class23();
		int num = class23_1.int_2 << 1;
		class3.uint_0[num] = 1U;
		class3.int_2 = num + 1;
		class3 = Class23.smethod_23(class3, class23_1);
		int num2 = class23_0.method_9();
		int num3 = 0;
		for (int i = 0; i < class23_0.int_2; i++)
		{
			uint num4 = 1U;
			int j = 0;
			while (j < 32)
			{
				if ((class23_0.uint_0[i] & num4) != 0U)
				{
					@class = this.method_6(Class23.smethod_8(@class, class2), class23_1, class3);
				}
				num4 <<= 1;
				class2 = this.method_6(Class23.smethod_8(class2, class2), class23_1, class3);
				if (class2.int_2 != 1 || class2.uint_0[0] != 1U)
				{
					num3++;
					if (num3 == num2)
					{
						break;
					}
					j++;
				}
				else
				{
					if (flag && (class23_0.uint_0[0] & 1U) != 0U)
					{
						return Class23.smethod_14(@class);
					}
					return @class;
				}
			}
		}
		if (flag && (class23_0.uint_0[0] & 1U) != 0U)
		{
			return Class23.smethod_14(@class);
		}
		return @class;
	}

	// Token: 0x0600016A RID: 362 RVA: 0x000112A8 File Offset: 0x0000F4A8
	private Class23 method_6(Class23 class23_0, Class23 class23_1, Class23 class23_2)
	{
		int num = class23_1.int_2;
		int num2 = num + 1;
		int num3 = num - 1;
		Class23 @class = new Class23();
		int i = num3;
		int num4 = 0;
		while (i < class23_0.int_2)
		{
			@class.uint_0[num4] = class23_0.uint_0[i];
			i++;
			num4++;
		}
		@class.int_2 = class23_0.int_2 - num3;
		if (@class.int_2 <= 0)
		{
			@class.int_2 = 1;
		}
		Class23 class2 = Class23.smethod_8(@class, class23_2);
		Class23 class3 = new Class23();
		i = num2;
		num4 = 0;
		while (i < class2.int_2)
		{
			class3.uint_0[num4] = class2.uint_0[i];
			i++;
			num4++;
		}
		class3.int_2 = class2.int_2 - num2;
		if (class3.int_2 <= 0)
		{
			class3.int_2 = 1;
		}
		Class23 class4 = new Class23();
		int num5 = (class23_0.int_2 > num2) ? num2 : class23_0.int_2;
		for (i = 0; i < num5; i++)
		{
			class4.uint_0[i] = class23_0.uint_0[i];
		}
		class4.int_2 = num5;
		Class23 class5 = new Class23();
		for (i = 0; i < class3.int_2; i++)
		{
			if (class3.uint_0[i] != 0U)
			{
				ulong num6 = 0UL;
				int num7 = i;
				num4 = 0;
				while (num4 < class23_1.int_2 && num7 < num2)
				{
					ulong num8 = (ulong)class3.uint_0[i] * (ulong)class23_1.uint_0[num4] + (ulong)class5.uint_0[num7] + num6;
					class5.uint_0[num7] = (uint)(num8 & 4294967295UL);
					num6 = num8 >> 32;
					num4++;
					num7++;
				}
				if (num7 < num2)
				{
					class5.uint_0[num7] = (uint)num6;
				}
			}
		}
		class5.int_2 = num2;
		while (class5.int_2 > 1 && class5.uint_0[class5.int_2 - 1] == 0U)
		{
			class5.int_2--;
		}
		class4 = Class23.smethod_6(class4, class5);
		if ((class4.uint_0[499] & 2147483648U) != 0U)
		{
			Class23 class6 = new Class23();
			class6.uint_0[num2] = 1U;
			class6.int_2 = num2 + 1;
			class4 = Class23.smethod_4(class4, class6);
		}
		while (Class23.smethod_19(class4, class23_1))
		{
			class4 = Class23.smethod_6(class4, class23_1);
		}
		return class4;
	}

	// Token: 0x0600016B RID: 363 RVA: 0x00011544 File Offset: 0x0000F744
	public Class23 method_7(Class23 class23_0)
	{
		Class23 @class;
		if ((this.uint_0[499] & 2147483648U) != 0U)
		{
			@class = Class23.smethod_14(this);
		}
		else
		{
			@class = this;
		}
		Class23 class2;
		if ((class23_0.uint_0[499] & 2147483648U) != 0U)
		{
			class2 = Class23.smethod_14(class23_0);
		}
		else
		{
			class2 = class23_0;
		}
		Class23 class3 = class2;
		while (@class.int_2 > 1 || (@class.int_2 == 1 && @class.uint_0[0] != 0U))
		{
			class3 = @class;
			@class = Class23.smethod_24(class2, @class);
			class2 = class3;
		}
		return class3;
	}

	// Token: 0x0600016C RID: 364 RVA: 0x000115D4 File Offset: 0x0000F7D4
	public void method_8(int int_3, Class31 class31_0)
	{
		int num = int_3 >> 5;
		int num2 = int_3 & 31;
		if (num2 != 0)
		{
			num++;
		}
		if (num > 500)
		{
			throw new ArithmeticException("Number of required bits > maxLength.");
		}
		for (int i = 0; i < num; i++)
		{
			this.uint_0[i] = class31_0.method_0();
		}
		for (int i = num; i < 500; i++)
		{
			this.uint_0[i] = 0U;
		}
		if (num2 != 0)
		{
			uint num3 = 1U << num2 - 1;
			this.uint_0[num - 1] |= num3;
			num3 = uint.MaxValue >> 32 - num2;
			this.uint_0[num - 1] &= num3;
		}
		else
		{
			this.uint_0[num - 1] |= 2147483648U;
		}
		this.int_2 = num;
		if (this.int_2 == 0)
		{
			this.int_2 = 1;
		}
	}

	// Token: 0x0600016D RID: 365 RVA: 0x000116D0 File Offset: 0x0000F8D0
	public int method_9()
	{
		while (this.int_2 > 1 && this.uint_0[this.int_2 - 1] == 0U)
		{
			this.int_2--;
		}
		uint num = this.uint_0[this.int_2 - 1];
		uint num2 = 2147483648U;
		int num3 = 32;
		while (num3 > 0 && (num & num2) == 0U)
		{
			num3--;
			num2 >>= 1;
		}
		return num3 + (this.int_2 - 1 << 5);
	}

	// Token: 0x0600016E RID: 366 RVA: 0x00011758 File Offset: 0x0000F958
	public bool method_10(int int_3)
	{
		Class23 @class;
		if ((this.uint_0[499] & 2147483648U) != 0U)
		{
			@class = Class23.smethod_14(this);
		}
		else
		{
			@class = this;
		}
		if (@class.int_2 == 1)
		{
			if (@class.uint_0[0] == 0U || @class.uint_0[0] == 1U)
			{
				return false;
			}
			if (@class.uint_0[0] == 2U || @class.uint_0[0] == 3U)
			{
				return true;
			}
		}
		bool result;
		if ((@class.uint_0[0] & 1U) == 0U)
		{
			result = false;
		}
		else
		{
			int num = @class.method_9();
			Class23 class2 = new Class23();
			Class23 class23_ = Class23.smethod_6(@class, new Class23(1L));
			Class31 class3 = new Class31();
			for (int i = 0; i < int_3; i++)
			{
				bool flag = false;
				while (!flag)
				{
					int j;
					for (j = 0; j < 2; j = class3.method_1() * num)
					{
					}
					class2.method_8(j, class3);
					int num2 = class2.int_2;
					if (num2 > 1 || (num2 == 1 && class2.uint_0[0] != 1U))
					{
						flag = true;
					}
				}
				Class23 class4 = class2.method_7(@class);
				if (class4.int_2 == 1 && class4.uint_0[0] != 1U)
				{
					return false;
				}
				Class23 class5 = class2.method_5(class23_, @class);
				int num3 = class5.int_2;
				if (num3 > 1 || (num3 == 1 && class5.uint_0[0] != 1U))
				{
					return false;
				}
			}
			result = true;
		}
		return result;
	}

	// Token: 0x0600016F RID: 367 RVA: 0x000118F0 File Offset: 0x0000FAF0
	public bool method_11(int int_3)
	{
		Class23 @class;
		if ((this.uint_0[499] & 2147483648U) != 0U)
		{
			@class = Class23.smethod_14(this);
		}
		else
		{
			@class = this;
		}
		if (@class.int_2 == 1)
		{
			if (@class.uint_0[0] == 0U || @class.uint_0[0] == 1U)
			{
				return false;
			}
			if (@class.uint_0[0] == 2U || @class.uint_0[0] == 3U)
			{
				return true;
			}
		}
		bool result;
		if ((@class.uint_0[0] & 1U) == 0U)
		{
			result = false;
		}
		else
		{
			Class23 class2 = Class23.smethod_6(@class, new Class23(1L));
			int num = 0;
			int i = 0;
			IL_EF:
			while (i < class2.int_2)
			{
				uint num2 = 1U;
				for (int j = 0; j < 32; j++)
				{
					if ((class2.uint_0[i] & num2) != 0U)
					{
						i = class2.int_2;
						IL_E9:
						i++;
						goto IL_EF;
					}
					num2 <<= 1;
					num++;
				}
				goto IL_E9;
			}
			Class23 class23_ = Class23.smethod_11(class2, num);
			int num3 = @class.method_9();
			Class23 class3 = new Class23();
			Class31 class4 = new Class31();
			for (int k = 0; k < int_3; k++)
			{
				bool flag = false;
				while (!flag)
				{
					int l;
					for (l = 0; l < 2; l = (int)(class4.method_2() * (float)num3))
					{
					}
					class3.method_8(l, class4);
					int num4 = class3.int_2;
					if (num4 > 1 || (num4 == 1 && class3.uint_0[0] != 1U))
					{
						flag = true;
					}
				}
				Class23 class5 = class3.method_7(@class);
				if (class5.int_2 == 1 && class5.uint_0[0] != 1U)
				{
					return false;
				}
				Class23 class6 = class3.method_5(class23_, @class);
				bool flag2 = false;
				if (class6.int_2 == 1 && class6.uint_0[0] == 1U)
				{
					flag2 = true;
				}
				int num5 = 0;
				while (!flag2 && num5 < num)
				{
					if (Class23.smethod_15(class6, class2))
					{
						flag2 = true;
						break;
					}
					class6 = Class23.smethod_24(Class23.smethod_8(class6, class6), @class);
					num5++;
				}
				if (!flag2)
				{
					return false;
				}
			}
			result = true;
		}
		return result;
	}

	// Token: 0x06000170 RID: 368 RVA: 0x00011B30 File Offset: 0x0000FD30
	public bool method_12(int int_3)
	{
		Class23 @class;
		if ((this.uint_0[499] & 2147483648U) != 0U)
		{
			@class = Class23.smethod_14(this);
		}
		else
		{
			@class = this;
		}
		if (@class.int_2 == 1)
		{
			if (@class.uint_0[0] == 0U || @class.uint_0[0] == 1U)
			{
				return false;
			}
			if (@class.uint_0[0] == 2U || @class.uint_0[0] == 3U)
			{
				return true;
			}
		}
		bool result;
		if ((@class.uint_0[0] & 1U) == 0U)
		{
			result = false;
		}
		else
		{
			int num = @class.method_9();
			Class23 class2 = new Class23();
			Class23 class3 = Class23.smethod_6(@class, Class23.smethod_2(1));
			Class23 class23_ = Class23.smethod_11(class3, 1);
			Class31 class4 = new Class31();
			for (int i = 0; i < int_3; i++)
			{
				bool flag = false;
				while (!flag)
				{
					int j;
					for (j = 0; j < 2; j = (int)(class4.method_2() * (float)num))
					{
					}
					class2.method_8(j, class4);
					int num2 = class2.int_2;
					if (num2 > 1 || (num2 == 1 && class2.uint_0[0] != 1U))
					{
						flag = true;
					}
				}
				Class23 class5 = class2.method_7(@class);
				if (class5.int_2 == 1 && class5.uint_0[0] != 1U)
				{
					return false;
				}
				Class23 class23_2 = class2.method_5(class23_, @class);
				if (Class23.smethod_15(class23_2, class3))
				{
					class23_2 = Class23.smethod_2(-1);
				}
				Class23 class23_3 = Class23.smethod_2(Class23.smethod_28(class2, @class));
				if (Class23.smethod_16(class23_2, class23_3))
				{
					return false;
				}
			}
			result = true;
		}
		return result;
	}

	// Token: 0x06000171 RID: 369 RVA: 0x00011CD8 File Offset: 0x0000FED8
	public bool method_13()
	{
		Class23 @class;
		if ((this.uint_0[499] & 2147483648U) != 0U)
		{
			@class = Class23.smethod_14(this);
		}
		else
		{
			@class = this;
		}
		if (@class.int_2 == 1)
		{
			if (@class.uint_0[0] == 0U || @class.uint_0[0] == 1U)
			{
				return false;
			}
			if (@class.uint_0[0] == 2U || @class.uint_0[0] == 3U)
			{
				return true;
			}
		}
		return (@class.uint_0[0] & 1U) != 0U && this.method_14(@class);
	}

	// Token: 0x06000172 RID: 370 RVA: 0x00011D78 File Offset: 0x0000FF78
	private bool method_14(Class23 class23_0)
	{
		long num = 5L;
		long num2 = -1L;
		long num3 = 0L;
		bool flag = false;
		while (!flag)
		{
			int num4 = Class23.smethod_28(Class23.smethod_0(num), class23_0);
			if (num4 != -1)
			{
				if (num4 != 0 || !Class23.smethod_18(Class23.smethod_0(Math.Abs(num)), class23_0))
				{
					if (num3 == 20L)
					{
						Class23 @class = class23_0.method_25();
						if (Class23.smethod_15(Class23.smethod_8(@class, @class), class23_0))
						{
							return false;
						}
					}
					num = (Math.Abs(num) + 2L) * num2;
					num2 = -num2;
					goto IL_A7;
				}
				return false;
			}
			flag = true;
			IL_A7:
			num3 += 1L;
		}
		long num5 = 1L - num >> 2;
		Class23 class2 = Class23.smethod_4(class23_0, Class23.smethod_2(1));
		int num6 = 0;
		int i = 0;
		IL_126:
		while (i < class2.int_2)
		{
			uint num7 = 1U;
			for (int j = 0; j < 32; j++)
			{
				if ((class2.uint_0[i] & num7) != 0U)
				{
					i = class2.int_2;
					IL_120:
					i++;
					goto IL_126;
				}
				num7 <<= 1;
				num6++;
			}
			goto IL_120;
		}
		Class23 class23_ = Class23.smethod_11(class2, num6);
		Class23 class3 = new Class23();
		int num8 = class23_0.int_2 << 1;
		class3.uint_0[num8] = 1U;
		class3.int_2 = num8 + 1;
		class3 = Class23.smethod_23(class3, class23_0);
		Class23[] array = Class23.smethod_31(Class23.smethod_2(1), Class23.smethod_0(num5), class23_, class23_0, class3, 0);
		bool flag2 = false;
		if ((array[0].int_2 == 1 && array[0].uint_0[0] == 0U) || (array[1].int_2 == 1 && array[1].uint_0[0] == 0U))
		{
			flag2 = true;
		}
		for (int j = 1; j < num6; j++)
		{
			if (!flag2)
			{
				array[1] = class23_0.method_6(Class23.smethod_8(array[1], array[1]), class23_0, class3);
				array[1] = Class23.smethod_24(Class23.smethod_6(array[1], Class23.smethod_9(array[2], 1)), class23_0);
				if (array[1].int_2 == 1 && array[1].uint_0[0] == 0U)
				{
					flag2 = true;
				}
			}
			array[2] = class23_0.method_6(Class23.smethod_8(array[2], array[2]), class23_0, class3);
		}
		if (flag2)
		{
			Class23 class4 = class23_0.method_7(Class23.smethod_0(num5));
			if (class4.int_2 == 1 && class4.uint_0[0] == 1U)
			{
				if ((array[2].uint_0[499] & 2147483648U) != 0U)
				{
					Class23[] array2;
					(array2 = array)[2] = Class23.smethod_4(array2[2], class23_0);
				}
				Class23 class5 = Class23.smethod_24(Class23.smethod_0(num5 * (long)Class23.smethod_28(Class23.smethod_0(num5), class23_0)), class23_0);
				if ((class5.uint_0[499] & 2147483648U) != 0U)
				{
					class5 = Class23.smethod_4(class5, class23_0);
				}
				if (Class23.smethod_16(array[2], class5))
				{
					flag2 = false;
				}
			}
		}
		return flag2;
	}

	// Token: 0x06000173 RID: 371 RVA: 0x000120AC File Offset: 0x000102AC
	public bool method_15(int int_3)
	{
		Class23 @class;
		if ((this.uint_0[499] & 2147483648U) != 0U)
		{
			@class = Class23.smethod_14(this);
		}
		else
		{
			@class = this;
		}
		for (int i = 0; i < Class23.int_1.Length; i++)
		{
			Class23 class2 = Class23.smethod_2(Class23.int_1[i]);
			if (Class23.smethod_19(class2, @class))
			{
				break;
			}
			Class23 class3 = Class23.smethod_24(@class, class2);
			if (class3.method_17() == 0)
			{
				return false;
			}
		}
		return @class.method_11(int_3);
	}

	// Token: 0x06000174 RID: 372 RVA: 0x0001213C File Offset: 0x0001033C
	public bool method_16()
	{
		Class23 @class;
		if ((this.uint_0[499] & 2147483648U) != 0U)
		{
			@class = Class23.smethod_14(this);
		}
		else
		{
			@class = this;
		}
		if (@class.int_2 == 1)
		{
			if (@class.uint_0[0] == 0U || @class.uint_0[0] == 1U)
			{
				return false;
			}
			if (@class.uint_0[0] == 2U || @class.uint_0[0] == 3U)
			{
				return true;
			}
		}
		bool result;
		if ((@class.uint_0[0] & 1U) == 0U)
		{
			result = false;
		}
		else
		{
			for (int i = 0; i < Class23.int_1.Length; i++)
			{
				Class23 class2 = Class23.smethod_2(Class23.int_1[i]);
				if (Class23.smethod_19(class2, @class))
				{
					break;
				}
				Class23 class3 = Class23.smethod_24(@class, class2);
				if (class3.method_17() == 0)
				{
					return false;
				}
			}
			Class23 class4 = Class23.smethod_6(@class, new Class23(1L));
			int num = 0;
			int j = 0;
			IL_13D:
			while (j < class4.int_2)
			{
				uint num2 = 1U;
				for (int k = 0; k < 32; k++)
				{
					if ((class4.uint_0[j] & num2) != 0U)
					{
						j = class4.int_2;
						IL_137:
						j++;
						goto IL_13D;
					}
					num2 <<= 1;
					num++;
				}
				goto IL_137;
			}
			Class23 class23_ = Class23.smethod_11(class4, num);
			@class.method_9();
			Class23 class5 = Class23.smethod_2(2);
			Class23 class6 = class5.method_5(class23_, @class);
			bool flag = false;
			if (class6.int_2 == 1 && class6.uint_0[0] == 1U)
			{
				flag = true;
			}
			int num3 = 0;
			while (!flag && num3 < num)
			{
				if (Class23.smethod_15(class6, class4))
				{
					flag = true;
					break;
				}
				class6 = Class23.smethod_24(Class23.smethod_8(class6, class6), @class);
				num3++;
			}
			if (flag)
			{
				flag = this.method_14(@class);
			}
			result = flag;
		}
		return result;
	}

	// Token: 0x06000175 RID: 373 RVA: 0x00012338 File Offset: 0x00010538
	public int method_17()
	{
		return (int)this.uint_0[0];
	}

	// Token: 0x06000176 RID: 374 RVA: 0x00012350 File Offset: 0x00010550
	public long method_18()
	{
		long num = 0L;
		num = (long)((ulong)this.uint_0[0]);
		try
		{
			num |= (long)((long)((ulong)this.uint_0[1]) << 32);
		}
		catch (Exception)
		{
			if ((this.uint_0[0] & 2147483648U) != 0U)
			{
				num = (long)this.uint_0[0];
			}
		}
		return num;
	}

	// Token: 0x06000177 RID: 375 RVA: 0x000123B8 File Offset: 0x000105B8
	public static int smethod_28(Class23 class23_0, Class23 class23_1)
	{
		if ((class23_1.uint_0[0] & 1U) == 0U)
		{
			throw new ArgumentException("Jacobi defined only for odd integers.");
		}
		if (Class23.smethod_19(class23_0, class23_1))
		{
			class23_0 = Class23.smethod_24(class23_0, class23_1);
		}
		int result;
		if (class23_0.int_2 == 1 && class23_0.uint_0[0] == 0U)
		{
			result = 0;
		}
		else if (class23_0.int_2 == 1 && class23_0.uint_0[0] == 1U)
		{
			result = 1;
		}
		else if (Class23.smethod_18(class23_0, Class23.smethod_2(0)))
		{
			if ((Class23.smethod_6(class23_1, Class23.smethod_2(1)).uint_0[0] & 2U) == 0U)
			{
				result = Class23.smethod_28(Class23.smethod_14(class23_0), class23_1);
			}
			else
			{
				result = -Class23.smethod_28(Class23.smethod_14(class23_0), class23_1);
			}
		}
		else
		{
			int num = 0;
			int i = 0;
			IL_10C:
			while (i < class23_0.int_2)
			{
				uint num2 = 1U;
				for (int j = 0; j < 32; j++)
				{
					if ((class23_0.uint_0[i] & num2) != 0U)
					{
						i = class23_0.int_2;
						IL_108:
						i++;
						goto IL_10C;
					}
					num2 <<= 1;
					num++;
				}
				goto IL_108;
			}
			Class23 @class = Class23.smethod_11(class23_0, num);
			int num3 = 1;
			if ((num & 1) != 0 && ((class23_1.uint_0[0] & 7U) == 3U || (class23_1.uint_0[0] & 7U) == 5U))
			{
				num3 = -1;
			}
			if ((class23_1.uint_0[0] & 3U) == 3U && (@class.uint_0[0] & 3U) == 3U)
			{
				num3 = -num3;
			}
			if (@class.int_2 == 1 && @class.uint_0[0] == 1U)
			{
				result = num3;
			}
			else
			{
				result = num3 * Class23.smethod_28(Class23.smethod_24(class23_1, @class), @class);
			}
		}
		return result;
	}

	// Token: 0x06000178 RID: 376 RVA: 0x00012574 File Offset: 0x00010774
	public static Class23 smethod_29(int int_3, int int_4, Class31 class31_0)
	{
		Class23 @class = new Class23();
		bool flag = false;
		while (!flag)
		{
			@class.method_8(int_3, class31_0);
			@class.uint_0[0] |= 1U;
			flag = @class.method_15(int_4);
		}
		return @class;
	}

	// Token: 0x06000179 RID: 377 RVA: 0x000125C0 File Offset: 0x000107C0
	public Class23 method_19(int int_3, Class31 class31_0)
	{
		bool flag = false;
		Class23 @class = new Class23();
		while (!flag)
		{
			@class.method_8(int_3, class31_0);
			Class23 class2 = @class.method_7(this);
			if (class2.int_2 == 1 && class2.uint_0[0] == 1U)
			{
				flag = true;
			}
		}
		return @class;
	}

	// Token: 0x0600017A RID: 378 RVA: 0x00012610 File Offset: 0x00010810
	public Class23 method_20(Class23 class23_0)
	{
		Class23[] array = new Class23[]
		{
			Class23.smethod_2(0),
			Class23.smethod_2(1)
		};
		Class23[] array2 = new Class23[2];
		Class23[] array3 = new Class23[]
		{
			Class23.smethod_2(0),
			Class23.smethod_2(0)
		};
		int num = 0;
		Class23 class23_ = class23_0;
		Class23 @class = this;
		while (@class.int_2 > 1 || (@class.int_2 == 1 && @class.uint_0[0] != 0U))
		{
			Class23 class2 = new Class23();
			Class23 class3 = new Class23();
			if (num > 1)
			{
				Class23 class4 = Class23.smethod_24(Class23.smethod_6(array[0], Class23.smethod_8(array[1], array2[0])), class23_0);
				array[0] = array[1];
				array[1] = class4;
			}
			if (@class.int_2 == 1)
			{
				Class23.smethod_22(class23_, @class, class2, class3);
			}
			else
			{
				Class23.smethod_21(class23_, @class, class2, class3);
			}
			array2[0] = array2[1];
			array3[0] = array3[1];
			array2[1] = class2;
			array3[1] = class3;
			class23_ = @class;
			@class = class3;
			num++;
		}
		if (array3[0].int_2 > 1 || (array3[0].int_2 == 1 && array3[0].uint_0[0] != 1U))
		{
			throw new ArithmeticException("No inverse!");
		}
		Class23 class5 = Class23.smethod_24(Class23.smethod_6(array[0], Class23.smethod_8(array[1], array2[0])), class23_0);
		if ((class5.uint_0[499] & 2147483648U) != 0U)
		{
			class5 = Class23.smethod_4(class5, class23_0);
		}
		return class5;
	}

	// Token: 0x0600017B RID: 379 RVA: 0x000127AC File Offset: 0x000109AC
	public byte[] method_21()
	{
		int num = this.method_9();
		int num2 = num >> 3;
		if ((num & 7) != 0)
		{
			num2++;
		}
		byte[] array = new byte[num2];
		int num3 = 0;
		uint num4 = this.uint_0[this.int_2 - 1];
		uint num5;
		if ((num5 = (num4 >> 24 & 255U)) != 0U)
		{
			array[num3++] = (byte)num5;
		}
		if ((num5 = (num4 >> 16 & 255U)) != 0U)
		{
			array[num3++] = (byte)num5;
		}
		if ((num5 = (num4 >> 8 & 255U)) != 0U)
		{
			array[num3++] = (byte)num5;
		}
		if ((num5 = (num4 & 255U)) != 0U)
		{
			array[num3++] = (byte)num5;
		}
		int i = this.int_2 - 2;
		while (i >= 0)
		{
			num4 = this.uint_0[i];
			array[num3 + 3] = (byte)(num4 & 255U);
			num4 >>= 8;
			array[num3 + 2] = (byte)(num4 & 255U);
			num4 >>= 8;
			array[num3 + 1] = (byte)(num4 & 255U);
			num4 >>= 8;
			array[num3] = (byte)(num4 & 255U);
			i--;
			num3 += 4;
		}
		return array;
	}

	// Token: 0x0600017C RID: 380 RVA: 0x000128D4 File Offset: 0x00010AD4
	public void method_22(uint uint_1)
	{
		uint num = uint_1 >> 5;
		byte b = (byte)(uint_1 & 31U);
		uint num2 = 1U << (int)b;
		this.uint_0[(int)((UIntPtr)num)] |= num2;
		if ((ulong)num >= (ulong)((long)this.int_2))
		{
			this.int_2 = (int)(num + 1U);
		}
	}

	// Token: 0x0600017D RID: 381 RVA: 0x00012924 File Offset: 0x00010B24
	public void method_23(uint uint_1)
	{
		uint num = uint_1 >> 5;
		if ((ulong)num < (ulong)((long)this.int_2))
		{
			byte b = (byte)(uint_1 & 31U);
			uint num2 = 1U << (int)b;
			uint num3 = uint.MaxValue ^ num2;
			this.uint_0[(int)((UIntPtr)num)] &= num3;
			if (this.int_2 > 1 && this.uint_0[this.int_2 - 1] == 0U)
			{
				this.int_2--;
			}
		}
	}

	// Token: 0x0600017E RID: 382 RVA: 0x000129A4 File Offset: 0x00010BA4
	public Class23 method_24(int int_3)
	{
		Class23 @class = this;
		for (int i = 1; i < int_3; i++)
		{
			@class = Class23.smethod_8(@class, this);
		}
		return @class;
	}

	// Token: 0x0600017F RID: 383 RVA: 0x000129CC File Offset: 0x00010BCC
	public Class23 method_25()
	{
		uint num = (uint)this.method_9();
		if ((num & 1U) != 0U)
		{
			num = (num >> 1) + 1U;
		}
		else
		{
			num >>= 1;
		}
		uint num2 = num >> 5;
		byte b = (byte)(num & 31U);
		Class23 @class = new Class23();
		uint num3;
		if (b == 0)
		{
			num3 = 2147483648U;
		}
		else
		{
			num3 = 1U << (int)b;
			num2 += 1U;
		}
		@class.int_2 = (int)num2;
		for (int i = (int)(num2 - 1U); i >= 0; i--)
		{
			while (num3 != 0U)
			{
				@class.uint_0[i] ^= num3;
				if (Class23.smethod_17(@class.method_24(2), this))
				{
					@class.uint_0[i] ^= num3;
				}
				num3 >>= 1;
			}
			num3 = 2147483648U;
		}
		return @class;
	}

	// Token: 0x06000180 RID: 384 RVA: 0x00012AA4 File Offset: 0x00010CA4
	public Class23 method_26()
	{
		uint num = (uint)this.method_9();
		if ((num & 1U) != 0U)
		{
			num = (num >> 1) + 1U;
		}
		else
		{
			num >>= 1;
		}
		uint num2 = num >> 5;
		byte b = (byte)(num & 31U);
		Class23 @class = new Class23();
		uint num3;
		if (b == 0)
		{
			num3 = 2147483648U;
		}
		else
		{
			num3 = 1U << (int)b;
			num2 += 1U;
		}
		@class.int_2 = (int)num2;
		for (int i = (int)(num2 - 1U); i >= 0; i--)
		{
			while (num3 != 0U)
			{
				@class.uint_0[i] ^= num3;
				if (Class23.smethod_17(@class.method_24(3), this))
				{
					@class.uint_0[i] ^= num3;
				}
				num3 >>= 1;
			}
			num3 = 2147483648U;
		}
		return @class;
	}

	// Token: 0x06000181 RID: 385 RVA: 0x00012B7C File Offset: 0x00010D7C
	public static Class23[] smethod_30(Class23 class23_0, Class23 class23_1, Class23 class23_2, Class23 class23_3)
	{
		Class23[] result;
		if (class23_2.int_2 == 1 && class23_2.uint_0[0] == 0U)
		{
			result = new Class23[]
			{
				Class23.smethod_2(0),
				Class23.smethod_24(Class23.smethod_2(2), class23_3),
				Class23.smethod_24(Class23.smethod_2(1), class23_3)
			};
		}
		else
		{
			Class23 @class = new Class23();
			int num = class23_3.int_2 << 1;
			@class.uint_0[num] = 1U;
			@class.int_2 = num + 1;
			@class = Class23.smethod_23(@class, class23_3);
			int num2 = 0;
			int i = 0;
			IL_C5:
			while (i < class23_2.int_2)
			{
				uint num3 = 1U;
				for (int j = 0; j < 32; j++)
				{
					if ((class23_2.uint_0[i] & num3) != 0U)
					{
						i = class23_2.int_2;
						IL_BF:
						i++;
						goto IL_C5;
					}
					num3 <<= 1;
					num2++;
				}
				goto IL_BF;
			}
			Class23 class23_4 = Class23.smethod_11(class23_2, num2);
			result = Class23.smethod_31(class23_0, class23_1, class23_4, class23_3, @class, num2);
		}
		return result;
	}

	// Token: 0x06000182 RID: 386 RVA: 0x00012C74 File Offset: 0x00010E74
	private static Class23[] smethod_31(Class23 class23_0, Class23 class23_1, Class23 class23_2, Class23 class23_3, Class23 class23_4, int int_3)
	{
		Class23[] array = new Class23[3];
		if ((class23_2.uint_0[0] & 1U) == 0U)
		{
			throw new ArgumentException("Argument k must be odd.");
		}
		int num = class23_2.method_9();
		uint num2 = 1U << (num & 31) - 1;
		Class23 @class = Class23.smethod_24(Class23.smethod_2(2), class23_3);
		Class23 class2 = Class23.smethod_24(Class23.smethod_2(1), class23_3);
		Class23 class3 = Class23.smethod_24(class23_0, class23_3);
		Class23 class4 = class2;
		bool flag = true;
		for (int i = class23_2.int_2 - 1; i >= 0; i--)
		{
			while (num2 != 0U && (i != 0 || num2 != 1U))
			{
				if ((class23_2.uint_0[i] & num2) != 0U)
				{
					class4 = Class23.smethod_24(Class23.smethod_8(class4, class3), class23_3);
					@class = Class23.smethod_24(Class23.smethod_6(Class23.smethod_8(@class, class3), Class23.smethod_8(class23_0, class2)), class23_3);
					class3 = class23_3.method_6(Class23.smethod_8(class3, class3), class23_3, class23_4);
					class3 = Class23.smethod_24(Class23.smethod_6(class3, Class23.smethod_9(Class23.smethod_8(class2, class23_1), 1)), class23_3);
					if (flag)
					{
						flag = false;
					}
					else
					{
						class2 = class23_3.method_6(Class23.smethod_8(class2, class2), class23_3, class23_4);
					}
					class2 = Class23.smethod_24(Class23.smethod_8(class2, class23_1), class23_3);
				}
				else
				{
					class4 = Class23.smethod_24(Class23.smethod_6(Class23.smethod_8(class4, @class), class2), class23_3);
					class3 = Class23.smethod_24(Class23.smethod_6(Class23.smethod_8(@class, class3), Class23.smethod_8(class23_0, class2)), class23_3);
					@class = class23_3.method_6(Class23.smethod_8(@class, @class), class23_3, class23_4);
					@class = Class23.smethod_24(Class23.smethod_6(@class, Class23.smethod_9(class2, 1)), class23_3);
					if (flag)
					{
						class2 = Class23.smethod_24(class23_1, class23_3);
						flag = false;
					}
					else
					{
						class2 = class23_3.method_6(Class23.smethod_8(class2, class2), class23_3, class23_4);
					}
				}
				num2 >>= 1;
			}
			num2 = 2147483648U;
		}
		class4 = Class23.smethod_24(Class23.smethod_6(Class23.smethod_8(class4, @class), class2), class23_3);
		@class = Class23.smethod_24(Class23.smethod_6(Class23.smethod_8(@class, class3), Class23.smethod_8(class23_0, class2)), class23_3);
		if (flag)
		{
			flag = false;
		}
		else
		{
			class2 = class23_3.method_6(Class23.smethod_8(class2, class2), class23_3, class23_4);
		}
		class2 = Class23.smethod_24(Class23.smethod_8(class2, class23_1), class23_3);
		for (int i = 0; i < int_3; i++)
		{
			class4 = Class23.smethod_24(Class23.smethod_8(class4, @class), class23_3);
			@class = Class23.smethod_24(Class23.smethod_6(Class23.smethod_8(@class, @class), Class23.smethod_9(class2, 1)), class23_3);
			if (flag)
			{
				class2 = Class23.smethod_24(class23_1, class23_3);
				flag = false;
			}
			else
			{
				class2 = class23_3.method_6(Class23.smethod_8(class2, class2), class23_3, class23_4);
			}
		}
		array[0] = class4;
		array[1] = @class;
		array[2] = class2;
		return array;
	}

	// Token: 0x06000183 RID: 387 RVA: 0x00003216 File Offset: 0x00001416
	public void Dispose()
	{
		this.uint_0 = new uint[0];
		this.uint_0 = null;
		GC.Collect();
		GC.Collect();
	}

	// Token: 0x040000FF RID: 255
	private const int int_0 = 500;

	// Token: 0x04000100 RID: 256
	public static readonly int[] int_1 = new int[]
	{
		2,
		3,
		5,
		7,
		11,
		13,
		17,
		19,
		23,
		29,
		31,
		37,
		41,
		43,
		47,
		53,
		59,
		61,
		67,
		71,
		73,
		79,
		83,
		89,
		97,
		101,
		103,
		107,
		109,
		113,
		127,
		131,
		137,
		139,
		149,
		151,
		157,
		163,
		167,
		173,
		179,
		181,
		191,
		193,
		197,
		199,
		211,
		223,
		227,
		229,
		233,
		239,
		241,
		251,
		257,
		263,
		269,
		271,
		277,
		281,
		283,
		293,
		307,
		311,
		313,
		317,
		331,
		337,
		347,
		349,
		353,
		359,
		367,
		373,
		379,
		383,
		389,
		397,
		401,
		409,
		419,
		421,
		431,
		433,
		439,
		443,
		449,
		457,
		461,
		463,
		467,
		479,
		487,
		491,
		499,
		503,
		509,
		521,
		523,
		541,
		547,
		557,
		563,
		569,
		571,
		577,
		587,
		593,
		599,
		601,
		607,
		613,
		617,
		619,
		631,
		641,
		643,
		647,
		653,
		659,
		661,
		673,
		677,
		683,
		691,
		701,
		709,
		719,
		727,
		733,
		739,
		743,
		751,
		757,
		761,
		769,
		773,
		787,
		797,
		809,
		811,
		821,
		823,
		827,
		829,
		839,
		853,
		857,
		859,
		863,
		877,
		881,
		883,
		887,
		907,
		911,
		919,
		929,
		937,
		941,
		947,
		953,
		967,
		971,
		977,
		983,
		991,
		997,
		1009,
		1013,
		1019,
		1021,
		1031,
		1033,
		1039,
		1049,
		1051,
		1061,
		1063,
		1069,
		1087,
		1091,
		1093,
		1097,
		1103,
		1109,
		1117,
		1123,
		1129,
		1151,
		1153,
		1163,
		1171,
		1181,
		1187,
		1193,
		1201,
		1213,
		1217,
		1223,
		1229,
		1231,
		1237,
		1249,
		1259,
		1277,
		1279,
		1283,
		1289,
		1291,
		1297,
		1301,
		1303,
		1307,
		1319,
		1321,
		1327,
		1361,
		1367,
		1373,
		1381,
		1399,
		1409,
		1423,
		1427,
		1429,
		1433,
		1439,
		1447,
		1451,
		1453,
		1459,
		1471,
		1481,
		1483,
		1487,
		1489,
		1493,
		1499,
		1511,
		1523,
		1531,
		1543,
		1549,
		1553,
		1559,
		1567,
		1571,
		1579,
		1583,
		1597,
		1601,
		1607,
		1609,
		1613,
		1619,
		1621,
		1627,
		1637,
		1657,
		1663,
		1667,
		1669,
		1693,
		1697,
		1699,
		1709,
		1721,
		1723,
		1733,
		1741,
		1747,
		1753,
		1759,
		1777,
		1783,
		1787,
		1789,
		1801,
		1811,
		1823,
		1831,
		1847,
		1861,
		1867,
		1871,
		1873,
		1877,
		1879,
		1889,
		1901,
		1907,
		1913,
		1931,
		1933,
		1949,
		1951,
		1973,
		1979,
		1987,
		1993,
		1997,
		1999
	};

	// Token: 0x04000101 RID: 257
	private uint[] uint_0 = null;

	// Token: 0x04000102 RID: 258
	public int int_2;
}
