using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetTesting.Calculator {
    internal class CalculatorViewModel : BindableBase {

        CalculatorModel model = new CalculatorModel();

        private int number1;
        private int number2;

        public string Number1 {
            get {
                return number1.ToString();
            }
            set {
                Int32.TryParse(value, out number1);
                RaisePropertyChanged("Number3");
            }
        }
        public string Number2 {
            get {
                return number2.ToString();
            }
            set {
                Int32.TryParse(value, out number2);
                RaisePropertyChanged("Number3");
            }
        }
        public string Number3 {
            get {
                return model.Sum(number1, number2).ToString();
            }
        }
    }
}
