using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TinyIoC.Tests.PlatformTestSuite;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237

namespace WinRT2
{
    /// <summary>
    /// A basic page that provides characteristics common to most applications.
    /// </summary>
    public sealed partial class MainPage : WinRT2.Common.LayoutAwarePage
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void GoButton_Click(object sender, RoutedEventArgs e)
        {
            var logger = new StringLogger();
            var tests = new PlatformTests(logger);
            int testsRun, testsPassed, testsFailed;
            tests.RunTests(out testsRun, out testsPassed, out testsFailed);
            Results.Text = String.Format("{0} Run, {1} Passed, {2} Failed", testsRun, testsPassed, testsFailed);
            ResultsBox.Text = logger.Log;
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Exit();
        }
    }
}
