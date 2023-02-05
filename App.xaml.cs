using MAUIGastos.MVVM.Models;
using MAUIGastos.MVVM.Views;
using MAUIGastos.Repositories;

namespace MAUIGastos;

public partial class App : Application
{
    public static BaseRepository<Transaction>
     TransactionsRepo
    { get; private set; }

    public App(BaseRepository<Transaction> _transcationsRepo)
    {
        InitializeComponent();

        TransactionsRepo = _transcationsRepo;

        MainPage = new AppContainer();
    }
}
