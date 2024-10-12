using CommunityToolkit.Mvvm.ComponentModel;
using PAM_Calculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PAM_Calculator.ViewModels
{
    public partial class CalculatorViewModel : ObservableObject
    {
        [ObservableProperty]
        private double primeiroTermo;
        [ObservableProperty]
        private double segundoTermo;
        [ObservableProperty]
        private double resultado;

        public ICommand SomarCommand { get; }
        public ICommand SubtrairCommand { get; }
        public ICommand MultiplicarCommand { get; }
        public ICommand DividirCommand { get ; }
        public ICommand ElevarCommand { get; }
        public ICommand RaizCommand { get; }
        public CalculatorViewModel() { 
            SomarCommand = new Command(Somar);
            SubtrairCommand = new Command(Subtrair);
            MultiplicarCommand = new Command(Multiplicar);
            DividirCommand = new Command(Dividir);
            ElevarCommand = new Command(Elevar);
            RaizCommand = new Command(Raiz);
        }

        public void Somar()
        {
            Resultado = new Calculator().Somar(PrimeiroTermo, SegundoTermo);
        }
        public void Subtrair()
        {
            Resultado = new Calculator().Subtrair(PrimeiroTermo, SegundoTermo);
        }
        public void Multiplicar()
        {
            Resultado = new Calculator().Multiplicar(PrimeiroTermo, SegundoTermo);
        }
        public void Dividir()
        {
            Resultado = new Calculator().Dividir(PrimeiroTermo, SegundoTermo);
        }
        public void Elevar()
        {
            Resultado = new Calculator().Elevar(PrimeiroTermo, SegundoTermo);
        }
        public void Raiz()
        {
            Resultado = new Calculator().Raiz(PrimeiroTermo, SegundoTermo);
        }
    }
}
