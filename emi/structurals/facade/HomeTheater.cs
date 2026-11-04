namespace facade;

public class HomeTheater
{
    private Projector projector;
    private SoundSystem sound;
    private LightSystem lights;
    private Config config;
    public HomeTheater()
    {
        config = Config.GetInstance();
        projector = new();
        sound = new(config.MediumVolume);
        lights = new(config.MinVolume);
    }
    public void WatchMovie()
    {
        lights.SetLightLevel(config.MinLights);
        System.Console.WriteLine($"Lights on {lights.LightLevel}%");

        projector.PowerOn();
        projector.ChooseInput(config.ProjectorPort);
        System.Console.WriteLine($"Projector on in {projector.InputCable}");

        sound.PowerOn();
        sound.ChangeVolume(config.MediumVolume);
        System.Console.WriteLine($"Sound on, volume {sound.Volume}");
        System.Console.WriteLine("-- enjoy the movie --");
    }
    public void EndMovie()
    {
        lights.SetLightLevel(config.MediumLights);
        System.Console.WriteLine($"Lights on {lights.LightLevel}%");

        projector.PowerOff();
        System.Console.WriteLine($"Projector off");

        sound.PowerOff();
        sound.ChangeVolume(config.MinVolume);
        System.Console.WriteLine($"Sound off, volume {sound.Volume}");
    }
}
