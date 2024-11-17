using JcvillaltavS68A.Models;
using Newtonsoft.Json;
using System.Collections.ObjectModel;

namespace JcvillaltavS68A.Views;

public partial class vEstudiante : ContentPage
{
    private const string Url = "http://192.168.100.6/uisrael/estudiante.php";
    private readonly HttpClient cliente = new HttpClient();
    private ObservableCollection<Estudiante> estud;

    public vEstudiante()
    {
        InitializeComponent();
        mostrar();
    }

    public async void mostrar()
    {
        var content = await cliente.GetStringAsync(Url);
        List<Estudiante> mostrarEst = JsonConvert.DeserializeObject<List<Estudiante>>(content);
        estud = new ObservableCollection<Estudiante>(mostrarEst);
        //lvEstudiantes.ItemsSource = estud;
        lvEstudiantes.ItemsSource = estud;

    }

    private void btnInsertar_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new vInsertar());
    }
}