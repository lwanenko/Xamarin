using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace TaskRadacode
{
    public partial class MainPage : ContentPage
    {
        #region VAR

            #region Xamarin.Forms Obj
        Label header;
        Entry FirstNameEntry,// \
              LastNameEntry, //  \
              CountryEntry,  //   > поля для введення 
              CityEntry,     //  /
              UnivEntry;     // /

        Picker PCountry,   // \
               PCity,      //  > вспливаючі вікна 
               PUniversity;// /

        Button ButGetBlank,
               ButNext_Country,// \
               ButNext_City,   //  > кнопки для, переведення 
               ButNext_Univ;   // /
        StackLayout layout  = new StackLayout()
                                  {
                                    BackgroundColor = Color.White,                                   
                                  },//головний Layout
                    country = new StackLayout(),   // \
                    city    = new StackLayout(),   //  > допоміжні, для введення країни, міста, ВНЗ
                    univ    = new StackLayout();   // /
        #endregion

        ListMaker lm = new ListMaker();
        /* лісти, які зберігають  / */List<Country> lCountry = new List<Country>();
        /*  значення завантажені <  */List<City> lCity = new List<City>();
        /*              з Vk Api  \ */List<University> lUniv = new List<University>();        

        int idCountry =-1,//id вибраної  країни
            idCity=-1,    //id вибраного міста
            idUniv =-1;   //id вибраного ВНЗ

        #endregion

        public MainPage()
        {
            InitializeComponent();

            //Label
            header = new Label
            {
                Text = "Бланк",
                HorizontalOptions = LayoutOptions.Center,
                TextColor = Color.Black,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
            };
            //Entry
            FirstNameEntry = new Entry
            {
                Placeholder = "Имя",
                TextColor = Color.Black,
                HorizontalOptions = LayoutOptions.Start,
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Entry)),
                WidthRequest = 200
            };
            FirstNameEntry.TextChanged += getLastName;
            LastNameEntry = new Entry
            {
                Placeholder = "Фамилия",
                TextColor = Color.Black,
                HorizontalOptions = LayoutOptions.Start,
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Entry)),
                WidthRequest = 200,
                IsEnabled = false
            };
            LastNameEntry.TextChanged += getCCU;
            CountryEntry = new Entry
            {
                Placeholder = "Название страны",
                TextColor = Color.Gray,
                HorizontalOptions = LayoutOptions.Center,
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Entry)),
                WidthRequest = 200,
                //Margin = new Thickness(300,0,0,0),
                IsEnabled = false
            };
            CountryEntry.TextChanged += showPCountry;
            TheListerCountry();
            CityEntry = new Entry
            {
                Placeholder = "Название города",
                TextColor = Color.Gray,
                HorizontalOptions = LayoutOptions.Center,
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Entry)),
                WidthRequest = 200,               
                IsEnabled = false
            };
            CityEntry.TextChanged += showPCity;
            UnivEntry = new Entry
            {
                Placeholder = "Название Университета",
                TextColor = Color.Gray,
                HorizontalOptions = LayoutOptions.Center,
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Entry)),
                WidthRequest = 200,
                IsEnabled = false
            };
            UnivEntry.TextChanged += showPUniv;

            //Pickers
            PCountry = new Picker
            {
                HorizontalOptions = LayoutOptions.Center,
                TextColor = Color.Gray,
                WidthRequest = 150,
                IsEnabled = false
            };
            PCountry.SelectedIndexChanged += Country_SelectedIndexChanged;
            PCity = new Picker
            {
                HorizontalOptions = LayoutOptions.Center,
                TextColor = Color.Gray,
                WidthRequest = 150,
                IsEnabled = false
            };
            PCity.SelectedIndexChanged += City_SelectedIndexChanged;
            PUniversity = new Picker
            {
                HorizontalOptions = LayoutOptions.Center,
                TextColor = Color.Gray,
                WidthRequest = 150,
                IsEnabled = false
            };
            PUniversity.SelectedIndexChanged += Univ_SelectedIndexChanged;

            //Button
            ButGetBlank = new Button
            {
                Text = "Заполнить бланк",
                HorizontalOptions = LayoutOptions.Center,
                TextColor = Color.Gray,
                FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label)),               
                IsEnabled = false
            };
            ButGetBlank.Clicked += OnButtonClicked;
            ButNext_Country = new Button
            {
                Text = "<=",
                HorizontalOptions = LayoutOptions.Center,
                TextColor = Color.Gray,
                FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label)),
                IsEnabled = false
            };
            ButNext_Country.Clicked += getCountry;
            ButNext_City = new Button
            {
                Text = "<=",
                HorizontalOptions = LayoutOptions.Center,
                TextColor = Color.Gray,
                FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label)),
                IsEnabled = false
            };
            ButNext_City.Clicked += getCity;
            ButNext_Univ = new Button
            {
                Text = "<=",
                HorizontalOptions = LayoutOptions.Center,
                TextColor = Color.Gray,
                FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label)),
                IsEnabled = false
            };
            ButNext_Univ.Clicked += getUniv;

            //StackLayout
            country = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                IsEnabled = false
            };
                country.Children.Add(CountryEntry);
                country.Children.Add(ButNext_Country);
                country.Children.Add(PCountry);
            city = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                IsEnabled = false
            };
                city.Children.Add(CityEntry);
                city.Children.Add(ButNext_City);
                city.Children.Add(PCity);
            univ = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                IsEnabled = false
            };
                univ.Children.Add(UnivEntry);
                univ.Children.Add(ButNext_Univ);
                univ.Children.Add(PUniversity);

            //Add to layout            
            layout.Children.Add(header);
            layout.Children.Add(FirstNameEntry);
            layout.Children.Add(LastNameEntry);
            layout.Children.Add(country);
            layout.Children.Add(city);
            layout.Children.Add(univ);
            layout.Children.Add(ButGetBlank);

            StackLayout s = new StackLayout()
            {
                BackgroundColor = Color.White,
                HorizontalOptions = LayoutOptions.Center
            };
            s.Children.Add(layout);
            this.Content = s;
        }
        
        /// <summary>
        /// Надає доступ до введення Країни, Міста, Університету
        /// </summary>
        private void getCCU(object sender, TextChangedEventArgs e)//відкриває для доступу country, city, univ
        {
            country.IsEnabled = true;
                CountryEntry.IsEnabled = true;
                PCountry.IsEnabled = true;
                ButNext_Country.IsEnabled = true;
            city.IsEnabled = true;
                CityEntry.IsEnabled = true;
                PCity.IsEnabled = true;
                ButNext_City.IsEnabled = true;
            univ.IsEnabled = true;
                UnivEntry.IsEnabled = true;
                PUniversity.IsEnabled = true;
                ButNext_Univ.IsEnabled = true;
        }

        /// <summary>
        /// Відкриває доступ до введення Прізвища
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void getLastName(object sender, TextChangedEventArgs e)
        {
            LastNameEntry.IsEnabled = true;
        }

        //===========================================================//
        //при введенні в Entry з країнами, містами чи університетами,//
        // активується відповідний Pickers(функція showP****)        //
        //===========================================================//
        private void showPUniv(object sender, TextChangedEventArgs e)
        {
            PUniversity = new Picker()
            {
                HorizontalOptions = LayoutOptions.Center,
                TextColor = Color.Gray,
                WidthRequest = 200
            };
            foreach (var cur in lUniv)
                if (cur.ToString().StartsWith(UnivEntry.Text))
                    PUniversity.Items.Add(cur.ToString());
            if (PUniversity.Items.Count > 0)
                PUniversity.Title = PUniversity.Items[0];
            univ.Children.RemoveAt(2);
            univ.Children.Add(PUniversity);
        }
        private void Univ_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = PUniversity.Items[PCity.SelectedIndex];
            foreach (var cur in lUniv)
                if (s == cur.ToString())
                {
                    idUniv = cur.id;
                    break;
                }

        }
        private void getUniv(object sender, EventArgs e)
        {
            string s = "";
            if (PUniversity.SelectedIndex == -1)
                s = PUniversity.Title.ToString();
            else s = PUniversity.Items[PUniversity.SelectedIndex];
            UnivEntry.Text = s;

            foreach (var cur in lUniv)
                if (s == cur.ToString())
                {
                    idUniv = cur.id;
                    break;
                }
            if (idUniv != -1) ButGetBlank.IsEnabled = true;
        }

        private void showPCity(object sender, TextChangedEventArgs e)
        {
           
            PCity = new Picker()
            {
                HorizontalOptions = LayoutOptions.Center,
                TextColor = Color.Gray,
                WidthRequest = 200
            };
            TheListnerCity(CityEntry.Text);
            foreach (var cur in lCity)
                if (cur.ToString().StartsWith(CityEntry.Text))
                    PCity.Items.Add(cur.ToString());
            if (PCity.Items.Count > 0)
                PCity.Title = PCity.Items[0];
            city.Children.RemoveAt(2);
            city.Children.Add(PCity);
        }
        private void City_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = PCity.Items[PCity.SelectedIndex];
            CityEntry.Text = s;
            idUniv = -1;
            UnivEntry.Text = "";
            
            foreach (var cur in lCity)
                if (s == cur.ToString())
                {
                    idCity = cur.id;
                    break;
                }
            if (idCity != -1)
            {            
                lUniv.Clear();
                TheListnerUniv("");
            }
        }
        private void getCity(object sender, EventArgs e)
        {
            string s = "";
            if (PCity.SelectedIndex == -1)
                s = PCity.Title.ToString();
            else s = PCity.Items[PCity.SelectedIndex];
            CityEntry.Text = s;

            foreach (var cur in lCity)
                if (s == cur.ToString())
                {
                    idCity = cur.id;
                    break;
                }
            if (idCity != -1) TheListnerUniv("");
        }

        private void showPCountry(object sender, TextChangedEventArgs e)
        {
            
            PCountry = new Picker()
            {
                HorizontalOptions = LayoutOptions.Center,
                TextColor = Color.Gray,
                WidthRequest = 200
            };
             foreach (var cur in lCountry)
                if (cur.ToString().StartsWith(CountryEntry.Text))
                    PCountry.Items.Add(cur.ToString());
            if (PCountry.Items.Count > 0)
                PCountry.Title = PCountry.Items[0];
            country.Children.RemoveAt(2);
            country.Children.Add(PCountry);
        }
        private void Country_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = PCountry.Items[PCountry.SelectedIndex];
            CountryEntry.Text = s;
            
            idCity = -1;
            CityEntry.Text = "";
            idUniv = -1;
            UnivEntry.Text = "";

            foreach (var cur in lCountry)
                if (s == cur.ToString())
                {
                    idCountry = cur.id;
                    break;           
                }       
        }
        private void getCountry(object sender, EventArgs e)
        {
            string s = "";
            if (PCountry.SelectedIndex == -1)
                s = PCountry.Title.ToString();
            else s = PCountry.Items[PCountry.SelectedIndex];
                CountryEntry.Text = s;
                  
                foreach (var cur in lCountry)
                    if (s == cur.ToString())
                    {
                        idCountry = cur.id;
                        break;
                    }
                if (idCountry != -1) TheListnerCity("");                                       
        }

        //викликаэмо нову форму з результатами бланку
        private async void OnButtonClicked(object sender, EventArgs e)
        {           
            await Navigation.PushModalAsync(new NextPage("Имя: "    + FirstNameEntry.Text,
                                                         "Фамилия: "+ LastNameEntry.Text,
                                                         "Страна: " + CountryEntry.Text,
                                                         "Город: "  + CityEntry.Text,
                                                         "ВУЗ: "    + UnivEntry.Text));
        }

        #region обробники запитів Країни, Міста, ВНЗ
        public async void TheListerCountry()
        {
            lCountry = await lm.GetCountryListAsync();
        }
        public async void TheListnerCity(string q)
        {
            lCity = await lm.GetCityListAsync(idCountry, q);
        }
        public async void TheListnerUniv(string q)
        {
            lUniv = await lm.GetUnivListAsync(idCountry, idCity, q);
        }
        #endregion
    }
}

