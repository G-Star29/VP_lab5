using System;
using System.Collections.Generic;
using System.Text;
using System.Reactive;
using ReactiveUI;
using lab5.Models;

namespace lab5.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {

        string text;
        public string Text
        {
            get => text;
            set => this.RaiseAndSetIfChanged(ref text, value);
        }
        string regular;

        public string Pattern
        {
            get => regular;
            set => this.RaiseAndSetIfChanged(ref regular, value);
        }
        string result;
        public string RegularResult
        {
            get => result;
            set => this.RaiseAndSetIfChanged(ref result, value); 
        }
        public string? FindRegular()=>RegexFunc.FindRegexInText(text, regular);

    }
}
