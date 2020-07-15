using Terraria.ModLoader;

namespace CrystallineMod
{
	public class CrystallineMod : Mod
	{
		public CrystallineMod()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadBackgrounds = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}
	}
}