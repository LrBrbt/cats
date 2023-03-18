using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace cats
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void WatchCatsBTN_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Random rnd = new();
                int numberCat = rnd.Next(1, 61);
                CaptionTXT.Text = "";
                CaptionTXT.Foreground = Brushes.Black;
                CaptionTXT.FontWeight = FontWeights.Bold;

                if (numberCat == 1)
                {
                    CatImage.Source = new BitmapImage(new Uri("./catsImages/котик (1).jpeg", UriKind.Relative));
                    CaptionTXT.Text = "Не пейте это не кофи, это котяты!!!";
                }
                if (numberCat == 2)
                {
                    CatImage.Source = new BitmapImage(new Uri("./catsImages/котик (2).jpg", UriKind.Relative));
                    CaptionTXT.Text = "Злой котя (но с цветочком)";
                }
                if (numberCat == 3)
                {
                    CatImage.Source = new BitmapImage(new Uri("./catsImages/котик (3).jpeg", UriKind.Relative));
                    CaptionTXT.Text = "Лежит, смотрит на тебя, такого милашкинса)";
                }
                if (numberCat == 4)
                {
                    CatImage.Source = new BitmapImage(new Uri("./catsImages/котик (4).jpg", UriKind.Relative));
                    CaptionTXT.Text = "Красивый котик в красивых цветочках)";
                }
                if (numberCat == 5)
                {
                    CatImage.Source = new BitmapImage(new Uri("./catsImages/котик (5).jpg", UriKind.Relative));
                    CaptionTXT.Text = "Лежит (кверху пузиком)";
                }
                if (numberCat == 6)
                {
                    CatImage.Source = new BitmapImage(new Uri("./catsImages/котик (6).jpg", UriKind.Relative));
                    CaptionTXT.Text = "Болбшой кот (но пока чьто малыш)";
                }
                if (numberCat == 7)
                {
                    CatImage.Source = new BitmapImage(new Uri("./catsImages/котик (7).jpg", UriKind.Relative));
                    CaptionTXT.Text = "Болбшой кот!";
                }
                if (numberCat == 8)
                {
                    CatImage.Source = new BitmapImage(new Uri("./catsImages/котик (8).jpg", UriKind.Relative));
                    CaptionTXT.Text = "Ведь ты как я, а я как ты...";
                }
                if (numberCat == 9)
                {
                    CatImage.Source = new BitmapImage(new Uri("./catsImages/котик (9).jpg", UriKind.Relative));
                    CaptionTXT.Text = "... Мы как две капельки воды";
                }
                if (numberCat == 10)
                {
                    CatImage.Source = new BitmapImage(new Uri("./catsImages/котик (10).jpg", UriKind.Relative));
                    CaptionTXT.Text = "Чихает? Орет?? Зевает???";
                }
                if (numberCat == 11)
                {
                    CatImage.Source = new BitmapImage(new Uri("./catsImages/котик (11).jpg", UriKind.Relative));
                    CaptionTXT.Text = "Испуган (инсульт попы)";
                }
                if (numberCat == 12)
                {
                    CatImage.Source = new BitmapImage(new Uri("./catsImages/котик (12).jpg", UriKind.Relative));
                    CaptionTXT.Text = "Когда скоро сессия: ";
                }
                if (numberCat == 13)
                {
                    CatImage.Source = new BitmapImage(new Uri("./catsImages/котик (13).jpg", UriKind.Relative));
                    CaptionTXT.Text = "Делает кусь(()())";
                }
                if (numberCat == 14)
                {
                    CatImage.Source = new BitmapImage(new Uri("./catsImages/котик (14).jpg", UriKind.Relative));
                    CaptionTXT.Text = "Покоритель женских сердец";
                }
                if (numberCat == 15)
                {
                    CatImage.Source = new BitmapImage(new Uri("./catsImages/котик (15).jpg", UriKind.Relative));
                    CaptionTXT.Text = "Он полетел...";
                }
                if (numberCat == 16)
                {
                    CatImage.Source = new BitmapImage(new Uri("./catsImages/котик (16).jpg", UriKind.Relative));
                    CaptionTXT.Text = "Вот это да, целая корзина пусек!!!";
                }
                if (numberCat == 17)
                {
                    CatImage.Source = new BitmapImage(new Uri("./catsImages/котик (17).jpg", UriKind.Relative));
                    CaptionTXT.Text = "Love is...";
                }
                if (numberCat == 18)
                {
                    CatImage.Source = new BitmapImage(new Uri("./catsImages/котик (18).jpg", UriKind.Relative));
                    CaptionTXT.Text = "o_O";
                }
                if (numberCat == 19)
                {
                    CatImage.Source = new BitmapImage(new Uri("./catsImages/котик (19).jpg", UriKind.Relative));
                    CaptionTXT.Text = "Каждое утро би лайк";
                }
                if (numberCat == 20)
                {
                    CatImage.Source = new BitmapImage(new Uri("./catsImages/котик (20).jpg", UriKind.Relative));
                    CaptionTXT.Text = "Блин котенок ты чего наделал, я теперь тоже хочу...";
                }
                if (numberCat == 21)
                {
                    CatImage.Source = new BitmapImage(new Uri("./catsImages/котик (21).jpg", UriKind.Relative));
                    CaptionTXT.Text = "Радужный (не ЛГБТ..наверное)";
                }
                if (numberCat == 22)
                {
                    CatImage.Source = new BitmapImage(new Uri("./catsImages/котик (22).jpg", UriKind.Relative));
                    CaptionTXT.Text = "Сидит в шоке (как мы на парах некоторых преподов)";
                }
                if (numberCat == 23)
                {
                    CatImage.Source = new BitmapImage(new Uri("./catsImages/котик (23).jpg", UriKind.Relative));
                    CaptionTXT.Text = "Он падает?";
                }
                if (numberCat == 24)
                {
                    CatImage.Source = new BitmapImage(new Uri("./catsImages/котик (24).jpg", UriKind.Relative));
                    CaptionTXT.Text = "Грустит чего-то.. Котенок, не грусти!";
                }
                if (numberCat == 25)
                {
                    CatImage.Source = new BitmapImage(new Uri("./catsImages/котик (25).jpg", UriKind.Relative));
                    CaptionTXT.Text = "В такие моменты хочется быть котом";
                }
                if (numberCat == 26)
                {
                    CatImage.Source = new BitmapImage(new Uri("./catsImages/котик (26).jpg", UriKind.Relative));
                    CaptionTXT.Text = "Просто котик";
                }
                if (numberCat == 27)
                {
                    CatImage.Source = new BitmapImage(new Uri("./catsImages/котик (27).jpg", UriKind.Relative));
                    CaptionTXT.Text = "Котики явно выиграли эту лотерею под названием Жизнь";
                }
                if (numberCat == 28)
                {
                    CatImage.Source = new BitmapImage(new Uri("./catsImages/котик (28).jpg", UriKind.Relative));
                    CaptionTXT.Text = "Злится. Злой. Опасный.";
                }
                if (numberCat == 29)
                {
                    CatImage.Source = new BitmapImage(new Uri("./catsImages/котик (29).jpg", UriKind.Relative));
                    CaptionTXT.Text = "Котики целуются <3";
                }
                if (numberCat == 30)
                {
                    CatImage.Source = new BitmapImage(new Uri("./catsImages/котик (30).jpg", UriKind.Relative));
                    CaptionTXT.Text = "Забота)";
                }
                if (numberCat == 31)
                {
                    CatImage.Source = new BitmapImage(new Uri("./catsImages/котик (31).jpg", UriKind.Relative));
                    CaptionTXT.Text = "Сидят и не вдупляют, что происходит. Понимаю их";
                }
                if (numberCat == 32)
                {
                    CatImage.Source = new BitmapImage(new Uri("./catsImages/котик (32).jpg", UriKind.Relative));
                    CaptionTXT.Text = "Никто не готов, никто...";
                }
                if (numberCat == 33)
                {
                    CatImage.Source = new BitmapImage(new Uri("./catsImages/котик (33).jpg", UriKind.Relative));
                    CaptionTXT.Text = "Он что спокойно купается???";
                }
                if (numberCat == 34)
                {
                    CatImage.Source = new BitmapImage(new Uri("./catsImages/котик (34).jpg", UriKind.Relative));
                    CaptionTXT.Text = "Селфиии ;)";
                }
                if (numberCat == 35)
                {
                    CatImage.Source = new BitmapImage(new Uri("./catsImages/котик (35).jpg", UriKind.Relative));
                    CaptionTXT.Text = "Котик легкого поведения (не осуждаем)";
                }
                if (numberCat == 36)
                {
                    CatImage.Source = new BitmapImage(new Uri("./catsImages/котик (36).jpg", UriKind.Relative));
                    CaptionTXT.Text = "Спят пирожочки";
                }
                if (numberCat == 37)
                {
                    CatImage.Source = new BitmapImage(new Uri("./catsImages/котик (37).jpg", UriKind.Relative));
                    CaptionTXT.Text = "Легенда. Мяяяу >:(";
                }
                if (numberCat == 38)
                {
                    CatImage.Source = new BitmapImage(new Uri("./catsImages/котик (38).jpg", UriKind.Relative));
                    CaptionTXT.Text = "Каждое утро просыпаюсь с таким лицом";
                }
                if (numberCat == 39)
                {
                    CatImage.Source = new BitmapImage(new Uri("./catsImages/39.jpg", UriKind.Relative));
                    CaptionTXT.Text = "Лежит, отдыхает))";
                }
                if (numberCat == 40)
                {
                    CatImage.Source = new BitmapImage(new Uri("./catsImages/40.jpg", UriKind.Relative));
                    CaptionTXT.Text = "- Ну не кусяй((\n-БУДУ! >:)";
                }
                if (numberCat == 41)
                {
                    CatImage.Source = new BitmapImage(new Uri("./catsImages/41).jpg", UriKind.Relative));
                    CaptionTXT.Text = "Когда помешали красть конфеты";
                }
                if (numberCat == 42)
                {
                    CatImage.Source = new BitmapImage(new Uri("./catsImages/42.jpg", UriKind.Relative));
                    CaptionTXT.Text = ":3";
                }
                if (numberCat == 43)
                {
                    CatImage.Source = new BitmapImage(new Uri("./catsImages/43.jpg", UriKind.Relative));
                    CaptionTXT.Text = "Конфетька :)";
                }
                if (numberCat == 44)
                {
                    CatImage.Source = new BitmapImage(new Uri("./catsImages/44.jpg", UriKind.Relative));
                    CaptionTXT.Text = "Рамштайн играет";
                }
                if (numberCat == 45)
                {
                    CatImage.Source = new BitmapImage(new Uri("./catsImages/45.jpg", UriKind.Relative));
                    CaptionTXT.Text = "Ох уж эта семейная жизнь...";
                }
                if (numberCat == 46)
                {
                    CatImage.Source = new BitmapImage(new Uri("./catsImages/46.jpg", UriKind.Relative));
                    CaptionTXT.Text = "Чокопайка убегает :000";
                }
                if (numberCat == 47)
                {
                    CatImage.Source = new BitmapImage(new Uri("./catsImages/47.jpg", UriKind.Relative));
                    CaptionTXT.Text = "Ой а кто у нас такой просыпается?!?";
                }
                if (numberCat == 48)
                {
                    CatImage.Source = new BitmapImage(new Uri("./catsImages/48.jpg", UriKind.Relative));
                    CaptionTXT.Text = "Мы правда помогаем работать!!!";
                }
                if (numberCat == 49)
                {
                    CatImage.Source = new BitmapImage(new Uri("./catsImages/49.jpg", UriKind.Relative));
                    CaptionTXT.Text = "Мем";
                }
                if (numberCat == 50)
                {
                    CatImage.Source = new BitmapImage(new Uri("./catsImages/50.jpg", UriKind.Relative));
                    CaptionTXT.Text = "Чебупеля";
                }
                if (numberCat == 51)
                {
                    CatImage.Source = new BitmapImage(new Uri("./catsImages/51.jpg", UriKind.Relative));
                    CaptionTXT.Text = "Хей беби герл вот ю дуинг тунайт";
                }
                if (numberCat == 52)
                {
                    CatImage.Source = new BitmapImage(new Uri("./catsImages/52.jpg", UriKind.Relative));
                    CaptionTXT.Text = "Теперь это не тапок а его дом";
                }
                if (numberCat == 53)
                {
                    CatImage.Source = new BitmapImage(new Uri("./catsImages/53.jpg", UriKind.Relative));
                    CaptionTXT.Text = "Воздушная зефирка";
                }
                if (numberCat == 54)
                {
                    CatImage.Source = new BitmapImage(new Uri("./catsImages/54.jpg", UriKind.Relative));
                    CaptionTXT.Text = "Весь семейный бюджет и так на мне, работа на мне, еще и продукты самой таскать...";
                }
                if (numberCat == 55)
                {
                    CatImage.Source = new BitmapImage(new Uri("./catsImages/55.jpg", UriKind.Relative));
                    CaptionTXT.Text = ":3";
                }
                if (numberCat == 56)
                {
                    CatImage.Source = new BitmapImage(new Uri("./catsImages/56.jpg", UriKind.Relative));
                    CaptionTXT.Text = "Красавец)";
                }
                if (numberCat == 57)
                {
                    CatImage.Source = new BitmapImage(new Uri("./catsImages/57.jpg", UriKind.Relative));
                    CaptionTXT.Text = "Цветочек :3";
                }
                if (numberCat == 58)
                {
                    CatImage.Source = new BitmapImage(new Uri("./catsImages/58.jpg", UriKind.Relative));
                    CaptionTXT.Text = "ГОСПОДИ КАКАЯ ЖИЗА ЭТО Я НА ВСЕ 1000%";
                }
                if (numberCat == 59)
                {
                    CatImage.Source = new BitmapImage(new Uri("./catsImages/59.jpg", UriKind.Relative));
                    CaptionTXT.Text = "Обнимааашки";
                }
                if (numberCat == 60)
                {
                    CatImage.Source = new BitmapImage(new Uri("./catsImages/60.jpg", UriKind.Relative));
                    CaptionTXT.Text = "Вам шикарный букет";
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
