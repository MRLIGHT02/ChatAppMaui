namespace ChatMaui
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1NNaF5cXmBCe0x3Q3xbf1x1ZFBMZV9bQHJPMyBoS35Rc0VmWXZedXFWQmRZWEx1VEBU");
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }
    }
}