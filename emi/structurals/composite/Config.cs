using System.Diagnostics.Contracts;

namespace composite;

public class Config
{
    private Menu _menu;
    public Config(Menu menu)
    {
        _menu = menu;
    }
    public void getMenuContent()
    {
        _menu.GetContent();
    }
    public void getAllContent()
    {
        _menu.GetDescription();
    }
}
