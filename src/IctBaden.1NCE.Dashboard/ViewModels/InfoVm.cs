using IctBaden.Api1NCE;
// ReSharper disable UnusedType.Global
// ReSharper disable UnusedMember.Global

namespace IctBaden._1NCE.Dashboard.ViewModels
{
    public class InfoVm
    {
        public string LibraryVersion => 
            typeof(DefaultUrls).Assembly.GetName().Version.ToString();
    }
}