using System;
using FC3.Core.Inventory;
using FC3.Core.Maths;
namespace FC3.Core.Components
{
	public class SplineRoad : Spline
	{
		public new static SplineRoad Null = new SplineRoad(IntPtr.Zero);
		public SplineInventoryEntry Entry
		{
			get
			{
				return new SplineInventoryEntry(Binding.FCE_SplineRoad_GetEntry(this.m_splinePtr));
			}
			set
			{
				Binding.FCE_SplineRoad_SetEntry(this.m_splinePtr, value.Pointer);
			}
		}
		public float Width
		{
			get
			{
				return Binding.FCE_SplineRoad_GetWidth(this.m_splinePtr);
			}
			set
			{
				Binding.FCE_SplineRoad_SetWidth(this.m_splinePtr, value);
			}
		}
		public SplineRoad(IntPtr ptr) : base(ptr)
		{
		}
	}
}
