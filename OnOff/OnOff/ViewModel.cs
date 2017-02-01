using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace CommandPattern
{
    class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string[] commandnames = { "Light On", "Light Off", "TV On", "TV Off", "Com Fix", "Com Off", "Watch Movie", "End Movie" };
        private string recent = "none";
        private List<string> commandlist = new List<string>();

        public string[] CommandNames
        {
            get { return commandnames; }
            set
            {
                commandnames = value;
                var handler = this.PropertyChanged;
                if (handler != null)
                {
                    handler(this, new PropertyChangedEventArgs("CommandNames"));
                }
            }
        }

        public string Recent
        {
            get { return recent; }
            set
            {
                recent = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Recent"));
            }
        }

        public List<String> CommandList
        {
            get { return commandlist; }
            set
            {
                commandlist = value;
                var handler = this.PropertyChanged;
                if (handler != null)
                {
                    handler(this, new PropertyChangedEventArgs("CommandList"));
                }
            }
        }

        public ICommand LightCommand { get; set; }
        public ICommand TVCommand { get; set; }
        public ICommand ComCommand { get; set; }
        public ICommand MovieCommand { get; set; }

        public ViewModel()
        {
            LightCommand = new RelayCommand<object>(Lightcommand);
            TVCommand = new RelayCommand<object>(TVcommand);
            ComCommand = new RelayCommand<object>(Comcommand);
            MovieCommand = new RelayCommand<object>(Moviecommand);
        }

        private void Moviecommand(object obj)
        {
            Light l = new Light();
            TV t = new TV();
            Facade f = new Facade(l, t);
            string flag;

            if (obj is string)
                flag = obj as string;
            else
                flag = string.Empty;

            CommandList.Add(flag);

            switch (flag)
            {
                case "on":
                    f.watchMovie();
                    Recent = "Watch Movie";
                    break;
                case "off":
                    f.endMovie();
                    Recent = "End Movie";
                    break;
            }
        }

        private void Comcommand(object obj)
        {
            Computer com = new Computer();
            IProducts comAdapt = new ComputerAdapter(com);
            string flag;

            if (obj is string)
                flag = obj as string;
            else
                flag = string.Empty;

            CommandList.Add(flag);

            switch (flag)
            {
                case "on":
                    comAdapt.on();
                    Recent = "Com fix";
                    break;
                case "off":
                    comAdapt.off();
                    Recent = "Com off";
                    break;
            }
        }

        private void Lightcommand(object obj)
        {
            IProducts l = new Light();
            string flag;

            if (obj is string)
                flag = obj as string;
            else
                flag = string.Empty;

            CommandList.Add(flag);

            switch (flag)
            {
                case "on":
                    l.on();
                    Recent = "Light on";
                    break;
                case "off":
                    l.off();
                    Recent = "Light off";
                    break;
            }
        }

        private void TVcommand(object obj)
        {
            IProducts t = new TV();
            string flag;

            if (obj is string)
                flag = obj as string;
            else
                flag = string.Empty;

            CommandList.Add(flag);

            switch (flag)
            {
                case "on":
                    t.on();
                    Recent = "TV on";
                    break;
                case "off":
                    t.off();
                    Recent = "TV off";
                    break;
            }
        }

    }
}
