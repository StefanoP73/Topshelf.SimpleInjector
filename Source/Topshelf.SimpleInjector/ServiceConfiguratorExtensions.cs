﻿using Topshelf.ServiceConfigurators;

namespace Topshelf.SimpleInjector
{
    public static class ServiceConfiguratorExtensions
    {
        #region Public Static Methods

        public static ServiceConfigurator<T> ConstructUsingSimpleInjector<T>(this ServiceConfigurator<T> configurator) where T : class
        {
            configurator.ConstructUsing(serviceFactory => SimpleInjectorHostBuilderConfigurator.Container.GetInstance<T>());
            return configurator;
        }

        #endregion
    }
}