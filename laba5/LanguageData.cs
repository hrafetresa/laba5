using System;

namespace WindowsFormsApp1
{
    public class LanguageData
    {
        private string name;
        private int devs;
        private int projects;

        public LanguageData(string name, int devs, int projects)
        {
            this.name = name;
            this.devs = devs;
            this.projects = projects;
        }

        public string Name => name;
        public int Devs => devs;
        public int Projects => projects;
        public double Index => devs > 0 ? (double)projects / devs : 0;
    }
}
