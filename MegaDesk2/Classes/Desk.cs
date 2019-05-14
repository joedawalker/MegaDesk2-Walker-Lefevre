using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Walker.Classes
{
	public class Desk
	{
		public int Depth { get; set; }
		public int Width { get; set; }
		public int NumberOfDrawers { get; set; }
		public DesktopMaterial SurfaceMaterial { get; set; }
	}

	public enum DesktopMaterial
	{
		Oak = 0,
		Laminate = 1,
		Pine = 2,
		Rosewood = 3,
		Veneer = 4
	}
}
