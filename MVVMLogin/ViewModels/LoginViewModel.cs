﻿using System;
using System.ComponentModel; // LIBRERIA
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVMLogin.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        public Action DisplayInvalidLoginPrompt;
        public event PropertyChangedEventHandler PropertyChanged = delegate {	};
        private string email;
        public string Email
        {
            get { return email; }
            set { email = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Email"));

            }
        }

        private string password;
        public string Password
        {
            get { return password; }
            set { password = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Password"));
            }
        }

        public ICommand SubmitCommand { protected set; get; }
        public LoginViewModel()
        {
            SubmitCommand = new Command(onSubmit);
        }
        public void onSubmit()
        {
            if (email != "eduard2@yoo.com" || password != "12345" )
            {
                DisplayInvalidLoginPrompt();
            }
        }
    }
}
