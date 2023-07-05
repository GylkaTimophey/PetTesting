using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetTesting {
    internal class MainModel : BindableBase { 

        internal void ShowCalculator() {
            Calculator.Calculator calculator = new Calculator.Calculator();
            calculator.ShowDialog();
        }

    }
}
