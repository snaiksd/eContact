using eContact.Plugin;
using eContact.Plugin.Core;
using eContact.Plugin.Google;
using eContact.Plugin.PTI;
using Unity;

namespace eContact.Business.Helpers
{
    public static class SourceFactory
    {
        private static IUnityContainer unityContainer = null;
        public static BaseSource Create(string Type)
        {
            // Design pattern :- Lazy loading. Eager loading
            if (unityContainer == null)
            {
                unityContainer = new UnityContainer();

                unityContainer.RegisterType<BaseSource, ContactsSource>("Internal");
                unityContainer.RegisterType<BaseSource, GoogleContactSource>("Google");
                unityContainer.RegisterType<BaseSource, PTIContactsSource>("PTI");
                unityContainer.RegisterType<BaseSource, AdvertisementSource>("Advert");
            }

            //Design pattern :-  RIP Replace If with Poly
            BaseSource factorybase = unityContainer.Resolve<BaseSource>(Type);
            return factorybase;
        }
    }
}
