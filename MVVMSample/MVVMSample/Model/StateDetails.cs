using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace MVVMSample
{
    public class StateDetails : INotifyPropertyChanged
    {
        #region Private variables
        private string name, capital, largestcity, language;
        private double population;
        private string province;
        #endregion
        #region public properties
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                OnPropertyChanged(nameof(Name));
            }
        }
        public string Capital
        {
            get
            {
                return capital;
            }
            set
            {
                capital = value;
                OnPropertyChanged(nameof(Capital));
            }
        }
        public string LargestCity
        {
            get
            {
                return largestcity;
            }
            set
            {
                largestcity = value;
                OnPropertyChanged(nameof(LargestCity));
            }
        }
        public string Language
        {
            get { return language; }
            set
            {
                language = value;
                OnPropertyChanged(nameof(Language));
            }
        }
        public string Province
        {
            get { return province; }
            set
            {
                province = value;
                OnPropertyChanged(nameof(Province));
            }
        }
        public double Population
        {
            get
            {
                return population;
            }
            set
            {
                population = value;
                OnPropertyChanged(nameof(Population));
            }
        }
        #endregion
        #region StateDetails ViewModel
        public StateDetails(string name, string capital, string city, string language, string province, double population)
        {
            Name = name;
            Capital = capital;
            LargestCity = city;
            Language = language;
            Province = province;
            Population = population;
        }
        #endregion
        #region INotifyPropertyChanged implementation
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string str)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(str));
        }
        #endregion
    }
}
