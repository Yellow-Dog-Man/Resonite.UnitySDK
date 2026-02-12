
using System;
using ResoniteLink;

namespace UnityEngine
{


		[Serializable]
		public struct Matrix2x2
		{
								public float m00;	
										public float m01;	
										public float m10;	
										public float m11;	
					
			public float2x2 ToResoniteLink() => new float2x2()
			{
										m00 = m00,
												m01 = m01,
												m10 = m10,
												m11 = m11,
							
			};
		}

		
		[Serializable]
		public struct Matrix3x3
		{
								public float m00;	
										public float m01;	
										public float m02;	
										public float m10;	
										public float m11;	
										public float m12;	
										public float m20;	
										public float m21;	
										public float m22;	
					
			public float3x3 ToResoniteLink() => new float3x3()
			{
										m00 = m00,
												m01 = m01,
												m02 = m02,
												m10 = m10,
												m11 = m11,
												m12 = m12,
												m20 = m20,
												m21 = m21,
												m22 = m22,
							
			};
		}

		
		[Serializable]
		public struct Matrix2x2Double
		{
								public double m00;	
										public double m01;	
										public double m10;	
										public double m11;	
					
			public double2x2 ToResoniteLink() => new double2x2()
			{
										m00 = m00,
												m01 = m01,
												m10 = m10,
												m11 = m11,
							
			};
		}

		
		[Serializable]
		public struct Matrix3x3Double
		{
								public double m00;	
										public double m01;	
										public double m02;	
										public double m10;	
										public double m11;	
										public double m12;	
										public double m20;	
										public double m21;	
										public double m22;	
					
			public double3x3 ToResoniteLink() => new double3x3()
			{
										m00 = m00,
												m01 = m01,
												m02 = m02,
												m10 = m10,
												m11 = m11,
												m12 = m12,
												m20 = m20,
												m21 = m21,
												m22 = m22,
							
			};
		}

		
		[Serializable]
		public struct Matrix4x4Double
		{
								public double m00;	
										public double m01;	
										public double m02;	
										public double m03;	
										public double m10;	
										public double m11;	
										public double m12;	
										public double m13;	
										public double m20;	
										public double m21;	
										public double m22;	
										public double m23;	
										public double m30;	
										public double m31;	
										public double m32;	
										public double m33;	
					
			public double4x4 ToResoniteLink() => new double4x4()
			{
										m00 = m00,
												m01 = m01,
												m02 = m02,
												m03 = m03,
												m10 = m10,
												m11 = m11,
												m12 = m12,
												m13 = m13,
												m20 = m20,
												m21 = m21,
												m22 = m22,
												m23 = m23,
												m30 = m30,
												m31 = m31,
												m32 = m32,
												m33 = m33,
							
			};
		}

		
}