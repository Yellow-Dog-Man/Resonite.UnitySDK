
using System;
using ResoniteLink;
using UnityEngine;


		[Serializable]
		public struct Vector2Bool
		{
							public bool x;
								public bool y;
				
			public bool2 ToResoniteLink() => new bool2()
			{
									x = x,
										y = y,
						
			};
		}

		
		[Serializable]
		public struct Vector3Bool
		{
							public bool x;
								public bool y;
								public bool z;
				
			public bool3 ToResoniteLink() => new bool3()
			{
									x = x,
										y = y,
										z = z,
						
			};
		}

		
		[Serializable]
		public struct Vector4Bool
		{
							public bool x;
								public bool y;
								public bool z;
								public bool w;
				
			public bool4 ToResoniteLink() => new bool4()
			{
									x = x,
										y = y,
										z = z,
										w = w,
						
			};
		}

		
		[Serializable]
		public struct Vector2Byte
		{
							public byte x;
								public byte y;
				
			public byte2 ToResoniteLink() => new byte2()
			{
									x = x,
										y = y,
						
			};
		}

		
		[Serializable]
		public struct Vector3Byte
		{
							public byte x;
								public byte y;
								public byte z;
				
			public byte3 ToResoniteLink() => new byte3()
			{
									x = x,
										y = y,
										z = z,
						
			};
		}

		
		[Serializable]
		public struct Vector4Byte
		{
							public byte x;
								public byte y;
								public byte z;
								public byte w;
				
			public byte4 ToResoniteLink() => new byte4()
			{
									x = x,
										y = y,
										z = z,
										w = w,
						
			};
		}

		
		[Serializable]
		public struct Vector2Ushort
		{
							public ushort x;
								public ushort y;
				
			public ushort2 ToResoniteLink() => new ushort2()
			{
									x = x,
										y = y,
						
			};
		}

		
		[Serializable]
		public struct Vector3Ushort
		{
							public ushort x;
								public ushort y;
								public ushort z;
				
			public ushort3 ToResoniteLink() => new ushort3()
			{
									x = x,
										y = y,
										z = z,
						
			};
		}

		
		[Serializable]
		public struct Vector4Ushort
		{
							public ushort x;
								public ushort y;
								public ushort z;
								public ushort w;
				
			public ushort4 ToResoniteLink() => new ushort4()
			{
									x = x,
										y = y,
										z = z,
										w = w,
						
			};
		}

		
		[Serializable]
		public struct Vector2Uint
		{
							public uint x;
								public uint y;
				
			public uint2 ToResoniteLink() => new uint2()
			{
									x = x,
										y = y,
						
			};
		}

		
		[Serializable]
		public struct Vector3Uint
		{
							public uint x;
								public uint y;
								public uint z;
				
			public uint3 ToResoniteLink() => new uint3()
			{
									x = x,
										y = y,
										z = z,
						
			};
		}

		
		[Serializable]
		public struct Vector4Uint
		{
							public uint x;
								public uint y;
								public uint z;
								public uint w;
				
			public uint4 ToResoniteLink() => new uint4()
			{
									x = x,
										y = y,
										z = z,
										w = w,
						
			};
		}

		
		[Serializable]
		public struct Vector2Ulong
		{
							public ulong x;
								public ulong y;
				
			public ulong2 ToResoniteLink() => new ulong2()
			{
									x = x,
										y = y,
						
			};
		}

		
		[Serializable]
		public struct Vector3Ulong
		{
							public ulong x;
								public ulong y;
								public ulong z;
				
			public ulong3 ToResoniteLink() => new ulong3()
			{
									x = x,
										y = y,
										z = z,
						
			};
		}

		
		[Serializable]
		public struct Vector4Ulong
		{
							public ulong x;
								public ulong y;
								public ulong z;
								public ulong w;
				
			public ulong4 ToResoniteLink() => new ulong4()
			{
									x = x,
										y = y,
										z = z,
										w = w,
						
			};
		}

		
		[Serializable]
		public struct Vector2Sbyte
		{
							public sbyte x;
								public sbyte y;
				
			public sbyte2 ToResoniteLink() => new sbyte2()
			{
									x = x,
										y = y,
						
			};
		}

		
		[Serializable]
		public struct Vector3Sbyte
		{
							public sbyte x;
								public sbyte y;
								public sbyte z;
				
			public sbyte3 ToResoniteLink() => new sbyte3()
			{
									x = x,
										y = y,
										z = z,
						
			};
		}

		
		[Serializable]
		public struct Vector4Sbyte
		{
							public sbyte x;
								public sbyte y;
								public sbyte z;
								public sbyte w;
				
			public sbyte4 ToResoniteLink() => new sbyte4()
			{
									x = x,
										y = y,
										z = z,
										w = w,
						
			};
		}

		
		[Serializable]
		public struct Vector2Short
		{
							public short x;
								public short y;
				
			public short2 ToResoniteLink() => new short2()
			{
									x = x,
										y = y,
						
			};
		}

		
		[Serializable]
		public struct Vector3Short
		{
							public short x;
								public short y;
								public short z;
				
			public short3 ToResoniteLink() => new short3()
			{
									x = x,
										y = y,
										z = z,
						
			};
		}

		
		[Serializable]
		public struct Vector4Short
		{
							public short x;
								public short y;
								public short z;
								public short w;
				
			public short4 ToResoniteLink() => new short4()
			{
									x = x,
										y = y,
										z = z,
										w = w,
						
			};
		}

		
		[Serializable]
		public struct Vector4Int
		{
							public int x;
								public int y;
								public int z;
								public int w;
				
			public int4 ToResoniteLink() => new int4()
			{
									x = x,
										y = y,
										z = z,
										w = w,
						
			};
		}

		
		[Serializable]
		public struct Vector2Long
		{
							public long x;
								public long y;
				
			public long2 ToResoniteLink() => new long2()
			{
									x = x,
										y = y,
						
			};
		}

		
		[Serializable]
		public struct Vector3Long
		{
							public long x;
								public long y;
								public long z;
				
			public long3 ToResoniteLink() => new long3()
			{
									x = x,
										y = y,
										z = z,
						
			};
		}

		
		[Serializable]
		public struct Vector4Long
		{
							public long x;
								public long y;
								public long z;
								public long w;
				
			public long4 ToResoniteLink() => new long4()
			{
									x = x,
										y = y,
										z = z,
										w = w,
						
			};
		}

		
		[Serializable]
		public struct Vector2Double
		{
							public double x;
								public double y;
				
			public double2 ToResoniteLink() => new double2()
			{
									x = x,
										y = y,
						
			};
		}

		
		[Serializable]
		public struct Vector3Double
		{
							public double x;
								public double y;
								public double z;
				
			public double3 ToResoniteLink() => new double3()
			{
									x = x,
										y = y,
										z = z,
						
			};
		}

		
		[Serializable]
		public struct Vector4Double
		{
							public double x;
								public double y;
								public double z;
								public double w;
				
			public double4 ToResoniteLink() => new double4()
			{
									x = x,
										y = y,
										z = z,
										w = w,
						
			};
		}

		