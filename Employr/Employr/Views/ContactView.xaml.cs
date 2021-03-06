﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Employr.ViewModels;
using Xamarin.Forms;

namespace Employr.Views
{
    public partial class ContactView : ContentPage, IIntroAnimation
    {
        private bool _appeared = false;

        public ContactView()
        {
            BindingContext = new ContactViewModel();
            InitializeComponent();

            AnimationUtilities.InitializeAppear(_twitterWhiteLogo, _twitterText, 
                _linkedinWhiteLogo, _linkedinText, _emailLogo, _emailText, _githubLogo, _githubText);
        }

        public void HandleCodeViewButtonPressed(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CodeView(new Uri("http://i.imgur.com/XNCNxYL.png")));
        }

        public void RunIntroAnimations()
        {
            if (!_appeared)
            {
                AnimationUtilities.FeatherIn(_twitterWhiteLogo, _twitterText,
                _linkedinWhiteLogo, _linkedinText, _emailLogo, _emailText, _githubLogo, _githubText);
                _appeared = true;
            }
        }
    }
}
