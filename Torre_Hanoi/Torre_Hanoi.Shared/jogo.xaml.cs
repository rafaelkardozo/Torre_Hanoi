using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Threading;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Torre_Hanoi
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    
    public sealed partial class jogo : Page
    {
        
        
        public jogo()
        {
            this.InitializeComponent();
          


        }
        int disco_aux=0;
        Stack<int> torre1 = new Stack<int>();
        Stack<int> torre2 = new Stack<int>();
        Stack<int> torre3 = new Stack<int>();
        
        
       
        
        
       

        private void bt_iniciar_jogo_Click(object sender, RoutedEventArgs e)
        {
            IniciaJogo();
        }

        // BOTAO EMPILHAR TORRE1
        private void bt_empilhar_torre1_Click(object sender, RoutedEventArgs e)
        {

            if (ValidaEmpilhamento(torre1.Count(), torre1.Peek(), disco_aux))
            {
                torre1.Push(disco_aux);
                txb_meio.Text = "Disco Empilhado";
            }
            else txb_meio.Text = "Movimento Incorreto";

        }//FIM DO BOTAO EMPILHAR TORRE1

        //BOTAO DESEMPILHAR TORRE1
        private void bt_desempilhar_torre1_Click(object sender, RoutedEventArgs e)
        {

        }

        


        
        //METODO PARA INICIAR JOGO
        private void IniciaJogo(){
            
            //PREENCHENDO A PILHA TORRE1
            torre1.Push(4); torre1.Push(3); torre1.Push(2); torre1.Push(1);
            
            //TORNANDO VISIVEIS AS ARGOLAS NA TORRE1
            img_argola1.Visibility = Visibility.Visible;
            img_argola2.Visibility = Visibility.Visible;
            img_argola3.Visibility = Visibility.Visible;
            img_argola4.Visibility = Visibility.Visible;
            
            //TORNANDO VISIVEIS OS BOTOES DAS TORRES
            bt_empilhar_torre1.Visibility = Visibility.Visible; bt_desempilhar_torre1.Visibility = Visibility.Visible;
            bt_empilhar_torre2.Visibility = Visibility.Visible; bt_desempilhar_torre2.Visibility = Visibility.Visible;
            bt_empilhar_torre3.Visibility = Visibility.Visible; bt_desempilhar_torre3.Visibility = Visibility.Visible;

        }
        //FIM DO METODO PARA INCIAR JOGO
        
        //METODO DE VALIDACAO DE EMPILHAMENTO DOS DISCOS
        private bool ValidaEmpilhamento(int tamanhoTorre, int topo, int aux ){

            if ((tamanhoTorre < 4)||(topo<aux) ) return true;
            else return false;

        }
        //FIM DO METODO DE VALIDACAO DE EMPILHAMENTO

        //METODO DE VALIDACAO DESEMPILHAR
        private bool ValidaDesempilhamento(int tamanho)
        {
            if (tamanho > 0) return true;
            else return false;

        }



        

        
    }
}
