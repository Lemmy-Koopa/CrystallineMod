using Terraria.ModLoader;

namespace CrystallineMod
{
	public class CrystallineMod : Mod
	{
		public static CrystallineMod instance;
		
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
		
		public override void Load()
		{
			instance = this;
		}
		
		public override void Unload()
		{
			instance = null;
		}
	}
}
