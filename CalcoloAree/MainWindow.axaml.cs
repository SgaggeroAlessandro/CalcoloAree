using Avalonia.Controls;
using Avalonia.Interactivity;

namespace CalcoloAree;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        Nascondi();
    }

    private void Nascondi()
    {
        LblCampo1.IsVisible = false;
        LblCampo2.IsVisible = false;
        TxtCampo1.IsVisible = false;
        TxtCampo2.IsVisible = false;
        TxtCampo1.Text = "";
        TxtCampo2.Text = "";
    }

    private void FiguraSelezionata_SelectionIndex(object? sender, SelectionChangedEventArgs e)
    {
        
        if(FiguraSelezionata == null || LblCampo1 == null || TxtCampo1 == null)
        {
            return;
        }
        
        int figuraSelezionata = FiguraSelezionata.SelectedIndex;
        
        if(figuraSelezionata == 0)
        {
            Nascondi();
            TxtRisultato.Text = "Seleziona una figura valida";
        }else if(figuraSelezionata == 1)
        {
            LblCampo1.Text = "Base:";
            LblCampo1.IsVisible = true;
            TxtCampo1.IsVisible = true;

            LblCampo2.Text = "Altezza:";
            LblCampo2.IsVisible = true;
            TxtCampo2.IsVisible = true;
        }
        else if(figuraSelezionata == 2)
        {
            LblCampo1.Text = "Lato:";
            LblCampo1.IsVisible = true;
            TxtCampo1.IsVisible = true;

            LblCampo2.IsVisible = false;
            TxtCampo2.IsVisible = false; 
        }
        else
        {
            LblCampo1.Text = "Raggio:";
            LblCampo1.IsVisible = true;
            TxtCampo1.IsVisible = true;

            LblCampo2.IsVisible = false;
            TxtCampo2.IsVisible = false; ;
        }
    }

   

    private void Calcola(object? sender, RoutedEventArgs e)
    {

        if (FiguraSelezionata == null || LblCampo1 == null || TxtCampo1 == null)
        {
            return;
        }

        int figuraSelezionata = FiguraSelezionata.SelectedIndex;

        if(figuraSelezionata == 0)
        {
            TxtRisultato.Text = "Prima di calcolare perimetro ed area di una figura, devi selezionarla";
            return;
        }
        if (figuraSelezionata == 1)
        {
            if(!float.TryParse(TxtCampo1.Text, out float baseR) || !float.TryParse(TxtCampo2.Text, out float altezzaR))
            {
                TxtRisultato.Text =  "Inserisci valori validi per la base o l'altezza";
                return;
            }

            CRettangolo rettangolo = new CRettangolo("Rettangolo", baseR, altezzaR);
            TxtRisultato.Text = rettangolo.Descrizione();
        }else if(figuraSelezionata == 2)
        {
            if (!float.TryParse(TxtCampo1.Text, out float lato))
            {
                TxtRisultato.Text = "Inserisci valori validi per il lato del quadrato";
                return;
            }

            CQuadrato quadrato = new CQuadrato("Quadrato", lato);
            TxtRisultato.Text = quadrato.Descrizione();
        }
        else
        {
            if (!float.TryParse(TxtCampo1.Text, out float raggio))
            {
                TxtRisultato.Text = "Inserisci valori validi per il raggio del cerchio";
                return;
            }

            CCerchio cerchio = new CCerchio("Cerchio", raggio);
            TxtRisultato.Text = cerchio.Descrizione();
        }
    }
}