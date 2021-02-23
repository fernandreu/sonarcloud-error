using System.Windows;
using Generators;

namespace WpfDemo
{
    public partial class DemoViewModel
    {
        [GenerateCommand]
        private void ExecuteTest()
        {
            MessageBox.Show("Executing test method");
        }
    }
}
