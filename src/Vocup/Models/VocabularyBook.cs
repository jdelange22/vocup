﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Vocup.Models
{
    public class VocabularyBook : INotifyPropertyChanged
    {
        private string _filePath;
        private string _vhrCode;
        private string _motherTongue;
        private string _foreignLang;
        private PracticeMode _practiceMode;
        private bool _unsafedChanges;

        public VocabularyBook()
        {
            var words = new ObservableCollection<VocabularyWord>();
            words.CollectionChanged += OnCollectionChanged;
            Words = words;
        }

        public string FilePath
        {
            get => _filePath;
            set { _filePath = value; OnPropertyChanged(); }
        }
        public string VhrCode
        {
            get => _vhrCode;
            set { _vhrCode = value; OnPropertyChanged(); }
        }
        public string MotherTongue
        {
            get => _motherTongue;
            set { _motherTongue = value; OnPropertyChanged(); }
        }
        public string ForeignLang
        {
            get => _foreignLang;
            set { _foreignLang = value; OnPropertyChanged(); }
        }
        public PracticeMode PracticeMode
        {
            get => _practiceMode;
            set { _practiceMode = value; OnPropertyChanged(); }
        }
        public bool UnsavedChanges
        {
            get => _unsafedChanges;
            set { _unsafedChanges = value; OnPropertyChanged(); }
        }
        public IList<VocabularyWord> Words { get; }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public event NotifyCollectionChangedEventHandler CollectionChanged;

        private void OnCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            CollectionChanged?.Invoke(sender, e);
        }

        public void GenerateVhrCode()
        {
            // No need for RNGCryptoServiceProvider here because this is not security critical.
            int number1 = '0', number2 = '9';
            int bigLetter1 = 'A', bigLetter2 = 'Z';
            int smallLetter1 = 'a', smallLetter2 = 'z';

            Random random = new Random();
            char[] code = new char[24];

            do
            {

                int i = 0;
                while (i < code.Length)
                {
                    int character = random.Next(number1, smallLetter2);
                    if ((character >= number1 && character <= number2) ||
                        (character >= bigLetter1 && character <= bigLetter2) ||
                        (character >= smallLetter1 && character <= smallLetter2))
                    {
                        code[i] = (char)character;
                        i++;
                    }
                }

            } while (File.Exists(Path.Combine(Properties.Settings.Default.path_vhr, code + ".vhr")));

            VhrCode = new string(code);
        }
    }
}
