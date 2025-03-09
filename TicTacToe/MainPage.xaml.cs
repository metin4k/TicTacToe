namespace TicTacToe
{
    public partial class MainPage : ContentPage
    {
        int tura = 0;
        bool czyGra = true;

        public MainPage()
        {
            InitializeComponent();
        }

        void clear()
        {
            Btn1.Opacity = 0.5;
            Btn2.Opacity = 0.5;
            Btn3.Opacity = 0.5;
            Btn4.Opacity = 0.5;
            Btn5.Opacity = 0.5;
            Btn6.Opacity = 0.5;
            Btn7.Opacity = 0.5;
            Btn8.Opacity = 0.5;
            Btn9.Opacity = 0.5;
        }


        private void Check()
        {
            if (tura > 4)
            {

                if (Btn1.Text == Btn2.Text && Btn2.Text == Btn3.Text && (Btn1.Text == "X" || Btn1.Text == "O"))
                {
                    czyGra = false;
                    clear();
                    Btn1.Opacity = 1;
                    Btn2.Opacity = 1;
                    Btn3.Opacity = 1;
                }
                else if (Btn4.Text == Btn5.Text && Btn5.Text == Btn6.Text && (Btn4.Text == "X" || Btn4.Text == "O"))
                {
                    czyGra = false;
                    clear();
                    Btn4.Opacity = 1;
                    Btn5.Opacity = 1;
                    Btn6.Opacity = 1;
                }
                else if (Btn7.Text == Btn8.Text && Btn8.Text == Btn9.Text && (Btn7.Text == "X" || Btn7.Text == "O"))
                {
                    czyGra = false;
                    clear();
                    Btn7.Opacity = 1;
                    Btn8.Opacity = 1;
                    Btn9.Opacity = 1;
                }
                else if (Btn1.Text == Btn5.Text && Btn5.Text == Btn9.Text && (Btn1.Text == "X" || Btn1.Text == "O"))
                {
                    czyGra = false;
                    clear();
                    Btn1.Opacity = 1;
                    Btn5.Opacity = 1;
                    Btn9.Opacity = 1;
                }
                else if (Btn3.Text == Btn5.Text && Btn5.Text == Btn7.Text && (Btn3.Text == "X" || Btn3.Text == "O"))
                {
                    czyGra = false;
                    clear();
                    Btn3.Opacity = 1;
                    Btn5.Opacity = 1;
                    Btn7.Opacity = 1;
                }
                else if (Btn1.Text == Btn4.Text && Btn4.Text == Btn7.Text && (Btn1.Text == "X" || Btn1.Text == "O"))
                {
                    czyGra = false;
                    clear();
                    Btn1.Opacity = 1;
                    Btn4.Opacity = 1;
                    Btn7.Opacity = 1;
                }
                else if (Btn2.Text == Btn5.Text && Btn5.Text == Btn8.Text && (Btn2.Text == "X" || Btn2.Text == "O"))
                {
                    czyGra = false;
                    clear();
                    Btn2.Opacity = 1;
                    Btn5.Opacity = 1;
                    Btn8.Opacity = 1;
                }
                else if (Btn3.Text == Btn6.Text && Btn6.Text == Btn9.Text && (Btn3.Text == "X" || Btn3.Text == "O"))
                {
                    czyGra = false;
                    clear();
                    Btn3.Opacity = 1;
                    Btn6.Opacity = 1;
                    Btn9.Opacity = 1;
                }


            }
        }

        private void OnBtnClicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (czyGra)
            {
                if (tura % 2 == 0) btn.Text = "X";
                else btn.Text = "O";
                tura++;
                btn.IsEnabled = false;
                Check();
            }
        }



        private void OnResetClicked(object sender, EventArgs e)
        {
            tura = 0;

            Btn1.Text = "";
            Btn1.IsEnabled = true;

            Btn2.Text = "";
            Btn2.IsEnabled = true;


            Btn3.Text = "";
            Btn3.IsEnabled = true;


            Btn4.Text = "";
            Btn4.IsEnabled = true;


            Btn5.Text = "";
            Btn5.IsEnabled = true;


            Btn6.Text = "";
            Btn6.IsEnabled = true;


            Btn7.Text = "";
            Btn7.IsEnabled = true;

            Btn8.Text = "";
            Btn8.IsEnabled = true;

            Btn9.Text = "";
            Btn9.IsEnabled = true;

            Btn1.Opacity = 1;
            Btn2.Opacity = 1;
            Btn3.Opacity = 1;
            Btn4.Opacity = 1;
            Btn5.Opacity = 1;
            Btn6.Opacity = 1;
            Btn7.Opacity = 1;
            Btn8.Opacity = 1;
            Btn9.Opacity = 1;


            czyGra = true;
        }




    }
}