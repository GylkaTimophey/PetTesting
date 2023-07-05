using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetTesting {
    internal class MainViewModel : BindableBase{

        MainModel model = new MainModel();

        internal MainViewModel() {
            ShowCalculatorCommand = new DelegateCommand(model.ShowCalculator);
        }

        public DelegateCommand ShowCalculatorCommand { get; set; }

    }
}
