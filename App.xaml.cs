using appProvaA1Caneta.DAL;
using appProvaA1Caneta.Views;

namespace appProvaA1Caneta;

public partial class App : Application
{
    static crudSQLite database;

    public static crudSQLite Database
    {
        get
        {
            if (database == null)
            {
                string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "bancocaneta.db3");
                database = new crudSQLite(path);
            }
            return database;
        }
    }

    public App()
    {
        InitializeComponent();
        MainPage = new NavigationPage(new TelaListaCaneta());
    }
}