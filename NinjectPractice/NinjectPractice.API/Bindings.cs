using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;

namespace NinjectPractice.API
{
    public class Bindings : NinjectModule
    {
        public override void Load()
        {
            var rng = new Random();
            var randomNumber = rng.Next();

            if (randomNumber%3 == 0)
                Bind<ISender>().To<Email>();
            if (randomNumber%3 == 1)
                Bind<ISender>().To<TextMessage>();
            if (randomNumber%3 == 2)
                Bind<ISender>().To<Whatsapp>();
        }
    }
}
