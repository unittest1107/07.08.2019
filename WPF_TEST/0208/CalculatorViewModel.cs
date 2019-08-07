using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace _0208
{
    public class CalculatorViewModel
    {
        public ICommand AddCommand { get; set; }

        public int NumberA { get; set; }

        public CalculatorViewModel()
        {
            NumberA = 12;
            AddCommand = new DelegateCommand(() =>
            {
                MessageBox.Show(NumberA.ToString());
            }, () =>
            {
                return true;
            });
            AddCommand.Execute
        }

        public int Add(int a, int b)
        {
            return a + b;
        }
    }
}
