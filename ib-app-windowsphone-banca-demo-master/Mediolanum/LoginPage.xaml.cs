using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Mediolanum
{
    public partial class LoginPage : ContentPage, INotifyPropertyChanged
    {
        private string mainText;

        public string MainText
        {
            get { return mainText; }
            set
            {
                mainText = value;
                OnPropertyChanged("MainText");
            }
        }

        public LoginPage()
        {
            InitializeComponent();
        }
    }
}
