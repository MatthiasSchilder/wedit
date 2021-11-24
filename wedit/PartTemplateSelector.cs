using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using wedit.ViewModels;

namespace wedit
{
    public class PartTemplateSelector : DataTemplateSelector
    {
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            FrameworkElement elemnt = container as FrameworkElement;
            
            if (item is ConnectorViewModel)
            {
                return elemnt.FindResource("ConnectorDataTemplate") as DataTemplate;
            }
            else
            {
                return elemnt.FindResource("ItemDataTemplate") as DataTemplate;
            }
        }
    }
}
