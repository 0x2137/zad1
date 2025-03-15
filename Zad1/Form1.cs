using System.Diagnostics;
using System.Windows.Forms;

namespace Zad1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonOblicz_Click(object sender, EventArgs e)
        {
            try
            {
                double liczba1 = double.Parse(Dzielna.Text);
                double liczba2 = double.Parse(Dzielnik.Text);

                // liczby są typu double, dla którego dzielenie przez 0.0 zwraca nieskończoność
                if (liczba2 == 0.0)
                {
                    throw new DivideByZeroException();
                }

                double wynik = liczba1 / liczba2;

                Wynik.Text = wynik.ToString();
            }
            catch (FormatException)
            {
                string wiadomosc = "Błąd: Wprowadzono niepoprawne liczby.";
                Wynik.Text = wiadomosc;
                ZapiszWyjatekDoDziennika(wiadomosc);
            }
            catch (DivideByZeroException)
            {
                string wiadomosc = "Błąd: Nie można dzielić przez zero.";
                Wynik.Text = wiadomosc;
                ZapiszWyjatekDoDziennika(wiadomosc);
            }
            catch (Exception ex)
            {
                string wiadomosc = $"Nieoczekiwany błąd: {ex.Message}";
                Wynik.Text = wiadomosc;
                ZapiszWyjatekDoDziennika(wiadomosc);
            }
        }

        private void ZapiszWyjatekDoDziennika(string wiadomosc)
        {
            string source = "Zad1";
            string log = "DziennikZad1";

            // za pierwszym uruchomieniem lub po zmianie źródła należy
            // uruchomić program jako administrator
            if (!EventLog.SourceExists(source))
            {
                EventLog.CreateEventSource(source, log);
            }

            EventLog.WriteEntry(source, wiadomosc, EventLogEntryType.Error);
        }
    }
}
