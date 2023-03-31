using SeleniumExtras.PageObjects;
namespace MQTASelenium;

public class Pages
{
    private static T GetPage<T>() where T : new()
    {
        var page = new T();

        PageFactory.InitElements(Browser.Driver, page);
        return page;
    }

    public static SharedComponents SharedComponents
    {
        get { return GetPage<SharedComponents>(); }
    }
    public static LoginPage Login
    {
        get { return GetPage<LoginPage>(); }
    }
    public static HRAdminPage HRAdminPage
    {
        get { return GetPage<HRAdminPage>(); }
    }


}
