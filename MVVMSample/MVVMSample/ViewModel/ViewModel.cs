using Syncfusion.SfDataGrid.XForms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVMSample
{

    class ViewModel : INotifyPropertyChanged
    {
        #region Private variables
        private ObservableCollection<string> StateProvince = new ObservableCollection<string>();
        private ObservableCollection<StateDetails> states = new ObservableCollection<StateDetails>();
        private bool isHidden;
        #endregion
        #region Public Properties
        public ICommand HideCommand { get; set; }
        public bool IsHidden
        {
            get { return isHidden; }
            set { isHidden = value;
                OnPropertyChanged(nameof(IsHidden));
            }
        }
        public ObservableCollection<StateDetails> State
        {
            get { return states; }
            set
            {
                states = value;
                OnPropertyChanged(nameof(State));
            }
        }
        public ObservableCollection<string> StatesProvince
        {
            get { return StateProvince; }
            set
            {
                StateProvince = value;
                OnPropertyChanged(nameof(StatesProvince));
            }
        }
        #endregion
        #region INotifyPropertyChanged implementation


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string str)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(str));
        }
        #endregion
        #region ViewModel Constructor
        public ViewModel()
        {
            AddProvince();
            AddStateDetails();
            IsHidden = false;
            HideCommand = new Command(CommandAction);
        }
        #endregion
        #region Private Methods
        private void CommandAction()
        {
            IsHidden = !IsHidden;
            OnPropertyChanged(nameof(IsHidden));
        }

        private void AddProvince()
        {
            StatesProvince.Add("South Central");
            StatesProvince.Add("Eastern");
            StatesProvince.Add("North Eastern");
            StatesProvince.Add("Northern");
            StatesProvince.Add("South Eastern");
            StatesProvince.Add("Western");
        }

        public void AddStateDetails()
        {
            State.Add(new StateDetails("California", "Sacramento ", "Sacramento", "English", "Western", 49506799));
            State.Add(new StateDetails("Florida", "Tallahassee", "Tallahassee", "English", "South Eastern", 72147030));
            State.Add(new StateDetails("California", "Sacramento ", "Sacramento", "English", "Western", 49506799));
            State.Add(new StateDetails("Florida", "Tallahassee", "Tallahassee", "English", "South Eastern", 72147030));
            State.Add(new StateDetails("Texas", "Austin", "Austin", "English", "South Central", 61095297));
            State.Add(new StateDetails("New Jersey", "Trenton", "Trenton", "English", "North Eastern", 6864602));
            State.Add(new StateDetails("Texas", "Austin", "Austin", "English", "South Central", 61095297));
            State.Add(new StateDetails("New Jersey", "Trenton", "Trenton", "English", "North Eastern", 6864602));
            State.Add(new StateDetails("California", "Sacramento ", "Sacramento", "English", "Western", 49506799));
            State.Add(new StateDetails("Florida", "Tallahassee", "Tallahassee", "English", "South Eastern", 72147030));
            State.Add(new StateDetails("Texas", "Austin", "Austin", "English", "South Central", 61095297));
            State.Add(new StateDetails("New Jersey", "Trenton", "Trenton", "English", "North Eastern", 6864602));
        }

    }

}
#endregion

