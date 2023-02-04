using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMTeplateCommunityToolkit.ViewModels;
[ObservableObject]
public partial class MainWindowViewModel
{
    [ObservableProperty]
    private string dummyText;

	public MainWindowViewModel()
	{
        DummyText = "Ein Platzhalter";
    }

}
