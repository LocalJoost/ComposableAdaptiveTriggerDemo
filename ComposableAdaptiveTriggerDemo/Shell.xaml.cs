using Windows.UI.Xaml.Controls;
using Template10.Services.NavigationService;

namespace ComposableAdaptiveTriggerDemo
{
  /// <summary>
  /// An empty page that can be used on its own or navigated to within a Frame.
  /// </summary>
  public sealed partial class Shell : Page
  {
    public Shell(INavigationService navigationService)
    {
      this.InitializeComponent();
      Menu.NavigationService = navigationService;
    }
  }
}
