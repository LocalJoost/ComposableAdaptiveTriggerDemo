using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Template10.Common;
using Template10.Services.NavigationService;

namespace ComposableAdaptiveTriggerDemo
{
  /// <summary>
  /// Provides application-specific behavior to supplement the default Application class.
  /// </summary>
  sealed partial class App
  {
    /// <summary>
    /// Initializes the singleton application object.  This is the first line of authored code
    /// executed, and as such is the logical equivalent of main() or WinMain().
    /// </summary>
    public App()
    {
      this.InitializeComponent();
    }

    public override Task OnInitializeAsync(IActivatedEventArgs args)
    {
      var nav = NavigationServiceFactory(BootStrapper.BackButton.Attach, BootStrapper.ExistingContent.Include);
      Window.Current.Content = new Shell(nav);
      return base.OnInitializeAsync(args);
    }

    public override Task OnStartAsync(StartKind startKind, IActivatedEventArgs args)
    {
      NavigationService.Navigate(typeof(Default));
      return Task.CompletedTask;
    }
  }
}
