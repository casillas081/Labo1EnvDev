using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo1Pupil
{
    class Activity
    {
        private string title;
        private bool compulsory;

        public string Title { get => title; set => title = value; }

        public bool Compulsory { get => compulsory; set => compulsory = value; }

        public Activity(string title, bool compulsory)
        {
            Title = title;
            this.Compulsory = compulsory;
        }

        public string LibelleActivity()
        {
            return (Compulsory) ? Title + " (obligatoire)" : Title;
        }

        public Activity(string title) :this(title,true)
        {}
    }
}
