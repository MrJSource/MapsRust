namespace Oxide.Plugins
{
    [Info("NoRain", "KpucTaJl", "1.0.1")]
    internal class NoRain : RustPlugin
    {
        private void OnServerInitialized() 
		{ 
			timer.In(10f, () => 
			{
				Server.Command("weather.storm_chance 0");
				Server.Command("weather.rain_chance 0");
			}); 
		}
    }
}